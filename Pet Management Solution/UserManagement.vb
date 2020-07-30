Public Class UserManagement
    Private account As Login
    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        txtID.Text = RecordCount("tbluser", "userID") + 1
        btnAdd.Text = "Add"
        txtFirst.Clear()
        txtLast.Clear()
        txtContact.Clear()
        txtUser.Clear()
        txtPass.Clear()
        txtRetype.Clear()
        cboType.SelectedIndex = 0
        Dim strQuery As String = "SELECT userID, userFirstname, userLastname, userContactNum, userName, userType FROM tbluser"
        DisplayRecords(strQuery, dgUser)
    End Sub

    Private Sub UserManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnPlus.PerformClick()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strQuery As String = String.Empty

        If btnAdd.Text.Contains("Add") Then
            If txtPass.Text <> String.Empty AndAlso txtPass.Text = txtRetype.Text Then
                Try
                    strQuery = $"INSERT INTO tbluser VALUES ({txtID.Text}, '{txtFirst.Text }', '{txtLast.Text}', '{txtContact.Text}', '{txtUser.Text}', md5('{txtPass.Text}'),'{cboType.SelectedIndex}', 'Active' ) "
                    'MsgBox(strQuery) 
                    SQLManager(strQuery, "Record saved.")
                    ExecuteCreateLog("User Form", "user account", Val(txtID.Text))
                    btnPlus.PerformClick()
                Catch ex As Exception
                    MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                   MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MsgBox("Password mismatch", MsgBoxStyle.Exclamation)
            End If

        Else
            account.FirtsName = txtFirst.Text
                account.LastName = txtLast.Text
                account.Contact = txtContact.Text
                account.Username = txtUser.Text
                account.Password = txtPass.Text = If(txtPass.Text = txtRetype.Text, txtPass.Text, " ")
                account.Type = cboType.SelectedIndex

                If txtPass.Text = String.Empty AndAlso txtRetype.Text = String.Empty Then
                    strQuery = $"UPDATE tbluser SET userFirstname='{account.FirtsName}', userLastname='{account.LastName}', userContactNum='{account.Contact}', userName='{account.Username}', userType='{account.Type}' WHERE userID={account.ID}  "
                ElseIf txtPass.Text = txtRetype.Text Then
                    strQuery = $"UPDATE tbluser SET userFirstname='{account.FirtsName}', userLastname='{account.LastName}', userContactNum='{account.Contact}', userName='{account.Username}', userPassword =md5('{account.Password}'),  userType='{account.Type}' WHERE userID={account.ID}  "
                End If
                If SQLManager(strQuery) Then
                    SQLManager(account.Auditlog)
                    MsgBox("Updated")
                End If
            'MsgBox(strQuery)
            'SQLManager(strQuery, "Record saved.")
            btnPlus.PerformClick()
        End If
        btnPlus.PerformClick()
    End Sub

    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        Dim strQuery As String
        Try
            strQuery = $"UPDATE tbluser SET userStatus='Active' WHERE userID ={txtID.Text} "
            'MsgBox(strQuery)
            SQLManager(strQuery, "Record set to Active.")
            btnPlus.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub btnDeac_Click(sender As Object, e As EventArgs) Handles btnDeac.Click
        Dim strQuery As String
        Try
            strQuery = $"UPDATE tbluser SET userStatus='Inactive' WHERE userID ={txtID.Text} "
            'MsgBox(strQuery)
            SQLManager(strQuery, "Record set to Inactive.")
            ExecuteDeleteLog("User Form", "delete user ", Val(txtID.Text))
            btnPlus.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub dgUser_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUser.CellClick
        btnAdd.Text = "Update"
        Dim i As Integer = e.RowIndex
        Try
            With dgUser
                account = New Login(CType(.Item("userID", i).Value, Integer))
                txtID.Text = account.ID
                txtFirst.Text = account.FirtsName
                txtLast.Text = account.LastName
                txtContact.Text = account.Contact
                txtUser.Text = account.Username
                cboType.SelectedIndex = account.Type

            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Me.Close()
    End Sub
End Class