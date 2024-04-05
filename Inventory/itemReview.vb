Imports MySql.Data.MySqlClient

Public Class itemReview

    Public prNumber As String

    Private Sub itemReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inventoryID.Text = GenerateSPORTSInventoryID()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        AddItemToInventory(categoryR.Text.ToLower.Trim)
    End Sub

    Sub AddItemToInventory(table As String)
        Dim descrip As String = descriptionR.Text
        Dim categ As String = categoryR.Text
        Dim meas As String = measureR.Text
        Dim quanti As String = quantityR.Text
        Dim price As String = priceR.Text
        Dim inv As String = inventoryID.Text
        If Connect() Then
            Try
                Dim query As String = $"INSERT INTO {table}(request_id,inventory_id,description,price,quantity  ) VALUES('{prNumber}','{inv}','{descrip}','{price}','{quanti}')"
                Using cmd As New MySqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                End Using
                Dim query2 As String = $"UPDATE request_form_cart SET item_status = 'Added' WHERE item_id = '{itemIDR.Text}'"
                Using cmd As New MySqlCommand(query2, con)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Item stored in the inventory!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class