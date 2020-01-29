Public Class ShowRating
    Dim connection As DBConnection = New DBConnection()
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item = Me.ListBox1
        connection.getDataBaseName(item)


    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim connStr As String = "server=localhost;user=root;database=""" + ListBox1.SelectedItem.ToString + """;port=3306;password=root;"
        Dim stmDB As String = "SELECT FORMAT(AVG(ocena), 1) FROM rating"
        Dim label = Label2

        connection.connectionToDatabase(stmDB, connStr, label)

        Dim stm As String = "SELECT * FROM rating"
        Dim item = DataGridView1

        connection.connectionToDatabase(stm, connStr, item)
    End Sub

    Private Sub Powrot_Click(sender As Object, e As EventArgs) Handles Powrót.Click
        Me.Close()
    End Sub
End Class