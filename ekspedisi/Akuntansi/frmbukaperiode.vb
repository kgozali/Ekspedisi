Imports MySql.Data.MySqlClient
Public Class frmbukaperiode

    Private Sub frmbukaperiode_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim maxdate As Date = CDate(Scalar("select tgl_awal from periode_transaksi"))
        DateEdit1.Properties.MaxValue = DateAdd(DateInterval.Day, -1, maxdate)
        DateEdit1.EditValue = DateAdd(DateInterval.Day, -1, maxdate)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim vartr As MySql.Data.MySqlClient.MySqlTransaction
        Try
            Dim command As New MySqlCommand()
            connect.Open()
            command.Connection = connect
            vartr = connect.BeginTransaction()
            command.Transaction = vartr
            'set periode aktif
            Dim tglawal As Date = CDate(Format(DateEdit1.EditValue, "yyyy-MM-01"))
            Dim tglakhir As Date = DateAdd(DateInterval.Month, 1, tglawal)
            tglakhir = DateAdd(DateInterval.Day, -1, tglakhir)
            command.CommandText = String.Format("delete from djurnal where no_jurnal in (select no_jurnal from jurnal where tgl='{0}' and no_jurnal like 'JPT%') ", Format(tglakhir, "yyyy-MM-dd"))
            command.ExecuteNonQuery()
            command.CommandText = String.Format("delete from jurnal where tgl='{0}' and no_jurnal like 'JPT%' ", Format(tglakhir, "yyyy-MM-dd"))
            command.ExecuteNonQuery()
            command.CommandText = String.Format("delete from tutupcoa_summary where tgl_bulan_tahun='{0}'", Format(tglakhir, "yyyyMM"))
            command.ExecuteNonQuery()
            command.CommandText = "delete from periode_transaksi"
            command.ExecuteNonQuery()
            command.CommandText = String.Format("insert into periode_transaksi (tgl_awal,tgl_akhir) VALUES ('{0}','{1}')", Format(tglawal, "yyyy-MM-dd"), Format(tglakhir, "yyyy-MM-dd"))
            command.ExecuteNonQuery()
            vartr.Commit()
            MessageBox.Show("Buka Periode Berhasil", "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Try
                vartr.Rollback()
            Catch ex2 As Exception
                MessageBox.Show(ex2.Message)
            End Try
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class