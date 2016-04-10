<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KIR_Truk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KIR_Truk))
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.tanggalkir = New System.Windows.Forms.DateTimePicker()
        Me.tanggalhabiskir = New System.Windows.Forms.RadioButton()
        Me.nama = New System.Windows.Forms.RadioButton()
        Me.id = New System.Windows.Forms.RadioButton()
        Me.cari = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit()
        Me.TextEdit3 = New DevExpress.XtraEditors.TextEdit()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.GridControl1)
        Me.GroupControl3.Location = New System.Drawing.Point(271, 173)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(757, 302)
        Me.GroupControl3.TabIndex = 40
        Me.GroupControl3.Text = "Data Kir Truk"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(8, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(747, 273)
        Me.GridControl1.TabIndex = 7
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.tanggalkir)
        Me.GroupControl1.Controls.Add(Me.tanggalhabiskir)
        Me.GroupControl1.Controls.Add(Me.nama)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Controls.Add(Me.cari)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 71)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(251, 96)
        Me.GroupControl1.TabIndex = 39
        Me.GroupControl1.Text = "Cari Berdasarkan"
        '
        'tanggalkir
        '
        Me.tanggalkir.Location = New System.Drawing.Point(5, 65)
        Me.tanggalkir.Name = "tanggalkir"
        Me.tanggalkir.Size = New System.Drawing.Size(200, 21)
        Me.tanggalkir.TabIndex = 52
        Me.tanggalkir.Visible = False
        '
        'tanggalhabiskir
        '
        Me.tanggalhabiskir.AutoSize = True
        Me.tanggalhabiskir.Location = New System.Drawing.Point(5, 45)
        Me.tanggalhabiskir.Name = "tanggalhabiskir"
        Me.tanggalhabiskir.Size = New System.Drawing.Size(78, 17)
        Me.tanggalhabiskir.TabIndex = 3
        Me.tanggalhabiskir.Text = "Tanggal Kir"
        Me.tanggalhabiskir.UseVisualStyleBackColor = True
        '
        'nama
        '
        Me.nama.AutoSize = True
        Me.nama.Checked = True
        Me.nama.Location = New System.Drawing.Point(87, 24)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(82, 17)
        Me.nama.TabIndex = 2
        Me.nama.TabStop = True
        Me.nama.Text = "Nomor Polisi"
        Me.nama.UseVisualStyleBackColor = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(5, 24)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(73, 17)
        Me.id.TabIndex = 1
        Me.id.Text = "Kode Truk"
        Me.id.UseVisualStyleBackColor = True
        '
        'cari
        '
        Me.cari.Location = New System.Drawing.Point(5, 68)
        Me.cari.Name = "cari"
        Me.cari.Size = New System.Drawing.Size(241, 20)
        Me.cari.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 18)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Kode Kir:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(13, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Nomor Kir :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(659, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 18)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Tanggal Kir :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(659, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 18)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Tanggal Kir Berikutnya :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label5.Location = New System.Drawing.Point(684, 483)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 18)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Nominal Kir :"
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(100, 9)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(174, 20)
        Me.TextEdit1.TabIndex = 3
        '
        'TextEdit2
        '
        Me.TextEdit2.Location = New System.Drawing.Point(100, 35)
        Me.TextEdit2.Name = "TextEdit2"
        Me.TextEdit2.Size = New System.Drawing.Size(224, 20)
        Me.TextEdit2.TabIndex = 46
        '
        'TextEdit3
        '
        Me.TextEdit3.EditValue = ""
        Me.TextEdit3.Location = New System.Drawing.Point(775, 481)
        Me.TextEdit3.Name = "TextEdit3"
        Me.TextEdit3.Size = New System.Drawing.Size(253, 20)
        Me.TextEdit3.TabIndex = 47
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(829, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 48
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(829, 6)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker2.TabIndex = 49
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(928, 507)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 51
        Me.SimpleButton1.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(822, 507)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 50
        Me.Submit.Text = "Submit"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.PictureBox1)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 173)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(251, 302)
        Me.GroupControl2.TabIndex = 52
        Me.GroupControl2.Text = "Bukti Kir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(5, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 273)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'KIR_Truk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 541)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TextEdit3)
        Me.Controls.Add(Me.TextEdit2)
        Me.Controls.Add(Me.TextEdit1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "KIR_Truk"
        Me.Text = "Input Kir"
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents nama As System.Windows.Forms.RadioButton
    Friend WithEvents id As System.Windows.Forms.RadioButton
    Friend WithEvents cari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tanggalkir As System.Windows.Forms.DateTimePicker
    Friend WithEvents tanggalhabiskir As System.Windows.Forms.RadioButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
