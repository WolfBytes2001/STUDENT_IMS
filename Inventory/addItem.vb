Imports MySql.Data.MySqlClient

Public Class addItem
    Dim itemId As String
    Private Sub addItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTabs()
    End Sub

    Public Sub LoadTabs()
        If Connect() Then
            Try
                Dim query As String = $"SELECT
	                                        request_form_cart.item_id, 
	                                        request_form_cart.request_id, 
	                                        request_form_cart.item_description, 
	                                        request_form_cart.measure, 
	                                        request_form_cart.quantity, 
	                                        request_form_cart.category, 
	                                        request_form_cart.price, 
	                                        request_form_cart.total
                                        FROM
	                                        request_form
	                                        INNER JOIN
	                                        request_form_cart
	                                        ON 
		                                        request_form.request_id = request_form_cart.request_id
                                        WHERE
	                                        request_form.po_status = 'Done' AND
	                                        request_form_cart.item_status = 'Not added'
                                    "
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, DB.con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                pendingItems.DataSource = dataTable
            Catch ex As Exception

            Finally
                con.Close()
            End Try

        End If
    End Sub

    Sub Add()
        Dim ColumnItemId As String = "item_id"

        If pendingItems.SelectedCells.Count > 0 AndAlso ADDITEMTAB.SelectedTabPage Is XtraTabPage1 Then
            Dim selectedRowIndex As Integer = pendingItems.SelectedCells(0).RowIndex
            itemId = pendingItems.Rows(selectedRowIndex).Cells(ColumnItemId).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"Proceed to add item in inventory Item ID:{itemId}?", "APPROVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            If result = DialogResult.OK Then
                loadItemReview()
            Else
                MessageBox.Show("Operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Only approved requests are allowed to be generated")
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Add()
    End Sub

    Public Sub loadItemReview()
        Dim review As New itemReview()
        review.inventoryID.Text = GenerateSPORTSInventoryID()


        ' Clear existing controls from MainPanel and add the purchase order form

        review.Show()

        ' Load details of the selected request into the purchase order form
        If Connect() Then
            Try
                Dim sql = $"SELECT * FROM request_form_cart WHERE item_id = '{itemId}'"

                Using cmd As New MySqlCommand(sql, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()
                            review.prNumber = reader("request_id").ToString()
                            review.itemIDR.Text = reader("item_id").ToString()
                            review.descriptionR.Text = reader("item_description").ToString()
                            review.categoryR.Text = reader("category").ToString()
                            review.measureR.Text = reader("measure").ToString()
                            review.quantityR.Text = reader("quantity").ToString()
                            review.priceR.Text = reader("price").ToString()
                            review.totalamountR.Text = reader("total").ToString()

                        End While
                    End If

                    reader.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading purchase order: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Connection error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If



    End Sub

    'Sub LoadItemsTabs(dataGrid As DataGridView, purchaseOrderForm As purchaseOrder)
    '    If Connect() Then
    '        Try
    '            Dim query As String = $"SELECT 
    '                                    request_form_cart.item_description,
    '                                    request_form_cart.quantity,
    '                                    request_form_cart.price,
    '                                    request_form_cart.measure,
    '                                    request_form_cart.category,
    '                                    request_form_cart.total
    '                                FROM
    '                                    request_form_cart
    '                                WHERE 
    '                                    request_form_cart.request_id = '{request_IDPOform}'"
    '            Dim dataTable As New DataTable()

    '            Using cmd As New MySqlCommand(query, DB.con)
    '                Dim adapter As New MySqlDataAdapter(cmd)
    '                adapter.Fill(dataTable)
    '            End Using

    '            dataGrid.DataSource = dataTable

    '            Dim totalPrice As Decimal = 0
    '            For Each row As DataRow In dataTable.Rows
    '                totalPrice += Convert.ToDecimal(row("total"))
    '            Next

    '            ' Set the TotalAmount label in the purchase order form
    '            purchaseOrderForm.TotalAmount.Text = totalPrice.ToString()

    '        Catch ex As Exception
    '            MessageBox.Show("Error loading items: " & ex.Message)
    '        Finally
    '            con.Close()
    '        End Try
    '    End If
    'End Sub

End Class
