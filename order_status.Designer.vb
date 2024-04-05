<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order_status
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.order_searchbox = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.OnProcessTab = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.all = New Guna.UI.WinForms.GunaDataGridView()
        Me.onprocess = New Guna.UI.WinForms.GunaDataGridView()
        Me.delivered = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.OnProcessTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OnProcessTab.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.all, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.onprocess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.delivered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.order_searchbox)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1026, 70)
        Me.Panel1.TabIndex = 1
        '
        'order_searchbox
        '
        Me.order_searchbox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.order_searchbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order_searchbox.Location = New System.Drawing.Point(100, 20)
        Me.order_searchbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.order_searchbox.Name = "order_searchbox"
        Me.order_searchbox.Size = New System.Drawing.Size(910, 30)
        Me.order_searchbox.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(21, 23)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 22)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "SEARCH"
        '
        'OnProcessTab
        '
        Me.OnProcessTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OnProcessTab.Location = New System.Drawing.Point(0, 70)
        Me.OnProcessTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OnProcessTab.Name = "OnProcessTab"
        Me.OnProcessTab.SelectedTabPage = Me.XtraTabPage1
        Me.OnProcessTab.Size = New System.Drawing.Size(1026, 313)
        Me.OnProcessTab.TabIndex = 2
        Me.OnProcessTab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.all)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1024, 290)
        Me.XtraTabPage1.Text = "ALL"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.onprocess)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1024, 290)
        Me.XtraTabPage2.Text = "On Process"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.delivered)
        Me.XtraTabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1024, 290)
        Me.XtraTabPage3.Text = "Delivered"
        '
        'all
        '
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.all.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.all.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.all.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.all.BackgroundColor = System.Drawing.Color.White
        Me.all.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.all.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.all.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.all.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.all.ColumnHeadersHeight = 15
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.all.DefaultCellStyle = DataGridViewCellStyle12
        Me.all.Dock = System.Windows.Forms.DockStyle.Fill
        Me.all.EnableHeadersVisualStyles = False
        Me.all.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.all.Location = New System.Drawing.Point(0, 0)
        Me.all.Name = "all"
        Me.all.RowHeadersVisible = False
        Me.all.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.all.Size = New System.Drawing.Size(1024, 290)
        Me.all.TabIndex = 6
        Me.all.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue
        Me.all.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.all.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.all.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.all.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.all.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.all.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.all.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.all.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.all.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.all.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.all.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.all.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.all.ThemeStyle.HeaderStyle.Height = 15
        Me.all.ThemeStyle.ReadOnly = False
        Me.all.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.all.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.all.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.all.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.all.ThemeStyle.RowsStyle.Height = 22
        Me.all.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.all.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'onprocess
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.onprocess.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.onprocess.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.onprocess.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.onprocess.BackgroundColor = System.Drawing.Color.White
        Me.onprocess.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.onprocess.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.onprocess.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.onprocess.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.onprocess.ColumnHeadersHeight = 15
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.onprocess.DefaultCellStyle = DataGridViewCellStyle15
        Me.onprocess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.onprocess.EnableHeadersVisualStyles = False
        Me.onprocess.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.onprocess.Location = New System.Drawing.Point(0, 0)
        Me.onprocess.Name = "onprocess"
        Me.onprocess.RowHeadersVisible = False
        Me.onprocess.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.onprocess.Size = New System.Drawing.Size(1024, 290)
        Me.onprocess.TabIndex = 6
        Me.onprocess.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Orange
        Me.onprocess.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.onprocess.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.onprocess.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.onprocess.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.onprocess.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.onprocess.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.onprocess.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.onprocess.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.onprocess.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.onprocess.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.onprocess.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.onprocess.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.onprocess.ThemeStyle.HeaderStyle.Height = 15
        Me.onprocess.ThemeStyle.ReadOnly = False
        Me.onprocess.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.onprocess.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.onprocess.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.onprocess.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.onprocess.ThemeStyle.RowsStyle.Height = 22
        Me.onprocess.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(189, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.onprocess.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'delivered
        '
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.delivered.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.delivered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.delivered.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.delivered.BackgroundColor = System.Drawing.Color.White
        Me.delivered.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.delivered.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.delivered.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.delivered.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.delivered.ColumnHeadersHeight = 15
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.delivered.DefaultCellStyle = DataGridViewCellStyle18
        Me.delivered.Dock = System.Windows.Forms.DockStyle.Fill
        Me.delivered.EnableHeadersVisualStyles = False
        Me.delivered.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.delivered.Location = New System.Drawing.Point(0, 0)
        Me.delivered.Name = "delivered"
        Me.delivered.RowHeadersVisible = False
        Me.delivered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.delivered.Size = New System.Drawing.Size(1024, 290)
        Me.delivered.TabIndex = 6
        Me.delivered.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea
        Me.delivered.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.delivered.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.delivered.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.delivered.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.delivered.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.delivered.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.delivered.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.delivered.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.delivered.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.delivered.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.delivered.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.delivered.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.delivered.ThemeStyle.HeaderStyle.Height = 15
        Me.delivered.ThemeStyle.ReadOnly = False
        Me.delivered.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.delivered.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.delivered.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.delivered.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.delivered.ThemeStyle.RowsStyle.Height = 22
        Me.delivered.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.delivered.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'order_status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.OnProcessTab)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "order_status"
        Me.Size = New System.Drawing.Size(1026, 383)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.OnProcessTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OnProcessTab.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.all, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.onprocess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.delivered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents order_searchbox As TextBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents OnProcessTab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents all As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents onprocess As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents delivered As Guna.UI.WinForms.GunaDataGridView
End Class
