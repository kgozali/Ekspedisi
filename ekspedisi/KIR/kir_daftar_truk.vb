Imports MySql.Data.MySqlClient
Public Class kir_daftar_truk
    Dim tabelid As New DataTable
    Private Sub kir_daftar_truk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cari.Text = ""
        proc()

    End Sub

    Sub proc()
        Try
            'query sesuai dengan radiobutton
            If id.Checked = True Then
                tabelid = DtTable("select id_truk `Kode Truk`,no_pol `No.Polisi`,no_mesin `No.Mesin`,no_rangka `No.Rangka` from mtruk where id_truk LIKE '%" + cari.Text.ToString + "%'")
                edit()
            ElseIf nama.Checked = True Then
                tabelid = DtTable("select id_truk `Kode Truk`,no_pol `No.Polisi`,no_mesin `No.Mesin`,no_rangka `No.Rangka` from mtruk where no_pol LIKE '%" + cari.Text.ToString + "%'")
                edit()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub edit()
        Try
            'mematikan edit pada kolom
            GridControl1.DataSource = tabelid
            For i = 0 To GridView1.Columns.Count - 1
                GridView1.Columns(i).OptionsColumn.AllowEdit = False
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Try
            'pilih truk ditampilkan pada buttonedit Booking truk
            check(sender, e)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub check(sender As Object, e As EventArgs)
        Try
            Dim kode As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "Kode Truk")
            Dim nama As String = GridView1.GetRowCellValue(GridView1.FocusedRowHandle, "No.Polisi")
            KIR_Truk.ButtonEdit1.Text = nama
            KIR_Truk.trukbook = kode
            kir_daftar_truk_Load(sender, e)
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub GridControl1_DoubleClick(sender As Object, e As EventArgs) Handles GridControl1.DoubleClick
        Try
            'pilih truk ditampilkan pada buttonedit Booking truk
           
                check(sender, e)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class