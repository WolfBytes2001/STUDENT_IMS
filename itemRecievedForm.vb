Imports System.IO
Imports DevExpress.Xpo.DB.Helpers
Imports MySql.Data.MySqlClient

Public Class itemRecievedForm
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles recieved_itemButton.Click
        Dim poId As String = poId_IR.Text
        Dim personnel As String = personnel_ir.Text
        Dim vehicle As String = vehicle_type.Text
        Dim recievedBy As String = inspected_by.Text
        Dim dateRecieved As String = date_recieved_IR.Text
        Dim condition As String = itemConditionCB.Text

        If Connect() Then

            If String.IsNullOrEmpty(poId) OrElse
               String.IsNullOrEmpty(personnel) OrElse
               String.IsNullOrEmpty(vehicle) OrElse
               String.IsNullOrEmpty(recievedBy) OrElse
               String.IsNullOrEmpty(condition) OrElse
               String.IsNullOrEmpty(dateRecieved) Then
                MessageBox.Show("One or more fields have not been completed.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Try
                    Dim query = $"INSERT INTO item_recieved (purchase_order_id, delivery_personel_name, delivery_vehicle, date_recieved,recieved_by,item_condition) VALUES   ('{poId}', '{personnel}', '{vehicle}', '{dateRecieved}','{recievedBy}', '{condition}')"
                    Using cmd As New MySqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                    End Using
                    MessageBox.Show("Order recieved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearForm()
                    Dim updateQuery = $"UPDATE po_form SET order_status = 'Delivered' WHERE purchase_order_id = '{poId}' "
                    Using updateCmd As New MySqlCommand(updateQuery, con)
                        updateCmd.ExecuteNonQuery()
                    End Using



                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try

            End If
        End If
    End Sub
    'Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
    '    Dim openFileDialog As New OpenFileDialog()

    '    ' Set the file dialog filters and properties
    '    openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif"
    '    openFileDialog.Multiselect = False

    '    If openFileDialog.ShowDialog() = DialogResult.OK Then
    '        Dim selectedFilePath As String = openFileDialog.FileName

    '        If Connect() Then
    '            Dim imageBytes As Byte() = File.ReadAllBytes(selectedFilePath)

    '            Dim query As String = "INSERT INTO item_received (delivery_image) VALUES (@ImageData)"
    '            Using cmd As New MySqlCommand(query, con)
    '                cmd.Parameters.AddWithValue("@ImageData", imageBytes)
    '                cmd.ExecuteNonQuery()
    '            End Using

    '            MessageBox.Show("Image uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        End If
    '    Else
    '        MessageBox.Show("No image selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub

    'Private Function ImageToByteArray(image As Image) As Byte()
    '    Dim stream As New MemoryStream()
    '    image.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
    '    Return stream.ToArray()
    'End Function

    Sub clearForm()
        poId_IR.Text = ""
        personnel_ir.Text = ""
        inspected_by.Text = ""
        date_recieved_IR.Text = ""
        vehicle_type.Text = ""
        itemConditionCB.Text = " "
    End Sub

    Private Sub LabelControl1_Click(sender As Object, e As EventArgs) Handles LabelControl1.Click

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim openfile As New OpenFileDialog

        Dim openFileDialog As New OpenFileDialog()

        ' Set the file dialog filters and properties
        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.gif)|*.jpg;*.jpeg;*.png;*.gif"
        openFileDialog.Multiselect = False

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = openFileDialog.FileName

            If Connect() Then
                Dim imageBytes As Byte() = File.ReadAllBytes(selectedFilePath)

                Dim query As String = "INSERT INTO item_received (delivery_image) VALUES (@ImageData)"
                Using cmd As New MySqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@ImageData", imageBytes)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("Image uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show("No image selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ImageToByteArray(image As Image) As Byte()
        Dim stream As New MemoryStream()
        image.Save(stream, System.Drawing.Imaging.ImageFormat.Png)
        Return stream.ToArray()
    End Function

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class