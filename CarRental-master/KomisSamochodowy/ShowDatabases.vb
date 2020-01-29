Public Class ShowDatabases
    Dim connection As DBConnection = New DBConnection()
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item = Me.ListBox1
        connection.getDataBaseName(item)
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim connStr As String = "server=localhost;user=root;database=""" + ListBox1.SelectedItem.ToString + """;port=3306;password=root;"
        Dim stm As String = "SELECT * FROM cars"
        Dim item = DataGridView1

        connection.connectionToDatabase(stm, connStr, item)
    End Sub

    Private Sub Powrot_Click(sender As Object, e As EventArgs) Handles Powrot.Click
        Me.Close()
    End Sub

    Private Sub Wybierz_Click(sender As Object, e As EventArgs) Handles Wybierz.Click
        Me.Close()
    End Sub
End Class