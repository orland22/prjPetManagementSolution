Public Class frmPetOwner
    Private Sub btnPersonAdd_Click(sender As Object, e As EventArgs) Handles btnPersonAdd.Click
        Dim strQuery As String
        Dim strName As String = txtOwnerName.Text
        Dim strAddress As String = txtAddress.Text
        Dim strPhone As String = txtPhone.Text

        Try

            If String.IsNullOrEmpty(strName.ToString()) Then
                MessageBox.Show("Please Fill All", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(strAddress.ToString()) Then
                MessageBox.Show("Please Fill All", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf String.IsNullOrEmpty(strPhone.toString()) Then
                MessageBox.Show("Please Fill All", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                strQuery = "INSERT INTO tblowner (ownerName,ownerAddress,ownerContactNumber ) VALUES ('" & strName & "', '" & strAddress & "', '" & strPhone & "') "
                'MsgBox(strQuery)
                SQLManager(strQuery, "Record saved.")
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If


    End Sub
End Class