Public Class buka_piutang_karyawan 
    Dim debet As String = Scalar("select id_akun from control_account where keterangan='Def. Akun Piutang'")
    Dim cekform As Boolean = False

    Private Sub buka_piutang_karyawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            id.Text = autogenerate("BPK", "select max(id_piutangkaryawan) FROM piutang_karyawan p")
            Dim data As New DataTable
            data = DtTable("select * from makun where tipe_akun='Kas&Bank' and detil='1'")
            akunkas.DataSource = data
            akunkas.DisplayMember = "nama_akun"
            akunkas.ValueMember = "kode_akun"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Public Sub New()
        Dim tabel As New DataTable
        tabel = DtTable("SELECT nama_karyawan as `Nama Karyawan` FROM mkaryawan mk where s='1'")
        InitializeComponent()
        Dim collection As New AutoCompleteStringCollection()

        For i = 0 To tabel.Rows.Count - 1
            collection.Add(tabel.Rows(i).Item("Nama Karyawan"))
        Next i

        pilihkaryawan.MaskBox.AutoCompleteSource = AutoCompleteSource.CustomSource
        pilihkaryawan.MaskBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        pilihkaryawan.MaskBox.AutoCompleteCustomSource = collection
    End Sub

    Private Sub pilihkaryawan_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles pilihkaryawan.ButtonClick
        karyawan_piutang.ShowDialog()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Public idbukapiutang As String
    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        If nominal.Text <> "" Then
            If tanggalpelunasan.Value > tanggalpiutang.Value Then
                If idkaryawan.Text <> "" Then
                    id.Text = autogenerate("BPK", "select max(id_piutangkaryawan) FROM piutang_karyawan p")

                    If InsertInto("INSERT INTO `piutang_karyawan`(`id_piutangkaryawan`, `id_karyawan`, `tgl`, `nominal`, `path_bukti`, `jatuh_tempo`, `keterangan`, `status`,`id_akun`, `cetakan_ke`) VALUES ('" & id.Text & "','" & idkaryawan.Text & "'," & tanggalpiutang.Value.ToString("yyyMMdd") & "," & nominal.Text & ",'path'," & tanggalpelunasan.Value.ToString("yyyyMMdd") & ",'" & keterangan.Text & "','1','" & akunkas.SelectedValue.ToString & "',0)") = True Then
                        InsertInto("INSERT INTO `jurnal`(`no_jurnal`, `tgl`) VALUES ('" & id.Text & "'," & tanggalpiutang.Value.ToString("yyyMMdd") & ")")
                        Dim opo As Double = CDbl(nominal.Text) * -1
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & id.Text & "','" & debet & "','Buka Piutang Karyawan'," & nominal.Text & ")")
                        InsertInto("INSERT INTO `djurnal`(`no_jurnal`, `id_akun`, `keterangan`, `nominal`) VALUES ('" & id.Text & "','" & akunkas.SelectedValue.ToString & "','Buka Piutang Karyawan'," & opo & ")")
                        MessageBox.Show("Input Piutang Berhasil")
                        If karyawan_piutang.bukasupirataukaryawan = "karyawan" Then
                            viewkwitansi.tangkap = id.Text.ToString
                            viewkwitansi.ShowDialog()
                        Else
                            idbukapiutang = id.Text
                            buktiformpinjam.ShowDialog()
                        End If

                        buka_piutang_karyawan_FormClosed()
                    Else
                        MessageBox.Show("Input piutang gagal", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    End If
                Else
                    MessageBox.Show("Karywawan belum dipilih", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Else
                MessageBox.Show("Tanggal pelunasan harus lebih besar dari tanggal piutang", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Nominal belum terisi", "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub pilihkaryawan_Click(sender As Object, e As EventArgs) Handles pilihkaryawan.Click
        karyawan_piutang.ShowDialog()
    End Sub

    'Private Sub pilihkaryawan_TextChanged(sender As Object, e As EventArgs) Handles pilihkaryawan.TextChanged

    '    Try
    '        idkaryawan.Text = Scalar("SELECT id_karyawan FROM mkaryawan mk,mjabatan mj where mj.id_jabatan=mk.id_jabatan and nama_karyawan='" & pilihkaryawan.Text & "'")
    '        If idkaryawan.Text = "" Then
    '            idkaryawan.Text = ""
    '            pilihkaryawan.Text = ""
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

    '    End Try
    'End Sub

    Private Sub buka_piutang_karyawan_FormClosed() Handles MyBase.FormClosed
        Try
            pilihkaryawan.Text = ""
            idkaryawan.Text = ""
            id.Text = ""
            nominal.Text = ""
            keterangan.Text = ""
            cekform = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub
End Class