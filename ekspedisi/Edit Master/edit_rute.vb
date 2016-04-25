Imports MySql.Data.MySqlClient
Public Class edit_rute
    Dim cbasal As New DataTable
    Dim cbtujuan As New DataTable
    Dim cbprinciple As New DataTable
    Private Sub edit_rute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbprinciple = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle` from mprinciple")
            principle.DataSource = cbprinciple
            principle.DisplayMember = "Nama Principle"
            principle.ValueMember = "Kode Principle"

            cbasal = DtTable("select kota from mkota")
            asal.DataSource = cbasal
            asal.DisplayMember = "Kota"
            asal.ValueMember = "Kota"
            cbtujuan = DtTable("select kota from mkota")
            tujuan.DataSource = cbtujuan
            tujuan.DisplayMember = "Kota"
            tujuan.ValueMember = "Kota"

            id.Text = edit_list_rute.GridView1.GetRowCellValue(edit_list_rute.GridView1.FocusedRowHandle, "Kode Rute").ToString()
            asal.Text = edit_list_rute.GridView1.GetRowCellValue(edit_list_rute.GridView1.FocusedRowHandle, "Kota Asal").ToString()
            tujuan.Text = edit_list_rute.GridView1.GetRowCellValue(edit_list_rute.GridView1.FocusedRowHandle.ToString, "Kota Tujuan").ToString()
            principle.Text = edit_list_rute.GridView1.GetRowCellValue(edit_list_rute.GridView1.FocusedRowHandle.ToString, "Nama Principle").ToString()
            unit.Text = edit_list_rute.GridView1.GetRowCellValue(edit_list_rute.GridView1.FocusedRowHandle.ToString, "Unit").ToString()
            hargaunit.Text = edit_list_rute.GridView1.GetRowCellValue(edit_list_rute.GridView1.FocusedRowHandle.ToString, "Price Per Unit").ToString()

        Catch ex As Exception

        End Try



    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case MsgBox("Apakah anda yakin mengedit data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim ccccc As String = "update mrute set kota_asal='" & asal.Text & "', kota_tujuan ='" & tujuan.Text & "', id_principle = '" & principle.SelectedValue.ToString & "', unit ='" & unit.Text & "', price_per_unit = '" & hargaunit.Text & "' where id_rute='" & id.Text.ToString & "'"
                InsertInto(ccccc)
                MessageBox.Show("File Updated")
                connect.Close()
                edit_list_rute.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub

End Class