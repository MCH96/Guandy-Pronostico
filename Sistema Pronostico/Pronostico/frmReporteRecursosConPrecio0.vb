Imports CrystalDecisions.CrystalReports

Public Class frmReporteRecursosConPrecio0


    Private Sub frmReporteRecursosConPrecio0_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim iX As DevExpress.XtraBars.Docking.DockPanel
        iX = DockManager1.AddPanel(DevExpress.XtraBars.Docking.DockingStyle.Left)
        iX.Text = "Filtros"
        iX.Width = 275
        GroupControl3.Dock = DockStyle.Fill
        iX.ControlContainer.Controls.Add(GroupControl3)
        DockManager1.ActivePanel = iX

        CrystalReportViewer1.ShowExportButton = CheckAccess(gConnectionString, gUsuario, Me.Name, 5)
        CrystalReportViewer1.ShowPrintButton = CheckAccess(gConnectionString, gUsuario, Me.Name, 6)

    End Sub


    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click

        Dim lLlave As Guid = Guid.NewGuid

        Try
            If String.IsNullOrEmpty(Me.txtPeriodo.Text) = True Then Throw New Exception("Seleccione un Período.")

            Dim lTableRecursos As DataTable = GetDataTableProtean("Select ObjectID as IdRecurso,resourceUK as Codigo,Description as Recurso From fdBasResc Where ResourceUKSite = 'TROP'", "Recursos")

            Dim lTableSocios As DataTable = GetDataTableProtean("Select ObjectID_Socio_Negcio as IdSocio,Socio_Negocio as Codigo, Nombre_Socio_Negocio as Socio From view_Cubo_SocioxPais", "Recursos")

            'Se carga la tabla temporal de lista de precios
            Dim lTable As DataTable = BOGeneral.GetDataTable(gConnectionStringProtean, String.Format("Select a.RescID,a.TPID,'{0}' as IdLlave,a.Codigo_Recurso,a.Codigo_Socio,case when Moneda<>'GTQ' THEN (SELECT TasaCambio FROM qv_tasacambio_actual) ELSE 1 END * ISNULL(a.[Precio Caja],0) as PrecioCaja From USR_VW_LST_PREC as a inner join (Select RescID,TPID,MAX([Fecha Fin]) as Fecha From USR_VW_LST_PREC group by RescID,TPID) as b on a.RescID=b.RescID and a.TPID=b.TPID and a.[Fecha Fin] = b.Fecha", lLlave), "Datos")
            BOGeneral.InsertTable(gConnectionString, lTable, "TEMP_PeriodoEnvioProtean")

            'Se traen los datos del pronostico y se valida que no existan precios en 0
            lTable = BOGeneral.GetDataTable(gConnectionString, String.Format("Select distinct p.IdProducto,p.IdCliente From PRO_PeriodoVendedorDetalle as p left join TEMP_PeriodoEnvioProtean as t on p.IdCliente=t.TPID and p.IdProducto=t.RescID and t.IdLlave='{0}' Where p.IdPeriodo={1} and p.Cantidad > 0 and (p.Cantidad * isnull(t.PrecioCaja,0)) = 0", lLlave, CInt(Me.txtPeriodo.Text)), "Pronostico")

            Dim lTableFinal As New DataTable("Datos")
            lTableFinal.Columns.Add("CodigoSocio", GetType(String))
            lTableFinal.Columns.Add("Socio", GetType(String))
            lTableFinal.Columns.Add("CodigoRecurso", GetType(String))
            lTableFinal.Columns.Add("Recurso", GetType(String))

            For Each lRow As DataRow In lTable.Rows

                Dim lRowS As DataRow = (From b In lTableSocios.AsEnumerable Where b.Field(Of Integer)("IdSocio") = lRow("IdCliente")).FirstOrDefault
                Dim lRowR As DataRow = (From b In lTableRecursos.AsEnumerable Where b.Field(Of Integer)("IdRecurso") = lRow("IdProducto")).FirstOrDefault

                Dim lRowData As DataRow = lTableFinal.Rows.Add
                lRowData("CodigoSocio") = lRowS("Codigo")
                lRowData("Socio") = lRowS("Socio")
                lRowData("CodigoRecurso") = lRowR("Codigo")
                lRowData("Recurso") = lRowR("Recurso")
                lTableFinal.Rows.Add("Recurso")

            Next

            Dim lFormulario As New frmReporte
            Dim lDS As New DSPRO_RecursosConPrecio0
            Dim lReporte As New rptPRO_RecursosConPrecio0

            lDS.Tables("Datos").Merge(lTableFinal)

            For Each thisFormulaField In lReporte.DataDefinition.FormulaFields
                Select Case thisFormulaField.FormulaName

                    Case "{@NombreEmpresa}"
                        thisFormulaField.Text = "'GUANDY'"
                    Case "{@Titulo}"
                        thisFormulaField.Text = "'Recursos con Precio 0'"
                    Case "{@Usuario}"
                        thisFormulaField.Text = String.Format("'{0}'", gUsuario)

                End Select

            Next

            lReporte.SetDataSource(lDS)
            CrystalReportViewer1.ReportSource = lReporte
            CrystalReportViewer1.Refresh()

            BOGeneral.ExecuteSQL(gConnectionString, String.Format("Delete TEMP_PeriodoEnvioProtean Where IdLlave='{0}'", lLlave))

        Catch ex As Exception
            BOGeneral.ExecuteSQL(gConnectionString, String.Format("Delete TEMP_PeriodoEnvioProtean Where IdLlave='{0}'", lLlave))
            MsgBox("Error al ejecutar reporte: " & ex.Message, MsgBoxStyle.Critical, "")
        End Try

    End Sub


    Private Sub txtPeriodo_EditorButtonClick(ByVal sender As Object, ByVal e As Infragistics.Win.UltraWinEditors.EditorButtonEventArgs) Handles txtPeriodo.EditorButtonClick

        Me.txtPeriodo.Text = String.Empty

        Dim iDatos As DataTable = GetDataTable("Select IdPeriodo as [Período] From PRO_Periodo Order By IdPeriodo", "Busqueda")
        Dim lCodigo As Object = MostrarBuscador("Busqueda", iDatos, "Busqueda")

        If lCodigo IsNot Nothing AndAlso IsNumeric(lCodigo) Then
            Me.txtPeriodo.Text = lCodigo
        End If

    End Sub

End Class