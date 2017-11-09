<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscadorArbol
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
        Dim EditorButton1 As Infragistics.Win.UltraWinEditors.EditorButton = New Infragistics.Win.UltraWinEditors.EditorButton
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscadorArbol))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl
        Me.txtPais = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.lblPais = New DevExpress.XtraEditors.LabelControl
        Me.cmdFiltrar = New DevExpress.XtraEditors.SimpleButton
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.txtMunicipo = New System.Windows.Forms.TextBox
        Me.lblTituloBusqueda = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl
        Me.btnCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.btnSeleccionar = New DevExpress.XtraEditors.SimpleButton
        Me.tvBuscador = New System.Windows.Forms.TreeView
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txtPais, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PanelControl1.Controls.Add(Me.txtPais)
        Me.PanelControl1.Controls.Add(Me.lblPais)
        Me.PanelControl1.Controls.Add(Me.cmdFiltrar)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txtMunicipo)
        Me.PanelControl1.Controls.Add(Me.lblTituloBusqueda)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(610, 132)
        Me.PanelControl1.TabIndex = 0
        '
        'txtPais
        '
        EditorButton1.Text = "..."
        Me.txtPais.ButtonsLeft.Add(EditorButton1)
        Me.txtPais.Location = New System.Drawing.Point(142, 71)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.ReadOnly = True
        Me.txtPais.Size = New System.Drawing.Size(287, 21)
        Me.txtPais.TabIndex = 96
        Me.txtPais.Visible = False
        '
        'lblPais
        '
        Me.lblPais.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblPais.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblPais.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblPais.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblPais.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblPais.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblPais.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblPais.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblPais.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblPais.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblPais.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblPais.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblPais.Location = New System.Drawing.Point(80, 76)
        Me.lblPais.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(23, 13)
        Me.lblPais.TabIndex = 97
        Me.lblPais.Text = "Pais:"
        Me.lblPais.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.lblPais.Visible = False
        '
        'cmdFiltrar
        '
        Me.cmdFiltrar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.cmdFiltrar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.cmdFiltrar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cmdFiltrar.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.cmdFiltrar.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.cmdFiltrar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.cmdFiltrar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.cmdFiltrar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.cmdFiltrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmdFiltrar.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.cmdFiltrar.Location = New System.Drawing.Point(504, 98)
        Me.cmdFiltrar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.cmdFiltrar.Name = "cmdFiltrar"
        Me.cmdFiltrar.Size = New System.Drawing.Size(103, 23)
        Me.cmdFiltrar.TabIndex = 94
        Me.cmdFiltrar.Text = "Filtrar"
        Me.cmdFiltrar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.cmdFiltrar.Visible = False
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
        Me.LabelControl2.Location = New System.Drawing.Point(80, 101)
        Me.LabelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl2.TabIndex = 95
        Me.LabelControl2.Text = "Municipio:"
        Me.LabelControl2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        Me.LabelControl2.Visible = False
        '
        'txtMunicipo
        '
        Me.txtMunicipo.Location = New System.Drawing.Point(142, 98)
        Me.txtMunicipo.Name = "txtMunicipo"
        Me.txtMunicipo.Size = New System.Drawing.Size(287, 20)
        Me.txtMunicipo.TabIndex = 93
        Me.txtMunicipo.Visible = False
        '
        'lblTituloBusqueda
        '
        Me.lblTituloBusqueda.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.lblTituloBusqueda.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloBusqueda.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lblTituloBusqueda.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.lblTituloBusqueda.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTituloBusqueda.Appearance.Options.UseFont = True
        Me.lblTituloBusqueda.Appearance.Options.UseForeColor = True
        Me.lblTituloBusqueda.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.lblTituloBusqueda.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.lblTituloBusqueda.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.lblTituloBusqueda.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.lblTituloBusqueda.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.lblTituloBusqueda.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.[Default]
        Me.lblTituloBusqueda.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.None
        Me.lblTituloBusqueda.LineLocation = DevExpress.XtraEditors.LineLocation.[Default]
        Me.lblTituloBusqueda.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.[Default]
        Me.lblTituloBusqueda.Location = New System.Drawing.Point(75, 31)
        Me.lblTituloBusqueda.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.lblTituloBusqueda.Name = "lblTituloBusqueda"
        Me.lblTituloBusqueda.Size = New System.Drawing.Size(206, 23)
        Me.lblTituloBusqueda.TabIndex = 1
        Me.lblTituloBusqueda.Text = "Titulo de la búsqueda"
        Me.lblTituloBusqueda.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 64)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelControl2
        '
        Me.PanelControl2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.PanelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.PanelControl2.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.PanelControl2.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.PanelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.PanelControl2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.PanelControl2.ContentImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.PanelControl2.Controls.Add(Me.btnCancelar)
        Me.PanelControl2.Controls.Add(Me.btnSeleccionar)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PanelControl2.Location = New System.Drawing.Point(494, 132)
        Me.PanelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(116, 287)
        Me.PanelControl2.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnCancelar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnCancelar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnCancelar.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnCancelar.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnCancelar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnCancelar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnCancelar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCancelar.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnCancelar.Location = New System.Drawing.Point(6, 37)
        Me.btnCancelar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(103, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.[Default]
        Me.btnSeleccionar.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal
        Me.btnSeleccionar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.btnSeleccionar.Appearance.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.[Default]
        Me.btnSeleccionar.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.[Default]
        Me.btnSeleccionar.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.[Default]
        Me.btnSeleccionar.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.[Default]
        Me.btnSeleccionar.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.[Default]
        Me.btnSeleccionar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSeleccionar.ImageLocation = DevExpress.XtraEditors.ImageLocation.[Default]
        Me.btnSeleccionar.Location = New System.Drawing.Point(6, 8)
        Me.btnSeleccionar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Skin
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(103, 23)
        Me.btnSeleccionar.TabIndex = 0
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.ToolTipIconType = DevExpress.Utils.ToolTipIconType.None
        '
        'tvBuscador
        '
        Me.tvBuscador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tvBuscador.Location = New System.Drawing.Point(0, 132)
        Me.tvBuscador.Name = "tvBuscador"
        Me.tvBuscador.Size = New System.Drawing.Size(494, 287)
        Me.tvBuscador.TabIndex = 2
        '
        'frmBuscadorArbol
        '
        Me.AcceptButton = Me.cmdFiltrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 419)
        Me.Controls.Add(Me.tvBuscador)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmBuscadorArbol"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscador"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txtPais, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSeleccionar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblTituloBusqueda As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tvBuscador As System.Windows.Forms.TreeView
    Friend WithEvents txtPais As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents lblPais As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cmdFiltrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMunicipo As System.Windows.Forms.TextBox

End Class
