Imports System.IO
Public Class Form1
    Dim connection As DBConnection = New DBConnection()
    Dim login As New LogInWindow

    Private Sub dataBaseGetData(stm, Item)
        Dim connStr As String
        If (Wypozyczalnia.SelectedIndex < 0 OrElse Wypozyczalnia.SelectedItem.ToString.Equals("Wszystkie")) Then
            For i = 0 To Wypozyczalnia.Items.Count - 2
                connStr = "server=localhost;user=root;database=""" + Wypozyczalnia.Items(i + 1).ToString + """;port=3306;password=root;"
                connection.connectionToDatabase(stm, connStr, Item)
            Next i
        Else
            connStr = "server=localhost;user=root;database=""" + Wypozyczalnia.SelectedItem.ToString + """;port=3306;password=root;"
            connection.connectionToDatabase(stm, connStr, Item)
        End If
    End Sub

    Private Sub Okno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item = Me.Wypozyczalnia
        Wypozyczalnia.Items.Add("Wszystkie")
        connection.getDataBaseName(item)

        Dim stmDB As String = "SELECT DISTINCT marka FROM cars"
        dataBaseGetData(stmDB, Marka)

        Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\download.png"))

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Marka.SelectedIndexChanged

        Me.Model.Items.Clear()
        Me.Model.ResetText()
        Me.Silnik.Items.Clear()
        Me.Silnik.ResetText()
        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()

        Dim stmDB As String = "SELECT DISTINCT model FROM cars WHERE marka = """ + Marka.SelectedItem.ToString + """"
        dataBaseGetData(stmDB, Model)

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Model.SelectedIndexChanged

        Me.Silnik.Items.Clear()
        Me.Silnik.ResetText()
        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()

        Dim stmDB As String = "SELECT DISTINCT silnik FROM cars WHERE marka = """ + Marka.SelectedItem.ToString + """ AND model = """ + Model.SelectedItem.ToString + """"
        dataBaseGetData(stmDB, Silnik)

        If (File.Exists(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\" + Model.SelectedItem.ToString) + ".png")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\" + Model.SelectedItem.ToString) + ".png")
        Else
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\download.png"))
        End If

    End Sub
    Private Sub Silnik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Silnik.SelectedIndexChanged

        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()

        Dim stmDB As String = "SELECT DISTINCT kolor FROM cars WHERE marka = """ + Marka.SelectedItem.ToString + """ AND model = """ + Model.SelectedItem.ToString + """ AND silnik = """ + Silnik.SelectedItem.ToString + """"
        dataBaseGetData(stmDB, Kolor)

    End Sub

    Private Sub Metalik_CheckedChanged(sender As Object, e As EventArgs) Handles Metalik.CheckedChanged
        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()

        If (Metalik.Checked = True) Then
            Dim stmDB As String = "SELECT DISTINCT kolor FROM cars WHERE marka = """ + Marka.SelectedItem.ToString + """ AND model = """ + Model.SelectedItem.ToString + """ AND silnik = """ + Silnik.SelectedItem.ToString + """ AND metalik = 1"
            Console.WriteLine(stmDB)
            dataBaseGetData(stmDB, Kolor)
            If (Me.Kolor.Size.Equals(0)) Then
                MessageBox.Show("Brak koloru")
            End If
        Else
            Silnik_SelectedIndexChanged(Silnik.SelectedItem, e)
        End If

    End Sub

    Private Sub Kolor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Kolor.SelectedIndexChanged
        Dim stmDB As String = "SELECT klima FROM cars WHERE marka = """ + Marka.SelectedItem.ToString + """ AND model = """ + Model.SelectedItem.ToString + """ AND silnik = """ + Silnik.SelectedItem.ToString + """ AND kolor = """ + Kolor.SelectedItem.ToString + """"
        dataBaseGetData(stmDB, 0)
        stmDB = "SELECT radio FROM cars WHERE marka = """ + Marka.SelectedItem.ToString + """ AND model = """ + Model.SelectedItem.ToString + """ AND silnik = """ + Silnik.SelectedItem.ToString + """ AND kolor = """ + Kolor.SelectedItem.ToString + """"
        dataBaseGetData(stmDB, 1)
        stmDB = "SELECT gps FROM cars WHERE marka = """ + Marka.SelectedItem.ToString + """ AND model = """ + Model.SelectedItem.ToString + """ AND silnik = """ + Silnik.SelectedItem.ToString + """ AND kolor = """ + Kolor.SelectedItem.ToString + """"
        dataBaseGetData(stmDB, 2)
        stmDB = "SELECT kamera FROM cars WHERE marka = """ + Marka.SelectedItem.ToString + """ AND model = """ + Model.SelectedItem.ToString + """ AND silnik = """ + Silnik.SelectedItem.ToString + """ AND kolor = """ + Kolor.SelectedItem.ToString + """"
        dataBaseGetData(stmDB, 3)
        Opcje.Enabled = False
    End Sub

    Private Sub AddCarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCarToolStripMenuItem.Click
        Dim myForm As New AddCar
        myForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ratings As New ShowRating
        ratings.Show()
    End Sub

    Private Sub Wypozyczalnia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Wypozyczalnia.SelectedIndexChanged
        Me.Marka.Items.Clear()
        Me.Marka.ResetText()
        Me.Model.Items.Clear()
        Me.Model.ResetText()
        Me.Silnik.Items.Clear()
        Me.Silnik.ResetText()
        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()

        Dim stmDB As String = "SELECT DISTINCT marka FROM cars"
        dataBaseGetData(stmDB, Marka)
    End Sub


    Private Sub LogInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogInToolStripMenuItem.Click
        login.Show()
    End Sub

    Public Sub checkLoginData(item)
        login.Close()
        Me.AddCarToolStripMenuItem.Enabled = True
        Me.AddCarToolStripMenuItem.Visible = True
        Me.ShowCarsToolStripMenuItem.Visible = True
        Me.ShowCarsToolStripMenuItem.Enabled = True
        Me.AddNewToolStripMenuItem.Enabled = True
        Me.AddNewToolStripMenuItem.Visible = True
        Me.LogInToolStripMenuItem.Enabled = False
        Me.LogInToolStripMenuItem.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rating As New Rating
        rating.Show()

        Dim item = rating.ComboBox1
        connection.getDataBaseName(item)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ShowCarsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowCarsToolStripMenuItem.Click
        Dim database As New ShowDatabases
        database.Show()
    End Sub

    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        Dim newrental As New NewRental
        newrental.Show()
    End Sub
End Class
