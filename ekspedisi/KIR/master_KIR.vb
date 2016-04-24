﻿Imports MySql.Data.MySqlClient
Public Class master_KIR
    Dim query As New DataTable
    Dim query2 As New DataTable
    Public Sub master_KIR_Load(sender As Object, e As EventArgs) Handles MyBase.Load, DateTimePicker1.ValueChanged
        Try
            query = DtTable("select id_truk,no_pol from mtruk")
            ComboBox1.DataSource = query
            ComboBox1.DisplayMember = "no_pol"
            ComboBox1.ValueMember = "id_truk"
            process()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Sub process()
        Try
            If nama.Checked = True Then
                'checkchange()
                TextEdit1.Visible = False
                ComboBox1.Visible = True
                DateTimePicker1.Visible = False
                GridView1.OptionsView.ShowFooter = True
                query2 = DtTable("select concat(day(kir.tgl),' ',monthname(kir.tgl),' ',year(kir.tgl)) `Tanggal KIR`,kir.id_kir `Kode KIR`,kir.no_kir `No. KIR`,mtruk.id_truk `Kode Truk`,mtruk.no_pol `No. Polisi` from kir,mtruk where kir.id_truk=mtruk.id_truk and mtruk.id_truk='" + ComboBox1.SelectedValue.ToString + "'")
                GridControl1.DataSource = query2
                summary()
            ElseIf tgl.Checked = True Then
                'checkchange()
                TextEdit1.Visible = False
                ComboBox1.Visible = False
                DateTimePicker1.Visible = True
                GridView1.OptionsView.ShowFooter = True
                query2 = DtTable("select concat(day(kir.tgl),' ',monthname(kir.tgl),' ',year(kir.tgl)) `Tanggal KIR`,kir.id_kir `Kode KIR`,kir.no_kir `No. KIR`,mtruk.id_truk `Kode Truk`,mtruk.no_pol `No. Polisi` from kir,mtruk where kir.id_truk=mtruk.id_truk and kir.tgl_kir='" + DateTimePicker1.Value.Date.ToString("yyyy-MM-dd") + "'")
                GridControl1.DataSource = query2
                summary()

            ElseIf kir.Checked = True Then
                'checkchange()
                ComboBox1.Visible = False
                DateTimePicker1.Visible = False
                TextEdit1.Visible = True
                GridView1.OptionsView.ShowFooter = True
                query2 = DtTable("select concat(day(kir.tgl),' ',monthname(kir.tgl),' ',year(kir.tgl)) `Tanggal KIR`,kir.id_kir `Kode KIR`,kir.no_kir `No. KIR`,mtruk.id_truk `Kode Truk`,mtruk.no_pol `No. Polisi` from kir,mtruk where kir.id_truk=mtruk.id_truk and kir.no_kir LIKE '%" + TextEdit1.Text.ToString + "%'")
                GridControl1.DataSource = query2
                summary()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
       
    End Sub
    Sub checkchange()
        TextEdit1.Text = ""
        DateTimePicker1.ResetText()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        process()
    End Sub

   
    Private Sub nama_CheckedChanged(sender As Object, e As EventArgs) Handles nama.CheckedChanged
        process()
    End Sub

    Private Sub tgl_CheckedChanged(sender As Object, e As EventArgs) Handles tgl.CheckedChanged
        process()
    End Sub

    Private Sub addsiswabaru_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles addsiswabaru.ItemClick
        KIR_Truk.ShowDialog()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles kir.CheckedChanged
        process()
    End Sub

    Private Sub master_KIR_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        checkchange()
    End Sub

    Sub summary()
        For i = 0 To GridView1.Columns.Count - 1
            GridView1.Columns(i).OptionsColumn.AllowEdit = False
            If GridView1.Columns(i).FieldName.ToString = "No. Polisi" Then
                GridView1.Columns(i).SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
                GridView1.Columns(i).SummaryItem.FieldName = "No. Polisi"
                GridView1.Columns(i).SummaryItem.DisplayFormat = "Total {0} records"
            End If
        Next i

    End Sub

    Private Sub edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles edit.ItemClick

    End Sub
End Class