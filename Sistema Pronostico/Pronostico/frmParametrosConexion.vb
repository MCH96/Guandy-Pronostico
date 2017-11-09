Imports System.Windows.Forms

Public Class frmParametrosConexion


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        If Len(Trim(txtServerName.Text)) = 0 Or Len(Trim(txtDBName.Text)) = 0 Then
            MessageBox.Show("Debe de completar los datos para realizar la conexión.", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerName", txtServerName.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBName", txtDBName.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerNameProtean", txtServerProtean.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBNameProtean", txtDataBaseProtean.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerNameEtiqueta", txtServerEtiqueta.Text)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBNameEtiqueta", txtDataBaseEtiqueta.Text)
        Me.Dispose()

    End Sub


    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click

        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub


    Private Sub frmOpcionesConexion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtServerName.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerName", String.Empty)
        Me.txtDBName.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBName", String.Empty)
        Me.txtServerProtean.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerNameProtean", String.Empty)
        Me.txtDataBaseProtean.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBNameProtean", String.Empty)
        Me.txtServerEtiqueta.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerNameEtiqueta", String.Empty)
        Me.txtDataBaseEtiqueta.Text = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBNameEtiqueta", String.Empty)

    End Sub

End Class
