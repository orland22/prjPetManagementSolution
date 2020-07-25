Imports MySql.Data.MySqlClient
Module modPet
    Private dbconn As MySqlConnection
    Private sqlcommand As MySqlCommand
    Private da As MySqlDataAdapter
    Private dt As DataTable

    Dim strConn As String = "Server=localhost; User ID=root; Database=dbPets_Celestino; " + "Convert Zero Datetime=True;"

    Public Sub dbConnection()
        Try
            dbconn = New MySqlConnection(strConn)
            dbconn.Open()
            MessageBox.Show("DB test connection is succesfull", "Pet DDMS")
            dbconn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: db Connection()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function isFound(ByVal SQL As String, ByVal name As String, ByVal address As String, ByVal valueItem As String, ByVal addItem As String) As Boolean
        Dim value = "", add = ""
        Dim found = False
        Try
            dbconn.Open()
            da = New MySqlDataAdapter(SQL, dbconn)
            dt = New DataTable
            da.Fill(dt)

            For Each row As DataRow In dt.Rows
                value = row.Item(valueItem) ' you can use this index specific instead value = row.Item(1)
                add = row.Item(addItem) ' you can use this index specific instead value = row.Item(1)

                If value = name And add = address Then
                    found = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error 106: isFound" & ex.Message)
        Finally
            dbconn.Close()
        End Try
        Return found
    End Function
    Public Sub DisplayRecords(ByVal strSql As String, ByVal dg As DataGridView)
        dg.DataSource = GetDataTable(strSql)
    End Sub

    Public Function GetDataTable(ByVal strSql As String) As DataTable
        Try
            dbconn.Open()
            da = New MySqlDataAdapter(strSql, dbconn)
            dt = New DataTable
            da.Fill(dt)
            GetDataTable = dt


        Catch ex As Exception
            MessageBox.Show("Error : DisplayRecords() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            GetDataTable = New DataTable
        Finally
            dbconn.Close()
        End Try

    End Function

    Public Function RecordCount() As Integer
        Dim count As Integer = 0
        Dim strSQL As String = "Select * FROM tblPet ORDER By petID DESC LIMIT 1"
        Dim dt = GetDataTable(strSQL)

        If dt.Rows.Count() > 0 Then
            count = dt.Rows(0).Item("petID")
        Else
            count = 0
        End If
        Return count
    End Function

    Public Function AllPet() As String
        Try
            dbconn.Open()
            Dim what As New MySqlCommand("SELECT COUNT(*) FROM tblpet", dbconn)
            Return what.ExecuteScalar.ToString
        Catch ex As Exception
            MessageBox.Show("Error: CountPet()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbconn.Close()
        End Try

    End Function

    Public Function ActivePet() As String
        Try
            dbconn.Open()
            Dim what As New MySqlCommand("SELECT COUNT(*) FROM tblpet WHERE petStatus='Active' ", dbconn)
            Return what.ExecuteScalar.ToString
        Catch ex As Exception
            MessageBox.Show("Error: CountPet()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbconn.Close()
        End Try

    End Function

    Public Function InacPet() As String
        Try
            dbconn.Open()
            Dim what As New MySqlCommand("SELECT COUNT(*) FROM tblpet WHERE petStatus='inactive' ", dbconn)
            Return what.ExecuteScalar.ToString
        Catch ex As Exception
            MessageBox.Show("Error: CountPet()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbconn.Close()
        End Try

    End Function

    Public Function GetPetType(intTypeID As Integer) As String
        Dim strSQL As String = "SELECT typeName FROM tbltype WHERE typeID = " & intTypeID.ToString
        Try
            dbconn.Open()
            da = New MySqlDataAdapter(strSQL, dbconn)
            dt = New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("typeName")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: GetPetType() " & ex.Message, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbconn.Close()
        End Try
        Return String.Empty
    End Function

    Public Sub LoadToComboBox(ByVal strSQL As String, ByRef combo As ComboBox, ByVal strValue As String, ByVal strDisplay As String)
        Dim dt = GetDataTable(strSQL)
        combo.DataSource = dt
        combo.ValueMember = dt.Columns(strValue).ToString
        combo.DisplayMember = dt.Columns(strDisplay).ToString


    End Sub

    Public Sub SQLManager(ByVal strSQL As String, ByVal strMsg As String)
        Try
            dbconn.Open()
            sqlcommand = New MySqlCommand(strSQL, dbconn)
            With sqlcommand
                .CommandType = CommandType.Text
                .ExecuteNonQuery()

            End With
            dbconn.Close()

            MessageBox.Show(strMsg, "Pet DBMS", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error: SQLManager()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dbconn.Close()
        End Try
    End Sub
End Module

