Imports MySql.Data.MySqlClient

Public Class updateItem


    '' Constructor to initialize the view_items instance
    'Public Sub New(ByVal viewItemInstance As view_items)
    '    viewItem = viewItemInstance
    '    InitializeComponent()
    'End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Dim id As String = inventoryID.Text
        Dim descrip As String = descriptionR.Text
        Dim measure As String = measureR.Text
        Dim reason As String = reasonR.Text

        If Connect() Then
            Try
                Dim query As String = $"UPDATE supplies SET description = '{descrip}', unit_of_measurement = '{measure}', update_reason = '{reason}' WHERE inventory_id = '{id}' "

                Using cmd As New MySqlCommand(query, con)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Call the loadTable method of the view_items instance
                Dashboard.viewItems.loadTable("supplies", Dashboard.viewItems.suppliesTable)
            Catch ex As Exception
                MessageBox.Show("Error updating item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



End Class
