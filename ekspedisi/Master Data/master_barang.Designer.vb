<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class master_barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(master_barang))
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.deldata = New DevExpress.XtraBars.BarButtonItem()
        Me.jumpmenu = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.addsiswabaru = New DevExpress.XtraBars.BarButtonItem()
        Me.edit = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.nonaktif = New System.Windows.Forms.RadioButton()
        Me.aktif = New System.Windows.Forms.RadioButton()
        Me.editing = New DevExpress.XtraEditors.SimpleButton()
        Me.hapus = New DevExpress.XtraEditors.SimpleButton()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.dataview = New System.Windows.Forms.DataGridView()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.msiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.nama = New System.Windows.Forms.RadioButton()
        Me.id = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.RibbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.datasiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.mastersiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.dataview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(594, 534)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 35
        Me.cancel.Text = "Cancel"
        '
        'deldata
        '
        Me.deldata.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.deldata.Caption = "Delete Data"
        Me.deldata.Glyph = CType(resources.GetObject("deldata.Glyph"), System.Drawing.Image)
        Me.deldata.Id = 30
        Me.deldata.LargeGlyph = CType(resources.GetObject("deldata.LargeGlyph"), System.Drawing.Image)
        Me.deldata.Name = "deldata"
        '
        'jumpmenu
        '
        Me.jumpmenu.Caption = "Main Menu"
        Me.jumpmenu.Glyph = CType(resources.GetObject("jumpmenu.Glyph"), System.Drawing.Image)
        Me.jumpmenu.Id = 31
        Me.jumpmenu.LargeGlyph = CType(resources.GetObject("jumpmenu.LargeGlyph"), System.Drawing.Image)
        Me.jumpmenu.Name = "jumpmenu"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.jumpmenu)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.addsiswabaru)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.edit)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.deldata)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'addsiswabaru
        '
        Me.addsiswabaru.Caption = "Tambah Data"
        Me.addsiswabaru.Glyph = CType(resources.GetObject("addsiswabaru.Glyph"), System.Drawing.Image)
        Me.addsiswabaru.Id = 23
        Me.addsiswabaru.LargeGlyph = CType(resources.GetObject("addsiswabaru.LargeGlyph"), System.Drawing.Image)
        Me.addsiswabaru.Name = "addsiswabaru"
        '
        'edit
        '
        Me.edit.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.edit.Caption = "Edit Data"
        Me.edit.Glyph = CType(resources.GetObject("edit.Glyph"), System.Drawing.Image)
        Me.edit.Id = 27
        Me.edit.LargeGlyph = CType(resources.GetObject("edit.LargeGlyph"), System.Drawing.Image)
        Me.edit.Name = "edit"
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.nonaktif)
        Me.GroupControl2.Controls.Add(Me.aktif)
        Me.GroupControl2.Location = New System.Drawing.Point(281, 102)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(150, 76)
        Me.GroupControl2.TabIndex = 32
        Me.GroupControl2.Text = "Sortir"
        '
        'nonaktif
        '
        Me.nonaktif.AutoSize = True
        Me.nonaktif.Location = New System.Drawing.Point(5, 47)
        Me.nonaktif.Name = "nonaktif"
        Me.nonaktif.Size = New System.Drawing.Size(107, 17)
        Me.nonaktif.TabIndex = 9
        Me.nonaktif.Text = "Barang Non-Aktif"
        Me.nonaktif.UseVisualStyleBackColor = True
        '
        'aktif
        '
        Me.aktif.AutoSize = True
        Me.aktif.Checked = True
        Me.aktif.Location = New System.Drawing.Point(5, 24)
        Me.aktif.Name = "aktif"
        Me.aktif.Size = New System.Drawing.Size(84, 17)
        Me.aktif.TabIndex = 8
        Me.aktif.TabStop = True
        Me.aktif.Text = "Barang Aktif"
        Me.aktif.UseVisualStyleBackColor = True
        '
        'editing
        '
        Me.editing.Location = New System.Drawing.Point(12, 534)
        Me.editing.Name = "editing"
        Me.editing.Size = New System.Drawing.Size(198, 26)
        Me.editing.TabIndex = 31
        Me.editing.Text = "Edit"
        Me.editing.Visible = False
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(12, 534)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(198, 26)
        Me.hapus.TabIndex = 33
        Me.hapus.Text = "Delete"
        Me.hapus.Visible = False
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.ActAsDropDown = True
        Me.BarButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItem2.Caption = "Master Data"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"), System.Drawing.Image)
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"), System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'dataview
        '
        Me.dataview.AllowUserToAddRows = False
        Me.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataview.Location = New System.Drawing.Point(5, 24)
        Me.dataview.Name = "dataview"
        Me.dataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dataview.Size = New System.Drawing.Size(672, 311)
        Me.dataview.TabIndex = 6
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Controls.Add(Me.dataview)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 184)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(682, 344)
        Me.GroupControl3.TabIndex = 34
        Me.GroupControl3.Text = "Data Barang"
        '
        'msiswa
        '
        Me.msiswa.ActAsDropDown = True
        Me.msiswa.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.msiswa.Caption = "Master Data"
        Me.msiswa.Glyph = CType(resources.GetObject("msiswa.Glyph"), System.Drawing.Image)
        Me.msiswa.Id = 1
        Me.msiswa.LargeGlyph = CType(resources.GetObject("msiswa.LargeGlyph"), System.Drawing.Image)
        Me.msiswa.Name = "msiswa"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.nama)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Controls.Add(Me.cari)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 102)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(263, 76)
        Me.GroupControl1.TabIndex = 30
        Me.GroupControl1.Text = "Cari Berdasarkan"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Checked = True
        Me.nama.Location = New System.Drawing.Point(87, 24)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(89, 17)
        Me.nama.TabIndex = 2
        Me.nama.TabStop = True
        Me.nama.Text = "Nama Barang"
        Me.nama.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(5, 24)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(73, 17)
        Me.id.TabIndex = 1
        Me.id.Text = "ID Barang"
        Me.id.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(5, 51)
        Me.cari.MenuManager = Me.RibbonControl1
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(253, 20)
        Me.cari.TabIndex = 0
        '
        'RibbonControl1
        '
        Me.RibbonControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonGalleryBarItem1, Me.datasiswa, Me.BarSubItem1, Me.mastersiswa, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.addsiswabaru, Me.edit, Me.deldata, Me.jumpmenu})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 32
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(706, 96)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'RibbonGalleryBarItem1
        '
        Me.RibbonGalleryBarItem1.Caption = "InplaceGallery1"
        Me.RibbonGalleryBarItem1.Id = 11
        Me.RibbonGalleryBarItem1.Name = "RibbonGalleryBarItem1"
        '
        'datasiswa
        '
        Me.datasiswa.Caption = "Master Data Siswa"
        Me.datasiswa.Glyph = CType(resources.GetObject("datasiswa.Glyph"), System.Drawing.Image)
        Me.datasiswa.Id = 10
        Me.datasiswa.Name = "datasiswa"
        '
        'BarSubItem1
        '
        Me.BarSubItem1.Caption = "BarSubItem1"
        Me.BarSubItem1.Id = 12
        Me.BarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem3), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem5)})
        Me.BarSubItem1.Name = "BarSubItem1"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Master Data Siswa"
        Me.BarButtonItem3.Id = 15
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Master Data Level"
        Me.BarButtonItem5.Id = 17
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'mastersiswa
        '
        Me.mastersiswa.Caption = "Master Data Siswa"
        Me.mastersiswa.Id = 13
        Me.mastersiswa.LargeGlyph = CType(resources.GetObject("mastersiswa.LargeGlyph"), System.Drawing.Image)
        Me.mastersiswa.LargeGlyphDisabled = CType(resources.GetObject("mastersiswa.LargeGlyphDisabled"), System.Drawing.Image)
        Me.mastersiswa.Name = "mastersiswa"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Master Data"
        Me.BarButtonItem4.Id = 16
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Master Data Buku"
        Me.BarButtonItem6.Id = 19
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Master Data Ruang"
        Me.BarButtonItem7.Id = 20
        Me.BarButtonItem7.Name = "BarButtonItem7"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Master Data Guru"
        Me.BarButtonItem8.Id = 21
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Master Data User"
        Me.BarButtonItem9.Id = 22
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(5, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(672, 311)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'master_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 568)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.editing)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "master_barang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Barang"
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.dataview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents deldata As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents jumpmenu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents addsiswabaru As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nonaktif As System.Windows.Forms.RadioButton
    Friend WithEvents aktif As System.Windows.Forms.RadioButton
    Friend WithEvents editing As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents hapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents dataview As System.Windows.Forms.DataGridView
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents msiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nama As System.Windows.Forms.RadioButton
    Friend WithEvents id As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents datasiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mastersiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
