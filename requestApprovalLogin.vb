Imports MySql.Data.MySqlClient

Public Class requestApprovalLogin
    Public officerName As String
    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim username As String = usernameBox1.Text.Trim()
        Dim password As String = passwordBox1.Text.Trim()
        If Connect() Then
            Try
                Dim query As String = "SELECT * FROM admin WHERE username = @username AND `password` = @password"
                Using cmd As New MySqlCommand(query, DB.con)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)

                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    If reader.HasRows Then
                        While reader.Read()
                            officerName = reader("fullname").ToString()

                        End While

                        MessageBox.Show($"WELCOME {officerName} ", "Authentication Succes!", MessageBoxButtons.OK, MessageBoxIcon.Information)


                        loadForm()





                    Else
                        MessageBox.Show("Invalid username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)


                    End If

                    reader.Close()

                End Using
            Catch ex As Exception

            End Try
        End If
    End Sub

    Sub loadForm()
        Dim approval As New requestApproval()
        approval.TopLevel = False
        approval.Dock = DockStyle.Fill
        Dashboard.MainPanel.Controls.Clear()
        Dashboard.MainPanel.Controls.Add(approval)
        approval.Show()
        approval.textBoxForOfficer.Text = officerName
        loadTable()
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
                requestApproval.approvalTable.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class
