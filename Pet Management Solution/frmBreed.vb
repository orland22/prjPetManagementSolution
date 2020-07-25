Public Class frmBreed
    Private _intPetTypeID As String
    Public WriteOnly Property PetTypeID As Integer
        Set(value As Integer)
            _intPetTypeID = value
        End Set
    End Property

    Private Sub frmBreed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtType.Text = GetPetType(_intPetTypeID)
    End Sub

    Private Sub btnBreed_Click(sender As Object, e As EventArgs) Handles btnBreed.Click
        Dim strQuery As String
        Dim strBreed As String = txtBreed.Text
        Try
            If String.IsNullOrEmpty(strBreed.ToString) Then
                MessageBox.Show("Please Fill Breed", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                strQuery = "INSERT INTO tblbreed (breedname,typeID) VALUES ('" & txtBreed.Text & "', " & _intPetTypeID.ToString & " ) "
                'MsgBox(strQuery)
                SQLManager(strQuery, "Record saved.")
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBreed.KeyPress
        If e.KeyChar <> vbBack And Char.IsLetter(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class