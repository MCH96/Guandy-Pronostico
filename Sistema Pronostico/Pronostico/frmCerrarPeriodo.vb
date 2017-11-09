Public Class frmCerrarPeriodo

    Dim Obj As PROPeriodoBO


    Private Sub Validar()

        If Obj.IsNew = True Then Throw New Exception("Ingrese el Período.")
        If Obj.PeriodoCerrado = False Then
            If Obj.Mes1 = False OrElse Obj.Mes2 = False OrElse Obj.Mes3 = False OrElse Obj.Mes4 = False OrElse Obj.Mes5 = False OrElse Obj.Mes6 = False OrElse Obj.Mes7 = False OrElse Obj.Mes8 = False OrElse Obj.Mes9 = False OrElse Obj.Mes10 = False OrElse Obj.Mes11 = False OrElse Obj.Mes12 = False Then Throw New Exception("Hacen falta meses por Cerrar del Período.")
        End If

    End Sub


    Private Sub Limpiar()

        Obj = New PROPeriodoBO
        Me.txtPeriodo.Tag = Nothing
        Me.txtPeriodo.Text = String.Empty
        Me.txtEstado.Text = String.Empty
        Me.txtCerradoPor.Text = String.Empty
        Me.txtFechaCierre.Text = String.Empty
        Me.txtComentario.Text = String.Empty
        Me.txtComentarioCambioEstado.Text = String.Empty

    End Sub


    Private Sub LoadData()

        Try

            Me.txtPeriodo.Tag = Obj.IdPeriodo
            Me.txtPeriodo.Text = Obj.IdPeriodo
            If Obj.PeriodoCerrado = True Then
                Me.txtEstado.Text = "Cerrado"
                Me.lblComentarioEstado.Text = "Comentario" & vbCrLf & "Cierre:"
                Me.lblComentarioCambioEstado.Text = "Comentario" & vbCrLf & "Apertura:"
                Dim lTable As DataTable = GetDataTable(String.Format("Select top 1 Comentario From BIT_PeriodoCierre Where IdPeriodo={0} and CierraPeriodo=1 Order By FechaHoraModificacion desc", Obj.IdPeriodo), "Datos")
                If lTable.Rows.Count > 0 Then Me.txtComentario.Text = lTable.Rows(0)(0)
                Me.cmdCerrarPeriodo.Caption = "Aperturar Período"
            Else
                Me.txtEstado.Text = "Abierto"
                Me.lblComentarioEstado.Text = "Comentario" & vbCrLf & "Apertura:"
                Me.lblComentarioCambioEstado.Text = "Comentario" & vbCrLf & "Cierre:"
                Dim lTable As DataTable = GetDataTable(String.Format("Select top 1 Comentario From BIT_PeriodoCierre Where IdPeriodo={0} and AbrePeriodo=1 Order By FechaHoraModificacion desc", Obj.IdPeriodo), "Datos")
                If lTable.Rows.Count > 0 Then Me.txtComentario.Text = lTable.Rows(0)(0)
                Me.cmdCerrarPeriodo.Caption = "Cerrar Período"
            End If
            Me.txtCerradoPor.Text = New SECUsuarioBO(gConnectionString, Obj.PeriodoCerradoPor).NombreUsuario
            Me.txtFechaCierre.Text = String.Format("{0:dd/MMM/yyyy}", Obj.PeriodoFechaCierre)
            Me.txtComentarioCambioEstado.Text = String.Empty

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


    Private Sub cmdCerrarPeriodo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCerrarPeriodo.ItemClick

        Try
            If Not CheckAccess(gConnectionString, gUsuario, Me.Name, 4) Then
                If Not CheckAccess(gConnectionString, gUsuario, "", 1) Then
                    MsgBox("Sin acceso para ejecutar la opción", MsgBoxStyle.Critical, "Seguridad del sistema")
                    Exit Sub
                End If
            End If

            Obj = New PROPeriodoBO(gConnectionString, Me.txtPeriodo.Text)
            If Obj.EnviadoProtean = True Then
                If MessageBox.Show("El Período ya se encuentra enviado. ¿Está seguro(a) de aperturar el Período?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
            Else
                If MessageBox.Show(String.Format("¿Está seguro(a) de {0} el Período?", IIf(Obj.PeriodoCerrado = True, "Aperturar", "Cerrar")), Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub
            End If

            Call Me.Validar()
            Me.Cursor = Cursors.WaitCursor

            If Obj.PeriodoCerrado = False Then
                Obj.PeriodoCerrado = True
                Obj.PeriodoCerradoPor = gUsuario
                Obj.PeriodoFechaCierre = Now
                PeriodoBL.AperturaCierreMesPeriodo(gConnectionString, Obj, gUsuario, False, False, 0, True, False, Me.txtComentarioCambioEstado.Text)
            Else
                Obj.PeriodoCerrado = False
                Obj.PeriodoCerradoPor = Nothing
                Obj.PeriodoFechaCierre = Nothing
                Obj.EnviadoProtean = False
                Obj.EnviadoProteanPor = Nothing
                Obj.EnviadoProteanFecha = Nothing
                PeriodoBL.AperturaCierreMesPeriodo(gConnectionString, Obj, gUsuario, False, False, 0, False, True, Me.txtComentarioCambioEstado.Text)
            End If

            Me.Cursor = Cursors.Default
            Call Me.Limpiar()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error al intentar grabar los datos " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub txtPeriodo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtPeriodo.EditorButtonClick

        Call Me.Limpiar()

        Dim iDatos As DataTable = GetDataTable("Select IdPeriodo as [Período] From PRO_Periodo Order By IdPeriodo", "Busqueda")
        Dim lCodigo As Object = MostrarBuscador("Busqueda", iDatos, "Busqueda")

        If lCodigo IsNot Nothing AndAlso IsNumeric(lCodigo) Then
            Obj = New PROPeriodoBO(gConnectionString, lCodigo)
            Call Me.LoadData()
        End If

    End Sub

End Class