Imports MySql.Data.MySqlClient
Public Class edit_truck
    Dim cbsupplier As New DataTable
    Dim cbaktv As New DataTable
    Dim cbdpresiasi As New DataTable
    Dim cbpenystn As New DataTable
    Private Sub edit_truck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbsupplier = DtTable("select id_supplier `Kode Supplier`,nama_supplier `Nama Supplier` from msupplier where `s` = 1")
            Cmbbxsupp.DataSource = cbsupplier
            Cmbbxsupp.DisplayMember = "Nama Supplier"
            Cmbbxsupp.ValueMember = "Kode Supplier"

            cbaktv = DtTable("select kode_akun, nama_akun from makun where detil = '1'")
            aktiva.DataSource = cbaktv
            aktiva.DisplayMember = "nama_akun"
            aktiva.ValueMember = "kode_akun"

            cbdpresiasi = DtTable("select kode_akun, nama_akun from makun where detil = '1'")
            depresiasi.DataSource = cbdpresiasi
            depresiasi.DisplayMember = "nama_akun"
            depresiasi.ValueMember = "kode_akun"

            cbpenystn = DtTable("select kode_akun, nama_akun from makun where detil = '1'")
            penyusutan.DataSource = cbpenystn
            penyusutan.DisplayMember = "nama_akun"
            penyusutan.ValueMember = "kode_akun"

            id.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle, "Kode Truk").ToString()
            nop.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle, "No Polisi").ToString()
            nomesin.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle.ToString, "No Mesin").ToString()
            norangka.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle.ToString, "No Rangka").ToString()
            Cmbbxsupp.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle.ToString, "Nama Supplier").ToString()
            hargabeli.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle.ToString, "Harga Beli").ToString()
            umur.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle.ToString, "Umur Default").ToString()
            nilairesidu.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle.ToString, "Nilai Residu").ToString()
            aktiva.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle.ToString, "Akun Aktiva").ToString()
            depresiasi.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle.ToString, "Akun Depresiasi").ToString()
            penyusutan.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle.ToString, "Akun Penyusutan").ToString()
            DateTimePicker1.Text = edit_list_truck.GridView1.GetRowCellValue(edit_list_truck.GridView1.FocusedRowHandle.ToString, "Tanggal Beli").ToString()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case MsgBox("Apakah anda yakin mengedit data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim ccccc As String = "update mtruk set no_pol = '" & nop.Text & "',no_mesin = '" & nomesin.Text & "', no_rangka = '" & norangka.Text & "',id_supplier = '" & Cmbbxsupp.SelectedValue.ToString & "', harga_beli ='" & hargabeli.Text & "', umur_default ='" & umur.Text & "', nilai_residu = '" & nilairesidu.Text & "', id_akun_akt = '" & aktiva.SelectedValue.ToString & "', id_akun_depresiasi = '" & depresiasi.SelectedValue.ToString & "', id_akun_penyusutan = '" & penyusutan.SelectedValue.ToString & "', tgl_beli = '" & DateTimePicker1.Value.ToString("yyyyMMdd") & "' where id_truk='" & id.Text.ToString & "'"
                InsertInto(ccccc)


                Dim cccc As String = "delete from kartu_aktiva where id_truck = '" & id.Text & "' "
                InsertInto(cccc)

                Dim pnmpungharga As Double = (CInt(hargabeli.Text) - CInt(nilairesidu.Text)) / CInt(umur.Text)

                If DateTimePicker1.Value.ToString("MM") = "01" Then
                    Dim nilaibuku As Double = CInt(hargabeli.Text)
                    For i = 0 To CInt(umur.Text) - 1
                        nilaibuku = nilaibuku - pnmpungharga
                        Dim tglakhir As Integer = CInt(DateTimePicker1.Value.ToString("yyyy")) + CInt(i)
                        Dim inserting As String = "insert into kartu_aktiva values ('" & id.Text & "','January " & tglakhir.ToString & "- December " & tglakhir.ToString & "', '" & pnmpungharga.ToString & "','" & nilaibuku.ToString & "') "
                        InsertInto(inserting)
                    Next
                Else
                    Dim penghitung As Integer = 0
                    For i = CInt(DateTimePicker1.Value.ToString("MM")) To 12
                        penghitung = penghitung + 1
                    Next

                    Dim nilaipertama As Double = (penghitung / 12) * pnmpungharga
                    Dim nilaibuku2 As Double = CInt(hargabeli.Text) - nilaipertama
                    'MsgBox(nilaipertama)
                    Dim masukan As String = "insert into kartu_aktiva values ('" & id.Text & "','" & DateTimePicker1.Value.ToString("MMMM yyyy") & "- December " & DateTimePicker1.Value.ToString("yyyy") & "', '" & nilaipertama.ToString & "','" & nilaibuku2.ToString & "') "
                    InsertInto(masukan)


                    For i = 1 To CInt(umur.Text) - 1
                        nilaibuku2 = nilaibuku2 - pnmpungharga
                        Dim tglakhir As Integer = CInt(DateTimePicker1.Value.ToString("yyyy")) + CInt(i)
                        Dim inserting As String = "insert into kartu_aktiva values ('" & id.Text & "','January " & tglakhir.ToString & "- December " & tglakhir.ToString & "', '" & pnmpungharga.ToString & "','" & nilaibuku2.ToString & "') "
                        InsertInto(inserting)
                    Next

                    Dim nilaiterakhir As Double = pnmpungharga - nilaipertama
                    nilaibuku2 = nilaibuku2 - nilaiterakhir
                    Dim tanggalnya As Integer = CInt(DateTimePicker1.Value.ToString("yyyy")) + CInt(umur.Text)
                    Dim masukan2 As String = "insert into kartu_aktiva values ('" & id.Text & "','January " & tanggalnya.ToString & "- " & DateTimePicker1.Value.ToString("MMMM") & " " & tanggalnya.ToString & "', '" & nilaiterakhir.ToString & "','" & nilaibuku2.ToString & "') "
                    InsertInto(masukan2)

                End If

                audit()
                MessageBox.Show("File Updated")
                connect.Close()
                edit_list_truck.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Master Truk"
        Dim aktivitas As String = "Edit Truk: " & id.Text.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub

 
End Class