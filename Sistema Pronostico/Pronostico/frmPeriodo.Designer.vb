﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeriodo
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
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraGridBand1 As Infragistics.Win.UltraWinGrid.UltraGridBand = New Infragistics.Win.UltraWinGrid.UltraGridBand("Band 0", -1)
        Dim UltraGridColumn1 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("IdMes")
        Dim UltraGridColumn2 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Mes")
        Dim UltraGridColumn3 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cerrado")
        Dim UltraGridColumn4 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("CerradoPor")
        Dim UltraGridColumn5 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("FechaCierre")
        Dim UltraGridColumn6 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Cerrar")
        Dim UltraGridColumn7 As Infragistics.Win.UltraWinGrid.UltraGridColumn = New Infragistics.Win.UltraWinGrid.UltraGridColumn("Abrir")
        Dim Appearance4 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance5 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance6 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance7 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance8 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance9 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance10 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance13 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim Appearance14 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim UltraDataColumn1 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("IdMes")
        Dim UltraDataColumn2 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Mes")
        Dim UltraDataColumn3 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cerrado")
        Dim UltraDataColumn4 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("CerradoPor")
        Dim UltraDataColumn5 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("FechaCierre")
        Dim UltraDataColumn6 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Cerrar")
        Dim UltraDataColumn7 As Infragistics.Win.UltraWinDataSource.UltraDataColumn = New Infragistics.Win.UltraWinDataSource.UltraDataColumn("Abrir")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPeriodo))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.cmdNuevoo = New DevExpress.XtraBars.BarButtonItem
        Me.cmdEliminar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem
        Me.cmdGrabar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.cmdCancelar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.BarStaticItem3 = New DevExpress.XtraBars.BarStaticItem
        Me.cmdBuscar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.cmdCerrar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem
        Me.gFile = New System.Windows.Forms.OpenFileDialog
        Me.sFile = New System.Windows.Forms.FolderBrowserDialog
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.lblEstado = New DevExpress.XtraEditors.LabelControl
        Me.dtpPeriodo = New System.Windows.Forms.DateTimePicker
        Me.lblCodigo = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.ugData = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.udsData = New Infragistics.Win.UltraWinDataSource.UltraDataSource(Me.components)
        Me.cmdNuevo = New DevExpress.XtraBars.BarLargeButtonItem
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ugData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdGrabar, Me.BarStaticItem1, Me.cmdEliminar, Me.BarStaticItem3, Me.cmdCancelar, Me.cmdBuscar, Me.cmdCerrar, Me.cmdNuevoo})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 12
        Me.BarManager1.MdiMenuMergeStyle = DevExpress.XtraBars.BarMdiMenuMergeStyle.Always
        '
        'Bar2
        '
        Me.Bar2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.Bar2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.Bar2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.Bar2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.Bar2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.Bar2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.Bar2.BarName = "Main menu"
        Me.Bar2.CanDockStyle = CType((((((DevExpress.XtraBars.BarCanDockStyle.Floating Or DevExpress.XtraBars.BarCanDockStyle.Left) _
                    Or DevExpress.XtraBars.BarCanDockStyle.Top) _
                    Or DevExpress.XtraBars.BarCanDockStyle.Right) _
                    Or DevExpress.XtraBars.BarCanDockStyle.Bottom) _
                    Or DevExpress.XtraBars.BarCanDockStyle.Standalone), DevExpress.XtraBars.BarCanDockStyle)
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 0
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdNuevoo), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdEliminar), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdGrabar), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdCancelar), New DevExpress.XtraBars.LinkPersistInfo(Me.BarStaticItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdBuscar), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdCerrar)})
        Me.Bar2.OptionsBar.BarState = DevExpress.XtraBars.BarState.Expanded
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'cmdNuevoo
        '
        Me.cmdNuevoo.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.cmdNuevoo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdNuevoo.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdNuevoo.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.cmdNuevoo.Caption = "Nuevo"
        Me.cmdNuevoo.Id = 11
        Me.cmdNuevoo.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.cmdNuevoo.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.cmdNuevoo.Name = "cmdNuevoo"
        Me.cmdNuevoo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
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
        'cmdGrabar
        '
        Me.cmdGrabar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.cmdGrabar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdGrabar.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.cmdGrabar.Caption = "Grabar"
        Me.cmdGrabar.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Bottom
        Me.cmdGrabar.Id = 1
        Me.cmdGrabar.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.cmdGrabar.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
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
        Me.barDockControlTop.Size = New System.Drawing.Size(730, 24)
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 445)
        Me.barDockControlBottom.Size = New System.Drawing.Size(730, 0)
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
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 421)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(730, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 421)
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
        'gFile
        '
        Me.gFile.Title = "Seleccione la imagen o documento a adjuntar a la fórmula"
        '
        'sFile
        '
        Me.sFile.Description = "Seleccione el lugar donde desea grabar el archivo."
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl1.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl1.AppearanceCaption.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.GroupControl1.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.GroupControl1.AppearanceCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.GroupControl1.CaptionImageLocation = DevExpress.Utils.GroupElementLocation.[Default]
        Me.GroupControl1.CaptionLocation = DevExpress.Utils.Locations.[Default]
        Me.GroupControl1.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.GroupControl1.Controls.Add(Me.lblEstado)
        Me.GroupControl1.Controls.Add(Me.dtpPeriodo)
        Me.GroupControl1.Controls.Add(Me.lblCodigo)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 6)
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(264, 53)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Datos Generales"
        '
        'lblEstado
        '
        Me.lblEstado.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblEstado.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblEstado.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblEstado.Appearance.Options.UseFont = True
        Me.lblEstado.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblEstado.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblEstado.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblEstado.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblEstado.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblEstado.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblEstado.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblEstado.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblEstado.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblEstado.Location = New System.Drawing.Point(154, 26)
        Me.lblEstado.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(55, 19)
        Me.lblEstado.TabIndex = 8
        Me.lblEstado.Text = "Estado"
        Me.lblEstado.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'dtpPeriodo
        '
        Me.dtpPeriodo.CustomFormat = "yyyy"
        Me.dtpPeriodo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpPeriodo.Location = New System.Drawing.Point(53, 25)
        Me.dtpPeriodo.Name = "dtpPeriodo"
        Me.dtpPeriodo.ShowUpDown = True
        Me.dtpPeriodo.Size = New System.Drawing.Size(95, 20)
        Me.dtpPeriodo.TabIndex = 7
        '
        'lblCodigo
        '
        Me.lblCodigo.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblCodigo.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblCodigo.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCodigo.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblCodigo.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblCodigo.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblCodigo.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblCodigo.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblCodigo.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblCodigo.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblCodigo.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblCodigo.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblCodigo.Location = New System.Drawing.Point(8, 28)
        Me.lblCodigo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 6
        Me.lblCodigo.Text = "Período:"
        Me.lblCodigo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
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
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 24)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(730, 421)
        Me.PanelControl1.TabIndex = 4
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GroupControl2.Controls.Add(Me.ugData)
        Me.GroupControl2.Location = New System.Drawing.Point(5, 65)
        Me.GroupControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(720, 351)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Datos Generales"
        '
        'ugData
        '
        Me.ugData.DataSource = Me.udsData
        Appearance2.BackColor = System.Drawing.SystemColors.Window
        Appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugData.DisplayLayout.Appearance = Appearance2
        Me.ugData.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns
        UltraGridColumn1.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn1.Header.VisiblePosition = 0
        UltraGridColumn1.Hidden = True
        UltraGridColumn1.Width = 54
        UltraGridColumn2.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn2.Header.VisiblePosition = 1
        UltraGridColumn2.Width = 137
        UltraGridColumn3.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn3.Header.VisiblePosition = 2
        UltraGridColumn3.Width = 125
        UltraGridColumn4.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn4.Header.Caption = "Cerrado Por"
        UltraGridColumn4.Header.VisiblePosition = 3
        UltraGridColumn4.Width = 110
        UltraGridColumn5.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn5.Format = "dd/MMM/yyyy"
        UltraGridColumn5.Header.Caption = "Fecha Cierre"
        UltraGridColumn5.Header.VisiblePosition = 4
        UltraGridColumn5.Width = 106
        UltraGridColumn6.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn6.Header.VisiblePosition = 5
        UltraGridColumn6.Width = 118
        UltraGridColumn7.AutoCompleteMode = Infragistics.Win.AutoCompleteMode.Append
        UltraGridColumn7.Header.VisiblePosition = 6
        UltraGridColumn7.Width = 118
        UltraGridBand1.Columns.AddRange(New Object() {UltraGridColumn1, UltraGridColumn2, UltraGridColumn3, UltraGridColumn4, UltraGridColumn5, UltraGridColumn6, UltraGridColumn7})
        UltraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect
        Me.ugData.DisplayLayout.BandsSerializer.Add(UltraGridBand1)
        Me.ugData.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Me.ugData.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.[False]
        Appearance4.BackColor = System.Drawing.SystemColors.ActiveBorder
        Appearance4.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical
        Appearance4.BorderColor = System.Drawing.SystemColors.Window
        Me.ugData.DisplayLayout.GroupByBox.Appearance = Appearance4
        Appearance5.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugData.DisplayLayout.GroupByBox.BandLabelAppearance = Appearance5
        Me.ugData.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid
        Appearance6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Appearance6.BackColor2 = System.Drawing.SystemColors.Control
        Appearance6.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance6.ForeColor = System.Drawing.SystemColors.GrayText
        Me.ugData.DisplayLayout.GroupByBox.PromptAppearance = Appearance6
        Me.ugData.DisplayLayout.MaxColScrollRegions = 1
        Me.ugData.DisplayLayout.MaxRowScrollRegions = 1
        Appearance7.BackColor = System.Drawing.SystemColors.Window
        Appearance7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ugData.DisplayLayout.Override.ActiveCellAppearance = Appearance7
        Appearance8.BackColor = System.Drawing.SystemColors.Highlight
        Appearance8.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ugData.DisplayLayout.Override.ActiveRowAppearance = Appearance8
        Me.ugData.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted
        Me.ugData.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted
        Appearance9.BackColor = System.Drawing.SystemColors.Window
        Me.ugData.DisplayLayout.Override.CardAreaAppearance = Appearance9
        Appearance10.BorderColor = System.Drawing.Color.Silver
        Appearance10.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter
        Me.ugData.DisplayLayout.Override.CellAppearance = Appearance10
        Me.ugData.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText
        Me.ugData.DisplayLayout.Override.CellPadding = 0
        Appearance11.BackColor = System.Drawing.SystemColors.Control
        Appearance11.BackColor2 = System.Drawing.SystemColors.ControlDark
        Appearance11.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element
        Appearance11.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal
        Appearance11.BorderColor = System.Drawing.SystemColors.Window
        Me.ugData.DisplayLayout.Override.GroupByRowAppearance = Appearance11
        Appearance12.TextHAlignAsString = "Left"
        Me.ugData.DisplayLayout.Override.HeaderAppearance = Appearance12
        Me.ugData.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti
        Me.ugData.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand
        Appearance13.BackColor = System.Drawing.SystemColors.Window
        Appearance13.BorderColor = System.Drawing.Color.Silver
        Me.ugData.DisplayLayout.Override.RowAppearance = Appearance13
        Me.ugData.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.[False]
        Appearance14.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ugData.DisplayLayout.Override.TemplateAddRowAppearance = Appearance14
        Me.ugData.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill
        Me.ugData.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate
        Me.ugData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugData.Location = New System.Drawing.Point(2, 22)
        Me.ugData.Name = "ugData"
        Me.ugData.Size = New System.Drawing.Size(716, 327)
        Me.ugData.TabIndex = 1
        Me.ugData.Text = "UltraGrid1"
        '
        'udsData
        '
        UltraDataColumn1.DataType = GetType(Integer)
        UltraDataColumn3.DataType = GetType(Boolean)
        UltraDataColumn5.DataType = GetType(Date)
        Me.udsData.Band.Columns.AddRange(New Object() {UltraDataColumn1, UltraDataColumn2, UltraDataColumn3, UltraDataColumn4, UltraDataColumn5, UltraDataColumn6, UltraDataColumn7})
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
        'frmPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 445)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPeriodo"
        Me.Text = "Período"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.ugData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cmdGrabar As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents cmdEliminar As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents BarStaticItem3 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents cmdCancelar As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents cmdBuscar As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents cmdCerrar As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents gFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sFile As System.Windows.Forms.FolderBrowserDialog

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ugData As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents udsData As Infragistics.Win.UltraWinDataSource.UltraDataSource
    Friend WithEvents dtpPeriodo As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdNuevoo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdNuevo As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents lblEstado As DevExpress.XtraEditors.LabelControl
End Class
