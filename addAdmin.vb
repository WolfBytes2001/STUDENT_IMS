Imports System.Text
Imports MySql.Data.MySqlClient

Public Class addAdmin
    Dim database As New Database()

    'Private Sub comboBoxLoadItems(tablename As String, comboName As ComboBox, columnName As String)
    '    If Connect() Then
    '        Try

    '            Dim query As String = $"SELECT * FROM {tablename}"

    '            Dim dataTable As New DataTable()

    '            Using cmd As New MySqlCommand(query, DB.con)
    '                Dim adapter As New MySqlDataAdapter(cmd)
    '                adapter.Fill(dataTable)
    '            End Using

    '            comboName.Items.Clear()

    '            For Each row As DataRow In dataTable.Rows
    '                comboName.Items.Add(row($"{columnName}"))
    '            Next

    '        Catch ex As Exception
    '            MessageBox.Show("Error loading data: " & ex.Message)
    '        End Try
    '    End If
    'End Sub



    Private Sub ComboBox1_Click(sender As Object, e As EventArgs) Handles desigBox.Click
        comboBoxLoadItems("designation", desigBox, "designation")
    End Sub

    Private Sub ComboBox1_Click_1(sender As Object, e As EventArgs) Handles depBox.Click
        comboBoxLoadItems("department", depBox, "department")
    End Sub

    Private Sub ComboBox2_Click(sender As Object, e As EventArgs) Handles statusBox.Click
        comboBoxLoadItems("employment_status", statusBox, "remarks")
    End Sub

    Private Sub ComboBox3_Click(sender As Object, e As EventArgs) Handles remarksBox.Click
        comboBoxLoadItems("employment_remarks", remarksBox, "remarks")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If database.Connect Then
            ' Inputs
            Dim id As String = emploIdTB.Text
            Dim fname As String = fullnameTB.Text
            Dim email As String = emailTB.Text
            Dim username As String = usernameTB.Text
            Dim password As String = pwTB.Text
            Dim desig As String = desigBox.Text
            Dim dep As String = depBox.Text
            Dim status As String = statusBox.Text
            Dim remarks As String = remarksBox.Text


            If String.IsNullOrEmpty(id) OrElse
               String.IsNullOrEmpty(fname) OrElse
               String.IsNullOrEmpty(email) OrElse
               String.IsNullOrEmpty(username) OrElse
               String.IsNullOrEmpty(password) OrElse
               String.IsNullOrEmpty(desig) OrElse
               String.IsNullOrEmpty(dep) OrElse
               String.IsNullOrEmpty(status) OrElse
               String.IsNullOrEmpty(remarks) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return ' Do not execute the query


            Else
                Try
                    Dim query = $"INSERT INTO employees(employee_id, fullname, username, password, email, designation, department, status, remarks) VALUES('{id}', '{fname}', '{username}', '{password}', '{email}', '{desig}', '{dep}', '{status}', '{remarks}')"

                    Using cmd As New MySqlCommand(query, database.con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Employee saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearForm()
                Catch ex As Exception
                    MessageBox.Show("Error executing the query", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If


        End If
    End Sub

    Private Function clearForm()

        emploIdTB.Text = ""
        fullnameTB.Text = ""
        emailTB.Text = ""
        usernameTB.Text = ""
        pwTB.Text = ""
        desigBox.Text = ""
        depBox.Text = ""
        statusBox.Text = ""
        remarksBox.Text = ""

        Return ""

    End Function




    Private Sub genButton_Click(sender As Object, e As EventArgs) Handles genButton.Click
        pwTB.Clear()
        pwTB.Text = GenerateRandomPassword()
    End Sub

    Private Sub addEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pwTB.Text = GenerateRandomPassword()
    End Sub
End Class