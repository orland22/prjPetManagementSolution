Public Class frmPetOwner
    Private owner As petOwner
    Private Sub btnPersonAdd_Click(sender As Object, e As EventArgs) Handles btnPersonAdd.Click
        Dim strQuery As String
        Dim strName As String = txtOwnerName.Text
        Dim strAddress As String = txtAddress.Text
        Dim strPhone As String = txtPhone.Text
        If btnPersonAdd.Text.Contains("Add") Then
            Try
                If String.IsNullOrEmpty(strName.ToString()) Then
                    MessageBox.Show("Please Fill All", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf String.IsNullOrEmpty(strAddress.ToString()) Then
                    MessageBox.Show("Please Fill All", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf String.IsNullOrEmpty(strPhone.ToString()) Then
                    MessageBox.Show("Please Fill All", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    strQuery = $"INSERT INTO tblowner VALUES ({textID.Text}, '{strName }', '{strAddress}', '{strPhone}', 'Active') "
                    'MsgBox(strQuery)
                    SQLManager(strQuery, "Record saved.")
                    ExecuteCreateLog("PetOwner Form", "pet owner", Val(textID.Text))
                    btnPlus.PerformClick()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
        Else
            owner.Name = strName
            owner.Address = strAddress
            owner.Phone = strPhone
            Try
                If String.IsNullOrEmpty(strName.ToString()) Then
                    MessageBox.Show("Please Fill All", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf String.IsNullOrEmpty(strAddress.ToString()) Then
                    MessageBox.Show("Please Fill All", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf String.IsNullOrEmpty(strPhone.ToString()) Then
                    MessageBox.Show("Please Fill All", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    strQuery = $"UPDATE tblowner SET ownerName='{owner.Name}', ownerAddress='{owner.Address}', ownerContactNumber='{owner.Phone}' WHERE ownerID ={textID.Text} "
                    'MsgBox(strQuery)
                    If SQLManager(strQuery) Then
                        SQLManager(owner.Auditlog)
                    End If
                    btnPlus.PerformClick()
                End If
            Catch ex As Exception
                MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
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

    Private Sub frmPetOwner_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlus.PerformClick()
    End Sub

    Private Sub dgOwner_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOwner.CellClick
        btnPersonAdd.Text = "Update"
        Dim i As Integer = e.RowIndex
        Try
            With dgOwner
                owner = New petOwner(CType(.Item("ownerID", i).Value, Integer))
                textID.Text = owner.ID
                txtOwnerName.Text = owner.Name
                txtAddress.Text = owner.Address
                txtPhone.Text = owner.Phone


                'txtOwnerName.Text = .Item("ownerName", i).Value
                'txtAddress.Text = .Item("ownerAddress", i).Value
                'txtPhone.Text = .Item("ownerContactNumber", i).Value
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        Dim strQuery As String
        Try
            strQuery = $"UPDATE tblowner SET ownerStatus='Active'  WHERE ownerID ={textID.Text} "
            'MsgBox(strQuery)
            SQLManager(strQuery, "Record set to Active.")
            btnPlus.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnIN_Click(sender As Object, e As EventArgs) Handles btnIN.Click
        Dim strQuery As String
        Try
            strQuery = $"UPDATE tblowner SET ownerStatus='Inactive'  WHERE ownerID ={ textID.Text} "
            'MsgBox(strQuery)
            SQLManager(strQuery, "Record Set to Inactive.")
            ExecuteDeleteLog("Owner Pet Form", "owner", Val(textID.Text))
            btnPlus.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        textID.Text = RecordCount("tblOwner", "ownerID") + 1
        btnPersonAdd.Text = "Add"
        txtOwnerName.Clear()
        txtAddress.Clear()
        txtPhone.Clear()
        Dim strQuery As String = "SELECT * FROM tblowner"
        DisplayRecords(strQuery, dgOwner)
    End Sub
End Class