<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class master_supir
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(master_supir))
        Me.hapus = New DevExpress.XtraEditors.SimpleButton()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.msiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
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
        Me.addsupirbaru = New DevExpress.XtraBars.BarButtonItem()
        Me.edit = New DevExpress.XtraBars.BarButtonItem()
        Me.deldata = New DevExpress.XtraBars.BarButtonItem()
        Me.jumpmenu = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Print = New System.Windows.Forms.ToolStripMenuItem()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.nonaktif = New System.Windows.Forms.RadioButton()
        Me.aktif = New System.Windows.Forms.RadioButton()
        Me.editing = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.nama = New System.Windows.Forms.RadioButton()
        Me.id = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.RepositoryItemCheckEdit1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl3,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl3.SuspendLayout
        CType(Me.GridControl2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RibbonControl1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.ContextMenuStrip1.SuspendLayout
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl2.SuspendLayout
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupControl1.SuspendLayout
        CType(Me.cari.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(13, 667)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(198, 26)
        Me.hapus.TabIndex = 50
        Me.hapus.Text = "Delete"
        Me.hapus.Visible = false
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = false
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'msiswa
        '
        Me.msiswa.ActAsDropDown = true
        Me.msiswa.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.msiswa.Caption = "Master Data"
        Me.msiswa.Glyph = CType(resources.GetObject("msiswa.Glyph"),System.Drawing.Image)
        Me.msiswa.Id = 1
        Me.msiswa.LargeGlyph = CType(resources.GetObject("msiswa.LargeGlyph"),System.Drawing.Image)
        Me.msiswa.Name = "msiswa"
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"),System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(892, 666)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 52
        Me.cancel.Text = "Cancel"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl2)
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Location = New System.Drawing.Point(13, 187)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(984, 473)
        Me.GroupControl3.TabIndex = 51
        Me.GroupControl3.Text = "Data Karayawan"
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(5, 28)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.MenuManager = Me.RibbonControl1
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(974, 440)
        Me.GridControl2.TabIndex = 8
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsSelection.MultiSelect = true
        Me.GridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        '
        'RibbonControl1
        '
        Me.RibbonControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonGalleryBarItem1, Me.datasiswa, Me.BarSubItem1, Me.mastersiswa, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.addsupirbaru, Me.edit, Me.deldata, Me.jumpmenu})
        Me.RibbonControl1.Location = New System.Drawing.Point(1, 3)
        Me.RibbonControl1.MaxItemId = 32
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = false
        Me.RibbonControl1.Size = New System.Drawing.Size(1007, 96)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = false
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
        Me.datasiswa.Glyph = CType(resources.GetObject("datasiswa.Glyph"),System.Drawing.Image)
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
        Me.mastersiswa.LargeGlyph = CType(resources.GetObject("mastersiswa.LargeGlyph"),System.Drawing.Image)
        Me.mastersiswa.LargeGlyphDisabled = CType(resources.GetObject("mastersiswa.LargeGlyphDisabled"),System.Drawing.Image)
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
        'addsupirbaru
        '
        Me.addsupirbaru.Caption = "Tambah Data"
        Me.addsupirbaru.Glyph = CType(resources.GetObject("addsupirbaru.Glyph"),System.Drawing.Image)
        Me.addsupirbaru.Id = 23
        Me.addsupirbaru.LargeGlyph = CType(resources.GetObject("addsupirbaru.LargeGlyph"),System.Drawing.Image)
        Me.addsupirbaru.Name = "addsupirbaru"
        '
        'edit
        '
        Me.edit.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.edit.Caption = "Edit Data"
        Me.edit.Glyph = CType(resources.GetObject("edit.Glyph"),System.Drawing.Image)
        Me.edit.Id = 27
        Me.edit.LargeGlyph = CType(resources.GetObject("edit.LargeGlyph"),System.Drawing.Image)
        Me.edit.Name = "edit"
        '
        'deldata
        '
        Me.deldata.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
        Me.deldata.Caption = "Delete Data"
        Me.deldata.Glyph = CType(resources.GetObject("deldata.Glyph"),System.Drawing.Image)
        Me.deldata.Id = 30
        Me.deldata.LargeGlyph = CType(resources.GetObject("deldata.LargeGlyph"),System.Drawing.Image)
        Me.deldata.Name = "deldata"
        '
        'jumpmenu
        '
        Me.jumpmenu.Caption = "Main Menu"
        Me.jumpmenu.Glyph = CType(resources.GetObject("jumpmenu.Glyph"),System.Drawing.Image)
        Me.jumpmenu.Id = 31
        Me.jumpmenu.LargeGlyph = CType(resources.GetObject("jumpmenu.LargeGlyph"),System.Drawing.Image)
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
        Me.RibbonPageGroup1.ItemLinks.Add(Me.addsupirbaru)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.edit)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.deldata)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Location = New System.Drawing.Point(5, 28)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.MenuManager = Me.RibbonControl1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(974, 440)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Print})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(100, 26)
        '
        'Print
        '
        Me.Print.Image = CType(resources.GetObject("Print.Image"),System.Drawing.Image)
        Me.Print.Name = "Print"
        Me.Print.Size = New System.Drawing.Size(99, 22)
        Me.Print.Text = "Print"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.nonaktif)
        Me.GroupControl2.Controls.Add(Me.aktif)
        Me.GroupControl2.Location = New System.Drawing.Point(282, 105)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(150, 76)
        Me.GroupControl2.TabIndex = 49
        Me.GroupControl2.Text = "Sortir"
        '
        'nonaktif
        '
        Me.nonaktif.AutoSize = true
        Me.nonaktif.Location = New System.Drawing.Point(5, 47)
        Me.nonaktif.Name = "nonaktif"
        Me.nonaktif.Size = New System.Drawing.Size(97, 17)
        Me.nonaktif.TabIndex = 9
        Me.nonaktif.Text = "Supir Non-Aktif"
        Me.nonaktif.UseVisualStyleBackColor = true
        '
        'aktif
        '
        Me.aktif.AutoSize = true
        Me.aktif.Checked = true
        Me.aktif.Location = New System.Drawing.Point(5, 24)
        Me.aktif.Name = "aktif"
        Me.aktif.Size = New System.Drawing.Size(74, 17)
        Me.aktif.TabIndex = 8
        Me.aktif.TabStop = true
        Me.aktif.Text = "Supir Aktif"
        Me.aktif.UseVisualStyleBackColor = true
        '
        'editing
        '
        Me.editing.Location = New System.Drawing.Point(13, 666)
        Me.editing.Name = "editing"
        Me.editing.Size = New System.Drawing.Size(198, 26)
        Me.editing.TabIndex = 48
        Me.editing.Text = "Edit"
        Me.editing.Visible = false
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.nama)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Controls.Add(Me.cari)
        Me.GroupControl1.Location = New System.Drawing.Point(13, 105)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(263, 76)
        Me.GroupControl1.TabIndex = 47
        Me.GroupControl1.Text = "Cari Berdasarkan"
        '
        'nama
        '
        Me.nama.AutoSize = true
        Me.nama.Checked = true
        Me.nama.Location = New System.Drawing.Point(98, 24)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(79, 17)
        Me.nama.TabIndex = 2
        Me.nama.TabStop = true
        Me.nama.Text = "Nama Supir"
        Me.nama.UseVisualStyleBackColor = true
        '
        'id
        '
        Me.id.AutoSize = true
        Me.id.Location = New System.Drawing.Point(5, 24)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(63, 17)
        Me.id.TabIndex = 1
        Me.id.Text = "ID Supir"
        Me.id.UseVisualStyleBackColor = true
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(5, 51)
        Me.cari.MenuManager = Me.RibbonControl1
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(253, 20)
        Me.cari.TabIndex = 0
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.ActAsDropDown = true
        Me.BarButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.BarButtonItem2.Caption = "Master Data"
        Me.BarButtonItem2.Glyph = CType(resources.GetObject("BarButtonItem2.Glyph"),System.Drawing.Image)
        Me.BarButtonItem2.Id = 1
        Me.BarButtonItem2.LargeGlyph = CType(resources.GetObject("BarButtonItem2.LargeGlyph"),System.Drawing.Image)
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"),System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(928, 152)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(69, 29)
        Me.SimpleButton1.TabIndex = 53
        Me.SimpleButton1.Text = "Print"
        '
        'master_supir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 697)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.editing)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Name = "master_supir"
        Me.Text = "Master Supir"
        CType(Me.RepositoryItemCheckEdit1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl3,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl3.ResumeLayout(false)
        CType(Me.GridControl2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RibbonControl1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GridControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ContextMenuStrip1.ResumeLayout(false)
        CType(Me.GridView1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GroupControl2,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl2.ResumeLayout(false)
        Me.GroupControl2.PerformLayout
        CType(Me.GroupControl1,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupControl1.ResumeLayout(false)
        Me.GroupControl1.PerformLayout
        CType(Me.cari.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents hapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents msiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
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
    Friend WithEvents addsupirbaru As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents deldata As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents jumpmenu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Print As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nonaktif As System.Windows.Forms.RadioButton
    Friend WithEvents aktif As System.Windows.Forms.RadioButton
    Friend WithEvents editing As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nama As System.Windows.Forms.RadioButton
    Friend WithEvents id As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
