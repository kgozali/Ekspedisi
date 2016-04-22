<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftar_karyawan_pelunasan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(daftar_karyawan_pelunasan))
        Me.viewdatakaryawan = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.datakaryawan = New DevExpress.XtraGrid.GridControl()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.nama = New System.Windows.Forms.RadioButton()
        Me.id = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.viewdatakaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datakaryawan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'viewdatakaryawan
        '
        Me.viewdatakaryawan.GridControl = Me.datakaryawan
        Me.viewdatakaryawan.Name = "viewdatakaryawan"
        Me.viewdatakaryawan.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.viewdatakaryawan.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.viewdatakaryawan.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.[False]
        Me.viewdatakaryawan.OptionsBehavior.Editable = False
        Me.viewdatakaryawan.OptionsSelection.EnableAppearanceFocusedCell = False
        '
        'datakaryawan
        '
        Me.datakaryawan.Location = New System.Drawing.Point(5, 24)
        Me.datakaryawan.MainView = Me.viewdatakaryawan
        Me.datakaryawan.Name = "datakaryawan"
        Me.datakaryawan.Size = New System.Drawing.Size(750, 393)
        Me.datakaryawan.TabIndex = 0
        Me.datakaryawan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.viewdatakaryawan})
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.datakaryawan)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 94)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(760, 422)
        Me.GroupControl3.TabIndex = 147
        Me.GroupControl3.Text = "Data Karayawan"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.nama)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Controls.Add(Me.cari)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(263, 76)
        Me.GroupControl1.TabIndex = 146
        Me.GroupControl1.Text = "Cari Berdasarkan"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Checked = True
        Me.nama.Location = New System.Drawing.Point(104, 24)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(103, 17)
        Me.nama.TabIndex = 2
        Me.nama.TabStop = True
        Me.nama.Text = "Nama Karyawan"
        Me.nama.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(5, 24)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 17)
        Me.id.TabIndex = 1
        Me.id.Text = "Kode Karyawan"
        Me.id.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(5, 51)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(253, 20)
        Me.cari.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(672, 522)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 149
        Me.SimpleButton1.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(566, 522)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 148
        Me.Submit.Text = "Submit"
        '
        'daftar_karyawan_pelunasan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 559)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Submit)
        Me.Name = "daftar_karyawan_pelunasan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Karyawan"
        CType(Me.viewdatakaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datakaryawan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents viewdatakaryawan As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents datakaryawan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nama As System.Windows.Forms.RadioButton
    Friend WithEvents id As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
End Class
