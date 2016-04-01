<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class edit_kontak
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(edit_kontak))
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.id = New DevExpress.XtraEditors.TextEdit()
        Me.nama = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.tel1 = New DevExpress.XtraEditors.TextEdit()
        Me.tel2 = New DevExpress.XtraEditors.TextEdit()
        Me.provinsi = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tel1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tel2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.provinsi.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(88, 167)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 149
        Me.Submit.Text = "Submit"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(194, 167)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 150
        Me.SimpleButton1.Text = "Cancel"
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(101, 22)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(100, 20)
        Me.id.TabIndex = 1
        '
        'nama
        '
        Me.nama.Location = New System.Drawing.Point(128, 46)
        Me.nama.Name = "nama"
        Me.nama.Size = New System.Drawing.Size(143, 20)
        Me.nama.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(5, 49)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(99, 18)
        Me.LabelControl2.TabIndex = 33
        Me.LabelControl2.Text = "Nama Kontak :"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(5, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 18)
        Me.LabelControl1.TabIndex = 32
        Me.LabelControl1.Text = "ID Principle :"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Location = New System.Drawing.Point(5, 73)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl6.TabIndex = 52
        Me.LabelControl6.Text = "Telepon 1 :"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Location = New System.Drawing.Point(5, 97)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(75, 18)
        Me.LabelControl7.TabIndex = 53
        Me.LabelControl7.Text = "Telepon 2 :"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(5, 121)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(43, 18)
        Me.LabelControl8.TabIndex = 54
        Me.LabelControl8.Text = "Email :"
        '
        'tel1
        '
        Me.tel1.Location = New System.Drawing.Point(86, 70)
        Me.tel1.Name = "tel1"
        Me.tel1.Size = New System.Drawing.Size(165, 20)
        Me.tel1.TabIndex = 4
        '
        'tel2
        '
        Me.tel2.Location = New System.Drawing.Point(86, 94)
        Me.tel2.Name = "tel2"
        Me.tel2.Size = New System.Drawing.Size(165, 20)
        Me.tel2.TabIndex = 5
        '
        'provinsi
        '
        Me.provinsi.Location = New System.Drawing.Point(69, 118)
        Me.provinsi.Name = "provinsi"
        Me.provinsi.Size = New System.Drawing.Size(143, 20)
        Me.provinsi.TabIndex = 6
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.provinsi)
        Me.GroupControl1.Controls.Add(Me.tel2)
        Me.GroupControl1.Controls.Add(Me.tel1)
        Me.GroupControl1.Controls.Add(Me.LabelControl8)
        Me.GroupControl1.Controls.Add(Me.LabelControl7)
        Me.GroupControl1.Controls.Add(Me.LabelControl6)
        Me.GroupControl1.Controls.Add(Me.LabelControl1)
        Me.GroupControl1.Controls.Add(Me.LabelControl2)
        Me.GroupControl1.Controls.Add(Me.nama)
        Me.GroupControl1.Controls.Add(Me.id)
        Me.GroupControl1.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(282, 149)
        Me.GroupControl1.TabIndex = 148
        Me.GroupControl1.Text = "Data"
        '
        'edit_kontak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 204)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "edit_kontak"
        Me.Text = "Edit Kontak Principle"
        CType(Me.id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tel1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tel2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.provinsi.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents nama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tel1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tel2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents provinsi As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
