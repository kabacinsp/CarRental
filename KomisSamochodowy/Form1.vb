Public Class Okno

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
    Dim nowySamochod As New List(Of Samochod)
    Dim carsCollection As ICollection

    Private Sub Okno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nowySamochod.Add(New Samochod("Audi", "A3", "1.6", "Biały", True))
        nowySamochod.Add(New Samochod("Audi", "A3", "1.6", "Czarny", True))
        nowySamochod.Add(New Samochod("Audi", "A3", "1.9TDI", "Czarny", False))
        nowySamochod.Add(New Samochod("Audi", "A3", "1.9TDI", "Niebieski", False))
        nowySamochod.Add(New Samochod("Audi", "A3", "1.9TDI", "Biały", True))
        nowySamochod.Add(New Samochod("Audi", "A4", "1.9TDI", "Czarny", True))
        nowySamochod.Add(New Samochod("Audi", "A4", "1.9TDI", "Srebny", True))
        nowySamochod.Add(New Samochod("Audi", "A4", "2.0", "Czarny", True))
        nowySamochod.Add(New Samochod("Audi", "A4", "2.0", "Srebny", False))
        nowySamochod.Add(New Samochod("Audi", "A4", "2.2", "Czarny", False))
        nowySamochod.Add(New Samochod("Audi", "A6", "2.0", "Czarny", False))
        nowySamochod.Add(New Samochod("Audi", "A6", "2.0", "Srebny", False))
        nowySamochod.Add(New Samochod("Audi", "A6", "2.2", "Zielony", False))
        nowySamochod.Add(New Samochod("Audi", "A6", "2.2", "Zielony", True))
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
        nowySamochod.Add(New Samochod("BMW", "X3", "2.0", "Szary", True))
        nowySamochod.Add(New Samochod("BMW", "X3", "2.0", "Szary", True))
        nowySamochod.Add(New Samochod("BMW", "X3", "1.8", "Biały", True))
        nowySamochod.Add(New Samochod("BMW", "X3", "2.0", "Srebny", True))

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
            ElseIf (Marka.SelectedItem.ToString.Equals("Audi") And s.Marka.Equals("Audi")) Then
                Me.Model.Items.Add(s.Model)
            End If
        Next

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Model.SelectedIndexChanged

        If (Marka.SelectedItem.ToString.Equals("Audi")) Then
            Me.Model.Items.AddRange(New Object() {"A3", "A4", "A6"})
        ElseIf (Marka.SelectedItem.ToString.Equals("BMW")) Then
            Me.Model.Items.AddRange(New Object() {"Series 3", "Series 5", "X3"})
        ElseIf (Marka.SelectedItem.ToString.Equals("Citroen")) Then
            Me.Model.Items.AddRange(New Object() {"Berlingo", "C3", "Jumper"})
        ElseIf (Marka.SelectedItem.ToString.Equals("Fiat")) Then
            Me.Model.Items.AddRange(New Object() {"500", "Panda", "Tipo"})
        ElseIf (Marka.SelectedItem.ToString.Equals("Mercedes-Benz")) Then
            Me.Model.Items.AddRange(New Object() {"Klasa C", "Klasa E"})
        ElseIf (Marka.SelectedItem.ToString.Equals("Mazda")) Then
            Me.Model.Items.AddRange(New Object() {"Mazda 3", "Mazda 6", "Mazda MX-5"})
        ElseIf (Marka.SelectedItem.ToString.Equals("Toyota")) Then
            Me.Model.Items.AddRange(New Object() {"Auris", "Aygo", "Yaris"})
        End If

        Me.Silnik.Items.Clear()
        Me.Silnik.ResetText()
        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()
        Me.Opcje.Items.Clear()

        If (Model.SelectedItem.ToString.Equals("A3") Or Model.SelectedItem.ToString.Equals("Series 3") Or Model.SelectedItem.ToString.Equals("Tipo") Or Model.SelectedItem.ToString.Equals("Klasa C") Or Model.SelectedItem.ToString.Equals("Mazda 3") Or Model.SelectedItem.ToString.Equals("Auris")) Then
            Me.Silnik.Items.AddRange(New Object() {"1.6", "1.9TDI", "2.0"})
        ElseIf (Model.SelectedItem.ToString.Equals("A6") Or Model.SelectedItem.ToString.Equals("Series 5") Or Model.SelectedItem.ToString.Equals("Jumper") Or Model.SelectedItem.ToString.Equals("Klasa E") Or Model.SelectedItem.ToString.Equals("Mazda 6") Or Model.SelectedItem.ToString.Equals("X3")) Then
            Me.Silnik.Items.AddRange(New Object() {"1.8", "2.0", "2.2"})
        ElseIf (Model.SelectedItem.ToString.Equals("A4") Or Model.SelectedItem.ToString.Equals("Berlingo") Or Model.SelectedItem.ToString.Equals("C3") Or Model.SelectedItem.ToString.Equals("Mazda MX-5")) Then
            Me.Silnik.Items.AddRange(New Object() {"1.6", "1.9TDI", "2.0"})
        ElseIf (Model.SelectedItem.ToString.Equals("Aygo") Or Model.SelectedItem.ToString.Equals("500") Or Model.SelectedItem.ToString.Equals("Yaris")) Then
            Me.Silnik.Items.AddRange(New Object() {"1.0", "1.1"})
        Else
            Me.Silnik.Items.AddRange(New Object() {"1.5", "1.7"})
        End If

        If (Model.SelectedItem.ToString.Equals("A3")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\audi3.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("A4")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\audi4.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("A6")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\audi6.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Series 3")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\bmw3.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Series 5")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\bmw5.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("X3")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\bmwx5.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Berlingo")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\Berlingo.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("C3")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\C3.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Jumper")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\Jumper.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Klasa C")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\klasaC.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Klasa E")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\klasaE.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Mazda 3")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\mazda3.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Mazda 6")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\mazda6.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Mazda MX-5")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\mx5.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Auris")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\corolla.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Aygo")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\aygo.jpg"))
        ElseIf (Model.SelectedItem.ToString.Equals("Yaris")) Then
            Me.PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\yaris.jpg"))
        End If
    End Sub
    Private Sub Silnik_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Silnik.SelectedIndexChanged
        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()
        Me.Opcje.Items.Clear()

        If (Model.SelectedItem.ToString.Equals("A3") And Silnik.SelectedItem.ToString.Equals("1.6") And Metalik.Checked = False) Then
            Me.Kolor.Items.AddRange(New Object() {"Zielony", "Niebieski", "Czarny"})
        ElseIf (Silnik.SelectedItem.ToString.Equals("2.0") And Metalik.Checked = False) Then
            Me.Kolor.Items.AddRange(New Object() {"Biały", "Czarny", "Granatowy"})
        ElseIf (Silnik.SelectedItem.ToString.Equals("1.9TDI") And Metalik.Checked = False) Then
            Me.Kolor.Items.AddRange(New Object() {"Niebieski", "Czerwony", "Zółty"})
        Else
            Me.Kolor.Items.AddRange(New Object() {"Biały"})
        End If
    End Sub

    Private Sub Metalik_CheckedChanged(sender As Object, e As EventArgs) Handles Metalik.CheckedChanged
        Me.Kolor.Items.Clear()
        Me.Kolor.ResetText()
        Me.Opcje.Items.Clear()

        If (Metalik.Checked = True) Then
            If (Model.SelectedItem.ToString.Equals("A3") And Silnik.SelectedItem.ToString.Equals("1.6") And Metalik.Checked = True) Then
                Me.Kolor.Items.AddRange(New Object() {"Srebny"})
            ElseIf (Silnik.SelectedItem.ToString.Equals("1.9TDI") And Silnik.SelectedItem.ToString.Equals("2.0") And Metalik.Checked = True) Then
                Me.Kolor.Items.AddRange(New Object() {"Srebny", "Złoty"})
            Else
                MessageBox.Show("Brak koloru")
            End If
        Else
            Silnik_SelectedIndexChanged(Silnik.SelectedItem, e)
        End If

    End Sub

    Private Sub Kolor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Kolor.SelectedIndexChanged
        Me.Opcje.Items.Clear()
        Me.Opcje.Items.AddRange(New Object() {"GPS", "Radio", "Kamera cofania"})
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
