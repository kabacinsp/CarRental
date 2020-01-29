Public Class Form2
    Dim mainForm As New Form1
    Private Sub Dodaj_Click(sender As Object, e As EventArgs) Handles Dodaj.Click
        Form1.nowySamochod.Add(New Form1.Samochod(GetMarka.Text, GetModel.Text, GetSilnik.Text, GetKolor.Text, GetKlima.CheckState))

        Form1.carsCollection = Form1.nowySamochod
        For Each s As Form1.Samochod In Form1.carsCollection
            If (Form1.Marka.Items.Contains(s.Marka)) Then
            Else
                Form1.Marka.Items.Add(s.Marka)
            End If
        Next

        Me.Close()
    End Sub
End Class