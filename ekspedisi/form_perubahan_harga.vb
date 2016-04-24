Public Class form_perubahan_harga 
    Dim isi As New DataTable
    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub form_perubahan_harga_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        isi.Columns.Add("id_rute")
        isi.Columns.Add("hargabaru")
        Dim data As New DataTable
        data = DtTableupdateharga("SELECT id_rute `Kode Rute` , kota_asal `Kota Asal` , kota_tujuan `Kota Tujuan` , nama_principle `Nama Principle` , price_per_unit `Harga Awal` FROM  `mrute` mr,  `mprinciple` mp WHERE mr.s =  '1' AND mr.id_principle = mp.id_principle")
        rute.DataSource = data
        data = New DataTable
        data = DtTable("select id_principle,nama_principle from mprinciple where s='1'")
        principle.DataSource = data
        principle.DisplayMember = "nama_principle"
        principle.ValueMember = "id_principle"
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            Dim data As New DataTable
            If namaasal.Checked = True Then
                data = DtTableupdateharga("SELECT id_rute `Kode Rute` , kota_asal `Kota Asal` , kota_tujuan `Kota Tujuan` , nama_principle `Nama Principle` , price_per_unit `Harga Awal` FROM  `mrute` mr,  `mprinciple` mp WHERE mr.s =  '1' AND mr.id_principle = mp.id_principle and kota_asal like '%" & cari.Text & "%'")
                rute.DataSource = data
            ElseIf namatujuan.Checked = True Then
                data = DtTableupdateharga("SELECT id_rute `Kode Rute` , kota_asal `Kota Asal` , kota_tujuan `Kota Tujuan` , nama_principle `Nama Principle` , price_per_unit `Harga Awal` FROM  `mrute` mr,  `mprinciple` mp WHERE mr.s =  '1' AND mr.id_principle = mp.id_principle and kota_tujuan like '%" & cari.Text & "%'")
                rute.DataSource = data
            Else
                data = DtTableupdateharga("SELECT id_rute `Kode Rute` , kota_asal `Kota Asal` , kota_tujuan `Kota Tujuan` , nama_principle `Nama Principle` , price_per_unit `Harga Awal` FROM  `mrute` mr,  `mprinciple` mp WHERE mr.s =  '1' AND mr.id_principle = mp.id_principle and kota_tujuan like '%" & cari.Text & "%'")
                rute.DataSource = data
            End If
            For i = 0 To datarute.RowCount - 1
                For k = 0 To isi.Rows.Count - 1
                    If datarute.GetRowCellValue(i, "Kode Rute") = isi.Rows(k).Item(0).ToString Then
                        With datarute
                            .SetRowCellValue(i, "Harga Baru", isi.Rows(k).Item(1).ToString)
                        End With
                    End If
                Next k
            Next i

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub namaprinciple_CheckedChanged(sender As Object, e As EventArgs) Handles namaprinciple.CheckedChanged
        If namaprinciple.Checked = True Then
            cari.Visible = False
            principle.Visible = True
        Else
            cari.Visible = True
            principle.Visible = False
        End If
    End Sub


    Private Sub datarute_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles datarute.CellValueChanged
        If datarute.FocusedColumn.AbsoluteIndex = 5 Then
            If isi.Rows.Count = 0 Then
                isi.Rows.Add(datarute.GetRowCellValue(datarute.FocusedRowHandle, "Kode Rute"), datarute.GetRowCellValue(datarute.FocusedRowHandle, "Harga Baru"))
            Else
                Dim hapus As Boolean = False
                Dim ganti As Boolean = False
                Dim tambah As Boolean = False
                Dim value As Integer
                For i = 0 To isi.Rows.Count - 1
                    If isi.Rows(i).Item("id_rute") = datarute.GetRowCellValue(datarute.FocusedRowHandle, "Kode Rute") Then
                        If IsDBNull(datarute.GetRowCellValue(datarute.FocusedRowHandle, "Harga Baru")) = True Then
                            hapus = True
                            value = i
                            tambah = False
                        ElseIf IsDBNull(datarute.GetRowCellValue(datarute.FocusedRowHandle, "Harga Baru")) = False Then
                            ganti = True
                            value = i
                            tambah = False
                        End If
                    Else
                        tambah = True
                    End If

                Next i
                
                If hapus = True Then
                    isi.Rows.RemoveAt(value)
                ElseIf ganti = True Then
                    isi.Rows.RemoveAt(value)
                    isi.Rows.Add(datarute.GetRowCellValue(datarute.FocusedRowHandle, "Kode Rute"), datarute.GetRowCellValue(datarute.FocusedRowHandle, "Harga Baru"))
                ElseIf tambah = True Then
                    isi.Rows.Add(datarute.GetRowCellValue(datarute.FocusedRowHandle, "Kode Rute"), datarute.GetRowCellValue(datarute.FocusedRowHandle, "Harga Baru"))
                End If
            End If
        End If
    End Sub

    Private Sub simpan_Click(sender As Object, e As EventArgs) Handles simpan.Click
        Try
            For i = 0 To datarute.RowCount - 1
                InsertInto("insert into mperubahan_harga values ()")
            Next i

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class