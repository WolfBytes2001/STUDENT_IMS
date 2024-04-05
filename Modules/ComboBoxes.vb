Imports DevExpress.XtraEditors
Imports MySql.Data.MySqlClient

Module ComboBoxes

    'Sub checkedComboBoxLoad(tablename As String, checkCombo As CheckedComboBoxEdit, columnName As String)
    '    If Connect() Then
    '        Try

    '            Dim query As String = $"SELECT * FROM {tablename}"

    '            Dim dataTable As New DataTable()

    '            Using cmd As New MySqlCommand(query, con)
    '                Dim adapter As New MySqlDataAdapter(cmd)
    '                adapter.Fill(dataTable)
    '            End Using

    '            checkCombo.Items.Clear()

    '            For Each row As DataRow In dataTable.Rows
    '                comboName.Items.Add(row($"{columnName}"))
    '            Next

    '        Catch ex As Exception
    '            MessageBox.Show("Error loading data: " & ex.Message)
    '        End Try
    '    End If
    'End Sub
End Module
