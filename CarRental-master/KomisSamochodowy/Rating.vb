Public Class Rating
    Dim item = 0
    Dim connection As DBConnection = New DBConnection()

    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Rating))
    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
    End Sub

    Private Sub PictureBox_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))

        clickedStar(sender, e)
    End Sub
    Private Sub PictureBox1_MouseClick(sender As Object, e As EventArgs) Handles PictureBox1.MouseClick
        item = 1
        PictureBox5_MouseLeave(sender, e)
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))

        clickedStar(sender, e)
    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As EventArgs) Handles PictureBox2.MouseClick
        item = 2
        PictureBox5_MouseLeave(sender, e)
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox3.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))
        PictureBox3.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))

        clickedStar(sender, e)
    End Sub

    Private Sub PictureBox3_MouseClick(sender As Object, e As EventArgs) Handles PictureBox3.MouseClick
        item = 3
        PictureBox5_MouseLeave(sender, e)
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox3.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))

    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox4.MouseEnter
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox3.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox4.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))
        PictureBox3.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))
        PictureBox4.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))

        clickedStar(sender, e)
    End Sub

    Private Sub PictureBox4_MouseClick(sender As Object, e As EventArgs) Handles PictureBox4.MouseClick
        item = 4
        PictureBox5_MouseLeave(sender, e)
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox3.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox4.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))

    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox3.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox4.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox5.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))
        PictureBox3.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))
        PictureBox4.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))
        PictureBox5.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\starempty.png"))

        clickedStar(sender, e)
    End Sub

    Private Sub PictureBox5_MouseClick(sender As Object, e As EventArgs) Handles PictureBox5.MouseClick
        item = 5
        PictureBox1.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox2.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox3.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox4.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))
        PictureBox5.Image = Image.FromFile(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resource\stars.png"))

    End Sub

    Private Sub clickedStar(sender As Object, e As EventArgs)
        Me.Label1.Text = "Ocena wypożyczalni: " + item.ToString + "/5"
        If (item.Equals(1)) Then
            PictureBox1_MouseEnter(sender, e)
        End If
        If (item.Equals(2)) Then
            PictureBox2_MouseEnter(sender, e)
        End If
        If (item.Equals(3)) Then
            PictureBox3_MouseEnter(sender, e)
        End If
        If (item.Equals(4)) Then
            PictureBox4_MouseEnter(sender, e)
        End If
        If (item.Equals(5)) Then
            PictureBox5_MouseEnter(sender, e)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connStr As String = "server=localhost;user=root;database=" + ComboBox1.Text.ToString + ";port=3306;password=root;"
        Dim stm As String = "INSERT INTO rating (ocena, komentarz) VALUES  (""" + item.ToString + """, """ + RichTextBox1.Text.ToString + """);"
        connection.connectionToDatabase(stm, connStr, 1)

        Me.Close()
    End Sub
End Class