Imports System.Data
Imports System.Data.OleDb

Public Class frmLogin


    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblVersion.Text = "Versión - " & Application.ProductVersion

    End Sub


    Private Sub cmdIngresar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresar.Click

        gServidor = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerName", String.Empty)
        gBaseDatos = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBName", String.Empty)
        gServidorProtean = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerNameProtean", String.Empty)
        gBaseDatosProtean = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBNameProtean", String.Empty)
        gServidorEtiqueta = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerNameEtiqueta", String.Empty)
        gBaseDatosEtiqueta = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBNameEtiqueta", String.Empty)

        gConnectionString = String.Format("Server={0};Database={1};Trusted_Connection=True;", gServidor, gBaseDatos)
        gConnectionStringProtean = String.Format("Server={0};Database={1};Trusted_Connection=True;", gServidorProtean, gBaseDatosProtean)
        gConnectionStringEtiqueta = String.Format("Server={0};Database={1};Trusted_Connection=True;", gServidorEtiqueta, gBaseDatosEtiqueta)

        Dim i_Connection As New SqlClient.SqlConnection()
        i_Connection.ConnectionString = gConnectionString
        Try
            Me.Cursor = Cursors.WaitCursor
            i_Connection.Open()
            i_Connection.Close()
            Me.Cursor = Cursors.Default

            Dim i_ConnectionPN As New SqlClient.SqlConnection()
            i_ConnectionPN.ConnectionString = gConnectionStringProtean
            i_ConnectionPN.Open()
            i_ConnectionPN.Close()

            Dim i_ConnectionET As New SqlClient.SqlConnection()
            i_ConnectionET.ConnectionString = gConnectionStringEtiqueta
            i_ConnectionET.Open()
            i_ConnectionET.Close()

            ConectionOk = True

            Dim lWin As System.Security.Principal.WindowsIdentity
            lWin = System.Security.Principal.WindowsIdentity.GetCurrent()
            gUsuario = lWin.Name.Substring(lWin.Name.IndexOf("\") + 1)

            frmPrincipal.Show()

            Me.Hide()

        Catch ex As Exception
            MsgBox("No se logro realizar la conexión con el servidor " & ex.Message, MsgBoxStyle.Critical, Me.Text)
            ConectionOk = False
        End Try

    End Sub


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click

        Me.Close()

    End Sub


    Private Sub lnkParametrosConexion_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkParametrosConexion.LinkClicked

        frmParametrosConexion.ShowDialog()

    End Sub


    Private Sub cmdUsuarioyClave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUsuarioyClave.Click

        frmLoginUsuarioyPasword.ShowDialog()

    End Sub

End Class
