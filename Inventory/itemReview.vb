Imports MySql.Data.MySqlClient

Public Class itemReview

    Public prNumber As String

    Private Sub itemReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If categoryR.Text.ToLower = "supplies" Then
            inventoryID.Text = GenerateSuppliesInventoryID()
        ElseIf categoryR.Text = "sports" Then
            inventoryID.Text = GenerateSPORTSInventoryID()
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        AddItemToInventory(categoryR.Text.ToLower.Trim)

    End Sub

    Sub AddItemToInventory(table As String)
        Dim descrip As String = descriptionR.Text
        Dim categ As String = categoryR.Text
        Dim meas As String = measureR.Text
        Dim quanti As String = quantityR.Text
        Dim price As Decimal = priceR.Text
        Dim total As String = totalamountR.Text
        Dim inv As String = inventoryID.Text
        If Connect() Then
            Try
                Dim query As String = $"INSERT INTO {table}(request_id,inventory_id,description,amountAccounted,quantity,price,unit_of_measurement  ) VALUES('{prNumber}','{inv}','{descrip}','{total}','{quanti}','{price}','{meas}')"
                Using cmd As New MySqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                End Using
                Dim query2 As String = $"UPDATE request_form_cart SET item_status = 'Added' WHERE item_id = '{itemIDR.Text}'"
                Using cmd As New MySqlCommand(query2, con)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Item stored in the inventory!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dashboard.addItems.LoadTabs()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub



End Class