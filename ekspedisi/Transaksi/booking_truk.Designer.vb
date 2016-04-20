<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class booking_truk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(booking_truk))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Submit = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.gridkontak = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.ButtonEdit1 = New DevExpress.XtraEditors.ButtonEdit()
        Me.ButtonEdit2 = New DevExpress.XtraEditors.ButtonEdit()
        Me.ButtonEdit4 = New DevExpress.XtraEditors.ButtonEdit()
        Me.TimeEdit1 = New DevExpress.XtraEditors.TimeEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridkontak, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ButtonEdit4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label1.Location = New System.Drawing.Point(32, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Booking"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Booking"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label4.Location = New System.Drawing.Point(576, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Principle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label6.Location = New System.Drawing.Point(88, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Truk "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(592, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Rute "
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(136, 6)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(138, 21)
        Me.id.TabIndex = 12
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(136, 31)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 21)
        Me.DateTimePicker1.TabIndex = 13
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(700, 480)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(100, 27)
        Me.SimpleButton1.TabIndex = 142
        Me.SimpleButton1.Text = "Cancel"
        '
        'Submit
        '
        Me.Submit.Image = CType(resources.GetObject("Submit.Image"), System.Drawing.Image)
        Me.Submit.Location = New System.Drawing.Point(594, 480)
        Me.Submit.Name = "Submit"
        Me.Submit.Size = New System.Drawing.Size(100, 27)
        Me.Submit.TabIndex = 141
        Me.Submit.Text = "Submit"
        '
        'GroupControl1
        '
        Me.GroupControl1.Location = New System.Drawing.Point(15, 112)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(785, 98)
        Me.GroupControl1.TabIndex = 146
        Me.GroupControl1.Text = "Data Booking"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(15, 136)
        Me.GridControl1.MainView = Me.gridkontak
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(775, 74)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridkontak})
        '
        'gridkontak
        '
        Me.gridkontak.GridControl = Me.GridControl1
        Me.gridkontak.Name = "gridkontak"
        '
        'ButtonEdit1
        '
        Me.ButtonEdit1.Location = New System.Drawing.Point(136, 56)
        Me.ButtonEdit1.Name = "ButtonEdit1"
        Me.ButtonEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ButtonEdit1.Size = New System.Drawing.Size(160, 20)
        Me.ButtonEdit1.TabIndex = 147
        '
        'ButtonEdit2
        '
        Me.ButtonEdit2.Location = New System.Drawing.Point(640, 7)
        Me.ButtonEdit2.Name = "ButtonEdit2"
        Me.ButtonEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ButtonEdit2.Size = New System.Drawing.Size(160, 20)
        Me.ButtonEdit2.TabIndex = 149
        '
        'ButtonEdit4
        '
        Me.ButtonEdit4.Location = New System.Drawing.Point(640, 32)
        Me.ButtonEdit4.Name = "ButtonEdit4"
        Me.ButtonEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
        Me.ButtonEdit4.Size = New System.Drawing.Size(160, 20)
        Me.ButtonEdit4.TabIndex = 151
        '
        'TimeEdit1
        '
        Me.TimeEdit1.EditValue = New Date(2016, 4, 8, 0, 0, 0, 0)
        Me.TimeEdit1.Location = New System.Drawing.Point(136, 78)
        Me.TimeEdit1.Name = "TimeEdit1"
        Me.TimeEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TimeEdit1.Size = New System.Drawing.Size(100, 20)
        Me.TimeEdit1.TabIndex = 152
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!)
        Me.Label3.Location = New System.Drawing.Point(56, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 18)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Jam Kirim"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.GridControl2)
        Me.GroupControl2.Location = New System.Drawing.Point(14, 228)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(700, 110)
        Me.GroupControl2.TabIndex = 147
        Me.GroupControl2.Text = "Pembayaran DP"
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(5, 24)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(690, 74)
        Me.GridControl2.TabIndex = 0
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(92, 361)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(375, 94)
        Me.RichTextBox2.TabIndex = 56
        Me.RichTextBox2.Text = ""
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(15, 361)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(61, 18)
        Me.LabelControl10.TabIndex = 55
        Me.LabelControl10.Text = "Catatan :"
        '
        'booking_truk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 519)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TimeEdit1)
        Me.Controls.Add(Me.ButtonEdit4)
        Me.Controls.Add(Me.ButtonEdit2)
        Me.Controls.Add(Me.ButtonEdit1)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Submit)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "booking_truk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking Truk"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridkontak, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ButtonEdit4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TimeEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents id As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents ButtonEdit1 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ButtonEdit2 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents ButtonEdit4 As DevExpress.XtraEditors.ButtonEdit
    Friend WithEvents TimeEdit1 As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridkontak As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
End Class
