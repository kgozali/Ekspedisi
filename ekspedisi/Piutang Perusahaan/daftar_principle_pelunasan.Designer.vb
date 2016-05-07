<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class daftar_principle_pelunasan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(daftar_principle_pelunasan))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.dataprinciple = New DevExpress.XtraGrid.GridControl()
        Me.allprinciple = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.nama = New System.Windows.Forms.RadioButton()
        Me.id = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.submit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.dataprinciple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.allprinciple, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.dataprinciple)
        Me.GroupControl3.Location = New System.Drawing.Point(8, 90)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(776, 414)
        Me.GroupControl3.TabIndex = 151
        Me.GroupControl3.Text = "Data Principle"
        '
        'dataprinciple
        '
        Me.dataprinciple.Location = New System.Drawing.Point(8, 24)
        Me.dataprinciple.MainView = Me.allprinciple
        Me.dataprinciple.Name = "dataprinciple"
        Me.dataprinciple.Size = New System.Drawing.Size(760, 384)
        Me.dataprinciple.TabIndex = 1
        Me.dataprinciple.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.allprinciple})
        '
        'allprinciple
        '
        Me.allprinciple.GridControl = Me.dataprinciple
        Me.allprinciple.Name = "allprinciple"
        Me.allprinciple.OptionsBehavior.Editable = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.nama)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Controls.Add(Me.cari)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(263, 76)
        Me.GroupControl1.TabIndex = 150
        Me.GroupControl1.Text = "Cari Berdasarkan"
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Checked = True
        Me.nama.Location = New System.Drawing.Point(98, 24)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(94, 17)
        Me.nama.TabIndex = 2
        Me.nama.TabStop = True
        Me.nama.Text = "Nama Principle"
        Me.nama.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(5, 24)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(91, 17)
        Me.id.TabIndex = 1
        Me.id.Text = "Kode Principle"
        Me.id.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(5, 51)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(253, 20)
        Me.cari.TabIndex = 0
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(684, 512)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 153
        Me.cancel.Text = "Cancel"
        '
        'submit
        '
        Me.submit.Image = CType(resources.GetObject("submit.Image"), System.Drawing.Image)
        Me.submit.Location = New System.Drawing.Point(576, 512)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(100, 27)
        Me.submit.TabIndex = 152
        Me.submit.Text = "Submit"
        '
        'daftar_principle_pelunasan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 547)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.submit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "daftar_principle_pelunasan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar Principle"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.dataprinciple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.allprinciple, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nama As System.Windows.Forms.RadioButton
    Friend WithEvents id As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dataprinciple As DevExpress.XtraGrid.GridControl
    Friend WithEvents allprinciple As DevExpress.XtraGrid.Views.Grid.GridView
End Class
