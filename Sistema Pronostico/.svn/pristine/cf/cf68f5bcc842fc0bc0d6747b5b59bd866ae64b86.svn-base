Public Class frmBuscadorCliente


    Public pCliente As Boolean

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        If Not Grid.Rows.Count = 1 Then
            i_LlaveBusqueda = Grid.GetData(Grid.Row, 0)
            i_LlaveBusqueda2 = Grid.GetData(Grid.Row, 2)
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
            i_LlaveBusqueda2 = Grid.GetData(Grid.Row, 2)
            Me.Close()
        End If

    End Sub


    Private Sub frmBuscadorCliente_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        Me.Dispose()

    End Sub


    Private Sub frmBuscadorCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        i_LlaveBusqueda = Nothing

    End Sub


    Private Sub cmdBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdBuscar.Click

        Try
            Dim lwhere2 As String = "Where 1=1"

            If String.IsNullOrEmpty(Me.txtCodigo.Text) = False Then
                lwhere2 = String.Format("{0} and  Socio_Negocio = '{1}'", lwhere2, Me.txtCodigo.Text)
            End If

            If String.IsNullOrEmpty(Me.txtNombre.Text) = False Then
                lwhere2 = String.Format("{0} and  Nombre_Socio_Negocio like '%{1}%'", lwhere2, Me.txtNombre.Text)
            End If

            Me.Grid.DataSource = GetDataTableProtean(String.Format("Select ObjectID_Socio_Negcio as ID, Socio_Negocio as Código, Nombre_Socio_Negocio as Nombre, Pais From view_Cubo_SocioxPais {0} ", lwhere2), "Busqueda")
            Me.Grid.Cols(0).Visible = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            Me.Grid.DataSource = Nothing
        End Try

    End Sub


    Private Sub cmdLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLimpiar.Click

        Me.txtCodigo.Text = String.Empty
        Me.txtNombre.Text = String.Empty

    End Sub

End Class