<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_list_kota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_list_kota))
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.hasiledit = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.hasiledit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(179, 304)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 117
        Me.cancel.Text = "Cancel"
        '
        'hasiledit
        '
        Me.hasiledit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.hasiledit.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.hasiledit.Location = New System.Drawing.Point(5, 24)
        Me.hasiledit.Name = "hasiledit"
        Me.hasiledit.ReadOnly = True
        Me.hasiledit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.hasiledit.Size = New System.Drawing.Size(245, 257)
        Me.hasiledit.TabIndex = 48
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama Kota"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 200
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.hasiledit)
        Me.GroupControl1.Location = New System.Drawing.Point(23, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(256, 286)
        Me.GroupControl1.TabIndex = 116
        Me.GroupControl1.Text = "Daftar Edit Kota"
        '
        'edit_list_kota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(291, 339)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "edit_list_kota"
        Me.Text = "Edit List Kota"
        CType(Me.hasiledit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents hasiledit As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
