<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteClientesConPronosticoIngresado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReporteClientesConPronosticoIngresado))
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim UltraDataColumn13 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdPeriodoContable")
        Dim UltraDataColumn14 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdEjercicioContable")
        Dim UltraDataColumn15 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdGrupoEmpresa")
        Dim UltraDataColumn16 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaInicio")
        Dim UltraDataColumn17 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaFin")
        Dim UltraDataColumn18 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cerrado")
        Dim UltraDataColumn19 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("UsuarioCerro")
        Dim UltraDataColumn20 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCierre")
        Dim UltraDataColumn21 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("PeriodoAjuste")
        Dim UltraDataColumn22 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CreadoPor")
        Dim UltraDataColumn23 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCreacion")
        Dim UltraDataColumn24 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IsNew")
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.DockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
        Me.cmdNuevo = New DevExpress.XtraBars.BarLargeButtonItem
        Me.cmdGrabar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.cmdEditar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem
        Me.cmdEliminar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem
        Me.cmdCancelar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.cmdBuscar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.cmdCerrar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtVendedor = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnFiltrar = New DevExpress.XtraEditors.SimpleButton
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.udsPeriodo = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.gFile = New System.Windows.Forms.OpenFileDialog
        Me.sFile = New System.Windows.Forms.FolderBrowserDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.txtVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.udsPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.DockManager = Me.DockManager1
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdNuevo, Me.cmdGrabar, Me.cmdEditar, Me.BarStaticItem1, Me.cmdEliminar, Me.BarStaticItem3, Me.cmdCancelar, Me.cmdBuscar, Me.cmdCerrar})
        Me.BarManager1.MaxItemId = 11
        Me.BarManager1.MdiMenuMergeStyle = DevExpress.XtraBars.BarMdiMenuMergeStyle.Always
        '
        'barDockControlTop
        '
        Me.barDockControlTop.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.barDockControlTop.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.barDockControlTop.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.barDockControlTop.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.barDockControlTop.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.barDockControlTop.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(687, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.barDockControlBottom.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.barDockControlBottom.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.barDockControlBottom.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.barDockControlBottom.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.barDockControlBottom.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 627)
        Me.barDockControlBottom.Size = New System.Drawing.Size(687, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.barDockControlLeft.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.barDockControlLeft.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.barDockControlLeft.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.barDockControlLeft.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.barDockControlLeft.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 627)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.barDockControlRight.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.barDockControlRight.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.barDockControlRight.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.barDockControlRight.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.barDockControlRight.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(687, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 627)
        '
        'DockManager1
        '
        Me.DockManager1.DockMode = DevExpress.XtraBars.Docking.Helpers.DockMode.VS2005
        Me.DockManager1.Form = Me
        Me.DockManager1.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.cmdNuevo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdNuevo.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdNuevo.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.cmdNuevo.Caption = "Nuevo"
        Me.cmdNuevo.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Bottom
        Me.cmdNuevo.Id = 0
        Me.cmdNuevo.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.cmdNuevo.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.cmdGrabar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdGrabar.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdGrabar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.cmdGrabar.Caption = "Grabar"
        Me.cmdGrabar.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Bottom
        Me.cmdGrabar.Id = 1
        Me.cmdGrabar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.cmdGrabar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'cmdEditar
        '
        Me.cmdEditar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.cmdEditar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdEditar.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdEditar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.cmdEditar.Caption = "Editar"
        Me.cmdEditar.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Bottom
        Me.cmdEditar.Id = 2
        Me.cmdEditar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.cmdEditar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.cmdEditar.Name = "cmdEditar"
        Me.cmdEditar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarStaticItem1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarStaticItem1.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Content
        Me.BarStaticItem1.Caption = "|"
        Me.BarStaticItem1.Id = 3
        Me.BarStaticItem1.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarStaticItem1.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarStaticItem1.Name = "BarStaticItem1"
        Me.BarStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarStaticItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.cmdEliminar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdEliminar.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdEliminar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.cmdEliminar.Caption = "Eliminar"
        Me.cmdEliminar.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Bottom
        Me.cmdEliminar.Id = 4
        Me.cmdEliminar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.cmdEliminar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarStaticItem3
        '
        Me.BarStaticItem3.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarStaticItem3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarStaticItem3.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarStaticItem3.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Content
        Me.BarStaticItem3.Caption = "|"
        Me.BarStaticItem3.Id = 5
        Me.BarStaticItem3.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarStaticItem3.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarStaticItem3.Name = "BarStaticItem3"
        Me.BarStaticItem3.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarStaticItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.cmdCancelar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdCancelar.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdCancelar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.cmdCancelar.Caption = "Cancelar"
        Me.cmdCancelar.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Bottom
        Me.cmdCancelar.Id = 6
        Me.cmdCancelar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.cmdCancelar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.cmdBuscar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdBuscar.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdBuscar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.cmdBuscar.Caption = "Buscar"
        Me.cmdBuscar.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Bottom
        Me.cmdBuscar.Id = 7
        Me.cmdBuscar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.cmdBuscar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.cmdCerrar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdCerrar.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdCerrar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.cmdCerrar.Caption = "Cerrar"
        Me.cmdCerrar.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Bottom
        Me.cmdCerrar.Id = 8
        Me.cmdCerrar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.cmdCerrar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'BarStaticItem2
        '
        Me.BarStaticItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.BarStaticItem2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarStaticItem2.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.BarStaticItem2.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Content
        Me.BarStaticItem2.Caption = "|"
        Me.BarStaticItem2.Id = 3
        Me.BarStaticItem2.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.BarStaticItem2.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.BarStaticItem2.Name = "BarStaticItem2"
        Me.BarStaticItem2.TextAlignment = System.Drawing.StringAlignment.Near
        Me.BarStaticItem2.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PanelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PanelControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PanelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PanelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PanelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PanelControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.PanelControl1.Controls.Add(Me.GroupControl2)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(687, 627)
        Me.PanelControl1.TabIndex = 4
        '
        'GroupControl2
        '
        Me.GroupControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl2.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl2.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl2.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl2.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.[Default]
        Me.GroupControl2.CaptionLocation = DevExpress.Utils.Locations.[Default]
        Me.GroupControl2.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.GroupControl2.Controls.Add(Me.GroupControl3)
        Me.GroupControl2.Controls.Add(Me.XtraTabControl1)
        Me.GroupControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupControl2.Location = New System.Drawing.Point(2, 2)
        Me.GroupControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(683, 623)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Clientes con Pronóstico Ingresado"
        '
        'GroupControl3
        '
        Me.GroupControl3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupControl3.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl3.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl3.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl3.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl3.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl3.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl3.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl3.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl3.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl3.CaptionImage = CType(resources.GetObject("GroupControl3.CaptionImage"), System.Drawing.Image)
        Me.GroupControl3.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.[Default]
        Me.GroupControl3.CaptionLocation = DevExpress.Utils.Locations.[Default]
        Me.GroupControl3.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.GroupControl3.Controls.Add(Me.dtpPeriodo)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.txtVendedor)
        Me.GroupControl3.Controls.Add(Me.btnFiltrar)
        Me.GroupControl3.Location = New System.Drawing.Point(198, 52)
        Me.GroupControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(287, 549)
        Me.GroupControl3.TabIndex = 0
        Me.GroupControl3.Text = "Filtros:"
        '
        'LabelControl2
        '
        Me.LabelControl2.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.LabelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LabelControl2.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LabelControl2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LabelControl2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LabelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LabelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.LabelControl2.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.LabelControl2.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.LabelControl2.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.LabelControl2.Location = New System.Drawing.Point(5, 27)
        Me.LabelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl2.TabIndex = 150
        Me.LabelControl2.Text = "Vendedor:"
        Me.LabelControl2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'txtVendedor
        '
        Me.txtVendedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        EditorButton2.Text = "..."
        Me.txtVendedor.ButtonsLeft.Add(EditorButton2)
        Me.txtVendedor.Location = New System.Drawing.Point(5, 46)
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.ReadOnly = True
        Me.txtVendedor.Size = New System.Drawing.Size(277, 21)
        Me.txtVendedor.TabIndex = 1
        '
        'btnFiltrar
        '
        Me.btnFiltrar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnFiltrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFiltrar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnFiltrar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnFiltrar.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnFiltrar.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnFiltrar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnFiltrar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnFiltrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnFiltrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnFiltrar.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnFiltrar.Location = New System.Drawing.Point(207, 73)
        Me.btnFiltrar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 3
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabControl1.AppearancePage.Header.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabControl1.AppearancePage.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabControl1.AppearancePage.Header.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabControl1.AppearancePage.Header.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabControl1.AppearancePage.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabControl1.AppearancePage.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabControl1.AppearancePage.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabControl1.AppearancePage.HeaderDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabControl1.AppearancePage.HeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabControl1.AppearancePage.PageClient.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabControl1.AppearancePage.PageClient.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabControl1.AppearancePage.PageClient.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabControl1.AppearancePage.PageClient.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabControl1.AppearancePage.PageClient.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabControl1.AppearancePage.PageClient.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.XtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.XtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.[Default]
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabControl1.HeaderButtons = DevExpress.XtraTab.TabButtons.[Default]
        Me.XtraTabControl1.HeaderButtonsShowMode = DevExpress.XtraTab.TabButtonShowMode.[Default]
        Me.XtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Top
        Me.XtraTabControl1.HeaderOrientation = DevExpress.XtraTab.TabOrientation.[Default]
        Me.XtraTabControl1.Location = New System.Drawing.Point(2, 22)
        Me.XtraTabControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.XtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Near
        Me.XtraTabControl1.PaintStyleName = "Flat"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabControl1.ShowToolTips = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabControl1.Size = New System.Drawing.Size(679, 599)
        Me.XtraTabControl1.TabIndex = 1
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.Header.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabPage1.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabPage1.Appearance.Header.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabPage1.Appearance.Header.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabPage1.Appearance.Header.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabPage1.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabPage1.Appearance.HeaderActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabPage1.Appearance.HeaderActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabPage1.Appearance.HeaderActive.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabPage1.Appearance.HeaderActive.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabPage1.Appearance.HeaderActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabPage1.Appearance.HeaderActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabPage1.Appearance.HeaderDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabPage1.Appearance.HeaderDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabPage1.Appearance.HeaderDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabPage1.Appearance.HeaderDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabPage1.Appearance.HeaderDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabPage1.Appearance.HeaderDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabPage1.Appearance.HeaderHotTracked.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabPage1.Appearance.HeaderHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabPage1.Appearance.HeaderHotTracked.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabPage1.Appearance.HeaderHotTracked.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabPage1.Appearance.HeaderHotTracked.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabPage1.Appearance.HeaderHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabPage1.Appearance.PageClient.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.XtraTabPage1.Appearance.PageClient.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.XtraTabPage1.Appearance.PageClient.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.XtraTabPage1.Appearance.PageClient.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.XtraTabPage1.Appearance.PageClient.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.XtraTabPage1.Appearance.PageClient.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.XtraTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.XtraTabPage1.Controls.Add(Me.CrystalReportViewer1)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.[Default]
        Me.XtraTabPage1.Size = New System.Drawing.Size(679, 577)
        Me.XtraTabPage1.Text = "Reporte"
        Me.XtraTabPage1.TooltipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(679, 577)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'udsPeriodo
        '
        Me.udsPeriodo.AllowAdd = False
        Me.udsPeriodo.AllowDelete = False
        UltraDataColumn13.DataType = GetType(Integer)
        UltraDataColumn14.DataType = GetType(Integer)
        UltraDataColumn15.DataType = GetType(Integer)
        UltraDataColumn16.DataType = GetType(Date)
        UltraDataColumn17.DataType = GetType(Date)
        UltraDataColumn18.DataType = GetType(Boolean)
        UltraDataColumn20.DataType = GetType(Date)
        UltraDataColumn21.DataType = GetType(Boolean)
        UltraDataColumn23.DataType = GetType(Date)
        UltraDataColumn24.DataType = GetType(Boolean)
        Me.udsPeriodo.Band.Columns.AddRange(New Object() {UltraDataColumn13, UltraDataColumn14, UltraDataColumn15, UltraDataColumn16, UltraDataColumn17, UltraDataColumn18, UltraDataColumn19, UltraDataColumn20, UltraDataColumn21, UltraDataColumn22, UltraDataColumn23, UltraDataColumn24})
        '
        'gFile
        '
        Me.gFile.Title = "Seleccione la imagen o documento a adjuntar a la fórmula"
        '
        'sFile
        '
        Me.sFile.Description = "Seleccione el lugar donde desea grabar el archivo."
        '
        'LabelControl1
        '
        Me.LabelControl1.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.LabelControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.LabelControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.LabelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.LabelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.LabelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.LabelControl1.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.LabelControl1.Location = New System.Drawing.Point(5, 77)
        Me.LabelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl1.TabIndex = 151
        Me.LabelControl1.Text = "Período:"
        Me.LabelControl1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "yyyy"
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodo.Location = New System.Drawing.Point(51, 73)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.ShowUpDown = True
        Me.dtpPeriodo.Size = New System.Drawing.Size(61, 20)
        Me.dtpPeriodo.TabIndex = 152
        '
        'frmReporteClientesConPronosticoIngresado
        '
        Me.AcceptButton = Me.btnFiltrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 627)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "frmReporteClientesConPronosticoIngresado"
        Me.Text = "Reportes - Clientes con Pronóstico Ingresado"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DockManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.txtVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.udsPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdNuevo As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents cmdGrabar As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents cmdEditar As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents cmdEliminar As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents cmdCancelar As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents cmdBuscar As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents cmdCerrar As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents gFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sFile As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents udsPeriodo As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents DockManager1 As DevExpress.XtraBars.Docking.DockManager
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btnFiltrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtVendedor As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
