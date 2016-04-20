<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_barang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_barang))
        Me.simpan = New DevExpress.XtraEditors.SimpleButton()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.principle = New System.Windows.Forms.ComboBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.databarang = New DevExpress.XtraGrid.GridControl()
        Me.listbarang = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.nama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.keterangan = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.listbarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'simpan
        '
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.Location = New System.Drawing.Point(486, 432)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(100, 27)
        Me.simpan.TabIndex = 120
        Me.simpan.Text = "Save"
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(592, 432)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 119
        Me.cancel.Text = "Cancel"
        '
        'principle
        '
        Me.principle.FormattingEnabled = True
        Me.principle.Location = New System.Drawing.Point(72, 24)
        Me.principle.Name = "principle"
        Me.principle.Size = New System.Drawing.Size(229, 21)
        Me.principle.TabIndex = 49
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(5, 25)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(60, 18)
        Me.LabelControl3.TabIndex = 47
        Me.LabelControl3.Text = "Principle :"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.principle)
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(312, 56)
        Me.GroupControl1.TabIndex = 121
        Me.GroupControl1.Text = "Pilih Principle"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.databarang)
        Me.GroupControl2.Location = New System.Drawing.Point(8, 72)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(680, 352)
        Me.GroupControl2.TabIndex = 122
        Me.GroupControl2.Text = "Data Barang"
        '
        'databarang
        '
        Me.databarang.Location = New System.Drawing.Point(8, 24)
        Me.databarang.MainView = Me.listbarang
        Me.databarang.Name = "databarang"
        Me.databarang.Size = New System.Drawing.Size(664, 320)
        Me.databarang.TabIndex = 0
        Me.databarang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.listbarang})
        '
        'listbarang
        '
        Me.listbarang.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.id, Me.nama, Me.keterangan})
        Me.listbarang.GridControl = Me.databarang
        Me.listbarang.Name = "listbarang"
        '
        'id
        '
        Me.id.Caption = "Kode Barang"
        Me.id.Name = "id"
        Me.id.Visible = True
        Me.id.VisibleIndex = 0
        '
        'nama
        '
        Me.nama.Caption = "Nama Barang"
        Me.nama.Name = "nama"
        Me.nama.Visible = True
        Me.nama.VisibleIndex = 1
        '
        'keterangan
        '
        Me.keterangan.Caption = "Keterangan"
        Me.keterangan.Name = "keterangan"
        Me.keterangan.Visible = True
        Me.keterangan.VisibleIndex = 2
        '
        'add_barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 468)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.cancel)
        Me.Name = "add_barang"
        Me.Text = "Tambah Barang"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.databarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.listbarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents principle As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents databarang As DevExpress.XtraGrid.GridControl
    Friend WithEvents listbarang As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents keterangan As DevExpress.XtraGrid.Columns.GridColumn
End Class
