<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class requestApproval
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(requestApproval))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.textBoxForOfficer = New System.Windows.Forms.TextBox()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.approvalTable = New Guna.UI.WinForms.GunaDataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.approvalTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Lime
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(639, 10)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(82, 32)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Approve"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.LightCoral
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(730, 10)
        Me.SimpleButton2.Margin = New System.Windows.Forms.Padding(2)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(82, 32)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "Reject"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.textBoxForOfficer)
        Me.Panel1.Controls.Add(Me.DateLabel)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.SimpleButton1)
        Me.Panel1.Controls.Add(Me.SimpleButton2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 61)
        Me.Panel1.TabIndex = 2
        '
        'textBoxForOfficer
        '
        Me.textBoxForOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxForOfficer.ForeColor = System.Drawing.Color.Black
        Me.textBoxForOfficer.Location = New System.Drawing.Point(124, 20)
        Me.textBoxForOfficer.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxForOfficer.Name = "textBoxForOfficer"
        Me.textBoxForOfficer.ReadOnly = True
        Me.textBoxForOfficer.Size = New System.Drawing.Size(152, 23)
        Me.textBoxForOfficer.TabIndex = 5
        '
        'DateLabel
        '
        Me.DateLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.DateLabel.Location = New System.Drawing.Point(412, 22)
        Me.DateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(51, 17)
        Me.DateLabel.TabIndex = 4
        Me.DateLabel.Text = "Label1"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.SystemColors.Control
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(10, 20)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(109, 17)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Officer in charge:"
        '
        'approvalTable
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.approvalTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.approvalTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.approvalTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.approvalTable.BackgroundColor = System.Drawing.Color.White
        Me.approvalTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.approvalTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.approvalTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.approvalTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.approvalTable.ColumnHeadersHeight = 15
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.approvalTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.approvalTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.approvalTable.EnableHeadersVisualStyles = False
        Me.approvalTable.GridColor = System.Drawing.Color.SlateGray
        Me.approvalTable.Location = New System.Drawing.Point(0, 61)
        Me.approvalTable.Name = "approvalTable"
        Me.approvalTable.RowHeadersVisible = False
        Me.approvalTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.approvalTable.Size = New System.Drawing.Size(821, 423)
        Me.approvalTable.TabIndex = 3
        Me.approvalTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.approvalTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.approvalTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.approvalTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.approvalTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.approvalTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.approvalTable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.approvalTable.ThemeStyle.GridColor = System.Drawing.Color.SlateGray
        Me.approvalTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.approvalTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.approvalTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.approvalTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.approvalTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.approvalTable.ThemeStyle.HeaderStyle.Height = 15
        Me.approvalTable.ThemeStyle.ReadOnly = False
        Me.approvalTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.approvalTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.approvalTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.approvalTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.approvalTable.ThemeStyle.RowsStyle.Height = 22
        Me.approvalTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.approvalTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'requestApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 484)
        Me.ControlBox = False
        Me.Controls.Add(Me.approvalTable)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "requestApproval"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.approvalTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As Panel
    Private WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateLabel As Label
    Friend WithEvents textBoxForOfficer As TextBox
    Friend WithEvents approvalTable As Guna.UI.WinForms.GunaDataGridView
End Class
