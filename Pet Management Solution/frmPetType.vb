Public Class frmPetType
    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        Dim strQuery As String
        Dim strType As String = txtType.Text
        If btnType.Text.Contains("Add") Then
            Try

                If String.IsNullOrEmpty(strType.ToString()) Then
                    MessageBox.Show("Please Fill Type of Pet ", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    ' strQuery = "INSERT INTO tbltype (typeName) VALUES ('" & txtType.Text & "') "
                    strQuery = $"INSERT INTO tbltype VALUES ({txtID.Text},'{strType}', 'Active') "

                    'MsgBox(strQuery)
                    SQLManager(strQuery, "Record saved.")
                    ExecuteCreateLog("Pet Type Form", "pet type", Val(txtID.Text))
                End If
            Catch ex As Exception
                MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            Try
                strQuery = $"UPDATE tbltype SET typeName='{strType}' WHERE typeID ={txtID.Text} "
                'MsgBox(strQuery)
                SQLManager(strQuery, "Record updated.")

            Catch ex As Exception
                MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        btnPlus.PerformClick()
    End Sub
    Private Sub txtType_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtType.KeyPress
        If e.KeyChar <> vbBack And Char.IsLetter(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dgType_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgType.CellClick
        btnType.Text = "Update"
        Dim i As Integer = e.RowIndex
        With dgType
            txtID.Text = .Item("typeID", i).Value
            txtType.Text = .Item("typeName", i).Value
        End With
    End Sub

    Private Sub frmPetType_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlus.PerformClick()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click

        txtID.Text = RecordCount("tbltype", "typeID") + 1
        btnType.Text = "Add"
        txtType.Clear()
        Dim strQuery As String = "SELECT * FROM tbltype"
        DisplayRecords(strQuery, dgType)

    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        Dim strQuery As String
        Try
            strQuery = $"UPDATE tbltype SET typeStatus='Active' WHERE typeID ={txtID.Text} "
            'MsgBox(strQuery)
            SQLManager(strQuery, "Record updated.")
            btnPlus.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnIN_Click(sender As Object, e As EventArgs) Handles btnIN.Click
        Dim strQuery As String
        Try
            strQuery = $"UPDATE tbltype SET typeStatus='Inactive' WHERE typeID ={txtID.Text} "
            'MsgBox(strQuery)
            SQLManager(strQuery, "Record updated.")
            ExecuteDeleteLog("Pet Type Form", "delete pet #", Val(txtID.Text))
            btnPlus.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
 MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class