<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historyperubahan
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
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.perubahan = New DevExpress.XtraGrid.GridControl()
        Me.daftarperubahan = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.perubahan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.daftarperubahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.perubahan)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(848, 488)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Daftar Perubahan Harga"
        '
        'perubahan
        '
        Me.perubahan.Location = New System.Drawing.Point(8, 24)
        Me.perubahan.MainView = Me.daftarperubahan
        Me.perubahan.Name = "perubahan"
        Me.perubahan.Size = New System.Drawing.Size(832, 456)
        Me.perubahan.TabIndex = 0
        Me.perubahan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.daftarperubahan})
        '
        'daftarperubahan
        '
        Me.daftarperubahan.GridControl = Me.perubahan
        Me.daftarperubahan.Name = "daftarperubahan"
        '
        'historyperubahan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 504)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "historyperubahan"
        Me.Text = "Perubahan Harga"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.perubahan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.daftarperubahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents perubahan As DevExpress.XtraGrid.GridControl
    Friend WithEvents daftarperubahan As DevExpress.XtraGrid.Views.Grid.GridView
End Class
