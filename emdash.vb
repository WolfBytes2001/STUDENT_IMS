Public Class emdash
    Public searchform = New search


    Private Sub displayEmplo()

        dashboardPanel.Controls.Clear()

        Dim displayEmpo = New emploTable
        displayEmpo.TopLevel = False


        dashboardPanel.Controls.Add(displayEmpo)

        displayEmpo.displayEmployees_Load()

        displayEmpo.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles AccountsButton.Click
        displayEmplo()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        displayEmplo()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        dashboardPanel.Controls.Clear()

        Dim addEmplo = New addAdmin
        addEmplo.TopLevel = False

        dashboardPanel.Controls.Add(addEmplo)
        addEmplo.Show()




    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        dashboardPanel.Controls.Clear()

        Dim searchForm = New search()
        searchForm.TopLevel = False

        dashboardPanel.Controls.Add(searchForm)
        searchForm.Show()
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        displayEmplo()
        displayNameBox.Text = login.userAccountDetails

        Timer1.Enabled = True
        Timer1.Interval = 1000

    End Sub

    Private Sub dashboard_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        login.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        timeBox.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub
End Class