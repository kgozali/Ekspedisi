Imports MySql.Data.MySqlClient
Public Class edit_kontak
    Dim cbprinciple As New DataTable

    Private Sub edit_kontak_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbprinciple = DtTable("select id_principle `Kode Principle`,nama_principle `Nama Principle` from mprinciple")
        principle.DataSource = cbprinciple
        principle.DisplayMember = "Nama Principle"
        principle.ValueMember = "Kode Principle"

        id.Text = edit_kontak_principle.GridView1.GetRowCellValue(edit_kontak_principle.GridView1.FocusedRowHandle, "Kode Kontak").ToString()
        nama.Text = edit_kontak_principle.GridView1.GetRowCellValue(edit_kontak_principle.GridView1.FocusedRowHandle, "Nama Kontak").ToString()
        principle.Text = edit_kontak_principle.GridView1.GetRowCellValue(edit_kontak_principle.GridView1.FocusedRowHandle.ToString, "Nama Principle").ToString()
        tel1.Text = edit_kontak_principle.GridView1.GetRowCellValue(edit_kontak_principle.GridView1.FocusedRowHandle.ToString, "Telepon 1").ToString()
        tel2.Text = edit_kontak_principle.GridView1.GetRowCellValue(edit_kontak_principle.GridView1.FocusedRowHandle.ToString, "Telepon 2").ToString()
        email.Text = edit_kontak_principle.GridView1.GetRowCellValue(edit_kontak_principle.GridView1.FocusedRowHandle.ToString, "Email").ToString()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case MsgBox("Apakah anda yakin menghapus data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim ccccc As String = "update mkontakprinciple set nama_kontak='" & nama.Text & "',id_principle='" & principle.SelectedValue.ToString & "',tel1='" & tel1.Text & "',tel2='" & tel2.Text & "',email='" & email.Text & "' where id_kontak='" & id.Text.ToString & "'"
                InsertInto(ccccc)
                MessageBox.Show("File Updated")
                connect.Close()
                edit_kontak_principle.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub
End Class