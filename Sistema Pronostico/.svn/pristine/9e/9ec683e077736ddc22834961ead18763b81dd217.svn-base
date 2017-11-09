Public Class frmBuscadorArbol

    Public pBusqueda As String
    Dim pNivel As Integer

    Private Sub CargarPartidaRecurso()

        'Dim LisObjP As List(Of SITPartidaArancelariaBO) = SITPartidaArancelariaBO.GetAll(gConnectionString)
        'For Each ObjP As SITPartidaArancelariaBO In LisObjP
        '    Dim lNP As New TreeNode
        '    lNP.Tag = ObjP.IdPartidaArancelaria
        '    lNP.Text = String.Format("Partida: {0} - {1}", ObjP.Codigo, ObjP.Nombre)

        '    Dim ListObjRec As List(Of SITPartidaArancelariaRecursoBO) = SITPartidaArancelariaRecursoBO.GetAllFiltro(gConnectionString, String.Format("Where IdPartidaArancelaria={0}", ObjP.IdPartidaArancelaria))
        '    For Each ObjRec As SITPartidaArancelariaRecursoBO In ListObjRec
        '        Dim lNRec As New TreeNode
        '        lNRec.Tag = ObjRec.IdRecurso
        '        lNRec.Text = String.Format("Recurso: {0}", ObjRec.IdRecurso)
        '        lNP.Nodes.Add(lNRec)
        '    Next
        '    Me.tvBuscador.Nodes.Add(lNP)
        'Next
        'tvBuscador.ExpandAll()

    End Sub


    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click

        Try
            Dim lNodo As TreeNode = Me.tvBuscador.SelectedNode
            If pBusqueda = "Producto" Then
                i_LlaveBusqueda = lNodo
                Me.Close()
            Else
                If lNodo.Nodes.Count = 0 And lNodo.Level = pNivel Then
                    i_LlaveBusqueda = lNodo
                    Me.Close()
                End If
            End If
        Catch
        End Try

    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        i_LlaveBusqueda = Nothing
        i_LlaveBusqueda2 = Nothing
        Me.Close()

    End Sub


    Private Sub frmBuscadorArbol_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Me.Dispose()

    End Sub


    Private Sub frmBuscadorArbol_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        i_LlaveBusqueda = Nothing
        i_LlaveBusqueda2 = Nothing

        Select Case pBusqueda
            Case "PartidaRecurso"
                Call Me.CargarPartidaRecurso()
                pNivel = 1
            Case "Municipio"
                LabelControl2.Visible = True
                txtMunicipo.Visible = True
                cmdFiltrar.Visible = True
                txtPais.Visible = True
                lblPais.Visible = True
                'Call Me.CargaMunicipio()
                pNivel = 2
        End Select

    End Sub


    Private Sub tvBuscador_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvBuscador.NodeMouseDoubleClick

        Try
            If pBusqueda = "Producto" Then
                i_LlaveBusqueda = e.Node
                Me.Close()
            Else
                If e.Node.Nodes.Count = 0 And e.Node.Level = pNivel Then
                    i_LlaveBusqueda = e.Node
                    Me.Close()
                End If
            End If
        Catch
        End Try

    End Sub

    Private Sub cmdFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFiltrar.Click

        'Call Me.CargaMunicipio()
        pNivel = 2

    End Sub


    Private Sub txtPais_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtPais.EditorButtonClick

        'Me.txtMunicipo.Text = String.Empty
        'Dim iDatos As DataTable = GetDataTable(String.Format("select IdPais as Código,NombrePais as Nombre from ADM_Pais "), "Busqueda")
        'Dim lCodigo As Object = MostrarBuscador("Busqueda", iDatos, "Busqueda")
        'If lCodigo IsNot Nothing Then
        '    Dim ObjPais As New FENPaisBO(gConnectionString, lCodigo)
        '    Me.txtPais.Tag = ObjPais.IdPais
        '    Me.txtPais.Text = ObjPais.IdPais & " - " & ObjPais.NombrePais
        'End If

    End Sub

End Class