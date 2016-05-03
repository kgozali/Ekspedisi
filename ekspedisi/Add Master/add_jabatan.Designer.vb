<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_jabatan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_jabatan))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.nama = New DevExpress.XtraEditors.TextEdit()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.simpan = New DevExpress.XtraEditors.SimpleButton()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.nama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.nama)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(296, 78)
        Me.GroupControl1.TabIndex = 142
        Me.GroupControl1.Text = "Data"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(11, 24)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(99, 18)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Kode Jabatan :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(5, 49)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(105, 18)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "Nama Jabatan :"
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(116, 50)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(143, 20)
        Me.nama.TabIndex = 46
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(116, 25)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 45
        '
        'simpan
        '
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.Location = New System.Drawing.Point(102, 96)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(100, 27)
        Me.simpan.TabIndex = 147
        Me.simpan.Text = "Save"
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(208, 96)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 146
        Me.cancel.Text = "Cancel"
        '
        'add_jabatan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(317, 132)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "add_jabatan"
        Me.Text = "Tambah Jabatan"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.nama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents nama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
End Class
