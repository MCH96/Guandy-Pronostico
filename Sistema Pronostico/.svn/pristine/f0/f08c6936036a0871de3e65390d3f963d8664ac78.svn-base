Public Class frmPeriodoVendedor

    Dim Obj As PROPeriodoBO
    Dim ObjV As PROPeriodoVendedorBO


    Private Sub AbrirPeriodo(ByVal pComentario As String)


        Select Case CInt(Me.ugData.ActiveRow.Cells("IdMes").Value)
            Case 1
                If Obj.Mes1 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes1 = False
                ObjV.Mes1CerradoPor = Nothing
                ObjV.Mes1FechaCierre = Nothing
            Case 2
                If Obj.Mes2 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes2 = False
                ObjV.Mes2CerradoPor = Nothing
                ObjV.Mes2FechaCierre = Nothing
            Case 3
                If Obj.Mes3 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes3 = False
                ObjV.Mes3CerradoPor = Nothing
                ObjV.Mes3FechaCierre = Nothing
            Case 4
                If Obj.Mes4 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes4 = False
                ObjV.Mes4CerradoPor = Nothing
                ObjV.Mes4FechaCierre = Nothing
            Case 5
                If Obj.Mes5 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes5 = False
                ObjV.Mes5CerradoPor = Nothing
                ObjV.Mes5FechaCierre = Nothing
            Case 6
                If Obj.Mes6 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes6 = False
                ObjV.Mes6CerradoPor = Nothing
                ObjV.Mes6FechaCierre = Nothing
            Case 7
                If Obj.Mes7 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes7 = False
                ObjV.Mes7CerradoPor = Nothing
                ObjV.Mes7FechaCierre = Nothing
            Case 8
                If Obj.Mes8 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes8 = False
                ObjV.Mes8CerradoPor = Nothing
                ObjV.Mes8FechaCierre = Nothing
            Case 9
                If Obj.Mes9 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes9 = False
                ObjV.Mes9CerradoPor = Nothing
                ObjV.Mes9FechaCierre = Nothing
            Case 10
                If Obj.Mes10 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes10 = False
                ObjV.Mes10CerradoPor = Nothing
                ObjV.Mes10FechaCierre = Nothing
            Case 11
                If Obj.Mes11 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes11 = False
                ObjV.Mes11CerradoPor = Nothing
                ObjV.Mes11FechaCierre = Nothing
            Case 12
                If Obj.Mes12 = True Then
                    MsgBox("El Período ya se encuentra cerrado, no es posible aperturar el mes.", MsgBoxStyle.Information, Me.Text)
                    Exit Sub
                End If
                ObjV.Mes12 = False
                ObjV.Mes12CerradoPor = Nothing
                ObjV.Mes12FechaCierre = Nothing
        End Select

        PeriodoBL.AperturaCierreMesVendedorPeriodo(gConnectionString, ObjV, gUsuario, False, True, CInt(Me.ugData.ActiveRow.Cells("IdMes").Value), pComentario)

        Call Me.CargarGrid()

    End Sub


    Private Function ObtenerValores(ByVal pMes As Integer) As String

        Dim lValores As String = String.Empty

        Select Case pMes
            Case 1
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes1), New SECUsuarioBO(gConnectionString, ObjV.Mes1CerradoPor).NombreUsuario, ObjV.Mes1FechaCierre)
            Case 2
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes2), New SECUsuarioBO(gConnectionString, ObjV.Mes2CerradoPor).NombreUsuario, ObjV.Mes2FechaCierre)
            Case 3
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes3), New SECUsuarioBO(gConnectionString, ObjV.Mes3CerradoPor).NombreUsuario, ObjV.Mes3FechaCierre)
            Case 4
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes4), New SECUsuarioBO(gConnectionString, ObjV.Mes4CerradoPor).NombreUsuario, ObjV.Mes4FechaCierre)
            Case 5
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes5), New SECUsuarioBO(gConnectionString, ObjV.Mes5CerradoPor).NombreUsuario, ObjV.Mes5FechaCierre)
            Case 6
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes6), New SECUsuarioBO(gConnectionString, ObjV.Mes6CerradoPor).NombreUsuario, ObjV.Mes6FechaCierre)
            Case 7
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes7), New SECUsuarioBO(gConnectionString, ObjV.Mes7CerradoPor).NombreUsuario, ObjV.Mes7FechaCierre)
            Case 8
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes8), New SECUsuarioBO(gConnectionString, ObjV.Mes8CerradoPor).NombreUsuario, ObjV.Mes8FechaCierre)
            Case 9
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes9), New SECUsuarioBO(gConnectionString, ObjV.Mes9CerradoPor).NombreUsuario, ObjV.Mes9FechaCierre)
            Case 10
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes10), New SECUsuarioBO(gConnectionString, ObjV.Mes10CerradoPor).NombreUsuario, ObjV.Mes10FechaCierre)
            Case 11
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes11), New SECUsuarioBO(gConnectionString, ObjV.Mes11CerradoPor).NombreUsuario, ObjV.Mes11FechaCierre)
            Case 12
                lValores = String.Format("{0}_{1}_{2}", CInt(ObjV.Mes12), New SECUsuarioBO(gConnectionString, ObjV.Mes12CerradoPor).NombreUsuario, ObjV.Mes12FechaCierre)
        End Select

        Return lValores

    End Function


    Private Sub CargarGrid()

        Me.udsData.Rows.Clear()

        Dim lTable As New DataTable("Datos")

        For i As Integer = 1 To 12
            Dim lFila As Infragistics.Win.UltraWinDataSource.UltraDataRow = Me.udsData.Rows.Add
            lFila.SetCellValue("IdMes", i)
            lFila.SetCellValue("Mes", NombreMes(i))
            Dim lValores As String() = ObtenerValores(i).Split("_")
            lFila.SetCellValue("Cerrado", CBool(lValores(0)))
            lFila.SetCellValue("CerradoPor", lValores(1).ToString)
            If String.IsNullOrEmpty(lValores(2)) = False Then lFila.SetCellValue("FechaCierre", CDate(lValores(2)))
            lFila.SetCellValue("Cerrar", "Cerrar")
            lFila.SetCellValue("Abrir", "Abrir")
        Next

        Me.ugData.DisplayLayout.Bands(0).Columns("Cerrar").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button
        Me.ugData.DisplayLayout.Bands(0).Columns("Abrir").Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Button

    End Sub


    Private Sub Limpiar()

        Obj = New PROPeriodoBO
        ObjV = New PROPeriodoVendedorBO
        Me.txtVendedor.Tag = Nothing
        Me.txtVendedor.Text = String.Empty
        Me.txtPeriodo.Text = String.Empty
        Me.udsData.Rows.Clear()

    End Sub


    Private Sub cmdCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCerrar.ItemClick

        Me.Close()

    End Sub


    Private Sub frmPeriodoVendedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Me.Limpiar()

    End Sub


    Private Sub txtVendedor_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtVendedor.EditorButtonClick

        Try

            Select Case e.Button.Key

                Case "cmdBuscar"

                    ObjV = New PROPeriodoVendedorBO
                    Me.txtVendedor.Tag = Nothing
                    Me.txtVendedor.Text = String.Empty
                    Me.udsData.Rows.Clear()

                    Dim lTableVendedores As New DataTable
                    lTableVendedores.Columns.Add("Código", GetType(String))
                    lTableVendedores.Columns.Add("Vendedor", GetType(String))

                    Dim iDatos As DataTable = GetDataTableProtean("Select distinct Vendedor as Código, Nombre_Vendedor as Vendedor From view_Cubo_SocioxVendedor Order By Vendedor", "Datos")

                    Dim ListObjPV As List(Of PROPeriodoVendedorBO) = PROPeriodoVendedorBO.GetAllFiltro(gConnectionString, String.Format("Where IdPeriodo = {0}", Me.txtPeriodo.Text))
                    For Each ObjPV As PROPeriodoVendedorBO In ListObjPV
                        Dim lRow As DataRow = lTableVendedores.NewRow
                        lRow("Código") = ObjPV.Vendedor
                        lRow("Vendedor") = (From b In iDatos.AsEnumerable Where b.Field(Of String)("Código") = ObjPV.Vendedor Select b.Field(Of String)("Vendedor")).FirstOrDefault
                        lTableVendedores.Rows.Add(lRow)
                    Next

                    Dim lCodigo As Object = MostrarBuscador("Vendedores", lTableVendedores, "Vendedores")
                    If i_LlaveBusqueda IsNot Nothing AndAlso String.IsNullOrEmpty(i_LlaveBusqueda.ToString) = False Then
                        If PROPeriodoVendedorBO.Exists(gConnectionString, Obj.IdPeriodo, lCodigo.ToString) = False Then
                            MsgBox("El Vendedor Seleccionado no se Encuentra Registrado.", MsgBoxStyle.Information, Me.Text)
                            Exit Sub
                        End If
                        Obj = New PROPeriodoBO(gConnectionString, Obj.IdPeriodo)
                        ObjV = New PROPeriodoVendedorBO(gConnectionString, Obj.IdPeriodo, lCodigo)
                        Me.txtVendedor.Tag = lCodigo
                        Me.txtVendedor.Text = String.Format("{0} - {1}", lCodigo, i_LlaveBusqueda2.ToString)
                        Call Me.CargarGrid()
                    End If

                Case "cmdNuevo"

                    Obj = New PROPeriodoBO
                    ObjV = New PROPeriodoVendedorBO
                    Me.txtVendedor.Tag = Nothing
                    Me.txtVendedor.Text = String.Empty
                    Me.udsData.Rows.Clear()

                    Dim iDatos As DataTable = GetDataTableProtean("Select distinct Vendedor, Nombre_Vendedor as Vendedor From view_Cubo_SocioxVendedor Order By Vendedor", "Datos")
                    Dim lCodigo As Object = MostrarBuscador("Vendedores", iDatos, "Vendedores")
                    If i_LlaveBusqueda IsNot Nothing AndAlso String.IsNullOrEmpty(i_LlaveBusqueda.ToString) = False Then
                        If PROPeriodoVendedorBO.Exists(gConnectionString, Obj.IdPeriodo, lCodigo.ToString) = True Then
                            MsgBox("El Vendedor ya se Encuentra Registrado.", MsgBoxStyle.Information, Me.Text)
                            Exit Sub
                        End If

                        PeriodoBL.GuardarPeriodoVendedor(gConnectionString, gConnectionStringProtean, Obj.IdPeriodo, lCodigo.ToString, gUsuario)

                        Obj = New PROPeriodoBO(gConnectionString, Obj.IdPeriodo)
                        ObjV = New PROPeriodoVendedorBO(gConnectionString, Obj.IdPeriodo, lCodigo)
                        Me.txtVendedor.Tag = lCodigo
                        Me.txtVendedor.Text = String.Format("{0} - {1}", lCodigo, i_LlaveBusqueda2.ToString)
                        Call Me.CargarGrid()
                    End If

                Case "cmdEliminar"

                    If MsgBox("¿Está seguro(a) de querer eliminar el registro seleccionado?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then Exit Sub

                    If String.IsNullOrEmpty(Me.txtVendedor.Text) = True Then
                        MsgBox("Seleccione un Vendedor.", MsgBoxStyle.Information, Me.Text)
                        Exit Sub
                    End If

                    If PROPeriodoVendedorBO.Exists(gConnectionString, Obj.IdPeriodo, Me.txtVendedor.Tag) = False Then
                        MsgBox("El Vendedor no se Encuentra Registrado.", MsgBoxStyle.Information, Me.Text)
                        Exit Sub
                    End If

                    If Obj.PeriodoCerrado = True Then
                        MsgBox("El Período ya se encuentra cerrado, no se puede eliminar.", MsgBoxStyle.Information, Me.Text)
                        Exit Sub
                    End If

                    Dim lCliente As String = String.Empty
                    Dim lTable As DataTable = GetDataTableProtean(String.Format("Select distinct ObjectID_Socio_Negcio as Cliente From view_Cubo_SocioxVendedor Where Vendedor = '{0}'", Me.txtVendedor.Tag), "Datos")
                    If lTable.Rows.Count = 0 Then
                        MsgBox("El Vendedor no posee cliente ligado.", MsgBoxStyle.Information, Me.Text)
                        Exit Sub
                    End If

                    ObjV = New PROPeriodoVendedorBO(gConnectionString, Obj.IdPeriodo, Me.txtVendedor.Tag)

                    If ObjV.Mes1 = True OrElse ObjV.Mes2 = True OrElse ObjV.Mes3 = True OrElse ObjV.Mes4 = True OrElse ObjV.Mes5 = True OrElse ObjV.Mes6 = True OrElse ObjV.Mes7 = True OrElse ObjV.Mes8 = True OrElse ObjV.Mes9 = True OrElse ObjV.Mes10 = True OrElse ObjV.Mes11 = True OrElse ObjV.Mes12 = True Then
                        MsgBox("El período del vendedor ya cuenta con meses cerrados, no se puede eliminar el vendedor.", MsgBoxStyle.Information, Me.Text)
                        Exit Sub
                    End If

                    PeriodoBL.EliminarPeriodoVendedor(gConnectionString, ObjV)
                    MsgBox("Eliminado con Éxito.", MsgBoxStyle.Information, Me.Text)

                    Call Me.Limpiar()

            End Select

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub ugData_ClickCellButton(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinGrid.CellEventArgs) Handles ugData.ClickCellButton

        If Obj.IsNew = True Then
            MsgBox("El perído no se encuentra registrado.", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        ElseIf ObjV.IsNew = True Then
            MsgBox("El perído del vendedor no se encuentra registrado.", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        ElseIf Obj.PeriodoCerrado = True Then
            MsgBox("El perído ya se encuentra cerrado.", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        Select Case e.Cell.Column.Key

            Case "Cerrar"

                If Not CheckAccess(gConnectionString, gUsuario, "CerrarMesPeriodo", 0) Then
                    MsgBox("Sin acceso para ejecutar la opción", MsgBoxStyle.Critical, "Seguridad del sistema")
                    Exit Sub
                End If

                If CInt(e.Cell.Row.Cells("IdMes").Value) <> 1 Then
                    If Me.ugData.Rows(Me.ugData.ActiveRow.Index - 1).Cells("Cerrado").Value = False Then
                        MsgBox("El Mes Anterior no se encuentra Cerrado.", MsgBoxStyle.Critical, "Seguridad del sistema")
                        Exit Sub
                    End If
                End If

                If e.Cell.Row.Cells("Cerrado").Value = True Then
                    MsgBox("El Mes ya se encuentra Cerrado.", MsgBoxStyle.Critical, "Seguridad del sistema")
                    Exit Sub
                End If

                If MessageBox.Show("¿Está seguro(a) de Cerrar el Mes del Período?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

                Select Case CInt(e.Cell.Row.Cells("IdMes").Value)
                    Case 1
                        ObjV.Mes1 = True
                        ObjV.Mes1CerradoPor = gUsuario
                        ObjV.Mes1FechaCierre = Now
                    Case 2
                        ObjV.Mes2 = True
                        ObjV.Mes2CerradoPor = gUsuario
                        ObjV.Mes2FechaCierre = Now
                    Case 3
                        ObjV.Mes3 = True
                        ObjV.Mes3CerradoPor = gUsuario
                        ObjV.Mes3FechaCierre = Now
                    Case 4
                        ObjV.Mes4 = True
                        ObjV.Mes4CerradoPor = gUsuario
                        ObjV.Mes4FechaCierre = Now
                    Case 5
                        ObjV.Mes5 = True
                        ObjV.Mes5CerradoPor = gUsuario
                        ObjV.Mes5FechaCierre = Now
                    Case 6
                        ObjV.Mes6 = True
                        ObjV.Mes6CerradoPor = gUsuario
                        ObjV.Mes6FechaCierre = Now
                    Case 7
                        ObjV.Mes7 = True
                        ObjV.Mes7CerradoPor = gUsuario
                        ObjV.Mes7FechaCierre = Now
                    Case 8
                        ObjV.Mes8 = True
                        ObjV.Mes8CerradoPor = gUsuario
                        ObjV.Mes8FechaCierre = Now
                    Case 9
                        ObjV.Mes9 = True
                        ObjV.Mes9CerradoPor = gUsuario
                        ObjV.Mes9FechaCierre = Now
                    Case 10
                        ObjV.Mes10 = True
                        ObjV.Mes10CerradoPor = gUsuario
                        ObjV.Mes10FechaCierre = Now
                    Case 11
                        ObjV.Mes11 = True
                        ObjV.Mes11CerradoPor = gUsuario
                        ObjV.Mes11FechaCierre = Now
                    Case 12
                        ObjV.Mes12 = True
                        ObjV.Mes12CerradoPor = gUsuario
                        ObjV.Mes12FechaCierre = Now
                End Select

                PeriodoBL.AperturaCierreMesVendedorPeriodo(gConnectionString, ObjV, gUsuario, True, False, CInt(e.Cell.Row.Cells("IdMes").Value), String.Empty)

                Call Me.CargarGrid()

            Case "Abrir"

                If Not CheckAccess(gConnectionString, gUsuario, "AbrirMesPeriodo", 0) Then
                    MsgBox("Sin acceso para ejecutar la opción", MsgBoxStyle.Critical, "Seguridad del sistema")
                    Exit Sub
                End If

                If CInt(e.Cell.Row.Cells("IdMes").Value) <> 12 Then
                    If Me.ugData.Rows(Me.ugData.ActiveRow.Index + 1).Cells("Cerrado").Value = True Then
                        MsgBox("El Mes Siguiente no se encuentra Abierto.", MsgBoxStyle.Critical, "Seguridad del sistema")
                        Exit Sub
                    End If
                End If

                If e.Cell.Row.Cells("Cerrado").Value = False Then
                    MsgBox("El Mes ya se encuentra Abierto.", MsgBoxStyle.Critical, "Seguridad del sistema")
                    Exit Sub
                End If

                If MessageBox.Show("¿Está seguro(a) de Aperturar el Período?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then Exit Sub

                frmPopUpComentario.pObligatorio = True
                frmPopUpComentario.Cargar = New frmPopUpComentario.Operar(AddressOf AbrirPeriodo)
                frmPopUpComentario.ShowDialog(Me)

        End Select

    End Sub


    Private Sub txtPeriodo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtPeriodo.EditorButtonClick

        Call Me.Limpiar()

        Dim iDatos As DataTable = GetDataTable("Select IdPeriodo as [Período] From PRO_Periodo Where PeriodoCerrado = 0 Order By IdPeriodo", "Busqueda")
        Dim lCodigo As Object = MostrarBuscador("Busqueda", iDatos, "Busqueda")

        If lCodigo IsNot Nothing AndAlso IsNumeric(lCodigo) Then
            Obj = New PROPeriodoBO(gConnectionString, CInt(lCodigo))
            Me.txtPeriodo.Text = lCodigo
            If Me.txtVendedor.Tag IsNot Nothing Then
                ObjV = New PROPeriodoVendedorBO(gConnectionString, CInt(lCodigo), Me.txtVendedor.Tag)
                Call Me.CargarGrid()
            End If
        End If

    End Sub

End Class