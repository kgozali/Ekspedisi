<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edi_buka_piutang_karyawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edi_buka_piutang_karyawan))
        Me.tanggalpelunasan = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.harilunas = New System.Windows.Forms.ComboBox()
        Me.keterangan = New System.Windows.Forms.RichTextBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.idkaryawan = New System.Windows.Forms.TextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.pilihkaryawan = New System.Windows.Forms.ComboBox()
        Me.akunkas = New System.Windows.Forms.ComboBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.nominal = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.tanggalpiutang = New System.Windows.Forms.DateTimePicker()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tanggalpelunasan
        '
        Me.tanggalpelunasan.Location = New System.Drawing.Point(197, 293)
        Me.tanggalpelunasan.Name = "tanggalpelunasan"
        Me.tanggalpelunasan.Size = New System.Drawing.Size(200, 21)
        Me.tanggalpelunasan.TabIndex = 174
        Me.tanggalpelunasan.Visible = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(256, 99)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(25, 18)
        Me.LabelControl8.TabIndex = 163
        Me.LabelControl8.Text = "Hari"
        '
        'harilunas
        '
        Me.harilunas.FormattingEnabled = True
        Me.harilunas.Location = New System.Drawing.Point(176, 96)
        Me.harilunas.Name = "harilunas"
        Me.harilunas.Size = New System.Drawing.Size(72, 21)
        Me.harilunas.TabIndex = 162
        '
        'keterangan
        '
        Me.keterangan.Location = New System.Drawing.Point(175, 174)
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Size = New System.Drawing.Size(270, 96)
        Me.keterangan.TabIndex = 160
        Me.keterangan.Text = ""
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(84, 174)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl7.TabIndex = 159
        Me.LabelControl7.Text = "Keterangan"
        '
        'idkaryawan
        '
        Me.idkaryawan.Location = New System.Drawing.Point(17, 293)
        Me.idkaryawan.Name = "idkaryawan"
        Me.idkaryawan.Size = New System.Drawing.Size(164, 21)
        Me.idkaryawan.TabIndex = 173
        Me.idkaryawan.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.pilihkaryawan)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.harilunas)
        Me.GroupControl1.Controls.Add(Me.keterangan)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.akunkas)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.nominal)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Controls.Add(Me.tanggalpiutang)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(450, 275)
        Me.GroupControl1.TabIndex = 168
        Me.GroupControl1.Text = "Data Piutang"
        '
        'pilihkaryawan
        '
        Me.pilihkaryawan.FormattingEnabled = True
        Me.pilihkaryawan.Location = New System.Drawing.Point(175, 49)
        Me.pilihkaryawan.Name = "pilihkaryawan"
        Me.pilihkaryawan.Size = New System.Drawing.Size(200, 21)
        Me.pilihkaryawan.TabIndex = 164
        '
        'akunkas
        '
        Me.akunkas.FormattingEnabled = True
        Me.akunkas.Location = New System.Drawing.Point(175, 121)
        Me.akunkas.Name = "akunkas"
        Me.akunkas.Size = New System.Drawing.Size(200, 21)
        Me.akunkas.TabIndex = 158
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 28)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(154, 18)
        Me.LabelControl1.TabIndex = 34
        Me.LabelControl1.Text = "Kode Piutang Karyawan"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(98, 124)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(61, 18)
        Me.LabelControl5.TabIndex = 146
        Me.LabelControl5.Text = "Akun Kas"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(51, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(108, 18)
        Me.LabelControl2.TabIndex = 35
        Me.LabelControl2.Text = "Nama Karyawan"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(55, 76)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(104, 18)
        Me.LabelControl3.TabIndex = 36
        Me.LabelControl3.Text = "Tanggal Piutang"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(58, 150)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(101, 18)
        Me.LabelControl4.TabIndex = 37
        Me.LabelControl4.Text = "Jumlah Nominal"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(72, 100)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(87, 18)
        Me.LabelControl6.TabIndex = 39
        Me.LabelControl6.Text = "Jatuh Tempo"
        '
        'nominal
        '
        Me.nominal.Location = New System.Drawing.Point(175, 147)
        Me.nominal.Name = "nominal"
        Me.nominal.Size = New System.Drawing.Size(200, 21)
        Me.nominal.TabIndex = 5
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(175, 25)
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Size = New System.Drawing.Size(162, 21)
        Me.id.TabIndex = 1
        '
        'tanggalpiutang
        '
        Me.tanggalpiutang.Location = New System.Drawing.Point(175, 73)
        Me.tanggalpiutang.Name = "tanggalpiutang"
        Me.tanggalpiutang.Size = New System.Drawing.Size(200, 21)
        Me.tanggalpiutang.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(362, 293)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 167
        Me.SimpleButton1.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(260, 293)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 166
        Me.Submit.Text = "Submit"
        '
        'edi_buka_piutang_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 331)
        Me.Controls.Add(Me.tanggalpelunasan)
        Me.Controls.Add(Me.idkaryawan)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Submit)
        Me.Name = "edi_buka_piutang_karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Piutang Karyawan"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tanggalpelunasan As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents harilunas As System.Windows.Forms.ComboBox
    Friend WithEvents keterangan As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents idkaryawan As System.Windows.Forms.TextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents akunkas As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nominal As System.Windows.Forms.TextBox
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents tanggalpiutang As System.Windows.Forms.DateTimePicker
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pilihkaryawan As System.Windows.Forms.ComboBox
End Class
