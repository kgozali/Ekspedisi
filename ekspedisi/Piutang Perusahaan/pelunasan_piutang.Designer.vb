<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pelunasan_piutang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pelunasan_piutang))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.principle = New DevExpress.XtraEditors.ButtonEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tanggalpelunasan = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.alamat = New System.Windows.Forms.RichTextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.bayarpiutang = New DevExpress.XtraGrid.GridControl()
        Me.datapiutang = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.daftarbayar = New DevExpress.XtraGrid.GridControl()
        Me.pelunasan = New System.Data.DataSet()
        Me.daftarpiutang = New System.Data.DataTable()
        Me.DataColumn1 = New System.Data.DataColumn()
        Me.DataColumn2 = New System.Data.DataColumn()
        Me.DataColumn3 = New System.Data.DataColumn()
        Me.DataColumn4 = New System.Data.DataColumn()
        Me.DataColumn5 = New System.Data.DataColumn()
        Me.DataColumn6 = New System.Data.DataColumn()
        Me.DataColumn7 = New System.Data.DataColumn()
        Me.bayaran = New System.Data.DataTable()
        Me.DataColumn8 = New System.Data.DataColumn()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.pembayaran = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.namabank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nobg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nominal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tanggalcair = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.namaakun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.labeltotalbayar = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.totalpiutang = New System.Windows.Forms.TextBox()
        Me.totaldibayar = New System.Windows.Forms.TextBox()
        Me.catatan = New System.Windows.Forms.RichTextBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.save = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.nomerpelunasan = New System.Windows.Forms.TextBox()
        CType(Me.principle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.bayarpiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datapiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.daftarbayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pelunasan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daftarpiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pembayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 18)
        Me.LabelControl1.TabIndex = 35
        Me.LabelControl1.Text = "Nama Principle"
        '
        'principle
        '
        Me.principle.Location = New System.Drawing.Point(112, 10)
        Me.principle.Name = "principle"
        Me.principle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.principle.Size = New System.Drawing.Size(212, 20)
        Me.principle.TabIndex = 36
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(520, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 18)
        Me.LabelControl2.TabIndex = 37
        Me.LabelControl2.Text = "Tanggal"
        '
        'tanggalpelunasan
        '
        Me.tanggalpelunasan.Location = New System.Drawing.Point(582, 33)
        Me.tanggalpelunasan.Name = "tanggalpelunasan"
        Me.tanggalpelunasan.Size = New System.Drawing.Size(200, 21)
        Me.tanggalpelunasan.TabIndex = 38
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(61, 37)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 18)
        Me.LabelControl3.TabIndex = 39
        Me.LabelControl3.Text = "Alamat"
        '
        'alamat
        '
        Me.alamat.Enabled = False
        Me.alamat.Location = New System.Drawing.Point(112, 37)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(270, 60)
        Me.alamat.TabIndex = 40
        Me.alamat.Text = ""
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.bayarpiutang)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 103)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(799, 186)
        Me.GroupControl1.TabIndex = 41
        Me.GroupControl1.Text = "Daftar Piutang"
        '
        'bayarpiutang
        '
        Me.bayarpiutang.Location = New System.Drawing.Point(5, 24)
        Me.bayarpiutang.MainView = Me.datapiutang
        Me.bayarpiutang.Name = "bayarpiutang"
        Me.bayarpiutang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1, Me.RepositoryItemDateEdit})
        Me.bayarpiutang.Size = New System.Drawing.Size(789, 157)
        Me.bayarpiutang.TabIndex = 1
        Me.bayarpiutang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.datapiutang})
        '
        'datapiutang
        '
        Me.datapiutang.GridControl = Me.bayarpiutang
        Me.datapiutang.Name = "datapiutang"
        Me.datapiutang.OptionsView.ShowGroupPanel = False
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RepositoryItemDateEdit
        '
        Me.RepositoryItemDateEdit.AutoHeight = False
        Me.RepositoryItemDateEdit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit.Name = "RepositoryItemDateEdit"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.daftarbayar)
        Me.GroupControl2.Controls.Add(Me.labeltotalbayar)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 295)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(705, 201)
        Me.GroupControl2.TabIndex = 42
        Me.GroupControl2.Text = "Pembayaran"
        '
        'daftarbayar
        '
        Me.daftarbayar.DataMember = "bayaran"
        Me.daftarbayar.DataSource = Me.pelunasan
        Me.daftarbayar.Location = New System.Drawing.Point(8, 24)
        Me.daftarbayar.MainView = Me.pembayaran
        Me.daftarbayar.Name = "daftarbayar"
        Me.daftarbayar.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemLookUpEdit1})
        Me.daftarbayar.Size = New System.Drawing.Size(688, 144)
        Me.daftarbayar.TabIndex = 151
        Me.daftarbayar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.pembayaran})
        '
        'pelunasan
        '
        Me.pelunasan.DataSetName = "NewDataSet"
        Me.pelunasan.Tables.AddRange(New System.Data.DataTable() {Me.daftarpiutang, Me.bayaran})
        '
        'daftarpiutang
        '
        Me.daftarpiutang.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn1, Me.DataColumn2, Me.DataColumn3, Me.DataColumn4, Me.DataColumn5, Me.DataColumn6, Me.DataColumn7})
        Me.daftarpiutang.TableName = "daftarpiutang"
        '
        'DataColumn1
        '
        Me.DataColumn1.Caption = "Kode Piutang"
        Me.DataColumn1.ColumnName = "id"
        '
        'DataColumn2
        '
        Me.DataColumn2.Caption = "Tanggal Piutang"
        Me.DataColumn2.ColumnName = "tanggalpiutang"
        '
        'DataColumn3
        '
        Me.DataColumn3.Caption = "Tanggal Jatuh Tempo"
        Me.DataColumn3.ColumnName = "jatuhtempo"
        '
        'DataColumn4
        '
        Me.DataColumn4.Caption = "Nominal"
        Me.DataColumn4.ColumnName = "nominal"
        '
        'DataColumn5
        '
        Me.DataColumn5.Caption = "Terbayar"
        Me.DataColumn5.ColumnName = "terbayar"
        '
        'DataColumn6
        '
        Me.DataColumn6.Caption = "Sisa"
        Me.DataColumn6.ColumnName = "sisa"
        '
        'DataColumn7
        '
        Me.DataColumn7.Caption = "Nominal Bayar"
        Me.DataColumn7.ColumnName = "nominalbayar"
        '
        'bayaran
        '
        Me.bayaran.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn8, Me.DataColumn9, Me.DataColumn10, Me.DataColumn11, Me.DataColumn12})
        Me.bayaran.TableName = "bayaran"
        '
        'DataColumn8
        '
        Me.DataColumn8.Caption = "namabank"
        Me.DataColumn8.ColumnName = "namabank"
        '
        'DataColumn9
        '
        Me.DataColumn9.Caption = "nomerbg"
        Me.DataColumn9.ColumnName = "nomerbg"
        '
        'DataColumn10
        '
        Me.DataColumn10.Caption = "Nominal"
        Me.DataColumn10.ColumnName = "nominal"
        Me.DataColumn10.DataType = GetType(Double)
        '
        'DataColumn11
        '
        Me.DataColumn11.Caption = "tanggalcair"
        Me.DataColumn11.ColumnName = "tanggalcair"
        '
        'DataColumn12
        '
        Me.DataColumn12.Caption = "Akun"
        Me.DataColumn12.ColumnName = "akun"
        '
        'pembayaran
        '
        Me.pembayaran.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.namabank, Me.nobg, Me.nominal, Me.tanggalcair, Me.namaakun})
        Me.pembayaran.GridControl = Me.daftarbayar
        Me.pembayaran.Name = "pembayaran"
        Me.pembayaran.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        Me.pembayaran.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.pembayaran.OptionsView.ShowFooter = True
        Me.pembayaran.OptionsView.ShowGroupPanel = False
        '
        'namabank
        '
        Me.namabank.Caption = "Nama Bank"
        Me.namabank.FieldName = "namabank"
        Me.namabank.Name = "namabank"
        Me.namabank.Visible = True
        Me.namabank.VisibleIndex = 0
        '
        'nobg
        '
        Me.nobg.Caption = "Nomor BG"
        Me.nobg.FieldName = "nomerbg"
        Me.nobg.Name = "nobg"
        Me.nobg.Visible = True
        Me.nobg.VisibleIndex = 1
        '
        'nominal
        '
        Me.nominal.Caption = "Nominal"
        Me.nominal.FieldName = "nominal"
        Me.nominal.Name = "nominal"
        Me.nominal.Visible = True
        Me.nominal.VisibleIndex = 2
        '
        'tanggalcair
        '
        Me.tanggalcair.Caption = "Tanggal Cair"
        Me.tanggalcair.ColumnEdit = Me.RepositoryItemDateEdit1
        Me.tanggalcair.FieldName = "tanggalcair"
        Me.tanggalcair.Name = "tanggalcair"
        Me.tanggalcair.Visible = True
        Me.tanggalcair.VisibleIndex = 3
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'namaakun
        '
        Me.namaakun.Caption = "Nama Akun"
        Me.namaakun.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.namaakun.FieldName = "akun"
        Me.namaakun.Name = "namaakun"
        Me.namaakun.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nominal", "Rp. {0:#,###,##},00")})
        Me.namaakun.Visible = True
        Me.namaakun.VisibleIndex = 4
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'labeltotalbayar
        '
        Me.labeltotalbayar.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltotalbayar.Location = New System.Drawing.Point(100, 176)
        Me.labeltotalbayar.Name = "labeltotalbayar"
        Me.labeltotalbayar.Size = New System.Drawing.Size(8, 18)
        Me.labeltotalbayar.TabIndex = 150
        Me.labeltotalbayar.Text = "0"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(8, 176)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(86, 18)
        Me.LabelControl11.TabIndex = 48
        Me.LabelControl11.Text = "Total Bayar :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(488, 507)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(141, 18)
        Me.LabelControl7.TabIndex = 48
        Me.LabelControl7.Text = "Total Nominal Piutang"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(497, 531)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(132, 18)
        Me.LabelControl9.TabIndex = 50
        Me.LabelControl9.Text = "Total Nominal Bayar"
        '
        'totalpiutang
        '
        Me.totalpiutang.Enabled = False
        Me.totalpiutang.Location = New System.Drawing.Point(636, 504)
        Me.totalpiutang.Name = "totalpiutang"
        Me.totalpiutang.Size = New System.Drawing.Size(174, 21)
        Me.totalpiutang.TabIndex = 48
        Me.totalpiutang.Text = "0"
        '
        'totaldibayar
        '
        Me.totaldibayar.Enabled = False
        Me.totaldibayar.Location = New System.Drawing.Point(636, 528)
        Me.totaldibayar.Name = "totaldibayar"
        Me.totaldibayar.Size = New System.Drawing.Size(174, 21)
        Me.totaldibayar.TabIndex = 52
        Me.totaldibayar.Text = "0"
        '
        'catatan
        '
        Me.catatan.Location = New System.Drawing.Point(72, 504)
        Me.catatan.Name = "catatan"
        Me.catatan.Size = New System.Drawing.Size(375, 66)
        Me.catatan.TabIndex = 54
        Me.catatan.Text = ""
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(12, 504)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(56, 18)
        Me.LabelControl10.TabIndex = 53
        Me.LabelControl10.Text = "Catatan "
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(710, 576)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 149
        Me.cancel.Text = "Cancel"
        '
        'save
        '
        Me.save.Image = CType(resources.GetObject("save.Image"), System.Drawing.Image)
        Me.save.Location = New System.Drawing.Point(604, 576)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(100, 27)
        Me.save.TabIndex = 148
        Me.save.Text = "Save"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(458, 12)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(114, 18)
        Me.LabelControl13.TabIndex = 150
        Me.LabelControl13.Text = "Nomer Pelunasan"
        '
        'nomerpelunasan
        '
        Me.nomerpelunasan.Enabled = False
        Me.nomerpelunasan.Location = New System.Drawing.Point(582, 9)
        Me.nomerpelunasan.Name = "nomerpelunasan"
        Me.nomerpelunasan.ReadOnly = True
        Me.nomerpelunasan.Size = New System.Drawing.Size(174, 21)
        Me.nomerpelunasan.TabIndex = 151
        '
        'pelunasan_piutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 610)
        Me.Controls.Add(Me.nomerpelunasan)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.catatan)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.totaldibayar)
        Me.Controls.Add(Me.totalpiutang)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.tanggalpelunasan)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.principle)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "pelunasan_piutang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pelunasan Piutang"
        CType(Me.principle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.bayarpiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datapiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.daftarbayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pelunasan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daftarpiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bayaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pembayaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents principle As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tanggalpelunasan As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents alamat As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bayarpiutang As DevExpress.XtraGrid.GridControl
    Friend WithEvents datapiutang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents totalpiutang As System.Windows.Forms.TextBox
    Friend WithEvents totaldibayar As System.Windows.Forms.TextBox
    Friend WithEvents catatan As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents labeltotalbayar As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nomerpelunasan As System.Windows.Forms.TextBox
    Friend WithEvents RepositoryItemDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents pelunasan As System.Data.DataSet
    Friend WithEvents daftarpiutang As System.Data.DataTable
    Friend WithEvents DataColumn1 As System.Data.DataColumn
    Friend WithEvents DataColumn2 As System.Data.DataColumn
    Friend WithEvents DataColumn3 As System.Data.DataColumn
    Friend WithEvents DataColumn4 As System.Data.DataColumn
    Friend WithEvents DataColumn5 As System.Data.DataColumn
    Friend WithEvents DataColumn6 As System.Data.DataColumn
    Friend WithEvents DataColumn7 As System.Data.DataColumn
    Friend WithEvents bayaran As System.Data.DataTable
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents daftarbayar As DevExpress.XtraGrid.GridControl
    Friend WithEvents pembayaran As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents namabank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nobg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nominal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tanggalcair As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents namaakun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
