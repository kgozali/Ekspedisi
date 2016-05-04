<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_pelunasan_karyawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_pelunasan_karyawan))
        Me.totalhutang = New System.Windows.Forms.TextBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.totalbayar = New System.Windows.Forms.TextBox()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.daftarutang = New DevExpress.XtraGrid.GridControl()
        Me.datapiutang = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.namakaryawan = New System.Windows.Forms.TextBox()
        Me.nomortelepon = New System.Windows.Forms.TextBox()
        Me.kotaasal = New System.Windows.Forms.TextBox()
        Me.jabatan = New System.Windows.Forms.TextBox()
        Me.idkaryawan = New System.Windows.Forms.TextBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.daftarutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datapiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'totalhutang
        '
        Me.totalhutang.Enabled = False
        Me.totalhutang.Location = New System.Drawing.Point(800, 582)
        Me.totalhutang.Name = "totalhutang"
        Me.totalhutang.Size = New System.Drawing.Size(191, 21)
        Me.totalhutang.TabIndex = 161
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(709, 585)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(85, 18)
        Me.LabelControl7.TabIndex = 160
        Me.LabelControl7.Text = "Total Hutang"
        '
        'totalbayar
        '
        Me.totalbayar.Enabled = False
        Me.totalbayar.Location = New System.Drawing.Point(800, 606)
        Me.totalbayar.Name = "totalbayar"
        Me.totalbayar.Size = New System.Drawing.Size(191, 21)
        Me.totalbayar.TabIndex = 157
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(718, 609)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(76, 18)
        Me.LabelControl6.TabIndex = 156
        Me.LabelControl6.Text = "Total Bayar"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.daftarutang)
        Me.GroupControl3.Location = New System.Drawing.Point(9, 114)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(980, 465)
        Me.GroupControl3.TabIndex = 159
        Me.GroupControl3.Text = "Daftar Piutang"
        '
        'daftarutang
        '
        Me.daftarutang.Location = New System.Drawing.Point(8, 24)
        Me.daftarutang.MainView = Me.datapiutang
        Me.daftarutang.Name = "daftarutang"
        Me.daftarutang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.daftarutang.Size = New System.Drawing.Size(967, 433)
        Me.daftarutang.TabIndex = 0
        Me.daftarutang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.datapiutang})
        '
        'datapiutang
        '
        Me.datapiutang.GridControl = Me.daftarutang
        Me.datapiutang.Name = "datapiutang"
        Me.datapiutang.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.namakaryawan)
        Me.GroupControl1.Controls.Add(Me.nomortelepon)
        Me.GroupControl1.Controls.Add(Me.kotaasal)
        Me.GroupControl1.Controls.Add(Me.jabatan)
        Me.GroupControl1.Controls.Add(Me.idkaryawan)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(9, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(980, 96)
        Me.GroupControl1.TabIndex = 158
        Me.GroupControl1.Text = "Data Karyawan"
        '
        'namakaryawan
        '
        Me.namakaryawan.Enabled = False
        Me.namakaryawan.Location = New System.Drawing.Point(128, 23)
        Me.namakaryawan.Name = "namakaryawan"
        Me.namakaryawan.Size = New System.Drawing.Size(191, 21)
        Me.namakaryawan.TabIndex = 66
        '
        'nomortelepon
        '
        Me.nomortelepon.Enabled = False
        Me.nomortelepon.Location = New System.Drawing.Point(775, 45)
        Me.nomortelepon.Name = "nomortelepon"
        Me.nomortelepon.Size = New System.Drawing.Size(191, 21)
        Me.nomortelepon.TabIndex = 63
        '
        'kotaasal
        '
        Me.kotaasal.Enabled = False
        Me.kotaasal.Location = New System.Drawing.Point(775, 21)
        Me.kotaasal.Name = "kotaasal"
        Me.kotaasal.Size = New System.Drawing.Size(191, 21)
        Me.kotaasal.TabIndex = 62
        '
        'jabatan
        '
        Me.jabatan.Enabled = False
        Me.jabatan.Location = New System.Drawing.Point(128, 69)
        Me.jabatan.Name = "jabatan"
        Me.jabatan.Size = New System.Drawing.Size(191, 21)
        Me.jabatan.TabIndex = 61
        '
        'idkaryawan
        '
        Me.idkaryawan.Enabled = False
        Me.idkaryawan.Location = New System.Drawing.Point(128, 45)
        Me.idkaryawan.Name = "idkaryawan"
        Me.idkaryawan.Size = New System.Drawing.Size(191, 21)
        Me.idkaryawan.TabIndex = 60
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(660, 48)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(101, 18)
        Me.LabelControl5.TabIndex = 56
        Me.LabelControl5.Text = "Nomor Telepon"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(700, 24)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(61, 18)
        Me.LabelControl4.TabIndex = 55
        Me.LabelControl4.Text = "Kota Asal"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(65, 72)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(51, 18)
        Me.LabelControl3.TabIndex = 54
        Me.LabelControl3.Text = "Jabatan"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 48)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(102, 18)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "Kode Karyawan"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(8, 24)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(108, 18)
        Me.LabelControl2.TabIndex = 37
        Me.LabelControl2.Text = "Nama Karyawan"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(891, 633)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 163
        Me.SimpleButton1.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(785, 633)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 162
        Me.Submit.Text = "Submit"
        '
        'edit_pelunasan_karyawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 664)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.totalhutang)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.totalbayar)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "edit_pelunasan_karyawan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Pelunasan Karyawan"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.daftarutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datapiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents totalhutang As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents totalbayar As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents daftarutang As DevExpress.XtraGrid.GridControl
    Friend WithEvents datapiutang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nomortelepon As System.Windows.Forms.TextBox
    Friend WithEvents kotaasal As System.Windows.Forms.TextBox
    Friend WithEvents jabatan As System.Windows.Forms.TextBox
    Friend WithEvents idkaryawan As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents namakaryawan As System.Windows.Forms.TextBox
End Class
