<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order_details
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.order_searchbox = New System.Windows.Forms.TextBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.OnProcessTab = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.order_details_table = New System.Windows.Forms.DataGridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.OnProcessTable = New System.Windows.Forms.DataGridView()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.delivered_table = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.OnProcessTab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OnProcessTab.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.order_details_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.OnProcessTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.delivered_table, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Size = New System.Drawing.Size(1082, 70)
        Me.Panel1.TabIndex = 0
        '
        'order_searchbox
        '
        Me.order_searchbox.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.order_searchbox.Location = New System.Drawing.Point(108, 20)
        Me.order_searchbox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.order_searchbox.Name = "order_searchbox"
        Me.order_searchbox.Size = New System.Drawing.Size(951, 30)
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
        'PanelControl1
        '
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelControl1.Location = New System.Drawing.Point(0, 466)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1082, 8)
        Me.PanelControl1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.OnProcessTab)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1082, 396)
        Me.Panel2.TabIndex = 2
        '
        'OnProcessTab
        '
        Me.OnProcessTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OnProcessTab.Location = New System.Drawing.Point(0, 0)
        Me.OnProcessTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OnProcessTab.Name = "OnProcessTab"
        Me.OnProcessTab.SelectedTabPage = Me.XtraTabPage1
        Me.OnProcessTab.Size = New System.Drawing.Size(1082, 396)
        Me.OnProcessTab.TabIndex = 0
        Me.OnProcessTab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.order_details_table)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1080, 365)
        Me.XtraTabPage1.Text = "ALL"
        '
        'order_details_table
        '
        Me.order_details_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.order_details_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.order_details_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.order_details_table.DefaultCellStyle = DataGridViewCellStyle1
        Me.order_details_table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.order_details_table.Location = New System.Drawing.Point(0, 0)
        Me.order_details_table.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.order_details_table.Name = "order_details_table"
        Me.order_details_table.RowHeadersWidth = 51
        Me.order_details_table.RowTemplate.Height = 24
        Me.order_details_table.Size = New System.Drawing.Size(1080, 365)
        Me.order_details_table.TabIndex = 0
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.OnProcessTable)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1080, 373)
        Me.XtraTabPage2.Text = "On Process"
        '
        'OnProcessTable
        '
        Me.OnProcessTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OnProcessTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.OnProcessTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OnProcessTable.DefaultCellStyle = DataGridViewCellStyle2
        Me.OnProcessTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OnProcessTable.Location = New System.Drawing.Point(0, 0)
        Me.OnProcessTable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OnProcessTable.Name = "OnProcessTable"
        Me.OnProcessTable.RowHeadersWidth = 51
        Me.OnProcessTable.RowTemplate.Height = 24
        Me.OnProcessTable.Size = New System.Drawing.Size(1080, 373)
        Me.OnProcessTable.TabIndex = 0
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.delivered_table)
        Me.XtraTabPage3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1080, 373)
        Me.XtraTabPage3.Text = "Delivered"
        '
        'delivered_table
        '
        Me.delivered_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.delivered_table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.delivered_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.delivered_table.DefaultCellStyle = DataGridViewCellStyle3
        Me.delivered_table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.delivered_table.Location = New System.Drawing.Point(0, 0)
        Me.delivered_table.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.delivered_table.Name = "delivered_table"
        Me.delivered_table.RowHeadersWidth = 51
        Me.delivered_table.RowTemplate.Height = 24
        Me.delivered_table.Size = New System.Drawing.Size(1080, 373)
        Me.delivered_table.TabIndex = 0
        '
        'order_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 474)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "order_details"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.OnProcessTab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OnProcessTab.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.order_details_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.OnProcessTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.delivered_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents order_searchbox As TextBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents OnProcessTab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents order_details_table As DataGridView
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents OnProcessTable As DataGridView
    Friend WithEvents delivered_table As DataGridView
End Class
