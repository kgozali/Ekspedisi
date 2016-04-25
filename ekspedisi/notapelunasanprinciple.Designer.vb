<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class notapelunasanprinciple
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomSqlQuery1 As DevExpress.DataAccess.Sql.CustomSqlQuery = New DevExpress.DataAccess.Sql.CustomSqlQuery()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(notapelunasanprinciple))
        Dim TableQuery1 As DevExpress.DataAccess.Sql.TableQuery = New DevExpress.DataAccess.Sql.TableQuery()
        Dim RelationInfo1 As DevExpress.DataAccess.Sql.RelationInfo = New DevExpress.DataAccess.Sql.RelationInfo()
        Dim RelationColumnInfo1 As DevExpress.DataAccess.Sql.RelationColumnInfo = New DevExpress.DataAccess.Sql.RelationColumnInfo()
        Dim TableInfo1 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
        Dim ColumnInfo1 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim TableInfo2 As DevExpress.DataAccess.Sql.TableInfo = New DevExpress.DataAccess.Sql.TableInfo()
        Dim ColumnInfo2 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Dim ColumnInfo3 As DevExpress.DataAccess.Sql.ColumnInfo = New DevExpress.DataAccess.Sql.ColumnInfo()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.SqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource()
        Me.SqlDataSource2 = New DevExpress.DataAccess.Sql.SqlDataSource()
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand()
        Me.pelunasan = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.HeightF = 100.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 100.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 100.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'SqlDataSource1
        '
        Me.SqlDataSource1.ConnectionName = "139.162.57.197_ekspedisiConnection"
        Me.SqlDataSource1.Name = "SqlDataSource1"
        CustomSqlQuery1.Name = "CustomSqlQuery"
        CustomSqlQuery1.Sql = "select * from mprinciple"
        Me.SqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {CustomSqlQuery1})
        Me.SqlDataSource1.ResultSchemaSerializable = resources.GetString("SqlDataSource1.ResultSchemaSerializable")
        '
        'SqlDataSource2
        '
        Me.SqlDataSource2.ConnectionName = "139.162.57.197_ekspedisiConnection"
        Me.SqlDataSource2.Name = "SqlDataSource2"
        TableQuery1.Name = "dpelunasan_piutang"
        RelationColumnInfo1.NestedKeyColumn = "id_pelunasan"
        RelationColumnInfo1.ParentKeyColumn = "id_pelunasan"
        RelationInfo1.KeyColumns.AddRange(New DevExpress.DataAccess.Sql.RelationColumnInfo() {RelationColumnInfo1})
        RelationInfo1.NestedTable = "pelunasan_piutang"
        RelationInfo1.ParentTable = "dpelunasan_piutang"
        TableQuery1.Relations.AddRange(New DevExpress.DataAccess.Sql.RelationInfo() {RelationInfo1})
        TableInfo1.Name = "dpelunasan_piutang"
        ColumnInfo1.Name = "id_pelunasan"
        TableInfo1.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo1})
        TableInfo2.Name = "pelunasan_piutang"
        ColumnInfo2.Name = "id_principle"
        ColumnInfo3.Name = "keterangan"
        TableInfo2.SelectedColumns.AddRange(New DevExpress.DataAccess.Sql.ColumnInfo() {ColumnInfo2, ColumnInfo3})
        TableQuery1.Tables.AddRange(New DevExpress.DataAccess.Sql.TableInfo() {TableInfo1, TableInfo2})
        Me.SqlDataSource2.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() {TableQuery1})
        Me.SqlDataSource2.ResultSchemaSerializable = resources.GetString("SqlDataSource2.ResultSchemaSerializable")
        '
        'GroupHeader1
        '
        Me.GroupHeader1.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() {New DevExpress.XtraReports.UI.GroupField("id_principle", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
        Me.GroupHeader1.HeightF = 100.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'pelunasan
        '
        Me.pelunasan.Description = "Pelunasan"
        Me.pelunasan.Name = "pelunasan"
        Me.pelunasan.Visible = False
        '
        'notapelunasanprinciple
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1})
        Me.ComponentStorage.Add(Me.SqlDataSource1)
        Me.ComponentStorage.Add(Me.SqlDataSource2)
        Me.DataMember = "dpelunasan_piutang"
        Me.DataSource = Me.SqlDataSource2
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.pelunasan})
        Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
        Me.Version = "14.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents SqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents SqlDataSource2 As DevExpress.DataAccess.Sql.SqlDataSource
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents pelunasan As DevExpress.XtraReports.Parameters.Parameter
End Class
