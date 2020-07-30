<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPetOwner
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOwnerName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnPersonAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnIN = New System.Windows.Forms.Button()
        Me.dgOwner = New System.Windows.Forms.DataGridView()
        Me.owID = New System.Windows.Forms.Label()
        Me.textID = New System.Windows.Forms.TextBox()
        Me.btnAC = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        CType(Me.dgOwner, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(9, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(17, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Phone :"
        '
        'txtOwnerName
        '
        Me.txtOwnerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtOwnerName.Location = New System.Drawing.Point(82, 100)
        Me.txtOwnerName.Name = "txtOwnerName"
        Me.txtOwnerName.Size = New System.Drawing.Size(181, 24)
        Me.txtOwnerName.TabIndex = 3
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtAddress.Location = New System.Drawing.Point(82, 147)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(181, 24)
        Me.txtAddress.TabIndex = 4
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtPhone.Location = New System.Drawing.Point(82, 189)
        Me.txtPhone.MaxLength = 11
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(181, 24)
        Me.txtPhone.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(61, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(170, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Owner's Information"
        '
        'btnPersonAdd
        '
        Me.btnPersonAdd.Location = New System.Drawing.Point(82, 234)
        Me.btnPersonAdd.Name = "btnPersonAdd"
        Me.btnPersonAdd.Size = New System.Drawing.Size(86, 29)
        Me.btnPersonAdd.TabIndex = 7
        Me.btnPersonAdd.Text = "Add"
        Me.btnPersonAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(174, 234)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 29)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnIN
        '
        Me.btnIN.Location = New System.Drawing.Point(493, 277)
        Me.btnIN.Name = "btnIN"
        Me.btnIN.Size = New System.Drawing.Size(86, 29)
        Me.btnIN.TabIndex = 9
        Me.btnIN.Text = "Inactive"
        Me.btnIN.UseVisualStyleBackColor = True
        '
        'dgOwner
        '
        Me.dgOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOwner.Location = New System.Drawing.Point(278, 12)
        Me.dgOwner.Name = "dgOwner"
        Me.dgOwner.Size = New System.Drawing.Size(301, 251)
        Me.dgOwner.TabIndex = 10
        '
        'owID
        '
        Me.owID.AutoSize = True
        Me.owID.Location = New System.Drawing.Point(41, 69)
        Me.owID.Name = "owID"
        Me.owID.Size = New System.Drawing.Size(24, 13)
        Me.owID.TabIndex = 11
        Me.owID.Text = "ID :"
        '
        'textID
        '
        Me.textID.Enabled = False
        Me.textID.Location = New System.Drawing.Point(82, 66)
        Me.textID.Name = "textID"
        Me.textID.Size = New System.Drawing.Size(100, 20)
        Me.textID.TabIndex = 12
        '
        'btnAC
        '
        Me.btnAC.Location = New System.Drawing.Point(401, 277)
        Me.btnAC.Name = "btnAC"
        Me.btnAC.Size = New System.Drawing.Size(86, 29)
        Me.btnAC.TabIndex = 13
        Me.btnAC.Text = "Active"
        Me.btnAC.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(188, 61)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(75, 29)
        Me.btnPlus.TabIndex = 14
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'frmPetOwner
        '
        Me.AcceptButton = Me.btnPersonAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 310)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnAC)
        Me.Controls.Add(Me.textID)
        Me.Controls.Add(Me.owID)
        Me.Controls.Add(Me.dgOwner)
        Me.Controls.Add(Me.btnIN)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPersonAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtOwnerName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPetOwner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgOwner, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOwnerName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnPersonAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnIN As Button
    Friend WithEvents dgOwner As DataGridView
    Friend WithEvents owID As Label
    Friend WithEvents textID As TextBox
    Friend WithEvents btnAC As Button
    Friend WithEvents btnPlus As Button
End Class
