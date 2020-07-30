<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPetType
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
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.btnType = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dgType = New System.Windows.Forms.DataGridView()
        Me.btnIN = New System.Windows.Forms.Button()
        Me.btnAC = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = " Pet Type "
        '
        'txtType
        '
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(107, 138)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(181, 24)
        Me.txtType.TabIndex = 1
        Me.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnType
        '
        Me.btnType.Location = New System.Drawing.Point(107, 189)
        Me.btnType.Name = "btnType"
        Me.btnType.Size = New System.Drawing.Size(86, 29)
        Me.btnType.TabIndex = 2
        Me.btnType.Text = "Add"
        Me.btnType.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(199, 189)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(86, 29)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Exit"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(62, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(107, 91)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 5
        '
        'dgType
        '
        Me.dgType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgType.Location = New System.Drawing.Point(315, 28)
        Me.dgType.Name = "dgType"
        Me.dgType.Size = New System.Drawing.Size(269, 236)
        Me.dgType.TabIndex = 6
        '
        'btnIN
        '
        Me.btnIN.Location = New System.Drawing.Point(499, 270)
        Me.btnIN.Name = "btnIN"
        Me.btnIN.Size = New System.Drawing.Size(86, 29)
        Me.btnIN.TabIndex = 7
        Me.btnIN.Text = "Inactive"
        Me.btnIN.UseVisualStyleBackColor = True
        '
        'btnAC
        '
        Me.btnAC.Location = New System.Drawing.Point(407, 270)
        Me.btnAC.Name = "btnAC"
        Me.btnAC.Size = New System.Drawing.Size(86, 29)
        Me.btnAC.TabIndex = 8
        Me.btnAC.Text = "Active"
        Me.btnAC.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(213, 88)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(75, 23)
        Me.btnPlus.TabIndex = 9
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(80, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Pet Type Information"
        '
        'frmPetType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.btnAC)
        Me.Controls.Add(Me.btnIN)
        Me.Controls.Add(Me.dgType)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnType)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPetType"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.dgType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents btnType As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents dgType As DataGridView
    Friend WithEvents btnIN As Button
    Friend WithEvents btnAC As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents Label3 As Label
End Class
