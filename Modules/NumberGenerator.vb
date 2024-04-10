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

        Return $"SPORTS-{monthDay}-{seriesNumber}"
    End Function

    Function GenerateSuppliesInventoryID() As String
        Dim now As DateTime = DateTime.Now
        Dim monthDay As String = now.ToString("MMdd")

        Dim seriesNumber As String = GetNextSeriesNumberSupplies().ToString().PadLeft(4, "0"c)

        Return $"SUP-{monthDay}-{seriesNumber}"
    End Function

    Private Function GetNextSeriesNumberSupplies() As Integer
        If Connect() Then
            Try
                Dim query As String = "SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'Supplies' AND table_schema = DATABASE();"
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


    Function GenerateTechInventoryID() As String
        Dim now As DateTime = DateTime.Now
        Dim monthDay As String = now.ToString("MMdd")

        Dim seriesNumber As String = GetNextSeriesNumberTech().ToString().PadLeft(4, "0"c)

        Return $"TECH-{monthDay}-{seriesNumber}"
    End Function

    Private Function GetNextSeriesNumberTech() As Integer
        If Connect() Then
            Try
                Dim query As String = "SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'Technology' AND table_schema = DATABASE();"
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


    Function GenerateFurnitureInventoryID() As String
        Dim now As DateTime = DateTime.Now
        Dim monthDay As String = now.ToString("MMdd")

        Dim seriesNumber As String = GetNextSeriesNumberFurniture().ToString().PadLeft(4, "0"c)

        Return $"FUR-{monthDay}-{seriesNumber}"
    End Function

    Private Function GetNextSeriesNumberFurniture() As Integer
        If Connect() Then
            Try
                Dim query As String = "SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'furniture' AND table_schema = DATABASE();"
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

    Function GenerateEquipmentInventoryID() As String
        Dim now As DateTime = DateTime.Now
        Dim monthDay As String = now.ToString("MMdd")

        Dim seriesNumber As String = GetNextSeriesNumberEquipment().ToString().PadLeft(4, "0"c)

        Return $"EQ-{monthDay}-{seriesNumber}"
    End Function

    Private Function GetNextSeriesNumberEquipment() As Integer
        If Connect() Then
            Try
                Dim query As String = "SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'equipment' AND table_schema = DATABASE();"
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


    Function GenerateToolsInventoryID() As String
        Dim now As DateTime = DateTime.Now
        Dim monthDay As String = now.ToString("MMdd")

        Dim seriesNumber As String = GetNextSeriesNumberTools().ToString().PadLeft(4, "0"c)

        Return $"TLS-{monthDay}-{seriesNumber}"
    End Function

    Private Function GetNextSeriesNumberTools() As Integer
        If Connect() Then
            Try
                Dim query As String = "SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'tools' AND table_schema = DATABASE();"
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

    Function GenerateInstrumentInventoryID() As String
        Dim now As DateTime = DateTime.Now
        Dim monthDay As String = now.ToString("MMdd")

        Dim seriesNumber As String = GetNextSeriesNumberInstument().ToString().PadLeft(4, "0"c)

        Return $"INS-{monthDay}-{seriesNumber}"
    End Function

    Private Function GetNextSeriesNumberInstument() As Integer
        If Connect() Then
            Try
                Dim query As String = "SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'instrument' AND table_schema = DATABASE();"
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

    Function GenerateVehiclesInventoryID() As String
        Dim now As DateTime = DateTime.Now
        Dim monthDay As String = now.ToString("MMdd")

        Dim seriesNumber As String = GetNextSeriesNumberVehicles().ToString().PadLeft(4, "0"c)

        Return $"VHCL-{monthDay}-{seriesNumber}"
    End Function

    Private Function GetNextSeriesNumberVehicles() As Integer
        If Connect() Then
            Try
                Dim query As String = "SELECT AUTO_INCREMENT FROM information_schema.tables WHERE table_name = 'vehicle' AND table_schema = DATABASE();"
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
