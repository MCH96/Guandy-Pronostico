﻿Imports System.Data
Imports System.Data.OleDb

Public Class frmLoginUsuarioyPasword


    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblVersion.Text = "Versión - " & Application.ProductVersion

    End Sub


    Private Sub cmdIngresar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIngresar.Click

        gUsuario = txtUsuario.Text
        gServidor = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerName", String.Empty)
        gBaseDatos = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBName", String.Empty)
        gServidorProtean = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerNameProtean", String.Empty)
        gBaseDatosProtean = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBNameProtean", String.Empty)
        gServidorEtiqueta = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "ServerNameEtiqueta", String.Empty)
        gBaseDatosEtiqueta = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\SITE\Pronostico", "DBNameEtiqueta", String.Empty)

        gConnectionString = "Data Source=" & gServidor & ";Initial Catalog=" & gBaseDatos & ";Persist Security Info=True;User ID=" & txtUsuario.Text & ";Password=" & txtPassword.Text & ";"
        gConnectionStringProtean = "Data Source=" & gServidorProtean & ";Initial Catalog=" & gBaseDatosProtean & ";Persist Security Info=True;User ID=" & txtUsuario.Text & ";Password=" & txtPassword.Text & ";"
        gConnectionStringEtiqueta = "Data Source=" & gServidorEtiqueta & ";Initial Catalog=" & gBaseDatosEtiqueta & ";Persist Security Info=True;User ID=" & txtUsuario.Text & ";Password=" & txtPassword.Text & ";"


        Dim i_Connection As New SqlClient.SqlConnection()
        i_Connection.ConnectionString = gConnectionString

        Try
            Me.Cursor = Cursors.WaitCursor
            i_Connection.Open()
            i_Connection.Close()
            Me.Cursor = Cursors.Default
            ConectionOk = True

            Dim i_ConnectionPN As New SqlClient.SqlConnection()
            i_ConnectionPN.ConnectionString = gConnectionStringProtean
            i_ConnectionPN.Open()
            i_ConnectionPN.Close()
            ConectionOk = True

            frmPrincipal.Show()
            Me.Close()
            frmLogin.Close()

        Catch ex As Exception
            MsgBox("No se logro realizar la conexión con el servidor " & ex.Message, MsgBoxStyle.Critical, Me.Text)
            ConectionOk = False
            Me.Close()
        End Try

    End Sub


    Private Sub cmdSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalir.Click

        Me.Close()

    End Sub

End Class
