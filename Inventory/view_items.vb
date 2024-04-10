Imports DevExpress.Xpo.DB.DataStoreLongrunnersWatch
Imports Guna.UI.WinForms
Imports MySql.Data.MySqlClient
Public Class view_items

	Dim inventory_id As String
	Dim query As String
	Dim dataTable As New DataTable()
	Private Sub view_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'loadTable("supplies", suppliesTable)
	End Sub

	Sub loadTable(table As String, dataGrid As GunaDataGridView)
		If Connect() Then
			Try
				Dim query As String = $"SELECT * FROM {table}"
				Dim dataTable As New DataTable()
				Using cmd As New MySqlCommand(query, con)
					Dim adapter As New MySqlDataAdapter(cmd)
					adapter.Fill(dataTable)

					' Assign the DataTable to the DataGridView DataSource
					dataGrid.DataSource = dataTable
				End Using
			Catch ex As Exception
				MessageBox.Show(ex.Message)
			End Try
		End If
	End Sub

	Private Sub TabPane1_Click(sender As Object, e As EventArgs) Handles TabPane1.Click
		Try
			loadTable("technology", technologyTable)
			loadTable("furniture", furnitureTable)
			loadTable("sports", sportsTable)
			loadTable("equipment", equipmenttTable)
			loadTable("tools", toolsTable)
			loadTable("instrument", instrumentsTable)
			loadTable("vehicle", vehiclesTable)
			loadTable("supplies", suppliesTable)
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub SearchControl1_TextChanged(sender As Object, e As EventArgs) Handles SearchControl1.TextChanged
		search()
	End Sub
	Sub search()
		Dim keyword As String = SearchControl1.Text.Trim()

		If Not String.IsNullOrEmpty(keyword) Then
			If Connect() Then
				Try
					Dim query As String = $"SELECT * FROM supplies WHERE request_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"
					Dim dataTable As New DataTable()

					Using cmd As New MySqlCommand(query, con)

						Dim adapter As New MySqlDataAdapter(cmd)


						adapter.Fill(dataTable)
						searchTable.DataSource = dataTable

					End Using

					Dim query2 As String = $"SELECT * FROM technology WHERE request_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"


					Using cmd As New MySqlCommand(query2, con)

						Dim adapter As New MySqlDataAdapter(cmd)


						adapter.Fill(dataTable)
						searchTable.DataSource = dataTable

					End Using

					Dim query3 As String = $"SELECT * FROM furniture WHERE request_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"


					Using cmd As New MySqlCommand(query3, con)

						Dim adapter As New MySqlDataAdapter(cmd)


						adapter.Fill(dataTable)
						searchTable.DataSource = dataTable

					End Using

					Dim query4 As String = $"SELECT * FROM sports WHERE request_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"


					Using cmd As New MySqlCommand(query4, con)

						Dim adapter As New MySqlDataAdapter(cmd)


						adapter.Fill(dataTable)
						searchTable.DataSource = dataTable

					End Using

					Dim query5 As String = $"SELECT * FROM equipment WHERE request_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"


					Using cmd As New MySqlCommand(query5, con)

						Dim adapter As New MySqlDataAdapter(cmd)


						adapter.Fill(dataTable)
						searchTable.DataSource = dataTable

					End Using

					Dim query6 As String = $"SELECT * FROM tools WHERE request_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"


					Using cmd As New MySqlCommand(query6, con)

						Dim adapter As New MySqlDataAdapter(cmd)


						adapter.Fill(dataTable)
						searchTable.DataSource = dataTable

					End Using
					Dim query7 As String = $"SELECT * FROM instrument WHERE request_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"


					Using cmd As New MySqlCommand(query7, con)

						Dim adapter As New MySqlDataAdapter(cmd)


						adapter.Fill(dataTable)
						searchTable.DataSource = dataTable

					End Using

					Dim query8 As String = $"SELECT * FROM vehicle WHERE request_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"


					Using cmd As New MySqlCommand(query8, con)

						Dim adapter As New MySqlDataAdapter(cmd)


						adapter.Fill(dataTable)
						searchTable.DataSource = dataTable

					End Using

					Dim query9 As String = $"SELECT * FROM others WHERE request_id LIKE '%{keyword}%' OR inventory_id LIKE '%{keyword}%' OR description LIKE '%{keyword}%'"


					Using cmd As New MySqlCommand(query9, con)

						Dim adapter As New MySqlDataAdapter(cmd)


						adapter.Fill(dataTable)
						searchTable.DataSource = dataTable

					End Using
				Catch ex As Exception

					MessageBox.Show("Error searching data: " & ex.Message)

				Finally
					con.Close()
				End Try
			End If
			'Else
			'    MessageBox.Show("Please enter a search keyword.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Warning)
		End If

	End Sub


	Private Sub TabNavigationPage10_Paint(sender As Object, e As PaintEventArgs) Handles TabNavigationPage10.Paint

	End Sub

	Private Sub suppliesTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles suppliesTable.CellContentClick
		update()
	End Sub

	Sub update()
		Dim ColumnItemId As String = "inventory_id"

		If suppliesTable.SelectedCells.Count > 0 AndAlso TabPane1.SelectedPage Is TabNavigationPage2 Then
			Dim selectedRowIndex As Integer = suppliesTable.SelectedCells(0).RowIndex
			inventory_id = suppliesTable.Rows(selectedRowIndex).Cells(ColumnItemId).Value?.ToString()

			Dim result As DialogResult = MessageBox.Show($"Proceed to update Item ID:{inventory_id}?", "UPDATE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

			If result = DialogResult.OK Then
				loadItemUpdate()
			Else
				MessageBox.Show("Operation cancelled by user.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
		Else
			MessageBox.Show("Only approved requests are allowed to be generated")
		End If
	End Sub


	Sub loadItemUpdate()

		Dim update As New updateItem()


		' Clear existing controls from MainPanel and add the purchase order form

		update.Show()

		' Load details of the selected request into the purchase order form
		If Connect() Then
			Try
				Dim sql = $"SELECT
								supplies.request_id, 
								supplies.inventory_id, 
								supplies.seq_id, 
								supplies.description, 
								supplies.amountAccounted, 
								supplies.quantity, 
								supplies.price, 
								supplies.unit_of_measurement
							FROM
								supplies WHERE inventory_id = '{inventory_id}'"

				Using cmd As New MySqlCommand(sql, con)
					Dim reader As MySqlDataReader = cmd.ExecuteReader()

					If reader.HasRows Then
						While reader.Read()
							'update.prNumber = reader("request_id").ToString()
							update.inventoryID.Text = reader("inventory_id").ToString()
							update.descriptionR.Text = reader("description").ToString
							'update.categoryR.Text = reader("category").ToString()
							update.measureR.Text = reader("unit_of_measurement").ToString()
							update.quantityR.Text = reader("quantity").ToString()
							update.totalamountR.Text = reader("amountAccounted").ToString()
							update.priceR.Text = reader("price").ToString()

							'If update.categoryR.Text.ToLower = "supplies" Then
							'	update.inventoryID.Text = GenerateSuppliesInventoryID()
							'ElseIf update.categoryR.Text.ToLower = "sports" Then
							'	update.inventoryID.Text = GenerateSPORTSInventoryID()
							'End If
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
End Class
