Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class logApprovalOfficer
    Public officerName As String
    Private Sub lgButton_Click(sender As Object, e As EventArgs) Handles lgButton.Click
        Dim username As String = usernameBox.Text.Trim()
        Dim password As String = passwordBox.Text.Trim()
        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM admin WHERE username = @username AND `password` = @password"
                Using cmd As New MySqlCommand(query, DB.con)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()
                            officerName = reader("fullname").ToString()

                        End While

                        MessageBox.Show($"WELCOME {officerName} ", "Authentication Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        loadForm()
                        Me.Close()




                    Else
                        MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                    End If

                    reader.Close()

                End Using
            Catch ex As Exception

            End Try
        End If

    End Sub

    Sub loadForm()
        Dim approval As New requestApproval()
        approval.TopLevel = False
        approval.Dock = DockStyle.Fill
        MainDashboard.DashboardContainer.Controls.Clear()
        MainDashboard.DashboardContainer.Controls.Add(approval)
        approval.Show()
        approval.textBoxForOfficer.Text = officerName
    End Sub

    Private Sub passwordBox_KeyDown(sender As Object, e As KeyEventArgs) Handles passwordBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim username As String = usernameBox.Text.Trim()
            Dim password As String = passwordBox.Text.Trim()

            If Connect() Then
                Try
                    Dim query As String = "SELECT * FROM admin WHERE username = @username AND `password` = @password"


                    Using cmd As New MySqlCommand(query, DB.con)
                        cmd.Parameters.AddWithValue("@username", username)
                        cmd.Parameters.AddWithValue("@password", password)

                        Dim reader As MySqlDataReader = cmd.ExecuteReader()

                        If reader.HasRows Then
                            While reader.Read()
                                officerName = reader("fullname").ToString()

                            End While

                            MessageBox.Show($"WELCOME {officerName} ", "Authentication Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information)


                            loadForm()
                            Me.Close()




                        Else
                            MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                        End If

                        reader.Close()

                    End Using
                Catch ex As Exception

                End Try
            End If
        End If

    End Sub

    'Private Sub lgButton_Enter(sender As Object, e As EventArgs) Handles lgButton.Enter

    'End Sub

    'Private Sub logApprovalOfficer_Enter(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub passwordBox_Enter(sender As Object, e As EventArgs) Handles passwordBox.Enter
    '    Dim username As String = usernameBox.Text.Trim()
    '    Dim password As String = passwordBox.Text.Trim()

    '    If Connect() Then
    '        Try
    '            Dim query As String = "SELECT * FROM employees WHERE username = @username AND `password` = @password"


    '            Using cmd As New MySqlCommand(query, DB.con)
    '                cmd.Parameters.AddWithValue("@username", username)
    '                cmd.Parameters.AddWithValue("@password", password)

    '                Dim reader As MySqlDataReader = cmd.ExecuteReader()

    '                If reader.HasRows Then
    '                    While reader.Read()
    '                        officerName = reader("fullname").ToString()

    '                    End While

    '                    MessageBox.Show($"WELCOME {officerName} ", "Authentication Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                    Me.Close()

    '                    loadForm()




    '                Else
    '                    MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)


    '                End If

    '                reader.Close()

    '            End Using
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub
End Class