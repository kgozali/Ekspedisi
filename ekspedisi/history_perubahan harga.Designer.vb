<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class history_perubahan_harga
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
        Me.history = New DevExpress.XtraGrid.GridControl()
        Me.datarute = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.history, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datarute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'history
        '
        Me.history.Location = New System.Drawing.Point(8, 24)
        Me.history.MainView = Me.datarute
        Me.history.Name = "history"
        Me.history.Size = New System.Drawing.Size(792, 464)
        Me.history.TabIndex = 0
        Me.history.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.datarute})
        '
        'datarute
        '
        Me.datarute.GridControl = Me.history
        Me.datarute.Name = "datarute"
        Me.datarute.OptionsBehavior.Editable = False
        Me.datarute.OptionsView.ShowGroupPanel = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.history)
        Me.GroupControl1.Location = New System.Drawing.Point(8, 8)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(808, 496)
        Me.GroupControl1.TabIndex = 123
        Me.GroupControl1.Text = "Daftar Rute"
        '
        'history_perubahan_harga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 514)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "history_perubahan_harga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hsitory Perubahan Harga"
        CType(Me.history, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datarute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents history As DevExpress.XtraGrid.GridControl
    Friend WithEvents datarute As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
