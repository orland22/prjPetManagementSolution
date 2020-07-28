<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtType = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtRetype = New System.Windows.Forms.TextBox()
        Me.lblbb = New System.Windows.Forms.Label()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lblPAss = New System.Windows.Forms.Label()
        Me.llblls = New System.Windows.Forms.Label()
        Me.txtConNum = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgUser = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.btnDeac = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtType)
        Me.GroupBox1.Controls.Add(Me.cboType)
        Me.GroupBox1.Controls.Add(Me.txtRetype)
        Me.GroupBox1.Controls.Add(Me.lblbb)
        Me.GroupBox1.Controls.Add(Me.btnPlus)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.txtUser)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.txtLast)
        Me.GroupBox1.Controls.Add(Me.txtFirst)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.lblPAss)
        Me.GroupBox1.Controls.Add(Me.llblls)
        Me.GroupBox1.Controls.Add(Me.txtConNum)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 344)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'txtType
        '
        Me.txtType.AutoSize = True
        Me.txtType.Location = New System.Drawing.Point(6, 308)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(31, 13)
        Me.txtType.TabIndex = 3
        Me.txtType.Text = "Type"
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Items.AddRange(New Object() {"Encoder", "Admin"})
        Me.cboType.Location = New System.Drawing.Point(71, 305)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(121, 21)
        Me.cboType.TabIndex = 3
        '
        'txtRetype
        '
        Me.txtRetype.Location = New System.Drawing.Point(71, 277)
        Me.txtRetype.Name = "txtRetype"
        Me.txtRetype.Size = New System.Drawing.Size(100, 20)
        Me.txtRetype.TabIndex = 3
        '
        'lblbb
        '
        Me.lblbb.AutoSize = True
        Me.lblbb.Location = New System.Drawing.Point(8, 284)
        Me.lblbb.Name = "lblbb"
        Me.lblbb.Size = New System.Drawing.Size(53, 13)
        Me.lblbb.TabIndex = 3
        Me.lblbb.Text = "RE TYPE"
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(177, 39)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(30, 31)
        Me.btnPlus.TabIndex = 2
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(71, 248)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(100, 20)
        Me.txtPass.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(71, 212)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 2
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(71, 171)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(100, 20)
        Me.txtContact.TabIndex = 2
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(71, 134)
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(100, 20)
        Me.txtLast.TabIndex = 2
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(71, 96)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(71, 42)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 2
        '
        'lblPAss
        '
        Me.lblPAss.AutoSize = True
        Me.lblPAss.Location = New System.Drawing.Point(6, 251)
        Me.lblPAss.Name = "lblPAss"
        Me.lblPAss.Size = New System.Drawing.Size(59, 13)
        Me.lblPAss.TabIndex = 2
        Me.lblPAss.Text = "Password :"
        '
        'llblls
        '
        Me.llblls.AutoSize = True
        Me.llblls.Location = New System.Drawing.Point(0, 212)
        Me.llblls.Name = "llblls"
        Me.llblls.Size = New System.Drawing.Size(55, 13)
        Me.llblls.TabIndex = 5
        Me.llblls.Text = "Username"
        '
        'txtConNum
        '
        Me.txtConNum.AutoSize = True
        Me.txtConNum.Location = New System.Drawing.Point(6, 174)
        Me.txtConNum.Name = "txtConNum"
        Me.txtConNum.Size = New System.Drawing.Size(54, 13)
        Me.txtConNum.TabIndex = 4
        Me.txtConNum.Text = "Contact #"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'dgUser
        '
        Me.dgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUser.Location = New System.Drawing.Point(243, 33)
        Me.dgUser.Name = "dgUser"
        Me.dgUser.Size = New System.Drawing.Size(428, 272)
        Me.dgUser.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(34, 364)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Confirm"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCan
        '
        Me.btnCan.Location = New System.Drawing.Point(129, 364)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(75, 23)
        Me.btnCan.TabIndex = 4
        Me.btnCan.Text = "cancel"
        Me.btnCan.UseVisualStyleBackColor = True
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(503, 381)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(75, 23)
        Me.btnActivate.TabIndex = 5
        Me.btnActivate.Text = "Active"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'btnDeac
        '
        Me.btnDeac.Location = New System.Drawing.Point(584, 381)
        Me.btnDeac.Name = "btnDeac"
        Me.btnDeac.Size = New System.Drawing.Size(75, 23)
        Me.btnDeac.TabIndex = 6
        Me.btnDeac.Text = "Deactivate"
        Me.btnDeac.UseVisualStyleBackColor = True
        '
        'UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 432)
        Me.Controls.Add(Me.btnDeac)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "UserManagement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UserManagement"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPlus As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtLast As TextBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents lblPAss As Label
    Friend WithEvents llblls As Label
    Friend WithEvents txtConNum As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgUser As DataGridView
    Friend WithEvents txtType As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents txtRetype As TextBox
    Friend WithEvents lblbb As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCan As Button
    Friend WithEvents btnActivate As Button
    Friend WithEvents btnDeac As Button
End Class
