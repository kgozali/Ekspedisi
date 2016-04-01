<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COA
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COA))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.kodeakun = New System.Windows.Forms.TextBox()
        Me.akundetil = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.save = New DevExpress.XtraEditors.SimpleButton()
        Me.reset = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl1.TabIndex = 149
        Me.LabelControl1.Text = "Tipe Akun :"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(107, 9)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(278, 21)
        Me.ComboBox1.TabIndex = 150
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(12, 36)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(80, 18)
        Me.LabelControl2.TabIndex = 151
        Me.LabelControl2.Text = "Kode Akun :"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(12, 60)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(86, 18)
        Me.LabelControl3.TabIndex = 152
        Me.LabelControl3.Text = "Nama Akun :"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(12, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(71, 18)
        Me.LabelControl4.TabIndex = 153
        Me.LabelControl4.Text = "Sub Akun :"
        '
        'kodeakun
        '
        Me.kodeakun.Location = New System.Drawing.Point(107, 33)
        Me.kodeakun.Name = "kodeakun"
        Me.kodeakun.Size = New System.Drawing.Size(172, 21)
        Me.kodeakun.TabIndex = 154
        '
        'akundetil
        '
        Me.akundetil.AutoSize = True
        Me.akundetil.Location = New System.Drawing.Point(285, 39)
        Me.akundetil.Name = "akundetil"
        Me.akundetil.Size = New System.Drawing.Size(80, 17)
        Me.akundetil.TabIndex = 155
        Me.akundetil.Text = "Akun Detail"
        Me.akundetil.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(107, 57)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(278, 21)
        Me.TextBox1.TabIndex = 156
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(107, 81)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(278, 21)
        Me.ComboBox2.TabIndex = 157
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(285, 108)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 159
        Me.SimpleButton1.Text = "Cancel"
        '
        'save
        '
        Me.save.Image = CType(resources.GetObject("save.Image"), System.Drawing.Image)
        Me.save.Location = New System.Drawing.Point(179, 108)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(100, 27)
        Me.save.TabIndex = 158
        Me.save.Text = "Save"
        '
        'reset
        '
        Me.reset.Image = CType(resources.GetObject("reset.Image"), System.Drawing.Image)
        Me.reset.Location = New System.Drawing.Point(73, 108)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(100, 27)
        Me.reset.TabIndex = 160
        Me.reset.Text = "Reset"
        '
        'COA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 142)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.akundetil)
        Me.Controls.Add(Me.kodeakun)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "COA"
        Me.Text = "COA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents kodeakun As System.Windows.Forms.TextBox
    Friend WithEvents akundetil As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents reset As DevExpress.XtraEditors.SimpleButton
End Class
