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
        Me.sisa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.bayar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nominal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tangggalkirim = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tanggal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.booking = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.datapiutang = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.nominalbayar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.nomertelepon = New DevExpress.XtraEditors.LabelControl()
        Me.kotaasal = New DevExpress.XtraEditors.LabelControl()
        Me.jabatan = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.idpiutang = New DevExpress.XtraEditors.ButtonEdit()
        Me.namakaryawan = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.tanggaljatuhtempo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nomerdo = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datapiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.idpiutang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'sisa
        '
        Me.sisa.Caption = "Sisa"
        Me.sisa.Name = "sisa"
        Me.sisa.Visible = True
        Me.sisa.VisibleIndex = 6
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
        Me.bayar.VisibleIndex = 5
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
        'booking
        '
        Me.booking.Caption = "ID Booking"
        Me.booking.Name = "booking"
        Me.booking.Visible = True
        Me.booking.VisibleIndex = 1
        '
        'datapiutang
        '
        Me.datapiutang.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomerdo, Me.booking, Me.tanggal, Me.tangggalkirim, Me.tanggaljatuhtempo, Me.nominal, Me.bayar, Me.nominalbayar, Me.sisa})
        Me.datapiutang.GridControl = Me.GridControl1
        Me.datapiutang.Name = "datapiutang"
        '
        'nominalbayar
        '
        Me.nominalbayar.Caption = "Nominal Bayar"
        Me.nominalbayar.Name = "nominalbayar"
        Me.nominalbayar.Visible = True
        Me.nominalbayar.VisibleIndex = 7
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(5, 24)
        Me.GridControl1.MainView = Me.datapiutang
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(743, 135)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.datapiutang})
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 316)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(758, 164)
        Me.GroupControl3.TabIndex = 153
        Me.GroupControl3.Text = "Daftar Piutang"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(670, 486)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 152
        Me.SimpleButton1.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(564, 486)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 151
        Me.Submit.Text = "Submit"
        '
        'nomertelepon
        '
        Me.nomertelepon.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomertelepon.Location = New System.Drawing.Point(310, 121)
        Me.nomertelepon.Name = "nomertelepon"
        Me.nomertelepon.Size = New System.Drawing.Size(111, 18)
        Me.nomertelepon.TabIndex = 53
        Me.nomertelepon.Text = "Nomor Telepon :"
        '
        'kotaasal
        '
        Me.kotaasal.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.kotaasal.Location = New System.Drawing.Point(270, 97)
        Me.kotaasal.Name = "kotaasal"
        Me.kotaasal.Size = New System.Drawing.Size(71, 18)
        Me.kotaasal.TabIndex = 52
        Me.kotaasal.Text = "Kota Asal :"
        '
        'jabatan
        '
        Me.jabatan.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jabatan.Location = New System.Drawing.Point(260, 73)
        Me.jabatan.Name = "jabatan"
        Me.jabatan.Size = New System.Drawing.Size(61, 18)
        Me.jabatan.TabIndex = 51
        Me.jabatan.Text = "Jabatan :"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(193, 121)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(111, 18)
        Me.LabelControl5.TabIndex = 50
        Me.LabelControl5.Text = "Nomor Telepon :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(193, 97)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(71, 18)
        Me.LabelControl4.TabIndex = 49
        Me.LabelControl4.Text = "Kota Asal :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(193, 73)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 18)
        Me.LabelControl3.TabIndex = 48
        Me.LabelControl3.Text = "Jabatan :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(5, 25)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(182, 268)
        Me.PictureBox2.TabIndex = 47
        Me.PictureBox2.TabStop = False
        '
        'idpiutang
        '
        Me.idpiutang.Location = New System.Drawing.Point(294, 23)
        Me.idpiutang.Name = "idpiutang"
        Me.idpiutang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.idpiutang.Size = New System.Drawing.Size(191, 20)
        Me.idpiutang.TabIndex = 1
        '
        'namakaryawan
        '
        Me.namakaryawan.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namakaryawan.Location = New System.Drawing.Point(317, 49)
        Me.namakaryawan.Name = "namakaryawan"
        Me.namakaryawan.Size = New System.Drawing.Size(104, 18)
        Me.namakaryawan.TabIndex = 43
        Me.namakaryawan.Text = "nama karyawan"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(193, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(95, 18)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "ID Karyawan :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(193, 49)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(118, 18)
        Me.LabelControl2.TabIndex = 37
        Me.LabelControl2.Text = "Nama Karyawan :"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.nomertelepon)
        Me.GroupControl1.Controls.Add(Me.kotaasal)
        Me.GroupControl1.Controls.Add(Me.jabatan)
        Me.GroupControl1.Controls.Add(Me.LabelControl5)
        Me.GroupControl1.Controls.Add(Me.LabelControl4)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.PictureBox2)
        Me.GroupControl1.Controls.Add(Me.idpiutang)
        Me.GroupControl1.Controls.Add(Me.namakaryawan)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Location = New System.Drawing.Point(275, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(495, 298)
        Me.GroupControl1.TabIndex = 149
        Me.GroupControl1.Text = "Data Karyawan"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(5, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(245, 268)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.PictureBox1)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(257, 298)
        Me.GroupControl2.TabIndex = 150
        Me.GroupControl2.Text = "Bukti Piutang"
        '
        'tanggaljatuhtempo
        '
        Me.tanggaljatuhtempo.Caption = "Tanggal Jatuh Tempo"
        Me.tanggaljatuhtempo.Name = "tanggaljatuhtempo"
        Me.tanggaljatuhtempo.Visible = True
        Me.tanggaljatuhtempo.VisibleIndex = 8
        '
        'nomerdo
        '
        Me.nomerdo.Caption = "Nomer DO"
        Me.nomerdo.Name = "nomerdo"
        Me.nomerdo.Visible = True
        Me.nomerdo.VisibleIndex = 0
        '
        'pelunasan_hutang_supir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 521)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "pelunasan_hutang_supir"
        Me.Text = "Pelunasan Hutang Karyawan"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datapiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.idpiutang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents bayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nominal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tangggalkirim As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tanggal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents booking As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents datapiutang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nominalbayar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents nomertelepon As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kotaasal As DevExpress.XtraEditors.LabelControl
    Friend WithEvents jabatan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents idpiutang As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents namakaryawan As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents tanggaljatuhtempo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nomerdo As DevExpress.XtraGrid.Columns.GridColumn
End Class
