Imports MySql.Data.MySqlClient

Public Class update
    Dim empId As String = emploTable.employeeId
    Dim fullname As String
    Dim email As String
    Dim username As String
    Dim password As String
    Dim designation As String
    Dim department As String
    Dim status As String
    Dim remark As String


    Private Sub genButton_Click(sender As Object, e As EventArgs) Handles genButton.Click
        pwTBUpdate.Clear()
        pwTBUpdate.Text = GenerateRandomPassword()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles updateButton.Click
        If Connect() Then
            Try
                Dim query As String = $"UPDATE employees SET fullname = '{fnameTBUpdate.Text}', username = '{usnameTxtBoxUpdate.Text}', email = '{emailTxtBoxUpdate.Text.Trim()}', password = '{pwTBUpdate.Text()}', designation = '{desigBoxUpdate.Text.Trim()}', department = '{depBoxUpdate.Text.Trim()}', status = '{statusBoxUpdate.Text.Trim()}', remarks = '{remarksBoxUpdate.Text.Trim()}' WHERE employee_id = '{idTBUpdate.Text.Trim()}'"

                Using cmd As New MySqlCommand(query, con)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Update failed. No rows were affected.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating employee: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub desigBoxUpdate_Click(sender As Object, e As EventArgs) Handles desigBoxUpdate.Click
        comboBoxLoadItems("designation", desigBoxUpdate, "designation")
    End Sub

    Private Sub depBoxUpdate_Click(sender As Object, e As EventArgs) Handles depBoxUpdate.Click
        comboBoxLoadItems("department", depBoxUpdate, "department")
    End Sub

    Private Sub statusBoxUpdate_Click(sender As Object, e As EventArgs) Handles statusBoxUpdate.Click
        comboBoxLoadItems("employment_status", statusBoxUpdate, "remarks")
    End Sub

    Private Sub remarksBoxUpdate_Click(sender As Object, e As EventArgs) Handles remarksBoxUpdate.Click
        comboBoxLoadItems("employment_remarks", remarksBoxUpdate, "remarks")
    End Sub
End Class