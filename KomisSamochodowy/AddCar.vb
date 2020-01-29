Public Class AddCar
    Dim connection As DBConnection = New DBConnection()

    Private Sub AddCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item = Me.BazyDanych
        connection.getDataBaseName(item)
    End Sub

    Private Sub Dodaj_Click(sender As Object, e As EventArgs) Handles Dodaj.Click
        Dim connStr As String = "server=localhost;user=root;database=" + BazyDanych.Text.ToString + ";port=3306;password=root;"
        Dim stm As String = "INSERT INTO cars (marka, model, silnik, kolor, metalik, klima, radio, gps, kamera) VALUES  (""" + GetMarka.Text.ToString + """, """ + GetModel.Text.ToString + """, """ + GetSilnik.Text.ToString + """, """ + GetKolor.Text.ToString + """, """ + GetMetalik.CheckState.ToString + """, """ + GetKlima.CheckState.ToString + """, """ + GetRadio.CheckState.ToString + """, """ + GetGPS.CheckState.ToString + """, """ + GetKamera.CheckState.ToString + """);"
        Dim stm1 As String = stm.Replace("Checked", "1")
        Dim stm2 As String = stm1.Replace("Unchecked", "0")
        connection.connectionToDatabase(stm2, connStr, 1)

        Me.Close()
    End Sub

End Class