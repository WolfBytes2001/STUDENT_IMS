Imports MySql.Data.MySqlClient

Public Class requestApproval
    Public requestID As String
    Private Sub reqeustApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTableApproval(approvalTable)
        Dim currentDate As String = DateTime.Now.ToString("yyyy-MM-dd")
        DateLabel.Text = currentDate



    End Sub

    Sub loadTable()
        If Connect() Then
            Try
                Dim query As String = "SELECT
	                request_form.request_id, 
	                request_form_cart.item_description, 
	                request_form_cart.measure, 
	                request_form_cart.quantity, 
	                request_form_cart.category, 
	                request_form_cart.price, 
	                request_form_cart.total, 
	                request_form.requesition_officer, 
	                request_form.office, 
	                request_form.purpose, 
	                request_form.mode_of_procurement, 
	                request_form.app_code, 
	                request_form.department_code, 
	                request_form.source_of_fund, 
	                request_form.estimated_cost, 
	                request_form.estimated_budget
                FROM
	                request_form
	                INNER JOIN
	                request_form_cart
	                ON 
		                request_form.request_id = request_form_cart.request_id
                WHERE
	                request_form.`status` = 'Pending' AND
	                request_form.po_status = 'Pending'ORDER BY 
                                        request_form.requested_at DESC"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, DB.con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                approvalTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Sub loadTableApproval(table As DataGridView)
        If Connect() Then
            Try
                Dim query As String = "SELECT
	                request_form.request_id, 
	                request_form.requesition_officer, 
	                request_form.office, 
	                request_form.purpose, 
	                request_form.source_of_fund, 
	                request_form.estimated_budget, 
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
	                request_form.status = 'Pending'
                ORDER BY
	                request_form.requested_at DESC"
                Dim dataTable As New DataTable()

                Using cmd As New MySqlCommand(query, DB.con)

                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(dataTable)
                End Using
                table.DataSource = dataTable
            Catch ex As Exception

            End Try
        End If
    End Sub


    Sub Approve()

        Dim reqID As String = "request_id"

        If approvalTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = approvalTable.SelectedCells(0).RowIndex
            requestID = approvalTable.Rows(selectedRowIndex).Cells(reqID).Value?.ToString()

            If Not String.IsNullOrEmpty(textBoxForOfficer.Text) Then
                Dim result As DialogResult = MessageBox.Show($"Proceed to approve Request ID:{requestID}", "APPROVE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

                If result = DialogResult.OK Then
                    If Connect() Then
                        Try
                            Dim query As String = $"UPDATE request_form SET status = 'Approved', approved_by = '{textBoxForOfficer.Text}' WHERE request_id = '{requestID}'"

                            Using cmd As New MySqlCommand(query, con)
                                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                                If rowsAffected > 0 Then
                                    MessageBox.Show("Request approved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    saveData()
                                Else
                                    MessageBox.Show("Approval  failed. No rows were affected.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End Using
                        Catch ex As Exception
                            MessageBox.Show("Update failed" & ex.Message)
                        End Try
                    End If


                Else
                    MessageBox.Show("Update operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                'Else
                '    MessageBox.Show("EMPTY")
            Else
                MessageBox.Show("Please fill up approval officer detail ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If
        Else
            MessageBox.Show("Select a row")
        End If
    End Sub

    Sub reject()
        Dim columnName As String = "request_id"

        If approvalTable.SelectedCells.Count > 0 Then
            Dim selectedRowIndex As Integer = approvalTable.SelectedCells(0).RowIndex
            requestID = approvalTable.Rows(selectedRowIndex).Cells(columnName).Value?.ToString()

            If Not String.IsNullOrEmpty(textBoxForOfficer.Text) Then
                Dim result As DialogResult = MessageBox.Show($"Proceed to reject Request ID:{requestID}", "REJECT?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

                If result = DialogResult.OK Then
                    If Connect() Then
                        Try
                            Dim query As String = $"UPDATE request_form SET status = 'Rejected' WHERE request_id = '{requestID}'"


                            Using cmd As New MySqlCommand(query, con)
                                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                                If rowsAffected > 0 Then
                                    MessageBox.Show("Request rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    saveData()
                                Else
                                    MessageBox.Show("Rejection  failed. No rows were affected.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                End If
                            End Using
                        Catch ex As Exception
                            MessageBox.Show("Reject failed" & ex.Message)
                        End Try
                    End If


                Else
                    MessageBox.Show("Update operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                'Else
                '    MessageBox.Show("EMPTY")
            Else
                MessageBox.Show("Please fill up approval officer detail ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Select a row")
        End If

    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Approve()

        loadTableApproval(approvalTable)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        reject()

        loadTableApproval(approvalTable)
    End Sub

    Sub saveData()
        Dim approvalOff As String = textBoxForOfficer.Text

        If Connect() Then

            If String.IsNullOrEmpty(textBoxForOfficer.Text) Then
                MessageBox.Show("Please fill up approval officer details", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    Dim query As String = $"INSERT INTO request_approval(request_approval.request_id,request_approval.approved_by)
                VALUES ('{requestID}','{textBoxForOfficer}')"


                    Using cmd As New MySqlCommand(query, con)
                        Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                        If rowsAffected > 0 Then
                            MessageBox.Show("Saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Saved  failed. No rows were affected.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Saved failed" & ex.Message)
                End Try
            End If



        End If

    End Sub

    Private Sub GunaDataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class