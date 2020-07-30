Public Class Pet
    Private petID As Integer
    Private ownerID As Integer
    Private petName As String
    Private petBirthdate As String
    Private petGender As String
    Private petStatus As String
    Private breedID As Integer
    Private petNotes As String
    Private petOwner As petOwner
    Private petBreed As petBreed
    Private strAuditLog As String

    Public Sub New(intID As Integer)
        Dim dt As DataTable = GetDataTable($"SELECT * FROM tblpet WHERE petID = {intID}")
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                petID = .Item("petID")
                ownerID = CType(.Item("ownerID"), Integer)
                petName = .Item("petName")
                petBirthdate = .Item("petBirthdate")
                petGender = .Item("petGender")
                petStatus = .Item("petStatus")
                breedID = CType(.Item("petBreed"), Integer)
                petNotes = .Item("petNotes")
            End With
            'MsgBox($"{ownerID}, {petName}, {petBirthdate}, {petStatus}, {petBreed}, {petNotes}")
            petOwner = New petOwner(ownerID)
            petBreed = New petBreed(breedID)
            strAuditLog = String.Empty
        End If
    End Sub

    Public ReadOnly Property ID As Integer
        Get
            Return petID
        End Get
    End Property

    Public Property Owner As petOwner
        Get
            Return petOwner
        End Get
        Set(value As petOwner)
            If ExecuteUpdateLog(strAuditLog, "Main Form", "pet owner", "pet", petID, petOwner.Name, value.Name) Then
                petOwner = value

            End If
        End Set
    End Property

    Public Property Breed As petBreed
        Get
            Return petBreed
        End Get
        Set(value As petBreed)
            If ExecuteUpdateLog(strAuditLog, "Main Form", "pet breed", "pet", petID, petBreed.Name, value.Name) Then
                ExecuteUpdateLog(strAuditLog, "Main Form", "pet type", "pet", petID, petBreed.Type.Name, value.Type.Name)
                petBreed = value

            End If
        End Set
    End Property

    Public ReadOnly Property Type As petType
        Get
            Return petBreed.Type
        End Get
    End Property

    Public Property Name As String
        Get
            Return petName
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditLog, "Main Form", "pet name", "pet", petID, petName, value) Then
                petName = value

            End If
        End Set
    End Property

    Public Property Birthdate As String
        Get
            Return CDate(petBirthdate).ToString("dd/MM/yyyy")
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditLog, "Main Form", "pet birthday", "pet", petID, petBirthdate, value) Then
                petBirthdate = value

            End If
        End Set
    End Property

    Public Property Gender As String
        Get
            Return petGender
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditLog, "Main Form", "pet gender", "pet", petID, petGender, value) Then
                petGender = value

            End If
        End Set

    End Property

    Public Property Status As String
        Get
            Return petStatus
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditLog, "Main Form", "pet status", "pet", petID, petStatus, value) Then
                petStatus = value

            End If
        End Set
    End Property

    Public Property Notes As String
        Get
            Return petNotes
        End Get
        Set(value As String)
            If ExecuteUpdateLog(strAuditLog, "Main Form", "pet note", "pet", petID, petNotes, value) Then
                petNotes = value

            End If
        End Set
    End Property

    Public ReadOnly Property Auditlog As String
        Get
            Return strAuditLog
        End Get
    End Property
End Class
