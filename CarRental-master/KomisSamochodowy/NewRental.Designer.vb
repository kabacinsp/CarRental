<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewRental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewRental))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nazwa = New System.Windows.Forms.Label()
        Me.Baza = New System.Windows.Forms.TextBox()
        Me.Powrot = New System.Windows.Forms.Button()
        Me.Stworz = New System.Windows.Forms.Button()
        Me.NazwaBazy = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(61, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stwórz nową wypożyczalnię"
        '
        'Nazwa
        '
        Me.Nazwa.AutoSize = True
        Me.Nazwa.BackColor = System.Drawing.Color.Transparent
        Me.Nazwa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Nazwa.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Nazwa.Location = New System.Drawing.Point(119, 112)
        Me.Nazwa.Name = "Nazwa"
        Me.Nazwa.Size = New System.Drawing.Size(165, 24)
        Me.Nazwa.TabIndex = 1
        Me.Nazwa.Text = "Wprowadź nazwę:"
        Me.Nazwa.UseMnemonic = False
        '
        'Baza
        '
        Me.Baza.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Baza.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Baza.Location = New System.Drawing.Point(108, 152)
        Me.Baza.Name = "Baza"
        Me.Baza.Size = New System.Drawing.Size(194, 29)
        Me.Baza.TabIndex = 2
        '
        'Powrot
        '
        Me.Powrot.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Powrot.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Powrot.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Powrot.Location = New System.Drawing.Point(40, 215)
        Me.Powrot.Name = "Powrot"
        Me.Powrot.Size = New System.Drawing.Size(128, 37)
        Me.Powrot.TabIndex = 3
        Me.Powrot.Text = "Powrót"
        Me.Powrot.UseVisualStyleBackColor = False
        '
        'Stworz
        '
        Me.Stworz.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Stworz.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Stworz.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Stworz.Location = New System.Drawing.Point(252, 215)
        Me.Stworz.Name = "Stworz"
        Me.Stworz.Size = New System.Drawing.Size(128, 37)
        Me.Stworz.TabIndex = 4
        Me.Stworz.Text = "Stwórz"
        Me.Stworz.UseVisualStyleBackColor = False
        '
        'NazwaBazy
        '
        Me.NazwaBazy.BackColor = System.Drawing.Color.WhiteSmoke
        Me.NazwaBazy.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.NazwaBazy.Location = New System.Drawing.Point(108, 152)
        Me.NazwaBazy.Name = "NazwaBazy"
        Me.NazwaBazy.Size = New System.Drawing.Size(194, 29)
        Me.NazwaBazy.TabIndex = 2
        '
        'NewRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(418, 264)
        Me.Controls.Add(Me.Stworz)
        Me.Controls.Add(Me.Powrot)
        Me.Controls.Add(Me.Baza)
        Me.Controls.Add(Me.Nazwa)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewRental"
        Me.Text = "NewRental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Nazwa As Label
    Friend WithEvents Baza As TextBox
    Friend WithEvents Powrot As Button
    Friend WithEvents Stworz As Button
    Friend WithEvents NazwaBazy As TextBox
End Class
