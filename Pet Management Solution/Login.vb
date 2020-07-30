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
    Private strAuditlog As String
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
    Public Sub New(userID As Integer)
        Dim strSQL As String = $"Select * FROM tbluser WHERE userID ={userID}"
        Dim dt = GetDataTable(strSQL)
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                Me.intID = .Item("userID")
                strFirstName = .Item("userFirstname")
                strLastName = .Item("userLastname")
                strContactNum = .Item("userContactNum")
                strUserName = .Item("userName")
                strPassWord = String.Empty
                strType = CType(.Item("userType"), Integer)
                strStatus = .Item("userStatus")
            End With
        End If


    End Sub


    Public ReadOnly Property LoggIN As Boolean
        Get
            Return boLog
        End Get
    End Property

    Public Property Username As String
        Get
            Return strUserName
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditlog, "User Form", "user name", "user", intID, strUserName, value) Then
                strUserName = value
            End If
        End Set
    End Property

    Public Property FirtsName As String
        Get
            Return strFirstName
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditlog, "User Form", "user", "FirstName", intID, strFirstName, value) Then
                strFirstName = value

            End If
        End Set
    End Property

    Public Property LastName As String
        Get
            Return strLastName
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditlog, "User Form", "user", "LastName", intID, strLastName, value) Then
                strLastName = value

            End If
        End Set
    End Property
    Public Property Contact As String
        Get
            Return strContactNum
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditlog, "User form", "user contact", "Contact", intID, strContactNum, value) Then
                strContactNum = value

            End If
        End Set
    End Property
    Public Property Password As String
        Get
            Return strPassWord
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditlog, "User form", "user pass", "user", intID, strPassWord, value) Then
                strPassWord = value

            End If
        End Set
    End Property
    Public Property Type As String
        Get
            Return strType
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditlog, "User form", "user type", "usert", intID, strType, value) Then
                strType = value

            End If
        End Set
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

    Public ReadOnly Property Auditlog As String
        Get
            Return strAuditlog
        End Get
    End Property

End Class
