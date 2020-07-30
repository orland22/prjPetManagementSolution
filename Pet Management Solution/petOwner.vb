Public Class petOwner
    Private ownerID As Integer
    Private ownerName As String
    Private ownerAddress As String
    Private ownerContactNumber As String
    Private ownerStatus As String
    Private strAuditlog As String

    Public Sub New(intID As Integer)
        Dim dt As DataTable = GetDataTable($"SELECT * FROM tblowner WHERE ownerID = {intID}")
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                ownerID = intID
                ownerName = .Item("ownerName")
                ownerAddress = .Item("ownerAddress")
                ownerContactNumber = .Item("ownerContactNumber")
                ownerStatus = .Item("ownerStatus")
            End With
            'MsgBox($"{ownerID}, {ownerName}, {ownerAddress}, {ownerAddress}, {ownerContactNumber}, {ownerStatus}")
        End If
    End Sub

    Public ReadOnly Property ID As Integer
        Get
            Return ownerID
        End Get
    End Property

    Public Property Name As String
        Get
            Return ownerName
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditlog, "Pet Owner", "owner name", "owner", ownerID, ownerName, value) Then
                ownerName = value

            End If
        End Set
    End Property

    Public Property Address As String
        Get
            Return ownerAddress
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditlog, "Pet Owner", "owner address", "owner", ownerID, ownerAddress, value) Then
                ownerAddress = value

            End If
        End Set

    End Property
    Public Property Phone As String
        Get
            Return ownerContactNumber
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditlog, "Owner Form", "owner contact", "owner", ownerID, ownerContactNumber, value) Then
                ownerContactNumber = value

            End If
        End Set
    End Property
    Public ReadOnly Property Auditlog As String
        Get
            Return strAuditlog
        End Get
    End property




End Class
