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
        resources.ApplyResources(LabelUsername, "LabelUsername")
        LabelUsername.Name = "LabelUsername"
        ' 
        ' TextBoxUsername
        ' 
        resources.ApplyResources(TextBoxUsername, "TextBoxUsername")
        TextBoxUsername.Name = "TextBoxUsername"
        ' 
        ' LabelPassword
        ' 
        resources.ApplyResources(LabelPassword, "LabelPassword")
        LabelPassword.Name = "LabelPassword"
        ' 
        ' TextBoxPassword
        ' 
        resources.ApplyResources(TextBoxPassword, "TextBoxPassword")
        TextBoxPassword.Name = "TextBoxPassword"
        ' 
        ' ButtonLogin
        ' 
        resources.ApplyResources(ButtonLogin, "ButtonLogin")
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.UseVisualStyleBackColor = True
        ' 
        ' LabelMessage
        ' 
        resources.ApplyResources(LabelMessage, "LabelMessage")
        LabelMessage.Name = "LabelMessage"
        ' 
        ' LabelLogo
        ' 
        resources.ApplyResources(LabelLogo, "LabelLogo")
        LabelLogo.Name = "LabelLogo"
        ' 
        ' PictureBox1
        ' 
        resources.ApplyResources(PictureBox1, "PictureBox1")
        PictureBox1.Name = "PictureBox1"
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PictureBox1)
        Controls.Add(LabelLogo)
        Controls.Add(LabelMessage)
        Controls.Add(ButtonLogin)
        Controls.Add(TextBoxPassword)
        Controls.Add(LabelPassword)
        Controls.Add(TextBoxUsername)
        Controls.Add(LabelUsername)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        ShowIcon = False
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
