<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddCarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowCarsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Wypozyczalnia = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(43, 150)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wybierz markę"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(549, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(541, 63)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Znajdź swój samochód!"
        '
        'Metalik
        '
        Me.Metalik.AutoSize = True
        Me.Metalik.BackColor = System.Drawing.Color.Transparent
        Me.Metalik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Metalik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Metalik.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Metalik.Location = New System.Drawing.Point(218, 521)
        Me.Metalik.Margin = New System.Windows.Forms.Padding(4)
        Me.Metalik.Name = "Metalik"
        Me.Metalik.Size = New System.Drawing.Size(78, 24)
        Me.Metalik.TabIndex = 4
        Me.Metalik.Text = "Metalik"
        Me.Metalik.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(43, 242)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Wybierz model"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label4.Location = New System.Drawing.Point(43, 337)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Wybierz silnik"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label5.Location = New System.Drawing.Point(43, 435)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Wybierz kolor"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label6.Location = New System.Drawing.Point(43, 542)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Opcje dodatkowe"
        '
        'Opcje
        '
        Me.Opcje.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Opcje.CheckOnClick = True
        Me.Opcje.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Opcje.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Opcje.FormattingEnabled = True
        Me.Opcje.Items.AddRange(New Object() {"Klimatyzacja", "Radio", "GPS", "Kamera cofania"})
        Me.Opcje.Location = New System.Drawing.Point(46, 576)
        Me.Opcje.Margin = New System.Windows.Forms.Padding(4)
        Me.Opcje.Name = "Opcje"
        Me.Opcje.Size = New System.Drawing.Size(266, 109)
        Me.Opcje.TabIndex = 9
        '
        'Marka
        '
        Me.Marka.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Marka.BackColor = System.Drawing.SystemColors.Window
        Me.Marka.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Marka.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Marka.FormattingEnabled = True
        Me.Marka.Location = New System.Drawing.Point(46, 179)
        Me.Marka.Margin = New System.Windows.Forms.Padding(4)
        Me.Marka.Name = "Marka"
        Me.Marka.Size = New System.Drawing.Size(268, 28)
        Me.Marka.TabIndex = 19
        '
        'Model
        '
        Me.Model.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Model.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Model.FormattingEnabled = True
        Me.Model.Location = New System.Drawing.Point(46, 271)
        Me.Model.Margin = New System.Windows.Forms.Padding(4)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(268, 28)
        Me.Model.TabIndex = 20
        '
        'Silnik
        '
        Me.Silnik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Silnik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Silnik.FormattingEnabled = True
        Me.Silnik.Location = New System.Drawing.Point(46, 366)
        Me.Silnik.Margin = New System.Windows.Forms.Padding(4)
        Me.Silnik.Name = "Silnik"
        Me.Silnik.Size = New System.Drawing.Size(268, 28)
        Me.Silnik.TabIndex = 21
        '
        'Kolor
        '
        Me.Kolor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Kolor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Kolor.FormattingEnabled = True
        Me.Kolor.Location = New System.Drawing.Point(48, 464)
        Me.Kolor.Margin = New System.Windows.Forms.Padding(4)
        Me.Kolor.Name = "Kolor"
        Me.Kolor.Size = New System.Drawing.Size(266, 28)
        Me.Kolor.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(639, 682)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(2)
        Me.Button1.Size = New System.Drawing.Size(238, 44)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Oceń"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1186, 27)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCarToolStripMenuItem, Me.AddNewToolStripMenuItem, Me.ShowCarsToolStripMenuItem, Me.LogInToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(52, 23)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'AddCarToolStripMenuItem
        '
        Me.AddCarToolStripMenuItem.Enabled = False
        Me.AddCarToolStripMenuItem.Name = "AddCarToolStripMenuItem"
        Me.AddCarToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.AddCarToolStripMenuItem.Text = "Add car"
        Me.AddCarToolStripMenuItem.Visible = False
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Enabled = False
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.AddNewToolStripMenuItem.Text = "Add new  rental"
        Me.AddNewToolStripMenuItem.Visible = False
        '
        'ShowCarsToolStripMenuItem
        '
        Me.ShowCarsToolStripMenuItem.Enabled = False
        Me.ShowCarsToolStripMenuItem.Name = "ShowCarsToolStripMenuItem"
        Me.ShowCarsToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.ShowCarsToolStripMenuItem.Text = "Show Cars"
        Me.ShowCarsToolStripMenuItem.Visible = False
        '
        'LogInToolStripMenuItem
        '
        Me.LogInToolStripMenuItem.Name = "LogInToolStripMenuItem"
        Me.LogInToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.LogInToolStripMenuItem.Text = "Log in"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(349, 682)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(243, 44)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Opinie"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(358, 122)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(828, 532)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label7.Location = New System.Drawing.Point(41, 58)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Wybierz wypożyczalnie"
        '
        'Wypozyczalnia
        '
        Me.Wypozyczalnia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Wypozyczalnia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wypozyczalnia.FormattingEnabled = True
        Me.Wypozyczalnia.Location = New System.Drawing.Point(46, 87)
        Me.Wypozyczalnia.Margin = New System.Windows.Forms.Padding(4)
        Me.Wypozyczalnia.Name = "Wypozyczalnia"
        Me.Wypozyczalnia.Size = New System.Drawing.Size(266, 28)
        Me.Wypozyczalnia.TabIndex = 27
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(925, 682)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(2)
        Me.Button3.Size = New System.Drawing.Size(238, 44)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Wypożycz"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1186, 744)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Wypozyczalnia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Wypożyczalnia samochodów"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
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
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Wypozyczalnia As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents ShowCarsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As ToolStripMenuItem
End Class
