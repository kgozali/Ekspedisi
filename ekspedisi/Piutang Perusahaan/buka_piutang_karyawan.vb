Public Class buka_piutang_karyawan 


    Private Sub buka_piutang_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id.Text = autogenerate("BPK", "select max(id_piutangkaryawan) FROM piutang_karyawan p")
        Dim data As New DataTable
        data = DtTable("select * from makun")
    End Sub

 
    Private Sub pilihkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles pilihkaryawan.ButtonClick
        karyawan_piutang.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        InsertInto("INSERT INTO `piutang_karyawan`(`id_piutangkaryawan`, `id_karyawan`, `tgl`, `nominal`, `path_bukti`, `jatuh_tempo`, `keterangan`, `status`, `cetakan_ke`) VALUES ('" & id.Text & "','" & idkaryawan.Text & "'," & tanggalpiutang.Value.ToString("yyyMMdd") & "," & nominal.Text & ",'path'," & Tanggaljatuhtempo.Value.ToString("yyyyMMdd") & "," & keterangan.Text & ",'0','0')")
    End Sub
End Class