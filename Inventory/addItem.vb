Imports System.Net.Http.Headers
Imports DevExpress.XtraLayout.Customization
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
	                                        po_form.product_brand, 
	                                        request_form_cart.measure, 
	                                        request_form_cart.quantity, 
	                                        request_form_cart.category, 
	                                        request_form_cart.price, 
	                                        request_form_cart.total
                                        FROM
	                                        request_form_cart
	                                        INNER JOIN
	                                        po_form
	                                        ON 
		                                        request_form_cart.request_id = po_form.request_id
                                        WHERE
	                                        po_form.order_status = 'Delivered' AND
	                                        request_form_cart.po_status = 'Done' AND
	                                        request_form_cart.approval_status = 'Approved' AND
	                                        request_form_cart.item_status = 'Not added'"
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



        ' Clear existing controls from MainPanel and add the purchase order form

        review.Show()

        ' Load details of the selected request into the purchase order form
        If Connect() Then
            Try
                Dim sql = $"SELECT
	                        *, 
	                        request_form_cart.*, 
	                        request_form_cart.item_id, 
	                        request_form_cart.request_id, 
	                        request_form_cart.item_description, 
	                        po_form.product_brand, 
	                        request_form_cart.measure, 
	                        request_form_cart.quantity, 
	                        request_form_cart.category, 
	                        request_form_cart.price, 
	                        request_form_cart.total
                        FROM
	                        request_form_cart
	                        INNER JOIN
	                        po_form
	                        ON 
		                        request_form_cart.request_id = po_form.request_id WHERE item_id = '{itemId}'"

                Using cmd As New MySqlCommand(sql, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()
                            review.prNumber = reader("request_id").ToString()
                            review.itemIDR.Text = reader("item_id").ToString()
                            review.descriptionR.Text = reader("product_brand").ToString + " " + reader("item_description").ToString()
                            review.categoryR.Text = reader("category").ToString()
                            review.measureR.Text = reader("measure").ToString()
                            review.quantityR.Text = reader("quantity").ToString()
                            review.priceR.Text = reader("price").ToString()
                            review.totalamountR.Text = reader("total").ToString()

                            'generate Inventory ID
                            If review.categoryR.Text.ToLower = "supplies" Then
                                review.inventoryID.Text = GenerateSuppliesInventoryID()
                            ElseIf review.categoryR.Text.ToLower = "sports" Then
                                review.inventoryID.Text = GenerateSPORTSInventoryID()
                            ElseIf review.categoryR.Text.ToLower = "technology" Then
                                review.inventoryID.Text = GenerateTechInventoryID()
                            ElseIf review.categoryR.Text.ToLower = "furniture" Then
                                review.inventoryID.Text = GenerateFurnitureInventoryID()
                            ElseIf review.categoryR.Text.ToLower = "equipment" Then
                                review.inventoryID.Text = GenerateEquipmentInventoryID()
                            ElseIf review.categoryR.Text.ToLower = "tools" Then
                                review.inventoryID.Text = GenerateToolsInventoryID()
                            ElseIf review.categoryR.Text.ToLower = "instrument" Then
                                review.inventoryID.Text = GenerateInstrumentInventoryID()
                            ElseIf review.categoryR.Text.ToLower = "vehicle" Then
                                review.inventoryID.Text = GenerateVehiclesInventoryID()
                            End If
                        End While
                    End If

                    reader.Close()
                End Using
                LoadTabs()
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
