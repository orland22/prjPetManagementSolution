Public Class frmBreed
    Private _intPetTypeID As String
    Private breed As petBreed
    Public WriteOnly Property PetTypeID As Integer
        Set(value As Integer)
            _intPetTypeID = value
        End Set
    End Property

    Private Sub frmBreed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtType.Text = GetPetType(_intPetTypeID)
        btnPlus.PerformClick()
        cdoType.SelectedValue = _intPetTypeID
    End Sub

    Private Sub btnBreed_Click(sender As Object, e As EventArgs) Handles btnBreed.Click
        Dim strQuery As String
        Dim strBreed As String = txtBreed.Text

        If btnBreed.Text.Contains("Add") Then
            Try
                If String.IsNullOrEmpty(strBreed.ToString) Then
                    MessageBox.Show("Please Fill Breed", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else
                    strQuery = $"INSERT INTO tblbreed VALUES ({txtID.Text},'{strBreed}', '{cdoType.SelectedValue}' , 'Active') "
                    'MsgBox(strQuery)
                    SQLManager(strQuery, "Record saved.")
                    ExecuteCreateLog("Breed Form", "new breed # ", Val(txtID.Text))
                End If

            Catch ex As Exception
                MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            breed.Name = strBreed
            breed.Type = New petType(cdoType.SelectedValue)
            Try
                strQuery = $"UPDATE tblbreed SET breedname='{breed.Name}', typeID={breed.Type.ID} WHERE breedID ={txtID.Text}"
                'MsgBox(strQuery)
                If SQLManager(strQuery) Then
                    SQLManager(breed.Auditlog)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        btnPlus.PerformClick()

    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBreed.KeyPress
        If e.KeyChar <> vbBack And Char.IsLetter(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub dgBreed_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgBreed.CellClick
        btnBreed.Text = "Update"
        Dim i As Integer = e.RowIndex
        With dgBreed
            breed = New petBreed(CType(.Item("breedID", i).Value, Integer))
            txtID.Text = breed.ID
            cdoType.SelectedValue = breed.Type.ID
            txtBreed.Text = breed.Name
            ' txtID.Text = .Item("breedID", i).Value
            ' cdoType.SelectedValue = .Item("typeID", i).Value
            'txtBreed.Text = .Item("breedname", i).Value
        End With
    End Sub

    Private Sub ACT_Click(sender As Object, e As EventArgs) Handles ACT.Click
        Dim strQuery As String
        Try
            strQuery = $"UPDATE tblbreed SET breedStatus='Active' WHERE breedID ={txtID.Text} "
            SQLManager(strQuery, "Record updated.")
            btnPlus.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DEACT_Click(sender As Object, e As EventArgs) Handles DEACT.Click

        Dim strQuery As String
        Try
            strQuery = $"UPDATE tblbreed SET breedStatus='Inactive' WHERE breedID={txtID.Text} "
            SQLManager(strQuery, "Record updated.")
            ExecuteDeleteLog("Breed Form", "delete breed #", Val(txtID.Text))
            btnPlus.PerformClick()
        Catch ex As Exception
            MessageBox.Show("Error: Save() " & ex.Message, "Pet DBMS",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        Dim strQuery As String = "SELECT * FROM tblType"
        LoadToComboBox(strQuery, cdoType, "typeID", "typeName", "typeStatus")
        txtID.Text = RecordCount("tblbreed", "breedID") + 1
        cdoType.SelectedIndex = 0
        btnBreed.Text = "Add"
        txtBreed.Clear()
        strQuery = "SELECT * FROM tblbreed"
        DisplayRecords(strQuery, dgBreed)
    End Sub


End Class