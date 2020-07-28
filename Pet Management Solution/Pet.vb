Public Class Pet
    Private petID As Integer
    Private ownerID As Integer
    Private petName As String
    Private petBirthdate As String
    Private petGender As String
    Private petStatus As String
    Private petBreed As Integer
    Private petNotes As String
    Private owner As petOwner

    Public Sub New(intID As Integer)
        Dim dt As DataTable = GetDataTable($"SELECT * FROM tblpet WHERE petID =
{intID}")
        If dt.Rows.Count > 0 Then
            With dt.Rows(0)
                petID = intID
                ownerID = CType(.Item("ownerID"), Integer)
                petName = .Item("petName")
                petBirthdate = .Item("petBirthdate")
                petGender = .Item("petGender")
                petStatus = .Item("petStatus")
                petBreed = CType(.Item("petBreed"), Integer)
                petNotes = .Item("petNotes")
            End With
            owner = New petOwner(ownerID)
        End If
    End Sub

End Class
