﻿Public Class frmPeriodoClienteDetalle


    Dim Obj As PROPeriodoBO


    Private Sub Limpiar()

        Me.dtpPeriodo.Value = Now.Date
        Obj = New PROPeriodoBO(gConnectionString, Me.dtpPeriodo.Value.Year)
        Me.txtCliente.Tag = Nothing
        Me.txtCliente.Text = String.Empty
        Me.ugData.DataSource = Me.udsData

    End Sub


    Private Sub CargarGrid()

        Try

            Dim lTable As DataTable = GetDataTable(String.Format("Select IdProducto From PRO_PeriodoVendedorDetalle Where IdPeriodo = {0} and IdCliente = {1}", Me.dtpPeriodo.Value.Year, Me.txtCliente.Tag), "Datos")

            Dim lTableProductos As DataTable = GetDataTableProtean(String.Format("Select distinct T2.RescObjectID as IdProducto,T2.Resc as Codigo,r.Description as Recurso From coMarketProfile as T0 inner join coTPAssignment as T1 on T1.ParentObjectID = T0.ObjectID and T1.ParentClassID = 10652 and T1.CollectionID = 1 inner join coRescAssignmen as T2 on T2.ParentObjectID = T0.ObjectID AND T2.ParentClassID = 10652 and T2.CollectionID = 1 inner join fdBasResc as r on T2.RescObjectID=r.ObjectID Where T0.EffDatesStart <= {3}ts '{0}-{1}-{2} 23:59:59'{4} and T0.EffDatesEnd >= {3}ts '{0}-{1}-{2} 00:00:00'{4} and T1.TPObjectID = {5}", Now.Year, Now.Month.ToString.PadLeft(2, "0"), Now.Day.ToString.PadLeft(2, "0"), "{", "}", Me.txtCliente.Tag), "Datos")
            Dim lTableFinal As New DataTable("Datos")
            lTableFinal.Columns.Add("IdProducto", GetType(Integer))
            lTableFinal.Columns.Add("Codigo", GetType(String))
            lTableFinal.Columns.Add("Recurso", GetType(String))
            lTableFinal.Columns.Add("Eliminar", GetType(String))

            For Each lRow As DataRow In lTableProductos.Rows
                If (From b In lTable.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lRow("IdProducto")).Count > 0 Then
                    Dim lRowData As DataRow = lTableFinal.NewRow
                    lRowData("IdProducto") = lRow("IdProducto")
                    lRowData("Codigo") = lRow("Codigo")
                    lRowData("Recurso") = lRow("Recurso")
                    lRowData("Eliminar") = "Eliminar"
                    lTableFinal.Rows.Add(lRowData)
                End If
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


    Private Sub frmPeriodoClienteDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Me.Limpiar()

    End Sub


    Private Sub dtpPeriodo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpPeriodo.ValueChanged

        Obj = New PROPeriodoBO(gConnectionString, Me.dtpPeriodo.Value.Year)
        If Me.txtCliente.Tag IsNot Nothing Then Call Me.CargarGrid()

    End Sub


    Private Sub ugData_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugData.ClickCellButton

        Try

            If Obj.PeriodoCerrado = True Then
                MsgBox("El perído ya se encuentra cerrado, no se puede eliminar el recurso.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            ElseIf PROPeriodoVendedorDetalleBO.GetAllQuery(gConnectionString, String.Format("Select top 1 * From PRO_PeriodoVendedor Where IdPeriodo = {0} and (Mes1 = 1 or Mes2 = 1 or Mes3 = 1 or Mes4 = 1 or Mes5 = 1 or Mes6 = 1 or Mes7 = 1 or Mes8 = 1 or Mes9 = 1 or Mes10 = 1 or Mes11 = 1 or Mes12 = 1)", Me.dtpPeriodo.Value.Year)).Count > 0 Then
                MsgBox("El Perído ya cuenta con meses cerrados, no se puede eliminar el recurso.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End If

            If MessageBox.Show("¿Está seguro(a) de Eliminar el Registro Seleccionado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            PeriodoBL.EliminarProducto(gConnectionString, Me.dtpPeriodo.Value.Year, Me.txtCliente.Tag, e.Cell.Row.Cells("IdProducto").Value)
            Call Me.CargarGrid()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error al eliminar recurso: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub lnkAgregarProducto_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAgregarProducto.LinkClicked

        Try
            If String.IsNullOrEmpty(Me.txtCliente.Tag) = True Then
                MsgBox("Seleccione el Cliente.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            ElseIf Obj.IsNew = True Then
                MsgBox("El Perído no se encuentra registrado.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            ElseIf Obj.PeriodoCerrado = True Then
                MsgBox("El Perído ya se Encuentra Cerrado, no se pueden ingresar más recursos.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            ElseIf PROPeriodoVendedorDetalleBO.GetAllQuery(gConnectionString, String.Format("Select top 1 * From PRO_PeriodoVendedor Where IdPeriodo = 0 and (Mes1 = 1 or Mes2 = 1 or Mes3 = 1 or Mes4 = 1 or Mes5 = 1 or Mes6 = 1 or Mes7 = 1 or Mes8 = 1 or Mes9 = 1 or Mes10 = 1 or Mes11 = 2 or Mes12 = 1)", Me.dtpPeriodo.Value.Year)).Count > 0 Then
                MsgBox("El Perído ya cuenta con meses cerrados, no se puede agregar el recurso.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End If

            Dim iDatos As DataTable = GetDataTableProtean(String.Format("Select distinct T2.RescObjectID as IdProducto,T2.Resc as Codigo,r.Description as Recurso From coMarketProfile as T0 inner join coTPAssignment as T1 on T1.ParentObjectID = T0.ObjectID and T1.ParentClassID = 10652 and T1.CollectionID = 1 inner join coRescAssignmen as T2 on T2.ParentObjectID = T0.ObjectID AND T2.ParentClassID = 10652 and T2.CollectionID = 1 inner join fdBasResc as r on T2.RescObjectID=r.ObjectID Where T0.EffDatesStart <= {3}ts '{0}-{1}-{2} 23:59:59'{4} and T0.EffDatesEnd >= {3}ts '{0}-{1}-{2} 00:00:00'{4} and T1.TPObjectID = {5} Order By T2.Resc", Now.Year, Now.Month.ToString.PadLeft(2, "0"), Now.Day.ToString.PadLeft(2, "0"), "{", "}", Me.txtCliente.Tag), "Datos")
            Dim lCodigo As Object = MostrarBuscador("Recursos", iDatos, "Recursos", True)
            If i_LlaveBusqueda IsNot Nothing AndAlso IsNumeric(i_LlaveBusqueda) = True Then
                If PROPeriodoVendedorDetalleBO.GetAllQuery(gConnectionString, String.Format("Select top 1 * From PRO_PeriodoVendedorDetalle Where IdPeriodo = {0} and IdCliente = {1} and IdProducto = {2}", Me.dtpPeriodo.Value.Year, Me.txtCliente.Tag, CInt(lCodigo))).Count > 0 Then
                    MsgBox("El Recurso ya se encuentra registrado.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If

                PeriodoBL.GuardarRecurso(gConnectionString, Me.dtpPeriodo.Value.Year, Me.txtCliente.Tag, CInt(lCodigo))

                Call Me.CargarGrid()

            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error al agregar recurso: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub txtCliente_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtCliente.EditorButtonClick

        Me.txtCliente.Tag = Nothing
        Me.txtCliente.Text = String.Empty
        Me.ugData.DataSource = Me.udsData

        Try
            frmBuscadorCliente.pCliente = True
            frmBuscadorCliente.ShowDialog(Me)
            If i_LlaveBusqueda IsNot Nothing Then

                Dim lTable As DataTable = GetDataTableProtean(String.Format("Select distinct Vendedor From view_Cubo_SocioxVendedor Where ObjectID_Socio_Negcio = {0}", CInt(i_LlaveBusqueda)), "Datos")
                If lTable.Rows.Count = 0 Then Throw New Exception("Cliente sin Vendedor Asignado.")

                Me.txtCliente.Tag = i_LlaveBusqueda
                Me.txtCliente.Text = i_LlaveBusqueda2
                Call Me.CargarGrid()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class