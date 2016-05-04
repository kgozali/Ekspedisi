<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_principle_pelunasan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_principle_pelunasan))
        Me.DataColumn10 = New System.Data.DataColumn()
        Me.DataColumn12 = New System.Data.DataColumn()
        Me.pembayaran = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.namabank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nobg = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.nominal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tanggalcair = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.namaakun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.daftarbayar = New DevExpress.XtraGrid.GridControl()
        Me.pelunasan = New System.Data.DataSet()
        Me.DataTable1 = New System.Data.DataTable()
        Me.DataColumn13 = New System.Data.DataColumn()
        Me.DataColumn14 = New System.Data.DataColumn()
        Me.DataColumn15 = New System.Data.DataColumn()
        Me.DataColumn16 = New System.Data.DataColumn()
        Me.DataColumn17 = New System.Data.DataColumn()
        Me.DataColumn18 = New System.Data.DataColumn()
        Me.DataColumn19 = New System.Data.DataColumn()
        Me.DataTable2 = New System.Data.DataTable()
        Me.DataColumn20 = New System.Data.DataColumn()
        Me.DataColumn21 = New System.Data.DataColumn()
        Me.DataColumn22 = New System.Data.DataColumn()
        Me.DataColumn23 = New System.Data.DataColumn()
        Me.DataColumn24 = New System.Data.DataColumn()
        Me.DataColumn11 = New System.Data.DataColumn()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.save = New DevExpress.XtraEditors.SimpleButton()
        Me.catatan = New System.Windows.Forms.RichTextBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.totaldibayar = New System.Windows.Forms.TextBox()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.nomerpelunasan = New System.Windows.Forms.TextBox()
        Me.DataColumn9 = New System.Data.DataColumn()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.bayarpiutang = New DevExpress.XtraGrid.GridControl()
        Me.datapiutang = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.alamat = New System.Windows.Forms.RichTextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.tanggalpelunasan = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
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
        Me.principle = New System.Windows.Forms.TextBox()
        CType(Me.pembayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daftarbayar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pelunasan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.bayarpiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datapiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daftarpiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataColumn10
        '
        Me.DataColumn10.AllowDBNull = False
        Me.DataColumn10.Caption = "Nominal"
        Me.DataColumn10.ColumnName = "nominal"
        Me.DataColumn10.DataType = GetType(Double)
        '
        'DataColumn12
        '
        Me.DataColumn12.AllowDBNull = False
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
        Me.nobg.ColumnEdit = Me.RepositoryItemComboBox1
        Me.nobg.FieldName = "nomerbg"
        Me.nobg.Name = "nobg"
        Me.nobg.Visible = True
        Me.nobg.VisibleIndex = 1
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Tunai", "Transfer"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
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
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatString = "dd MMMM yyyy"
        Me.RepositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.RepositoryItemDateEdit1.ExportMode = DevExpress.XtraEditors.Repository.ExportMode.DisplayText
        Me.RepositoryItemDateEdit1.Mask.EditMask = "dd MMMM yyyy"
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
        'daftarbayar
        '
        Me.daftarbayar.DataMember = "bayaran"
        Me.daftarbayar.DataSource = Me.pelunasan
        Me.daftarbayar.Location = New System.Drawing.Point(8, 24)
        Me.daftarbayar.MainView = Me.pembayaran
        Me.daftarbayar.Name = "daftarbayar"
        Me.daftarbayar.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemDateEdit1, Me.RepositoryItemLookUpEdit1, Me.RepositoryItemComboBox1})
        Me.daftarbayar.Size = New System.Drawing.Size(688, 144)
        Me.daftarbayar.TabIndex = 151
        Me.daftarbayar.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.pembayaran})
        '
        'pelunasan
        '
        Me.pelunasan.DataSetName = "NewDataSet"
        Me.pelunasan.Tables.AddRange(New System.Data.DataTable() {Me.DataTable1, Me.DataTable2})
        '
        'DataTable1
        '
        Me.DataTable1.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn13, Me.DataColumn14, Me.DataColumn15, Me.DataColumn16, Me.DataColumn17, Me.DataColumn18, Me.DataColumn19})
        Me.DataTable1.TableName = "daftarpiutang"
        '
        'DataColumn13
        '
        Me.DataColumn13.Caption = "Kode Piutang"
        Me.DataColumn13.ColumnName = "id"
        '
        'DataColumn14
        '
        Me.DataColumn14.Caption = "Tanggal Piutang"
        Me.DataColumn14.ColumnName = "tanggalpiutang"
        '
        'DataColumn15
        '
        Me.DataColumn15.Caption = "Tanggal Jatuh Tempo"
        Me.DataColumn15.ColumnName = "jatuhtempo"
        '
        'DataColumn16
        '
        Me.DataColumn16.Caption = "Nominal"
        Me.DataColumn16.ColumnName = "nominal"
        '
        'DataColumn17
        '
        Me.DataColumn17.Caption = "Terbayar"
        Me.DataColumn17.ColumnName = "terbayar"
        '
        'DataColumn18
        '
        Me.DataColumn18.Caption = "Sisa"
        Me.DataColumn18.ColumnName = "sisa"
        '
        'DataColumn19
        '
        Me.DataColumn19.Caption = "Nominal Bayar"
        Me.DataColumn19.ColumnName = "nominalbayar"
        '
        'DataTable2
        '
        Me.DataTable2.Columns.AddRange(New System.Data.DataColumn() {Me.DataColumn20, Me.DataColumn21, Me.DataColumn22, Me.DataColumn23, Me.DataColumn24})
        Me.DataTable2.TableName = "bayaran"
        '
        'DataColumn20
        '
        Me.DataColumn20.Caption = "namabank"
        Me.DataColumn20.ColumnName = "namabank"
        '
        'DataColumn21
        '
        Me.DataColumn21.Caption = "nomerbg"
        Me.DataColumn21.ColumnName = "nomerbg"
        '
        'DataColumn22
        '
        Me.DataColumn22.Caption = "Nominal"
        Me.DataColumn22.ColumnName = "nominal"
        Me.DataColumn22.DataType = GetType(Double)
        '
        'DataColumn23
        '
        Me.DataColumn23.Caption = "tanggalcair"
        Me.DataColumn23.ColumnName = "tanggalcair"
        Me.DataColumn23.DataType = GetType(Date)
        '
        'DataColumn24
        '
        Me.DataColumn24.Caption = "Akun"
        Me.DataColumn24.ColumnName = "akun"
        '
        'DataColumn11
        '
        Me.DataColumn11.AllowDBNull = False
        Me.DataColumn11.Caption = "tanggalcair"
        Me.DataColumn11.ColumnName = "tanggalcair"
        Me.DataColumn11.DataType = GetType(Date)
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(716, 545)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 167
        Me.cancel.Text = "Cancel"
        '
        'save
        '
        Me.save.Image = CType(resources.GetObject("save.Image"), System.Drawing.Image)
        Me.save.Location = New System.Drawing.Point(610, 545)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(100, 27)
        Me.save.TabIndex = 166
        Me.save.Text = "Save"
        '
        'catatan
        '
        Me.catatan.Location = New System.Drawing.Point(76, 480)
        Me.catatan.Name = "catatan"
        Me.catatan.Size = New System.Drawing.Size(375, 66)
        Me.catatan.TabIndex = 165
        Me.catatan.Text = ""
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(16, 480)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(56, 18)
        Me.LabelControl10.TabIndex = 164
        Me.LabelControl10.Text = "Catatan "
        '
        'totaldibayar
        '
        Me.totaldibayar.Enabled = False
        Me.totaldibayar.Location = New System.Drawing.Point(641, 481)
        Me.totaldibayar.Name = "totaldibayar"
        Me.totaldibayar.Size = New System.Drawing.Size(174, 21)
        Me.totaldibayar.TabIndex = 163
        Me.totaldibayar.Text = "0"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(502, 484)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(132, 18)
        Me.LabelControl9.TabIndex = 162
        Me.LabelControl9.Text = "Total Nominal Bayar"
        '
        'nomerpelunasan
        '
        Me.nomerpelunasan.Enabled = False
        Me.nomerpelunasan.Location = New System.Drawing.Point(586, 10)
        Me.nomerpelunasan.Name = "nomerpelunasan"
        Me.nomerpelunasan.ReadOnly = True
        Me.nomerpelunasan.Size = New System.Drawing.Size(174, 21)
        Me.nomerpelunasan.TabIndex = 169
        '
        'DataColumn9
        '
        Me.DataColumn9.AllowDBNull = False
        Me.DataColumn9.Caption = "nomerbg"
        Me.DataColumn9.ColumnName = "nomerbg"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.daftarbayar)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 296)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(705, 178)
        Me.GroupControl2.TabIndex = 159
        Me.GroupControl2.Text = "Pembayaran"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.bayarpiutang)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 104)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(799, 186)
        Me.GroupControl1.TabIndex = 158
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
        'alamat
        '
        Me.alamat.Enabled = False
        Me.alamat.Location = New System.Drawing.Point(116, 38)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(270, 60)
        Me.alamat.TabIndex = 157
        Me.alamat.Text = ""
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(65, 38)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(45, 18)
        Me.LabelControl3.TabIndex = 156
        Me.LabelControl3.Text = "Alamat"
        '
        'tanggalpelunasan
        '
        Me.tanggalpelunasan.Location = New System.Drawing.Point(586, 34)
        Me.tanggalpelunasan.Name = "tanggalpelunasan"
        Me.tanggalpelunasan.Size = New System.Drawing.Size(200, 21)
        Me.tanggalpelunasan.TabIndex = 155
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(524, 37)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(52, 18)
        Me.LabelControl2.TabIndex = 154
        Me.LabelControl2.Text = "Tanggal"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(462, 13)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(114, 18)
        Me.LabelControl13.TabIndex = 168
        Me.LabelControl13.Text = "Nomer Pelunasan"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(16, 13)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(94, 18)
        Me.LabelControl1.TabIndex = 152
        Me.LabelControl1.Text = "Nama Principle"
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
        'principle
        '
        Me.principle.Location = New System.Drawing.Point(116, 10)
        Me.principle.Name = "principle"
        Me.principle.Size = New System.Drawing.Size(255, 21)
        Me.principle.TabIndex = 170
        '
        'edit_principle_pelunasan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 575)
        Me.Controls.Add(Me.principle)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.catatan)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.totaldibayar)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.nomerpelunasan)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.tanggalpelunasan)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "edit_principle_pelunasan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Pelunasan Principle"
        CType(Me.pembayaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daftarbayar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pelunasan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.bayarpiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datapiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daftarpiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bayaran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents pembayaran As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents namabank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nobg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents nominal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tanggalcair As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents namaakun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents daftarbayar As DevExpress.XtraGrid.GridControl
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents catatan As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents totaldibayar As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nomerpelunasan As System.Windows.Forms.TextBox
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bayarpiutang As DevExpress.XtraGrid.GridControl
    Friend WithEvents datapiutang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemDateEdit As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents alamat As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tanggalpelunasan As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents pelunasan As System.Data.DataSet
    Friend WithEvents DataTable1 As System.Data.DataTable
    Friend WithEvents DataColumn13 As System.Data.DataColumn
    Friend WithEvents DataColumn14 As System.Data.DataColumn
    Friend WithEvents DataColumn15 As System.Data.DataColumn
    Friend WithEvents DataColumn16 As System.Data.DataColumn
    Friend WithEvents DataColumn17 As System.Data.DataColumn
    Friend WithEvents DataColumn18 As System.Data.DataColumn
    Friend WithEvents DataColumn19 As System.Data.DataColumn
    Friend WithEvents DataTable2 As System.Data.DataTable
    Friend WithEvents DataColumn20 As System.Data.DataColumn
    Friend WithEvents DataColumn21 As System.Data.DataColumn
    Friend WithEvents DataColumn22 As System.Data.DataColumn
    Friend WithEvents DataColumn23 As System.Data.DataColumn
    Friend WithEvents DataColumn24 As System.Data.DataColumn
    Friend WithEvents principle As System.Windows.Forms.TextBox
End Class
