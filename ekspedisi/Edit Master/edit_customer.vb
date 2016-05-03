Imports MySql.Data.MySqlClient
Public Class edit_Customer
    Dim cbkota As New DataTable
    Private Sub edit_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            cbkota = DtTable("select kota, provinsi from mkota where s = '1'")
            kota.DataSource = cbkota
            kota.ValueMember = "kota"
            kota.DisplayMember = "kota"

            id.Text = list_edit_customer.GridView1.GetRowCellValue(list_edit_customer.GridView1.FocusedRowHandle, "Kode Customer").ToString()
            nama.Text = list_edit_customer.GridView1.GetRowCellValue(list_edit_customer.GridView1.FocusedRowHandle, "Nama Customer").ToString()
            email.Text = list_edit_customer.GridView1.GetRowCellValue(list_edit_customer.GridView1.FocusedRowHandle.ToString, "Email").ToString()
            alamat.Text = list_edit_customer.GridView1.GetRowCellValue(list_edit_customer.GridView1.FocusedRowHandle.ToString, "Alamat").ToString()
            tel1.Text = list_edit_customer.GridView1.GetRowCellValue(list_edit_customer.GridView1.FocusedRowHandle.ToString, "Telepon 1").ToString()
            tel2.Text = list_edit_customer.GridView1.GetRowCellValue(list_edit_customer.GridView1.FocusedRowHandle.ToString, "Telepon 2").ToString()
            kota.Text = list_edit_customer.GridView1.GetRowCellValue(list_edit_customer.GridView1.FocusedRowHandle.ToString, "Kota").ToString()
            provinsi.Text = list_edit_customer.GridView1.GetRowCellValue(list_edit_customer.GridView1.FocusedRowHandle.ToString, "Provinsi").ToString()

        Catch ex As Exception

        End Try
        


    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Select Case MsgBox("Apakah anda yakin mengedit data ini?", MsgBoxStyle.YesNo, "System Error")
            Case MsgBoxResult.Yes
                Dim ccccc As String = "update mcustomer set nama_customer='" & nama.Text & "', email ='" & email.Text & "', alamat = '" & alamat.Text & "', tel1 ='" & tel1.Text & "', tel2 = '" & tel2.Text & "',kota ='" & kota.Text & "', provinsi ='" & provinsi.Text & "' where id_customer='" & id.Text.ToString & "'"
                InsertInto(ccccc)
                audit()
                MessageBox.Show("File Updated")
                connect.Close()
                list_edit_Customer.GridView1.DeleteSelectedRows()
                Me.Close()
        End Select
    End Sub
    Sub audit()
        Dim user As String = main_menu.username
        Dim kompname As String = System.Net.Dns.GetHostName
        Dim form As String = "Master Customer"
        Dim aktivitas As String = "Edit Customer: " & id.Text.ToString
        auditlog(user, kompname, form, aktivitas)
    End Sub
    Private Sub kota_SelectedValueChanged(sender As Object, e As EventArgs)
        Dim carip As String = "select provinsi from mkota where kota ='" & kota.Text.ToString & "' and s = '1'"
        Dim prov As String = Scalar(carip)
        provinsi.Text = prov
    End Sub
End Class