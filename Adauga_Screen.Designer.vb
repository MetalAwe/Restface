<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adauga_Screen
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
        TextBox1 = New TextBox()
        RadioBautura = New RadioButton()
        RadioMancare = New RadioButton()
        LabelTipAliment = New Label()
        LabelNumeAliment = New Label()
        ButtonInapoi = New Button()
        ButtonAccepta = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(52, 140)
        TextBox1.Margin = New Padding(2, 2, 2, 2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(106, 23)
        TextBox1.TabIndex = 0
        ' 
        ' RadioBautura
        ' 
        RadioBautura.AutoSize = True
        RadioBautura.Location = New Point(52, 89)
        RadioBautura.Margin = New Padding(2, 2, 2, 2)
        RadioBautura.Name = "RadioBautura"
        RadioBautura.Size = New Size(66, 19)
        RadioBautura.TabIndex = 1
        RadioBautura.Text = "Bautura"
        RadioBautura.UseVisualStyleBackColor = True
        ' 
        ' RadioMancare
        ' 
        RadioMancare.AutoSize = True
        RadioMancare.Checked = True
        RadioMancare.Location = New Point(52, 68)
        RadioMancare.Margin = New Padding(2, 2, 2, 2)
        RadioMancare.Name = "RadioMancare"
        RadioMancare.Size = New Size(71, 19)
        RadioMancare.TabIndex = 2
        RadioMancare.TabStop = True
        RadioMancare.Text = "Mancare"
        RadioMancare.UseVisualStyleBackColor = True
        ' 
        ' LabelTipAliment
        ' 
        LabelTipAliment.AutoSize = True
        LabelTipAliment.Location = New Point(50, 38)
        LabelTipAliment.Margin = New Padding(2, 0, 2, 0)
        LabelTipAliment.Name = "LabelTipAliment"
        LabelTipAliment.Size = New Size(196, 15)
        LabelTipAliment.TabIndex = 3
        LabelTipAliment.Text = "Ce tip de aliment doriti sa adaugati?"
        ' 
        ' LabelNumeAliment
        ' 
        LabelNumeAliment.AutoSize = True
        LabelNumeAliment.Location = New Point(51, 115)
        LabelNumeAliment.Margin = New Padding(2, 0, 2, 0)
        LabelNumeAliment.Name = "LabelNumeAliment"
        LabelNumeAliment.Size = New Size(154, 15)
        LabelNumeAliment.TabIndex = 4
        LabelNumeAliment.Text = "Cum se numeste alimentul?"
        ' 
        ' ButtonInapoi
        ' 
        ButtonInapoi.Location = New Point(8, 7)
        ButtonInapoi.Margin = New Padding(2, 2, 2, 2)
        ButtonInapoi.Name = "ButtonInapoi"
        ButtonInapoi.Size = New Size(78, 20)
        ButtonInapoi.TabIndex = 5
        ButtonInapoi.Text = "<< Inapoi"
        ButtonInapoi.UseVisualStyleBackColor = True
        ' 
        ' ButtonAccepta
        ' 
        ButtonAccepta.Location = New Point(228, 155)
        ButtonAccepta.Margin = New Padding(2, 2, 2, 2)
        ButtonAccepta.Name = "ButtonAccepta"
        ButtonAccepta.Size = New Size(78, 20)
        ButtonAccepta.TabIndex = 6
        ButtonAccepta.Text = "Accepta"
        ButtonAccepta.UseVisualStyleBackColor = True
        ' 
        ' Adauga_Screen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(323, 190)
        Controls.Add(ButtonAccepta)
        Controls.Add(ButtonInapoi)
        Controls.Add(LabelNumeAliment)
        Controls.Add(LabelTipAliment)
        Controls.Add(RadioMancare)
        Controls.Add(RadioBautura)
        Controls.Add(TextBox1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Adauga_Screen"
        ShowIcon = False
        Text = "Adauga aliment"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents RadioBautura As RadioButton
    Friend WithEvents RadioMancare As RadioButton
    Friend WithEvents LabelTipAliment As Label
    Friend WithEvents LabelNumeAliment As Label
    Friend WithEvents ButtonInapoi As Button
    Friend WithEvents ButtonAccepta As Button
End Class
