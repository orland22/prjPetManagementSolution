Public Class petBreed
    Private petType As petType
    Private breedID As Integer
    Private breedname As String
    Private typeID As Integer
    Private breedStatus As String
    Private strAuditlog As String

    Public Sub New(intID As Integer)
        Dim dt As DataTable = GetDataTable($"SELECT * FROM tblbreed WHERE breedID = {intID}")
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                breedID = intID
                breedname = .Item("breedname")
                typeID = CType(.Item("typeID"), Integer)
                breedStatus = .Item("breedStatus")
            End With
            petType = New petType(typeID)
            'MsgBox($"{breedID}, {breedname}, {typeID}, {breedStatus}")
        End If
    End Sub

    Public Property Type As petType
        Get
            Return petType
        End Get
        Set(value As petType)
            If ExecuteUpdateLog(strAuditlog, "breed Form", "breed name", "pet", typeID, petType.Name, value.Name) Then
                petType = value

            End If
        End Set
    End Property

    Public ReadOnly Property ID As Integer
        Get
            Return breedID
        End Get
    End Property

    Public Property Name As String
        Get
            Return breedname
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditlog, "breed Form", "breed name", "breed", breedID, breedname, value) Then
                breedname = value

            End If
        End Set
    End Property

    Public ReadOnly Property Auditlog As String
        Get
            Return strAuditlog
        End Get
    End Property
End Class
