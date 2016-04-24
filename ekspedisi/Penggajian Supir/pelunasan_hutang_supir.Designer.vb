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
        Me.bayar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nominal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tangggalkirim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.datapiutang = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.nomerdo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tanggaljatuhtempo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.daftarpiutang = New DevExpress.XtraGrid.GridControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.nomertelepon = New DevExpress.XtraEditors.LabelControl()
        Me.kotaasal = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.namakaryawan = New DevExpress.XtraEditors.ButtonEdit()
        Me.idkaryawan = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.TextEdit4 = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datapiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daftarpiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.namakaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'bayar
        '
        Me.bayar.Caption = "Bayar"
        Me.bayar.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.bayar.Name = "bayar"
        Me.bayar.Visible = True
        Me.bayar.VisibleIndex = 4
        '
        'nominal
        '
        Me.nominal.Caption = "Nominal"
        Me.nominal.Name = "nominal"
        Me.nominal.Visible = True
        Me.nominal.VisibleIndex = 4
        '
        'tangggalkirim
        '
        Me.tangggalkirim.Caption = "Tanggal Kirim"
        Me.tangggalkirim.Name = "tangggalkirim"
        Me.tangggalkirim.Visible = True
        Me.tangggalkirim.VisibleIndex = 3
        '
        'tanggal
        '
        Me.tanggal.Caption = "Tanggal & Jam"
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Visible = True
        Me.tanggal.VisibleIndex = 2
        '
        'datapiutang
        '
        Me.datapiutang.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomerdo, Me.tanggal, Me.tangggalkirim, Me.tanggaljatuhtempo, Me.nominal, Me.bayar})
        Me.datapiutang.GridControl = Me.daftarpiutang
        Me.datapiutang.Name = "datapiutang"
        Me.datapiutang.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.datapiutang.OptionsView.ShowGroupPanel = False
        '
        'nomerdo
        '
        Me.nomerdo.Caption = "Nomer DO"
        Me.nomerdo.Name = "nomerdo"
        Me.nomerdo.Visible = True
        Me.nomerdo.VisibleIndex = 0
        '
        'tanggaljatuhtempo
        '
        Me.tanggaljatuhtempo.Caption = "Tanggal Jatuh Tempo"
        Me.tanggaljatuhtempo.Name = "tanggaljatuhtempo"
        Me.tanggaljatuhtempo.Visible = True
        Me.tanggaljatuhtempo.VisibleIndex = 8
        '
        'daftarpiutang
        '
        Me.daftarpiutang.Location = New System.Drawing.Point(5, 24)
        Me.daftarpiutang.MainView = Me.datapiutang
        Me.daftarpiutang.Name = "daftarpiutang"
        Me.daftarpiutang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.daftarpiutang.Size = New System.Drawing.Size(743, 135)
        Me.daftarpiutang.TabIndex = 0
        Me.daftarpiutang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.datapiutang})
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.daftarpiutang)
        Me.GroupControl3.Location = New System.Drawing.Point(10, 352)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(758, 164)
        Me.GroupControl3.TabIndex = 153
        Me.GroupControl3.Text = "Daftar Piutang"
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(668, 522)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 152
        Me.cancel.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(560, 522)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 151
        Me.Submit.Text = "Submit"
        '
        'nomertelepon
        '
        Me.nomertelepon.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomertelepon.Location = New System.Drawing.Point(133, 96)
        Me.nomertelepon.Name = "nomertelepon"
        Me.nomertelepon.Size = New System.Drawing.Size(111, 18)
        Me.nomertelepon.TabIndex = 53
        Me.nomertelepon.Text = "Nomor Telepon :"
        '
        'kotaasal
        '
        Me.kotaasal.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kotaasal.Location = New System.Drawing.Point(133, 72)
        Me.kotaasal.Name = "kotaasal"
        Me.kotaasal.Size = New System.Drawing.Size(71, 18)
        Me.kotaasal.TabIndex = 52
        Me.kotaasal.Text = "Kota Asal :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(25, 96)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(101, 18)
        Me.LabelControl5.TabIndex = 50
        Me.LabelControl5.Text = "Nomor Telepon"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(65, 72)
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
        'idkaryawan
        '
        Me.idkaryawan.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idkaryawan.Location = New System.Drawing.Point(132, 24)
        Me.idkaryawan.Name = "idkaryawan"
        Me.idkaryawan.Size = New System.Drawing.Size(77, 18)
        Me.idkaryawan.TabIndex = 43
        Me.idkaryawan.Text = "id karyawan"
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
        Me.GroupControl1.Controls.Add(Me.nomertelepon)
        Me.GroupControl1.Controls.Add(Me.kotaasal)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.namakaryawan)
        Me.GroupControl1.Controls.Add(Me.idkaryawan)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(328, 120)
        Me.GroupControl1.TabIndex = 149
        Me.GroupControl1.Text = "Data Karyawan"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(8, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(408, 268)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.PictureBox1)
        Me.GroupControl2.Location = New System.Drawing.Point(344, 8)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(424, 298)
        Me.GroupControl2.TabIndex = 150
        Me.GroupControl2.Text = "Bukti Piutang"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(726, 312)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(42, 37)
        Me.SimpleButton2.TabIndex = 155
        '
        'TextEdit4
        '
        Me.TextEdit4.Enabled = False
        Me.TextEdit4.Location = New System.Drawing.Point(384, 320)
        Me.TextEdit4.Name = "TextEdit4"
        Me.TextEdit4.Size = New System.Drawing.Size(336, 20)
        Me.TextEdit4.TabIndex = 154
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(343, 319)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(29, 18)
        Me.LabelControl6.TabIndex = 54
        Me.LabelControl6.Text = "Path"
        '
        'pelunasan_hutang_supir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 553)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.TextEdit4)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.GroupControl2)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.TextEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nominal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tangggalkirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents datapiutang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents daftarpiutang As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents nomertelepon As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kotaasal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents namakaryawan As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents idkaryawan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tanggaljatuhtempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nomerdo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
