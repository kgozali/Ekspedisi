<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_truck
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_truck))
        Me.depresiasi = New System.Windows.Forms.ComboBox()
        Me.aktiva = New System.Windows.Forms.ComboBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.penyusutan = New System.Windows.Forms.ComboBox()
        Me.Cmbbxsupp = New System.Windows.Forms.ComboBox()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.hargabeli = New DevExpress.XtraEditors.TextEdit()
        Me.nilairesidu = New DevExpress.XtraEditors.TextEdit()
        Me.norangka = New DevExpress.XtraEditors.TextEdit()
        Me.nomesin = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.nop = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.simpan = New DevExpress.XtraEditors.SimpleButton()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.hargabeli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nilairesidu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.norangka.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nomesin.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nop.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'depresiasi
        '
        Me.depresiasi.FormattingEnabled = True
        Me.depresiasi.Location = New System.Drawing.Point(123, 238)
        Me.depresiasi.Name = "depresiasi"
        Me.depresiasi.Size = New System.Drawing.Size(121, 21)
        Me.depresiasi.TabIndex = 78
        '
        'aktiva
        '
        Me.aktiva.FormattingEnabled = True
        Me.aktiva.Location = New System.Drawing.Point(98, 190)
        Me.aktiva.Name = "aktiva"
        Me.aktiva.Size = New System.Drawing.Size(121, 21)
        Me.aktiva.TabIndex = 76
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.depresiasi)
        Me.GroupControl1.Controls.Add(Me.penyusutan)
        Me.GroupControl1.Controls.Add(Me.aktiva)
        Me.GroupControl1.Controls.Add(Me.Cmbbxsupp)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.LabelControl10)
        Me.GroupControl1.Controls.Add(Me.hargabeli)
        Me.GroupControl1.Controls.Add(Me.nilairesidu)
        Me.GroupControl1.Controls.Add(Me.norangka)
        Me.GroupControl1.Controls.Add(Me.nomesin)
        Me.GroupControl1.Controls.Add(Me.LabelControl9)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.nop)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(307, 270)
        Me.GroupControl1.TabIndex = 149
        Me.GroupControl1.Text = "Data"
        '
        'penyusutan
        '
        Me.penyusutan.FormattingEnabled = True
        Me.penyusutan.Location = New System.Drawing.Point(134, 214)
        Me.penyusutan.Name = "penyusutan"
        Me.penyusutan.Size = New System.Drawing.Size(121, 21)
        Me.penyusutan.TabIndex = 77
        '
        'Cmbbxsupp
        '
        Me.Cmbbxsupp.FormattingEnabled = True
        Me.Cmbbxsupp.Location = New System.Drawing.Point(114, 118)
        Me.Cmbbxsupp.Name = "Cmbbxsupp"
        Me.Cmbbxsupp.Size = New System.Drawing.Size(121, 21)
        Me.Cmbbxsupp.TabIndex = 6
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(5, 169)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(81, 18)
        Me.LabelControl13.TabIndex = 75
        Me.LabelControl13.Text = "Nilai Residu :"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(5, 217)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(123, 18)
        Me.LabelControl11.TabIndex = 71
        Me.LabelControl11.Text = "Akun Penyusutan :"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(5, 193)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(86, 18)
        Me.LabelControl10.TabIndex = 69
        Me.LabelControl10.Text = "Akun Aktiva :"
        '
        'hargabeli
        '
        Me.hargabeli.Location = New System.Drawing.Point(86, 143)
        Me.hargabeli.Name = "hargabeli"
        Me.hargabeli.Size = New System.Drawing.Size(143, 20)
        Me.hargabeli.TabIndex = 7
        '
        'nilairesidu
        '
        Me.nilairesidu.Location = New System.Drawing.Point(92, 167)
        Me.nilairesidu.Name = "nilairesidu"
        Me.nilairesidu.Size = New System.Drawing.Size(57, 20)
        Me.nilairesidu.TabIndex = 6
        '
        'norangka
        '
        Me.norangka.Location = New System.Drawing.Point(125, 95)
        Me.norangka.Name = "norangka"
        Me.norangka.Size = New System.Drawing.Size(165, 20)
        Me.norangka.TabIndex = 5
        '
        'nomesin
        '
        Me.nomesin.Location = New System.Drawing.Point(107, 71)
        Me.nomesin.Name = "nomesin"
        Me.nomesin.Size = New System.Drawing.Size(165, 20)
        Me.nomesin.TabIndex = 4
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(5, 145)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl9.TabIndex = 55
        Me.LabelControl9.Text = "Harga Beli :"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(5, 121)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(103, 18)
        Me.LabelControl8.TabIndex = 54
        Me.LabelControl8.Text = "Nama Supplier :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(5, 97)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(107, 18)
        Me.LabelControl7.TabIndex = 53
        Me.LabelControl7.Text = "Nomor Rangka :"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(5, 73)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(96, 18)
        Me.LabelControl6.TabIndex = 52
        Me.LabelControl6.Text = "Nomor Mesin :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(5, 241)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(112, 18)
        Me.LabelControl4.TabIndex = 48
        Me.LabelControl4.Text = "Akun Depresiasi :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 18)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "ID Truck:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(5, 48)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(88, 18)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "Nomor Polisi :"
        '
        'nop
        '
        Me.nop.Location = New System.Drawing.Point(99, 46)
        Me.nop.Name = "nop"
        Me.nop.Size = New System.Drawing.Size(143, 20)
        Me.nop.TabIndex = 2
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(74, 23)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 1
        '
        'simpan
        '
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.Location = New System.Drawing.Point(113, 288)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(100, 27)
        Me.simpan.TabIndex = 165
        Me.simpan.Text = "Save"
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(219, 288)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 164
        Me.cancel.Text = "Cancel"
        '
        'add_truck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 323)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "add_truck"
        Me.Text = "Tambah Truck"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.hargabeli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nilairesidu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.norangka.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nomesin.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nop.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents depresiasi As System.Windows.Forms.ComboBox
    Friend WithEvents aktiva As System.Windows.Forms.ComboBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents penyusutan As System.Windows.Forms.ComboBox
    Friend WithEvents Cmbbxsupp As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents hargabeli As DevExpress.XtraEditors.TextEdit
    Friend WithEvents nilairesidu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents norangka As DevExpress.XtraEditors.TextEdit
    Friend WithEvents nomesin As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nop As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
End Class
