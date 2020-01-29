Public Class NewRental
    Dim connection As DBConnection = New DBConnection()
    Private Sub Stworz_Click(sender As Object, e As EventArgs) Handles Stworz.Click
        Dim connStr As String = "server=localhost;user=root;database=intercars;port=3306;password=root;"

        Dim stmDB As String = "DROP SCHEMA IF EXISTS " + Baza.Text.ToString + ";" + "CREATE DATABASE " + Baza.Text.ToString + ";" + "USE " + Baza.Text.ToString + ";" +
            "CREATE TABLE cars(
            id Int NOT NULL AUTO_INCREMENT,
            marka VARCHAR(20) Not NULL,
            model VARCHAR(20) Not NULL,
            silnik VARCHAR(20) Not NULL,
            kolor VARCHAR(20) Not NULL,
            metalik tinyint(1) Not NULL,
            klima tinyint(1) Not NULL,
            radio tinyint(1) Not NULL,
            gps tinyint(1) Not NULL,
            kamera tinyint(1) Not NULL,
            PRIMARY KEY(id));" +
            "CREATE TABLE rating(
            id INT NOT NULL AUTO_INCREMENT,
            ocena INT(1) NOT NULL,
            komentarz VARCHAR(200),
            PRIMARY KEY ( id )
            );"


        connection.connectionToDatabase(stmDB, connStr, stmDB)

        Me.Close()
    End Sub

    Private Sub Powrot_Click(sender As Object, e As EventArgs) Handles Powrot.Click
        Me.Close()
    End Sub
End Class