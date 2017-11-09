﻿Public Class frmPrincipal
 

    Private Sub frmPrincipal_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim frmCollection As New FormCollection()
        frmCollection = Application.OpenForms()
        If frmCollection.Count = 1 Then Application.Exit()

    End Sub


    Private Sub frmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim iNOmbreUsuario As String
        gModulo = 2
        gAdministrador = Val(ObtenerCampo("SEC_AdministradorModulo", "count(*)", "Where IdUsuario = '" & gUsuario & "' and IdModulo = " & gModulo)) <> 0
        lblServerName.Caption = UCase(gServidor) & "." & UCase(gBaseDatos)
        iNOmbreUsuario = BOGeneral.GetDataTable(gConnectionString, "exec sp_SEC_ValidaUsuario '" & gUsuario & "'", "Datos").Rows(0)("NombreUsuario")
        If iNOmbreUsuario = "" Then
            MessageBox.Show("El usuario " & gUsuario & " no esta registrado en el sistema ó esta inactivo. Cree ó active la cuenta correspondiente y vuelva a ingresar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End
        End If
        lblUserName.Caption = gUsuario & " (" & iNOmbreUsuario & ")"

        lblVersion.Caption = "Pronóstico Ver. - " & Application.ProductVersion

        gVendedor = New SECUsuarioBO(gConnectionString, gUsuario).Vendedor

    End Sub


    Public Sub Mostrar_Forma(ByVal iForma As Form, Optional ByVal iDialog As Boolean = False)

        If iDialog = False Then
            iForma.MdiParent = Me
            iForma.Show()
        Else
            iForma.ShowDialog()
        End If

    End Sub


    Private Sub ValidaAcceso(ByVal pForma As Form)

        If Not gAdministrador Then
            If Not CheckAccess(gConnectionString, gUsuario, pForma.Name, 0) Then
                MsgBox("Sin acceso para ejecutar la opción", MsgBoxStyle.Critical, "Seguridad del sistema")
                Exit Sub
            End If
        End If

        Mostrar_Forma(pForma, False)

    End Sub


    Private Sub cmdPeriodo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPeriodo.ItemClick

        ValidaAcceso(frmPeriodo)

    End Sub


    Private Sub cmdCerrarPeriodo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCerrarPeriodo.ItemClick

        ValidaAcceso(frmCerrarPeriodo)

    End Sub


    Private Sub cmdEnviarPeriodo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdEnviarPeriodo.ItemClick

        ValidaAcceso(frmEnviarPeriodoProtean)

    End Sub


    Private Sub cmdEdicionPeriodo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdEdicionPeriodo.ItemClick

        ValidaAcceso(frmEdicionPeriodo)

    End Sub


    Private Sub cmdComparacionPeriodo_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdComparacionPeriodo.ItemClick

        ValidaAcceso(frmComparacionPeriodo)

    End Sub


    Private Sub cmdPMMantenimientoPorSocio_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPMMantenimientoPorSocio.ItemClick

        ValidaAcceso(frmMantenimientoPerfilMercado)

    End Sub


    Private Sub cmdCerrarPeriodoVendedor_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPeriodoVendedor.ItemClick

        ValidaAcceso(frmPeriodoVendedor)

    End Sub


    Private Sub cmdReporteClientesConPronosticoIngresado_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdReporteClientesConPronosticoIngresado.ItemClick

        ValidaAcceso(frmReporteClientesConPronosticoIngresado)

    End Sub


    Private Sub cmdVendedorDetalleProductos_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdVendedorDetalleProductos.ItemClick

        ValidaAcceso(frmPeriodoClienteDetalle)

    End Sub


    Private Sub cmdPeriodoCliente_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPeriodoCliente.ItemClick

        ValidaAcceso(frmPeriodoCliente)

    End Sub


    Private Sub cmdGrupoCliente_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdGrupoCliente.ItemClick

        ValidaAcceso(frmGrupoCliente)

    End Sub


    Private Sub cmdPeriodoVendedorVarios_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPeriodoVendedorVarios.ItemClick

        ValidaAcceso(frmPeriodoVendedorVarios)

    End Sub


    Private Sub cmdReporteRecursoConPrecio0_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdReporteRecursoConPrecio0.ItemClick

        ValidaAcceso(frmReporteRecursosConPrecio0)

    End Sub

End Class
