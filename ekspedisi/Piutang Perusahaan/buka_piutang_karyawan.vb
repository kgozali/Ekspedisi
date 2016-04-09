Public Class buka_piutang_karyawan 


    Private Sub buka_piutang_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id.Text = autogenerate("BPK", "select max(id_piutangkaryawan) FROM piutang_karyawan p")
    End Sub

 
    Private Sub pilihkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles pilihkaryawan.ButtonClick
        karyawan_piutang.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class