<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemReview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(itemReview))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.descriptionR = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.itemIDR = New DevExpress.XtraEditors.LabelControl()
        Me.quantityR = New Guna.UI.WinForms.GunaTextBox()
        Me.priceR = New Guna.UI.WinForms.GunaTextBox()
        Me.totalamountR = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.categoryR = New Guna.UI.WinForms.GunaTextBox()
        Me.measureR = New Guna.UI.WinForms.GunaTextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.inventoryID = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1.SuspendLayout()
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
        Me.Panel1.Size = New System.Drawing.Size(543, 46)
        Me.Panel1.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.Lime
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton1.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton1.Location = New System.Drawing.Point(439, 6)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(93, 32)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Add"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(203, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ITEM REVIEW"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 99)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(67, 15)
        Me.GunaLabel1.TabIndex = 4
        Me.GunaLabel1.Text = "Description"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 192)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(55, 15)
        Me.GunaLabel2.TabIndex = 5
        Me.GunaLabel2.Text = "Category"
        '
        'descriptionR
        '
        Me.descriptionR.BackColor = System.Drawing.Color.Transparent
        Me.descriptionR.BaseColor = System.Drawing.Color.White
        Me.descriptionR.BorderColor = System.Drawing.Color.Silver
        Me.descriptionR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.descriptionR.FocusedBaseColor = System.Drawing.Color.White
        Me.descriptionR.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.descriptionR.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.descriptionR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.descriptionR.ForeColor = System.Drawing.Color.Red
        Me.descriptionR.Location = New System.Drawing.Point(15, 117)
        Me.descriptionR.Name = "descriptionR"
        Me.descriptionR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.descriptionR.Radius = 10
        Me.descriptionR.ReadOnly = True
        Me.descriptionR.SelectedText = ""
        Me.descriptionR.Size = New System.Drawing.Size(524, 72)
        Me.descriptionR.TabIndex = 6
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(273, 248)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(33, 15)
        Me.GunaLabel3.TabIndex = 8
        Me.GunaLabel3.Text = "Price"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(273, 194)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(119, 15)
        Me.GunaLabel4.TabIndex = 9
        Me.GunaLabel4.Text = "Unit of Measurement"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(12, 248)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(49, 15)
        Me.GunaLabel5.TabIndex = 12
        Me.GunaLabel5.Text = "Quantiy"
        '
        'itemIDR
        '
        Me.itemIDR.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemIDR.Appearance.ForeColor = System.Drawing.Color.Green
        Me.itemIDR.Appearance.Options.UseFont = True
        Me.itemIDR.Appearance.Options.UseForeColor = True
        Me.itemIDR.Location = New System.Drawing.Point(5, 59)
        Me.itemIDR.Name = "itemIDR"
        Me.itemIDR.Size = New System.Drawing.Size(86, 23)
        Me.itemIDR.TabIndex = 15
        Me.itemIDR.Text = "ITEM ID:"
        '
        'quantityR
        '
        Me.quantityR.BackColor = System.Drawing.Color.Transparent
        Me.quantityR.BaseColor = System.Drawing.Color.White
        Me.quantityR.BorderColor = System.Drawing.Color.Silver
        Me.quantityR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.quantityR.FocusedBaseColor = System.Drawing.Color.White
        Me.quantityR.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.quantityR.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.quantityR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.quantityR.ForeColor = System.Drawing.Color.Red
        Me.quantityR.Location = New System.Drawing.Point(15, 266)
        Me.quantityR.Name = "quantityR"
        Me.quantityR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.quantityR.Radius = 10
        Me.quantityR.ReadOnly = True
        Me.quantityR.SelectedText = ""
        Me.quantityR.Size = New System.Drawing.Size(239, 26)
        Me.quantityR.TabIndex = 13
        Me.quantityR.Text = "GunaTextBox3"
        '
        'priceR
        '
        Me.priceR.BackColor = System.Drawing.Color.Transparent
        Me.priceR.BaseColor = System.Drawing.Color.White
        Me.priceR.BorderColor = System.Drawing.Color.Silver
        Me.priceR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.priceR.FocusedBaseColor = System.Drawing.Color.White
        Me.priceR.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.priceR.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.priceR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.priceR.ForeColor = System.Drawing.Color.Red
        Me.priceR.Location = New System.Drawing.Point(276, 266)
        Me.priceR.Name = "priceR"
        Me.priceR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.priceR.Radius = 10
        Me.priceR.ReadOnly = True
        Me.priceR.SelectedText = ""
        Me.priceR.Size = New System.Drawing.Size(263, 26)
        Me.priceR.TabIndex = 16
        Me.priceR.Text = "GunaTextBox2"
        '
        'totalamountR
        '
        Me.totalamountR.BackColor = System.Drawing.Color.Transparent
        Me.totalamountR.BaseColor = System.Drawing.Color.White
        Me.totalamountR.BorderColor = System.Drawing.Color.Silver
        Me.totalamountR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.totalamountR.FocusedBaseColor = System.Drawing.Color.White
        Me.totalamountR.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalamountR.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.totalamountR.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalamountR.ForeColor = System.Drawing.Color.Red
        Me.totalamountR.Location = New System.Drawing.Point(15, 313)
        Me.totalamountR.Name = "totalamountR"
        Me.totalamountR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalamountR.Radius = 10
        Me.totalamountR.ReadOnly = True
        Me.totalamountR.SelectedText = ""
        Me.totalamountR.Size = New System.Drawing.Size(525, 36)
        Me.totalamountR.TabIndex = 18
        Me.totalamountR.Text = "GunaTextBox4"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(12, 295)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(79, 15)
        Me.GunaLabel6.TabIndex = 17
        Me.GunaLabel6.Text = "Total Amount"
        '
        'categoryR
        '
        Me.categoryR.BackColor = System.Drawing.Color.Transparent
        Me.categoryR.BaseColor = System.Drawing.Color.White
        Me.categoryR.BorderColor = System.Drawing.Color.Silver
        Me.categoryR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.categoryR.FocusedBaseColor = System.Drawing.Color.White
        Me.categoryR.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.categoryR.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.categoryR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.categoryR.ForeColor = System.Drawing.Color.Red
        Me.categoryR.Location = New System.Drawing.Point(12, 212)
        Me.categoryR.Name = "categoryR"
        Me.categoryR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.categoryR.Radius = 10
        Me.categoryR.ReadOnly = True
        Me.categoryR.SelectedText = ""
        Me.categoryR.Size = New System.Drawing.Size(239, 26)
        Me.categoryR.TabIndex = 19
        Me.categoryR.Text = "GunaTextBox3"
        '
        'measureR
        '
        Me.measureR.BackColor = System.Drawing.Color.Transparent
        Me.measureR.BaseColor = System.Drawing.Color.White
        Me.measureR.BorderColor = System.Drawing.Color.Silver
        Me.measureR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.measureR.FocusedBaseColor = System.Drawing.Color.White
        Me.measureR.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.measureR.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.measureR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.measureR.ForeColor = System.Drawing.Color.Red
        Me.measureR.Location = New System.Drawing.Point(276, 212)
        Me.measureR.Name = "measureR"
        Me.measureR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.measureR.Radius = 10
        Me.measureR.ReadOnly = True
        Me.measureR.SelectedText = ""
        Me.measureR.Size = New System.Drawing.Size(263, 26)
        Me.measureR.TabIndex = 20
        Me.measureR.Text = "GunaTextBox3"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(176, 59)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(130, 23)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Inventory ID:"
        '
        'inventoryID
        '
        Me.inventoryID.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryID.Appearance.ForeColor = System.Drawing.Color.Green
        Me.inventoryID.Appearance.Options.UseFont = True
        Me.inventoryID.Appearance.Options.UseForeColor = True
        Me.inventoryID.Location = New System.Drawing.Point(312, 59)
        Me.inventoryID.Name = "inventoryID"
        Me.inventoryID.Size = New System.Drawing.Size(86, 23)
        Me.inventoryID.TabIndex = 22
        Me.inventoryID.Text = "ITEM ID:"
        '
        'itemReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 373)
        Me.Controls.Add(Me.inventoryID)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.itemIDR)
        Me.Controls.Add(Me.measureR)
        Me.Controls.Add(Me.categoryR)
        Me.Controls.Add(Me.totalamountR)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.priceR)
        Me.Controls.Add(Me.quantityR)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.descriptionR)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "itemReview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "itemReview"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents descriptionR As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents itemIDR As DevExpress.XtraEditors.LabelControl
    Friend WithEvents quantityR As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents priceR As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents totalamountR As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents categoryR As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents measureR As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents inventoryID As DevExpress.XtraEditors.LabelControl
End Class
