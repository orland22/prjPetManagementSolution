﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdoInactive = New System.Windows.Forms.RadioButton()
        Me.rdoActive = New System.Windows.Forms.RadioButton()
        Me.rdoAll = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgPets = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboStatus = New System.Windows.Forms.ComboBox()
        Me.txtBirthdate = New System.Windows.Forms.MaskedTextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.btnAddOwner = New System.Windows.Forms.Button()
        Me.btnAddBreed = New System.Windows.Forms.Button()
        Me.btnAddType = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboOwner = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboBreed = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboGender = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblNump = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutPMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MasterFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TypeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BreedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OwnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgPets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rdoInactive)
        Me.GroupBox2.Controls.Add(Me.rdoActive)
        Me.GroupBox2.Controls.Add(Me.rdoAll)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(240, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 44)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'rdoInactive
        '
        Me.rdoInactive.AutoSize = True
        Me.rdoInactive.Location = New System.Drawing.Point(304, 16)
        Me.rdoInactive.Name = "rdoInactive"
        Me.rdoInactive.Size = New System.Drawing.Size(63, 17)
        Me.rdoInactive.TabIndex = 4
        Me.rdoInactive.Text = "Inactive"
        Me.rdoInactive.UseVisualStyleBackColor = True
        '
        'rdoActive
        '
        Me.rdoActive.AutoSize = True
        Me.rdoActive.Location = New System.Drawing.Point(243, 16)
        Me.rdoActive.Name = "rdoActive"
        Me.rdoActive.Size = New System.Drawing.Size(55, 17)
        Me.rdoActive.TabIndex = 3
        Me.rdoActive.Text = "Active"
        Me.rdoActive.UseVisualStyleBackColor = True
        '
        'rdoAll
        '
        Me.rdoAll.AutoSize = True
        Me.rdoAll.Location = New System.Drawing.Point(192, 16)
        Me.rdoAll.Name = "rdoAll"
        Me.rdoAll.Size = New System.Drawing.Size(36, 17)
        Me.rdoAll.TabIndex = 2
        Me.rdoAll.Text = "All"
        Me.rdoAll.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(41, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(58, 13)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(100, 20)
        Me.txtSearch.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(544, 420)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 9
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(463, 420)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(254, 420)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(173, 420)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(11, 420)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "New"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(92, 420)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgPets
        '
        Me.dgPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPets.Location = New System.Drawing.Point(240, 79)
        Me.dgPets.Name = "dgPets"
        Me.dgPets.Size = New System.Drawing.Size(402, 294)
        Me.dgPets.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboStatus)
        Me.GroupBox1.Controls.Add(Me.txtBirthdate)
        Me.GroupBox1.Controls.Add(Me.txtNotes)
        Me.GroupBox1.Controls.Add(Me.btnAddOwner)
        Me.GroupBox1.Controls.Add(Me.btnAddBreed)
        Me.GroupBox1.Controls.Add(Me.btnAddType)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboOwner)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.cboBreed)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cboType)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cboGender)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 346)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pet Information Form"
        '
        'cboStatus
        '
        Me.cboStatus.FormattingEnabled = True
        Me.cboStatus.Items.AddRange(New Object() {"Active", "Inactive"})
        Me.cboStatus.Location = New System.Drawing.Point(69, 320)
        Me.cboStatus.Name = "cboStatus"
        Me.cboStatus.Size = New System.Drawing.Size(100, 21)
        Me.cboStatus.TabIndex = 17
        '
        'txtBirthdate
        '
        Me.txtBirthdate.Location = New System.Drawing.Point(69, 78)
        Me.txtBirthdate.Mask = "00/00/0000"
        Me.txtBirthdate.Name = "txtBirthdate"
        Me.txtBirthdate.Size = New System.Drawing.Size(100, 20)
        Me.txtBirthdate.TabIndex = 5
        Me.txtBirthdate.ValidatingType = GetType(Date)
        '
        'txtNotes
        '
        Me.txtNotes.Location = New System.Drawing.Point(69, 211)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.Size = New System.Drawing.Size(100, 103)
        Me.txtNotes.TabIndex = 15
        '
        'btnAddOwner
        '
        Me.btnAddOwner.Location = New System.Drawing.Point(175, 182)
        Me.btnAddOwner.Name = "btnAddOwner"
        Me.btnAddOwner.Size = New System.Drawing.Size(28, 23)
        Me.btnAddOwner.TabIndex = 20
        Me.btnAddOwner.Text = "+"
        Me.btnAddOwner.UseVisualStyleBackColor = True
        '
        'btnAddBreed
        '
        Me.btnAddBreed.Location = New System.Drawing.Point(175, 157)
        Me.btnAddBreed.Name = "btnAddBreed"
        Me.btnAddBreed.Size = New System.Drawing.Size(28, 23)
        Me.btnAddBreed.TabIndex = 19
        Me.btnAddBreed.Text = "+"
        Me.btnAddBreed.UseVisualStyleBackColor = True
        '
        'btnAddType
        '
        Me.btnAddType.Location = New System.Drawing.Point(175, 128)
        Me.btnAddType.Name = "btnAddType"
        Me.btnAddType.Size = New System.Drawing.Size(28, 23)
        Me.btnAddType.TabIndex = 18
        Me.btnAddType.Text = "+"
        Me.btnAddType.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Notes"
        '
        'cboOwner
        '
        Me.cboOwner.FormattingEnabled = True
        Me.cboOwner.Location = New System.Drawing.Point(69, 184)
        Me.cboOwner.Name = "cboOwner"
        Me.cboOwner.Size = New System.Drawing.Size(100, 21)
        Me.cboOwner.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 187)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Owner"
        '
        'cboBreed
        '
        Me.cboBreed.FormattingEnabled = True
        Me.cboBreed.Location = New System.Drawing.Point(69, 157)
        Me.cboBreed.Name = "cboBreed"
        Me.cboBreed.Size = New System.Drawing.Size(100, 21)
        Me.cboBreed.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Breed"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(69, 130)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(100, 21)
        Me.cboType.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Type"
        '
        'cboGender
        '
        Me.cboGender.FormattingEnabled = True
        Me.cboGender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboGender.Location = New System.Drawing.Point(69, 104)
        Me.cboGender.Name = "cboGender"
        Me.cboGender.Size = New System.Drawing.Size(100, 21)
        Me.cboGender.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Status"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Gender"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(69, 52)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Birthdate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Name"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(69, 26)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(429, 391)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Total Number of Pets :"
        '
        'lblNump
        '
        Me.lblNump.BackColor = System.Drawing.SystemColors.Info
        Me.lblNump.Location = New System.Drawing.Point(541, 386)
        Me.lblNump.Name = "lblNump"
        Me.lblNump.Size = New System.Drawing.Size(100, 23)
        Me.lblNump.TabIndex = 11
        Me.lblNump.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PMSToolStripMenuItem, Me.MasterFileToolStripMenuItem, Me.SettingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(655, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PMSToolStripMenuItem
        '
        Me.PMSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutPMSToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.PMSToolStripMenuItem.Name = "PMSToolStripMenuItem"
        Me.PMSToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.PMSToolStripMenuItem.Text = "PMS"
        '
        'AboutPMSToolStripMenuItem
        '
        Me.AboutPMSToolStripMenuItem.Name = "AboutPMSToolStripMenuItem"
        Me.AboutPMSToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutPMSToolStripMenuItem.Text = "About PMS"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'MasterFileToolStripMenuItem
        '
        Me.MasterFileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PetsToolStripMenuItem, Me.TypeToolStripMenuItem, Me.BreedToolStripMenuItem, Me.OwnerToolStripMenuItem})
        Me.MasterFileToolStripMenuItem.Name = "MasterFileToolStripMenuItem"
        Me.MasterFileToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.MasterFileToolStripMenuItem.Text = "Master File"
        '
        'PetsToolStripMenuItem
        '
        Me.PetsToolStripMenuItem.Name = "PetsToolStripMenuItem"
        Me.PetsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PetsToolStripMenuItem.Text = "Pets"
        '
        'TypeToolStripMenuItem
        '
        Me.TypeToolStripMenuItem.Name = "TypeToolStripMenuItem"
        Me.TypeToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TypeToolStripMenuItem.Text = "Type"
        '
        'BreedToolStripMenuItem
        '
        Me.BreedToolStripMenuItem.Name = "BreedToolStripMenuItem"
        Me.BreedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BreedToolStripMenuItem.Text = "Breed"
        '
        'OwnerToolStripMenuItem
        '
        Me.OwnerToolStripMenuItem.Name = "OwnerToolStripMenuItem"
        Me.OwnerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OwnerToolStripMenuItem.Text = "Owner"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsersToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(655, 471)
        Me.Controls.Add(Me.lblNump)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgPets)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pet Management Solution"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgPets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdoInactive As RadioButton
    Friend WithEvents rdoActive As RadioButton
    Friend WithEvents rdoAll As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnClose As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgPets As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBirthdate As MaskedTextBox
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnAddOwner As Button
    Friend WithEvents btnAddBreed As Button
    Friend WithEvents btnAddType As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents cboOwner As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboBreed As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboGender As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboStatus As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblNump As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutPMSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MasterFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TypeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BreedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OwnerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As ToolStripMenuItem
End Class
