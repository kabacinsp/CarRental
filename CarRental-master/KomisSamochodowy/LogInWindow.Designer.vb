<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LogInWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LogInWindow))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoginField = New System.Windows.Forms.TextBox()
        Me.PasswordField = New System.Windows.Forms.TextBox()
        Me.SigninButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label1.Location = New System.Drawing.Point(126, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(126, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Hasło"
        '
        'LoginField
        '
        Me.LoginField.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginField.Location = New System.Drawing.Point(74, 58)
        Me.LoginField.Margin = New System.Windows.Forms.Padding(2)
        Me.LoginField.Name = "LoginField"
        Me.LoginField.Size = New System.Drawing.Size(162, 28)
        Me.LoginField.TabIndex = 2
        '
        'PasswordField
        '
        Me.PasswordField.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordField.Location = New System.Drawing.Point(74, 145)
        Me.PasswordField.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordField.Name = "PasswordField"
        Me.PasswordField.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordField.Size = New System.Drawing.Size(162, 28)
        Me.PasswordField.TabIndex = 3
        '
        'SigninButton
        '
        Me.SigninButton.BackColor = System.Drawing.Color.WhiteSmoke
        Me.SigninButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SigninButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SigninButton.Location = New System.Drawing.Point(92, 208)
        Me.SigninButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SigninButton.Name = "SigninButton"
        Me.SigninButton.Size = New System.Drawing.Size(128, 36)
        Me.SigninButton.TabIndex = 4
        Me.SigninButton.Text = "Sign in"
        Me.SigninButton.UseVisualStyleBackColor = False
        '
        'LogInWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(320, 269)
        Me.Controls.Add(Me.SigninButton)
        Me.Controls.Add(Me.PasswordField)
        Me.Controls.Add(Me.LoginField)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "LogInWindow"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginField As TextBox
    Friend WithEvents PasswordField As TextBox
    Friend WithEvents SigninButton As Button
End Class
