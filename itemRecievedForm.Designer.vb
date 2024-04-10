<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class itemRecievedForm
    Inherits DevExpress.XtraBars.Ribbon.RibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(itemRecievedForm))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.poId_IR = New System.Windows.Forms.RichTextBox()
        Me.recieved_itemButton = New DevExpress.XtraEditors.SimpleButton()
        Me.itemConditionCB = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.date_recieved_IR = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inspected_by = New System.Windows.Forms.RichTextBox()
        Me.vehicle_type = New System.Windows.Forms.RichTextBox()
        Me.personnel_ir = New System.Windows.Forms.RichTextBox()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.SimpleButton2)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(876, 41)
        Me.Panel1.TabIndex = 0
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.SlateGray
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.ImageOptions.SvgImage = CType(resources.GetObject("SimpleButton2.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.SimpleButton2.Location = New System.Drawing.Point(806, 6)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(39, 30)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Text = "SimpleButton2"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Lime
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(384, 7)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(169, 22)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "ITEM INSPECTION"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.SimpleButton1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.poId_IR)
        Me.Panel2.Controls.Add(Me.recieved_itemButton)
        Me.Panel2.Controls.Add(Me.itemConditionCB)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.date_recieved_IR)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.inspected_by)
        Me.Panel2.Controls.Add(Me.vehicle_type)
        Me.Panel2.Controls.Add(Me.personnel_ir)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(876, 250)
        Me.Panel2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(609, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Proof of Delivery"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(690, 175)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(94, 20)
        Me.SimpleButton1.TabIndex = 17
        Me.SimpleButton1.Text = "Upload"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(617, 27)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Silver
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label7.Location = New System.Drawing.Point(42, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Purchase Order ID"
        '
        'poId_IR
        '
        Me.poId_IR.Location = New System.Drawing.Point(45, 44)
        Me.poId_IR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.poId_IR.Name = "poId_IR"
        Me.poId_IR.Size = New System.Drawing.Size(259, 28)
        Me.poId_IR.TabIndex = 14
        Me.poId_IR.Text = ""
        '
        'recieved_itemButton
        '
        Me.recieved_itemButton.Appearance.BackColor = System.Drawing.Color.Lime
        Me.recieved_itemButton.Appearance.Options.UseBackColor = True
        Me.recieved_itemButton.ImageOptions.Image = CType(resources.GetObject("recieved_itemButton.ImageOptions.Image"), System.Drawing.Image)
        Me.recieved_itemButton.Location = New System.Drawing.Point(400, 176)
        Me.recieved_itemButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.recieved_itemButton.Name = "recieved_itemButton"
        Me.recieved_itemButton.Size = New System.Drawing.Size(119, 38)
        Me.recieved_itemButton.TabIndex = 13
        Me.recieved_itemButton.Text = "Recieved Item"
        '
        'itemConditionCB
        '
        Me.itemConditionCB.FormattingEnabled = True
        Me.itemConditionCB.Items.AddRange(New Object() {"Good"})
        Me.itemConditionCB.Location = New System.Drawing.Point(345, 116)
        Me.itemConditionCB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.itemConditionCB.Name = "itemConditionCB"
        Me.itemConditionCB.Size = New System.Drawing.Size(223, 21)
        Me.itemConditionCB.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(351, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Item Condition"
        '
        'date_recieved_IR
        '
        Me.date_recieved_IR.Location = New System.Drawing.Point(345, 42)
        Me.date_recieved_IR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.date_recieved_IR.Name = "date_recieved_IR"
        Me.date_recieved_IR.Size = New System.Drawing.Size(223, 21)
        Me.date_recieved_IR.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(351, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Date Recieved"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Recieved and Inspected by"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(-3, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Delivery Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Vehicle Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Personnel Name"
        '
        'inspected_by
        '
        Me.inspected_by.Location = New System.Drawing.Point(45, 205)
        Me.inspected_by.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.inspected_by.Name = "inspected_by"
        Me.inspected_by.Size = New System.Drawing.Size(259, 28)
        Me.inspected_by.TabIndex = 2
        Me.inspected_by.Text = ""
        '
        'vehicle_type
        '
        Me.vehicle_type.Location = New System.Drawing.Point(48, 148)
        Me.vehicle_type.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.vehicle_type.Name = "vehicle_type"
        Me.vehicle_type.Size = New System.Drawing.Size(259, 28)
        Me.vehicle_type.TabIndex = 1
        Me.vehicle_type.Text = ""
        '
        'personnel_ir
        '
        Me.personnel_ir.Location = New System.Drawing.Point(48, 91)
        Me.personnel_ir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.personnel_ir.Name = "personnel_ir"
        Me.personnel_ir.Size = New System.Drawing.Size(259, 28)
        Me.personnel_ir.TabIndex = 0
        Me.personnel_ir.Text = ""
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'itemRecievedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 291)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "itemRecievedForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "itemRecieved"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents inspected_by As RichTextBox
    Friend WithEvents vehicle_type As RichTextBox
    Friend WithEvents personnel_ir As RichTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents date_recieved_IR As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents recieved_itemButton As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents itemConditionCB As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents poId_IR As RichTextBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
