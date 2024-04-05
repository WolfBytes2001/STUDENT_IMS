<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class purchaseOrder
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(purchaseOrder))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.POID = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.POoffice = New System.Windows.Forms.Label()
        Me.POrequesitionOfficer = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.POrequestNumber = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TotalAmount = New System.Windows.Forms.Label()
        Me.POdepCode = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.POestimBudget = New System.Windows.Forms.TextBox()
        Me.POappCode = New System.Windows.Forms.TextBox()
        Me.POestimCost = New System.Windows.Forms.TextBox()
        Me.POsourceOfFund = New System.Windows.Forms.TextBox()
        Me.POModeOfProC = New System.Windows.Forms.TextBox()
        Me.poPurpose = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.confirPOButton = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.supplierNameBox = New System.Windows.Forms.ComboBox()
        Me.shippingMethodBox = New System.Windows.Forms.RichTextBox()
        Me.shipViaBox = New System.Windows.Forms.RichTextBox()
        Me.productBox = New System.Windows.Forms.RichTextBox()
        Me.deliveryDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.itemsIncludedTable = New Guna.UI.WinForms.GunaDataGridView()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.VendorDataGrid = New Guna.UI.WinForms.GunaDataGridView()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.vendorLocationInput = New System.Windows.Forms.RichTextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.VendorIDinput = New System.Windows.Forms.RichTextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.VendorContactInfoInput = New System.Windows.Forms.RichTextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.VendorTypeInput = New System.Windows.Forms.RichTextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.vendorNameInput = New System.Windows.Forms.RichTextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.itemsIncludedTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.VendorDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.POID)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.POoffice)
        Me.Panel1.Controls.Add(Me.POrequesitionOfficer)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.POrequestNumber)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Gold
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1098, 67)
        Me.Panel1.TabIndex = 5
        '
        'POID
        '
        Me.POID.AutoSize = True
        Me.POID.BackColor = System.Drawing.Color.SlateGray
        Me.POID.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POID.ForeColor = System.Drawing.Color.MidnightBlue
        Me.POID.Location = New System.Drawing.Point(314, 13)
        Me.POID.Name = "POID"
        Me.POID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.POID.Size = New System.Drawing.Size(47, 24)
        Me.POID.TabIndex = 8
        Me.POID.Text = "RQ-"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Gold
        Me.Label17.Location = New System.Drawing.Point(257, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 17)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "PO ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(838, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Office:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(505, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Requesition Officer:"
        '
        'POoffice
        '
        Me.POoffice.AutoSize = True
        Me.POoffice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POoffice.ForeColor = System.Drawing.Color.White
        Me.POoffice.Location = New System.Drawing.Point(902, 19)
        Me.POoffice.Name = "POoffice"
        Me.POoffice.Size = New System.Drawing.Size(49, 17)
        Me.POoffice.TabIndex = 4
        Me.POoffice.Text = "Office:"
        '
        'POrequesitionOfficer
        '
        Me.POrequesitionOfficer.AutoSize = True
        Me.POrequesitionOfficer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POrequesitionOfficer.ForeColor = System.Drawing.Color.White
        Me.POrequesitionOfficer.Location = New System.Drawing.Point(663, 19)
        Me.POrequesitionOfficer.Name = "POrequesitionOfficer"
        Me.POrequesitionOfficer.Size = New System.Drawing.Size(133, 17)
        Me.POrequesitionOfficer.TabIndex = 2
        Me.POrequesitionOfficer.Text = "Requesition Officer:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(11, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Request ID:"
        '
        'POrequestNumber
        '
        Me.POrequestNumber.AutoSize = True
        Me.POrequestNumber.BackColor = System.Drawing.Color.SlateGray
        Me.POrequestNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POrequestNumber.ForeColor = System.Drawing.Color.LawnGreen
        Me.POrequestNumber.Location = New System.Drawing.Point(100, 13)
        Me.POrequestNumber.Name = "POrequestNumber"
        Me.POrequestNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.POrequestNumber.Size = New System.Drawing.Size(47, 24)
        Me.POrequestNumber.TabIndex = 0
        Me.POrequestNumber.Text = "RQ-"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1098, 141)
        Me.Panel2.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel6.Controls.Add(Me.Label13)
        Me.Panel6.Controls.Add(Me.TotalAmount)
        Me.Panel6.Controls.Add(Me.POdepCode)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.POestimBudget)
        Me.Panel6.Controls.Add(Me.POappCode)
        Me.Panel6.Controls.Add(Me.POestimCost)
        Me.Panel6.Controls.Add(Me.POsourceOfFund)
        Me.Panel6.Controls.Add(Me.POModeOfProC)
        Me.Panel6.Controls.Add(Me.poPurpose)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1098, 141)
        Me.Panel6.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label13.Location = New System.Drawing.Point(706, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 27)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Total:"
        '
        'TotalAmount
        '
        Me.TotalAmount.AutoSize = True
        Me.TotalAmount.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmount.ForeColor = System.Drawing.Color.Red
        Me.TotalAmount.Location = New System.Drawing.Point(807, 106)
        Me.TotalAmount.Name = "TotalAmount"
        Me.TotalAmount.Size = New System.Drawing.Size(68, 27)
        Me.TotalAmount.TabIndex = 36
        Me.TotalAmount.Text = "Total"
        '
        'POdepCode
        '
        Me.POdepCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POdepCode.Location = New System.Drawing.Point(543, 69)
        Me.POdepCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.POdepCode.Name = "POdepCode"
        Me.POdepCode.ReadOnly = True
        Me.POdepCode.Size = New System.Drawing.Size(516, 21)
        Me.POdepCode.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(29, 92)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(90, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Estimated Budget"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(309, 90)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Estimated Cost"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(352, 6)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Source of Fund"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "APP Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(736, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Mode of Procurement"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Purpose"
        '
        'POestimBudget
        '
        Me.POestimBudget.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POestimBudget.Location = New System.Drawing.Point(32, 106)
        Me.POestimBudget.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.POestimBudget.Name = "POestimBudget"
        Me.POestimBudget.ReadOnly = True
        Me.POestimBudget.Size = New System.Drawing.Size(255, 21)
        Me.POestimBudget.TabIndex = 28
        '
        'POappCode
        '
        Me.POappCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POappCode.Location = New System.Drawing.Point(32, 69)
        Me.POappCode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.POappCode.Name = "POappCode"
        Me.POappCode.ReadOnly = True
        Me.POappCode.Size = New System.Drawing.Size(486, 21)
        Me.POappCode.TabIndex = 27
        '
        'POestimCost
        '
        Me.POestimCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POestimCost.Location = New System.Drawing.Point(312, 106)
        Me.POestimCost.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.POestimCost.Name = "POestimCost"
        Me.POestimCost.ReadOnly = True
        Me.POestimCost.Size = New System.Drawing.Size(388, 21)
        Me.POestimCost.TabIndex = 26
        '
        'POsourceOfFund
        '
        Me.POsourceOfFund.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POsourceOfFund.Location = New System.Drawing.Point(342, 26)
        Me.POsourceOfFund.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.POsourceOfFund.Name = "POsourceOfFund"
        Me.POsourceOfFund.ReadOnly = True
        Me.POsourceOfFund.Size = New System.Drawing.Size(370, 21)
        Me.POsourceOfFund.TabIndex = 25
        '
        'POModeOfProC
        '
        Me.POModeOfProC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.POModeOfProC.Location = New System.Drawing.Point(741, 26)
        Me.POModeOfProC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.POModeOfProC.Name = "POModeOfProC"
        Me.POModeOfProC.ReadOnly = True
        Me.POModeOfProC.Size = New System.Drawing.Size(318, 21)
        Me.POModeOfProC.TabIndex = 24
        '
        'poPurpose
        '
        Me.poPurpose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.poPurpose.Location = New System.Drawing.Point(32, 26)
        Me.poPurpose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.poPurpose.Name = "poPurpose"
        Me.poPurpose.ReadOnly = True
        Me.poPurpose.Size = New System.Drawing.Size(294, 21)
        Me.poPurpose.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(540, 53)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Department Code"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel5.Controls.Add(Me.confirPOButton)
        Me.Panel5.Controls.Add(Me.supplierNameBox)
        Me.Panel5.Controls.Add(Me.shippingMethodBox)
        Me.Panel5.Controls.Add(Me.shipViaBox)
        Me.Panel5.Controls.Add(Me.productBox)
        Me.Panel5.Controls.Add(Me.deliveryDatePicker)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.ForeColor = System.Drawing.Color.Gold
        Me.Panel5.Location = New System.Drawing.Point(0, 208)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1098, 85)
        Me.Panel5.TabIndex = 7
        '
        'confirPOButton
        '
        Me.confirPOButton.AnimationHoverSpeed = 0.07!
        Me.confirPOButton.AnimationSpeed = 0.03!
        Me.confirPOButton.BackColor = System.Drawing.Color.Transparent
        Me.confirPOButton.BaseColor = System.Drawing.Color.Green
        Me.confirPOButton.BorderColor = System.Drawing.Color.Black
        Me.confirPOButton.CheckedBaseColor = System.Drawing.Color.Gray
        Me.confirPOButton.CheckedBorderColor = System.Drawing.Color.Black
        Me.confirPOButton.CheckedForeColor = System.Drawing.Color.White
        Me.confirPOButton.CheckedImage = CType(resources.GetObject("confirPOButton.CheckedImage"), System.Drawing.Image)
        Me.confirPOButton.CheckedLineColor = System.Drawing.Color.DimGray
        Me.confirPOButton.DialogResult = System.Windows.Forms.DialogResult.None
        Me.confirPOButton.FocusedColor = System.Drawing.Color.Empty
        Me.confirPOButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.confirPOButton.ForeColor = System.Drawing.Color.White
        Me.confirPOButton.Image = CType(resources.GetObject("confirPOButton.Image"), System.Drawing.Image)
        Me.confirPOButton.ImageSize = New System.Drawing.Size(20, 20)
        Me.confirPOButton.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.confirPOButton.Location = New System.Drawing.Point(973, 35)
        Me.confirPOButton.Name = "confirPOButton"
        Me.confirPOButton.OnHoverBaseColor = System.Drawing.Color.Red
        Me.confirPOButton.OnHoverBorderColor = System.Drawing.Color.Black
        Me.confirPOButton.OnHoverForeColor = System.Drawing.Color.White
        Me.confirPOButton.OnHoverImage = Nothing
        Me.confirPOButton.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.confirPOButton.OnPressedColor = System.Drawing.Color.Black
        Me.confirPOButton.Radius = 10
        Me.confirPOButton.Size = New System.Drawing.Size(109, 36)
        Me.confirPOButton.TabIndex = 55
        Me.confirPOButton.Text = "CONFIRM"
        '
        'supplierNameBox
        '
        Me.supplierNameBox.FormattingEnabled = True
        Me.supplierNameBox.Location = New System.Drawing.Point(151, 28)
        Me.supplierNameBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.supplierNameBox.Name = "supplierNameBox"
        Me.supplierNameBox.Size = New System.Drawing.Size(210, 21)
        Me.supplierNameBox.TabIndex = 44
        '
        'shippingMethodBox
        '
        Me.shippingMethodBox.Location = New System.Drawing.Point(528, 53)
        Me.shippingMethodBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.shippingMethodBox.Name = "shippingMethodBox"
        Me.shippingMethodBox.Size = New System.Drawing.Size(184, 23)
        Me.shippingMethodBox.TabIndex = 42
        Me.shippingMethodBox.Text = ""
        '
        'shipViaBox
        '
        Me.shipViaBox.Location = New System.Drawing.Point(447, 28)
        Me.shipViaBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.shipViaBox.Name = "shipViaBox"
        Me.shipViaBox.Size = New System.Drawing.Size(265, 23)
        Me.shipViaBox.TabIndex = 41
        Me.shipViaBox.Text = ""
        '
        'productBox
        '
        Me.productBox.Location = New System.Drawing.Point(149, 55)
        Me.productBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.productBox.Name = "productBox"
        Me.productBox.Size = New System.Drawing.Size(211, 23)
        Me.productBox.TabIndex = 40
        Me.productBox.Text = ""
        '
        'deliveryDatePicker
        '
        Me.deliveryDatePicker.Location = New System.Drawing.Point(720, 56)
        Me.deliveryDatePicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.deliveryDatePicker.Name = "deliveryDatePicker"
        Me.deliveryDatePicker.Size = New System.Drawing.Size(217, 21)
        Me.deliveryDatePicker.TabIndex = 39
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Gold
        Me.Label22.Location = New System.Drawing.Point(2, 54)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(137, 17)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "PRODUCT BRAND:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Gold
        Me.Label21.Location = New System.Drawing.Point(717, 28)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(215, 17)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "PREFERRED DELIVERY DATE:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Gold
        Me.Label20.Location = New System.Drawing.Point(366, 58)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(152, 17)
        Me.Label20.TabIndex = 32
        Me.Label20.Text = "SHIPPING METHOD:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Gold
        Me.Label19.Location = New System.Drawing.Point(366, 28)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 17)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "SHIP VIA:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Gold
        Me.Label18.Location = New System.Drawing.Point(2, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(130, 17)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "SUPPLIER NAME:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(-4, -1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 17)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Reference Information"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 293)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage3
        Me.XtraTabControl1.Size = New System.Drawing.Size(1098, 207)
        Me.XtraTabControl1.TabIndex = 8
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.itemsIncludedTable)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1092, 179)
        Me.XtraTabPage3.Text = "ITEMS INCLUDED"
        '
        'itemsIncludedTable
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.itemsIncludedTable.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.itemsIncludedTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.itemsIncludedTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.itemsIncludedTable.BackgroundColor = System.Drawing.Color.White
        Me.itemsIncludedTable.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.itemsIncludedTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.itemsIncludedTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.itemsIncludedTable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.itemsIncludedTable.ColumnHeadersHeight = 15
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.itemsIncludedTable.DefaultCellStyle = DataGridViewCellStyle3
        Me.itemsIncludedTable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.itemsIncludedTable.EnableHeadersVisualStyles = False
        Me.itemsIncludedTable.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.itemsIncludedTable.Location = New System.Drawing.Point(0, 0)
        Me.itemsIncludedTable.Name = "itemsIncludedTable"
        Me.itemsIncludedTable.RowHeadersVisible = False
        Me.itemsIncludedTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.itemsIncludedTable.Size = New System.Drawing.Size(1092, 179)
        Me.itemsIncludedTable.TabIndex = 2
        Me.itemsIncludedTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.GreenSea
        Me.itemsIncludedTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(218, Byte), Integer))
        Me.itemsIncludedTable.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.itemsIncludedTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.itemsIncludedTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.itemsIncludedTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.itemsIncludedTable.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.itemsIncludedTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(182, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.itemsIncludedTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.itemsIncludedTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.itemsIncludedTable.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.itemsIncludedTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.itemsIncludedTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.itemsIncludedTable.ThemeStyle.HeaderStyle.Height = 15
        Me.itemsIncludedTable.ThemeStyle.ReadOnly = False
        Me.itemsIncludedTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.itemsIncludedTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.itemsIncludedTable.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.itemsIncludedTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.itemsIncludedTable.ThemeStyle.RowsStyle.Height = 22
        Me.itemsIncludedTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.itemsIncludedTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.VendorDataGrid)
        Me.XtraTabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1096, 176)
        Me.XtraTabPage1.Text = "Vendors"
        '
        'VendorDataGrid
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.VendorDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.VendorDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.VendorDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.VendorDataGrid.BackgroundColor = System.Drawing.Color.White
        Me.VendorDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VendorDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.VendorDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VendorDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.VendorDataGrid.ColumnHeadersHeight = 15
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.VendorDataGrid.DefaultCellStyle = DataGridViewCellStyle6
        Me.VendorDataGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VendorDataGrid.EnableHeadersVisualStyles = False
        Me.VendorDataGrid.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.VendorDataGrid.Location = New System.Drawing.Point(0, 0)
        Me.VendorDataGrid.Name = "VendorDataGrid"
        Me.VendorDataGrid.RowHeadersVisible = False
        Me.VendorDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.VendorDataGrid.Size = New System.Drawing.Size(1096, 176)
        Me.VendorDataGrid.TabIndex = 3
        Me.VendorDataGrid.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Blue
        Me.VendorDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.VendorDataGrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.VendorDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.VendorDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.VendorDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.VendorDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.VendorDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.VendorDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.VendorDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.VendorDataGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.VendorDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.VendorDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.VendorDataGrid.ThemeStyle.HeaderStyle.Height = 15
        Me.VendorDataGrid.ThemeStyle.ReadOnly = False
        Me.VendorDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.VendorDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.VendorDataGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.VendorDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.VendorDataGrid.ThemeStyle.RowsStyle.Height = 22
        Me.VendorDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.VendorDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GunaAdvenceButton1)
        Me.XtraTabPage2.Controls.Add(Me.vendorLocationInput)
        Me.XtraTabPage2.Controls.Add(Me.Label27)
        Me.XtraTabPage2.Controls.Add(Me.VendorIDinput)
        Me.XtraTabPage2.Controls.Add(Me.Label26)
        Me.XtraTabPage2.Controls.Add(Me.VendorContactInfoInput)
        Me.XtraTabPage2.Controls.Add(Me.Label25)
        Me.XtraTabPage2.Controls.Add(Me.VendorTypeInput)
        Me.XtraTabPage2.Controls.Add(Me.Label24)
        Me.XtraTabPage2.Controls.Add(Me.vendorNameInput)
        Me.XtraTabPage2.Controls.Add(Me.Label23)
        Me.XtraTabPage2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1096, 176)
        Me.XtraTabPage2.Text = "Add a Vendor"
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.Green
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
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(923, 68)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Red
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaAdvenceButton1.Radius = 10
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(120, 36)
        Me.GunaAdvenceButton1.TabIndex = 56
        Me.GunaAdvenceButton1.Text = "SAVE VENDOR"
        '
        'vendorLocationInput
        '
        Me.vendorLocationInput.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.vendorLocationInput.Location = New System.Drawing.Point(553, 69)
        Me.vendorLocationInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.vendorLocationInput.Name = "vendorLocationInput"
        Me.vendorLocationInput.Size = New System.Drawing.Size(299, 58)
        Me.vendorLocationInput.TabIndex = 53
        Me.vendorLocationInput.Text = ""
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.BackColor = System.Drawing.Color.SlateGray
        Me.Label27.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Gold
        Me.Label27.Location = New System.Drawing.Point(454, 68)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 17)
        Me.Label27.TabIndex = 52
        Me.Label27.Text = "Location:"
        '
        'VendorIDinput
        '
        Me.VendorIDinput.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.VendorIDinput.Location = New System.Drawing.Point(553, 28)
        Me.VendorIDinput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VendorIDinput.Name = "VendorIDinput"
        Me.VendorIDinput.Size = New System.Drawing.Size(299, 23)
        Me.VendorIDinput.TabIndex = 50
        Me.VendorIDinput.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.SlateGray
        Me.Label26.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Gold
        Me.Label26.Location = New System.Drawing.Point(457, 28)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(85, 17)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "Vendor ID:"
        '
        'VendorContactInfoInput
        '
        Me.VendorContactInfoInput.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.VendorContactInfoInput.Location = New System.Drawing.Point(186, 110)
        Me.VendorContactInfoInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VendorContactInfoInput.Name = "VendorContactInfoInput"
        Me.VendorContactInfoInput.Size = New System.Drawing.Size(229, 23)
        Me.VendorContactInfoInput.TabIndex = 48
        Me.VendorContactInfoInput.Text = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.SlateGray
        Me.Label25.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Gold
        Me.Label25.Location = New System.Drawing.Point(60, 110)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(102, 17)
        Me.Label25.TabIndex = 47
        Me.Label25.Text = "Contact Info:"
        '
        'VendorTypeInput
        '
        Me.VendorTypeInput.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.VendorTypeInput.Location = New System.Drawing.Point(186, 69)
        Me.VendorTypeInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.VendorTypeInput.Name = "VendorTypeInput"
        Me.VendorTypeInput.Size = New System.Drawing.Size(229, 23)
        Me.VendorTypeInput.TabIndex = 46
        Me.VendorTypeInput.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.BackColor = System.Drawing.Color.SlateGray
        Me.Label24.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Gold
        Me.Label24.Location = New System.Drawing.Point(60, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(102, 17)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "Vendor Type:"
        '
        'vendorNameInput
        '
        Me.vendorNameInput.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.vendorNameInput.Location = New System.Drawing.Point(186, 29)
        Me.vendorNameInput.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.vendorNameInput.Name = "vendorNameInput"
        Me.vendorNameInput.Size = New System.Drawing.Size(229, 23)
        Me.vendorNameInput.TabIndex = 44
        Me.vendorNameInput.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.SlateGray
        Me.Label23.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Gold
        Me.Label23.Location = New System.Drawing.Point(60, 29)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(108, 17)
        Me.Label23.TabIndex = 44
        Me.Label23.Text = "Vendor Name:"
        '
        'purchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "purchaseOrder"
        Me.Size = New System.Drawing.Size(1098, 500)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage3.ResumeLayout(False)
        CType(Me.itemsIncludedTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage1.ResumeLayout(False)
        CType(Me.VendorDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents POID As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents POoffice As Label
    Friend WithEvents POrequesitionOfficer As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents POrequestNumber As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents POdepCode As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents POestimBudget As TextBox
    Friend WithEvents POappCode As TextBox
    Friend WithEvents POestimCost As TextBox
    Friend WithEvents POsourceOfFund As TextBox
    Friend WithEvents POModeOfProC As TextBox
    Friend WithEvents poPurpose As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents supplierNameBox As ComboBox
    Friend WithEvents shippingMethodBox As RichTextBox
    Friend WithEvents shipViaBox As RichTextBox
    Friend WithEvents productBox As RichTextBox
    Friend WithEvents deliveryDatePicker As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents vendorLocationInput As RichTextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents VendorIDinput As RichTextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents VendorContactInfoInput As RichTextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents VendorTypeInput As RichTextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents vendorNameInput As RichTextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents itemsIncludedTable As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents TotalAmount As Label
    Friend WithEvents confirPOButton As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents VendorDataGrid As Guna.UI.WinForms.GunaDataGridView
End Class
