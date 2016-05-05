Imports MySql.Data.MySqlClient
Public Class edit_rute
    Dim cbasal As New DataTable
    Dim cbtujuan As New DataTable
    Dim cbprinciple As New DataTable
    Private Sub edit_rute_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbprinciple = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle` from mprinciple where s = '1'")
            principle.DataSource = cbprinciple
            principle.DisplayMember = "Nama Principle"
            principle.ValueMember = "Kode Principle"

            cbasal = DtTable("select kota from mkota where s = '1'")
            asal.DataSource = cbasal
            asal.DisplayMember = "Kota"
            asal.ValueMember = "Kota"
            cbtujuan = DtTable("select kota from mkota where s = '1'")
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
                audit()
                MessageBox.Show("File Updated")
                connect.Close()
                edit_list_rute.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub

    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Master Rute"
        Dim aktivitas As String = "Edit Rute: " & id.Text.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub
    Private Sub hargaunit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles hargaunit.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

End Class