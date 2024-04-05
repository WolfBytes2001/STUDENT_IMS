Imports DevExpress
Imports DevExpress.XtraLayout.Customization
Imports MySql.Data.MySqlClient

Public Class request
    Private cartItems As New List(Of CartItem)()
    Private Sub PanelControl1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        requestIDLabel.Text = GenerateRequestNumber()
        loadTable()
    End Sub

    Private Sub addToCartButton_Click(sender As Object, e As EventArgs)
        addToCart()
    End Sub



    Sub addToCart()
        Dim tNum As String = GenerateRequestNumber()
        Dim reqNumber As String = requestIDLabel.Text
        Dim reqOfficer As String = rqOfficer.Text
        Dim reqOffice As String = rqOffice.Text
        Dim itemDescrip As String = itemDesBox.Text
        Dim unit_of_measure As String = unit_of_measureBox.Text
        Dim quantity As String = quantityBox.Text
        Dim item_Price As String = itemPriceBox.Text
        Dim purpose As String = purposeBox.Text
        Dim modeOfProcurement As String = cbModProc.Text
        Dim appCode As String = papBox.Text
        Dim depCode As String = cbDepCode.Text
        Dim sourceOfFund As String = sourceOfFundBox.Text
        Dim estimatedCost As String = estimCost.Text
        Dim estimatedBudget As String = estimBud.Text
        Dim totalPrice As String = totalPriceBox.Text

        If Connect() Then

            If String.IsNullOrEmpty(reqNumber) OrElse
               String.IsNullOrEmpty(reqOfficer) OrElse
               String.IsNullOrEmpty(reqOffice) OrElse
               String.IsNullOrEmpty(itemDescrip) OrElse
               String.IsNullOrEmpty(unit_of_measure) OrElse
               String.IsNullOrEmpty(quantity) OrElse
               String.IsNullOrEmpty(item_Price) OrElse
               String.IsNullOrEmpty(purpose) OrElse
               String.IsNullOrEmpty(modeOfProcurement) OrElse
               String.IsNullOrEmpty(appCode) OrElse
               String.IsNullOrEmpty(depCode) OrElse
               String.IsNullOrEmpty(estimatedBudget) OrElse
               String.IsNullOrEmpty(estimatedCost) OrElse
               String.IsNullOrEmpty(totalPrice) OrElse
               String.IsNullOrEmpty(sourceOfFund) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                Try

                    'Dim query = $"INSERT INTO request_form (request_id, requesition_officer, office, item_description,unit_of_measure,quantity,item_price,total_price, purpose, mode_of_procurement, app_code, department_code, source_of_fund, estimated_cost, estimated_budget) VALUES   ('{reqNumber}', '{reqOfficer}', '{reqOffice}', '{itemDescrip}','{unit_of_measure}','{quantity}','{item_Price}','{totalPrice}', '{purpose}', '{modeOfProcurement}', '{appCode}', '{depCode}', '{sourceOfFund}','{estimatedCost}', '{estimatedBudget}')"

                    'Using cmd As New MySqlCommand(query, con)
                    '    cmd.ExecuteNonQuery()
                    'End Using
                    MessageBox.Show("Item added to cart!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearRequestForm()
                    requestIDLabel.Text = tNum
                    cartTextBox.Text = $"ID: {reqNumber} Description:{itemDescrip} Price:{item_Price} Quantity: {quantity}"


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If

        'loadTable()
    End Sub


    Sub clearRequestForm()

        rqOffice.Text = ""
        rqOfficer.Text = ""
        itemDesBox.Text = ""
        purposeBox.Text = ""
        cbModProc.Text = ""
        papBox.Text = ""
        cbDepCode.Text = ""
        sourceOfFundBox.Text = ""
        estimCost.Text = ""
        estimBud.Text = ""
        'TotalAmount.Text = ""
        quantityBox.Text = ""
        unit_of_measureBox.Text = ""
        itemPriceBox.Text = ""
        totalPriceBox.Text = ""
        cartTextBox.Clear()

    End Sub

    Sub clearAddItem()

        itemDesBox.Text = ""
        itemCategoryBox.Text = ""
        priceBox.Text = ""
        itemTotalPriceBox.Text = ""
        itemQuantityBox.Text = ""
        unitOfMeBOx.Text = ""

    End Sub


    Sub calculateTotalPrice()
        Dim quantity As Integer
        Dim price As Double

        ' Convert text to integer for quantity
        If Integer.TryParse(itemQuantityBox.Text, quantity) Then
            ' Text is a valid integer, proceed
            If Double.TryParse(priceBox.Text, price) Then
                ' Text is a valid double, proceed
                itemTotalPriceBox.Text = (quantity * price).ToString()
            Else
                ' Text in itemPriceBox is not a valid double
                itemTotalPriceBox.Text = "Invalid Price"
            End If
        Else
            ' Text in quantityBox is not a valid integer
            itemTotalPriceBox.Text = "Invalid Quantity"
        End If
    End Sub

    Private Sub itemQuantityBox_TextChanged(sender As Object, e As EventArgs) Handles itemQuantityBox.TextChanged
        calculateTotalPrice()

    End Sub

    Private Sub priceBox_TextChanged(sender As Object, e As EventArgs) Handles priceBox.TextChanged
        calculateTotalPrice()
    End Sub



    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim reqId = requestIDLabel.Text
        Dim description As String = itemDesBox.Text
        Dim measure As String = unitOfMeBOx.Text
        Dim quantity As String = itemQuantityBox.Text
        Dim category As String = itemCategoryBox.Text
        Dim price As String = priceBox.Text
        Dim total As String = itemTotalPriceBox.Text

        If Connect() Then
            If String.IsNullOrEmpty(description) OrElse
           String.IsNullOrEmpty(measure) OrElse
           String.IsNullOrEmpty(quantity) OrElse
           String.IsNullOrEmpty(category) OrElse
           String.IsNullOrEmpty(price) OrElse
           String.IsNullOrEmpty(total) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    ' Add the item to the cart list
                    Dim newItem As New CartItem() With {
                    .RequestId = reqId,
                    .Description = description,
                    .Measure = measure,
                    .Quantity = quantity,
                    .Category = category,
                    .Price = price,
                    .Total = total
                }
                    cartItems.Add(newItem)

                    ' Update the display of items in the cart
                    UpdateCartTextBox()

                    ' Add the item to the database
                    Dim query As String = $"INSERT INTO request_form_cart(request_id,item_description,measure,quantity,category,price,total) VALUES('{reqId}','{description}','{measure}','{quantity}','{category}','{price}','{total}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using

                    MessageBox.Show("Item added to cart and database!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearAddItem()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub

    ' Method to update the display of items in the cart
    Private Sub UpdateCartTextBox()
        cartTextBox.Clear()
        For Each item As CartItem In cartItems
            cartTextBox.AppendText($"PR ID: {item.RequestId} {Environment.NewLine} Description: {item.Description}{Environment.NewLine} Quantity: {item.Quantity}{Environment.NewLine} Price: {item.Price}{Environment.NewLine} Total: {item.Total}{Environment.NewLine} {Environment.NewLine}")
        Next
    End Sub



    Sub loadTable()
        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM request_form"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, DB.con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                PR_TABLE.DataSource = dataTable
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub ConfirmPurchaseRequestButton_Click(sender As Object, e As EventArgs) Handles ConfirmPurchaseRequestButton.Click
        Dim reqId = requestIDLabel.Text
        Dim officer = rqOfficer.Text
        Dim office = rqOffice.Text
        Dim source = sourceOfFundBox.Text
        Dim app = papBox.Text
        Dim estCost = estimCost.Text
        Dim purpose = purposeBox.Text
        Dim dep = cbDepCode.Text
        Dim estBud = estimBud.Text
        Dim mode = cbModProc.Text

        If Connect() Then
            If String.IsNullOrEmpty(reqId) OrElse
               String.IsNullOrEmpty(source) OrElse
               String.IsNullOrEmpty(app) OrElse
               String.IsNullOrEmpty(estCost) OrElse
               String.IsNullOrEmpty(estBud) OrElse
               String.IsNullOrEmpty(dep) OrElse
               String.IsNullOrEmpty(mode) OrElse
               String.IsNullOrEmpty(purpose) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                Try
                    Dim query As String = $"INSERT INTO request_form(request_id,requesition_officer,office,purpose,mode_of_procurement,app_code,department_code,source_of_fund,estimated_cost,estimated_budget) VALUES('{reqId}','{officer}','{office}','{purpose}','{mode}','{app}','{dep}','{source}','{estCost}','{estBud}')"

                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Purchase Request Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearRequestForm()
                    requestIDLabel.Text = GenerateRequestNumber()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If
        End If
    End Sub



    Private Sub rqOfficer_Click(sender As Object, e As EventArgs) Handles rqOfficer.Click
        comboBoxLoadItems("employees", rqOfficer, "fullname")
    End Sub

    Private Sub rqOffice_Click(sender As Object, e As EventArgs) Handles rqOffice.Click
        comboBoxLoadItems("Office_name", rqOffice, "Offices_name")
    End Sub

    Private Sub sourceOfFundBox_Click(sender As Object, e As EventArgs) Handles sourceOfFundBox.Click
        comboBoxLoadItems("source_of_fund", sourceOfFundBox, "description")
    End Sub

    Private Sub purposeBox_Click(sender As Object, e As EventArgs) Handles purposeBox.Click
        comboBoxLoadItems("req_purpose", purposeBox, "purpose")
    End Sub

    Private Sub cbModProc_Click(sender As Object, e As EventArgs) Handles cbModProc.Click
        comboBoxLoadItems("modes_of_procurement", cbModProc, "mode")
    End Sub

    Private Sub papBox_Click(sender As Object, e As EventArgs) Handles papBox.Click
        comboBoxLoadItems("pap", papBox, "PAP_description")
    End Sub

    Private Sub cbDepCode_Click(sender As Object, e As EventArgs) Handles cbDepCode.Click
        comboBoxLoadItems("department", cbDepCode, "Department")
    End Sub

    Private Sub estimCost_TextChanged(sender As Object, e As EventArgs) Handles estimCost.TextChanged
        estimBud.Text = estimCost.Text
    End Sub
End Class
