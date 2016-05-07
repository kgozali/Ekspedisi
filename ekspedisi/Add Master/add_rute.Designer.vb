<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class add_rute
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(add_rute))
        Me.unit = New DevExpress.XtraEditors.TextEdit()
        Me.hargaunit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.principle = New System.Windows.Forms.ComboBox()
        Me.tujuan = New System.Windows.Forms.ComboBox()
        Me.asal = New System.Windows.Forms.ComboBox()
        Me.simpan = New DevExpress.XtraEditors.SimpleButton()
        Me.cancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hargaunit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'unit
        '
        Me.unit.Location = New System.Drawing.Point(132, 129)
        Me.unit.Name = "unit"
        Me.unit.Size = New System.Drawing.Size(169, 20)
        Me.unit.TabIndex = 6
        '
        'hargaunit
        '
        Me.hargaunit.Location = New System.Drawing.Point(132, 106)
        Me.hargaunit.Name = "hargaunit"
        Me.hargaunit.Size = New System.Drawing.Size(169, 20)
        Me.hargaunit.TabIndex = 5
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(87, 127)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(35, 18)
        Me.LabelControl8.TabIndex = 54
        Me.LabelControl8.Text = "Unit :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(19, 105)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(103, 18)
        Me.LabelControl7.TabIndex = 53
        Me.LabelControl7.Text = "Harga per unit :"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(31, 80)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(91, 18)
        Me.LabelControl6.TabIndex = 52
        Me.LabelControl6.Text = "Kota Tujuan :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(44, 26)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(78, 18)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "Kode Rute :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(51, 52)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 18)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "Kota Asal :"
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(132, 27)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(169, 20)
        Me.id.TabIndex = 1
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.LabelControl3)
        Me.GroupControl1.Controls.Add(Me.principle)
        Me.GroupControl1.Controls.Add(Me.tujuan)
        Me.GroupControl1.Controls.Add(Me.asal)
        Me.GroupControl1.Controls.Add(Me.unit)
        Me.GroupControl1.Controls.Add(Me.hargaunit)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Location = New System.Drawing.Point(9, 11)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(329, 189)
        Me.GroupControl1.TabIndex = 162
        Me.GroupControl1.Text = "Data"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(23, 151)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(99, 18)
        Me.LabelControl3.TabIndex = 58
        Me.LabelControl3.Text = "Nama Principle:"
        '
        'principle
        '
        Me.principle.FormattingEnabled = True
        Me.principle.Location = New System.Drawing.Point(132, 152)
        Me.principle.Name = "principle"
        Me.principle.Size = New System.Drawing.Size(169, 21)
        Me.principle.TabIndex = 57
        '
        'tujuan
        '
        Me.tujuan.FormattingEnabled = True
        Me.tujuan.Location = New System.Drawing.Point(132, 81)
        Me.tujuan.Name = "tujuan"
        Me.tujuan.Size = New System.Drawing.Size(169, 21)
        Me.tujuan.TabIndex = 56
        '
        'asal
        '
        Me.asal.FormattingEnabled = True
        Me.asal.Location = New System.Drawing.Point(132, 53)
        Me.asal.Name = "asal"
        Me.asal.Size = New System.Drawing.Size(169, 21)
        Me.asal.TabIndex = 55
        '
        'simpan
        '
        Me.simpan.Image = CType(resources.GetObject("simpan.Image"), System.Drawing.Image)
        Me.simpan.Location = New System.Drawing.Point(132, 206)
        Me.simpan.Name = "simpan"
        Me.simpan.Size = New System.Drawing.Size(100, 27)
        Me.simpan.TabIndex = 164
        Me.simpan.Text = "Save"
        '
        'cancel
        '
        Me.cancel.Image = CType(resources.GetObject("cancel.Image"), System.Drawing.Image)
        Me.cancel.Location = New System.Drawing.Point(238, 206)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(100, 27)
        Me.cancel.TabIndex = 163
        Me.cancel.Text = "Cancel"
        '
        'add_rute
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 247)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.simpan)
        Me.Controls.Add(Me.cancel)
        Me.Name = "add_rute"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tambah Rute"
        CType(Me.unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hargaunit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents unit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents hargaunit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents principle As System.Windows.Forms.ComboBox
    Friend WithEvents tujuan As System.Windows.Forms.ComboBox
    Friend WithEvents asal As System.Windows.Forms.ComboBox
    Friend WithEvents simpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cancel As DevExpress.XtraEditors.SimpleButton
End Class
