﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.dgBreed = New System.Windows.Forms.DataGridView()
        Me.DEACT = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ACT = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.cdoType = New System.Windows.Forms.ComboBox()
        Me.btnPlus = New System.Windows.Forms.Button()
        CType(Me.dgBreed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pet Breed"
        '
        'txtBreed
        '
        Me.txtBreed.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtBreed.Location = New System.Drawing.Point(124, 140)
        Me.txtBreed.Name = "txtBreed"
        Me.txtBreed.Size = New System.Drawing.Size(181, 24)
        Me.txtBreed.TabIndex = 1
        Me.txtBreed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBreed
        '
        Me.btnBreed.Location = New System.Drawing.Point(121, 189)
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
        Me.Label2.Location = New System.Drawing.Point(29, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Pet Type"
        '
        'txtType
        '
        Me.txtType.Enabled = False
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txtType.Location = New System.Drawing.Point(400, -2)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(181, 24)
        Me.txtType.TabIndex = 4
        Me.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(216, 189)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(86, 29)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Cancel"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgBreed
        '
        Me.dgBreed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBreed.Location = New System.Drawing.Point(338, 28)
        Me.dgBreed.Name = "dgBreed"
        Me.dgBreed.Size = New System.Drawing.Size(240, 150)
        Me.dgBreed.TabIndex = 6
        '
        'DEACT
        '
        Me.DEACT.Location = New System.Drawing.Point(492, 185)
        Me.DEACT.Name = "DEACT"
        Me.DEACT.Size = New System.Drawing.Size(86, 29)
        Me.DEACT.TabIndex = 7
        Me.DEACT.Text = "inactive"
        Me.DEACT.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(69, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "ID"
        '
        'ACT
        '
        Me.ACT.Location = New System.Drawing.Point(400, 184)
        Me.ACT.Name = "ACT"
        Me.ACT.Size = New System.Drawing.Size(86, 29)
        Me.ACT.TabIndex = 10
        Me.ACT.Text = "Active"
        Me.ACT.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(124, 58)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 11
        '
        'cdoType
        '
        Me.cdoType.FormattingEnabled = True
        Me.cdoType.Location = New System.Drawing.Point(124, 104)
        Me.cdoType.Name = "cdoType"
        Me.cdoType.Size = New System.Drawing.Size(121, 21)
        Me.cdoType.TabIndex = 12
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(230, 56)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(75, 23)
        Me.btnPlus.TabIndex = 13
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'frmBreed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 254)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.cdoType)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.ACT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DEACT)
        Me.Controls.Add(Me.dgBreed)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBreed)
        Me.Controls.Add(Me.txtBreed)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBreed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgBreed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBreed As TextBox
    Friend WithEvents btnBreed As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtType As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents dgBreed As DataGridView
    Friend WithEvents DEACT As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ACT As Button
    Friend WithEvents txtID As TextBox
    Friend WithEvents cdoType As ComboBox
    Friend WithEvents btnPlus As Button
End Class
