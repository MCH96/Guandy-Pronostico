Public Class frmPopUpPronosticoPorcentajeGlobal


    Public pPorcentaje


    Private Sub cmdCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCerrar.ItemClick

        Me.Close()

    End Sub


    Private Sub frmPopUpPronosticoPorcentajeGlobal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtPorcentaje.Text = pPorcentaje
        If pPorcentaje = 0 Then
            Me.txtPorcentaje.BackColor = Color.Yellow
        ElseIf pPorcentaje > 0 Then
            Me.txtPorcentaje.BackColor = Color.Green
        Else
            Me.txtPorcentaje.BackColor = Color.Red
        End If

    End Sub

End Class