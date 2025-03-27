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
        TextBox1.Location = New Point(74, 234)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 0
        ' 
        ' RadioBautura
        ' 
        RadioBautura.AutoSize = True
        RadioBautura.Location = New Point(74, 148)
        RadioBautura.Name = "RadioBautura"
        RadioBautura.Size = New Size(97, 29)
        RadioBautura.TabIndex = 1
        RadioBautura.Text = "Bautura"
        RadioBautura.UseVisualStyleBackColor = True
        ' 
        ' RadioMancare
        ' 
        RadioMancare.AutoSize = True
        RadioMancare.Checked = True
        RadioMancare.Location = New Point(74, 113)
        RadioMancare.Name = "RadioMancare"
        RadioMancare.Size = New Size(104, 29)
        RadioMancare.TabIndex = 2
        RadioMancare.TabStop = True
        RadioMancare.Text = "Mancare"
        RadioMancare.UseVisualStyleBackColor = True
        ' 
        ' LabelTipAliment
        ' 
        LabelTipAliment.AutoSize = True
        LabelTipAliment.Location = New Point(72, 64)
        LabelTipAliment.Name = "LabelTipAliment"
        LabelTipAliment.Size = New Size(297, 25)
        LabelTipAliment.TabIndex = 3
        LabelTipAliment.Text = "Ce tip de aliment doriti sa adaugati?"
        ' 
        ' LabelNumeAliment
        ' 
        LabelNumeAliment.AutoSize = True
        LabelNumeAliment.Location = New Point(73, 191)
        LabelNumeAliment.Name = "LabelNumeAliment"
        LabelNumeAliment.Size = New Size(229, 25)
        LabelNumeAliment.TabIndex = 4
        LabelNumeAliment.Text = "Cum se numeste alimentul?"
        ' 
        ' ButtonInapoi
        ' 
        ButtonInapoi.Location = New Point(12, 12)
        ButtonInapoi.Name = "ButtonInapoi"
        ButtonInapoi.Size = New Size(112, 34)
        ButtonInapoi.TabIndex = 5
        ButtonInapoi.Text = "<< Inapoi"
        ButtonInapoi.UseVisualStyleBackColor = True
        ' 
        ' ButtonAccepta
        ' 
        ButtonAccepta.Location = New Point(325, 259)
        ButtonAccepta.Name = "ButtonAccepta"
        ButtonAccepta.Size = New Size(112, 34)
        ButtonAccepta.TabIndex = 6
        ButtonAccepta.Text = "Accepta"
        ButtonAccepta.UseVisualStyleBackColor = True
        ' 
        ' Adauga_Screen
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(461, 316)
        Controls.Add(ButtonAccepta)
        Controls.Add(ButtonInapoi)
        Controls.Add(LabelNumeAliment)
        Controls.Add(LabelTipAliment)
        Controls.Add(RadioMancare)
        Controls.Add(RadioBautura)
        Controls.Add(TextBox1)
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
