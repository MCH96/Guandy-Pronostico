Public Class frmGrupoCliente


    Private Sub Limpiar()

        Me.txtCliente.Tag = Nothing
        Me.txtCliente.Text = String.Empty
        Me.ugData.DataSource = Me.udsData

    End Sub


    Private Sub CargarGrid()

        Try

            Me.ugData.DataSource = Me.udsData

            Dim lTable As DataTable = GetDataTable(String.Format("Select IdClienteHijo as IdCliente From PRO_GrupoCliente Where IdClientePadre = {0}", Me.txtCliente.Tag), "Datos")
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


    Private Sub frmGrupoCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Me.Limpiar()

    End Sub


    Private Sub ugData_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugData.ClickCellButton

        Try

            If MessageBox.Show("¿Está seguro(a) de eliminar el registro seleccionado?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            Dim Obj As New PROGrupoClienteBO(gConnectionString, Me.txtCliente.Tag, e.Cell.Row.Cells("IdCliente").Value)
            If Obj.IsNew = False Then Obj.Delete(gConnectionString)
            Call Me.CargarGrid()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error al eliminar recurso: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub lnkAgregarCliente_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAgregarClienteHijo.LinkClicked

        Try
            If Me.txtCliente.Tag Is Nothing Then
                MsgBox("Seleccione el Cliente primero.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End If

            frmBuscadorCliente.ShowDialog(Me)

            If i_LlaveBusqueda IsNot Nothing AndAlso IsNumeric(i_LlaveBusqueda) = True Then
             
                Dim lTable As DataTable = GetDataTableProtean(String.Format("Select distinct Vendedor From view_Cubo_SocioxVendedor Where ObjectID_Socio_Negcio = {0}", CInt(i_LlaveBusqueda)), "Datos")

                If lTable.Rows.Count = 0 Then
                    Throw New Exception("Cliente sin Vendedor Asignado.")
                ElseIf PROGrupoClienteBO.Exists(gConnectionString, Me.txtCliente.Tag, CInt(i_LlaveBusqueda)) = True Then
                    Throw New Exception("Cliente ya ingresado.")
                ElseIf PROGrupoClienteBO.GetAllQuery(gConnectionString, String.Format("Select top 1 * From PRO_GrupoCliente Where IdClientePadre = {0}", CInt(i_LlaveBusqueda))).Count > 0 Then
                    Throw New Exception("El cliente seleccionado ya es padre de un grupo.")
                ElseIf PROGrupoClienteBO.GetAllQuery(gConnectionString, String.Format("Select top 1 * From PRO_GrupoCliente Where IdClienteHijo = {0} and IdClientePadre <> {1}", CInt(i_LlaveBusqueda), Me.txtCliente.Tag)).Count > 0 Then
                    Throw New Exception("El cliente ya es hijo de otro grupo.")
                ElseIf Me.txtCliente.Tag = CInt(i_LlaveBusqueda) Then
                    Throw New Exception("El cliente hijo no pude ser el mismo que el padre.")
                End If

                Dim Obj As New PROGrupoClienteBO
                Obj.IdClientePadre = Me.txtCliente.Tag
                Obj.IdClienteHijo = CInt(i_LlaveBusqueda)
                Obj.CreadoPor = gUsuario
                Obj.FechaCreacion = Now
                Obj.Save(gConnectionString)

                Call Me.CargarGrid()

            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error al agregar recurso: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub txtCliente_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtCliente.EditorButtonClick

        Call Me.Limpiar()

        Try
            frmBuscadorCliente.pCliente = True
            frmBuscadorCliente.ShowDialog(Me)
            If i_LlaveBusqueda IsNot Nothing Then

                Dim lTable As DataTable = GetDataTableProtean(String.Format("Select distinct Vendedor From view_Cubo_SocioxVendedor Where ObjectID_Socio_Negcio = {0}", CInt(i_LlaveBusqueda)), "Datos")
                If lTable.Rows.Count = 0 Then Throw New Exception("Cliente sin Vendedor Asignado.")

                If PROGrupoClienteBO.GetAllQuery(gConnectionString, String.Format("Select top 1 * From PRO_GrupoCliente Where IdClienteHijo = {0}", CInt(i_LlaveBusqueda))).Count > 0 Then Throw New Exception("El cliente seleccionado ya es hijo de un grupo.")

                Me.txtCliente.Tag = i_LlaveBusqueda
                Me.txtCliente.Text = i_LlaveBusqueda2
                Call Me.CargarGrid()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class