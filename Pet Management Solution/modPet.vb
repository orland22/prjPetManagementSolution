Imports MySql.Data.MySqlClient

Module modPet
    Private dbconn As MySqlConnection
    Private sqlcommand As MySqlCommand
    Private da As MySqlDataAdapter
    Private dt As DataTable
    Public user As Login

    Dim strConn As String = "Server=localhost; User ID=root; Database=dbPets_Celestino; " + "Convert Zero Datetime=True;"

    Public Sub dbConnection()
        Try
            dbconn = New MySqlConnection(strConn)
            dbconn.Open()
            MsgBox("ACCESS GUARANTEED", MsgBoxStyle.Information)
            dbconn.Close()

        Catch ex As Exception
            MessageBox.Show("Error: db Connection()" & ex.Message, "pet dbms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub DisplayRecords(ByVal strSql As String, ByVal dg As DataGridView)
        dg.DataSource = GetDataTable(strSql)
    End Sub

    Public Function GetDataTable(ByVal strSQL As String) As DataTable
        Try
            dbconn = New MySqlConnection(strConn)
            dbconn.Open()
            da = New MySqlDataAdapter(strSQL, dbconn)
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

    Public Function RecordCount(strTable As String, strColumn As String) As Integer
        Dim count As Integer = 0
        Dim strSQL As String = $"SELECT * FROM {strTable} ORDER BY {strColumn} DESC LIMIT 1"
        Dim dt = GetDataTable(strSQL)

        If dt.Rows.Count() > 0 Then
            count = dt.Rows(0).Item(strColumn)
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

    Public Sub LoadToComboBox(ByVal strSQL As String, ByRef combo As ComboBox, ByVal strValue As String, ByVal strDisplay As String, strColumnStatus As String)
        If strSQL.ToLower.Contains("where") Then
            strSQL += $" AND {strColumnStatus} ='Active'"
        Else
            strSQL += $" WHERE {strColumnStatus} ='Active'"
        End If
        'MsgBox(strSQL)
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
    Public Function SQLManager(ByVal strSQL As String) As Boolean
        Try
            dbconn.Open()
            sqlcommand = New MySqlCommand(strSQL, dbconn)
            With sqlcommand
                .CommandType = CommandType.Text
                .ExecuteNonQuery()
            End With
            dbconn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Sub ExecuteUnsuccessLog(intID As Integer)
        Dim strQuery As String = $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment ) VALUES
     (now(), 0, {intID}, 'Login ', 'INVALID username/password')"

        SQLManager(strQuery)


    End Sub

    Public Sub ExecuteSucessLog(intID As Integer)
        Dim strQuery As String = $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment ) VALUES
     (now(), 1, {intID}, 'Login FORM ', 'SuccessFul Login')"

        SQLManager(strQuery)
    End Sub

    Public Sub ExecuteCreateLog(strForm As String, strObject As String, intID As Integer)
        Dim strQuery As String = $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES
     (now(), 2, {user.ID}, '{strForm} ', 'Create new {strObject} -# {intID}') "

        SQLManager(strQuery)
    End Sub

    Public Function ExecuteUpdateLog(ByRef strSQL As String, strForm As String, strColumn As String, strObject As String, intID As Integer, beforeValue As String, afterValue As String) As Boolean
        If beforeValue <> afterValue Then
            strSQL += $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES
     (now(), 3, {user.ID}, '{strForm} ', 'UPDATE {strColumn} of {strObject} - #{intID} FROM ""{beforeValue}"" to ""{afterValue}"" '); "
            MsgBox($"{beforeValue} to {afterValue}")
            'SQLManager(strQuery)
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub ExecuteDeleteLog(strForm As String, strObject As String, intID As Integer)
        Dim strQuery As String = $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment) VALUES
     (now(), 4, {user.ID}, '{strForm} ', 'Deactivated {strObject} -# {intID}') "

        SQLManager(strQuery)

    End Sub

    Public Sub ExecutePrint(ByRef strQuery As String, strForm As String)
        strQuery += $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment ) VALUES (now(), 5, {user.ID}, '{strForm}', 'Printed')"

        SQLManager(strQuery)
    End Sub

    Public Sub ExecuteLogout()
        Dim strQuery As String = $"INSERT INTO tblauditlog (logDateTime, logType, userID, logModule, logComment ) VALUES
     (now(), 6, {user.ID}, 'Main Form', 'Logout successfully')"

        SQLManager(strQuery)

    End Sub
End Module

