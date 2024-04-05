﻿Imports MySql.Data.MySqlClient

Public Class order_status
    Private Sub order_status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSpecificOrderForm("On process", onprocess)
        loadSpecificOrderForm("Delivered", delivered)
        loadTable()
    End Sub

    Sub loadSpecificOrderForm(status As String, tableName As DataGridView)
        If Connect() Then
            Try
                Dim query As String = $"SELECT purchase_order_id, supplier_name, ship_via, product_brand,shipping_method,preferred_delivery_date, order_status  FROM po_form WHERE order_status = '{status}' ORDER BY po_form.generated_at DESC"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, DB.con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)

                    ' Assign the DataTable to the DataGridView DataSource
                    tableName.DataSource = dataTable

                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub
    Sub loadTable()
        If Connect() Then
            Try
                Dim query As String = $"SELECT purchase_order_id, supplier_name, ship_via, product_brand,shipping_method,preferred_delivery_date, order_status  FROM po_form ORDER BY po_form.generated_at DESC"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, DB.con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)

                    ' Assign the DataTable to the DataGridView DataSource
                    all.DataSource = dataTable

                    ' Loop through each row in the DataGridView to apply color coding
                    For Each row As DataGridViewRow In all.Rows
                        If row.Cells("order_status").Value IsNot Nothing Then
                            Dim status As String = row.Cells("order_status").Value.ToString()
                            Select Case status
                                Case "On process"
                                    row.DefaultCellStyle.BackColor = Color.Purple
                                    row.DefaultCellStyle.ForeColor = Color.White
                                Case "Delivered"
                                    row.DefaultCellStyle.BackColor = Color.Green
                                    row.DefaultCellStyle.ForeColor = Color.White
                                    ' Add more cases for other statuses as needed
                            End Select
                        End If
                    Next

                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Private Sub order_searchbox_TextChanged(sender As Object, e As EventArgs) Handles order_searchbox.TextChanged
        search()
    End Sub
    Sub search()
        Dim keyword As String = order_searchbox.Text.Trim()

        If Not String.IsNullOrEmpty(keyword) Then
            If Connect() Then
                Try
                    Dim query As String = $"SELECT * FROM po_form WHERE purchase_order_id LIKE '%{keyword}%' OR product_brand LIKE '%{keyword}%' OR supplier_name LIKE '%{keyword}%'"

                    Dim dataTable As New DataTable()

                    Using cmd As New MySqlCommand(query, DB.con)
                        ' Create a MySqlDataAdapter to fill the DataTable
                        Dim adapter As New MySqlDataAdapter(cmd)

                        ' Fill the DataTable with the data from the database
                        adapter.Fill(dataTable)

                        all.DataSource = dataTable
                        onprocess.DataSource = dataTable
                        delivered.DataSource = dataTable

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
End Class
