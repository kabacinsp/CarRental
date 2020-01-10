<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Okno
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Metalik = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Opcje = New System.Windows.Forms.CheckedListBox()
        Me.Marka = New System.Windows.Forms.ComboBox()
        Me.Model = New System.Windows.Forms.ComboBox()
        Me.Silnik = New System.Windows.Forms.ComboBox()
        Me.Kolor = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wybierz markę"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.25!)
        Me.Label2.Location = New System.Drawing.Point(132, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Wypożyczalnia samochodów"
        '
        'Metalik
        '
        Me.Metalik.AutoSize = True
        Me.Metalik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Metalik.Location = New System.Drawing.Point(96, 270)
        Me.Metalik.Name = "Metalik"
        Me.Metalik.Size = New System.Drawing.Size(60, 17)
        Me.Metalik.TabIndex = 4
        Me.Metalik.Text = "Metalik"
        Me.Metalik.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Wybierz model"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Wybierz silnik"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Wybierz kolor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 302)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Opcje dodatkowe"
        '
        'Opcje
        '
        Me.Opcje.CheckOnClick = True
        Me.Opcje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Opcje.FormattingEnabled = True
        Me.Opcje.Location = New System.Drawing.Point(36, 331)
        Me.Opcje.Name = "Opcje"
        Me.Opcje.Size = New System.Drawing.Size(120, 94)
        Me.Opcje.TabIndex = 14
        '
        'Marka
        '
        Me.Marka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Marka.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Marka.FormattingEnabled = True
        Me.Marka.Location = New System.Drawing.Point(35, 85)
        Me.Marka.Name = "Marka"
        Me.Marka.Size = New System.Drawing.Size(121, 21)
        Me.Marka.TabIndex = 19
        '
        'Model
        '
        Me.Model.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Model.FormattingEnabled = True
        Me.Model.Location = New System.Drawing.Point(35, 136)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(121, 21)
        Me.Model.TabIndex = 20
        '
        'Silnik
        '
        Me.Silnik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Silnik.FormattingEnabled = True
        Me.Silnik.Location = New System.Drawing.Point(35, 192)
        Me.Silnik.Name = "Silnik"
        Me.Silnik.Size = New System.Drawing.Size(121, 21)
        Me.Silnik.TabIndex = 21
        '
        'Kolor
        '
        Me.Kolor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Kolor.FormattingEnabled = True
        Me.Kolor.Location = New System.Drawing.Point(35, 243)
        Me.Kolor.Name = "Kolor"
        Me.Kolor.Size = New System.Drawing.Size(121, 21)
        Me.Kolor.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(235, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(229, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Wypożycz"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(178, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(363, 300)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Okno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 441)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Kolor)
        Me.Controls.Add(Me.Silnik)
        Me.Controls.Add(Me.Model)
        Me.Controls.Add(Me.Marka)
        Me.Controls.Add(Me.Opcje)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Metalik)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Okno"
        Me.Text = "Wypożyczalnia samochodów"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Metalik As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Opcje As CheckedListBox
    Friend WithEvents Marka As ComboBox
    Friend WithEvents Model As ComboBox
    Friend WithEvents Silnik As ComboBox
    Friend WithEvents Kolor As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
