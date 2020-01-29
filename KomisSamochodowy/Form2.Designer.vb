<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Podaj marke"
        '
        'GetMarka
        '
        Me.GetMarka.Location = New System.Drawing.Point(102, 77)
        Me.GetMarka.Name = "GetMarka"
        Me.GetMarka.Size = New System.Drawing.Size(165, 22)
        Me.GetMarka.TabIndex = 1
        '
        'GetModel
        '
        Me.GetModel.Location = New System.Drawing.Point(102, 141)
        Me.GetModel.Name = "GetModel"
        Me.GetModel.Size = New System.Drawing.Size(165, 22)
        Me.GetModel.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Podaj model"
        '
        'GetSilnik
        '
        Me.GetSilnik.Location = New System.Drawing.Point(102, 208)
        Me.GetSilnik.Name = "GetSilnik"
        Me.GetSilnik.Size = New System.Drawing.Size(165, 22)
        Me.GetSilnik.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Podaj pojemnosc silnika"
        '
        'GetKolor
        '
        Me.GetKolor.Location = New System.Drawing.Point(102, 272)
        Me.GetKolor.Name = "GetKolor"
        Me.GetKolor.Size = New System.Drawing.Size(165, 22)
        Me.GetKolor.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Podaj kolor samochodu"
        '
        'Dodaj
        '
        Me.Dodaj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Dodaj.Location = New System.Drawing.Point(370, 149)
        Me.Dodaj.Name = "Dodaj"
        Me.Dodaj.Size = New System.Drawing.Size(189, 81)
        Me.Dodaj.TabIndex = 8
        Me.Dodaj.Text = "Dodaj samochod"
        Me.Dodaj.UseVisualStyleBackColor = False
        '
        'GetKlima
        '
        Me.GetKlima.AutoSize = True
        Me.GetKlima.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GetKlima.Location = New System.Drawing.Point(102, 323)
        Me.GetKlima.Name = "GetKlima"
        Me.GetKlima.Size = New System.Drawing.Size(108, 21)
        Me.GetKlima.TabIndex = 9
        Me.GetKlima.Text = "Klimatyzacja"
        Me.GetKlima.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(639, 395)
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
        Me.Name = "Form2"
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
End Class
