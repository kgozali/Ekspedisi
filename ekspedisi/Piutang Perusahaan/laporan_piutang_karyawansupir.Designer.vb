<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class laporan_piutang_karyawansupir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(laporan_piutang_karyawansupir))
        Me.DocumentViewer1 = New DevExpress.XtraPrinting.Preview.DocumentViewer()
        Me.SuspendLayout()
        '
        'DocumentViewer1
        '
        Me.DocumentViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DocumentViewer1.IsMetric = False
        Me.DocumentViewer1.Location = New System.Drawing.Point(0, 0)
        Me.DocumentViewer1.Name = "DocumentViewer1"
        Me.DocumentViewer1.Size = New System.Drawing.Size(1013, 606)
        Me.DocumentViewer1.TabIndex = 0
        '
        'laporan_piutang_karyawansupir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 606)
        Me.Controls.Add(Me.DocumentViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "laporan_piutang_karyawansupir"
        Me.Text = "Laporan Pinjaman Supir & Karyawan"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DocumentViewer1 As DevExpress.XtraPrinting.Preview.DocumentViewer
End Class
