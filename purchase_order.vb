Imports Google.Protobuf.WellKnownTypes
Imports System.Reflection.Emit
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud

Public Class purchase_order
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

                    Dim updateQuery = $"UPDATE request_form SET po_status = 'Done' WHERE request_id = '{request_id}' "
                    Using updateCmd As New MySqlCommand(updateQuery, con)
                        updateCmd.ExecuteNonQuery()
                    End Using



                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If

    End Sub

    'Public Sub loadPurchaseOrder()
    '    If Connect() Then
    '        Try
    '            Dim sql = $"SELECT * FROM request_form WHERE request_id = '{approveListForPO.request_IDPOform}'"

    '            Using cmd As New MySqlCommand(sql, con)

    '                Dim reader As MySqlDataReader = cmd.ExecuteReader()
    '                If reader.HasRows Then
    '                    While reader.Read()


    '                        POrequestNumber.Text = reader("request_id").ToString()
    '                        POrequesitionOfficer.Text = reader("requesition_officer").ToString()
    '                        POoffice.Text = reader("office").ToString()
    '                        itemDescriptionBox.Text = reader("item_description").ToString()
    '                        POappCode.Text = reader("app_code").ToString()
    '                        POdepCode.Text = reader("department_code").ToString()
    '                        POsourceOfFund.Text = reader("source_of_fund").ToString()
    '                        POestimCost.Text = reader("estimated_cost").ToString()
    '                        POestimBudget.Text = reader("estimated_budget").ToString()
    '                        POunitOfMeasure.Text = reader("unit_of_measure").ToString()
    '                        POQuantity.Text = reader("quantity").ToString()
    '                        POitemPrice.Text = reader("item_price").ToString()



    '                    End While

    '                Else
    '                    'MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)


    '                End If

    '                reader.Close()

    '            End Using
    '        Catch ex As Exception
    '            MessageBox.Show(ex.Message)
    '        End Try
    '    End If
    'End Sub

    Private Sub purchase_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        POID.Text = GeneratePOCode()
        VendorIDinput.Text = GenerateVendorID()
        loadVendorTable()
    End Sub

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

                    Dim updateQuery = "UPDATE request_form SET purchase_order_status = 'Done' WHERE purchase_order_status IS NULL"
                    Using updateCmd As New MySqlCommand(updateQuery, con)
                        updateCmd.ExecuteNonQuery()
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
        itemDescriptionBox.Text = ""
        poPurpose.Text = ""
        POModeOfProC.Text = ""
        POappCode.Text = ""
        POdepCode.Text = ""
        POsourceOfFund.Text = ""
        POestimBudget.Text = ""
        POestimCost.Text = ""
        POQuantity.Text = ""
        POunitOfMeasure.Text = ""
        POitemPrice.Text = ""
        TotalAmount.Text = ""
        supplierNameBox.Text = ""
        productBox.Text = ""
        shipViaBox.Text = ""
        shippingMethodBox.Text = ""
        deliveryDatePicker.Text = ""
    End Sub

    Sub ClearAllTextBoxes()

    End Sub

    Private Sub supplierNameBox_Click(sender As Object, e As EventArgs) Handles supplierNameBox.Click
        comboBoxLoadItems("vendors", supplierNameBox, "vendor_name")
    End Sub

    Private Sub SaveVendorButton_Click(sender As Object, e As EventArgs) Handles SaveVendorButton.Click
        addVendor()
    End Sub

    Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles XtraTabControl1.Click
        loadVendorTable()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles POconfirmButton.Click
        savePurchaseOrder()
        clearPOform()
    End Sub



End Class