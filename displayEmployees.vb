Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common

Public Class emploTable
    Public employeeId As String
    Public Sub displayEmployees_Load()
        Dim db = New Database

        If db.Connect() Then
            Try
                Dim query As String = "SELECT * FROM employees"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, db.con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                tableEmplo.DataSource = dataTable
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub searchTB_TextChanged(sender As Object, e As EventArgs) Handles searchTB.TextChanged
        Dim keyword As String = searchTB.Text.Trim()

        If Not String.IsNullOrEmpty(keyword) Then
            If Connect() Then
                Try
                    Dim query As String = $"SELECT * FROM employees WHERE employee_id LIKE '%{keyword}%' OR fullname LIKE '%{keyword}%'"

                    Dim dataTable As New DataTable()

                    Using cmd As New MySqlCommand(query, DB.con)

                        Dim adapter As New MySqlDataAdapter(cmd)


                        adapter.Fill(dataTable)

                        tableEmplo.DataSource = dataTable

                    End Using

                Catch ex As Exception

                    MessageBox.Show("Error searching data: " & ex.Message)
                End Try
            End If

        End If
    End Sub

    Private Sub searchTB_Click(sender As Object, e As EventArgs) Handles searchTB.Click
        searchTB.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        tableEmplo.Controls.Clear()

        Dim addEmplo = New addAdmin
        addEmplo.TopLevel = False

        tableEmplo.Controls.Add(addEmplo)
        addEmplo.Show()

        Dim db = New Database()

        If db.Connect Then
            Try
                Dim query = "INSERT INTO "
            Catch ex As Exception

            End Try
        End If
    End Sub

    'Add emplo form
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Dim addEmp As New addAdmin()
        addEmp.TopLevel = False

        ' Dispose of the existing form, if any
        If emdash.dashboardPanel.Controls.Count > 0 Then
            Dim existingForm = TryCast(emdash.dashboardPanel.Controls(0), Form)
            If existingForm IsNot Nothing Then
                existingForm.Dispose()
            End If
        End If

        emdash.dashboardPanel.Controls.Clear()
        emdash.dashboardPanel.Controls.Add(addEmp)
        addEmp.Show()



    End Sub

    'delete employee function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim employeeIdColumnName As String = "employee_id"

        If tableEmplo.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = tableEmplo.SelectedCells(0).RowIndex
            employeeId = tableEmplo.Rows(selectedRowIndex).Cells(employeeIdColumnName).Value?.ToString().Trim()

            If Not String.IsNullOrEmpty(employeeId) Then
                Dim result As DialogResult = MessageBox.Show($"Proceed to delete employee ID:{employeeId}", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

                If result = DialogResult.OK Then
                    If Connect() Then
                        Try
                            Dim query As String = $"DELETE FROM employees WHERE employees.employee_id = '{employeeId}' "

                            Using cmd As New MySqlCommand(query, con)
                                cmd.ExecuteNonQuery()
                            End Using

                            displayEmployees_Load()

                        Catch ex As Exception
                            MessageBox.Show("Deletion failed" & ex.Message)
                        End Try
                    End If


                    MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Delete operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("EMPTY")
            End If
        Else
            MessageBox.Show("Select a row")
        End If
    End Sub


    Private Sub refreshDashboard()

        emdash.dashboardPanel.Controls.Clear()
        emdash.dashboardPanel.Controls.Add(Me)
    End Sub

    Private Sub emploTable_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim loginForm As New login()

    End Sub

    'update
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim employeeIdColumnName As String = "employee_id"

        If tableEmplo.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = tableEmplo.SelectedCells(0).RowIndex
            employeeId = tableEmplo.Rows(selectedRowIndex).Cells(employeeIdColumnName).Value?.ToString().Trim()

            If Not String.IsNullOrEmpty(employeeId) Then
                Dim result As DialogResult = MessageBox.Show($"Proceed to update employee ID:{employeeId}", "UPDATE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

                If result = DialogResult.OK Then
                    If Connect() Then
                        Try

                            loadUpdateEmployeeForm()

                        Catch ex As Exception
                            MessageBox.Show("Update failed" & ex.Message)
                        End Try
                    End If


                Else
                    MessageBox.Show("Update operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("EMPTY")
            End If
        Else
            MessageBox.Show("Select a row")
        End If
    End Sub



    Private Sub loadUpdateEmployeeForm()
        Dim updateF As New update()
        updateF.TopLevel = False
        If emdash.dashboardPanel.Controls.Count > 0 Then
            Dim existingForm = TryCast(emdash.dashboardPanel.Controls(0), Form)
            If existingForm IsNot Nothing Then
                existingForm.Dispose()
            End If
        End If

        emdash.dashboardPanel.Controls.Add(updateF)
        updateF.Show()
        updateF.idTBUpdate.Text = employeeId

        If Connect() Then
            Try
                Dim sql = $"SELECT * FROM employees WHERE employee_id = '{employeeId}'"

                Using cmd As New MySqlCommand(sql, con)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            updateF.fnameTBUpdate.Text = reader("fullname").ToString()
                            updateF.emailTxtBoxUpdate.Text = reader("email").ToString()
                            updateF.usnameTxtBoxUpdate.Text = reader("username").ToString()
                            updateF.pwTBUpdate.Text = reader("password").ToString()
                            updateF.desigBoxUpdate.Text = reader("designation").ToString()
                            updateF.depBoxUpdate.Text = reader("department").ToString()
                            updateF.statusBoxUpdate.Text = reader("status").ToString()
                            updateF.remarksBoxUpdate.Text = reader("remarks").ToString()

                        End While

                    Else
                        'MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                    End If

                    reader.Close()

                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub


End Class