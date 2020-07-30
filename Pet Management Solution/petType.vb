Public Class petType
    Private typeID As Integer
    Private typeName As String
    Private typeStatus As String
    Private strAuditlog As String

    Public Sub New(intID As Integer)
        Dim dt As DataTable = GetDataTable($"SELECT * FROM tbltype WHERE typeID = {intID}")
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                typeID = intID
                typeName = .Item("typeName")
                typeStatus = .Item("typeStatus")
            End With
            'MsgBox($"{typeID}, {typeName}, {typeStatus}")
        End If
    End Sub

    Public ReadOnly Property ID As Integer
        Get
            Return typeID
        End Get
    End Property
    Public Property Name As String
        Get
            Return typeName
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditlog, "Type Form", "type pet", "pet name", typeID, typeName, value) Then
                typeName = value

            End If
        End Set
    End Property

    Public ReadOnly Property Auditlog As String
        Get
            Return strAuditlog
        End Get
    End Property


End Class
