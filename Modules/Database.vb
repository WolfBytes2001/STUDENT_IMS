Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Relational

Public Class Database
    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = "root"
    Private database As String = "ems"
    Public con As MySqlConnection


    Public Function Connect() As Boolean
        Try
            ' Connection string
            Dim connectionString As String = $"Server={server};Database={database};User ID={username};Password={password};"

            ' Create a new MySqlConnection instance
            con = New MySqlConnection(connectionString)

            ' Open the connection
            con.Open()

            ' Return true indicating successful connection
            Return True
        Catch ex As Exception
            ' Handle the exception (you might want to log or display the error)
            MessageBox.Show("Error connecting to the database: " & ex.Message)
            Return False
        End Try
    End Function


    'Sub loadTable(table As Table)
    '    If Connect() Then
    '        Try
    '            Dim query As String = "SELECT * FROM request_form"
    '            Dim dataTable As New DataTable()

    '            Using cmd As New MySqlCommand(query, DB.con)

    '                Dim adapter As New MySqlDataAdapter(cmd)
    '                adapter.Fill(dataTable)
    '            End Using
    '            rFormTable.DataSource = dataTable
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

End Class
