Public Class Login
    Private intID As Integer
    Private strUserName As String
    Private strPassWord As String
    Private strFirstName As String
    Private strLastName As String
    Private strContactNum As String
    Private intType As String
    Private strType As String
    Private boLog As Boolean
    Private strStatus As String
    Public Sub New(strUser As String, strPass As String)

        Dim strSQL As String = $"Select * FROM tblUser WHERE userName ='{strUser}' LIMIT 1"
        Dim dt = GetDataTable(strSQL)
        Dim isValid As Boolean
        If dt.Rows.Count() > 0 Then
            With dt.Rows(0)
                intID = CType(.Item("userID"), Integer)
                strUserName = dt.Rows(0).Item("userName").ToString
                strFirstName = dt.Rows(0).Item("userFirstname").ToString
                strLastName = dt.Rows(0).Item("userLastname").ToString
                intType = CType(.Item("userType"), Integer)
                strType = If(intType = 0, "Encoder", "Admin")
                strStatus = dt.Rows(0).Item("userStatus").ToString
            End With
            strSQL = $"SELECT userPassword=md5('{strPass}') AS isValid FROM tbluser WHERE userID={intID} "
            dt = GetDataTable(strSQL)
            isValid = CType(dt.Rows(0).Item("isValid"), Integer) = 1
            If isValid AndAlso strStatus = "Active" Then
                boLog = True
                ExecuteSucessLog(intID)
            Else
                boLog = False
                ExecuteUnsuccessLog(intID)
            End If

        Else
            boLog = False
        End If

    End Sub

    Public ReadOnly Property LoggIN As Boolean
        Get
            Return boLog
        End Get
    End Property

    Public ReadOnly Property Username As String
        Get
            Return strUserName
        End Get
    End Property

    Public ReadOnly Property FirtsName As String
        Get
            Return strFirstName
        End Get
    End Property

    Public ReadOnly Property LastName As String
        Get
            Return strLastName
        End Get
    End Property

    Public ReadOnly Property IsActive As Boolean
        Get
            Return strStatus = "Active"
        End Get
    End Property

    Public ReadOnly Property ID As Integer
        Get
            Return intID
        End Get
    End Property

    'new 
    ' Public ReadOnly Property Type As String
    ' Get
    '   Return strType
    ' End Get
    'End Property
End Class
