<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class po_approve_list
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI.Animation.Animation = New Guna.UI.Animation.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(po_approve_list))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaTransition1 = New Guna.UI.WinForms.GunaTransition(Me.components)
        Me.GunaGradient2Panel1 = New Guna.UI.WinForms.GunaGradient2Panel()
        Me.POTAB = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.approved = New Guna.UI.WinForms.GunaDataGridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.rejected = New Guna.UI.WinForms.GunaDataGridView()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.pending = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1.SuspendLayout()
        Me.GunaGradient2Panel1.SuspendLayout()
        CType(Me.POTAB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.POTAB.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.approved, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.rejected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.pending, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.GunaTransition1.SetDecoration(Me.Panel1, Guna.UI.Animation.DecorationType.None)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 46)
        Me.Panel1.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Lime
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.GunaTransition1.SetDecoration(Me.SimpleButton1, Guna.UI.Animation.DecorationType.None)
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(653, 6)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(93, 32)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Confirm"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.GunaTransition1.SetDecoration(Me.Label1, Guna.UI.Animation.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(63, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT APPROVED REQUEST TO GENERATE PURCHASE ORDER"
        '
        'GunaTransition1
        '
        Me.GunaTransition1.AnimationType = Guna.UI.Animation.AnimationType.VertSlide
        Me.GunaTransition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.GunaTransition1.DefaultAnimation = Animation1
        '
        'GunaGradient2Panel1
        '
        Me.GunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGradient2Panel1.Controls.Add(Me.POTAB)
        Me.GunaTransition1.SetDecoration(Me.GunaGradient2Panel1, Guna.UI.Animation.DecorationType.None)
        Me.GunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaGradient2Panel1.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradient2Panel1.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradient2Panel1.Location = New System.Drawing.Point(0, 46)
        Me.GunaGradient2Panel1.Name = "GunaGradient2Panel1"
        Me.GunaGradient2Panel1.Size = New System.Drawing.Size(757, 243)
        Me.GunaGradient2Panel1.TabIndex = 2
        '
        'POTAB
        '
        Me.GunaTransition1.SetDecoration(Me.POTAB, Guna.UI.Animation.DecorationType.None)
        Me.POTAB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.POTAB.Location = New System.Drawing.Point(0, 0)
        Me.POTAB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.POTAB.Name = "POTAB"
        Me.POTAB.SelectedTabPage = Me.XtraTabPage1
        Me.POTAB.Size = New System.Drawing.Size(757, 243)
        Me.POTAB.TabIndex = 5
        Me.POTAB.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Lime
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.approved)
        Me.GunaTransition1.SetDecoration(Me.XtraTabPage1, Guna.UI.Animation.DecorationType.None)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(751, 215)
        Me.XtraTabPage1.Text = "Approved"
        '
        'approved
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.approved.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.approved.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.approved.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.approved.BackgroundColor = System.Drawing.Color.White
        Me.approved.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.approved.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.approved.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.approved.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.approved.ColumnHeadersHeight = 15
        Me.GunaTransition1.SetDecoration(Me.approved, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.approved.DefaultCellStyle = DataGridViewCellStyle3
        Me.approved.Dock = System.Windows.Forms.DockStyle.Fill
        Me.approved.EnableHeadersVisualStyles = False
        Me.approved.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.approved.Location = New System.Drawing.Point(0, 0)
        Me.approved.Name = "approved"
        Me.approved.RowHeadersVisible = False
        Me.approved.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.approved.Size = New System.Drawing.Size(751, 215)
        Me.approved.TabIndex = 5
        Me.approved.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea
        Me.approved.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.approved.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.approved.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.approved.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.approved.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.approved.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.approved.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.approved.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.approved.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.approved.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.approved.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.approved.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.approved.ThemeStyle.HeaderStyle.Height = 15
        Me.approved.ThemeStyle.ReadOnly = False
        Me.approved.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.approved.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.approved.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.approved.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.approved.ThemeStyle.RowsStyle.Height = 22
        Me.approved.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.approved.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.rejected)
        Me.GunaTransition1.SetDecoration(Me.XtraTabPage2, Guna.UI.Animation.DecorationType.None)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(755, 212)
        Me.XtraTabPage2.Text = "Rejected"
        '
        'rejected
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.rejected.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.rejected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.rejected.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.rejected.BackgroundColor = System.Drawing.Color.White
        Me.rejected.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rejected.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.rejected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.rejected.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.rejected.ColumnHeadersHeight = 15
        Me.GunaTransition1.SetDecoration(Me.rejected, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(215, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(121, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.rejected.DefaultCellStyle = DataGridViewCellStyle6
        Me.rejected.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rejected.EnableHeadersVisualStyles = False
        Me.rejected.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.rejected.Location = New System.Drawing.Point(0, 0)
        Me.rejected.Name = "rejected"
        Me.rejected.RowHeadersVisible = False
        Me.rejected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.rejected.Size = New System.Drawing.Size(755, 212)
        Me.rejected.TabIndex = 4
        Me.rejected.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Red
        Me.rejected.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.rejected.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.rejected.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.rejected.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.rejected.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.rejected.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.rejected.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.rejected.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.rejected.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.rejected.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.rejected.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.rejected.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.rejected.ThemeStyle.HeaderStyle.Height = 15
        Me.rejected.ThemeStyle.ReadOnly = False
        Me.rejected.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.rejected.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.rejected.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.rejected.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.rejected.ThemeStyle.RowsStyle.Height = 22
        Me.rejected.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(121, Byte), Integer))
        Me.rejected.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.pending)
        Me.GunaTransition1.SetDecoration(Me.XtraTabPage3, Guna.UI.Animation.DecorationType.None)
        Me.XtraTabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(755, 212)
        Me.XtraTabPage3.Text = "Pending"
        '
        'pending
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.pending.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.pending.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.pending.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.pending.BackgroundColor = System.Drawing.Color.White
        Me.pending.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pending.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.pending.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pending.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.pending.ColumnHeadersHeight = 15
        Me.GunaTransition1.SetDecoration(Me.pending, Guna.UI.Animation.DecorationType.None)
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pending.DefaultCellStyle = DataGridViewCellStyle9
        Me.pending.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pending.EnableHeadersVisualStyles = False
        Me.pending.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.pending.Location = New System.Drawing.Point(0, 0)
        Me.pending.Name = "pending"
        Me.pending.RowHeadersVisible = False
        Me.pending.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.pending.Size = New System.Drawing.Size(755, 212)
        Me.pending.TabIndex = 4
        Me.pending.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Orange
        Me.pending.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.pending.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.pending.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.pending.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.pending.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.pending.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.pending.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.pending.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.pending.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.pending.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.pending.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.pending.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.pending.ThemeStyle.HeaderStyle.Height = 15
        Me.pending.ThemeStyle.ReadOnly = False
        Me.pending.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.pending.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.pending.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.pending.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.pending.ThemeStyle.RowsStyle.Height = 22
        Me.pending.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.pending.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'po_approve_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.GunaGradient2Panel1)
        Me.Controls.Add(Me.Panel1)
        Me.GunaTransition1.SetDecoration(Me, Guna.UI.Animation.DecorationType.None)
        Me.Name = "po_approve_list"
        Me.Size = New System.Drawing.Size(757, 289)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GunaGradient2Panel1.ResumeLayout(False)
        CType(Me.POTAB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.POTAB.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.approved, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.rejected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.pending, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaTransition1 As Guna.UI.WinForms.GunaTransition
    Friend WithEvents GunaGradient2Panel1 As Guna.UI.WinForms.GunaGradient2Panel
    Friend WithEvents POTAB As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents rejected As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents pending As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents approved As Guna.UI.WinForms.GunaDataGridView
End Class
