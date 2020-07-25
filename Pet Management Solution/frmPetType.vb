Public Class frmPetType
    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        Dim strQuery As String
        Dim strType As String = txtType.Text

        Try
            If String.IsNullOrEmpty(strType.ToString()) Then
                MessageBox.Show("Please Fill Type of Pet ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                strQuery = "INSERT INTO tbltype (typeName) VALUES ('" & txtType.Text & "') "
                'MsgBox(strQuery)
                SQLManager(strQuery, "Record saved.")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtType.KeyPress
        If e.KeyChar <> vbBack And Char.IsLetter(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class