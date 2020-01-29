Imports System.IO

Public Class Form1

    Structure Samochod
        Public Marka As String
        Public Model As String
        Public Silnik As String
        Public Kolor As String
        Public Klima As Boolean
        Public Sub New(ByVal marka As String, ByVal model As String, ByVal silnik As String, ByVal kolor As String, ByVal klima As Boolean)
            Me.Marka = marka
            Me.Model = model
            Me.Silnik = silnik
            Me.Kolor = kolor
            Me.Klima = klima
        End Sub
    End Structure

    Public nowySamochod As New List(Of Samochod)
    Public carsCollection As ICollection

    Private Sub Okno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nowySamochod.Add(New Samochod("Audi", "A3", "1.6", "Biały", True))
        nowySamochod.Add(New Samochod("Audi", "A3", "1.6", "Srebny", True))
        nowySamochod.Add(New Samochod("Audi", "A3", "1.6", "Czarny", True))
        nowySamochod.Add(New Samochod("Audi", "A3", "1.9TDI", "Czarny", False))
        nowySamochod.Add(New Samochod("Audi", "A3", "1.9TDI", "Niebieski", False))
        nowySamochod.Add(New Samochod("Audi", "A3", "1.9TDI", "Biały", True))
        nowySamochod.Add(New Samochod("Audi", "A4", "1.9TDI", "Czarny", True))
        nowySamochod.Add(New Samochod("Audi", "A4", "1.9TDI", "Srebny", True))
        nowySamochod.Add(New Samochod("Audi", "A4", "2.0", "Czarny", True))
        nowySamochod.Add(New Samochod("Audi", "A4", "2.0", "Srebny", False))
        nowySamochod.Add(New Samochod("Audi", "A4", "2.2", "Czarny", False))
        nowySamochod.Add(New Samochod("Audi", "A4", "2.2", "Zielony", True))
        nowySamochod.Add(New Samochod("Audi", "A6", "2.0", "Czarny", False))
        nowySamochod.Add(New Samochod("Audi", "A6", "2.0", "Niebieski", False))
        nowySamochod.Add(New Samochod("Audi", "A6", "2.0", "Srebny", False))
        nowySamochod.Add(New Samochod("Audi", "A6", "2.2", "Niebieski", False))
        nowySamochod.Add(New Samochod("Audi", "A6", "2.2", "Zielony", True))
        nowySamochod.Add(New Samochod("Audi", "A6", "2.2", "Srebny", True))
        nowySamochod.Add(New Samochod("Audi", "A6", "2.2", "Srebny", True))

        nowySamochod.Add(New Samochod("BMW", "Series 3", "2.0", "Srebny", True))
        nowySamochod.Add(New Samochod("BMW", "Series 3", "2.0", "Biały", True))
        nowySamochod.Add(New Samochod("BMW", "Series 3", "2.0", "Szary", True))
        nowySamochod.Add(New Samochod("BMW", "Series 3", "1.8", "Srebny", True))
        nowySamochod.Add(New Samochod("BMW", "Series 3", "1.8", "Czarny", True))
        nowySamochod.Add(New Samochod("BMW", "Series 3", "1.8", "Biały", True))
        nowySamochod.Add(New Samochod("BMW", "Series 5", "2.0", "Srebny", True))
        nowySamochod.Add(New Samochod("BMW", "Series 5", "2.0", "Czarny", True))
        nowySamochod.Add(New Samochod("BMW", "Series 5", "2.0", "Granatowy", True))
        nowySamochod.Add(New Samochod("BMW", "Series 5", "2.0", "Czarwony", True))
        nowySamochod.Add(New Samochod("BMW", "Series 5", "2.0", "Szary", True))
        nowySamochod.Add(New Samochod("BMW", "X3", "1.8", "Biały", True))
        nowySamochod.Add(New Samochod("BMW", "X3", "1.8", "Biały", False))
        nowySamochod.Add(New Samochod("BMW", "X3", "1.8", "Czarny", True))
        nowySamochod.Add(New Samochod("BMW", "X3", "1.8", "Srebny", True))
        nowySamochod.Add(New Samochod("BMW", "X3", "2.0", "Szary", True))
        nowySamochod.Add(New Samochod("BMW", "X3", "2.0", "Szary", False))
        nowySamochod.Add(New Samochod("BMW", "X3", "2.0", "Zielony", True))
        nowySamochod.Add(New Samochod("BMW", "X3", "2.0", "Srebny", True))

        nowySamochod.Add(New Samochod("Citroen", "Berlingo", "1.4", "Srebny", True))
        nowySamochod.Add(New Samochod("Citroen", "Berlingo", "1.4", "Srebny", False))
        nowySamochod.Add(New Samochod("Citroen", "Berlingo", "1.4", "Niebieski", True))
        nowySamochod.Add(New Samochod("Citroen", "Berlingo", "1.8", "Srebny", True))
        nowySamochod.Add(New Samochod("Citroen", "Berlingo", "1.8", "Zloty", True))
        nowySamochod.Add(New Samochod("Citroen", "Berlingo", "1.8", "Srebny", False))
        nowySamochod.Add(New Samochod("Citroen", "C3", "1.1", "Zolty", False))
        nowySamochod.Add(New Samochod("Citroen", "C3", "1.1", "Niebieski", False))
        nowySamochod.Add(New Samochod("Citroen", "C3", "1.1", "Czerowny", False))
        nowySamochod.Add(New Samochod("Citroen", "C3", "1.1", "Pomaranczowy", False))
        nowySamochod.Add(New Samochod("Citroen", "C3", "1.1", "Zielony", False))
        nowySamochod.Add(New Samochod("Citroen", "C3", "1.1", "Fioletowy", False))
        nowySamochod.Add(New Samochod("Citroen", "Jumper", "1.8", "Bialy", True))
        nowySamochod.Add(New Samochod("Citroen", "Jumper", "1.8", "Bialy", False))
        nowySamochod.Add(New Samochod("Citroen", "Jumper", "1.8", "Czarny", True))
        nowySamochod.Add(New Samochod("Citroen", "Jumper", "2.5", "Bialy", True))
        nowySamochod.Add(New Samochod("Citroen", "Jumper", "2.5", "Bialy", False))
        nowySamochod.Add(New Samochod("Citroen", "Jumper", "2.5", "Zolty", True))
        nowySamochod.Add(New Samochod("Citroen", "Jumper", "2.5", "Srebny", True))

        nowySamochod.Add(New Samochod("Fiat", "500", "1.2", "Czerwony", True))
        nowySamochod.Add(New Samochod("Fiat", "500", "1.2", "Srebny", True))
        nowySamochod.Add(New Samochod("Fiat", "500", "1.2", "Czerwony", False))
        nowySamochod.Add(New Samochod("Fiat", "500", "1.2", "Zielony", True))
        nowySamochod.Add(New Samochod("Fiat", "500", "1.4", "Zolty", True))
        nowySamochod.Add(New Samochod("Fiat", "500", "1.4", "Czerwony", True))
        nowySamochod.Add(New Samochod("Fiat", "500", "1.4", "Czerwony", False))
        nowySamochod.Add(New Samochod("Fiat", "Panda", "1.3", "Granatowy", False))
        nowySamochod.Add(New Samochod("Fiat", "Panda", "1.3", "Bialy", False))
        nowySamochod.Add(New Samochod("Fiat", "Panda", "1.3", "Zielony", True))
        nowySamochod.Add(New Samochod("Fiat", "Panda", "1.6", "Niebieski", False))
        nowySamochod.Add(New Samochod("Fiat", "Panda", "1.6", "Srebny", False))
        nowySamochod.Add(New Samochod("Fiat", "Panda", "1.6", "Zielony", True))
        nowySamochod.Add(New Samochod("Fiat", "Tipo", "1.4", "Czarny", True))
        nowySamochod.Add(New Samochod("Fiat", "Tipo", "1.4", "Bialy", True))
        nowySamochod.Add(New Samochod("Fiat", "Tipo", "1.4", "Srebny", False))
        nowySamochod.Add(New Samochod("Fiat", "Tipo", "1.6", "Czarny", True))
        nowySamochod.Add(New Samochod("Fiat", "Tipo", "1.6", "Czarny", False))
        nowySamochod.Add(New Samochod("Fiat", "Tipo", "1.6", "Srebny", True))

        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa C", "1.8", "Srebny", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa C", "1.8", "Bialy", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa C", "1.8", "Czarny", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa C", "1.8", "Granatowy", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa C", "2.0", "Srebny", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa C", "2.0", "Zloty", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa C", "2.0", "Bialy", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa C", "2.0", "Zielony", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa C", "2.0", "Niebieski", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa E", "1.8", "Srebny", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa E", "1.8", "Bialy", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa E", "1.8", "Czarny", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa E", "1.8", "Granatowy", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa E", "2.0", "Srebny", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa E", "2.0", "Zloty", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa E", "2.0", "Bialy", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa E", "2.0", "Zielony", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa E", "2.0", "Niebieski", True))
        nowySamochod.Add(New Samochod("Mercedes-Benz", "Klasa E", "3.0", "Srebny", True))

        nowySamochod.Add(New Samochod("Mazda", "Mazda 3", "1.6", "Srebny", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 3", "1.6", "Bialy", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 3", "1.6", "Niebieski", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 3", "2.0", "Czerwony", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 3", "2,0", "Zielony", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 3", "2.0", "Srebny", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 6", "1.8", "Srebny", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 6", "1.8", "Czerwony", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 6", "1.8", "Zloty", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 6", "1.8", "Niebieski", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 6", "2.0", "Srebny", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 6", "2.0", "Czerwony", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 6", "2.0", "Czarny", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 6", "2.0", "Bialy", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda 6", "2.0", "Zielony", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda MX-5", "2.0", "Czerwony", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda MX-5", "2.0", "Srebny", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda MX-5", "3.0", "Czarny", True))
        nowySamochod.Add(New Samochod("Mazda", "Mazda MX-5", "3.0", "Zielony", True))

        nowySamochod.Add(New Samochod("Toyota", "Auris", "1.4", "Zielony", True))
        nowySamochod.Add(New Samochod("Toyota", "Auris", "1.4", "Czarny", False))
        nowySamochod.Add(New Samochod("Toyota", "Auris", "1.4", "Niebieski", True))
        nowySamochod.Add(New Samochod("Toyota", "Auris", "1.8", "Zielony", True))
        nowySamochod.Add(New Samochod("Toyota", "Auris", "1.8", "Zielony", False))
        nowySamochod.Add(New Samochod("Toyota", "Aygo", "1.0", "Zielony", False))
        nowySamochod.Add(New Samochod("Toyota", "Aygo", "1.0", "Bialy", False))
        nowySamochod.Add(New Samochod("Toyota", "Aygo", "1.0", "Bialy", True))
        nowySamochod.Add(New Samochod("Toyota", "Aygo", "1.2", "Zielony", False))
        nowySamochod.Add(New Samochod("Toyota", "Aygo", "1.2", "Czarny", False))
        nowySamochod.Add(New Samochod("Toyota", "Aygo", "1.2", "Bialy", False))
        nowySamochod.Add(New Samochod("Toyota", "Aygo", "1.2", "Bialy", True))
        nowySamochod.Add(New Samochod("Toyota", "Yaris", "1.1", "Bialy", True))
        nowySamochod.Add(New Samochod("Toyota", "Yaris", "1.1", "Czarny", True))
        nowySamochod.Add(New Samochod("Toyota", "Yaris", "1.1", "Szary", True))
        nowySamochod.Add(New Samochod("Toyota", "Yaris", "1.1", "Bialy", False))
        nowySamochod.Add(New Samochod("Toyota", "Yaris", "1.4", "Bialy", True))
        nowySamochod.Add(New Samochod("Toyota", "Yaris", "1.4", "Bialy", False))
        nowySamochod.Add(New Samochod("Toyota", "Yaris", "1.4", "Srebny", True))


        carsCollection = nowySamochod
        For Each s As Samochod In carsCollection
            If (Marka.Items.Contains(s.Marka)) Then
            Else
                Me.Marka.Items.Add(s.Marka)
            End If
        Next
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Marka.SelectedIndexChanged

        Me.Model.Items.Clear()
        Me.Model.ResetText()
        Me.Silnik.Items.Clear()
        Me.Silnik.ResetText()
        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()
        Me.Opcje.Items.Clear()

        For Each s As Samochod In carsCollection
            If (Model.Items.Contains(s.Model)) Then
            ElseIf (Marka.SelectedItem.ToString.Equals(Marka.SelectedItem.ToString) And s.Marka.Equals(Marka.SelectedItem.ToString)) Then
                Me.Model.Items.Add(s.Model)
            End If
        Next

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Model.SelectedIndexChanged

        Me.Silnik.Items.Clear()
        Me.Silnik.ResetText()
        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()
        Me.Opcje.Items.Clear()

        For Each s As Samochod In carsCollection
            If (Silnik.Items.Contains(s.Silnik)) Then
            ElseIf (Model.SelectedItem.ToString.Equals(Model.SelectedItem.ToString) And s.Model.Equals(Model.SelectedItem.ToString)) Then
                Me.Silnik.Items.Add(s.Silnik)
            End If
        Next

        If (File.Exists(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\" + Model.SelectedItem.ToString) + ".jpg")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\" + Model.SelectedItem.ToString) + ".jpg")
        Else
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\Default.jpg"))
        End If
    End Sub
    Private Sub Silnik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Silnik.SelectedIndexChanged
        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()
        Me.Opcje.Items.Clear()

        For Each s As Samochod In carsCollection
            If (Kolor.Items.Contains(s.Kolor)) Then
            ElseIf (Silnik.SelectedItem.ToString.Equals(Silnik.SelectedItem.ToString) And s.Silnik.Equals(Silnik.SelectedItem.ToString) And
                Model.SelectedItem.ToString.Equals(Model.SelectedItem.ToString) And s.Model.Equals(Model.SelectedItem.ToString)) Then
                Me.Kolor.Items.Add(s.Kolor)
            End If
        Next
    End Sub

    Private Sub Metalik_CheckedChanged(sender As Object, e As EventArgs) Handles Metalik.CheckedChanged
        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()
        Me.Opcje.Items.Clear()

        If (Metalik.Checked = True) Then
            For Each s As Samochod In carsCollection
                If (Kolor.Items.Contains(s.Kolor)) Then
                ElseIf (Silnik.SelectedItem.ToString.Equals(Silnik.SelectedItem.ToString) And s.Silnik.Equals(Silnik.SelectedItem.ToString) And
                    Model.SelectedItem.ToString.Equals(Model.SelectedItem.ToString) And s.Model.Equals(Model.SelectedItem.ToString) And (s.Kolor.ToString.Equals("Srebny") Or
                    s.Kolor.ToString.Equals("Zloty"))) Then
                    Me.Kolor.Items.Add(s.Kolor)
                End If
            Next
            If (Me.Kolor.Size.Equals(0)) Then
                MessageBox.Show("Brak koloru")
            End If
        Else
            Silnik_SelectedIndexChanged(Silnik.SelectedItem, e)
        End If

    End Sub

    Private Sub Kolor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Kolor.SelectedIndexChanged
        Me.Opcje.Items.Clear()
        Me.Opcje.Items.AddRange(New Object() {"Klimatyzacja", "GPS", "Radio", "Kamera cofania"})
        Me.Opcje.SetItemChecked(0, True)
    End Sub

    Private Sub AddCarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddCarToolStripMenuItem.Click
        Dim myForm As New Form2
        myForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim database As New Form3
        database.Show()
    End Sub
End Class
