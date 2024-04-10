Imports MySql.Data.MySqlClient

Public Class po_approve_list
    Public request_IDPOform As String
    Public itemIdPO As String
    Public purchaseOrder As New purchaseOrder()
    Private Sub po_approve_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTabs("Approved", approved)
        LoadTabs("Rejected", rejected)
        LoadTabs("Pending", pending)
    End Sub

    Sub LoadTabs(status As String, dataGrid As DataGridView)
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
	                                        request_form_cart.total, 
	                                        request_form_cart.approved_by
                                        FROM
	                                        request_form_cart
                                        WHERE
	                                        request_form_cart.approval_status = '{status}' AND
	                                        request_form_cart.po_status = 'Pending'
                                        ORDER BY
	                                        request_form_cart.added_at DESC"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, DB.con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                dataGrid.DataSource = dataTable
            Catch ex As Exception

            Finally
                con.Close()
            End Try

        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        confirmPO()

    End Sub

    Sub confirmPO()
        Dim item_id As String = "item_id"
        Dim prColumn As String = "request_id"

        If approved.SelectedCells.Count > 0 AndAlso POTAB.SelectedTabPage Is XtraTabPage1 Then
            Dim selectedRowIndex As Integer = approved.SelectedCells(0).RowIndex
            request_IDPOform = approved.Rows(selectedRowIndex).Cells(prColumn).Value?.ToString()
            itemIdPO = approved.Rows(selectedRowIndex).Cells(item_id).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"Proceed to generate Purchase order for item ID:{itemIdPO} with Request ID: {request_IDPOform}?", "APPROVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            If result = DialogResult.OK Then
                loadPurchaseOrder()
            Else
                MessageBox.Show("Operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Only approved requests are allowed to be generated")
        End If
    End Sub
    Public Sub loadPurchaseOrder()
        Dim purchaseOrderForm As New purchaseOrder()

        purchaseOrderForm.Dock = DockStyle.Fill

        ' Clear existing controls from MainPanel and add the purchase order form
        Dashboard.MainPanel.Controls.Clear()
        Dashboard.MainPanel.Controls.Add(purchaseOrderForm)
        purchaseOrderForm.Show()

        ' Load details of the selected request into the purchase order form
        If Connect() Then
            Try
                Dim sql = $"SELECT * FROM request_form WHERE request_id = '{request_IDPOform}'"
                Dim sql2 = $"SELECT * FROM request_form_cart WHERE item_id = '{itemIdPO}'"
                Using cmd As New MySqlCommand(sql2, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            purchaseOrderForm.itemID = reader("item_id").ToString
                        End While
                        reader.Close()
                    End If
                End Using
                Using cmd As New MySqlCommand(sql, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()
                            purchaseOrderForm.POrequestNumber.Text = reader("request_id").ToString()
                            purchaseOrderForm.POrequesitionOfficer.Text = reader("requesition_officer").ToString()
                            purchaseOrderForm.POoffice.Text = reader("office").ToString()
                            'purchaseOrderForm.itemDescriptionBox.Text = reader("item_description").ToString()
                            'purchaseOrderForm.POunitOfMeasure.Text = reader("unit_of_measure").ToString()
                            'purchaseOrderForm.POQuantity.Text = reader("quantity").ToString()
                            'purchaseOrderForm.POitemPrice.Text = reader("item_price").ToString()
                            purchaseOrderForm.poPurpose.Text = reader("purpose").ToString()
                            purchaseOrderForm.POModeOfProC.Text = reader("mode_of_procurement").ToString()
                            purchaseOrderForm.POappCode.Text = reader("app_code").ToString()
                            purchaseOrderForm.POdepCode.Text = reader("department_code").ToString()
                            purchaseOrderForm.POsourceOfFund.Text = reader("source_of_fund").ToString()
                            purchaseOrderForm.POestimCost.Text = reader("estimated_cost").ToString()
                            purchaseOrderForm.POestimBudget.Text = reader("estimated_budget").ToString()
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

        ' Load items related to the purchase order and calculate total price
        LoadItemsTabs(purchaseOrderForm.itemsIncludedTable, purchaseOrderForm)
    End Sub

    Sub LoadItemsTabs(dataGrid As DataGridView, purchaseOrderForm As purchaseOrder)
        If Connect() Then
            Try
                Dim query As String = $"SELECT 
                                        request_form_cart.item_description,
                                        request_form_cart.quantity,
                                        request_form_cart.price,
                                        request_form_cart.measure,
                                        request_form_cart.category,
                                        request_form_cart.total
                                    FROM
                                        request_form_cart
                                    WHERE 
                                        request_form_cart.item_id = '{itemIdPO}'"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, DB.con)
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using

                dataGrid.DataSource = dataTable

                Dim totalPrice As Decimal = 0
                For Each row As DataRow In dataTable.Rows
                    totalPrice += Convert.ToDecimal(row("total"))
                Next

                ' Set the TotalAmount label in the purchase order form
                purchaseOrderForm.TotalAmount.Text = totalPrice.ToString()

            Catch ex As Exception
                MessageBox.Show("Error loading items: " & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

End Class
