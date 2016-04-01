Partial Public Class main_menu
    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main_menu))
        Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.menumasterdata = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.makun = New DevExpress.XtraBars.BarButtonItem()
        Me.mbank = New DevExpress.XtraBars.BarButtonItem()
        Me.mbarang = New DevExpress.XtraBars.BarButtonItem()
        Me.mcustomer = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
        Me.mkaryawan = New DevExpress.XtraBars.BarButtonItem()
        Me.mkategorisupplier = New DevExpress.XtraBars.BarButtonItem()
        Me.mkontakprinciple = New DevExpress.XtraBars.BarButtonItem()
        Me.mkota = New DevExpress.XtraBars.BarButtonItem()
        Me.mperubahanharaga = New DevExpress.XtraBars.BarButtonItem()
        Me.mprinciple = New DevExpress.XtraBars.BarButtonItem()
        Me.mrekening = New DevExpress.XtraBars.BarButtonItem()
        Me.mrute = New DevExpress.XtraBars.BarButtonItem()
        Me.msupplier = New DevExpress.XtraBars.BarButtonItem()
        Me.mtruck = New DevExpress.XtraBars.BarButtonItem()
        Me.muser = New DevExpress.XtraBars.BarButtonItem()
        Me.BarCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
        Me.menutransaksi = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu2 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
        Me.menulaporan = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu3 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.masuklogin = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.menuhistoryharga = New DevExpress.XtraBars.BarButtonItem()
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbonControl1
        '
        Me.ribbonControl1.ExpandCollapseItem.Id = 0
        Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.menumasterdata, Me.mkaryawan, Me.mbank, Me.mbarang, Me.BarCheckItem1, Me.mcustomer, Me.BarButtonItem1, Me.mkategorisupplier, Me.mkontakprinciple, Me.mkota, Me.mperubahanharaga, Me.mprinciple, Me.mrekening, Me.mrute, Me.msupplier, Me.mtruck, Me.muser, Me.makun, Me.menutransaksi, Me.menulaporan, Me.BarButtonItem2, Me.BarButtonItem3, Me.BarButtonItem4, Me.BarButtonItem5, Me.BarButtonItem6})
        Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.ribbonControl1.MaxItemId = 27
        Me.ribbonControl1.Name = "ribbonControl1"
        Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
        Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
        Me.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowCategoryInCaption = False
        Me.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowFullScreenButton = DevExpress.Utils.DefaultBoolean.[False]
        Me.ribbonControl1.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide
        Me.ribbonControl1.ShowQatLocationSelector = False
        Me.ribbonControl1.ShowToolbarCustomizeItem = False
        Me.ribbonControl1.Size = New System.Drawing.Size(758, 123)
        Me.ribbonControl1.Toolbar.ShowCustomizeItem = False
        '
        'menumasterdata
        '
        Me.menumasterdata.ActAsDropDown = True
        Me.menumasterdata.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.menumasterdata.Caption = "Master Data"
        Me.menumasterdata.DropDownControl = Me.PopupMenu1
        Me.menumasterdata.Glyph = CType(resources.GetObject("menumasterdata.Glyph"), System.Drawing.Image)
        Me.menumasterdata.Id = 1
        Me.menumasterdata.LargeGlyph = CType(resources.GetObject("menumasterdata.LargeGlyph"), System.Drawing.Image)
        Me.menumasterdata.Name = "menumasterdata"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.ItemLinks.Add(Me.makun)
        Me.PopupMenu1.ItemLinks.Add(Me.mbank)
        Me.PopupMenu1.ItemLinks.Add(Me.mbarang)
        Me.PopupMenu1.ItemLinks.Add(Me.mcustomer)
        Me.PopupMenu1.ItemLinks.Add(Me.BarButtonItem1)
        Me.PopupMenu1.ItemLinks.Add(Me.mkaryawan)
        Me.PopupMenu1.ItemLinks.Add(Me.mkategorisupplier)
        Me.PopupMenu1.ItemLinks.Add(Me.mkontakprinciple)
        Me.PopupMenu1.ItemLinks.Add(Me.mkota)
        Me.PopupMenu1.ItemLinks.Add(Me.mperubahanharaga)
        Me.PopupMenu1.ItemLinks.Add(Me.mprinciple)
        Me.PopupMenu1.ItemLinks.Add(Me.mrekening)
        Me.PopupMenu1.ItemLinks.Add(Me.mrute)
        Me.PopupMenu1.ItemLinks.Add(Me.msupplier)
        Me.PopupMenu1.ItemLinks.Add(Me.mtruck)
        Me.PopupMenu1.ItemLinks.Add(Me.muser)
        Me.PopupMenu1.Name = "PopupMenu1"
        Me.PopupMenu1.Ribbon = Me.ribbonControl1
        '
        'makun
        '
        Me.makun.Caption = "Master Akun"
        Me.makun.Id = 18
        Me.makun.Name = "makun"
        '
        'mbank
        '
        Me.mbank.Caption = "Master Bank"
        Me.mbank.Id = 3
        Me.mbank.Name = "mbank"
        '
        'mbarang
        '
        Me.mbarang.Caption = "Master Barang"
        Me.mbarang.Id = 4
        Me.mbarang.Name = "mbarang"
        '
        'mcustomer
        '
        Me.mcustomer.Caption = "Master Customer"
        Me.mcustomer.Id = 6
        Me.mcustomer.Name = "mcustomer"
        '
        'BarButtonItem1
        '
        Me.BarButtonItem1.Caption = "Master Jabatan"
        Me.BarButtonItem1.Id = 7
        Me.BarButtonItem1.Name = "BarButtonItem1"
        '
        'mkaryawan
        '
        Me.mkaryawan.Caption = "Master Karyawan"
        Me.mkaryawan.Id = 2
        Me.mkaryawan.Name = "mkaryawan"
        '
        'mkategorisupplier
        '
        Me.mkategorisupplier.Caption = "Master Katerogri Supplier"
        Me.mkategorisupplier.Id = 8
        Me.mkategorisupplier.Name = "mkategorisupplier"
        '
        'mkontakprinciple
        '
        Me.mkontakprinciple.Caption = "Master Kontak Principle"
        Me.mkontakprinciple.Id = 9
        Me.mkontakprinciple.Name = "mkontakprinciple"
        '
        'mkota
        '
        Me.mkota.Caption = "Master Kota"
        Me.mkota.Id = 10
        Me.mkota.Name = "mkota"
        '
        'mperubahanharaga
        '
        Me.mperubahanharaga.Caption = "History Perubahan Harga"
        Me.mperubahanharaga.Id = 11
        Me.mperubahanharaga.Name = "mperubahanharaga"
        '
        'mprinciple
        '
        Me.mprinciple.Caption = "Master Principle"
        Me.mprinciple.Id = 12
        Me.mprinciple.Name = "mprinciple"
        '
        'mrekening
        '
        Me.mrekening.Caption = "Master Rekening"
        Me.mrekening.Id = 13
        Me.mrekening.Name = "mrekening"
        '
        'mrute
        '
        Me.mrute.Caption = "Master Rute"
        Me.mrute.Id = 14
        Me.mrute.Name = "mrute"
        '
        'msupplier
        '
        Me.msupplier.Caption = "Master Supplier"
        Me.msupplier.Id = 15
        Me.msupplier.Name = "msupplier"
        '
        'mtruck
        '
        Me.mtruck.Caption = "Master Truck"
        Me.mtruck.Id = 16
        Me.mtruck.Name = "mtruck"
        '
        'muser
        '
        Me.muser.Caption = "Master User"
        Me.muser.Id = 17
        Me.muser.Name = "muser"
        '
        'BarCheckItem1
        '
        Me.BarCheckItem1.Id = 5
        Me.BarCheckItem1.Name = "BarCheckItem1"
        '
        'menutransaksi
        '
        Me.menutransaksi.ActAsDropDown = True
        Me.menutransaksi.Caption = "Transaksi"
        Me.menutransaksi.DropDownControl = Me.PopupMenu2
        Me.menutransaksi.Glyph = CType(resources.GetObject("menutransaksi.Glyph"), System.Drawing.Image)
        Me.menutransaksi.Id = 20
        Me.menutransaksi.LargeGlyph = CType(resources.GetObject("menutransaksi.LargeGlyph"), System.Drawing.Image)
        Me.menutransaksi.Name = "menutransaksi"
        '
        'PopupMenu2
        '
        Me.PopupMenu2.ItemLinks.Add(Me.BarButtonItem2)
        Me.PopupMenu2.ItemLinks.Add(Me.BarButtonItem3)
        Me.PopupMenu2.ItemLinks.Add(Me.BarButtonItem4)
        Me.PopupMenu2.ItemLinks.Add(Me.BarButtonItem5)
        Me.PopupMenu2.ItemLinks.Add(Me.BarButtonItem6)
        Me.PopupMenu2.Name = "PopupMenu2"
        Me.PopupMenu2.Ribbon = Me.ribbonControl1
        '
        'BarButtonItem2
        '
        Me.BarButtonItem2.Caption = "Service Truck"
        Me.BarButtonItem2.Id = 22
        Me.BarButtonItem2.Name = "BarButtonItem2"
        '
        'BarButtonItem3
        '
        Me.BarButtonItem3.Caption = "Booking Truck"
        Me.BarButtonItem3.Id = 23
        Me.BarButtonItem3.Name = "BarButtonItem3"
        '
        'BarButtonItem4
        '
        Me.BarButtonItem4.Caption = "Delivery Order"
        Me.BarButtonItem4.Id = 24
        Me.BarButtonItem4.Name = "BarButtonItem4"
        '
        'BarButtonItem5
        '
        Me.BarButtonItem5.Caption = "Transaksi Kas"
        Me.BarButtonItem5.Id = 25
        Me.BarButtonItem5.Name = "BarButtonItem5"
        '
        'BarButtonItem6
        '
        Me.BarButtonItem6.Caption = "Transaksi Bank"
        Me.BarButtonItem6.Id = 26
        Me.BarButtonItem6.Name = "BarButtonItem6"
        '
        'menulaporan
        '
        Me.menulaporan.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.menulaporan.Caption = "Laporan"
        Me.menulaporan.DropDownControl = Me.PopupMenu3
        Me.menulaporan.Glyph = CType(resources.GetObject("menulaporan.Glyph"), System.Drawing.Image)
        Me.menulaporan.Id = 21
        Me.menulaporan.LargeGlyph = CType(resources.GetObject("menulaporan.LargeGlyph"), System.Drawing.Image)
        Me.menulaporan.Name = "menulaporan"
        '
        'PopupMenu3
        '
        Me.PopupMenu3.Name = "PopupMenu3"
        Me.PopupMenu3.Ribbon = Me.ribbonControl1
        '
        'ribbonPage1
        '
        Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
        Me.ribbonPage1.Name = "ribbonPage1"
        Me.ribbonPage1.Text = "ribbonPage1"
        '
        'ribbonPageGroup1
        '
        Me.ribbonPageGroup1.ItemLinks.Add(Me.menumasterdata, False, "", "", True)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.menutransaksi)
        Me.ribbonPageGroup1.ItemLinks.Add(Me.menulaporan)
        Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
        Me.ribbonPageGroup1.ShowCaptionButton = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.TextEdit1)
        Me.Panel1.Controls.Add(Me.masuklogin)
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Location = New System.Drawing.Point(200, 198)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(329, 163)
        Me.Panel1.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(121, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox1.Size = New System.Drawing.Size(173, 21)
        Me.TextBox1.TabIndex = 2
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(121, 33)
        Me.TextEdit1.MenuManager = Me.ribbonControl1
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(173, 20)
        Me.TextEdit1.TabIndex = 1
        '
        'masuklogin
        '
        Me.masuklogin.Location = New System.Drawing.Point(147, 129)
        Me.masuklogin.Name = "masuklogin"
        Me.masuklogin.Size = New System.Drawing.Size(75, 23)
        Me.masuklogin.TabIndex = 3
        Me.masuklogin.Text = "Login"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(38, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(59, 15)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = "Password :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(38, 36)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 15)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Username :"
        '
        'menuhistoryharga
        '
        Me.menuhistoryharga.Caption = "History Perubahan Harga"
        Me.menuhistoryharga.Glyph = CType(resources.GetObject("menuhistoryharga.Glyph"), System.Drawing.Image)
        Me.menuhistoryharga.Id = 19
        Me.menuhistoryharga.LargeGlyph = CType(resources.GetObject("menuhistoryharga.LargeGlyph"), System.Drawing.Image)
        Me.menuhistoryharga.Name = "menuhistoryharga"
        '
        'main_menu
        '
        Me.AllowFormGlass = DevExpress.Utils.DefaultBoolean.[False]
        Me.ClientSize = New System.Drawing.Size(758, 435)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ribbonControl1)
        Me.Name = "main_menu"
        Me.Ribbon = Me.ribbonControl1
        Me.Text = "Main Menu"
        CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents menumasterdata As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mkaryawan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mbank As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mbarang As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarCheckItem1 As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents mcustomer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mkategorisupplier As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mkontakprinciple As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mkota As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mperubahanharaga As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mprinciple As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mrekening As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mrute As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents msupplier As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents mtruck As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents muser As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents makun As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menutransaksi As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu2 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents menulaporan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem2 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem3 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem4 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem5 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem6 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupMenu3 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents masuklogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents menuhistoryharga As DevExpress.XtraBars.BarButtonItem
End Class
