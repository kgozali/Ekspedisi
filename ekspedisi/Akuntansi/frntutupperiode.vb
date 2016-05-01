Imports MySql.Data.MySqlClient

Public Class frntutupperiode
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'simpan ke summary coa
        Dim vartr As MySql.Data.MySqlClient.MySqlTransaction
        Dim sqlstr As String = ""
        Dim tglawal As Date = CDate(Format(DateEdit1.EditValue, "yyyy-MM-01"))
        Dim tglakhir As Date = DateAdd(DateInterval.Month, 1, DateEdit1.EditValue)
        tglakhir = DateAdd(DateInterval.Day, -1, tglakhir)
        Dim blanlalu As String = Format(DateAdd(DateInterval.Day, -1, DateEdit1.EditValue), "yyyyMM")
        Dim no_jurnal As String = autogenerate2("JPT", "select max(no_jurnal) from jurnal where no_jurnal like 'JPT%' and tgl='" & Format(tglakhir, "yyyy-MM-dd") & "'", tglakhir)
        Dim ilen As Long = 0

        Try
            Dim defakunlrbulan As String = Scalar("select * from control_account where keterangan='Def. Akun LR Bulan'")

            Dim command As New MySqlCommand()
            connect.Open()
            command.Connection = connect
            vartr = connect.BeginTransaction()
            command.Transaction = vartr

            Dim dtrow As DataRow
            'tutup akun labarugi 
            command.CommandText = String.Format("delete from djurnal where no_jurnal in (select no_jurnal from jurnal where tgl='{0}' and no_jurnal like 'JPT%') ", Format(tglakhir, "yyyy-MM-dd"))
            command.ExecuteNonQuery()
            command.CommandText = String.Format("delete from jurnal where tgl='{0}' and no_jurnal like 'JPT%' ", Format(tglakhir, "yyyy-MM-dd"))
            command.ExecuteNonQuery()
            sqlstr = String.Format("insert into jurnal (no_jurnal,tgl) values ('{0}','{1}');", no_jurnal, Format(tglakhir, "yyyy-MM-dd"))
            Dim tbsum As DataTable = DtTable(String.Format("select kode_akun,sum(nominal) tot from djurnal a inner join jurnal m on a.no_jurnal=m.no_jurnal  inner join makun b on a.id_akun=b.kode_akun inner join tipeakun c on b.tipe_akun=c.tipeakun where tgl>='{0}' and tgl<='{1}' and subtipe in ('Laba Rugi') group by kode_akun", Format(tglawal, "yyyy-MM-dd"), Format(tglakhir, "yyyy-MM-dd")))
            For Each dtrow In tbsum.Rows
                'update ke tabel summary
                sqlstr = sqlstr + String.Format("insert into djurnal (id_akun,nominal,no_jurnal) VALUES ('{0}','{1}','{2}')", dtrow("kode_akun"), -1 * dtrow("tot"), no_jurnal) & ";"
                sqlstr = sqlstr + String.Format("insert into djurnal (id_akun,nominal,no_jurnal) VALUES ('{0}','{1}','{2}')", defakunlrbulan, dtrow("tot"), no_jurnal) & ";"
            Next
            If sqlstr <> "" Then
                ilen = Len(sqlstr)
                sqlstr = Microsoft.VisualBasic.Left(sqlstr, ilen - 1)
                command.CommandText = sqlstr
                command.ExecuteNonQuery()
            End If
            sqlstr = ""
            ilen = 0
            tbsum.Clear()
            command.CommandText = String.Format("delete from tutupcoa_summary where tgl_bulan_tahun='{0}'", Format(tglakhir, "yyyyMM"))
            command.ExecuteNonQuery()
            tbsum = DtTable(String.Format("select kode_akun,sum(nominal) tot from djurnal a inner join jurnal m on a.no_jurnal=m.no_jurnal  inner join makun b on a.id_akun=b.kode_akun inner join tipeakun c on b.tipe_akun=c.tipeakun where tgl>='{0}' and tgl<='{1}' and subtipe not in ('Laba Rugi') group by kode_akun", Format(tglawal, "yyyy-MM-dd"), Format(tglakhir, "yyyy-MM-dd")))
            For Each dtrow In tbsum.Rows
                'update ke tabel summary
                sqlstr = sqlstr + String.Format("insert into tutupcoa_summary (id_akun,nominal,tgl_bulan_tahun) VALUES ('{0}','{1}','{2}')", dtrow("kode_akun"), dtrow("tot"), Format(tglakhir, "yyyyMM")) & ";"
            Next
            tbsum.Clear()

            If sqlstr <> "" Then
                ilen = Len(sqlstr)
                sqlstr = Microsoft.VisualBasic.Left(sqlstr, ilen - 1)
                command.CommandText = sqlstr
                command.ExecuteNonQuery()
                command.CommandText = String.Format("update tutupcoa_summary a left join (select id_akun,nominal from tutupcoa_summary where tgl_bulan_tahun='{1}') b on a.id_akun=b.id_akun set a.nominal=a.nominal+ifnull(b.nominal,0)  where  a.tgl_bulan_tahun='{0}' ", Format(tglawal, "yyyyMM"), blanlalu)
                command.ExecuteNonQuery()
            End If
            'set periode aktif
            tglawal = DateAdd(DateInterval.Month, 1, tglawal)
            tglakhir = DateAdd(DateInterval.Month, 1, tglakhir)
            tglakhir = DateAdd(DateInterval.Day, -1, tglakhir)
            command.CommandText = "delete from periode_transaksi"
            command.ExecuteNonQuery()
            command.CommandText = String.Format("insert into periode_transaksi (tgl_awal,tgl_akhir) VALUES ('{0}','{1}')", Format(tglawal, "yyyy-MM-dd"), Format(tglakhir, "yyyy-MM-dd"))
            command.ExecuteNonQuery()
            vartr.Commit()
            MessageBox.Show("Tutup Periode Berhasil")
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

    Private Sub frntutupperiode_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim mindate As Date = CDate(Scalar("select tgl_awal from periode_transaksi"))
        DateEdit1.Properties.MinValue = mindate
        DateEdit1.EditValue = mindate
    End Sub
End Class