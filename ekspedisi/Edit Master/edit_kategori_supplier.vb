Imports MySql.Data.MySqlClient
Public Class edit_kategori_supplier

    Private Sub edit_kategori_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            id.Text = edit_list_kategori_supplier.GridView1.GetRowCellValue(edit_list_kategori_supplier.GridView1.FocusedRowHandle, "Kode Kategori Supplier").ToString()
            nama.Text = edit_list_kategori_supplier.GridView1.GetRowCellValue(edit_list_kategori_supplier.GridView1.FocusedRowHandle, "Nama Kategori Supplier").ToString()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case MsgBox("Apakah anda yakin mengedit data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim ccccc As String = "update mkategori_supplier set kategori_supplier = '" & nama.Text & "' where id_kategori='" & id.Text.ToString & "'"
                InsertInto(ccccc)
                MessageBox.Show("File Updated")
                connect.Close()
                edit_list_kategori_supplier.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub

End Class