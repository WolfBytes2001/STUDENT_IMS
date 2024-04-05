Public Class MainDashboard
    Private Sub AccordionControlElement1_Click(sender As Object, e As EventArgs) Handles AccordionControlElement1.Click

    End Sub

    Private Sub AccordionControlElement4_Click(sender As Object, e As EventArgs) Handles AccordionControlElement4.Click

        Dim requestForm As New requestForm()
        requestForm.TopLevel = False
        requestForm.Dock = DockStyle.Fill
        DashboardContainer.Controls.Clear()
        DashboardContainer.Controls.Add(requestForm)
        requestForm.Show()

    End Sub

    Private Sub AccordionControlElement5_Click(sender As Object, e As EventArgs) Handles AccordionControlElement5.Click
        approvalOfficerLogin()

    End Sub

    Sub approvalOfficerLogin()
        Dim login As New logApprovalOfficer
        login.Show()
    End Sub

    Private Sub AccordionControlElement6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccordionControlElement6_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccordionControlElement2_Click(sender As Object, e As EventArgs) Handles AccordionControlElement2.Click

    End Sub

    Private Sub BarButtonItem1_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Me.Close()
    End Sub

    Private Sub AccordionControlElement6_Click_2(sender As Object, e As EventArgs) Handles AccordionControlElement6.Click
        Dim list As New approveListForPO
        list.Show()
        'Dim purchaseOrder As New Purchase_orderForm()
        'purchaseOrder.TopLevel = False
        'DashboardContainer.Controls.Clear()
        'DashboardContainer.Controls.Add(purchaseOrder)
        'purchaseOrder.Dock = DockStyle.Fill
        'purchaseOrder.Show()
    End Sub

    Private Sub AccordionControlElement8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub AccordionControlElement8_Click_1(sender As Object, e As EventArgs) Handles AccordionControlElement8.Click
        Dim order_details As New order_details()
        order_details.TopLevel = False
        order_details.Dock = DockStyle.Fill
        DashboardContainer.Controls.Clear()
        DashboardContainer.Controls.Add(order_details)
        order_details.Show()
    End Sub

    Private Sub AccordionControlElement9_Click(sender As Object, e As EventArgs) Handles AccordionControlElement9.Click
        Dim itemRecieved As New itemRecievedForm()
        'itemRecieved.TopLevel = False
        'itemRecieved.Dock = DockStyle.Fill
        'DashboardContainer.Controls.Clear()
        'DashboardContainer.Controls.Add(itemRecieved)
        itemRecieved.Show()
    End Sub

    Private Sub AccordionControlElement10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccordionControlElement10_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub AccordionControlElement13_Click(sender As Object, e As EventArgs) Handles AccordionControlElement13.Click
        Dim addAdmin As New addAdmin
        addAdmin.Show()
    End Sub
End Class
