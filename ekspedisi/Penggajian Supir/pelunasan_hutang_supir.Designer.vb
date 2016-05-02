<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pelunasan_hutang_supir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pelunasan_hutang_supir))
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.datapiutang = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.daftarpiutang = New DevExpress.XtraGrid.GridControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.namakaryawan = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.idkaryawan = New System.Windows.Forms.TextBox()
        Me.nomertelepon = New System.Windows.Forms.TextBox()
        Me.kotaasal = New System.Windows.Forms.TextBox()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.tanggalpembayaran = New System.Windows.Forms.DateTimePicker()
        Me.totaldibayar = New System.Windows.Forms.TextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.namaakun = New System.Windows.Forms.ComboBox()
        Me.totalhutang = New System.Windows.Forms.TextBox()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datapiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daftarpiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.namakaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'datapiutang
        '
        Me.datapiutang.GridControl = Me.daftarpiutang
        Me.datapiutang.Name = "datapiutang"
        Me.datapiutang.OptionsView.ShowGroupPanel = False
        '
        'daftarpiutang
        '
        Me.daftarpiutang.Location = New System.Drawing.Point(5, 24)
        Me.daftarpiutang.MainView = Me.datapiutang
        Me.daftarpiutang.Name = "daftarpiutang"
        Me.daftarpiutang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.daftarpiutang.Size = New System.Drawing.Size(787, 128)
        Me.daftarpiutang.TabIndex = 0
        Me.daftarpiutang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.datapiutang})
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.daftarpiutang)
        Me.GroupControl3.Location = New System.Drawing.Point(8, 88)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(800, 160)
        Me.GroupControl3.TabIndex = 153
        Me.GroupControl3.Text = "Daftar Hutang"
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(700, 342)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 152
        Me.cancel.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(592, 342)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 151
        Me.Submit.Text = "Submit"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(536, 48)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(101, 18)
        Me.LabelControl5.TabIndex = 50
        Me.LabelControl5.Text = "Nomor Telepon"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(576, 24)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(61, 18)
        Me.LabelControl4.TabIndex = 49
        Me.LabelControl4.Text = "Kota Asal"
        '
        'namakaryawan
        '
        Me.namakaryawan.Location = New System.Drawing.Point(132, 46)
        Me.namakaryawan.Name = "namakaryawan"
        Me.namakaryawan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.namakaryawan.Size = New System.Drawing.Size(191, 20)
        Me.namakaryawan.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(41, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 18)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "ID Karyawan"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(18, 48)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(108, 18)
        Me.LabelControl2.TabIndex = 37
        Me.LabelControl2.Text = "Nama Karyawan"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.idkaryawan)
        Me.GroupControl1.Controls.Add(Me.nomertelepon)
        Me.GroupControl1.Controls.Add(Me.kotaasal)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.namakaryawan)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(800, 72)
        Me.GroupControl1.TabIndex = 149
        Me.GroupControl1.Text = "Data Karyawan"
        '
        'idkaryawan
        '
        Me.idkaryawan.Enabled = False
        Me.idkaryawan.Location = New System.Drawing.Point(132, 21)
        Me.idkaryawan.Name = "idkaryawan"
        Me.idkaryawan.Size = New System.Drawing.Size(149, 21)
        Me.idkaryawan.TabIndex = 56
        '
        'nomertelepon
        '
        Me.nomertelepon.Enabled = False
        Me.nomertelepon.Location = New System.Drawing.Point(643, 45)
        Me.nomertelepon.Name = "nomertelepon"
        Me.nomertelepon.Size = New System.Drawing.Size(149, 21)
        Me.nomertelepon.TabIndex = 55
        '
        'kotaasal
        '
        Me.kotaasal.Enabled = False
        Me.kotaasal.Location = New System.Drawing.Point(643, 21)
        Me.kotaasal.Name = "kotaasal"
        Me.kotaasal.Size = New System.Drawing.Size(149, 21)
        Me.kotaasal.TabIndex = 54
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.tanggalpembayaran)
        Me.GroupControl4.Controls.Add(Me.totaldibayar)
        Me.GroupControl4.Controls.Add(Me.LabelControl3)
        Me.GroupControl4.Controls.Add(Me.namaakun)
        Me.GroupControl4.Controls.Add(Me.totalhutang)
        Me.GroupControl4.Controls.Add(Me.LabelControl12)
        Me.GroupControl4.Controls.Add(Me.LabelControl9)
        Me.GroupControl4.Controls.Add(Me.LabelControl7)
        Me.GroupControl4.Location = New System.Drawing.Point(8, 254)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(792, 82)
        Me.GroupControl4.TabIndex = 150
        Me.GroupControl4.Text = "Pembayaran"
        '
        'tanggalpembayaran
        '
        Me.tanggalpembayaran.Location = New System.Drawing.Point(160, 54)
        Me.tanggalpembayaran.Name = "tanggalpembayaran"
        Me.tanggalpembayaran.Size = New System.Drawing.Size(200, 21)
        Me.tanggalpembayaran.TabIndex = 161
        '
        'totaldibayar
        '
        Me.totaldibayar.Enabled = False
        Me.totaldibayar.Location = New System.Drawing.Point(613, 54)
        Me.totaldibayar.Name = "totaldibayar"
        Me.totaldibayar.Size = New System.Drawing.Size(174, 21)
        Me.totaldibayar.TabIndex = 159
        Me.totaldibayar.Text = "0"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(10, 57)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(139, 18)
        Me.LabelControl3.TabIndex = 160
        Me.LabelControl3.Text = "Tanggal Pembayaran"
        '
        'namaakun
        '
        Me.namaakun.FormattingEnabled = True
        Me.namaakun.Location = New System.Drawing.Point(160, 29)
        Me.namaakun.Name = "namaakun"
        Me.namaakun.Size = New System.Drawing.Size(184, 21)
        Me.namaakun.TabIndex = 38
        '
        'totalhutang
        '
        Me.totalhutang.Enabled = False
        Me.totalhutang.Location = New System.Drawing.Point(613, 29)
        Me.totalhutang.Name = "totalhutang"
        Me.totalhutang.Size = New System.Drawing.Size(174, 21)
        Me.totalhutang.TabIndex = 156
        Me.totalhutang.Text = "0"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Location = New System.Drawing.Point(73, 32)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(76, 18)
        Me.LabelControl12.TabIndex = 37
        Me.LabelControl12.Text = "Nama Akun"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(470, 57)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(132, 18)
        Me.LabelControl9.TabIndex = 158
        Me.LabelControl9.Text = "Total Nominal Bayar"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(461, 32)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(141, 18)
        Me.LabelControl7.TabIndex = 157
        Me.LabelControl7.Text = "Total Nominal Hutang"
        '
        'pelunasan_hutang_supir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 375)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "pelunasan_hutang_supir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pelunasan Hutang Karyawan"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datapiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daftarpiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.namakaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents datapiutang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents daftarpiutang As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents namakaryawan As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents namaakun As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents totaldibayar As System.Windows.Forms.TextBox
    Friend WithEvents totalhutang As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tanggalpembayaran As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nomertelepon As System.Windows.Forms.TextBox
    Friend WithEvents kotaasal As System.Windows.Forms.TextBox
    Friend WithEvents idkaryawan As System.Windows.Forms.TextBox
End Class
