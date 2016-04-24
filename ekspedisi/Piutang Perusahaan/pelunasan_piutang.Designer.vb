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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.alamat = New System.Windows.Forms.RichTextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.bayarpiutang = New DevExpress.XtraGrid.GridControl()
        Me.datapiutang = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RepositoryItemDateEdit = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
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
        Me.labeltotalbayar = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.nominalbg = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
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
        Me.idprinciple = New System.Windows.Forms.Label()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.pembayaran = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colnama_akun = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
        Me.colketerangan = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colnominal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.coltruk = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
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
        CType(Me.pelunasan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daftarpiutang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pembayaran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(582, 33)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 38
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
        Me.GroupControl2.Controls.Add(Me.GridControl1)
        Me.GroupControl2.Controls.Add(Me.labeltotalbayar)
        Me.GroupControl2.Controls.Add(Me.LabelControl11)
        Me.GroupControl2.Controls.Add(Me.nominalbg)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 295)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(705, 195)
        Me.GroupControl2.TabIndex = 42
        Me.GroupControl2.Text = "Pembayaran"
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
        'labeltotalbayar
        '
        Me.labeltotalbayar.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labeltotalbayar.Location = New System.Drawing.Point(523, 170)
        Me.labeltotalbayar.Name = "labeltotalbayar"
        Me.labeltotalbayar.Size = New System.Drawing.Size(8, 18)
        Me.labeltotalbayar.TabIndex = 150
        Me.labeltotalbayar.Text = "0"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(431, 170)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(86, 18)
        Me.LabelControl11.TabIndex = 48
        Me.LabelControl11.Text = "Total Bayar :"
        '
        'nominalbg
        '
        Me.nominalbg.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nominalbg.Location = New System.Drawing.Point(134, 170)
        Me.nominalbg.Name = "nominalbg"
        Me.nominalbg.Size = New System.Drawing.Size(8, 18)
        Me.nominalbg.TabIndex = 47
        Me.nominalbg.Text = "0"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(5, 170)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(123, 18)
        Me.LabelControl5.TabIndex = 46
        Me.LabelControl5.Text = "Total Nominal BG :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(488, 501)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(141, 18)
        Me.LabelControl7.TabIndex = 48
        Me.LabelControl7.Text = "Total Nominal Piutang"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(497, 523)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(132, 18)
        Me.LabelControl9.TabIndex = 50
        Me.LabelControl9.Text = "Total Nominal Bayar"
        '
        'totalpiutang
        '
        Me.totalpiutang.Enabled = False
        Me.totalpiutang.Location = New System.Drawing.Point(636, 498)
        Me.totalpiutang.Name = "totalpiutang"
        Me.totalpiutang.Size = New System.Drawing.Size(174, 21)
        Me.totalpiutang.TabIndex = 48
        Me.totalpiutang.Text = "0"
        '
        'totaldibayar
        '
        Me.totaldibayar.Enabled = False
        Me.totaldibayar.Location = New System.Drawing.Point(636, 520)
        Me.totaldibayar.Name = "totaldibayar"
        Me.totaldibayar.Size = New System.Drawing.Size(174, 21)
        Me.totaldibayar.TabIndex = 52
        Me.totaldibayar.Text = "0"
        '
        'catatan
        '
        Me.catatan.Location = New System.Drawing.Point(72, 501)
        Me.catatan.Name = "catatan"
        Me.catatan.Size = New System.Drawing.Size(375, 66)
        Me.catatan.TabIndex = 54
        Me.catatan.Text = ""
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(12, 501)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(56, 18)
        Me.LabelControl10.TabIndex = 53
        Me.LabelControl10.Text = "Catatan "
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(710, 573)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 149
        Me.cancel.Text = "Cancel"
        '
        'save
        '
        Me.save.Image = CType(resources.GetObject("save.Image"), System.Drawing.Image)
        Me.save.Location = New System.Drawing.Point(604, 573)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(100, 27)
        Me.save.TabIndex = 148
        Me.save.Text = "Save"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Location = New System.Drawing.Point(482, 12)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(90, 18)
        Me.LabelControl13.TabIndex = 150
        Me.LabelControl13.Text = "Nomer Faktur"
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
        'idprinciple
        '
        Me.idprinciple.AutoSize = True
        Me.idprinciple.Location = New System.Drawing.Point(448, 80)
        Me.idprinciple.Name = "idprinciple"
        Me.idprinciple.Size = New System.Drawing.Size(54, 13)
        Me.idprinciple.TabIndex = 152
        Me.idprinciple.Text = "idprinciple"
        Me.idprinciple.Visible = False
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "bayaran"
        Me.GridControl1.DataSource = Me.pelunasan
        Me.GridControl1.EmbeddedNavigator.Buttons.Append.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.Edit.Visible = False
        Me.GridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
        Me.GridControl1.Location = New System.Drawing.Point(8, 24)
        Me.GridControl1.MainView = Me.pembayaran
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemLookUpEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(688, 144)
        Me.GridControl1.TabIndex = 151
        Me.GridControl1.UseEmbeddedNavigator = True
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.pembayaran})
        '
        'pembayaran
        '
        Me.pembayaran.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colnama_akun, Me.colketerangan, Me.colnominal, Me.coltruk})
        Me.pembayaran.GridControl = Me.GridControl1
        Me.pembayaran.Name = "pembayaran"
        Me.pembayaran.OptionsCustomization.AllowGroup = False
        Me.pembayaran.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.pembayaran.OptionsView.ShowFooter = True
        Me.pembayaran.OptionsView.ShowGroupPanel = False
        '
        'colnama_akun
        '
        Me.colnama_akun.Caption = "Nama Akun"
        Me.colnama_akun.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.colnama_akun.FieldName = "id_akun_detil"
        Me.colnama_akun.Name = "colnama_akun"
        Me.colnama_akun.Visible = True
        Me.colnama_akun.VisibleIndex = 0
        Me.colnama_akun.Width = 233
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("descr", "Nama Akun"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kode_akun", "kode_akun", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        '
        'colketerangan
        '
        Me.colketerangan.Caption = "Keterangan"
        Me.colketerangan.FieldName = "keterangan"
        Me.colketerangan.Name = "colketerangan"
        Me.colketerangan.Visible = True
        Me.colketerangan.VisibleIndex = 1
        Me.colketerangan.Width = 223
        '
        'colnominal
        '
        Me.colnominal.AppearanceCell.Options.UseTextOptions = True
        Me.colnominal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.colnominal.AppearanceHeader.Options.UseTextOptions = True
        Me.colnominal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.colnominal.Caption = "Nominal"
        Me.colnominal.ColumnEdit = Me.RepositoryItemTextEdit1
        Me.colnominal.FieldName = "nominal"
        Me.colnominal.Name = "colnominal"
        Me.colnominal.OptionsFilter.AllowAutoFilter = False
        Me.colnominal.OptionsFilter.AllowFilter = False
        Me.colnominal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "nominal", "{0:N2}")})
        Me.colnominal.Visible = True
        Me.colnominal.VisibleIndex = 2
        Me.colnominal.Width = 161
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Mask.EditMask = "n"
        Me.RepositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.RepositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = True
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'coltruk
        '
        Me.coltruk.Caption = "Truk"
        Me.coltruk.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.coltruk.FieldName = "id_truk"
        Me.coltruk.Name = "coltruk"
        Me.coltruk.Visible = True
        Me.coltruk.VisibleIndex = 3
        Me.coltruk.Width = 79
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("no_pol", "No Pol"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("id_truk", "Name11", 20, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default])})
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        '
        'pelunasan_piutang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 608)
        Me.Controls.Add(Me.idprinciple)
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
        Me.Controls.Add(Me.DateTimePicker1)
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
        CType(Me.pelunasan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daftarpiutang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bayaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pembayaran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents principle As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents alamat As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents bayarpiutang As DevExpress.XtraGrid.GridControl
    Friend WithEvents datapiutang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nominalbg As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents idprinciple As System.Windows.Forms.Label
    Friend WithEvents bayaran As System.Data.DataTable
    Friend WithEvents DataColumn8 As System.Data.DataColumn
    Friend WithEvents DataColumn9 As System.Data.DataColumn
    Friend WithEvents DataColumn10 As System.Data.DataColumn
    Friend WithEvents DataColumn11 As System.Data.DataColumn
    Friend WithEvents DataColumn12 As System.Data.DataColumn
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents pembayaran As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colnama_akun As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colketerangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colnominal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents coltruk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
