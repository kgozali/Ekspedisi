Public Class master_pelunasan_principle 

    Private Sub cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        Me.Close()
    End Sub

    Private Sub jumpmenu_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles jumpmenu.ItemClick
        Me.Close()
    End Sub
    Dim data As New DataTable
    Dim cekload As Boolean = False
    Private Sub master_pelunasan_principle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            data = New DataTable
            data = DtTable("SELECT pp.id_pelunasan `Nomor Pelunasan`,mp.id_principle `Kode Principle`,nama_principle `Nama Principle`,alamat `Alamat`,id_faktur `Nomor DO`,keterangan `Keterangan` FROM `dpelunasan_piutang` dp, pelunasan_piutang pp, mprinciple mp WHERE mp.id_principle=pp.id_principle and pp.id_pelunasan=dp.id_pelunasan")
            datapelunasan.DataSource = data
            data = New DataTable
            data = DtTable("select id_principle,nama_principle from mprinciple where s='1'")
            pilihprinciple.DataSource = data
            pilihprinciple.DisplayMember = "nama_principle"
            pilihprinciple.ValueMember = "id_principle"
            cekload = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        Try
            If nama.Checked = True Then
                pilihprinciple.Visible = True
                cari.Visible = False
            Else
                pilihprinciple.Visible = False
                cari.Visible = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub pilihprinciple_SelectedIndexChanged(sender As Object, e As EventArgs) Handles pilihprinciple.SelectedIndexChanged
        Try
            If cekload = True Then
                data = New DataTable
                data = DtTable("SELECT pp.id_pelunasan `Nomor Pelunasan`,mp.id_principle `Kode Principle`,nama_principle `Nama Principle`,alamat `Alamat`,id_faktur `Nomor DO`,keterangan `Keterangan` FROM `dpelunasan_piutang` dp, pelunasan_piutang pp, mprinciple mp WHERE mp.id_principle=pp.id_principle and pp.id_pelunasan=dp.id_pelunasan and mp.id_principle='" & pilihprinciple.SelectedValue.ToString & "'")
                datapelunasan.DataSource = data
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cari_EditValueChanged(sender As Object, e As EventArgs) Handles cari.EditValueChanged
        Try
            data = New DataTable
            data = DtTable("SELECT pp.id_pelunasan `Nomor Pelunasan`,mp.id_principle `Kode Principle`,nama_principle `Nama Principle`,alamat `Alamat`,id_faktur `Nomor DO`,keterangan `Keterangan` FROM `dpelunasan_piutang` dp, pelunasan_piutang pp, mprinciple mp WHERE mp.id_principle=pp.id_principle and pp.id_pelunasan=dp.id_pelunasan and pp.id_pelunasan like '%" & cari.Text & "%'")
            datapelunasan.DataSource = data
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub editpelunasan_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles editpelunasan.ItemClick
        Try
            edit_principle_pelunasan.idprinciple = viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Kode Principle")
            edit_principle_pelunasan.principle.Text = viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Nama Principle")
            edit_principle_pelunasan.alamat.Text = viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Alamat")
            edit_principle_pelunasan.nomerpelunasan.Text = viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Nomor Pelunasan")
            edit_principle_pelunasan.catatan.Text = viewdatapelunasan.GetRowCellValue(viewdatapelunasan.FocusedRowHandle, "Keterangan")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        edit_principle_pelunasan.ShowDialog()
    End Sub

    Private Sub master_pelunasan_principle_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        master_pelunasan_principle_Load(sender, e)
    End Sub
End Class