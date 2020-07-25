Public Class Login
    Private strUserName As String
    Private strPassWord As String
    Private strFirstName As String
    Private strLastName As String
    Private strContactNum As String
    Private intType As String
    Private strType As String
    Private boLog As Boolean

    Public Sub New(strUser As String, strPass As String)


        Dim strSQL As String = "Select * FROM tblUser WHERE userName ='" & strUser & "' AND userPassword = md5('" & strPass & "') LIMIT 1"
        Dim dt = GetDataTable(strSQL)

        If dt.Rows.Count() > 0 Then
            strUserName = dt.Rows(0).Item("userName").ToString
            strFirstName = dt.Rows(0).Item("userFirstname").ToString
            strLastName = dt.Rows(0).Item("userLastname").ToString
            intType = CType(dt.Rows(0).Item("userType"), Integer)

            strType = If(intType = 0, "Encoder", "Admin")
            boLog = True
        Else
            MsgBox("Invalid user and password.")
            boLog = False
        End If

    End Sub

    Public ReadOnly Property LoggIN As Boolean
        Get
            Return boLog
        End Get
    End Property

    ' Public Property Username As String
    't
    ' Return strUserName
    'End Get
    'Set(value As String)

    'End Set
    'End Property



End Class
