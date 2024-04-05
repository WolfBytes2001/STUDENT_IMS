<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addItem))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ADDITEMTAB = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.pendingItems = New Guna.UI.WinForms.GunaDataGridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Panel1.SuspendLayout()
        CType(Me.ADDITEMTAB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ADDITEMTAB.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.pendingItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1081, 46)
        Me.Panel1.TabIndex = 2
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Lime
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(977, 6)
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
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(282, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(402, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT AN ITEM TO ADD IN THE INVENTORY"
        '
        'ADDITEMTAB
        '
        Me.ADDITEMTAB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ADDITEMTAB.Location = New System.Drawing.Point(0, 46)
        Me.ADDITEMTAB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ADDITEMTAB.Name = "ADDITEMTAB"
        Me.ADDITEMTAB.SelectedTabPage = Me.XtraTabPage1
        Me.ADDITEMTAB.Size = New System.Drawing.Size(1081, 434)
        Me.ADDITEMTAB.TabIndex = 3
        Me.ADDITEMTAB.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.pendingItems)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1079, 403)
        Me.XtraTabPage1.Text = "PENDING ITEMS"
        '
        'pendingItems
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pendingItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.pendingItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.pendingItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.pendingItems.BackgroundColor = System.Drawing.Color.White
        Me.pendingItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.pendingItems.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.pendingItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 7.8!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.pendingItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.pendingItems.ColumnHeadersHeight = 15
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(239, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 7.8!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.pendingItems.DefaultCellStyle = DataGridViewCellStyle3
        Me.pendingItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pendingItems.EnableHeadersVisualStyles = False
        Me.pendingItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.pendingItems.Location = New System.Drawing.Point(0, 0)
        Me.pendingItems.Name = "pendingItems"
        Me.pendingItems.RowHeadersVisible = False
        Me.pendingItems.RowHeadersWidth = 51
        Me.pendingItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.pendingItems.Size = New System.Drawing.Size(1079, 403)
        Me.pendingItems.TabIndex = 6
        Me.pendingItems.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Indigo
        Me.pendingItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(197, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pendingItems.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.pendingItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.pendingItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.pendingItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.pendingItems.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.pendingItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(194, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.pendingItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.pendingItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.pendingItems.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 7.8!)
        Me.pendingItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.pendingItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.pendingItems.ThemeStyle.HeaderStyle.Height = 15
        Me.pendingItems.ThemeStyle.ReadOnly = False
        Me.pendingItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.pendingItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.pendingItems.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 7.8!)
        Me.pendingItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.pendingItems.ThemeStyle.RowsStyle.Height = 22
        Me.pendingItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.pendingItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1079, 403)
        Me.XtraTabPage2.Text = "XtraTabPage2"
        '
        'addItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ADDITEMTAB)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "addItem"
        Me.Size = New System.Drawing.Size(1081, 480)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ADDITEMTAB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ADDITEMTAB.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.pendingItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ADDITEMTAB As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents pendingItems As Guna.UI.WinForms.GunaDataGridView
End Class
