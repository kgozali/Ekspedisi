<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class harga_supir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(harga_supir))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.supir = New System.Windows.Forms.ComboBox()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.hargasupir = New DevExpress.XtraGrid.GridControl()
        Me.dataharga = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.kota = New System.Windows.Forms.RadioButton()
        Me.rute = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.hargasupir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataharga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.supir)
        Me.GroupControl1.Location = New System.Drawing.Point(281, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(248, 58)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Pilih Supir"
        '
        'supir
        '
        Me.supir.FormattingEnabled = True
        Me.supir.Location = New System.Drawing.Point(5, 24)
        Me.supir.Name = "supir"
        Me.supir.Size = New System.Drawing.Size(238, 21)
        Me.supir.TabIndex = 1
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.hargasupir)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 86)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(725, 414)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Input Harga"
        '
        'hargasupir
        '
        Me.hargasupir.Location = New System.Drawing.Point(5, 24)
        Me.hargasupir.MainView = Me.dataharga
        Me.hargasupir.Name = "hargasupir"
        Me.hargasupir.Size = New System.Drawing.Size(715, 385)
        Me.hargasupir.TabIndex = 0
        Me.hargasupir.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.dataharga})
        '
        'dataharga
        '
        Me.dataharga.GridControl = Me.hargasupir
        Me.dataharga.Name = "dataharga"
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(637, 506)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 151
        Me.cancel.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(531, 506)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 150
        Me.Submit.Text = "Submit"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.kota)
        Me.GroupControl3.Controls.Add(Me.rute)
        Me.GroupControl3.Controls.Add(Me.cari)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(263, 76)
        Me.GroupControl3.TabIndex = 152
        Me.GroupControl3.Text = "Cari Berdasarkan"
        '
        'kota
        '
        Me.kota.AutoSize = True
        Me.kota.Checked = True
        Me.kota.Location = New System.Drawing.Point(86, 24)
        Me.kota.Name = "kota"
        Me.kota.Size = New System.Drawing.Size(47, 17)
        Me.kota.TabIndex = 3
        Me.kota.TabStop = True
        Me.kota.Text = "Kota"
        Me.kota.UseVisualStyleBackColor = True
        '
        'rute
        '
        Me.rute.AutoSize = True
        Me.rute.Location = New System.Drawing.Point(5, 24)
        Me.rute.Name = "rute"
        Me.rute.Size = New System.Drawing.Size(75, 17)
        Me.rute.TabIndex = 1
        Me.rute.Text = "Kode Rute"
        Me.rute.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(5, 47)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(253, 20)
        Me.cari.TabIndex = 0
        '
        'harga_supir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 539)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "harga_supir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Harga Supir"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.hargasupir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataharga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents supir As System.Windows.Forms.ComboBox
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents hargasupir As DevExpress.XtraGrid.GridControl
    Friend WithEvents dataharga As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents kota As System.Windows.Forms.RadioButton
    Friend WithEvents rute As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
End Class
