<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        LabelUsername = New Label()
        TextBoxUsername = New TextBox()
        LabelPassword = New Label()
        TextBoxPassword = New TextBox()
        ButtonLogin = New Button()
        LabelMessage = New Label()
        LabelLogo = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LabelUsername
        ' 
        LabelUsername.AutoSize = True
        LabelUsername.Location = New Point(138, 108)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(91, 25)
        LabelUsername.TabIndex = 0
        LabelUsername.Text = "Username"
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Location = New Point(141, 146)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(150, 31)
        TextBoxUsername.TabIndex = 1
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.Location = New Point(138, 199)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(87, 25)
        LabelPassword.TabIndex = 2
        LabelPassword.Text = "Password"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(138, 238)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PasswordChar = "*"c
        TextBoxPassword.Size = New Size(150, 31)
        TextBoxPassword.TabIndex = 3
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.Location = New Point(138, 295)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(112, 34)
        ButtonLogin.TabIndex = 4
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = True
        ' 
        ' LabelMessage
        ' 
        LabelMessage.AutoSize = True
        LabelMessage.Location = New Point(487, 176)
        LabelMessage.Name = "LabelMessage"
        LabelMessage.Size = New Size(63, 25)
        LabelMessage.TabIndex = 5
        LabelMessage.Text = "Label1"
        LabelMessage.Visible = False
        ' 
        ' LabelLogo
        ' 
        LabelLogo.AutoSize = True
        LabelLogo.Location = New Point(267, 90)
        LabelLogo.Name = "LabelLogo"
        LabelLogo.Size = New Size(256, 25)
        LabelLogo.TabIndex = 7
        LabelLogo.Text = "Artists' Pub -- Interface System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(313, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(150, 75)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(LabelLogo)
        Controls.Add(LabelMessage)
        Controls.Add(ButtonLogin)
        Controls.Add(TextBoxPassword)
        Controls.Add(LabelPassword)
        Controls.Add(TextBoxUsername)
        Controls.Add(LabelUsername)
        Name = "Form1"
        ShowIcon = False
        Text = "Log In"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LabelUsername As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents LabelMessage As Label
    Friend WithEvents LabelLogo As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
