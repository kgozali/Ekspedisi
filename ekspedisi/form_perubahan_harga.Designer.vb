<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_perubahan_harga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_perubahan_harga))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.level = New System.Windows.Forms.RadioButton()
        Me.nama = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        Me.simpan = New DevExpress.XtraEditors.SimpleButton()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.rute = New DevExpress.XtraGrid.GridControl()
        Me.datarute = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datarute, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.rute)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 96)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(657, 296)
        Me.GroupControl1.TabIndex = 122
        Me.GroupControl1.Text = "Daftar Rute"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.level)
        Me.GroupControl2.Controls.Add(Me.nama)
        Me.GroupControl2.Controls.Add(Me.cari)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 8)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(250, 80)
        Me.GroupControl2.TabIndex = 123
        Me.GroupControl2.Text = "Cari Berdasarkan"
        '
        'level
        '
        Me.level.AutoSize = True
        Me.level.Location = New System.Drawing.Point(112, 24)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(113, 17)
        Me.level.TabIndex = 3
        Me.level.Text = "Nama Kota Tujuan"
        Me.level.UseVisualStyleBackColor = True
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Checked = True
        Me.nama.Location = New System.Drawing.Point(8, 24)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(100, 17)
        Me.nama.TabIndex = 2
        Me.nama.TabStop = True
        Me.nama.Text = "Nama Kota Asal"
        Me.nama.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(8, 48)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(235, 20)
        Me.cari.TabIndex = 0
        '
        'simpan
        '
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.Location = New System.Drawing.Point(496, 400)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(87, 27)
        Me.simpan.TabIndex = 125
        Me.simpan.Text = "Save"
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(586, 400)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(87, 27)
        Me.cancel.TabIndex = 124
        Me.cancel.Text = "Cancel"
        '
        'rute
        '
        Me.rute.Location = New System.Drawing.Point(8, 24)
        Me.rute.MainView = Me.datarute
        Me.rute.Name = "rute"
        Me.rute.Size = New System.Drawing.Size(640, 264)
        Me.rute.TabIndex = 0
        Me.rute.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.datarute})
        '
        'datarute
        '
        Me.datarute.GridControl = Me.rute
        Me.datarute.Name = "datarute"
        '
        'form_perubahan_harga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 433)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.cancel)
        Me.Name = "form_perubahan_harga"
        Me.Text = "Perubahan Harga"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datarute, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rute As DevExpress.XtraGrid.GridControl
    Friend WithEvents datarute As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents level As System.Windows.Forms.RadioButton
    Friend WithEvents nama As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
End Class
