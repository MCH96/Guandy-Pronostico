﻿Public Class frmEnviarPeriodoProtean

    Dim Obj As PROPeriodoBO


    Private Sub Validar()

        If Obj.IsNew = True Then Throw New Exception("Ingrese el Período.")

    End Sub


    Private Sub Limpiar()

        Obj = New PROPeriodoBO
        Me.txtPeriodo.Tag = Nothing
        Me.txtPeriodo.Text = String.Empty
        Me.txtEstado.Text = String.Empty
        Me.txtCerradoPor.Text = String.Empty
        Me.txtFechaCierre.Text = String.Empty
        Me.txtComentario.Text = String.Empty

    End Sub


    Private Sub LoadData()

        Try

            Me.txtPeriodo.Tag = Obj.IdPeriodo
            Me.txtPeriodo.Text = Obj.IdPeriodo
            Me.txtEstado.Text = "Cerrado"
            Dim lTable As DataTable = GetDataTable(String.Format("Select top 1 Comentario From BIT_PeriodoCierre Where IdPeriodo={0} and AbrePeriodo=1", Obj.IdPeriodo), "Datos")
            If lTable.Rows.Count > 0 Then Me.txtComentario.Text = lTable.Rows(0)(0)
            Me.txtCerradoPor.Text = New SECUsuarioBO(gConnectionString, Obj.PeriodoCerradoPor).NombreUsuario
            Me.txtFechaCierre.Text = String.Format("{0:dd/MMM/yyyy}", Obj.PeriodoFechaCierre)

        Catch ex As Exception
            MsgBox("Error al intentar obtener los datos " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub cmdCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCerrar.ItemClick

        Me.Close()

    End Sub


    Private Sub frmCerrarPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Me.Limpiar()

    End Sub


    Private Sub cmdEnviarPeriodo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdEnviarPeriodo.ItemClick

        Dim lLlave As Guid = Guid.NewGuid

        Try
            If Not CheckAccess(gConnectionString, gUsuario, Me.Name, 4) Then
                MsgBox("Sin acceso para ejecutar la opción", MsgBoxStyle.Critical, "Seguridad del sistema")
                Exit Sub
            End If

            Obj = New PROPeriodoBO(gConnectionString, Me.txtPeriodo.Text)
            If MessageBox.Show("¿Está seguro(a) de Enviar el Período a Protean?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

            Call Me.Validar()
            Me.Cursor = Cursors.WaitCursor

            PeriodoBL.EnviarPeriodoProtean(gConnectionString, gConnectionStringProtean, Obj, gUsuario, lLlave)
            Me.Cursor = Cursors.Default

            MsgBox("Pronóstico enviado con éxito.", MsgBoxStyle.Information, Me.Text)
            Call Me.Limpiar()
        Catch ex As Exception
            BOGeneral.ExecuteSQL(gConnectionString, String.Format("Delete TEMP_PeriodoEnvioProtean Where IdLlave='{0}'", lLlave))
            Me.Cursor = Cursors.Default
            MsgBox("Error al intentar grabar los datos " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub txtPeriodo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtPeriodo.EditorButtonClick

        Call Me.Limpiar()

        Dim iDatos As DataTable = GetDataTable("Select IdPeriodo as [Período] From PRO_Periodo Where PeriodoCerrado = 1 and EnviadoProtean = 0 Order By IdPeriodo", "Busqueda")
        Dim lCodigo As Object = MostrarBuscador("Busqueda", iDatos, "Busqueda")

        If lCodigo IsNot Nothing AndAlso IsNumeric(lCodigo) Then
            Obj = New PROPeriodoBO(gConnectionString, lCodigo)
            Call Me.LoadData()
        End If

    End Sub

End Class