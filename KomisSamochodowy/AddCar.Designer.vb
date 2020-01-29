<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddCar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GetMarka = New System.Windows.Forms.TextBox()
        Me.GetModel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GetSilnik = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GetKolor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dodaj = New System.Windows.Forms.Button()
        Me.GetKlima = New System.Windows.Forms.CheckBox()
        Me.GetRadio = New System.Windows.Forms.CheckBox()
        Me.GetGPS = New System.Windows.Forms.CheckBox()
        Me.GetKamera = New System.Windows.Forms.CheckBox()
        Me.GetMetalik = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BazyDanych = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(50, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Podaj marke"
        '
        'GetMarka
        '
        Me.GetMarka.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GetMarka.Location = New System.Drawing.Point(53, 50)
        Me.GetMarka.Margin = New System.Windows.Forms.Padding(2)
        Me.GetMarka.Name = "GetMarka"
        Me.GetMarka.Size = New System.Drawing.Size(204, 29)
        Me.GetMarka.TabIndex = 1
        '
        'GetModel
        '
        Me.GetModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GetModel.Location = New System.Drawing.Point(53, 124)
        Me.GetModel.Margin = New System.Windows.Forms.Padding(2)
        Me.GetModel.Name = "GetModel"
        Me.GetModel.Size = New System.Drawing.Size(204, 29)
        Me.GetModel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(51, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Podaj model"
        '
        'GetSilnik
        '
        Me.GetSilnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GetSilnik.Location = New System.Drawing.Point(55, 197)
        Me.GetSilnik.Margin = New System.Windows.Forms.Padding(2)
        Me.GetSilnik.Name = "GetSilnik"
        Me.GetSilnik.Size = New System.Drawing.Size(203, 29)
        Me.GetSilnik.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(50, 171)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(213, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Podaj pojemność silnika"
        '
        'GetKolor
        '
        Me.GetKolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GetKolor.Location = New System.Drawing.Point(56, 274)
        Me.GetKolor.Margin = New System.Windows.Forms.Padding(2)
        Me.GetKolor.Name = "GetKolor"
        Me.GetKolor.Size = New System.Drawing.Size(201, 29)
        Me.GetKolor.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(52, 248)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Podaj kolor samochodu"
        '
        'Dodaj
        '
        Me.Dodaj.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Dodaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dodaj.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Dodaj.Location = New System.Drawing.Point(352, 288)
        Me.Dodaj.Margin = New System.Windows.Forms.Padding(2)
        Me.Dodaj.Name = "Dodaj"
        Me.Dodaj.Padding = New System.Windows.Forms.Padding(8)
        Me.Dodaj.Size = New System.Drawing.Size(167, 45)
        Me.Dodaj.TabIndex = 8
        Me.Dodaj.Text = "Dodaj samochód"
        Me.Dodaj.UseVisualStyleBackColor = False
        '
        'GetKlima
        '
        Me.GetKlima.AutoSize = True
        Me.GetKlima.BackColor = System.Drawing.Color.Transparent
        Me.GetKlima.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GetKlima.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GetKlima.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GetKlima.Location = New System.Drawing.Point(360, 119)
        Me.GetKlima.Margin = New System.Windows.Forms.Padding(2)
        Me.GetKlima.Name = "GetKlima"
        Me.GetKlima.Size = New System.Drawing.Size(131, 28)
        Me.GetKlima.TabIndex = 9
        Me.GetKlima.Text = "Klimatyzacja"
        Me.GetKlima.UseVisualStyleBackColor = False
        '
        'GetRadio
        '
        Me.GetRadio.AutoSize = True
        Me.GetRadio.BackColor = System.Drawing.Color.Transparent
        Me.GetRadio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GetRadio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GetRadio.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GetRadio.Location = New System.Drawing.Point(360, 163)
        Me.GetRadio.Margin = New System.Windows.Forms.Padding(2)
        Me.GetRadio.Name = "GetRadio"
        Me.GetRadio.Size = New System.Drawing.Size(78, 28)
        Me.GetRadio.TabIndex = 10
        Me.GetRadio.Text = "Radio"
        Me.GetRadio.UseVisualStyleBackColor = False
        '
        'GetGPS
        '
        Me.GetGPS.AutoSize = True
        Me.GetGPS.BackColor = System.Drawing.Color.Transparent
        Me.GetGPS.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GetGPS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GetGPS.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GetGPS.Location = New System.Drawing.Point(360, 203)
        Me.GetGPS.Margin = New System.Windows.Forms.Padding(2)
        Me.GetGPS.Name = "GetGPS"
        Me.GetGPS.Size = New System.Drawing.Size(67, 28)
        Me.GetGPS.TabIndex = 11
        Me.GetGPS.Text = "GPS"
        Me.GetGPS.UseVisualStyleBackColor = False
        '
        'GetKamera
        '
        Me.GetKamera.AutoSize = True
        Me.GetKamera.BackColor = System.Drawing.Color.Transparent
        Me.GetKamera.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GetKamera.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GetKamera.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GetKamera.Location = New System.Drawing.Point(360, 245)
        Me.GetKamera.Margin = New System.Windows.Forms.Padding(2)
        Me.GetKamera.Name = "GetKamera"
        Me.GetKamera.Size = New System.Drawing.Size(159, 28)
        Me.GetKamera.TabIndex = 12
        Me.GetKamera.Text = "Kamera cofania"
        Me.GetKamera.UseVisualStyleBackColor = False
        '
        'GetMetalik
        '
        Me.GetMetalik.AutoSize = True
        Me.GetMetalik.BackColor = System.Drawing.Color.Transparent
        Me.GetMetalik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GetMetalik.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GetMetalik.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.GetMetalik.Location = New System.Drawing.Point(172, 306)
        Me.GetMetalik.Margin = New System.Windows.Forms.Padding(2)
        Me.GetMetalik.Name = "GetMetalik"
        Me.GetMetalik.Size = New System.Drawing.Size(87, 28)
        Me.GetMetalik.TabIndex = 13
        Me.GetMetalik.Text = "Metalik"
        Me.GetMetalik.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(340, 24)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(191, 24)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Wybierz bazę danych"
        '
        'BazyDanych
        '
        Me.BazyDanych.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BazyDanych.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BazyDanych.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.BazyDanych.FormattingEnabled = True
        Me.BazyDanych.Location = New System.Drawing.Point(344, 47)
        Me.BazyDanych.Margin = New System.Windows.Forms.Padding(2)
        Me.BazyDanych.Name = "BazyDanych"
        Me.BazyDanych.Size = New System.Drawing.Size(183, 32)
        Me.BazyDanych.TabIndex = 15
        '
        'AddCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(551, 364)
        Me.Controls.Add(Me.BazyDanych)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GetMetalik)
        Me.Controls.Add(Me.GetKamera)
        Me.Controls.Add(Me.GetGPS)
        Me.Controls.Add(Me.GetRadio)
        Me.Controls.Add(Me.GetKlima)
        Me.Controls.Add(Me.Dodaj)
        Me.Controls.Add(Me.GetKolor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GetSilnik)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GetModel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GetMarka)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddCar"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GetMarka As TextBox
    Friend WithEvents GetModel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GetSilnik As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GetKolor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Dodaj As Button
    Friend WithEvents GetKlima As CheckBox
    Friend WithEvents GetRadio As CheckBox
    Friend WithEvents GetGPS As CheckBox
    Friend WithEvents GetKamera As CheckBox
    Friend WithEvents GetMetalik As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BazyDanych As ComboBox
End Class
