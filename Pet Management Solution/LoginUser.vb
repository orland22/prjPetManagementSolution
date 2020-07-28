Public Class LoginUser

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    ' Private login As Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim form As New frmMain
        user = New Login(UsernameTextBox.Text, PasswordTextBox.Text)
        If user.LoggIN Then

            Me.Hide()
            form.ShowDialog()
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            Me.Show()
        ElseIf user.Username <> String.Empty AndAlso user.IsActive Then
            MsgBox("User is Deactivited by Administrator", MsgBoxStyle.Exclamation)
        Else
            MsgBox("Access denied ,Invalid username or password!.", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
