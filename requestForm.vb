Imports System.Globalization
Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class requestForm



    Private Sub requestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tNum As String = GenerateRequestNumber()
        requestNumber.Text = tNum
        loadTable()
    End Sub


    Sub loadTable()
        If Connect() Then
            Try
                Dim query As String = "CALL requestFormTableDisplay()"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, DB.con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                rFormTable.DataSource = dataTable
            Catch ex As Exception

            End Try
        End If
    End Sub

    Sub submitRequestForm()

    End Sub

    Private Sub quantity_TextChanged(sender As Object, e As EventArgs) Handles quantityBox.TextChanged
        Dim quantity As Integer
        Dim price As Double

        ' Convert text to integer for quantity
        If Integer.TryParse(quantityBox.Text, quantity) Then
            ' Text is a valid integer, proceed
            If Double.TryParse(itemPriceBox.Text, price) Then
                ' Text is a valid double, proceed
                totalPriceBox.Text = (quantity * price).ToString()
            Else
                ' Text in itemPriceBox is not a valid double
                totalPriceBox.Text = "Invalid Price"
            End If
        Else
            ' Text in quantityBox is not a valid integer
            totalPriceBox.Text = "Invalid Quantity"
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tNum As String = GenerateRequestNumber()
        Dim reqNumber As String = requestNumber.Text
        Dim reqOfficer As String = rqOfficer.Text
        Dim reqOffice As String = rqOffice.Text
        Dim itemDescrip As String = itemDescriptionBox.Text
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

                    Dim query = $"INSERT INTO request_form (request_id, requesition_officer, office, item_description,unit_of_measure,quantity,item_price,total_price, purpose, mode_of_procurement, app_code, department_code, source_of_fund, estimated_cost, estimated_budget) VALUES   ('{reqNumber}', '{reqOfficer}', '{reqOffice}', '{itemDescrip}','{unit_of_measure}','{quantity}','{item_Price}','{totalPrice}', '{purpose}', '{modeOfProcurement}', '{appCode}', '{depCode}', '{sourceOfFund}','{estimatedCost}', '{estimatedBudget}')"

                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Purchase Request Saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearRequestForm()
                    requestNumber.Text = tNum
                    checkoutTXTBOX.Text = $"ID: {reqNumber} Description:{itemDescrip} Price:{item_Price} Quantity: {quantity}"


                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If

        loadTable()
    End Sub


    Sub clearRequestForm()

        rqOfficer.Text = ""
        rqOffice.Text = ""
        itemDescriptionBox.Text = ""
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


    End Sub

    Private Sub itemPriceBox_TextChanged(sender As Object, e As EventArgs) Handles itemPriceBox.TextChanged
        calculateTotalPrice()
    End Sub


    Sub calculateTotalPrice()
        Dim quantity As Integer
        Dim price As Double

        ' Convert text to integer for quantity
        If Integer.TryParse(quantityBox.Text, quantity) Then
            ' Text is a valid integer, proceed
            If Double.TryParse(itemPriceBox.Text, price) Then
                ' Text is a valid double, proceed
                totalPriceBox.Text = (quantity * price).ToString()
            Else
                ' Text in itemPriceBox is not a valid double
                totalPriceBox.Text = "Invalid Price"
            End If
        Else
            ' Text in quantityBox is not a valid integer
            totalPriceBox.Text = "Invalid Quantity"
        End If
    End Sub

    Private Sub sourceOfFundBox_Click(sender As Object, e As EventArgs) Handles sourceOfFundBox.Click
        comboBoxLoadItems("source_of_fund", sourceOfFundBox, "Description")
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub rqOfficer_SelectedIndexChanged(sender As Object, e As EventArgs)
        comboBoxLoadItems("employees", rqOfficer, "fullname")
    End Sub

    Private Sub rqOffice_Click(sender As Object, e As EventArgs) Handles rqOffice.Click
        comboBoxLoadItems("office_name", rqOffice, "Offices_name")
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
        comboBoxLoadItems("department", cbDepCode, "department")
    End Sub

    Private Sub rqOfficer_Click(sender As Object, e As EventArgs) Handles rqOfficer.Click
        comboBoxLoadItems("employees", rqOfficer, "fullname")
    End Sub

    Private Sub estimCost_TextChanged(sender As Object, e As EventArgs) Handles estimCost.TextChanged
        Dim amount As Decimal
        If Decimal.TryParse(estimCost.Text.Replace(",", ""), NumberStyles.Currency, CultureInfo.CurrentCulture, amount) Then
            ' Format the number with commas
            estimCost.Text = amount.ToString("N0")
            ' Set the cursor position to the end
            estimCost.SelectionStart = estimCost.Text.Length
        End If

        estimBud.Text = estimCost.Text
    End Sub



    'Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    'End Sub

    'Private Sub rqOfficer_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles rqOfficer.SelectedIndexChanged

    'End Sub

    'Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    'End Sub

    'Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    'End Sub

    'Private Sub rqOffice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rqOffice.SelectedIndexChanged

    'End Sub

    'Private Sub unit_of_measureBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles unit_of_measureBox.SelectedIndexChanged

    'End Sub

    'Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    'End Sub

    'Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    'End Sub

    'Private Sub papBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles papBox.SelectedIndexChanged

    'End Sub

    'Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    'End Sub

    'Private Sub rFormTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles rFormTable.CellContentClick

    'End Sub

    'Private Sub sourceOfFundBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sourceOfFundBox.SelectedIndexChanged

    'End Sub

    'Private Sub estimBbud_SelectedIndexChanged(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    'End Sub

    'Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    'End Sub

    'Private Sub estimCost_TextChanged(sender As Object, e As EventArgs) Handles estimCost.TextChanged

    'End Sub

    'Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    'End Sub

    'Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    'End Sub

    'Private Sub cbModProc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbModProc.SelectedIndexChanged

    'End Sub

    'Private Sub cbDepCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbDepCode.SelectedIndexChanged

    'End Sub

    'Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    'End Sub

    'Private Sub purposeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles purposeBox.SelectedIndexChanged

    'End Sub

    'Private Sub Label8_Click(sender As Object, e As EventArgs)

    'End Sub

    'Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    'End Sub

    'Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    'End Sub

    'Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    'End Sub

    'Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    'End Sub

    'Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    'End Sub

    'Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    'End Sub

    'Private Sub checkoutTXTBOX_TextChanged(sender As Object, e As EventArgs) Handles checkoutTXTBOX.TextChanged

    'End Sub

    'Private Sub totalPriceBox_TextChanged(sender As Object, e As EventArgs) Handles totalPriceBox.TextChanged

    'End Sub

    'Private Sub itemDescriptionBox_TextChanged(sender As Object, e As EventArgs) Handles itemDescriptionBox.TextChanged

    'End Sub

    'Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    'End Sub

    'Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    'End Sub

    'Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    'End Sub

    'Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    'End Sub

    'Private Sub requestNumber_Click(sender As Object, e As EventArgs) Handles requestNumber.Click

    'End Sub
End Class