<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_supplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_supplier))
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.kategori = New System.Windows.Forms.ComboBox()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.provinsi = New DevExpress.XtraEditors.TextEdit()
        Me.tel2 = New DevExpress.XtraEditors.TextEdit()
        Me.tel1 = New DevExpress.XtraEditors.TextEdit()
        Me.email = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.alamat = New System.Windows.Forms.RichTextBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.nama = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.simpan = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.kota = New System.Windows.Forms.ComboBox()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.provinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tel2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tel1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.email.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(4, 196)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(117, 18)
        Me.LabelControl13.TabIndex = 75
        Me.LabelControl13.Text = "Kategori Supplier :"
        '
        'kategori
        '
        Me.kategori.FormattingEnabled = True
        Me.kategori.Location = New System.Drawing.Point(129, 193)
        Me.kategori.Name = "kategori"
        Me.kategori.Size = New System.Drawing.Size(335, 21)
        Me.kategori.TabIndex = 10
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(397, 322)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 147
        Me.cancel.Text = "Cancel"
        '
        'provinsi
        '
        Me.provinsi.Enabled = False
        Me.provinsi.Location = New System.Drawing.Point(129, 170)
        Me.provinsi.Name = "provinsi"
        Me.provinsi.Size = New System.Drawing.Size(336, 20)
        Me.provinsi.TabIndex = 64
        '
        'tel2
        '
        Me.tel2.Location = New System.Drawing.Point(128, 119)
        Me.tel2.Name = "tel2"
        Me.tel2.Size = New System.Drawing.Size(336, 20)
        Me.tel2.TabIndex = 63
        '
        'tel1
        '
        Me.tel1.Location = New System.Drawing.Point(128, 95)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(336, 20)
        Me.tel1.TabIndex = 62
        '
        'email
        '
        Me.email.Location = New System.Drawing.Point(128, 71)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(336, 20)
        Me.email.TabIndex = 61
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(63, 169)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(58, 18)
        Me.LabelControl8.TabIndex = 54
        Me.LabelControl8.Text = "Provinsi :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(46, 118)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl7.TabIndex = 53
        Me.LabelControl7.Text = "Telepon 2 :"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(46, 94)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl6.TabIndex = 52
        Me.LabelControl6.Text = "Telepon 1 :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(78, 70)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(43, 18)
        Me.LabelControl5.TabIndex = 51
        Me.LabelControl5.Text = "Email :"
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(128, 219)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(337, 70)
        Me.alamat.TabIndex = 65
        Me.alamat.Text = ""
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(66, 218)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 18)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Alamat :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(24, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(97, 18)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Kode Supplier :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(18, 45)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(103, 18)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "Nama Supplier :"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(129, 46)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(335, 20)
        Me.nama.TabIndex = 46
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(129, 23)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(202, 20)
        Me.id.TabIndex = 45
        '
        'simpan
        '
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.Location = New System.Drawing.Point(291, 322)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(100, 27)
        Me.simpan.TabIndex = 148
        Me.simpan.Text = "Save"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.kota)
        Me.GroupControl1.Controls.Add(Me.provinsi)
        Me.GroupControl1.Controls.Add(Me.tel2)
        Me.GroupControl1.Controls.Add(Me.kategori)
        Me.GroupControl1.Controls.Add(Me.tel1)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.email)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.alamat)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.nama)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(485, 304)
        Me.GroupControl1.TabIndex = 146
        Me.GroupControl1.Text = "Data"
        '
        'kota
        '
        Me.kota.FormattingEnabled = True
        Me.kota.Location = New System.Drawing.Point(129, 144)
        Me.kota.Name = "kota"
        Me.kota.Size = New System.Drawing.Size(335, 21)
        Me.kota.TabIndex = 76
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(81, 143)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(40, 18)
        Me.LabelControl9.TabIndex = 55
        Me.LabelControl9.Text = "Kota :"
        '
        'add_supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 360)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "add_supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Supplier"
        CType(Me.provinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tel2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tel1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.email.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kategori As System.Windows.Forms.ComboBox
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents provinsi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tel2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tel1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents email As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents alamat As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents kota As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
End Class
