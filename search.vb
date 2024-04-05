Imports MySql.Data.MySqlClient

Public Class search
    Public selectedEmployeeId As String = " "
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles searchTB.Click
        searchTB.Text = ""

    End Sub

    Private Sub searchTB_Enter(sender As Object, e As EventArgs) Handles searchTB.Enter
        'Dim keyword As String = searchTB.Text.Trim()

        'If Not String.IsNullOrEmpty(keyword) Then
        '    If Connect() Then
        '        Try
        '            Dim query As String = $"SELECT * FROM employees WHERE employee_id LIKE '%{keyword}%' OR fullname LIKE '%{keyword}%'"

        '            Dim dataTable As New DataTable()

        '            Using cmd As New MySqlCommand(query, DB.con)
        '                ' Create a MySqlDataAdapter to fill the DataTable
        '                Dim adapter As New MySqlDataAdapter(cmd)

        '                ' Fill the DataTable with the data from the database
        '                adapter.Fill(dataTable)

        '                resultsTable.DataSource = dataTable

        '            End Using

        '        Catch ex As Exception
        '            ' Handle the exception (you might want to log or display the error)
        '            MessageBox.Show("Error searching data: " & ex.Message)
        '        End Try
        '    End If
        'Else
        '    MessageBox.Show("Please enter a search keyword.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If


    End Sub



    Private Sub searchTB_TextChanged(sender As Object, e As EventArgs) Handles searchTB.TextChanged
        Dim keyword As String = searchTB.Text.Trim()

        If Not String.IsNullOrEmpty(keyword) Then
            If Connect() Then
                Try
                    Dim query As String = $"SELECT * FROM employees WHERE employee_id LIKE '%{keyword}%' OR fullname LIKE '%{keyword}%'"

                    Dim dataTable As New DataTable()

                    Using cmd As New MySqlCommand(query, DB.con)
                        ' Create a MySqlDataAdapter to fill the DataTable
                        Dim adapter As New MySqlDataAdapter(cmd)

                        ' Fill the DataTable with the data from the database
                        adapter.Fill(dataTable)

                        resultsTable.DataSource = dataTable

                    End Using

                Catch ex As Exception
                    ' Handle the exception (you might want to log or display the error)
                    MessageBox.Show("Error searching data: " & ex.Message)
                End Try
            End If
            'Else
            '    MessageBox.Show("Please enter a search keyword.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub resultsTable_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles resultsTable.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            ' Ensure that the column name is correct and matches the actual column name in your DataGridView
            Dim columnName As String = "id"

            ' Check if the column exists in the DataGridView
            If resultsTable.Columns.Contains(columnName) Then
                ' Get the selected employee ID from the specified column
                selectedEmployeeId = resultsTable.Rows(e.RowIndex).Cells(columnName).Value.ToString()

                MessageBox.Show(selectedEmployeeId)
            Else
                MessageBox.Show($"Column '{columnName}' not found in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub



End Class