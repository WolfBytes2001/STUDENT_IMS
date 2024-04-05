Imports MySql.Data.MySqlClient

Public Class login

    Public userAccountDetails = ""
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles lgButton.Click
        Dim db = New Database

        If db.Connect() Then
            Dim username As String = lgUsname.Text
            Dim pass As String = lgPass.Text

            Try
                Dim query As String = "SELECT * FROM employees WHERE username = @username AND `password` = @password"


                Using cmd As New MySqlCommand(query, db.con)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", pass)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()
                            userAccountDetails = reader("fullname").ToString()

                        End While

                        MessageBox.Show($"WELCOME {userAccountDetails} ", "Authentication Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Hide()

                        'create dashboard window
                        Dim dashboardMain = New emdash()
                        dashboard.Show()



                    Else
                        MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                    End If

                    reader.Close()

                End Using
            Catch ex As Exception
                MessageBox.Show("Error executing the query" & ex.Message)
            End Try
        End If



    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.Hide()

        'create reg form
        Dim register = New register()
        register.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        MessageBox.Show("Bye")
        Me.Close()

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
