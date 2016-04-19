Imports MySql.Data.MySqlClient
Public Class KIR_Truk

    Dim kode As String = ""
    Private Sub KIR_Truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub GridControl1_Click(sender As Object, e As EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        If nama.Checked = True Then
            Dim dt As New DataTable
            dt = DtTable("select id_kir `Kode KIR`,no_kir `No. KIR`,id_truk `Kode Truk`,no_pol `No. Polisi`,tgl `Tanggal KIR`,")
        End If
    End Sub
End Class