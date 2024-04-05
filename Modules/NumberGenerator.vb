Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.XDevAPI.Common

Module NumberGenerator



    Function GenerateRequestNumber() As String
        ' Get current date
        Dim currentDate As Date = Date.Now
        ' Format the date as Day-Month
        Dim formattedDate As String = currentDate.ToString("dd-MM")

        ' Generate a unique order number (you can replace this logic with your own)
        Dim orderNumber As Integer = GetUniqueOrderNumber()

        ' Combine the components to create the PR number
        Dim requestID As String = $"PR-{formattedDate}-{orderNumber}"
        Return requestID
    End Function

    Function GetUniqueOrderNumber() As Integer
        ' Replace this logic with your own method to generate a unique order number
        ' For example, you can use a database sequence, random number generator, etc.
        Return New Random().Next(1000, 9999)
    End Function

    Function GeneratePOCode() As String
        ' Get current date
        Dim currentDate As Date = Date.Now
        ' Format the date as Day-Month
        Dim formattedDate As String = currentDate.ToString("dd-MM")

        ' Generate a unique order number (you can replace this logic with your own)
        Dim orderNumber As Integer = GetUniqueOrderNumber()

        ' Combine the components to create the PR number
        Dim requestID As String = $"PO-{formattedDate}-{orderNumber}"
        Return requestID
    End Function

    Function GenerateVendorID() As String
        ' Get current date
        Dim currentDate As Date = Date.Now
        ' Format the date as Day-Month
        Dim formattedDate As String = currentDate.ToString("dd-MM")

        ' Generate a unique order number (you can replace this logic with your own)
        Dim orderNumber As Integer = GetUniqueOrderNumber()

        ' Combine the components to create the PR number
        Dim requestID As String = $"V-{formattedDate}-{orderNumber}"
        Return requestID
    End Function

    Function generateINID() As String
        ' Get current date
        Dim currentDate As Date = Date.Now
        ' Format the date as Day-Month
        Dim formattedDate As String = currentDate.ToString("dd-MM")

        ' Generate a unique order number (you can replace this logic with your own)
        Dim orderNumber As Integer = GetUniqueOrderNumber()

        ' Combine the components to create the PR number
        Dim requestID As String = $"V-{formattedDate}-{orderNumber}"
        Return requestID
    End Function

    Function GenerateSPORTSInventoryID() As String
        Dim now As DateTime = DateTime.Now
        Dim monthDay As String = now.ToString("MMdd")

        Dim seriesNumber As String = GetNextSeriesNumber().ToString().PadLeft(4, "0"c)

        Return $"SP-{monthDay}-{seriesNumber}"
    End Function



    Private Function GetNextSeriesNumber() As Integer
        If Connect() Then
            Try
                Dim query As String = "SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'Sports' AND table_schema = DATABASE();"
                Using cmd As New MySqlCommand(query, con)
                    Dim result As Object = cmd.ExecuteScalar()
                    If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                        Return Convert.ToInt32(result)
                    Else
                        Return -1 ' Error occurred or no data found
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching series number: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
        Return -1 ' Connection to database failed
    End Function

End Module
