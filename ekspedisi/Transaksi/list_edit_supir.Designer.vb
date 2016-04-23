<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class list_edit_supir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(list_edit_supir))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.nama = New System.Windows.Forms.RadioButton()
        Me.id = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        Me.controlbooking = New DevExpress.XtraGrid.GridControl()
        Me.gridbooking = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.msiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.jumpmenu = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.addsiswabaru = New DevExpress.XtraBars.BarButtonItem()
        Me.deldata = New DevExpress.XtraBars.BarButtonItem()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.RibbonGalleryBarItem1 = New DevExpress.XtraBars.RibbonGalleryBarItem()
        Me.datasiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.BarSubItem1 = New DevExpress.XtraBars.BarSubItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.mastersiswa = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.BarButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
        Me.edit = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.controlbooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridbooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(670, 524)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 156
        Me.SimpleButton1.Text = "Cancel"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Location = New System.Drawing.Point(96, 24)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(79, 17)
        Me.nama.TabIndex = 2
        Me.nama.Text = "Nama Supir"
        Me.nama.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Checked = True
        Me.id.Location = New System.Drawing.Point(5, 24)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(76, 17)
        Me.id.TabIndex = 1
        Me.id.TabStop = True
        Me.id.Text = "Kode Supir"
        Me.id.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(8, 48)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(240, 20)
        Me.cari.TabIndex = 0
        '
        'controlbooking
        '
        Me.controlbooking.Location = New System.Drawing.Point(2, 24)
        Me.controlbooking.MainView = Me.gridbooking
        Me.controlbooking.Name = "controlbooking"
        Me.controlbooking.Size = New System.Drawing.Size(746, 384)
        Me.controlbooking.TabIndex = 0
        Me.controlbooking.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridbooking})
        '
        'gridbooking
        '
        Me.gridbooking.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.gridbooking.GridControl = Me.controlbooking
        Me.gridbooking.Name = "gridbooking"
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
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Caption = "Check"
        Me.RepositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "RibbonPage1"
        '
        'jumpmenu
        '
        Me.jumpmenu.Caption = "Main Menu"
        Me.jumpmenu.Glyph = CType(resources.GetObject("jumpmenu.Glyph"), System.Drawing.Image)
        Me.jumpmenu.Id = 31
        Me.jumpmenu.LargeGlyph = CType(resources.GetObject("jumpmenu.LargeGlyph"), System.Drawing.Image)
        Me.jumpmenu.Name = "jumpmenu"
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
        'addsiswabaru
        '
        Me.addsiswabaru.Caption = "Tambah Data"
        Me.addsiswabaru.Glyph = CType(resources.GetObject("addsiswabaru.Glyph"), System.Drawing.Image)
        Me.addsiswabaru.Id = 23
        Me.addsiswabaru.LargeGlyph = CType(resources.GetObject("addsiswabaru.LargeGlyph"), System.Drawing.Image)
        Me.addsiswabaru.Name = "addsiswabaru"
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
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(564, 524)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 155
        Me.Submit.Text = "Submit"
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
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.controlbooking)
        Me.GroupControl3.Location = New System.Drawing.Point(14, 98)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(756, 418)
        Me.GroupControl3.TabIndex = 154
        Me.GroupControl3.Text = "Data Booking"
        '
        'BarButtonItem7
        '
        Me.BarButtonItem7.Caption = "Master Data Ruang"
        Me.BarButtonItem7.Id = 20
        Me.BarButtonItem7.Name = "BarButtonItem7"
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
        'BarButtonItem9
        '
        Me.BarButtonItem9.Caption = "Master Data User"
        Me.BarButtonItem9.Id = 22
        Me.BarButtonItem9.Name = "BarButtonItem9"
        '
        'BarButtonItem8
        '
        Me.BarButtonItem8.Caption = "Master Data Guru"
        Me.BarButtonItem8.Id = 21
        Me.BarButtonItem8.Name = "BarButtonItem8"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.nama)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Controls.Add(Me.cari)
        Me.GroupControl1.Location = New System.Drawing.Point(14, 10)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(263, 80)
        Me.GroupControl1.TabIndex = 153
        Me.GroupControl1.Text = "Cari Berdasarkan"
        '
        'list_edit_supir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "list_edit_supir"
        Me.Text = "list_edit_supir"
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.controlbooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridbooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents nama As System.Windows.Forms.RadioButton
    Friend WithEvents id As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents controlbooking As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridbooking As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents msiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents jumpmenu As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents addsiswabaru As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents deldata As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RibbonGalleryBarItem1 As DevExpress.XtraBars.RibbonGalleryBarItem
    Friend WithEvents datasiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarSubItem1 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mastersiswa As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents BarButtonItem7 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem9 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem8 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
