<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transaksi_kas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(transaksi_kas))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.tanggalterkirim = New System.Windows.Forms.DateTimePicker()
        Me.idbooking = New DevExpress.XtraEditors.ButtonEdit()
        Me.id = New System.Windows.Forms.TextBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.datatransaksi = New System.Windows.Forms.DataGridView()
        CType(Me.idbooking.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.datatransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(522, 466)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 159
        Me.SimpleButton1.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(416, 466)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 158
        Me.Submit.Text = "Submit"
        '
        'tanggalterkirim
        '
        Me.tanggalterkirim.Location = New System.Drawing.Point(147, 57)
        Me.tanggalterkirim.Name = "tanggalterkirim"
        Me.tanggalterkirim.Size = New System.Drawing.Size(200, 21)
        Me.tanggalterkirim.TabIndex = 5
        '
        'idbooking
        '
        Me.idbooking.Location = New System.Drawing.Point(104, 34)
        Me.idbooking.Name = "idbooking"
        Me.idbooking.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.idbooking.Size = New System.Drawing.Size(128, 20)
        Me.idbooking.TabIndex = 2
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(111, 9)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(117, 21)
        Me.id.TabIndex = 1
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 60)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(129, 18)
        Me.LabelControl4.TabIndex = 149
        Me.LabelControl4.Text = "Tanggal Transaksi :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 84)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(85, 18)
        Me.LabelControl3.TabIndex = 148
        Me.LabelControl3.Text = "Keterangan :"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 18)
        Me.LabelControl2.TabIndex = 147
        Me.LabelControl2.Text = "Nama Akun :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(93, 18)
        Me.LabelControl1.TabIndex = 146
        Me.LabelControl1.Text = "ID Transaksi :"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(103, 85)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(340, 96)
        Me.RichTextBox1.TabIndex = 160
        Me.RichTextBox1.Text = ""
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.datatransaksi)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 187)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(610, 273)
        Me.GroupControl1.TabIndex = 161
        Me.GroupControl1.Text = "Data Transaksi"
        '
        'datatransaksi
        '
        Me.datatransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datatransaksi.Location = New System.Drawing.Point(5, 24)
        Me.datatransaksi.Name = "datatransaksi"
        Me.datatransaksi.Size = New System.Drawing.Size(600, 244)
        Me.datatransaksi.TabIndex = 0
        '
        'transaksi_kas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 498)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.tanggalterkirim)
        Me.Controls.Add(Me.idbooking)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "transaksi_kas"
        Me.Text = "Transaksi Kas"
        CType(Me.idbooking.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.datatransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tanggalterkirim As System.Windows.Forms.DateTimePicker
    Friend WithEvents idbooking As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents datatransaksi As System.Windows.Forms.DataGridView
End Class
