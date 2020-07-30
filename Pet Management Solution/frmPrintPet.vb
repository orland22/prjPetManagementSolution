Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class frmPrintPet
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load
        ' Dim dbconn As MySqlConnection
        'Dim strConn As String = "Server=localhost; User ID=root; Database=dbPets_Celestino; " + "Convert Zero Datetime=True;"
        crPets1.SummaryInfo.ReportTitle = My.Application.Info.ProductName
        crPets1.SummaryInfo.ReportAuthor = $"By  :{user.LastName}"

        Dim strQuery As String
        strQuery = "Select petID, petName, DATE_FORMAT(petBirthdate, '%M %d %Y')as petBirthdate, petGender, petStatus FROM tblpet ORDER BY petStatus"

        'Dim da As New MySqlDataAdapter(strQuery, dbconn)
        'Dim ds As New dsPets
        'da.Fill(ds, "tblpet")
        'dbconn.Close()
        'Dim myCR As New crPets
        'myCR.SetDataSource(ds.Tables(1))
        'CrystalReportViewer1.ReportSource = myCR
        'CrystalReportViewer1.Refresh()
        crPets1.SetDataSource(GetDataTable(strQuery))
        CrystalReportViewer1.ReportSource = crPets1
        CrystalReportViewer1.Refresh()
    End Sub

    ' Private Sub frmPrintPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' For Each ctrl As Control In CrystalReportViewer1.Controls
    'eOf ctrl Is System.Windows.Forms.ToolStrip Then
    ' AddHandler(CType(ctrl, ToolStrip).Items(1).Click), AddressOf AfterPrint

    'End If
    'Next
    'End Sub
End Class