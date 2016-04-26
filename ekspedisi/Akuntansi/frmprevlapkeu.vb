Imports DevExpress.XtraReports.UI

Public Class frmprevlapkeu

    Private Sub lapjurnal(ByVal tglawal As Date, tglakhir As Date)
        Dim rep As XtraReport = New lapjurnal
        rep.Parameters("tglawal").Value = tglawal
        rep.Parameters("tglakhir").Value = tglakhir
        rep.Parameters("periode").Value = "Dari " & Format(tglawal, "dd-MM-yyyy") & " s/d " & Format(tglakhir, "dd-MM-yyyy")
        rep.FilterString = "[tgl] >= [Parameters.tglawal] and [tgl] <= [Parameters.tglakhir]"
        DocumentViewer1.DocumentSource = rep
        DocumentViewer1.InitiateDocumentCreation()
    End Sub

    Private Sub labarugi(ByVal bulan As String)
        Dim dtset As DataSet
        dtset = DtSetReturn("select tipe_akun,nama_akun,-1*nominal as nominal,urtlabarugi from lap_neraca where subtipe in ('Laba Rugi') and (date_format(tgl,""%m %Y"")='" & bulan & "'or ifnull(tgl,0)=0 ) and urtlabarugi<>0  and nominal <>0 order by urtlabarugi", "dttable")
        Dim rep As XtraReport = New labarugi
        rep.DataSource = dtset
        rep.DataMember = "dttable"
        Dim xrlabel As XRLabel = rep.Bands(BandKind.GroupHeader).Controls.Item("XrLabel3")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.tipe_akun")
        xrlabel = rep.Bands(BandKind.Detail).Controls.Item("XrLabel4")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nama_akun")
        xrlabel = rep.Bands(BandKind.Detail).Controls.Item("XrLabel5")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nominal")
        xrlabel.DataBindings("Text").FormatString = "{0:n2}"

        xrlabel = rep.Bands(BandKind.GroupFooter).Controls.Item("XrLabel6")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nominal")

        xrlabel = rep.Bands(BandKind.ReportFooter).Controls.Item("XrLabel7")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nominal")

        xrlabel = rep.Bands(BandKind.PageHeader).Controls.Item("XrLabel2")
        xrlabel.Text = "Bulan " & bulan

        DocumentViewer1.DocumentSource = rep
        DocumentViewer1.InitiateDocumentCreation()
    End Sub

    Private Sub cetakneraca(ByVal bulan As String)
        Dim dtset As DataSet
        Dim dtset2 As DataSet

        'or ifnull(tgl,0)=0
        dtset = DtSetReturn("select nama_akun,sum(nominal) as nominal from lap_neraca where subtipe in ('Aktiva','Aktiva Lancar','Aktiva Tetap') and (date_format(tgl,""%m %Y"")='" & bulan & "' ) group by kode_akun", "dttable")

        Dim rep As XtraReport = New neracax
        Dim subrepsrc1 As XtraReport = New subneraca_ak
        Dim subrepsrc2 As XtraReport = New subneraca_kw
        Dim subnr_ak As XRSubreport = rep.Bands(BandKind.Detail).FindControl("XrSubreport1", True)
        Dim subnr_ak2 As XRSubreport = rep.Bands(BandKind.Detail).FindControl("XrSubreport2", True)

        subrepsrc1.DataSource = dtset
        subrepsrc1.DataMember = "dttable"


        Dim xrlabel As XRLabel = subrepsrc1.Bands(BandKind.Detail).Controls.Item("XrLabel1")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nama_akun")
        xrlabel = subrepsrc1.Bands(BandKind.Detail).Controls.Item("XrLabel2")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nominal")
        xrlabel.DataBindings("Text").FormatString = "{0:n2}"

        dtset2 = DtSetReturn("select nama_akun,sum(-1*nominal) as nominal from lap_neraca where subtipe in ('Kewajiban') and (date_format(tgl,""%m %Y"")='" & bulan & "' ) group by kode_akun", "dttable")
        subrepsrc2.DataSource = dtset2
        subrepsrc2.DataMember = "dttable"

        xrlabel = subrepsrc2.Bands(BandKind.Detail).Controls.Item("XrLabel1")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nama_akun")
        xrlabel = subrepsrc2.Bands(BandKind.Detail).Controls.Item("XrLabel2")
        xrlabel.DataBindings.Add("Text", Nothing, "dttable.nominal")
        xrlabel.DataBindings("Text").FormatString = "{0:n2}"

        subnr_ak.ReportSource = subrepsrc1
        subnr_ak2.ReportSource = subrepsrc2

        Dim totaktiva As String = Scalar("select ifnull(sum(nominal),0) as nominal from lap_neraca where subtipe in ('Aktiva','Aktiva Lancar','Aktiva Tetap') and (date_format(tgl,""%m %Y"")='" & bulan & "' ) ")

        xrlabel = rep.Bands(BandKind.PageFooter).Controls.Item("XrLabel9")
        xrlabel.Text = Format(CDbl(totaktiva), "#,###.00")

        totaktiva = Scalar("select ifnull(sum(-1*nominal),0) as nominal from lap_neraca where subtipe in ('Kewajiban') and (date_format(tgl,""%m %Y"")='" & bulan & "' ) ")

        xrlabel = rep.Bands(BandKind.PageFooter).Controls.Item("XrLabel7")
        xrlabel.Text = Format(CDbl(totaktiva), "#,###.00")

        xrlabel = rep.Bands(BandKind.PageHeader).Controls.Item("XrLabel10")
        xrlabel.Text = "Bulan " & bulan

        DocumentViewer1.DocumentSource = rep

        DocumentViewer1.InitiateDocumentCreation()
    End Sub



    Private Sub ListBoxControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxControl1.SelectedIndexChanged
        Select Case UCase(ListBoxControl1.Text)
            Case "LAP. JURNAL"
                LabelControl1.Text = "Dari Tanggal"
                DateEdit2.Properties.DisplayFormat.FormatString = "dd-MM-yyyy"
                DateEdit2.Properties.Mask.EditMask = "dd-MM-yyyy"
                DateEdit1.Visible = True
                LabelControl2.Visible = True
            Case "LAP. LABA RUGI"
                LabelControl1.Text = "Bulan"
                DateEdit2.Properties.DisplayFormat.FormatString = "MM yyyy"
                DateEdit2.Properties.Mask.EditMask = "MM yyyy"
                DateEdit1.Visible = False
                LabelControl2.Visible = False
            Case "LAP. NERACA"
                LabelControl1.Text = "Bulan"
                DateEdit2.Properties.DisplayFormat.FormatString = "MM yyyy"
                DateEdit2.Properties.Mask.EditMask = "MM yyyy"
                DateEdit1.Visible = False
                LabelControl2.Visible = False
        End Select
    End Sub

    Private Sub DateEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles DateEdit2.EditValueChanged

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Select Case UCase(ListBoxControl1.Text)
            Case "LAP. NERACA"
                cetakneraca(DateEdit2.Text)
            Case "LAP. LABA RUGI"
                labarugi(DateEdit2.Text)
            Case "LAP. JURNAL"
                lapjurnal(DateEdit2.EditValue, DateEdit1.EditValue)
        End Select

    End Sub
End Class