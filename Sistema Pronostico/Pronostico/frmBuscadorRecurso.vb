Public Class frmBuscadorRecurso

    Public pWhere As String

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        If Not Grid.Rows.Count = 1 Then
            i_LlaveBusqueda = Grid.GetData(Grid.Row, 0)
            i_LlaveBusqueda2 = Grid.GetData(Grid.Row, 2)
            i_LlaveBusqueda3 = Grid.GetData(Grid.Row, 1)
            Me.Close()
        End If

    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        i_LlaveBusqueda = Nothing
        i_LlaveBusqueda2 = Nothing
        i_LlaveBusqueda3 = Nothing
        Me.Close()

    End Sub


    Private Sub Grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick

        If Not Grid.Rows.Count = 1 Then
            i_LlaveBusqueda = Grid.GetData(Grid.Row, 0)
            i_LlaveBusqueda2 = Grid.GetData(Grid.Row, 2)
            i_LlaveBusqueda3 = Grid.GetData(Grid.Row, 1)
            Me.Close()
        End If

    End Sub


    Private Sub frmBuscadorRecurso_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Me.Dispose()

    End Sub


    Private Sub frmBuscadorRecurso_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        i_LlaveBusqueda = Nothing
        i_LlaveBusqueda2 = Nothing
        i_LlaveBusqueda3 = Nothing

    End Sub


    Private Sub cmdBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        Try
            Dim lConsulta As String = String.Format("select ObjectID,resourceUK as Código,Description as Descripción from fdBasResc where ResourceUKSite = 'TROP' ")

            If String.IsNullOrEmpty(Me.txtRecurso.Text) = False Then lConsulta = String.Format("{0} and resourceUK  Like '%{1}%'", lConsulta, Me.txtRecurso.Text)
            If String.IsNullOrEmpty(Me.txtDescripcion.Text) = False Then lConsulta = String.Format("{0} and Description  Like '%{1}%'", lConsulta, Me.txtDescripcion.Text)
            If String.IsNullOrEmpty(pWhere) = False Then lConsulta = String.Format("{0} {1}", lConsulta, pWhere)
            Me.Grid.DataSource = GetDataTableProtean(String.Format("{0}", lConsulta), "Busqueda")
            Me.Grid.Cols(0).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Me.Grid.DataSource = Nothing
        End Try

    End Sub




    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click

        Me.txtRecurso.Text = String.Empty
        Me.txtDescripcion.Text = String.Empty

    End Sub

End Class