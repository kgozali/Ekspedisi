<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tambah_master_sewa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tambah_master_sewa))
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.save = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.nomortelepon = New System.Windows.Forms.TextBox()
        Me.kota = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.namakaryawan = New System.Windows.Forms.TextBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.idkaryawan = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.id = New System.Windows.Forms.RadioButton()
        Me.nama = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl2.SuspendLayout
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.idkaryawan.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl3.SuspendLayout
        CType(Me.cari.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"),System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(916, 562)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 179
        Me.cancel.Text = "Cancel"
        '
        'save
        '
        Me.save.Image = CType(resources.GetObject("save.Image"),System.Drawing.Image)
        Me.save.Location = New System.Drawing.Point(810, 562)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(100, 27)
        Me.save.TabIndex = 178
        Me.save.Text = "Save"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 193)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(1004, 358)
        Me.GroupControl2.TabIndex = 177
        Me.GroupControl2.Text = "Data Sewa Mobil"
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 21)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1000, 335)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.nomortelepon)
        Me.GroupControl1.Controls.Add(Me.kota)
        Me.GroupControl1.Controls.Add(Me.email)
        Me.GroupControl1.Controls.Add(Me.namakaryawan)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.idkaryawan)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1004, 95)
        Me.GroupControl1.TabIndex = 176
        Me.GroupControl1.Text = "Data Customer"
        '
        'nomortelepon
        '
        Me.nomortelepon.Enabled = false
        Me.nomortelepon.Location = New System.Drawing.Point(807, 46)
        Me.nomortelepon.Name = "nomortelepon"
        Me.nomortelepon.Size = New System.Drawing.Size(191, 21)
        Me.nomortelepon.TabIndex = 73
        '
        'kota
        '
        Me.kota.Enabled = false
        Me.kota.Location = New System.Drawing.Point(807, 22)
        Me.kota.Name = "kota"
        Me.kota.Size = New System.Drawing.Size(191, 21)
        Me.kota.TabIndex = 72
        '
        'email
        '
        Me.email.Enabled = false
        Me.email.Location = New System.Drawing.Point(125, 69)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(191, 21)
        Me.email.TabIndex = 71
        '
        'namakaryawan
        '
        Me.namakaryawan.Enabled = false
        Me.namakaryawan.Location = New System.Drawing.Point(125, 45)
        Me.namakaryawan.Name = "namakaryawan"
        Me.namakaryawan.Size = New System.Drawing.Size(191, 21)
        Me.namakaryawan.TabIndex = 70
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(692, 47)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(101, 18)
        Me.LabelControl5.TabIndex = 69
        Me.LabelControl5.Text = "Nomor Telepon"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(763, 23)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(30, 18)
        Me.LabelControl4.TabIndex = 68
        Me.LabelControl4.Text = "Kota"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(79, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(33, 18)
        Me.LabelControl3.TabIndex = 67
        Me.LabelControl3.Text = "Email"
        '
        'idkaryawan
        '
        Me.idkaryawan.Location = New System.Drawing.Point(125, 24)
        Me.idkaryawan.Name = "idkaryawan"
        Me.idkaryawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.idkaryawan.Size = New System.Drawing.Size(191, 20)
        Me.idkaryawan.TabIndex = 64
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(11, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(101, 18)
        Me.LabelControl1.TabIndex = 65
        Me.LabelControl1.Text = "Kode Customer"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(5, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(107, 18)
        Me.LabelControl2.TabIndex = 66
        Me.LabelControl2.Text = "Nama Customer"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.id)
        Me.GroupControl3.Controls.Add(Me.nama)
        Me.GroupControl3.Controls.Add(Me.cari)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 113)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(263, 74)
        Me.GroupControl3.TabIndex = 181
        Me.GroupControl3.Text = "Cari Berdasarkan"
        '
        'id
        '
        Me.id.AutoSize = true
        Me.id.Location = New System.Drawing.Point(5, 24)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(76, 17)
        Me.id.TabIndex = 3
        Me.id.Text = "Kode Mobil"
        Me.id.UseVisualStyleBackColor = true
        '
        'nama
        '
        Me.nama.AutoSize = true
        Me.nama.Checked = true
        Me.nama.Location = New System.Drawing.Point(87, 24)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(82, 17)
        Me.nama.TabIndex = 2
        Me.nama.TabStop = true
        Me.nama.Text = "Nomor Polisi"
        Me.nama.UseVisualStyleBackColor = true
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(5, 47)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(253, 20)
        Me.cari.TabIndex = 0
        '
        'tambah_master_sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1023, 596)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "tambah_master_sewa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Data Sewa"
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl2.ResumeLayout(false)
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        Me.GroupControl1.PerformLayout
        CType(Me.idkaryawan.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl3,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl3.ResumeLayout(false)
        Me.GroupControl3.PerformLayout
        CType(Me.cari.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nomortelepon As System.Windows.Forms.TextBox
    Friend WithEvents kota As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents namakaryawan As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents idkaryawan As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents id As System.Windows.Forms.RadioButton
    Friend WithEvents nama As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
End Class
