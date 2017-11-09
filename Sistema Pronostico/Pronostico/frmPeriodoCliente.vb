﻿Public Class frmPeriodoCliente


    Dim Obj As PROPeriodoBO


    Private Sub Limpiar()

        Me.dtpPeriodo.Value = Now.Date
        Obj = New PROPeriodoBO(gConnectionString, Me.dtpPeriodo.Value.Year)
        Call Me.CargarGrid()

    End Sub


    Private Sub CargarGrid()

        Try

            Me.ugData.DataSource = Me.udsData

            Dim lTable As DataTable = GetDataTable(String.Format("Select distinct IdCliente From PRO_PeriodoVendedorDetalle Where IdPeriodo = {0}", Me.dtpPeriodo.Value.Year), "Datos")

            Dim lTableClientes As DataTable = GetDataTableProtean("Select ObjectID_Socio_Negcio as IdCliente, Socio_Negocio as Codigo, Nombre_Socio_Negocio as Cliente From view_Cubo_SocioxPais", "Clientes")

            Dim lTableFinal As New DataTable("Datos")
            lTableFinal.Columns.Add("IdCliente", GetType(Integer))
            lTableFinal.Columns.Add("Codigo", GetType(String))
            lTableFinal.Columns.Add("Cliente", GetType(String))
            lTableFinal.Columns.Add("Eliminar", GetType(String))

            For Each lRow As DataRow In lTable.Rows
                Dim lRowCliente As DataRow = (From b In lTableClientes.AsEnumerable Where b.Field(Of Integer)("IdCliente") = lRow("IdCliente")).FirstOrDefault
                Dim lRowData As DataRow = lTableFinal.NewRow
                lRowData("IdCliente") = lRow("IdCliente")
                lRowData("Codigo") = lRowCliente("Codigo")
                lRowData("Cliente") = lRowCliente("Cliente")
                lRowData("Eliminar") = "Eliminar"
                lTableFinal.Rows.Add(lRowData)
            Next

            Me.ugData.DataSource = lTableFinal
            Me.ugData.DataBind()

            Me.ugData.DisplayLayout.Bands(0).Columns("Eliminar").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button

        Catch ex As Exception
            MsgBox("Error al intentar obtener los datos " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub cmdCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCerrar.ItemClick

        Me.Close()

    End Sub


    Private Sub frmPeriodoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Me.Limpiar()

    End Sub


    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged

        Obj = New PROPeriodoBO(gConnectionString, Me.dtpPeriodo.Value.Year)
        Call Me.CargarGrid()

    End Sub


    Private Sub ugData_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugData.ClickCellButton

        Try

            If Obj.PeriodoCerrado = True Then
                MsgBox("El Perído ya se Encuentra Cerrado, no se puede eliminar el cliente.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            ElseIf PROPeriodoVendedorDetalleBO.GetAllQuery(gConnectionString, String.Format("Select top 1 * From PRO_PeriodoVendedor Where IdPeriodo = {0} and (Mes1 = 1 or Mes2 = 1 or Mes3 = 1 or Mes4 = 1 or Mes5 = 1 or Mes6 = 1 or Mes7 = 1 or Mes8 = 1 or Mes9 = 1 or Mes10 = 1 or Mes11 = 1 or Mes12 = 1)", Me.dtpPeriodo.Value.Year)).Count > 0 Then
                MsgBox("El Perído ya cuenta con meses cerrados, no se puede eliminar el cliente.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End If

            If MessageBox.Show("¿Está seguro(a) de Eliminar el Registro Seleccionado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            PeriodoBL.EliminarCliente(gConnectionString, Me.dtpPeriodo.Value.Year, e.Cell.Row.Cells("IdCliente").Value)
            Call Me.CargarGrid()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error al eliminar recurso: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub lnkAgregarCliente_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAgregarCliente.LinkClicked

        Try

            If Obj.IsNew = True Then
                MsgBox("El Perído no se encuentra registrado.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            ElseIf Obj.PeriodoCerrado = True Then
                MsgBox("El Perído ya se Encuentra Cerrado, no se pueden ingresar más clientes.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            ElseIf PROPeriodoVendedorDetalleBO.GetAllQuery(gConnectionString, String.Format("Select top 1 * From PRO_PeriodoVendedor Where IdPeriodo = 0 and (Mes1 = 1 or Mes2 = 1 or Mes3 = 1 or Mes4 = 1 or Mes5 = 1 or Mes6 = 1 or Mes7 = 1 or Mes8 = 1 or Mes9 = 1 or Mes10 = 1 or Mes11 = 2 or Mes12 = 1)", Me.dtpPeriodo.Value.Year)).Count > 0 Then
                MsgBox("El Perído ya cuenta con meses cerrados, no se pueden agregar más clientes.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End If

            frmBuscadorCliente.ShowDialog(Me)

            If i_LlaveBusqueda IsNot Nothing AndAlso IsNumeric(i_LlaveBusqueda) = True Then
                If PROPeriodoVendedorDetalleBO.GetAllQuery(gConnectionString, String.Format("Select top 1 * From PRO_PeriodoVendedorDetalle Where IdPeriodo = {0} and IdCliente = {1}", Me.dtpPeriodo.Value.Year, CInt(i_LlaveBusqueda))).Count > 0 Then
                    MsgBox("El Cliente ya se encuentra registrado.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If

                Dim lTable As DataTable = GetDataTableProtean(String.Format("Select top 1 * From view_Cubo_SocioxVendedor Where ObjectID_Socio_Negcio = {0}", CInt(i_LlaveBusqueda)), "Datos")
                If lTable.Rows.Count = 0 Then Throw New Exception("Cliente sin Vendedor Asignado.")

                PeriodoBL.GuardarCliente(gConnectionString, gConnectionStringProtean, Me.dtpPeriodo.Value.Year, CInt(i_LlaveBusqueda))

                Call Me.CargarGrid()

            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error al agregar recurso: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub

End Class