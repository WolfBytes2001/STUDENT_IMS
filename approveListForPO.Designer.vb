<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class approveListForPO
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(approveListForPO))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ApproveDataGrid = New System.Windows.Forms.DataGridView()
        Me.TABCONTROL1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.rejectedDataGrid = New System.Windows.Forms.DataGridView()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.PendingDataGrid = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.ApproveDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TABCONTROL1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABCONTROL1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.rejectedDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.PendingDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(711, 46)
        Me.Panel1.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Lime
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(607, 6)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(93, 32)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Confirm"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(21, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(551, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SELECT APPROVED REQUEST TO GENERATE PURCHASE ORDER"
        '
        'ApproveDataGrid
        '
        Me.ApproveDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ApproveDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ApproveDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ApproveDataGrid.DefaultCellStyle = DataGridViewCellStyle1
        Me.ApproveDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApproveDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.ApproveDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ApproveDataGrid.Name = "ApproveDataGrid"
        Me.ApproveDataGrid.RowHeadersWidth = 51
        Me.ApproveDataGrid.RowTemplate.Height = 24
        Me.ApproveDataGrid.Size = New System.Drawing.Size(709, 200)
        Me.ApproveDataGrid.TabIndex = 1
        '
        'TABCONTROL1
        '
        Me.TABCONTROL1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TABCONTROL1.Location = New System.Drawing.Point(0, 46)
        Me.TABCONTROL1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TABCONTROL1.Name = "TABCONTROL1"
        Me.TABCONTROL1.SelectedTabPage = Me.XtraTabPage1
        Me.TABCONTROL1.Size = New System.Drawing.Size(711, 231)
        Me.TABCONTROL1.TabIndex = 4
        Me.TABCONTROL1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Lime
        Me.XtraTabPage1.Appearance.PageClient.Options.UseBackColor = True
        Me.XtraTabPage1.Controls.Add(Me.ApproveDataGrid)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(709, 200)
        Me.XtraTabPage1.Text = "Approved"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.rejectedDataGrid)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(709, 210)
        Me.XtraTabPage2.Text = "Rejected"
        '
        'rejectedDataGrid
        '
        Me.rejectedDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.rejectedDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.rejectedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.rejectedDataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.rejectedDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rejectedDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.rejectedDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rejectedDataGrid.Name = "rejectedDataGrid"
        Me.rejectedDataGrid.RowHeadersWidth = 51
        Me.rejectedDataGrid.RowTemplate.Height = 24
        Me.rejectedDataGrid.Size = New System.Drawing.Size(709, 210)
        Me.rejectedDataGrid.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.PendingDataGrid)
        Me.XtraTabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(709, 210)
        Me.XtraTabPage3.Text = "Pending"
        '
        'PendingDataGrid
        '
        Me.PendingDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PendingDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.PendingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PendingDataGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.PendingDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PendingDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.PendingDataGrid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PendingDataGrid.Name = "PendingDataGrid"
        Me.PendingDataGrid.RowHeadersWidth = 51
        Me.PendingDataGrid.RowTemplate.Height = 24
        Me.PendingDataGrid.Size = New System.Drawing.Size(709, 210)
        Me.PendingDataGrid.TabIndex = 0
        '
        'approveListForPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 277)
        Me.Controls.Add(Me.TABCONTROL1)
        Me.Controls.Add(Me.Panel1)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "approveListForPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ApproveDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TABCONTROL1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABCONTROL1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.rejectedDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.PendingDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ApproveDataGrid As DataGridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TABCONTROL1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents rejectedDataGrid As DataGridView
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents PendingDataGrid As DataGridView
End Class
