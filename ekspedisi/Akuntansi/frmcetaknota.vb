Imports DevExpress.XtraReports.UI
Public Class frmcetaknota

    Private Sub cetnotakas(ByVal mkeyid As String, ByVal tipedok As String)
        Dim dtset As DataSet
        dtset = DtSetReturn("select id_transaksi_kas,tgl,keterangan as keterangan_detil,nama_akun as nama_akun_detil,nominal from dtrans_kas d inner join makun m on d.id_akun_detil=m.kode_akun where id_transaksi_kas='" & mkeyid & "'", "dttable")

        Dim rep As XtraReport = New XtraReport1
        rep.DataSource = dtset
        rep.DataMember = "dttable"
        Dim xrlabel As XRLabel = rep.Bands(BandKind.Detail).Controls.Item("XrLabel11")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nama_akun_detil")
        xrlabel = rep.Bands(BandKind.Detail).Controls.Item("XrLabel12")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.keterangan_detil")
        xrlabel = rep.Bands(BandKind.Detail).Controls.Item("XrLabel13")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nominal")
        xrlabel.DataBindings("Text").FormatString = "{0:n2}"
        xrlabel = rep.Bands(BandKind.PageHeader).Controls.Item("XrLabel6")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.id_transaksi_kas")
        xrlabel = rep.Bands(BandKind.PageHeader).Controls.Item("XrLabel5")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.tgl")
        xrlabel.DataBindings("Text").FormatString = "{0:dd/MM/yyyy}"
        xrlabel = rep.Bands(BandKind.PageHeader).Controls.Item("XrLabel7")
        If tipedok = "M" Then
            xrlabel.Text = "BUKTI KAS MASUK"
        Else
            xrlabel.Text = "BUKTI KAS KELUAR"
        End If
        xrlabel = rep.Bands(BandKind.PageFooter).Controls.Item("XrLabel14")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nominal")
        xrlabel.DataBindings("Text").FormatString = "{0:n2}"
        rep.PaperKind = Drawing.Printing.PaperKind.Custom
        rep.PageHeight = 550
        rep.PageWidth = 850
        DocumentViewer1.DocumentSource = rep
    End Sub

    Private Sub cetnotabank(ByVal mkeyid As String, ByVal tipedok As String)
        Dim dtset As DataSet
        dtset = DtSetReturn("select id_tbank,tgl,keterangan as keterangan_detil,nama_akun as nama_akun_detil,nominal from dtrans_bank d inner join makun m on d.id_akun_detil=m.kode_akun where id_tbank='" & mkeyid & "'", "dttable")

        Dim rep As XtraReport = New XtraReport1
        rep.DataSource = dtset
        rep.DataMember = "dttable"
        Dim xrlabel As XRLabel = rep.Bands(BandKind.Detail).Controls.Item("XrLabel11")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nama_akun_detil")
        xrlabel = rep.Bands(BandKind.Detail).Controls.Item("XrLabel12")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.keterangan_detil")
        xrlabel = rep.Bands(BandKind.Detail).Controls.Item("XrLabel13")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nominal")
        xrlabel.DataBindings("Text").FormatString = "{0:n2}"
        xrlabel = rep.Bands(BandKind.PageHeader).Controls.Item("XrLabel6")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.id_tbank")
        xrlabel = rep.Bands(BandKind.PageHeader).Controls.Item("XrLabel5")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.tgl")
        xrlabel.DataBindings("Text").FormatString = "{0:dd/MM/yyyy}"
        xrlabel = rep.Bands(BandKind.PageHeader).Controls.Item("XrLabel7")
        If tipedok = "M" Then
            xrlabel.Text = "BUKTI BANK MASUK"
        Else
            xrlabel.Text = "BUKTI BANK KELUAR"
        End If
        xrlabel = rep.Bands(BandKind.PageFooter).Controls.Item("XrLabel14")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nominal")
        xrlabel.DataBindings("Text").FormatString = "{0:n2}"
        rep.PaperKind = Drawing.Printing.PaperKind.Custom
        rep.PageHeight = 550
        rep.PageWidth = 850
        DocumentViewer1.DocumentSource = rep
    End Sub
    Public Sub gencetak(ByVal docname As String, ByVal mkeyid As String, ByVal tipedok As String)
        Select Case docname
            Case "TRANSAKSI KAS"
                cetnotakas(mkeyid, tipedok)
            Case "TRANSAKSI BANK"
                cetnotabank(mkeyid, tipedok)
        End Select
        Me.Show()
    End Sub
End Class