Imports MySql.Data.MySqlClient

Public Class register
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim db = New Database()
        If db.Connect() Then ' Check if the connection was successful
            Dim username As String = regUsBox.Text
            Dim password As String = regPassBox.Text

            Try
                ' Build the SQL query with parameters to prevent SQL injection
                Dim query As String = "INSERT INTO login(username, `password`) VALUES(@username, @password)"

                ' Create a MySqlCommand with the SQL query and MySqlConnection
                Using cmd As New MySqlCommand(query, db.con)
                    ' Add parameters to the command
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    ' Execute the query
                    cmd.ExecuteNonQuery()

                    MessageBox.Show("Registration successful!")
                End Using
            Catch ex As Exception
                ' Handle the exception (you might want to log or display the error)
                MessageBox.Show("Error executing the query: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        login.Show()
    End Sub
End Class
