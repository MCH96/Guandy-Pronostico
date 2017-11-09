Public Class frmBuscadorPerfilMercado


    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        If Not Grid.Rows.Count = 1 Then
            i_LlaveBusqueda = Grid.GetData(Grid.Row, 0)
            i_LlaveBusqueda2 = Grid.GetData(Grid.Row, 1)
            i_LlaveBusqueda3 = Grid.GetData(Grid.Row, 2)
            Me.Close()
        End If

    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        i_LlaveBusqueda = Nothing
        Me.Close()

    End Sub


    Private Sub Grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick

        If Not Grid.Rows.Count = 1 Then
            i_LlaveBusqueda = Grid.GetData(Grid.Row, 0)
            i_LlaveBusqueda2 = Grid.GetData(Grid.Row, 1)
            i_LlaveBusqueda3 = Grid.GetData(Grid.Row, 2)
            Me.Close()
        End If

    End Sub


    Private Sub frmBuscadorPerfilMercado_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Me.Dispose()

    End Sub


    Private Sub frmBuscadorRecurso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        cmdLimpiar_Click(Nothing, Nothing)

    End Sub


    Private Sub cmdBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        Try
            Dim lWhere As String = "Where T0.EffDatesStart <= GetDate() AND T0.EffDatesEnd >= GetDate()"

            If String.IsNullOrEmpty(Me.txtCodigo.Text) = False Then lWhere = String.Format("{0} and T0.MktProf  like '%{1}%'", lWhere, Me.txtCodigo.Text)

            If String.IsNullOrEmpty(Me.txtDescripcion.Text) = False Then lWhere = String.Format("{0} and T0.Description  like '%{1}%'", lWhere, Me.txtDescripcion.Text)

            Me.Grid.DataSource = GetDataTableProtean(String.Format("Select T0.ObjectID,T0.MktProf as 'Perfil de Mercado', T0.Description as 'Descripción', T0.EffDatesStart [Inicio Efectividad], T0.EffDatesEnd [Fin Efectividad] From coMarketProfile as T0 {0} Order By T0.MktProf", lWhere), "Busqueda")
            Me.Grid.Cols(0).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Me.Grid.DataSource = Nothing
        End Try

    End Sub


    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click

        i_LlaveBusqueda = Nothing
        i_LlaveBusqueda2 = Nothing
        i_LlaveBusqueda3 = Nothing
        Me.txtCodigo.Text = String.Empty
        Me.txtDescripcion.Text = String.Empty

    End Sub

End Class