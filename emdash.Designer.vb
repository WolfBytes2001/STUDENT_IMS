<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class emdash
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.displayNameBox = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dashboardPanel = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.AccountsButton = New System.Windows.Forms.Button()
        Me.timeBox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.timeBox)
        Me.Panel1.Controls.Add(Me.displayNameBox)
        Me.Panel1.Controls.Add(Me.AccountsButton)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(136, 450)
        Me.Panel1.TabIndex = 1
        '
        'displayNameBox
        '
        Me.displayNameBox.BackColor = System.Drawing.Color.SteelBlue
        Me.displayNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.displayNameBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayNameBox.ForeColor = System.Drawing.Color.White
        Me.displayNameBox.Location = New System.Drawing.Point(0, 88)
        Me.displayNameBox.Name = "displayNameBox"
        Me.displayNameBox.Size = New System.Drawing.Size(136, 15)
        Me.displayNameBox.TabIndex = 6
        Me.displayNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'dashboardPanel
        '
        Me.dashboardPanel.AutoSize = True
        Me.dashboardPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.dashboardPanel.Location = New System.Drawing.Point(142, 5)
        Me.dashboardPanel.Name = "dashboardPanel"
        Me.dashboardPanel.Size = New System.Drawing.Size(559, 444)
        Me.dashboardPanel.TabIndex = 2
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button5.BackgroundImage = Global.loginformVB.My.Resources.Resources.arrow
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(749, 5)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 28)
        Me.Button5.TabIndex = 7
        Me.Button5.UseVisualStyleBackColor = False
        '
        'AccountsButton
        '
        Me.AccountsButton.BackColor = System.Drawing.Color.White
        Me.AccountsButton.BackgroundImage = Global.loginformVB.My.Resources.Resources.staff
        Me.AccountsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.AccountsButton.Location = New System.Drawing.Point(0, 0)
        Me.AccountsButton.Name = "AccountsButton"
        Me.AccountsButton.Size = New System.Drawing.Size(136, 91)
        Me.AccountsButton.TabIndex = 3
        Me.AccountsButton.UseVisualStyleBackColor = False
        '
        'timeBox
        '
        Me.timeBox.BackColor = System.Drawing.Color.SteelBlue
        Me.timeBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.timeBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeBox.ForeColor = System.Drawing.SystemColors.Window
        Me.timeBox.Location = New System.Drawing.Point(0, 435)
        Me.timeBox.Name = "timeBox"
        Me.timeBox.Size = New System.Drawing.Size(136, 15)
        Me.timeBox.TabIndex = 7
        Me.timeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.dashboardPanel)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "dashboard"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AccountsButton As Button
    Friend WithEvents dashboardPanel As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents displayNameBox As TextBox
    Friend WithEvents timeBox As TextBox
End Class
