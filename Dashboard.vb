Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins

Public Class Dashboard
    Public viewItems As New view_items
    Public addItems As New addItem
    Public po As New po_approve_list
    Private Sub BarToggleSwitchItem1_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarToggleSwitchItem1.CheckedChanged
        If BarToggleSwitchItem1.Checked Then
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Dark Style")
            BarToggleSwitchItem1.Caption = "Light Mode"
        Else
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
            BarToggleSwitchItem1.Caption = "Dark Mode"
        End If
    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Dim purchaseRequest As New request
        purchaseRequest.Dock = DockStyle.Fill
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(purchaseRequest)
        purchaseRequest.Show()
    End Sub

    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim login As New requestApprovalLogin
        login.Dock = DockStyle.Fill
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(login)
        login.Show()
    End Sub

    Private Sub BarButtonItem3_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick

        Dim po As New po_approve_list
        po.Dock = DockStyle.Fill
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(po)
        po.Show()
    End Sub

    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim status As New order_status
        status.Dock = DockStyle.Fill
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(status)

    End Sub

    Private Sub BarButtonItem5_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim received As New itemRecievedForm



        received.Show()
    End Sub

    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick

        addItems.Dock = DockStyle.Fill
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(addItems)

    End Sub

    Private Sub BarButtonItem7_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem7.ItemClick

        viewItems.Dock = DockStyle.Fill
        MainPanel.Controls.Clear()
        MainPanel.Controls.Add(viewItems)
    End Sub


    'Private Sub ApplyTheme(themeName As String)
    '    ' Unload all skins and skin elements previously loaded
    '    SkinManager.Default.UnregisterAll()

    '    ' Register DevExpress skins
    '    BonusSkins.Register()
    '    SkinManager.EnableFormSkins()
    '    UserLookAndFeel.Default.UseDefaultLookAndFeel = False

    '    ' Apply the specified theme
    '    UserLookAndFeel.Default.SkinName = themeName

    '    ' Update the appearance of DevExpress controls
    '    DevExpress.Utils.AppearanceObject.DefaultFont = New System.Drawing.Font("Tahoma", 8.25F)
    '    DevExpress.Utils.AppearanceObject.Default.ForeColor = System.Drawing.Color.FromArgb(30, 30, 30)
    '    DevExpress.Utils.AppearanceObject.Default.BackColor = System.Drawing.Color.FromArgb(247, 247, 247)
    '    DevExpress.Utils.AppearanceObject.Default.Options.UseFont = True
    '    DevExpress.Utils.AppearanceObject.Default.Options.UseForeColor = True
    '    DevExpress.Utils.AppearanceObject.Default.Options.UseBackColor = True

    '    ' Optionally, update the appearance of your Ribbon control
    '    UpdateRibbonAppearance()
    'End Sub

    'Private Sub UpdateRibbonAppearance()
    '    ' Assuming your Ribbon control is named "ribbonControlMain"
    '    ribbonControlMain.Refresh()
    'End Sub
End Class