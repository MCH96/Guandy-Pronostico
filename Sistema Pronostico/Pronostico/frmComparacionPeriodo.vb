﻿Imports Infragistics.Win.UltraWinGrid
Imports Infragistics.Excel


Public Class frmComparacionPeriodo


    Dim Obj As PROPeriodoBO
    Dim lTotalPronosticoAnterior As Decimal = 0


    Private Sub AgregarColumnaGrupo(ByVal pPeriodo As Integer, ByVal pMes As Integer)

        Dim cPeriodo As Infragistics.Win.UltraWinGrid.UltraGridColumn
        cPeriodo = ugData.DisplayLayout.Bands(0).Columns.Add(String.Format("{0}_{1}", pPeriodo.ToString, pMes.ToString), pPeriodo.ToString)
        cPeriodo.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
        cPeriodo.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
        cPeriodo.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
        cPeriodo.DataType = GetType(Int32)
        cPeriodo.Format = "#,###,###"
        cPeriodo.Width = 50

        Me.ugData.DisplayLayout.Bands(0).Groups(pMes.ToString).Columns.Add(cPeriodo)

    End Sub


    Private Sub Limpiar()

        Obj = New PROPeriodoBO
        lTotalPronosticoAnterior = 0
        Me.txtPeriodo.Tag = Nothing
        Me.txtPeriodo.Text = String.Empty
        Me.txtCliente.Tag = Nothing
        Me.txtCliente.Text = String.Empty
        Me.chkEnero.Text = NombreMes(1)
        Me.chkFebrero.Text = NombreMes(2)
        Me.chkMarzo.Text = NombreMes(3)
        Me.chkAbril.Text = NombreMes(4)
        Me.chkMayo.Text = NombreMes(5)
        Me.chkJunio.Text = NombreMes(6)
        Me.chkJulio.Text = NombreMes(7)
        Me.chkAgosto.Text = NombreMes(8)
        Me.chkSeptiembre.Text = NombreMes(9)
        Me.chkOctubre.Text = NombreMes(10)
        Me.chkNoviembre.Text = NombreMes(11)
        Me.chkDiciembre.Text = NombreMes(12)
        Me.chkEnero.Checked = False
        Me.chkFebrero.Checked = False
        Me.chkMarzo.Checked = False
        Me.chkAbril.Checked = False
        Me.chkMayo.Checked = False
        Me.chkJunio.Checked = False
        Me.chkJulio.Checked = False
        Me.chkAgosto.Checked = False
        Me.chkSeptiembre.Checked = False
        Me.chkOctubre.Checked = False
        Me.chkNoviembre.Checked = False
        Me.chkDiciembre.Checked = False
        Me.txtAniosComparar.Text = 0
        Me.ugData.DataSource = Nothing

    End Sub


    Private Sub Validar()

        If String.IsNullOrEmpty(Me.txtPeriodo.Text) = True Then Throw New Exception("Seleccione un Período.")
        If String.IsNullOrEmpty(Me.txtCliente.Text) = True Then Throw New Exception("Seleccione el Cliente")
        If Obj.IsNew = True Then Throw New Exception("No existe un período registrado relacionado al vendedor del cliente seleccionado.")
        If Me.chkEnero.Checked = False AndAlso Me.chkFebrero.Checked = False AndAlso Me.chkMarzo.Checked = False AndAlso Me.chkAbril.Checked = False AndAlso Me.chkMayo.Checked = False AndAlso Me.chkJunio.Checked = False AndAlso Me.chkJulio.Checked = False AndAlso Me.chkAgosto.Checked = False AndAlso Me.chkSeptiembre.Checked = False AndAlso Me.chkOctubre.Checked = False AndAlso Me.chkNoviembre.Checked = False AndAlso Me.chkDiciembre.Checked = False Then Throw New Exception("Seleccione al menos un mes.")
        If CInt(Me.txtAniosComparar.Text) < 0 Then Throw New Exception("El mes a Comparar no puede ser negativo.")
        Dim lTableDetalle As DataTable = GetDataTable(String.Format("Select top 1 * From PRO_PeriodoVendedorDetalle Where IdPeriodo={0} and IdCliente={1}", Obj.IdPeriodo, Me.txtCliente.Tag), "Datos")
        If lTableDetalle.Rows.Count = 0 Then MsgBox("Cliente sin Productos ingresados.", MsgBoxStyle.Information, Me.Text)

    End Sub


    Private Sub cmdCerrar_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCerrar.ItemClick

        Me.Close()

    End Sub


    Private Sub frmComparacionPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call Me.Limpiar()

    End Sub


    Private Sub txtPeriodo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtPeriodo.EditorButtonClick

        Call Me.Limpiar()

        Dim iDatos As DataTable = GetDataTable("Select IdPeriodo as [Período] From PRO_Periodo Where PeriodoCerrado = 0 and EnviadoProtean = 0 Order By IdPeriodo", "Busqueda")
        Dim lCodigo As Object = MostrarBuscador("Busqueda", iDatos, "Busqueda")

        If lCodigo IsNot Nothing AndAlso IsNumeric(lCodigo) Then
            Me.txtPeriodo.Text = lCodigo
        End If

    End Sub


    Private Sub txtCliente_EditorButtonClick(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtCliente.EditorButtonClick

        If String.IsNullOrEmpty(Me.txtPeriodo.Text) = True Then
            MsgBox("Seleccione el Período Primero.", MsgBoxStyle.Information, Me.Text)
            Exit Sub
        End If

        Me.txtCliente.Clear()
        Me.txtCliente.Tag = Nothing
        Me.ugData.DataSource = Nothing

        Try

            frmBuscadorCliente.pCliente = True
            frmBuscadorCliente.ShowDialog(Me)
            If i_LlaveBusqueda IsNot Nothing Then
                Me.txtCliente.Tag = i_LlaveBusqueda
                Me.txtCliente.Text = i_LlaveBusqueda2
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub cmdComparar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdComparar.Click

        Try
            Me.ugData.DataSource = Nothing
            Me.ugData.DisplayLayout.Bands(0).Groups.Clear()

            Obj = New PROPeriodoBO(gConnectionString, Me.txtPeriodo.Text)
            lTotalPronosticoAnterior = 0

            Call Me.Validar()

            'Listado Productos
            Dim lTableProductos As DataTable = GetDataTableProtean(String.Format("Select distinct T2.RescObjectID as IdProducto,T2.Resc as Codigo,r.Description as Recurso From coMarketProfile as T0 inner join coTPAssignment as T1 on T1.ParentObjectID = T0.ObjectID and T1.ParentClassID = 10652 and T1.CollectionID = 1 inner join coRescAssignmen as T2 on T2.ParentObjectID = T0.ObjectID AND T2.ParentClassID = 10652 and T2.CollectionID = 1 inner join fdBasResc as r on T2.RescObjectID=r.ObjectID Where T0.EffDatesStart <= {3}ts '{0}-{1}-{2} 23:59:59'{4} and T0.EffDatesEnd >= {3}ts '{0}-{1}-{2} 00:00:00'{4} and T1.TPObjectID = {5}", Obj.FechaCreacion.Year, Obj.FechaCreacion.Month.ToString.PadLeft(2, "0"), Obj.FechaCreacion.Day.ToString.PadLeft(2, "0"), "{", "}", Me.txtCliente.Tag), "Datos")

            Dim lTableDetalle As DataTable = GetDataTable(String.Format("Select IdPeriodo as Periodo,Mes,IdProducto,Cantidad From PRO_PeriodoVendedorDetalle Where IdPeriodo = {0} and IdCliente = {1} Order By Periodo,Mes", Obj.IdPeriodo, Me.txtCliente.Tag), "Datos")

            Dim listP As List(Of Integer) = (From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("Periodo") = Obj.IdPeriodo Select b.Field(Of Integer)("IdProducto")).Distinct.ToList

            Dim lPeriodoInicial As Integer = Obj.IdPeriodo - CInt(Me.txtAniosComparar.Text)
            Dim lTableVentas As DataTable
            Dim lMesInicial As Integer = 0
            Dim lMesFinal As Integer = 0

            If CInt(Me.txtAniosComparar.Text) > 0 Then

                If Me.chkEnero.Checked = True Then
                    lMesInicial = 1
                ElseIf Me.chkFebrero.Checked = True Then
                    lMesInicial = 2
                ElseIf Me.chkMarzo.Checked = True Then
                    lMesInicial = 3
                ElseIf Me.chkAbril.Checked = True Then
                    lMesInicial = 4
                ElseIf Me.chkMayo.Checked = True Then
                    lMesInicial = 5
                ElseIf Me.chkJunio.Checked = True Then
                    lMesInicial = 6
                ElseIf Me.chkJulio.Checked = True Then
                    lMesInicial = 7
                ElseIf Me.chkAgosto.Checked = True Then
                    lMesInicial = 8
                ElseIf Me.chkSeptiembre.Checked = True Then
                    lMesInicial = 9
                ElseIf Me.chkOctubre.Checked = True Then
                    lMesInicial = 10
                ElseIf Me.chkNoviembre.Checked = True Then
                    lMesInicial = 11
                ElseIf Me.chkDiciembre.Checked = True Then
                    lMesInicial = 12
                End If

                If Me.chkDiciembre.Checked = True Then
                    lMesFinal = 12
                ElseIf Me.chkNoviembre.Checked = True Then
                    lMesFinal = 11
                ElseIf Me.chkOctubre.Checked = True Then
                    lMesFinal = 10
                ElseIf Me.chkSeptiembre.Checked = True Then
                    lMesFinal = 9
                ElseIf Me.chkAgosto.Checked = True Then
                    lMesFinal = 8
                ElseIf Me.chkJulio.Checked = True Then
                    lMesFinal = 7
                ElseIf Me.chkJunio.Checked = True Then
                    lMesFinal = 6
                ElseIf Me.chkMayo.Checked = True Then
                    lMesFinal = 5
                ElseIf Me.chkAbril.Checked = True Then
                    lMesFinal = 4
                ElseIf Me.chkMarzo.Checked = True Then
                    lMesFinal = 3
                ElseIf Me.chkFebrero.Checked = True Then
                    lMesFinal = 2
                ElseIf Me.chkEnero.Checked = True Then
                    lMesFinal = 1
                End If

                Dim lDiaFinalPeriodoFinal As Integer = DateTime.DaysInMonth(Obj.IdPeriodo - 1, lMesFinal)
                Dim lWhereCliente As String = String.Empty

                Dim listObjGC As List(Of PROGrupoClienteBO) = PROGrupoClienteBO.GetAllFiltro(gConnectionString, String.Format("Where IdClientePadre = {0}", Me.txtCliente.Tag))
                If listObjGC.Count > 0 Then
                    lWhereCliente = String.Format("Where ShipToTPObjectID in ({0}", Me.txtCliente.Tag)
                    For Each ObjGC As PROGrupoClienteBO In listObjGC
                        lWhereCliente = String.Format("{0},{1}", lWhereCliente, ObjGC.IdClienteHijo)
                    Next
                    lWhereCliente = String.Format("{0})", lWhereCliente)
                Else
                    lWhereCliente = String.Format("Where ShipToTPObjectID = {0}", Me.txtCliente.Tag)
                End If

                lTableVentas = GetDataTableProtean(String.Format("Select RescObjectID as IdProducto,month(FacFecha) as Mes,year(FacFecha) as Periodo,convert(decimal(18,2),sum(CantCaja)) as Cantidad From ucb_coinvcline {0} and FacFecha between convert(datetime,'{1}-{2}-01 00:00:00',102) and convert(datetime,'{3}-{4}-{5} 23:59:59',102) Group By rescobjectid,month(FacFecha),year(FacFecha)", lWhereCliente, lPeriodoInicial, lMesInicial.ToString.PadLeft(2, "0"), Obj.IdPeriodo - 1, lMesFinal.ToString.PadLeft(2, "0"), lDiaFinalPeriodoFinal), "Datos")

            End If

            'Grupo Producto
            Dim gProducto As Infragistics.Win.UltraWinGrid.UltraGridGroup
            gProducto = ugData.DisplayLayout.Bands(0).Groups.Add("gProducto", "Datos Producto")
            gProducto.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            Dim cIdProducto As Infragistics.Win.UltraWinGrid.UltraGridColumn
            cIdProducto = ugData.DisplayLayout.Bands(0).Columns.Add("IdProducto")
            cIdProducto.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            cIdProducto.Width = 100
            cIdProducto.Hidden = True
            Dim cCodigoProducto As Infragistics.Win.UltraWinGrid.UltraGridColumn
            cCodigoProducto = ugData.DisplayLayout.Bands(0).Columns.Add("Codigo", "Código")
            cCodigoProducto.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            cCodigoProducto.Width = 100
            cCodigoProducto.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            Dim cProducto As Infragistics.Win.UltraWinGrid.UltraGridColumn
            cProducto = ugData.DisplayLayout.Bands(0).Columns.Add("Recurso")
            cProducto.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
            cProducto.Width = 250
            cProducto.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            Me.ugData.DisplayLayout.Bands(0).Groups("gProducto").Columns.Add(cIdProducto)
            Me.ugData.DisplayLayout.Bands(0).Groups("gProducto").Columns.Add(cCodigoProducto)
            Me.ugData.DisplayLayout.Bands(0).Groups("gProducto").Columns.Add(cProducto)

            'DataTable con los Datos Finales
            Dim lTableFinal As New DataTable
            lTableFinal.Columns.Add("IdProducto", GetType(Integer))
            lTableFinal.Columns.Add("Codigo", GetType(String))
            lTableFinal.Columns.Add("Recurso", GetType(String))

            'Grupos Meses
            If Me.chkEnero.Checked = True Then
                lTableFinal.Columns.Add("1", GetType(Integer))

                Dim gEnero As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gEnero.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gEnero = ugData.DisplayLayout.Bands(0).Groups.Add("1", NombreMes(1))
                gEnero.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_1", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 1)
                Next
            End If

            If Me.chkFebrero.Checked = True Then
                lTableFinal.Columns.Add("2", GetType(Integer))

                Dim gFebrero As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gFebrero.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gFebrero = ugData.DisplayLayout.Bands(0).Groups.Add("2", NombreMes(2))
                gFebrero.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_2", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 2)
                Next
            End If

            If Me.chkMarzo.Checked = True Then
                lTableFinal.Columns.Add("3", GetType(Integer))

                Dim gMarzo As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gMarzo.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gMarzo = ugData.DisplayLayout.Bands(0).Groups.Add("3", NombreMes(3))
                gMarzo.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_3", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 3)
                Next
            End If

            If Me.chkAbril.Checked = True Then
                lTableFinal.Columns.Add("4", GetType(Integer))

                Dim gAbril As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gAbril.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gAbril = ugData.DisplayLayout.Bands(0).Groups.Add("4", NombreMes(4))
                gAbril.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_4", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 4)
                Next
            End If

            If Me.chkMayo.Checked = True Then
                lTableFinal.Columns.Add("5", GetType(Integer))

                Dim gMayo As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gMayo.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gMayo = ugData.DisplayLayout.Bands(0).Groups.Add("5", NombreMes(5))
                gMayo.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_5", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 5)
                Next
            End If

            If Me.chkJunio.Checked = True Then
                lTableFinal.Columns.Add("6", GetType(Integer))

                Dim gJunio As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gJunio.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gJunio = ugData.DisplayLayout.Bands(0).Groups.Add("6", NombreMes(6))
                gJunio.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_6", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 6)
                Next
            End If

            If Me.chkJulio.Checked = True Then
                lTableFinal.Columns.Add("7", GetType(Integer))

                Dim gJulio As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gJulio.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gJulio = ugData.DisplayLayout.Bands(0).Groups.Add("7", NombreMes(7))
                gJulio.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_7", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 7)
                Next
            End If

            If Me.chkAgosto.Checked = True Then
                lTableFinal.Columns.Add("8", GetType(Integer))

                Dim gAgosto As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gAgosto.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gAgosto = ugData.DisplayLayout.Bands(0).Groups.Add("8", NombreMes(8))
                gAgosto.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_8", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 8)
                Next
            End If

            If Me.chkSeptiembre.Checked = True Then
                lTableFinal.Columns.Add("9", GetType(Integer))

                Dim gSeptiembre As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gSeptiembre.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gSeptiembre = ugData.DisplayLayout.Bands(0).Groups.Add("9", NombreMes(9))
                gSeptiembre.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_9", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 9)
                Next
            End If

            If Me.chkOctubre.Checked = True Then
                lTableFinal.Columns.Add("10", GetType(Integer))

                Dim gOctubre As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gOctubre.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gOctubre = ugData.DisplayLayout.Bands(0).Groups.Add("10", NombreMes(10))
                gOctubre.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_10", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 10)
                Next
            End If

            If Me.chkNoviembre.Checked = True Then
                lTableFinal.Columns.Add("11", GetType(Integer))

                Dim gNoviembre As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gNoviembre.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gNoviembre = ugData.DisplayLayout.Bands(0).Groups.Add("11", NombreMes(11))
                gNoviembre.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_11", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 11)
                Next
            End If

            If Me.chkDiciembre.Checked = True Then
                lTableFinal.Columns.Add("12", GetType(Integer))

                Dim gDiciembre As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gDiciembre.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gDiciembre = ugData.DisplayLayout.Bands(0).Groups.Add("12", NombreMes(12))
                gDiciembre.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                    lTableFinal.Columns.Add(String.Format("{0}_12", i.ToString), GetType(Decimal))
                    Call Me.AgregarColumnaGrupo(i, 12)
                Next
            End If

            Dim gTotal As New Infragistics.Win.UltraWinGrid.UltraGridGroup
            gTotal.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
            gTotal = ugData.DisplayLayout.Bands(0).Groups.Add("Totales", "Totales")
            gTotal.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

            For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                lTableFinal.Columns.Add(String.Format("{0}_Total", i.ToString), GetType(Decimal))

                Dim cTotal As Infragistics.Win.UltraWinGrid.UltraGridColumn
                cTotal = ugData.DisplayLayout.Bands(0).Columns.Add(String.Format("{0}_Total", i.ToString), i.ToString)
                cTotal.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                cTotal.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                cTotal.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                cTotal.DataType = GetType(System.Int32)
                cTotal.Format = "#,###,###"
                cTotal.Width = 70

                Me.ugData.DisplayLayout.Bands(0).Groups("Totales").Columns.Add(cTotal)
            Next

            If CInt(Me.txtAniosComparar.Text) > 0 Then

                Dim gPorcIncremento As New Infragistics.Win.UltraWinGrid.UltraGridGroup
                gPorcIncremento.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                gPorcIncremento = ugData.DisplayLayout.Bands(0).Groups.Add("PorcIncremento", "%")
                gPorcIncremento.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center

                lTableFinal.Columns.Add("PorcentajeIncremento", GetType(Decimal))

                Dim cPorcIncremento As Infragistics.Win.UltraWinGrid.UltraGridColumn
                cPorcIncremento = ugData.DisplayLayout.Bands(0).Columns.Add("PorcentajeIncremento", "Incremento")
                cPorcIncremento.Header.Appearance.TextHAlign = Infragistics.Win.HAlign.Center
                cPorcIncremento.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit
                cPorcIncremento.CellAppearance.TextHAlign = Infragistics.Win.HAlign.Right
                cPorcIncremento.DataType = GetType(Decimal)
                cPorcIncremento.Format = "#,###,###.00"
                cPorcIncremento.Width = 70

                Me.ugData.DisplayLayout.Bands(0).Groups("PorcIncremento").Columns.Add(cPorcIncremento)

            End If

            Dim lDatetime As DateTime
            Dim lFechaActual As New DateTime(Now.Year, Now.Month, 1)
            Dim lTotalAnterior As Decimal = 0
            Dim lTotalActual As Decimal = 0
            Dim lPorcentajeIncremento As Decimal = 0

            For Each lP As Integer In listP
                lTotalActual = 0
                lTotalAnterior = 0
                lPorcentajeIncremento = 0

                Dim lRowProducto As DataRow = (From b In lTableProductos.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP Select b).FirstOrDefault
                If lRowProducto IsNot Nothing Then
                    Dim lRowData As DataRow = lTableFinal.NewRow
                    lRowData("IdProducto") = lP
                    lRowData("Codigo") = lRowProducto("Codigo")
                    lRowData("Recurso") = lRowProducto("Recurso")

                    For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                        Dim lTotal As Decimal = 0

                        If Me.chkEnero.Checked = True Then
                            lRowData("1") = 1
                            lDatetime = New DateTime(i, 1, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_1", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 1 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_1", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_1", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 1 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_1", i.ToString)))
                        End If

                        If Me.chkFebrero.Checked = True Then
                            lRowData("2") = 2
                            lDatetime = New DateTime(i, 2, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_2", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 2 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_2", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_2", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 2 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_2", i.ToString)))
                        End If

                        If Me.chkMarzo.Checked = True Then
                            lRowData("3") = 3
                            lDatetime = New DateTime(i, 3, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_3", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 3 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_3", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_3", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 3 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_3", i.ToString)))
                        End If

                        If Me.chkAbril.Checked = True Then
                            lRowData("4") = 4
                            lDatetime = New DateTime(i, 4, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_4", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 4 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_4", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_4", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 4 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_4", i.ToString)))
                        End If

                        If Me.chkMayo.Checked = True Then
                            lRowData("5") = 5
                            lDatetime = New DateTime(i, 5, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_5", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 5 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_5", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_5", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 5 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_5", i.ToString)))
                        End If

                        If Me.chkJunio.Checked = True Then
                            lRowData("6") = 6
                            lDatetime = New DateTime(i, 6, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_6", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 6 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_6", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_6", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 6 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_6", i.ToString)))
                        End If

                        If Me.chkJulio.Checked = True Then
                            lRowData("7") = 7
                            lDatetime = New DateTime(i, 7, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_7", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 7 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_7", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_7", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 7 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_7", i.ToString)))
                        End If

                        If Me.chkAgosto.Checked = True Then
                            lRowData("8") = 8
                            lDatetime = New DateTime(i, 8, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_8", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 8 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_8", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_8", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 8 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_8", i.ToString)))
                        End If

                        If Me.chkSeptiembre.Checked = True Then
                            lRowData("9") = 9
                            lDatetime = New DateTime(i, 9, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_9", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 9 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_9", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_9", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 9 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_9", i.ToString)))
                        End If

                        If Me.chkOctubre.Checked = True Then
                            lRowData("10") = 10
                            lDatetime = New DateTime(i, 10, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_10", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 10 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_10", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_10", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 10 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_10", i.ToString)))
                        End If

                        If Me.chkNoviembre.Checked = True Then
                            lRowData("11") = 11
                            lDatetime = New DateTime(i, 11, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_11", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 11 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_11", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_11", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 11 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_11", i.ToString)))
                        End If

                        If Me.chkDiciembre.Checked = True Then
                            lRowData("12") = 12
                            lDatetime = New DateTime(i, 11, 1)
                            If lDatetime >= lFechaActual Then
                                If Obj.IdPeriodo = i Then
                                    lRowData(String.Format("{0}_12", i.ToString)) = Math.Round((From b In lTableDetalle.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Mes") = 12 Select b.Field(Of Decimal)("Cantidad")).FirstOrDefault, 0)
                                Else
                                    lRowData(String.Format("{0}_12", i.ToString)) = 0
                                End If
                            Else
                                lRowData(String.Format("{0}_12", i.ToString)) = Math.Round((From b In lTableVentas.AsEnumerable Where b.Field(Of Integer)("IdProducto") = lP And b.Field(Of Integer)("Periodo") = i And b.Field(Of Integer)("Mes") = 12 Select b.Field(Of Decimal)("Cantidad")).Sum, 0)
                            End If
                            lTotal += CInt(lRowData(String.Format("{0}_12", i.ToString)))
                        End If

                        lRowData(String.Format("{0}_Total", i.ToString)) = lTotal

                        If CInt(Me.txtAniosComparar.Text) > 0 Then
                            If i = Obj.IdPeriodo - 1 Then lTotalPronosticoAnterior += lTotal
                        End If
                    Next

                    'Se calcula el porcentaje de incremento
                    If CInt(Me.txtAniosComparar.Text) > 0 Then
                        If CDec(lRowData(String.Format("{0}_Total", Obj.IdPeriodo - 1))) > 0 Then lTotalAnterior = CDec(lRowData(String.Format("{0}_Total", Obj.IdPeriodo - 1)))
                        If CDec(lRowData(String.Format("{0}_Total", Obj.IdPeriodo))) > 0 Then lTotalActual = CDec(lRowData(String.Format("{0}_Total", Obj.IdPeriodo)))

                        If lTotalAnterior > 0 Then
                            lPorcentajeIncremento = Math.Round(((lTotalActual / lTotalAnterior) * 100), 2)

                            If lTotalAnterior > lTotalActual Then
                                lPorcentajeIncremento = (100 - lPorcentajeIncremento)
                                lPorcentajeIncremento *= -1
                            ElseIf lTotalAnterior < lTotalActual Then
                                lPorcentajeIncremento -= 100
                            ElseIf lTotalAnterior = lTotalActual Then
                                lPorcentajeIncremento = 0
                            End If
                        Else
                            lPorcentajeIncremento = 100
                        End If

                        lRowData("PorcentajeIncremento") = lPorcentajeIncremento
                    End If

                    lTableFinal.Rows.Add(lRowData)
                End If
            Next

            Me.ugData.DataSource = lTableFinal
            Me.ugData.DataBind()

            Me.ugData.DisplayLayout.Bands(0).Groups(0).Header.Fixed = True
            If CInt(Me.txtAniosComparar.Text) = 0 Then
                Me.ugData.DisplayLayout.Bands(0).Columns(String.Format("{0}_Total", Obj.IdPeriodo)).SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Descending
            Else
                Me.ugData.DisplayLayout.Bands(0).Columns(String.Format("{0}_Total", Obj.IdPeriodo - 1)).SortIndicator = Infragistics.Win.UltraWinGrid.SortIndicator.Descending

                For Each lRow As Infragistics.Win.UltraWinGrid.UltraGridRow In Me.ugData.Rows
                    For i As Integer = lPeriodoInicial To Obj.IdPeriodo
                        lRow.Cells(String.Format("{0}_Total", i)).Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                    Next

                    If lRow.Cells("PorcentajeIncremento").Value = 0 Then
                        lRow.Cells("PorcentajeIncremento").Appearance.BackColor = Color.Yellow
                    ElseIf lRow.Cells("PorcentajeIncremento").Value > 0 Then
                        lRow.Cells("PorcentajeIncremento").Appearance.BackColor = Color.Green
                    Else
                        lRow.Cells("PorcentajeIncremento").Appearance.BackColor = Color.Red
                    End If

                    lRow.Cells("PorcentajeIncremento").Appearance.FontData.Bold = Infragistics.Win.DefaultableBoolean.True
                Next
            End If

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error al intentar cargar los datos " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub ugData_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ugData.KeyDown

        Select Case e.KeyCode
            Case Keys.Up
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode)
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.AboveCell)
                e.Handled = True
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
            Case Keys.Down
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode)
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.BelowCell)
                e.Handled = True
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
            Case Keys.Right
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode)
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.NextCellByTab)
                e.Handled = True
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
            Case Keys.Left
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode)
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.PrevCellByTab)
                e.Handled = True
                Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.EnterEditMode)
        End Select

    End Sub


    Private Sub cmdExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportar.Click

        If Not CheckAccess(gConnectionString, gUsuario, Me.Name, 6) Then
            MsgBox("Sin acceso para ejecutar la opción", MsgBoxStyle.Critical, "Seguridad del sistema")
            Exit Sub
        End If

        If Me.ugData.Rows.Count > 0 Then
            Dim lWoorkBook As New Workbook()
            Dim lWorkSheet As Worksheet = lWoorkBook.Worksheets.Add("Hoja1")

            Me.ugData.DisplayLayout.Bands(0).GroupHeadersVisible = True
            Dim currentCol = 0
            For Each group In Me.ugData.DisplayLayout.Bands(0).Groups.All.Cast(Of UltraGridGroup).Where(Function(b) Not b.Hidden).OrderBy(Function(b) b.Header.VisiblePosition)
                Dim groupSize = group.Columns.All.Cast(Of UltraGridColumn)().Count(Function(b) b.IsVisibleInLayout)
                If groupSize = 0 Then
                    Continue For
                End If

                lWorkSheet.MergedCellsRegions.Add(0, currentCol, 0, currentCol + groupSize - 1)
                lWorkSheet.MergedCellsRegions.Last().Value = group.Header.Caption
                currentCol += groupSize
            Next

            Dim SaveDlg As New SaveFileDialog
            SaveDlg.CheckPathExists = True
            SaveDlg.DefaultExt = "Excel WorkBook (*.xls)"
            SaveDlg.Filter = "Excel WorkBook (*.xls)|*.xls"
            SaveDlg.OverwritePrompt = True
            If SaveDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim UGE As New Infragistics.Win.UltraWinGrid.ExcelExport.UltraGridExcelExporter
                UGE.Export(ugData, lWorkSheet, 1, 0)
                lWoorkBook.Save(SaveDlg.FileName)
                MsgBox("Exportado con Éxito.", MsgBoxStyle.Information, "Información")
            End If

        End If

    End Sub


    Private Sub cmdSeleccionarMeses_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdSeleccionarMeses.ItemClick

        Me.chkEnero.Checked = True
        Me.chkFebrero.Checked = True
        Me.chkMarzo.Checked = True
        Me.chkAbril.Checked = True
        Me.chkMayo.Checked = True
        Me.chkJunio.Checked = True
        Me.chkJulio.Checked = True
        Me.chkAgosto.Checked = True
        Me.chkSeptiembre.Checked = True
        Me.chkOctubre.Checked = True
        Me.chkNoviembre.Checked = True
        Me.chkDiciembre.Checked = True

    End Sub


    Private Sub cmdDeseleccionarMeses_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdDeseleccionarMeses.ItemClick

        Me.chkEnero.Checked = False
        Me.chkFebrero.Checked = False
        Me.chkMarzo.Checked = False
        Me.chkAbril.Checked = False
        Me.chkMayo.Checked = False
        Me.chkJunio.Checked = False
        Me.chkJulio.Checked = False
        Me.chkAgosto.Checked = False
        Me.chkSeptiembre.Checked = False
        Me.chkOctubre.Checked = False
        Me.chkNoviembre.Checked = False
        Me.chkDiciembre.Checked = False

    End Sub


    Private Sub cmdMostrarPorcentajeGlobal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMostrarPorcentajeGlobal.Click

        Try

            Call Me.Validar()

            If CInt(Me.txtAniosComparar.Text) = 0 Then
                MsgBox("Debe tener ingresado al menos un mes para comparar.", MsgBoxStyle.Information, Me.Text)
                Exit Sub
            End If

            Me.ugData.PerformAction(Infragistics.Win.UltraWinGrid.UltraGridAction.ExitEditMode)
            Me.ugData.UpdateData()

            Dim lTotalActual As Decimal = 0

            For Each lRow As Infragistics.Win.UltraWinGrid.UltraGridRow In Me.ugData.Rows
                lTotalActual += CDec(lRow.Cells(String.Format("{0}_Total", Obj.IdPeriodo)).Value)
            Next

            Dim lPorcentajeIncremento As Decimal

            If lTotalPronosticoAnterior > 0 Then
                lPorcentajeIncremento = Math.Round(((lTotalActual / lTotalPronosticoAnterior) * 100), 2)

                If lTotalPronosticoAnterior > lTotalActual Then
                    lPorcentajeIncremento = (100 - lPorcentajeIncremento)
                    lPorcentajeIncremento *= -1
                ElseIf lTotalPronosticoAnterior < lTotalActual Then
                    lPorcentajeIncremento -= 100
                ElseIf lTotalPronosticoAnterior = lTotalActual Then
                    lPorcentajeIncremento = 0
                End If
            Else
                lPorcentajeIncremento = 100
            End If

            frmPopUpPronosticoPorcentajeGlobal.pPorcentaje = lPorcentajeIncremento
            frmPopUpPronosticoPorcentajeGlobal.ShowDialog(Me)

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("Error al intentar cargar los datos " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub

End Class