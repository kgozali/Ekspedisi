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

        Catch ex As Exception

        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case MsgBox("Apakah anda yakin mengedit data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim ccccc As String = "update mtruk set no_pol = '" & nop.Text & "',no_mesin = '" & nomesin.Text & "', no_rangka = '" & norangka.Text & "',id_supplier = '" & Cmbbxsupp.SelectedValue.ToString & "', harga_beli ='" & hargabeli.Text & "', umur_default ='" & umur.Text & "', nilai_residu = '" & nilairesidu.Text & "', id_akun_akt = '" & aktiva.SelectedValue.ToString & "', id_akun_depresiasi = '" & depresiasi.SelectedValue.ToString & "', id_akun_penyusutan = '" & penyusutan.SelectedValue.ToString & "' where id_truk='" & id.Text.ToString & "'"
                InsertInto(ccccc)
                MessageBox.Show("File Updated")
                connect.Close()
                edit_list_truck.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub


End Class