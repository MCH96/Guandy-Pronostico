﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComparacionPeriodo
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim EditorButton2 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim Appearance2 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmComparacionPeriodo))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar2 = New DevExpress.XtraBars.Bar
        Me.cmdSeleccionarMeses = New DevExpress.XtraBars.BarButtonItem
        Me.cmdDeseleccionarMeses = New DevExpress.XtraBars.BarButtonItem
        Me.cmdCerrar = New DevExpress.XtraBars.BarLargeButtonItem
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        Me.BarStaticItem2 = New DevExpress.XtraBars.BarStaticItem
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl
        Me.cmdExportar = New System.Windows.Forms.Button
        Me.txtAniosComparar = New DevExpress.XtraEditors.TextEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.cmdComparar = New System.Windows.Forms.Button
        Me.txtCliente = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.chkNoviembre = New System.Windows.Forms.CheckBox
        Me.chkDiciembre = New System.Windows.Forms.CheckBox
        Me.chkJunio = New System.Windows.Forms.CheckBox
        Me.chkMayo = New System.Windows.Forms.CheckBox
        Me.chkMarzo = New System.Windows.Forms.CheckBox
        Me.chkOctubre = New System.Windows.Forms.CheckBox
        Me.chkEnero = New System.Windows.Forms.CheckBox
        Me.chkAbril = New System.Windows.Forms.CheckBox
        Me.chkFebrero = New System.Windows.Forms.CheckBox
        Me.chkJulio = New System.Windows.Forms.CheckBox
        Me.chkSeptiembre = New System.Windows.Forms.CheckBox
        Me.chkAgosto = New System.Windows.Forms.CheckBox
        Me.txtPeriodo = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lblCodigo = New DevExpress.XtraEditors.LabelControl
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl
        Me.ugData = New Infragistics.Win.UltraWinGrid.UltraGrid
        Me.cmdNuevo = New DevExpress.XtraBars.BarLargeButtonItem
        Me.cmdMostrarPorcentajeGlobal = New System.Windows.Forms.Button
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.txtAniosComparar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.txtPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.ugData, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.cmdCerrar, Me.cmdSeleccionarMeses, Me.cmdDeseleccionarMeses})
        Me.BarManager1.MainMenu = Me.Bar2
        Me.BarManager1.MaxItemId = 14
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
        Me.Bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.cmdSeleccionarMeses), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdDeseleccionarMeses), New DevExpress.XtraBars.LinkPersistInfo(Me.cmdCerrar, True)})
        Me.Bar2.OptionsBar.BarState = DevExpress.XtraBars.BarState.Expanded
        Me.Bar2.OptionsBar.MultiLine = True
        Me.Bar2.OptionsBar.UseWholeRow = True
        Me.Bar2.Text = "Main menu"
        '
        'cmdSeleccionarMeses
        '
        Me.cmdSeleccionarMeses.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.cmdSeleccionarMeses.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdSeleccionarMeses.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdSeleccionarMeses.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.cmdSeleccionarMeses.Caption = "Seleccionar Todos los Meses"
        Me.cmdSeleccionarMeses.Id = 12
        Me.cmdSeleccionarMeses.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.cmdSeleccionarMeses.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.cmdSeleccionarMeses.Name = "cmdSeleccionarMeses"
        Me.cmdSeleccionarMeses.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
        '
        'cmdDeseleccionarMeses
        '
        Me.cmdDeseleccionarMeses.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.[Default]
        Me.cmdDeseleccionarMeses.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdDeseleccionarMeses.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdDeseleccionarMeses.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.[Default]
        Me.cmdDeseleccionarMeses.Caption = "Deseleccionar Todos los Meses"
        Me.cmdDeseleccionarMeses.Id = 13
        Me.cmdDeseleccionarMeses.ItemClickFireMode = DevExpress.XtraBars.BarItemEventFireMode.[Default]
        Me.cmdDeseleccionarMeses.MergeType = DevExpress.XtraBars.BarMenuMerge.Add
        Me.cmdDeseleccionarMeses.Name = "cmdDeseleccionarMeses"
        Me.cmdDeseleccionarMeses.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
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
        Me.barDockControlTop.Size = New System.Drawing.Size(943, 24)
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
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 511)
        Me.barDockControlBottom.Size = New System.Drawing.Size(943, 0)
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
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 487)
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
        Me.barDockControlRight.Location = New System.Drawing.Point(943, 24)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 487)
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
        Me.GroupControl1.Controls.Add(Me.cmdMostrarPorcentajeGlobal)
        Me.GroupControl1.Controls.Add(Me.cmdExportar)
        Me.GroupControl1.Controls.Add(Me.txtAniosComparar)
        Me.GroupControl1.Controls.Add(Me.Label20)
        Me.GroupControl1.Controls.Add(Me.cmdComparar)
        Me.GroupControl1.Controls.Add(Me.txtCliente)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupControl1.Controls.Add(Me.txtPeriodo)
        Me.GroupControl1.Controls.Add(Me.lblCodigo)
        Me.GroupControl1.Location = New System.Drawing.Point(5, 6)
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(695, 160)
        Me.GroupControl1.TabIndex = 1
        Me.GroupControl1.Text = "Datos Generales"
        '
        'cmdExportar
        '
        Me.cmdExportar.Location = New System.Drawing.Point(615, 131)
        Me.cmdExportar.Name = "cmdExportar"
        Me.cmdExportar.Size = New System.Drawing.Size(75, 23)
        Me.cmdExportar.TabIndex = 4
        Me.cmdExportar.Text = "Exportar"
        Me.cmdExportar.UseVisualStyleBackColor = True
        '
        'txtAniosComparar
        '
        Me.txtAniosComparar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtAniosComparar.Location = New System.Drawing.Point(100, 132)
        Me.txtAniosComparar.Name = "txtAniosComparar"
        Me.txtAniosComparar.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.[Default]
        Me.txtAniosComparar.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[Default]
        Me.txtAniosComparar.Properties.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtAniosComparar.Properties.Appearance.Options.UseTextOptions = True
        Me.txtAniosComparar.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtAniosComparar.Properties.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtAniosComparar.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtAniosComparar.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtAniosComparar.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtAniosComparar.Properties.AppearanceDisabled.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtAniosComparar.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtAniosComparar.Properties.AppearanceDisabled.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtAniosComparar.Properties.AppearanceDisabled.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtAniosComparar.Properties.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtAniosComparar.Properties.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtAniosComparar.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtAniosComparar.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtAniosComparar.Properties.AppearanceFocused.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtAniosComparar.Properties.AppearanceFocused.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtAniosComparar.Properties.AppearanceFocused.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtAniosComparar.Properties.AppearanceFocused.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtAniosComparar.Properties.AppearanceReadOnly.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.txtAniosComparar.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.txtAniosComparar.Properties.AppearanceReadOnly.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.txtAniosComparar.Properties.AppearanceReadOnly.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.txtAniosComparar.Properties.AppearanceReadOnly.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.txtAniosComparar.Properties.AppearanceReadOnly.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.txtAniosComparar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.txtAniosComparar.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtAniosComparar.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtAniosComparar.Properties.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.[Default]
        Me.txtAniosComparar.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.txtAniosComparar.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.[Default]
        Me.txtAniosComparar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtAniosComparar.Size = New System.Drawing.Size(115, 20)
        Me.txtAniosComparar.TabIndex = 2
        Me.txtAniosComparar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 137)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(91, 13)
        Me.Label20.TabIndex = 83
        Me.Label20.Text = "Años a Comparar:"
        '
        'cmdComparar
        '
        Me.cmdComparar.Location = New System.Drawing.Point(397, 131)
        Me.cmdComparar.Name = "cmdComparar"
        Me.cmdComparar.Size = New System.Drawing.Size(92, 23)
        Me.cmdComparar.TabIndex = 3
        Me.cmdComparar.Text = "Comparar"
        Me.cmdComparar.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        EditorButton1.Text = "..."
        Me.txtCliente.ButtonsLeft.Add(EditorButton1)
        Me.txtCliente.Location = New System.Drawing.Point(100, 52)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(590, 21)
        Me.txtCliente.TabIndex = 1
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
        Me.LabelControl1.Location = New System.Drawing.Point(8, 57)
        Me.LabelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl1.TabIndex = 56
        Me.LabelControl1.Text = "Cliente:"
        Me.LabelControl1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel1.Controls.Add(Me.chkNoviembre, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkDiciembre, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkJunio, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkMayo, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkMarzo, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkOctubre, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkEnero, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkAbril, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkFebrero, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.chkJulio, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkSeptiembre, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.chkAgosto, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(100, 79)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(590, 47)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'chkNoviembre
        '
        Me.chkNoviembre.AutoSize = True
        Me.chkNoviembre.Location = New System.Drawing.Point(395, 26)
        Me.chkNoviembre.Name = "chkNoviembre"
        Me.chkNoviembre.Size = New System.Drawing.Size(77, 17)
        Me.chkNoviembre.TabIndex = 10
        Me.chkNoviembre.Text = "Noviembre"
        Me.chkNoviembre.UseVisualStyleBackColor = True
        '
        'chkDiciembre
        '
        Me.chkDiciembre.AutoSize = True
        Me.chkDiciembre.Location = New System.Drawing.Point(493, 26)
        Me.chkDiciembre.Name = "chkDiciembre"
        Me.chkDiciembre.Size = New System.Drawing.Size(73, 17)
        Me.chkDiciembre.TabIndex = 11
        Me.chkDiciembre.Text = "Diciembre"
        Me.chkDiciembre.UseVisualStyleBackColor = True
        '
        'chkJunio
        '
        Me.chkJunio.AutoSize = True
        Me.chkJunio.Location = New System.Drawing.Point(493, 3)
        Me.chkJunio.Name = "chkJunio"
        Me.chkJunio.Size = New System.Drawing.Size(51, 17)
        Me.chkJunio.TabIndex = 5
        Me.chkJunio.Text = "Junio"
        Me.chkJunio.UseVisualStyleBackColor = True
        '
        'chkMayo
        '
        Me.chkMayo.AutoSize = True
        Me.chkMayo.Location = New System.Drawing.Point(395, 3)
        Me.chkMayo.Name = "chkMayo"
        Me.chkMayo.Size = New System.Drawing.Size(52, 17)
        Me.chkMayo.TabIndex = 4
        Me.chkMayo.Text = "Mayo"
        Me.chkMayo.UseVisualStyleBackColor = True
        '
        'chkMarzo
        '
        Me.chkMarzo.AutoSize = True
        Me.chkMarzo.Location = New System.Drawing.Point(199, 3)
        Me.chkMarzo.Name = "chkMarzo"
        Me.chkMarzo.Size = New System.Drawing.Size(55, 17)
        Me.chkMarzo.TabIndex = 2
        Me.chkMarzo.Text = "Marzo"
        Me.chkMarzo.UseVisualStyleBackColor = True
        '
        'chkOctubre
        '
        Me.chkOctubre.AutoSize = True
        Me.chkOctubre.Location = New System.Drawing.Point(297, 26)
        Me.chkOctubre.Name = "chkOctubre"
        Me.chkOctubre.Size = New System.Drawing.Size(64, 17)
        Me.chkOctubre.TabIndex = 9
        Me.chkOctubre.Text = "Octubre"
        Me.chkOctubre.UseVisualStyleBackColor = True
        '
        'chkEnero
        '
        Me.chkEnero.AutoSize = True
        Me.chkEnero.Location = New System.Drawing.Point(3, 3)
        Me.chkEnero.Name = "chkEnero"
        Me.chkEnero.Size = New System.Drawing.Size(54, 17)
        Me.chkEnero.TabIndex = 0
        Me.chkEnero.Text = "Enero"
        Me.chkEnero.UseVisualStyleBackColor = True
        '
        'chkAbril
        '
        Me.chkAbril.AutoSize = True
        Me.chkAbril.Location = New System.Drawing.Point(297, 3)
        Me.chkAbril.Name = "chkAbril"
        Me.chkAbril.Size = New System.Drawing.Size(46, 17)
        Me.chkAbril.TabIndex = 3
        Me.chkAbril.Text = "Abril"
        Me.chkAbril.UseVisualStyleBackColor = True
        '
        'chkFebrero
        '
        Me.chkFebrero.AutoSize = True
        Me.chkFebrero.Location = New System.Drawing.Point(101, 3)
        Me.chkFebrero.Name = "chkFebrero"
        Me.chkFebrero.Size = New System.Drawing.Size(62, 17)
        Me.chkFebrero.TabIndex = 1
        Me.chkFebrero.Text = "Febrero"
        Me.chkFebrero.UseVisualStyleBackColor = True
        '
        'chkJulio
        '
        Me.chkJulio.AutoSize = True
        Me.chkJulio.Location = New System.Drawing.Point(3, 26)
        Me.chkJulio.Name = "chkJulio"
        Me.chkJulio.Size = New System.Drawing.Size(47, 17)
        Me.chkJulio.TabIndex = 6
        Me.chkJulio.Text = "Julio"
        Me.chkJulio.UseVisualStyleBackColor = True
        '
        'chkSeptiembre
        '
        Me.chkSeptiembre.AutoSize = True
        Me.chkSeptiembre.Location = New System.Drawing.Point(199, 26)
        Me.chkSeptiembre.Name = "chkSeptiembre"
        Me.chkSeptiembre.Size = New System.Drawing.Size(79, 17)
        Me.chkSeptiembre.TabIndex = 8
        Me.chkSeptiembre.Text = "Septiembre"
        Me.chkSeptiembre.UseVisualStyleBackColor = True
        '
        'chkAgosto
        '
        Me.chkAgosto.AutoSize = True
        Me.chkAgosto.Location = New System.Drawing.Point(101, 26)
        Me.chkAgosto.Name = "chkAgosto"
        Me.chkAgosto.Size = New System.Drawing.Size(59, 17)
        Me.chkAgosto.TabIndex = 7
        Me.chkAgosto.Text = "Agosto"
        Me.chkAgosto.UseVisualStyleBackColor = True
        '
        'txtPeriodo
        '
        EditorButton2.Text = "..."
        Me.txtPeriodo.ButtonsLeft.Add(EditorButton2)
        Me.txtPeriodo.Location = New System.Drawing.Point(100, 25)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.ReadOnly = True
        Me.txtPeriodo.Size = New System.Drawing.Size(115, 21)
        Me.txtPeriodo.TabIndex = 0
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
        Me.lblCodigo.Location = New System.Drawing.Point(8, 30)
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
        Me.PanelControl1.Size = New System.Drawing.Size(943, 487)
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
        Me.GroupControl2.Location = New System.Drawing.Point(5, 172)
        Me.GroupControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(933, 310)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Detalle"
        '
        'ugData
        '
        Appearance2.BackColor = System.Drawing.SystemColors.Window
        Appearance2.BorderColor = System.Drawing.SystemColors.InactiveCaption
        Me.ugData.DisplayLayout.Appearance = Appearance2
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
        Me.ugData.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No
        Me.ugData.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.[False]
        Me.ugData.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.[False]
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
        Me.ugData.DisplayLayout.UseFixedHeaders = True
        Me.ugData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ugData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ugData.Location = New System.Drawing.Point(2, 22)
        Me.ugData.Name = "ugData"
        Me.ugData.Size = New System.Drawing.Size(929, 286)
        Me.ugData.TabIndex = 2
        Me.ugData.Text = "UltraGrid1"
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
        'cmdMostrarPorcentajeGlobal
        '
        Me.cmdMostrarPorcentajeGlobal.Location = New System.Drawing.Point(495, 131)
        Me.cmdMostrarPorcentajeGlobal.Name = "cmdMostrarPorcentajeGlobal"
        Me.cmdMostrarPorcentajeGlobal.Size = New System.Drawing.Size(114, 23)
        Me.cmdMostrarPorcentajeGlobal.TabIndex = 85
        Me.cmdMostrarPorcentajeGlobal.Text = "Mostrar % Global"
        Me.cmdMostrarPorcentajeGlobal.UseVisualStyleBackColor = True
        '
        'frmComparacionPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 511)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmComparacionPeriodo"
        Me.Text = "Comparación de Período"
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.txtAniosComparar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.txtPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.ugData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarStaticItem2 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents cmdCerrar As DevExpress.XtraBars.BarLargeButtonItem

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents lblCodigo As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdNuevo As DevExpress.XtraBars.BarLargeButtonItem
    Friend WithEvents txtPeriodo As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chkOctubre As System.Windows.Forms.CheckBox
    Friend WithEvents chkAbril As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiciembre As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeptiembre As System.Windows.Forms.CheckBox
    Friend WithEvents chkJulio As System.Windows.Forms.CheckBox
    Friend WithEvents chkAgosto As System.Windows.Forms.CheckBox
    Friend WithEvents chkFebrero As System.Windows.Forms.CheckBox
    Friend WithEvents chkEnero As System.Windows.Forms.CheckBox
    Friend WithEvents chkNoviembre As System.Windows.Forms.CheckBox
    Friend WithEvents chkJunio As System.Windows.Forms.CheckBox
    Friend WithEvents chkMayo As System.Windows.Forms.CheckBox
    Friend WithEvents chkMarzo As System.Windows.Forms.CheckBox
    Friend WithEvents cmdComparar As System.Windows.Forms.Button
    Friend WithEvents txtCliente As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ugData As Infragistics.Win.UltraWinGrid.UltraGrid
    Friend WithEvents txtAniosComparar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cmdExportar As System.Windows.Forms.Button
    Friend WithEvents cmdSeleccionarMeses As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdDeseleccionarMeses As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cmdMostrarPorcentajeGlobal As System.Windows.Forms.Button
End Class
