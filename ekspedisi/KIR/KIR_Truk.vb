Imports MySql.Data.MySqlClient
Public Class KIR_Truk

    Dim kode As String = ""
    Private Sub KIR_Truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'autogenerate kode kir
            autogen()
            'generate isi gridview
            cekcang()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        cekcang()
    End Sub

    Sub cekcang()
        Try
            If nama.Checked = True Then
                tanggalkir.Visible = False
                cari.Visible = True
                Dim dt As New DataTable
                dt = DtTable("select concat(day(kir.tgl),' ',monthname(kir.tgl),' ',year(kir.tgl)) `Tanggal KIR`,kir.id_kir `Kode KIR`,kir.no_kir `No. KIR`,mtruk.id_truk `Kode Truk`,mtruk.no_pol `No. Polisi` from kir,mtruk where kir.id_truk=mtruk.id_truk and mtruk.no_pol LIKE '%" + cari.Text + "%'")
                GridControl1.DataSource = dt
            ElseIf tanggalhabiskir.Checked = True Then
                tanggalkir.Visible = True
                cari.Visible = False
                Dim dt As New DataTable
                dt = DtTable("select concat(day(kir.tgl),' ',monthname(kir.tgl),' ',year(kir.tgl)) `Tanggal KIR`,kir.id_kir `Kode KIR`,kir.no_kir `No. KIR`,mtruk.id_truk `Kode Truk`,mtruk.no_pol `No. Polisi` from kir,mtruk where kir.id_truk=mtruk.id_truk and kir.tgl='" + tanggalkir.Value.Date.ToString("yyyy-MM-dd") + "'")
                GridControl1.DataSource = dt
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        
    End Sub

    Sub autogen()
        Try
            Dim tanggal As New DataTable
            Dim tgl As String = "KIR" + Today.Date.ToString("yyyyMMdd")
            tanggal = DtTable("select * from kir where substring(id_kir,1,11) = '" & tgl & "'")
            Dim hitung As String = tanggal.Rows.Count() + 1
            While hitung.LongCount < 5
                hitung = "0" + hitung
            End While
            kode = tgl + hitung
            TextEdit1.Text = kode
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
      
    End Sub

    Private Sub tanggalhabiskir_CheckedChanged(sender As Object, e As EventArgs) Handles tanggalhabiskir.CheckedChanged
        cekcang()
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        cekcang()
    End Sub

    Private Sub tanggalkir_ValueChanged(sender As Object, e As EventArgs) Handles tanggalkir.ValueChanged
        cekcang()
    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            If TextEdit2.Text = "" Then
                MessageBox.Show("Nomor KIR wajib terisi", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If TextEdit3.Text = "0" Then
                    Dim msg As Integer = MessageBox.Show("Nominal KIR tertulis Rp. 0, apakah anda ingin melanjutkan transaksi KIR? Tekan OK untuk konfirmasi", "System Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                    If msg = DialogResult.OK Then
                        'insert database
                    Else

                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       

    End Sub
End Class