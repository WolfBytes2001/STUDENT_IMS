Imports MySql.Data.MySqlClient

Public Class purchaseOrder
    Public totalPrice As String
    Public itemID As String
    Private Sub purchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        POID.Text = GeneratePOCode()
        VendorIDinput.Text = GenerateVendorID()
        loadVendorTable()
    End Sub

    Sub savePurchaseOrder()
        Dim request_id As String = POrequestNumber.Text
        Dim purchase_order_id As String = POID.Text
        Dim supplier_name As String = supplierNameBox.Text
        Dim ship_via As String = shipViaBox.Text
        Dim product_brand As String = productBox.Text
        Dim shipping_method As String = shippingMethodBox.Text
        Dim preffered_delivery_date As String = deliveryDatePicker.Text

        If Connect() Then

            If String.IsNullOrEmpty(request_id) OrElse
               String.IsNullOrEmpty(purchase_order_id) OrElse
               String.IsNullOrEmpty(supplier_name) OrElse
               String.IsNullOrEmpty(ship_via) OrElse
               String.IsNullOrEmpty(product_brand) OrElse
               String.IsNullOrEmpty(shipping_method) OrElse
               String.IsNullOrEmpty(preffered_delivery_date) OrElse
               String.IsNullOrEmpty(product_brand) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    Dim query = $"INSERT INTO po_form (request_id, purchase_order_id, supplier_name, ship_via,product_brand, shipping_method, preferred_delivery_date) VALUES   ('{request_id}', '{purchase_order_id}', '{supplier_name}', '{ship_via}','{product_brand}', '{shipping_method}', '{preffered_delivery_date}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Purchase Order details Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearPOform()
                    Dim updateQuery = $"UPDATE request_form_cart SET po_status = 'Done' WHERE item_id = '{itemID}' "
                    Using updateCmd As New MySqlCommand(updateQuery, con)
                        updateCmd.ExecuteNonQuery()
                    End Using



                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If

    End Sub
    Sub LoadItemsTabs(dataGrid As DataGridView)
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
	                                        request_form_cart.request_id = '{POrequestNumber}'"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, DB.con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                dataGrid.DataSource = dataTable


                For Each row As DataRow In dataTable.Rows
                    totalPrice += Convert.ToDecimal(row("total"))
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                con.Close()
            End Try

        End If
    End Sub

    Private Sub SaveVendorButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub POconfirmButton_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub confirPOButton_Click(sender As Object, e As EventArgs) Handles confirPOButton.Click
        savePurchaseOrder()
    End Sub

    'Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click
    '    LoadItemsTabs(itemsIncludedTable)
    'End Sub



    Sub loadVendorTable()
        If Connect() Then
            Try
                Dim query As String = "SELECT vendor_id, vendor_name, vendor_type, contact_info, location FROM vendors"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, DB.con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                VendorDataGrid.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Sub addVendor()
        Dim id As String = VendorIDinput.Text.Trim
        Dim name As String = vendorNameInput.Text.Trim
        Dim contact As String = VendorContactInfoInput.Text.Trim
        Dim location As String = vendorNameInput.Text.Trim
        Dim vendor_type As String = VendorTypeInput.Text.Trim


        If Connect() Then

            If String.IsNullOrEmpty(id) OrElse
               String.IsNullOrEmpty(name) OrElse
               String.IsNullOrEmpty(contact) OrElse
               String.IsNullOrEmpty(location) OrElse
               String.IsNullOrEmpty(vendor_type) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    Dim query = $"INSERT INTO vendors (vendor_id, vendor_name, vendor_type, contact_info,location) VALUES   ('{id}', '{name}', '{contact}', '{location}','{vendor_type}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using


                    MessageBox.Show("Vendor details Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearVendorForm()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If


    End Sub

    Sub clearVendorForm()
        vendorNameInput.Text = ""
        vendorLocationInput.Text = ""
        VendorContactInfoInput.Text = ""
        VendorTypeInput.Text = ""
        VendorIDinput.Text = ""
    End Sub

    Sub clearPOform()
        POrequestNumber.Text = ""
        POID.Text = ""
        POrequesitionOfficer.Text = ""
        POoffice.Text = ""
        'itemDescriptionBox.Text = ""
        poPurpose.Text = ""
        POModeOfProC.Text = ""
        POappCode.Text = ""
        POdepCode.Text = ""
        POsourceOfFund.Text = ""
        POestimBudget.Text = ""
        POestimCost.Text = ""
        'POQuantity.Text = ""
        'POunitOfMeasure.Text = ""
        'POitemPrice.Text = ""
        TotalAmount.Text = ""
        supplierNameBox.Text = ""
        productBox.Text = ""
        shipViaBox.Text = ""
        shippingMethodBox.Text = ""
        deliveryDatePicker.Text = ""
    End Sub



    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        addVendor()
        loadVendorTable()
    End Sub

    Private Sub supplierNameBox_Click(sender As Object, e As EventArgs) Handles supplierNameBox.Click
        comboBoxLoadItems("vendors", supplierNameBox, "vendor_name")
    End Sub
End Class
