﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RandomizedTextBoxUserId = New System.Windows.Forms.TextBox()
        Me.RandomizedTextBoxLicenseKey = New System.Windows.Forms.TextBox()
        Me.RandomizedMethodButtonGenerate = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 133)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(365, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Computer\HKEY_CURRENT_USER\SOFTWARE\AsyncRAT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Reg Path"
        '
        'RandomizedTextBoxUserId
        '
        Me.RandomizedTextBoxUserId.Location = New System.Drawing.Point(12, 6)
        Me.RandomizedTextBoxUserId.Name = "RandomizedTextBoxUserId"
        Me.RandomizedTextBoxUserId.Size = New System.Drawing.Size(365, 20)
        Me.RandomizedTextBoxUserId.TabIndex = 2
        '
        'RandomizedTextBoxLicenseKey
        '
        Me.RandomizedTextBoxLicenseKey.Location = New System.Drawing.Point(12, 43)
        Me.RandomizedTextBoxLicenseKey.Name = "RandomizedTextBoxLicenseKey"
        Me.RandomizedTextBoxLicenseKey.Size = New System.Drawing.Size(365, 20)
        Me.RandomizedTextBoxLicenseKey.TabIndex = 3
        '
        'RandomizedMethodButtonGenerate
        '
        Me.RandomizedMethodButtonGenerate.Location = New System.Drawing.Point(12, 90)
        Me.RandomizedMethodButtonGenerate.Name = "RandomizedMethodButtonGenerate"
        Me.RandomizedMethodButtonGenerate.Size = New System.Drawing.Size(365, 23)
        Me.RandomizedMethodButtonGenerate.TabIndex = 4
        Me.RandomizedMethodButtonGenerate.Text = "Generate Key"
        Me.RandomizedMethodButtonGenerate.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(12, 67)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton1.TabIndex = 5
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "3Losh"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(287, 69)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(72, 17)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RXRcode"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(109, 67)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(96, 17)
        Me.RadioButton3.TabIndex = 7
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "3Losh First Rat"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 165)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(88, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "@MONSTERMC"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 184)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RandomizedMethodButtonGenerate)
        Me.Controls.Add(Me.RandomizedTextBoxLicenseKey)
        Me.Controls.Add(Me.RandomizedTextBoxUserId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "3Losh Gen Key v3 By MONSTERMC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RandomizedTextBoxUserId As TextBox
    Friend WithEvents RandomizedTextBoxLicenseKey As TextBox
    Friend WithEvents RandomizedMethodButtonGenerate As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
