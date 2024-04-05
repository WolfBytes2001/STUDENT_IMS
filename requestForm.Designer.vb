<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class requestForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.rqOffice = New System.Windows.Forms.ComboBox()
        Me.rqOfficer = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.requestNumber = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.estimBud = New System.Windows.Forms.TextBox()
        Me.sourceOfFundBox = New System.Windows.Forms.ComboBox()
        Me.papBox = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.estimCost = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbModProc = New System.Windows.Forms.ComboBox()
        Me.cbDepCode = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.purposeBox = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itemDescriptionBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.checkoutTXTBOX = New System.Windows.Forms.TextBox()
        Me.totalPriceBox = New System.Windows.Forms.TextBox()
        Me.itemPriceBox = New System.Windows.Forms.TextBox()
        Me.quantityBox = New System.Windows.Forms.TextBox()
        Me.unit_of_measureBox = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.rFormTable = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.rFormTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.rqOffice)
        Me.Panel1.Controls.Add(Me.rqOfficer)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.requestNumber)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1262, 57)
        Me.Panel1.TabIndex = 0
        '
        'rqOffice
        '
        Me.rqOffice.FormattingEnabled = True
        Me.rqOffice.IntegralHeight = False
        Me.rqOffice.Location = New System.Drawing.Point(914, 9)
        Me.rqOffice.Name = "rqOffice"
        Me.rqOffice.Size = New System.Drawing.Size(222, 24)
        Me.rqOffice.TabIndex = 6
        '
        'rqOfficer
        '
        Me.rqOfficer.FormattingEnabled = True
        Me.rqOfficer.Location = New System.Drawing.Point(582, 12)
        Me.rqOfficer.Name = "rqOfficer"
        Me.rqOfficer.Size = New System.Drawing.Size(162, 24)
        Me.rqOfficer.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(849, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Office:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(408, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Requesition Officer:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Request ID:"
        '
        'requestNumber
        '
        Me.requestNumber.AutoSize = True
        Me.requestNumber.BackColor = System.Drawing.Color.SlateGray
        Me.requestNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.requestNumber.ForeColor = System.Drawing.Color.LawnGreen
        Me.requestNumber.Location = New System.Drawing.Point(192, 9)
        Me.requestNumber.Name = "requestNumber"
        Me.requestNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.requestNumber.Size = New System.Drawing.Size(60, 29)
        Me.requestNumber.TabIndex = 0
        Me.requestNumber.Text = "RQ-"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.estimBud)
        Me.Panel2.Controls.Add(Me.sourceOfFundBox)
        Me.Panel2.Controls.Add(Me.papBox)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.estimCost)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.cbModProc)
        Me.Panel2.Controls.Add(Me.cbDepCode)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.purposeBox)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.itemDescriptionBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1262, 164)
        Me.Panel2.TabIndex = 1
        '
        'estimBud
        '
        Me.estimBud.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estimBud.Location = New System.Drawing.Point(456, 122)
        Me.estimBud.Name = "estimBud"
        Me.estimBud.Size = New System.Drawing.Size(299, 27)
        Me.estimBud.TabIndex = 27
        '
        'sourceOfFundBox
        '
        Me.sourceOfFundBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sourceOfFundBox.FormattingEnabled = True
        Me.sourceOfFundBox.Location = New System.Drawing.Point(799, 74)
        Me.sourceOfFundBox.Name = "sourceOfFundBox"
        Me.sourceOfFundBox.Size = New System.Drawing.Size(334, 28)
        Me.sourceOfFundBox.TabIndex = 26
        '
        'papBox
        '
        Me.papBox.FormattingEnabled = True
        Me.papBox.Location = New System.Drawing.Point(84, 74)
        Me.papBox.Name = "papBox"
        Me.papBox.Size = New System.Drawing.Size(333, 28)
        Me.papBox.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(452, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 20)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Estimated Budget"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(78, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 20)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Estimated Cost"
        '
        'estimCost
        '
        Me.estimCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.estimCost.Location = New System.Drawing.Point(84, 124)
        Me.estimCost.Name = "estimCost"
        Me.estimCost.Size = New System.Drawing.Size(336, 27)
        Me.estimCost.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(797, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Source of Fund"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(452, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 20)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Department Code"
        '
        'cbModProc
        '
        Me.cbModProc.FormattingEnabled = True
        Me.cbModProc.Location = New System.Drawing.Point(799, 22)
        Me.cbModProc.Name = "cbModProc"
        Me.cbModProc.Size = New System.Drawing.Size(334, 28)
        Me.cbModProc.TabIndex = 12
        '
        'cbDepCode
        '
        Me.cbDepCode.FormattingEnabled = True
        Me.cbDepCode.Location = New System.Drawing.Point(456, 72)
        Me.cbDepCode.Name = "cbDepCode"
        Me.cbDepCode.Size = New System.Drawing.Size(299, 28)
        Me.cbDepCode.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(798, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 20)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Source of Fund"
        '
        'purposeBox
        '
        Me.purposeBox.FormattingEnabled = True
        Me.purposeBox.Location = New System.Drawing.Point(455, 22)
        Me.purposeBox.Name = "purposeBox"
        Me.purposeBox.Size = New System.Drawing.Size(299, 28)
        Me.purposeBox.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(85, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "APP Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(796, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Mode of Procurement"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(452, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Purpose"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Item Description"
        '
        'itemDescriptionBox
        '
        Me.itemDescriptionBox.Location = New System.Drawing.Point(85, 25)
        Me.itemDescriptionBox.Name = "itemDescriptionBox"
        Me.itemDescriptionBox.Size = New System.Drawing.Size(333, 27)
        Me.itemDescriptionBox.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSlateGray
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.totalPriceBox)
        Me.Panel3.Controls.Add(Me.itemPriceBox)
        Me.Panel3.Controls.Add(Me.quantityBox)
        Me.Panel3.Controls.Add(Me.unit_of_measureBox)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 221)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1262, 158)
        Me.Panel3.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(83, 135)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(130, 20)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Detailed History"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SlateGray
        Me.Button1.BackgroundImage = Global.loginformVB.My.Resources.Resources.plus
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1063, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(58, 61)
        Me.Button1.TabIndex = 29
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.checkoutTXTBOX)
        Me.Panel4.Location = New System.Drawing.Point(415, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(618, 122)
        Me.Panel4.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(4, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Last Request:"
        '
        'checkoutTXTBOX
        '
        Me.checkoutTXTBOX.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkoutTXTBOX.Location = New System.Drawing.Point(5, 25)
        Me.checkoutTXTBOX.Multiline = True
        Me.checkoutTXTBOX.Name = "checkoutTXTBOX"
        Me.checkoutTXTBOX.ReadOnly = True
        Me.checkoutTXTBOX.Size = New System.Drawing.Size(594, 90)
        Me.checkoutTXTBOX.TabIndex = 0
        '
        'totalPriceBox
        '
        Me.totalPriceBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPriceBox.ForeColor = System.Drawing.Color.Red
        Me.totalPriceBox.Location = New System.Drawing.Point(232, 98)
        Me.totalPriceBox.Name = "totalPriceBox"
        Me.totalPriceBox.ReadOnly = True
        Me.totalPriceBox.Size = New System.Drawing.Size(174, 27)
        Me.totalPriceBox.TabIndex = 27
        '
        'itemPriceBox
        '
        Me.itemPriceBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemPriceBox.Location = New System.Drawing.Point(232, 64)
        Me.itemPriceBox.Name = "itemPriceBox"
        Me.itemPriceBox.Size = New System.Drawing.Size(174, 27)
        Me.itemPriceBox.TabIndex = 26
        '
        'quantityBox
        '
        Me.quantityBox.Location = New System.Drawing.Point(232, 36)
        Me.quantityBox.Name = "quantityBox"
        Me.quantityBox.Size = New System.Drawing.Size(174, 22)
        Me.quantityBox.TabIndex = 25
        '
        'unit_of_measureBox
        '
        Me.unit_of_measureBox.FormattingEnabled = True
        Me.unit_of_measureBox.Items.AddRange(New Object() {"unit", "piece", "box", "rim"})
        Me.unit_of_measureBox.Location = New System.Drawing.Point(232, 6)
        Me.unit_of_measureBox.Name = "unit_of_measureBox"
        Me.unit_of_measureBox.Size = New System.Drawing.Size(174, 24)
        Me.unit_of_measureBox.TabIndex = 25
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label19.Location = New System.Drawing.Point(84, 98)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(105, 25)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Total Price"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(86, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 20)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Item Price"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(86, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 20)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Quantity"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(86, 6)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 20)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Unit of Measure"
        '
        'rFormTable
        '
        Me.rFormTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.rFormTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.rFormTable.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.rFormTable.Location = New System.Drawing.Point(0, 379)
        Me.rFormTable.Name = "rFormTable"
        Me.rFormTable.RowHeadersWidth = 51
        Me.rFormTable.RowTemplate.Height = 24
        Me.rFormTable.Size = New System.Drawing.Size(1262, 217)
        Me.rFormTable.TabIndex = 3
        '
        'requestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 596)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rFormTable)
        Me.Name = "requestForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.rFormTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents requestNumber As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents itemDescriptionBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents purposeBox As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbDepCode As ComboBox
    Friend WithEvents cbModProc As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents totalPriceBox As TextBox
    Friend WithEvents itemPriceBox As TextBox
    Friend WithEvents quantityBox As TextBox
    Friend WithEvents unit_of_measureBox As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents rFormTable As DataGridView
    Friend WithEvents papBox As ComboBox
    Friend WithEvents checkoutTXTBOX As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents sourceOfFundBox As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents rqOffice As ComboBox
    Friend WithEvents rqOfficer As ComboBox
    Friend WithEvents estimBud As TextBox
    Friend WithEvents estimCost As TextBox
End Class
