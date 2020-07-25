<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBreed
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
        Me.txtBreed = New System.Windows.Forms.TextBox()
        Me.btnBreed = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pet Breed"
        '
        'txtBreed
        '
        Me.txtBreed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtBreed.Location = New System.Drawing.Point(140, 104)
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.Size = New System.Drawing.Size(181, 24)
        Me.txtBreed.TabIndex = 1
        Me.txtBreed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBreed
        '
        Me.btnBreed.Location = New System.Drawing.Point(140, 149)
        Me.btnBreed.Name = "btnBreed"
        Me.btnBreed.Size = New System.Drawing.Size(86, 29)
        Me.btnBreed.TabIndex = 2
        Me.btnBreed.Text = "Add"
        Me.btnBreed.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(55, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pet Type"
        '
        'txtType
        '
        Me.txtType.Enabled = False
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtType.Location = New System.Drawing.Point(140, 48)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(181, 24)
        Me.txtType.TabIndex = 4
        Me.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(232, 149)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(86, 29)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Cancel"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmBreed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 204)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBreed)
        Me.Controls.Add(Me.txtBreed)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBreed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents btnBreed As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents btnBack As Button
End Class
