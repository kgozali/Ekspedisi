<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_mobil_sewa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_mobil_sewa))
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.warna = New DevExpress.XtraEditors.TextEdit()
        Me.tipemobil = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.nomorpolisi = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.simpan = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.tahun = New DevExpress.XtraEditors.TextEdit()
        Me.tanggal = New System.Windows.Forms.DateTimePicker()
        Me.simpanedit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.warna.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tipemobil.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nomorpolisi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.tahun.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(466, 207)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 8
        Me.cancel.Text = "Cancel"
        '
        'warna
        '
        Me.warna.Location = New System.Drawing.Point(89, 128)
        Me.warna.Name = "warna"
        Me.warna.Size = New System.Drawing.Size(336, 20)
        Me.warna.TabIndex = 4
        '
        'tipemobil
        '
        Me.tipemobil.Location = New System.Drawing.Point(89, 102)
        Me.tipemobil.Name = "tipemobil"
        Me.tipemobil.Size = New System.Drawing.Size(336, 20)
        Me.tipemobil.TabIndex = 3
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(41, 156)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(42, 18)
        Me.LabelControl9.TabIndex = 55
        Me.LabelControl9.Text = "Tahun"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(40, 130)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(43, 18)
        Me.LabelControl7.TabIndex = 53
        Me.LabelControl7.Text = "Warna"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(18, 104)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(65, 18)
        Me.LabelControl6.TabIndex = 52
        Me.LabelControl6.Text = "Tipe Mobil"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(5, 78)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(78, 18)
        Me.LabelControl5.TabIndex = 51
        Me.LabelControl5.Text = "Tanggal Beli"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(13, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(70, 18)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Kode Mobil"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(5, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(78, 18)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "Nomor Polisi"
        '
        'nomorpolisi
        '
        Me.nomorpolisi.Location = New System.Drawing.Point(89, 49)
        Me.nomorpolisi.Name = "nomorpolisi"
        Me.nomorpolisi.Size = New System.Drawing.Size(336, 20)
        Me.nomorpolisi.TabIndex = 1
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(89, 23)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(202, 20)
        Me.id.TabIndex = 45
        '
        'simpan
        '
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.Location = New System.Drawing.Point(360, 207)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(100, 27)
        Me.simpan.TabIndex = 7
        Me.simpan.Text = "Save"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.tahun)
        Me.GroupControl1.Controls.Add(Me.tanggal)
        Me.GroupControl1.Controls.Add(Me.warna)
        Me.GroupControl1.Controls.Add(Me.tipemobil)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.nomorpolisi)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(560, 189)
        Me.GroupControl1.TabIndex = 146
        Me.GroupControl1.Text = "Data"
        '
        'tahun
        '
        Me.tahun.Location = New System.Drawing.Point(89, 154)
        Me.tahun.Name = "tahun"
        Me.tahun.Size = New System.Drawing.Size(115, 20)
        Me.tahun.TabIndex = 5
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(89, 75)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(200, 21)
        Me.tanggal.TabIndex = 2
        '
        'simpanedit
        '
        Me.simpanedit.Image = CType(resources.GetObject("simpanedit.Image"), System.Drawing.Image)
        Me.simpanedit.Location = New System.Drawing.Point(360, 207)
        Me.simpanedit.Name = "simpanedit"
        Me.simpanedit.Size = New System.Drawing.Size(100, 27)
        Me.simpanedit.TabIndex = 6
        Me.simpanedit.Text = "Save"
        Me.simpanedit.Visible = False
        '
        'add_mobil_sewa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 246)
        Me.Controls.Add(Me.simpanedit)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "add_mobil_sewa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Mobil Sewa"
        CType(Me.warna.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tipemobil.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nomorpolisi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.tahun.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents warna As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tipemobil As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nomorpolisi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tahun As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents simpanedit As DevExpress.XtraEditors.SimpleButton
End Class
