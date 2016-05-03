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
        Me.rute = New DevExpress.XtraGrid.GridControl()
        Me.datarute = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.principle = New System.Windows.Forms.ComboBox()
        Me.namaprinciple = New System.Windows.Forms.RadioButton()
        Me.namatujuan = New System.Windows.Forms.RadioButton()
        Me.namaasal = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        Me.simpan = New DevExpress.XtraEditors.SimpleButton()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.history = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.rute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datarute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.rute)
        Me.GroupControl1.Location = New System.Drawing.Point(16, 112)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(657, 296)
        Me.GroupControl1.TabIndex = 122
        Me.GroupControl1.Text = "Daftar Rute"
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
        Me.datarute.OptionsView.ShowGroupPanel = False
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.principle)
        Me.GroupControl2.Controls.Add(Me.namaprinciple)
        Me.GroupControl2.Controls.Add(Me.namatujuan)
        Me.GroupControl2.Controls.Add(Me.namaasal)
        Me.GroupControl2.Controls.Add(Me.cari)
        Me.GroupControl2.Location = New System.Drawing.Point(16, 8)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(250, 96)
        Me.GroupControl2.TabIndex = 123
        Me.GroupControl2.Text = "Cari Berdasarkan"
        '
        'principle
        '
        Me.principle.FormattingEnabled = True
        Me.principle.Location = New System.Drawing.Point(8, 72)
        Me.principle.Name = "principle"
        Me.principle.Size = New System.Drawing.Size(144, 21)
        Me.principle.TabIndex = 126
        Me.principle.Visible = False
        '
        'namaprinciple
        '
        Me.namaprinciple.AutoSize = True
        Me.namaprinciple.Location = New System.Drawing.Point(8, 48)
        Me.namaprinciple.Name = "namaprinciple"
        Me.namaprinciple.Size = New System.Drawing.Size(94, 17)
        Me.namaprinciple.TabIndex = 4
        Me.namaprinciple.Text = "Nama Principle"
        Me.namaprinciple.UseVisualStyleBackColor = True
        '
        'namatujuan
        '
        Me.namatujuan.AutoSize = True
        Me.namatujuan.Location = New System.Drawing.Point(112, 24)
        Me.namatujuan.Name = "namatujuan"
        Me.namatujuan.Size = New System.Drawing.Size(113, 17)
        Me.namatujuan.TabIndex = 3
        Me.namatujuan.Text = "Nama Kota Tujuan"
        Me.namatujuan.UseVisualStyleBackColor = True
        '
        'namaasal
        '
        Me.namaasal.AutoSize = True
        Me.namaasal.Checked = True
        Me.namaasal.Location = New System.Drawing.Point(8, 24)
        Me.namaasal.Name = "namaasal"
        Me.namaasal.Size = New System.Drawing.Size(100, 17)
        Me.namaasal.TabIndex = 2
        Me.namaasal.TabStop = True
        Me.namaasal.Text = "Nama Kota Asal"
        Me.namaasal.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(8, 72)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(235, 20)
        Me.cari.TabIndex = 0
        '
        'simpan
        '
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.Location = New System.Drawing.Point(496, 416)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(87, 27)
        Me.simpan.TabIndex = 125
        Me.simpan.Text = "Save"
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(586, 416)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(87, 27)
        Me.cancel.TabIndex = 124
        Me.cancel.Text = "Cancel"
        '
        'history
        '
        Me.history.Image = CType(resources.GetObject("history.Image"), System.Drawing.Image)
        Me.history.Location = New System.Drawing.Point(480, 80)
        Me.history.Name = "history"
        Me.history.Size = New System.Drawing.Size(191, 27)
        Me.history.TabIndex = 126
        Me.history.Text = "History Perubahan Harga"
        '
        'form_perubahan_harga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 450)
        Me.Controls.Add(Me.history)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.cancel)
        Me.Name = "form_perubahan_harga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Perubahan Harga Supir"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.rute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datarute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rute As DevExpress.XtraGrid.GridControl
    Friend WithEvents datarute As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents namatujuan As System.Windows.Forms.RadioButton
    Friend WithEvents namaasal As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents principle As System.Windows.Forms.ComboBox
    Friend WithEvents namaprinciple As System.Windows.Forms.RadioButton
    Friend WithEvents history As DevExpress.XtraEditors.SimpleButton
End Class
