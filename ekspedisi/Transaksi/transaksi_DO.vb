Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views

Public Class transaksi_DO
    Public kodeprinciple As String = ""
    Public namaprinciple As String = ""
    Private Sub idbooking_EditValueChanged(sender As Object, e As EventArgs) Handles idbooking.EditValueChanged
        Dim data As String = ""
        data = Scalar("select nama_principle from mprinciple,booking_truk where id_booking='" + idbooking.Text.ToString + "' and mprinciple.id_principle=booking_truk.id_principle")
        TextBox2.Text = data
        namaprinciple = data
    End Sub

    Private Sub transaksi_DO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tanggal As New DataTable
        Dim tgl As String = "TDO" + Today.Date.ToString("yyyyMMdd")
        tanggal = DtTable("select * from trans_do where substring(id_transaksi,1,10) = '" & tgl & "'")
        Dim hitung As String = tanggal.Rows.Count() + 1
        While hitung.LongCount < 5
            hitung = "0" + hitung
        End While
        id.Text = tgl + hitung

        tanggaljatuhtempo.Value = tanggalterkirim.Value.Date.AddDays(30)

    End Sub

    Private Sub idbooking_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles idbooking.ButtonClick
        Try
            Me.Visible = False
            booking_do.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        kodeprinciple = Scalar("select id_principle from booking_truk where id_booking='" + idbooking.Text + "'")
        add_item.ShowDialog()

    End Sub

    Private Sub GroupControl3_Paint(sender As Object, e As PaintEventArgs) Handles GroupControl3.Paint

    End Sub

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            Dim kem As String = ""
            If nomerdo.Text = "" Then
                MessageBox.Show("Mohon lengkapi data terlebih dahulu", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                If GridView1.DataRowCount < 1 Then
                    MessageBox.Show("Tidak ada barang yang dipilih", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else

                End If


            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub

    Private Sub tanggalterkirim_ValueChanged(sender As Object, e As EventArgs) Handles tanggalterkirim.ValueChanged
        tanggaljatuhtempo.Value = tanggalterkirim.Value.Date.AddDays(30)
    End Sub
End Class