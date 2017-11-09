Public Class frmBuscador

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If Not Grid.Rows.Count = 1 Then
            i_LlaveBusqueda = Grid.GetData(Grid.Row, 0)
            i_LlaveBusqueda2 = Grid.GetData(Grid.Row, 1)
            If Grid.Cols.Count > 2 Then
                i_LlaveBusqueda3 = Grid.GetData(Grid.Row, 2)
            End If
            If Grid.Cols.Count > 3 Then
                i_LlaveBusqueda4 = Grid.GetData(Grid.Row, 3)
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        i_LlaveBusqueda = Nothing
        i_LlaveBusqueda2 = Nothing
        i_LlaveBusqueda3 = Nothing
        i_LlaveBusqueda4 = Nothing
        Me.Close()
    End Sub

    Private Sub Grid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Grid.DoubleClick
        If Not Grid.Rows.Count = 1 Then
            i_LlaveBusqueda = Grid.GetData(Grid.Row, 0)
            i_LlaveBusqueda2 = Grid.GetData(Grid.Row, 1)
            If Grid.Cols.Count > 2 Then
                i_LlaveBusqueda3 = Grid.GetData(Grid.Row, 2)
            End If
            If Grid.Cols.Count > 3 Then
                i_LlaveBusqueda4 = Grid.GetData(Grid.Row, 3)
            End If

            Me.Close()
        End If
    End Sub

  
End Class