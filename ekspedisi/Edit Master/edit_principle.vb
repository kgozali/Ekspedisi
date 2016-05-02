Imports MySql.Data.MySqlClient
Public Class edit_Principle
    Dim cbkota As New DataTable
    Private Sub edit_Principle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbkota = DtTable("select kota, provinsi from mkota where s = '1'")
            kota.DataSource = cbkota
            kota.ValueMember = "kota"
            kota.DisplayMember = "kota"

            id.Text = edit_list_Principle.GridView1.GetRowCellValue(edit_list_Principle.GridView1.FocusedRowHandle, "Kode Principle").ToString()
            nama.Text = edit_list_Principle.GridView1.GetRowCellValue(edit_list_Principle.GridView1.FocusedRowHandle, "Nama Principle").ToString()
            email.Text = edit_list_Principle.GridView1.GetRowCellValue(edit_list_Principle.GridView1.FocusedRowHandle.ToString, "Email").ToString()
            alamat.Text = edit_list_Principle.GridView1.GetRowCellValue(edit_list_Principle.GridView1.FocusedRowHandle.ToString, "Alamat").ToString()
            tel1.Text = edit_list_Principle.GridView1.GetRowCellValue(edit_list_Principle.GridView1.FocusedRowHandle.ToString, "Telepon 1").ToString()
            tel2.Text = edit_list_Principle.GridView1.GetRowCellValue(edit_list_Principle.GridView1.FocusedRowHandle.ToString, "Telepon 2").ToString()
            kota.Text = edit_list_Principle.GridView1.GetRowCellValue(edit_list_Principle.GridView1.FocusedRowHandle.ToString, "Kota").ToString()
            provinsi.Text = edit_list_Principle.GridView1.GetRowCellValue(edit_list_Principle.GridView1.FocusedRowHandle.ToString, "Provinsi").ToString()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub tel1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel1.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub
    Private Sub tel2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tel2.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case MsgBox("Apakah anda yakin mengedit data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim ccccc As String = "update mprinciple set nama_principle='" & nama.Text & "', email ='" & email.Text & "', alamat = '" & alamat.Text & "', tel1 ='" & tel1.Text & "', tel2 = '" & tel2.Text & "',kota ='" & kota.Text & "', provinsi ='" & provinsi.Text & "' where id_principle='" & id.Text.ToString & "'"
                InsertInto(ccccc)
                MessageBox.Show("File Updated")
                connect.Close()
                edit_list_Principle.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub
    Private Sub kota_SelectedValueChanged(sender As Object, e As EventArgs) Handles kota.SelectedValueChanged
        Dim carip As String = "select provinsi from mkota where kota ='" & kota.Text.ToString & "' and s = '1'"
        Dim prov As String = Scalar(carip)
        provinsi.Text = prov
    End Sub
End Class