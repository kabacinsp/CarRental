Public Class LogInWindow
    Dim connection As DBConnection = New DBConnection()

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SigninButton.Click
        Dim connStr As String = "server=localhost;user=root;database=users;port=3306;password=root;"
        Dim stm As String = "SELECT login FROM users WHERE login =""" + LoginField.Text.ToString + """ AND haslo=""" + PasswordField.Text.ToString + """"
        connection.connectionToDatabase(stm, connStr, 1)
    End Sub

End Class