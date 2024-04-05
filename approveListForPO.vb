Imports DevExpress
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class approveListForPO
    Public request_IDPOform As String
    'Sub loadApproveTable()
    '    If Connect() Then
    '        Try
    '            Dim query As String = "SELECT request_id, item_description, requesition_officer, status FROM request_form WHERE status = 'Approved'"
    '            Dim dataTable As New DataTable()

    '            Using cmd As New MySqlCommand(query, DB.con)
    '                Dim adapter As New MySqlDataAdapter(cmd)
    '                adapter.Fill(dataTable)
    '            End Using

    '            ' Assuming ApproveDataGrid is a DataGridView control on your form
    '            ApproveDataGrid.DataSource = dataTable
    '        Catch ex As Exception
    '            MessageBox.Show("Error loading approved items: " & ex.Message)
    '        Finally
    '            con.Close()
    '        End Try
    '    End If
    'End Sub


    Sub LoadTabs(status As String, dataGrid As DataGridView)
        If Connect() Then
            Try
                Dim query As String = $"SELECT request_id , item_description, requesition_officer, status,approved_by FROM request_form WHERE status = '{status}' AND po_status = 'Pending' ORDER BY 
                request_form.requested_at DESC"
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

    Private Sub approveListForPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTabs("Approved", ApproveDataGrid)
        LoadTabs("Rejected", rejectedDataGrid)
        LoadTabs("Pending", PendingDataGrid)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        confirmPO()
        Me.Close()
    End Sub

    Sub confirmPO()
        Dim tableName As String = "request_id"

        If ApproveDataGrid.SelectedCells.Count > 0 AndAlso TABCONTROL1.SelectedTabPage Is XtraTabPage1 Then
            Dim selectedRowIndex As Integer = ApproveDataGrid.SelectedCells(0).RowIndex
            request_IDPOform = ApproveDataGrid.Rows(selectedRowIndex).Cells(tableName).Value?.ToString()

            Dim result As DialogResult = MessageBox.Show($"Proceed to generate Purchase order for Request ID: {request_IDPOform}?", "APPROVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            If result = DialogResult.OK Then
                loadPurchaseOrder()
            Else
                MessageBox.Show("Operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("Only approved requests are allowed to be generated")
        End If
    End Sub

    'Private Sub XtraTabControl1_Click(sender As Object, e As EventArgs) Handles TABCONTROL1.Click
    '    loadApproveTable()
    'End Sub

    Public Sub loadPurchaseOrder()

        Dim purchaseOrder As New purchase_order()
        purchaseOrder.TopLevel = False
        purchaseOrder.Dock = DockStyle.Fill
        'If MainDashboard.DashboardContainer.Controls.Count >= 0 Then
        '    Dim existingForm = TryCast(MainDashboard.DashboardContainer.Controls(0), Form)
        '    If existingForm IsNot Nothing Then
        '        existingForm.Dispose()
        '    End If
        'End If
        MainDashboard.DashboardContainer.Controls.Clear()
        MainDashboard.DashboardContainer.Controls.Add(purchaseOrder)
        purchaseOrder.Show()


        If Connect() Then
            Try
                Dim sql = $"SELECT * FROM request_form WHERE request_id = '{request_IDPOform}'"

                Using cmd As New MySqlCommand(sql, con)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()


                    If reader.HasRows Then
                        While reader.Read()
                            purchaseOrder.POrequestNumber.Text = reader("request_id").ToString()
                            purchaseOrder.POrequesitionOfficer.Text = reader("requesition_officer").ToString()
                            purchaseOrder.POoffice.Text = reader("office").ToString()
                            purchaseOrder.itemDescriptionBox.Text = reader("item_description").ToString()
                            purchaseOrder.POunitOfMeasure.Text = reader("unit_of_measure").ToString()
                            purchaseOrder.POQuantity.Text = reader("quantity").ToString()
                            purchaseOrder.POitemPrice.Text = reader("item_price").ToString()
                            purchaseOrder.TotalAmount.Text = reader("total_price").ToString()
                            purchaseOrder.poPurpose.Text = reader("purpose").ToString()
                            purchaseOrder.POModeOfProC.Text = reader("mode_of_procurement").ToString()
                            purchaseOrder.POappCode.Text = reader("app_code").ToString()
                            purchaseOrder.POdepCode.Text = reader("department_code").ToString()
                            purchaseOrder.POsourceOfFund.Text = reader("source_of_fund").ToString()
                            purchaseOrder.POestimCost.Text = reader("estimated_cost").ToString()
                            purchaseOrder.POestimBudget.Text = reader("estimated_budget").ToString()

                        End While

                    Else
                        'MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)


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
End Class