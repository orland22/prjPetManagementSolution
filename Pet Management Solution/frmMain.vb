' Name:         Pet Management Solution
' Programmer:   Orland Celestino on July 18, 2020

Public Class frmMain
   ' Public user As Login
    Private pet As Pet
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If user.Type = "Admin" Then
            AdminSet.Visible = True
        ElseIf user.Type = "Encoder" Then
            AdminSet.Visible = False
        End If

        StatusUser.Text = "User: " & user.Type.ToString & "[ " & user.Username & " ]"
        StatusName.Text = "Developed by :" & user.FirtsName & user.LastName & " Copyright ©  2020"

        dbConnection()
        box()
        rdoAll.Checked = True
        btnNew.PerformClick()
        Status_RadioButton()
        Search_Data()
    End Sub

    Private Sub box()
        txtID.Text = RecordCount("tblpet", "petID") + 1

        Dim strQuery As String
        strQuery = "Select * FROM tblType"
        LoadToComboBox(strQuery, cboType, "typeID", "typeName", "typeStatus")

        strQuery = "Select breedID, breedName, typeID from tblBreed " +
            "WHERE typeID = " + cboType.SelectedValue.ToString
        LoadToComboBox(strQuery, cboBreed, "breedID", "breedName", "breedStatus")

        strQuery = "SELECT * FROM tblOwner WHERE ownerStatus='Active'"
        LoadToComboBox(strQuery, cboOwner, "ownerID", "ownerName", "ownerStatus")


    End Sub
    Private Sub cboType_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cboType.SelectionChangeCommitted
        Dim strQuery As String
        Try
            strQuery = "Select breedID, breedName, typeID FROM tblbreed " +
                "WHERE typeID = " + cboType.SelectedValue.ToString
            LoadToComboBox(strQuery, cboBreed, "breedID", "breedName", "breedStatus")
        Catch ex As Exception
            MessageBox.Show("Error:cboType SelectionChangeCommitted()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'save button
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strQuery As String
        Try
            strQuery = "INSERT INTO tblpet VALUES (" &
                txtID.Text & ", " &
                cboOwner.SelectedValue.ToString & ", '" &
                txtName.Text & "', '" &
                CDate(txtBirthdate.Text).ToString("yyyy-MM-dd") & "', '" &
                cboGender.Text & "', '" &
                cboStatus.Text & "', " &
                cboBreed.SelectedValue.ToString & ", '" &
                txtNotes.Text & "')"

            SQLManager(strQuery, "Record saved.")
            ExecuteCreateLog("Main Form", "pet", Val(txtID.Text))
            txtID.Text = RecordCount("tblpet", "petID") + 1
            strQuery = "Select petID, petName, petBirthdate, petGender, tbltype.typeName, tblbreed.breedName, " +
                "petNotes, tblOwner.ownerName, tblOwner.ownerAddress, " +
                "tblOwner.ownerContactNumber, petStatus " +
                "FROM tblpet INNER JOIN tblbreed ON tblpet.petBreed = tblBreed.breedID " +
                "INNER JOIN tbltype ON tbltype.typeID = tblbreed.typeID " +
                "INNER JOIN tblowner ON tblowner.ownerID = tblpet.ownerID ORDER BY petID"
            DisplayRecords(strQuery, dgPets)
            Status_RadioButton()
        Catch ex As Exception
            MessageBox.Show("Error: Save()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'data grid selection
    Private Sub dgPets_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPets.CellClick
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        btnPrint.Enabled = False
        btnSave.Enabled = False
        Dim i As Integer = e.RowIndex
        Try
            pet = New Pet(CType(dgPets.Item("petID", i).Value, Integer))
            txtID.Text = pet.ID
            txtName.Text = pet.Name
            txtBirthdate.Text = pet.Birthdate
            cboGender.Text = pet.Gender
            cboType.SelectedValue = pet.Type.ID
            'Update cboBreed First before anything
            Dim strQuery As String
            Try
                strQuery = "Select breedID, breedName, typeID FROM tblbreed " +
                "WHERE typeID = " + cboType.SelectedValue.ToString
                LoadToComboBox(strQuery, cboBreed, "breedID", "breedName", "breedStatus")
            Catch ex As Exception
                MessageBox.Show("Error:cboType SelectionChangeCommitted()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            'resume Display of Click

            cboBreed.SelectedValue = pet.Breed.ID
            cboOwner.SelectedValue = pet.Owner.ID
            txtNotes.Text = pet.Notes
            cboStatus.Text = pet.Status
        Catch ex As Exception
            MessageBox.Show("Empty Fields", "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'button new
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        txtID.Text = RecordCount("tblpet", "petID") + 1
        btnSave.Enabled = True
        btnPrint.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        txtName.Text = String.Empty
        txtBirthdate.Text = String.Empty
        cboGender.SelectedIndex = 0
        If cboType.Items.Count > 0 Then
            cboType.SelectedIndex = 0
        End If
        If cboBreed.Items.Count > 0 Then
            cboBreed.SelectedIndex = 0
        End If
        If cboOwner.Items.Count > 0 Then
            cboOwner.SelectedIndex = 0
        End If

        txtNotes.Text = String.Empty
        cboStatus.SelectedIndex = 0
    End Sub

    'button Update
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim strQuery As String
        'trim to remove white space
        pet.Name = txtName.Text.Trim
        pet.Birthdate = Date.ParseExact(txtBirthdate.Text, "dd/MM/yyyy", Nothing).ToString("MM/dd/yyyy")  'CDate(txtBirthdate.Text).ToString()
        pet.Gender = cboGender.Text
        pet.Breed = New petBreed(cboBreed.SelectedValue)
        pet.Owner = New petOwner(cboOwner.SelectedValue)
        pet.Notes = txtNotes.Text.Trim
        pet.Status = cboStatus.Text

        Try
            strQuery = $"UPDATE tblpet SET petName = '{pet.Name}', petBirthdate = '{Date.ParseExact(pet.Birthdate, "dd/MM/yyyy", Nothing).ToString("yyyy-MM-dd")}', petGender = '{pet.Gender}', petBreed = {pet.Breed.ID}, ownerID ={pet.Owner.ID}, petNotes = '{pet.Notes}', petStatus='{pet.Status}'  WHERE petID ={pet.ID}"
            If SQLManager(strQuery) Then
                'success audit
                SQLManager(pet.Auditlog)
            End If
            'MsgBox(pet.Auditlog)
            txtID.Text = RecordCount("tblpet", "petID") + 1
            Status_RadioButton()
            Search_Data()
        Catch ex As Exception
            MessageBox.Show("Error: btnUpdate_Click()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    'set to Inactive 
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim strQuery As String
        Try
            strQuery = "UPDATE tblpet SET petStatus='Inactive'  WHERE petID = " & txtID.Text
            'MsgBox(strQuery)
            SQLManager(strQuery, "Pet status set to INACTIVE.")
            ExecuteDeleteLog("Main Form", "pet", Val(txtID.Text))
            btnNew.PerformClick()
            strQuery = "SELECT petID, petName, petBirthdate, petGender, tbltype.typeName, " +
            "tblbreed.breedName, petNotes, " +
            "tblOwner.ownerName, tblOwner.ownerAddress, tblOwner.ownerContactNumber, petStatus " +
            "FROM tblpet INNER JOIN tblbreed ON tblpet.petBreed = tblbreed.breedID " +
            "INNER JOIN tbltype ON tbltype.typeID = tblbreed.typeID " +
            "INNER JOIN tblowner ON tblowner.ownerID = tblpet.ownerID ORDER BY petID"
            DisplayRecords(strQuery, dgPets)
            Status_RadioButton()
        Catch ex As Exception
            MessageBox.Show("Error: btnDelete_Click()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Status_RadioButton()
        Try
            Dim strQuery As String = "SELECT petID, petName, petBirthdate, petGender, tbltype.typeName, tblbreed.breedname," +
            "petNotes, tblowner.ownerName, tblowner.ownerAddress, tblowner.ownerContactNumber," +
            "petStatus FROM tblpet INNER JOIN tblbreed ON tblpet.petBreed = tblbreed.breedID INNER JOIN tbltype ON tbltype.typeID = tblbreed.typeID INNER JOIN tblowner on tblowner.ownerID = tblpet.ownerID"

            If rdoAll.Checked Then
                strQuery += " ORDER BY petID ASC "
                lblNump.Text = AllPet()
            ElseIf rdoActive.Checked Then
                strQuery += " WHERE petStatus = 'Active' ORDER BY petID "
                lblNump.Text = ActivePet()
            ElseIf rdoInactive.Checked Then
                strQuery += " WHERE petStatus = 'Inactive' ORDER BY petID "
                lblNump.Text = InacPet()
            End If
            DisplayRecords(strQuery, dgPets)
        Catch ex As Exception
            MessageBox.Show("Error: Status_Enter()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Search_Data()
        Try
            Dim strQuery As String = "SELECT petID, petName, petBirthdate, petGender, tbltype.typeName, tblbreed.breedname," +
            "petNotes, tblowner.ownerName, tblowner.ownerAddress, tblowner.ownerContactNumber," +
            "petStatus FROM tblpet INNER JOIN tblbreed ON tblpet.petBreed = tblbreed.breedID INNER JOIN tbltype ON tbltype.typeID = tblbreed.typeID INNER JOIN tblowner on tblowner.ownerID = tblpet.ownerID"

            Dim strSearch = "'%" & txtSearch.Text & "%'"
            strQuery += " WHERE petID like " & strSearch & " OR petName LIKE " & strSearch & " OR petBirthdate LIKE " & strSearch & " OR petGender LIKE " & strSearch & " OR tbltype.typeName LIKE " & strSearch &
                " OR tblbreed.breedname LIKE " & strSearch & " OR petNotes LIKE " & strSearch & " OR tblowner.ownerName LIKE " & strSearch & " OR tblowner.ownerAddress LIKE " & strSearch & " OR tblowner.ownerContactNumber LIKE " & strSearch &
                " ORDER BY petID"
            DisplayRecords(strQuery, dgPets)
        Catch ex As Exception
            MessageBox.Show("Error: _Search_Data()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
    Private Sub rdoButton_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAll.CheckedChanged, rdoActive.CheckedChanged, rdoInactive.CheckedChanged
        Status_RadioButton()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Search_Data()
    End Sub

    Private Sub btnAddType_Click(sender As Object, e As EventArgs) Handles btnAddType.Click
        Dim frm As frmPetType
        frm = New frmPetType
        frm.ShowDialog()
        Dim strQuery As String = "SELECT * FROM tbltype"
        LoadQueryToComboBox1(strQuery, "typeID", "typeName", cboType)
    End Sub
    Private Sub btnAddBreed_Click(sender As Object, e As EventArgs) Handles btnAddBreed.Click
        Dim frm As frmBreed
        frm = New frmBreed
        frm.PetTypeID = cboType.SelectedValue.ToString
        frm.ShowDialog()
        Dim strQuery As String = "SELECT breedID, breedName, typeID FROM tblbreed WHERE typeID = " + cboType.SelectedValue.ToString
        LoadQueryToComboBox2(strQuery, "breedID", "breedName", cboBreed)
    End Sub
    Private Sub btnAddOwner_Click(sender As Object, e As EventArgs) Handles btnAddOwner.Click
        Dim frm As frmPetOwner
        frm = New frmPetOwner
        frm.ShowDialog()
        Dim strQuery As String = "SELECT * FROM tblowner"
        LoadQueryToComboBox3(strQuery, "ownerID", "ownerName", cboOwner)
    End Sub

    Private Sub LoadQueryToComboBox1(strQuery As String, v1 As String, v2 As String, cboType As ComboBox)
        LoadToComboBox(strQuery, cboType, "typeID", "typeName", "typeStatus")
    End Sub
    Private Sub LoadQueryToComboBox2(strQuery As String, v1 As String, v2 As String, cboBreed As ComboBox)
        LoadToComboBox(strQuery, cboBreed, "breedID", "breedName", "breedStatus")
    End Sub
    Private Sub LoadQueryToComboBox3(strQuery As String, v1 As String, v2 As String, cboOwner As ComboBox)
        LoadToComboBox(strQuery, cboOwner, "ownerID", "ownerName", "ownerStatus")
    End Sub

    Private Sub AboutPMSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutPMSToolStripMenuItem.Click
        Dim AbUs As AboutUS
        AbUs = New AboutUS
        AbUs.ShowDialog()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Dim form As New UserManagement
        form.ShowDialog()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ExecuteLogout()

    End Sub

    Private Sub MStype_Click(sender As Object, e As EventArgs) Handles MStype.Click
        Dim form As New frmPetType
        form.ShowDialog()
    End Sub

    Private Sub MSbreed_Click(sender As Object, e As EventArgs) Handles MSbreed.Click
        Dim form As New frmBreed
        form.ShowDialog()
    End Sub

    Private Sub MSowner_Click(sender As Object, e As EventArgs) Handles MSowner.Click
        Dim form As New frmPetOwner
        form.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Dim form As New frmPrintPet
        form.ShowDialog()
        Dim strQuery As String = String.Empty
        ExecutePrint(strQuery, "Print form")
        'MsgBox(strQuery)
        SQLManager(strQuery)

    End Sub

    Private Sub LogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogsToolStripMenuItem.Click
        Dim form As New frmAudit
        form.ShowDialog()
    End Sub
End Class
