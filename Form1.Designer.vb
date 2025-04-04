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
        LabelUsername.Location = New Point(19, 21)
        LabelUsername.Margin = New Padding(2, 0, 2, 0)
        LabelUsername.Name = "LabelUsername"
        LabelUsername.Size = New Size(60, 15)
        LabelUsername.TabIndex = 0
        LabelUsername.Text = "Username"
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Location = New Point(21, 44)
        TextBoxUsername.Margin = New Padding(2)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(106, 23)
        TextBoxUsername.TabIndex = 1
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.Location = New Point(19, 75)
        LabelPassword.Margin = New Padding(2, 0, 2, 0)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(57, 15)
        LabelPassword.TabIndex = 2
        LabelPassword.Text = "Password"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(19, 99)
        TextBoxPassword.Margin = New Padding(2)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PasswordChar = "*"c
        TextBoxPassword.Size = New Size(106, 23)
        TextBoxPassword.TabIndex = 3
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.Location = New Point(19, 133)
        ButtonLogin.Margin = New Padding(2)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(78, 20)
        ButtonLogin.TabIndex = 4
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = True
        ' 
        ' LabelMessage
        ' 
        LabelMessage.AutoSize = True
        LabelMessage.Location = New Point(19, 167)
        LabelMessage.Margin = New Padding(2, 0, 2, 0)
        LabelMessage.Name = "LabelMessage"
        LabelMessage.Size = New Size(41, 15)
        LabelMessage.TabIndex = 5
        LabelMessage.Text = "Label1"
        LabelMessage.Visible = False
        ' 
        ' LabelLogo
        ' 
        LabelLogo.AutoSize = True
        LabelLogo.Location = New Point(285, 195)
        LabelLogo.Margin = New Padding(2, 0, 2, 0)
        LabelLogo.Name = "LabelLogo"
        LabelLogo.Size = New Size(234, 15)
        LabelLogo.TabIndex = 7
        LabelLogo.Text = "RestFace - Restaurant Interface System v0.1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(248, 11)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(301, 182)
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 227)
        Controls.Add(PictureBox1)
        Controls.Add(LabelLogo)
        Controls.Add(LabelMessage)
        Controls.Add(ButtonLogin)
        Controls.Add(TextBoxPassword)
        Controls.Add(LabelPassword)
        Controls.Add(TextBoxUsername)
        Controls.Add(LabelUsername)
        Margin = New Padding(2)
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
