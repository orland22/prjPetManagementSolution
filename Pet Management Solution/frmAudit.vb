Public Class frmAudit
    Private Sub frmAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strQuery As String = "SELECT logID as ID, logDatetime as Date, CONCAT(userFirstname,' ',userLastname) as User, logModule as Form, logComment as Comment FROM tblauditlog LEFT JOIN tbluser USING(userID)"
        DisplayRecords(strQuery, dtAudit)
    End Sub
End Class