<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class updateItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(updateItem))
        Me.inventoryID = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.totalamountR = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.quantityR = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.descriptionR = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.priceR = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.measureR = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.reasonR = New Guna.UI.WinForms.GunaTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'inventoryID
        '
        Me.inventoryID.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inventoryID.Appearance.ForeColor = System.Drawing.Color.Green
        Me.inventoryID.Appearance.Options.UseFont = True
        Me.inventoryID.Appearance.Options.UseForeColor = True
        Me.inventoryID.Location = New System.Drawing.Point(186, 71)
        Me.inventoryID.Name = "inventoryID"
        Me.inventoryID.Size = New System.Drawing.Size(86, 23)
        Me.inventoryID.TabIndex = 38
        Me.inventoryID.Text = "ITEM ID:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(50, 71)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(130, 23)
        Me.LabelControl2.TabIndex = 37
        Me.LabelControl2.Text = "Inventory ID:"
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
        Me.totalamountR.Location = New System.Drawing.Point(15, 332)
        Me.totalamountR.Name = "totalamountR"
        Me.totalamountR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalamountR.Radius = 10
        Me.totalamountR.ReadOnly = True
        Me.totalamountR.SelectedText = ""
        Me.totalamountR.Size = New System.Drawing.Size(525, 36)
        Me.totalamountR.TabIndex = 34
        Me.totalamountR.Text = "GunaTextBox4"
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(12, 314)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(79, 15)
        Me.GunaLabel6.TabIndex = 33
        Me.GunaLabel6.Text = "Total Amount"
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
        Me.quantityR.Location = New System.Drawing.Point(15, 285)
        Me.quantityR.Name = "quantityR"
        Me.quantityR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.quantityR.Radius = 10
        Me.quantityR.ReadOnly = True
        Me.quantityR.SelectedText = ""
        Me.quantityR.Size = New System.Drawing.Size(239, 26)
        Me.quantityR.TabIndex = 30
        Me.quantityR.Text = "GunaTextBox3"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(12, 267)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(53, 15)
        Me.GunaLabel5.TabIndex = 29
        Me.GunaLabel5.Text = "Quantity"
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
        Me.descriptionR.Location = New System.Drawing.Point(15, 136)
        Me.descriptionR.Name = "descriptionR"
        Me.descriptionR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.descriptionR.Radius = 10
        Me.descriptionR.SelectedText = ""
        Me.descriptionR.Size = New System.Drawing.Size(524, 72)
        Me.descriptionR.TabIndex = 26
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(12, 118)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(67, 15)
        Me.GunaLabel1.TabIndex = 24
        Me.GunaLabel1.Text = "Description"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(207, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ITEM UPDATE"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.GunaAdvenceButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 46)
        Me.Panel1.TabIndex = 23
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Red
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = CType(resources.GetObject("GunaAdvenceButton1.CheckedImage"), System.Drawing.Image)
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = CType(resources.GetObject("GunaAdvenceButton1.Image"), System.Drawing.Image)
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(433, 8)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 10
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(106, 27)
        Me.GunaAdvenceButton1.TabIndex = 1
        Me.GunaAdvenceButton1.Text = "Update"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(273, 267)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(33, 15)
        Me.GunaLabel3.TabIndex = 27
        Me.GunaLabel3.Text = "Price"
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
        Me.priceR.Location = New System.Drawing.Point(276, 285)
        Me.priceR.Name = "priceR"
        Me.priceR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.priceR.Radius = 10
        Me.priceR.ReadOnly = True
        Me.priceR.SelectedText = ""
        Me.priceR.Size = New System.Drawing.Size(263, 26)
        Me.priceR.TabIndex = 32
        Me.priceR.Text = "GunaTextBox2"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(273, 213)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(119, 15)
        Me.GunaLabel4.TabIndex = 28
        Me.GunaLabel4.Text = "Unit of Measurement"
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
        Me.measureR.Location = New System.Drawing.Point(276, 231)
        Me.measureR.Name = "measureR"
        Me.measureR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.measureR.Radius = 10
        Me.measureR.SelectedText = ""
        Me.measureR.Size = New System.Drawing.Size(263, 26)
        Me.measureR.TabIndex = 36
        Me.measureR.Text = "GunaTextBox3"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 211)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(110, 15)
        Me.GunaLabel2.TabIndex = 25
        Me.GunaLabel2.Text = "Reason for changes"
        '
        'reasonR
        '
        Me.reasonR.BackColor = System.Drawing.Color.Transparent
        Me.reasonR.BaseColor = System.Drawing.Color.White
        Me.reasonR.BorderColor = System.Drawing.Color.Silver
        Me.reasonR.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.reasonR.FocusedBaseColor = System.Drawing.Color.White
        Me.reasonR.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.reasonR.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.reasonR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.reasonR.ForeColor = System.Drawing.Color.Red
        Me.reasonR.Location = New System.Drawing.Point(12, 231)
        Me.reasonR.Name = "reasonR"
        Me.reasonR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.reasonR.Radius = 10
        Me.reasonR.SelectedText = ""
        Me.reasonR.Size = New System.Drawing.Size(239, 26)
        Me.reasonR.TabIndex = 35
        Me.reasonR.Text = ">Required<"
        '
        'updateItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 386)
        Me.Controls.Add(Me.inventoryID)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.measureR)
        Me.Controls.Add(Me.reasonR)
        Me.Controls.Add(Me.totalamountR)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.priceR)
        Me.Controls.Add(Me.quantityR)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.descriptionR)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "updateItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "updateItem"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents inventoryID As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents totalamountR As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents quantityR As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents descriptionR As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents priceR As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents measureR As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents reasonR As Guna.UI.WinForms.GunaTextBox
End Class
