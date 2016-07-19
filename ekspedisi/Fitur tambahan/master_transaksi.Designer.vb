<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class master_transaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(master_transaksi))
        Me.hapus = New DevExpress.XtraEditors.SimpleButton()
        Me.nonaktif = New System.Windows.Forms.RadioButton()
        Me.kodetransaksi = New System.Windows.Forms.RadioButton()
        Me.cust = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteBookingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviewAndPrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RibbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.aktif = New System.Windows.Forms.RadioButton()
        Me.datasiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.mastersiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.addsiswabaru = New DevExpress.XtraBars.BarButtonItem()
        Me.edit = New DevExpress.XtraBars.BarButtonItem()
        Me.deldata = New DevExpress.XtraBars.BarButtonItem()
        Me.jumpmenu = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.ksewa = New System.Windows.Forms.RadioButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(13, 802)
        Me.hapus.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(231, 32)
        Me.hapus.TabIndex = 174
        Me.hapus.Text = "Delete"
        Me.hapus.Visible = False
        '
        'nonaktif
        '
        Me.nonaktif.AutoSize = True
        Me.nonaktif.Location = New System.Drawing.Point(6, 57)
        Me.nonaktif.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nonaktif.Name = "nonaktif"
        Me.nonaktif.Size = New System.Drawing.Size(125, 21)
        Me.nonaktif.TabIndex = 9
        Me.nonaktif.Text = "Transaksi Lunas"
        Me.nonaktif.UseVisualStyleBackColor = True
        '
        'kodetransaksi
        '
        Me.kodetransaksi.AutoSize = True
        Me.kodetransaksi.Checked = True
        Me.kodetransaksi.Location = New System.Drawing.Point(9, 30)
        Me.kodetransaksi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.kodetransaksi.Name = "kodetransaksi"
        Me.kodetransaksi.Size = New System.Drawing.Size(124, 21)
        Me.kodetransaksi.TabIndex = 3
        Me.kodetransaksi.TabStop = True
        Me.kodetransaksi.Text = "Kode Transaksi "
        Me.kodetransaksi.UseVisualStyleBackColor = True
        '
        'cust
        '
        Me.cust.AutoSize = True
        Me.cust.Location = New System.Drawing.Point(133, 30)
        Me.cust.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cust.Name = "cust"
        Me.cust.Size = New System.Drawing.Size(128, 21)
        Me.cust.TabIndex = 1
        Me.cust.Text = "Nama Customer"
        Me.cust.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(9, 85)
        Me.cari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(295, 22)
        Me.cari.TabIndex = 0
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'GridControl1
        '
        Me.GridControl1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(2, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1119, 525)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditBookingToolStripMenuItem, Me.DeleteBookingToolStripMenuItem, Me.PreviewAndPrintToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(199, 110)
        '
        'EditBookingToolStripMenuItem
        '
        Me.EditBookingToolStripMenuItem.Image = CType(resources.GetObject("EditBookingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditBookingToolStripMenuItem.Name = "EditBookingToolStripMenuItem"
        Me.EditBookingToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.EditBookingToolStripMenuItem.Text = "Edit Booking"
        '
        'DeleteBookingToolStripMenuItem
        '
        Me.DeleteBookingToolStripMenuItem.Image = CType(resources.GetObject("DeleteBookingToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteBookingToolStripMenuItem.Name = "DeleteBookingToolStripMenuItem"
        Me.DeleteBookingToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.DeleteBookingToolStripMenuItem.Text = "Delete Booking"
        '
        'PreviewAndPrintToolStripMenuItem
        '
        Me.PreviewAndPrintToolStripMenuItem.Image = CType(resources.GetObject("PreviewAndPrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PreviewAndPrintToolStripMenuItem.Name = "PreviewAndPrintToolStripMenuItem"
        Me.PreviewAndPrintToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.PreviewAndPrintToolStripMenuItem.Text = "Preview and Print"
        '
        'RibbonGalleryBarItem1
        '
        Me.RibbonGalleryBarItem1.Caption = "InplaceGallery1"
        Me.RibbonGalleryBarItem1.Id = 11
        Me.RibbonGalleryBarItem1.Name = "RibbonGalleryBarItem1"
        '
        'aktif
        '
        Me.aktif.AutoSize = True
        Me.aktif.Checked = True
        Me.aktif.Location = New System.Drawing.Point(6, 28)
        Me.aktif.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.aktif.Name = "aktif"
        Me.aktif.Size = New System.Drawing.Size(166, 21)
        Me.aktif.TabIndex = 8
        Me.aktif.TabStop = True
        Me.aktif.Text = "Transaksi Belum Lunas"
        Me.aktif.UseVisualStyleBackColor = True
        '
        'datasiswa
        '
        Me.datasiswa.Caption = "Master Data Siswa"
        Me.datasiswa.Glyph = CType(resources.GetObject("datasiswa.Glyph"), System.Drawing.Image)
        Me.datasiswa.Id = 10
        Me.datasiswa.Name = "datasiswa"
        '
        'RibbonControl1
        '
        Me.RibbonControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RibbonControl1.Dock = System.Windows.Forms.DockStyle.None
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.RibbonGalleryBarItem1, Me.datasiswa, Me.BarSubItem1, Me.mastersiswa, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6, Me.BarButtonItem7, Me.BarButtonItem8, Me.BarButtonItem9, Me.addsiswabaru, Me.edit, Me.deldata, Me.jumpmenu})
        Me.RibbonControl1.Location = New System.Drawing.Point(-1, -4)
        Me.RibbonControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RibbonControl1.MaxItemId = 32
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1})
        Me.RibbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.RibbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[True]
        Me.RibbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(1156, 104)
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
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
        Me.edit.Caption = "Edit Data"
        Me.edit.Glyph = CType(resources.GetObject("edit.Glyph"), System.Drawing.Image)
        Me.edit.Id = 27
        Me.edit.LargeGlyph = CType(resources.GetObject("edit.LargeGlyph"), System.Drawing.Image)
        Me.edit.Name = "edit"
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
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(1020, 801)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(117, 33)
        Me.SimpleButton1.TabIndex = 172
        Me.SimpleButton1.Text = "Cancel"
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.nonaktif)
        Me.GroupControl4.Controls.Add(Me.aktif)
        Me.GroupControl4.Location = New System.Drawing.Point(342, 122)
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(175, 91)
        Me.GroupControl4.TabIndex = 173
        Me.GroupControl4.Text = "Sortir"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.ksewa)
        Me.GroupControl1.Controls.Add(Me.kodetransaksi)
        Me.GroupControl1.Controls.Add(Me.cust)
        Me.GroupControl1.Controls.Add(Me.cari)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 122)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(321, 116)
        Me.GroupControl1.TabIndex = 170
        Me.GroupControl1.Text = "Cari Berdasarkan"
        '
        'ksewa
        '
        Me.ksewa.AutoSize = True
        Me.ksewa.Location = New System.Drawing.Point(9, 57)
        Me.ksewa.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ksewa.Name = "ksewa"
        Me.ksewa.Size = New System.Drawing.Size(96, 21)
        Me.ksewa.TabIndex = 5
        Me.ksewa.Text = "Kode Sewa"
        Me.ksewa.UseVisualStyleBackColor = True
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Location = New System.Drawing.Point(13, 245)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(1123, 551)
        Me.GroupControl3.TabIndex = 171
        Me.GroupControl3.Text = "Daftar Transaksi"
        '
        'master_transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 844)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl4)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "master_transaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master Transaksi Sewa"
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hapus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents nonaktif As System.Windows.Forms.RadioButton
    Friend WithEvents kodetransaksi As System.Windows.Forms.RadioButton
    Friend WithEvents cust As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteBookingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviewAndPrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RibbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents aktif As System.Windows.Forms.RadioButton
    Friend WithEvents datasiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mastersiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents addsiswabaru As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents deldata As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents jumpmenu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ksewa As System.Windows.Forms.RadioButton
End Class
