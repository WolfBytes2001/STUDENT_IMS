<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class search
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
        Me.searchTB = New System.Windows.Forms.TextBox()
        Me.resultsTable = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.resultsTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchTB
        '
        Me.searchTB.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.searchTB.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchTB.Location = New System.Drawing.Point(88, 12)
        Me.searchTB.Name = "searchTB"
        Me.searchTB.Size = New System.Drawing.Size(632, 31)
        Me.searchTB.TabIndex = 0
        Me.searchTB.Text = "Employee ID or Fullname"
        Me.searchTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'resultsTable
        '
        Me.resultsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.resultsTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.resultsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.resultsTable.Location = New System.Drawing.Point(88, 101)
        Me.resultsTable.Name = "resultsTable"
        Me.resultsTable.Size = New System.Drawing.Size(632, 302)
        Me.resultsTable.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Results"
        '
        'search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.resultsTable)
        Me.Controls.Add(Me.searchTB)
        Me.Name = "search"
        CType(Me.resultsTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents searchTB As TextBox
    Friend WithEvents resultsTable As DataGridView
    Friend WithEvents Label1 As Label
End Class
