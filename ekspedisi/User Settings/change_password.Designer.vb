﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class change_password
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(change_password))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.repass = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.simpan = New DevExpress.XtraEditors.SimpleButton()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 16)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "Re-enter New Password :"
        '
        'repass
        '
        Me.repass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.repass.Location = New System.Drawing.Point(174, 56)
        Me.repass.Name = "repass"
        Me.repass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.repass.Size = New System.Drawing.Size(175, 22)
        Me.repass.TabIndex = 125
        '
        'pass
        '
        Me.pass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass.Location = New System.Drawing.Point(174, 29)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.pass.Size = New System.Drawing.Size(175, 22)
        Me.pass.TabIndex = 122
        '
        'simpan
        '
        Me.simpan.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.simpan.Appearance.Options.UseFont = True
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.Location = New System.Drawing.Point(169, 97)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(87, 26)
        Me.simpan.TabIndex = 126
        Me.simpan.Text = "Save"
        '
        'cancel
        '
        Me.cancel.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.Appearance.Options.UseFont = True
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(262, 97)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(87, 26)
        Me.cancel.TabIndex = 127
        Me.cancel.Text = "Cancel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(61, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 16)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "New Password :"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nama.Location = New System.Drawing.Point(171, 8)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(69, 16)
        Me.nama.TabIndex = 123
        Me.nama.Text = "nama user"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(88, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 16)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Username :"
        '
        'change_password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 135)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.repass)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nama)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "change_password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents repass As System.Windows.Forms.TextBox
    Friend WithEvents pass As System.Windows.Forms.TextBox
    Friend WithEvents simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nama As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
