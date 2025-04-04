<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BonFiscal
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
        Radio5lasuta = New RadioButton()
        Radio10lasuta = New RadioButton()
        Radio15lasuta = New RadioButton()
        LabelBacsis = New Label()
        ListBox1 = New ListBox()
        TextBoxMetodaPlata = New TextBox()
        LabelMetodaPlata = New Label()
        ButtonPlateste = New Button()
        SuspendLayout()
        ' 
        ' Radio5lasuta
        ' 
        Radio5lasuta.AutoSize = True
        Radio5lasuta.Location = New Point(71, 318)
        Radio5lasuta.Name = "Radio5lasuta"
        Radio5lasuta.Size = New Size(62, 29)
        Radio5lasuta.TabIndex = 0
        Radio5lasuta.Text = "5%"
        Radio5lasuta.UseVisualStyleBackColor = True
        ' 
        ' Radio10lasuta
        ' 
        Radio10lasuta.AutoSize = True
        Radio10lasuta.Checked = True
        Radio10lasuta.Location = New Point(71, 353)
        Radio10lasuta.Name = "Radio10lasuta"
        Radio10lasuta.Size = New Size(72, 29)
        Radio10lasuta.TabIndex = 1
        Radio10lasuta.TabStop = True
        Radio10lasuta.Text = "10%"
        Radio10lasuta.UseVisualStyleBackColor = True
        ' 
        ' Radio15lasuta
        ' 
        Radio15lasuta.AutoSize = True
        Radio15lasuta.Location = New Point(71, 388)
        Radio15lasuta.Name = "Radio15lasuta"
        Radio15lasuta.Size = New Size(72, 29)
        Radio15lasuta.TabIndex = 2
        Radio15lasuta.Text = "15%"
        Radio15lasuta.UseVisualStyleBackColor = True
        ' 
        ' LabelBacsis
        ' 
        LabelBacsis.AutoSize = True
        LabelBacsis.Location = New Point(71, 290)
        LabelBacsis.Name = "LabelBacsis"
        LabelBacsis.Size = New Size(59, 25)
        LabelBacsis.TabIndex = 3
        LabelBacsis.Text = "Bacsis"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(306, 53)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(433, 354)
        ListBox1.TabIndex = 4
        ' 
        ' TextBoxMetodaPlata
        ' 
        TextBoxMetodaPlata.Enabled = False
        TextBoxMetodaPlata.Location = New Point(71, 128)
        TextBoxMetodaPlata.Name = "TextBoxMetodaPlata"
        TextBoxMetodaPlata.Size = New Size(129, 31)
        TextBoxMetodaPlata.TabIndex = 5
        TextBoxMetodaPlata.Text = "card"
        ' 
        ' LabelMetodaPlata
        ' 
        LabelMetodaPlata.AutoSize = True
        LabelMetodaPlata.Location = New Point(71, 100)
        LabelMetodaPlata.Name = "LabelMetodaPlata"
        LabelMetodaPlata.Size = New Size(117, 25)
        LabelMetodaPlata.TabIndex = 6
        LabelMetodaPlata.Text = "Metoda Plata"
        ' 
        ' ButtonPlateste
        ' 
        ButtonPlateste.Location = New Point(169, 353)
        ButtonPlateste.Name = "ButtonPlateste"
        ButtonPlateste.Size = New Size(112, 34)
        ButtonPlateste.TabIndex = 7
        ButtonPlateste.Text = "Plateste"
        ButtonPlateste.UseVisualStyleBackColor = True
        ' 
        ' BonFiscal
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonPlateste)
        Controls.Add(LabelMetodaPlata)
        Controls.Add(TextBoxMetodaPlata)
        Controls.Add(ListBox1)
        Controls.Add(LabelBacsis)
        Controls.Add(Radio15lasuta)
        Controls.Add(Radio10lasuta)
        Controls.Add(Radio5lasuta)
        Name = "BonFiscal"
        ShowIcon = False
        Text = "Bon Fiscal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Radio5lasuta As RadioButton
    Friend WithEvents Radio10lasuta As RadioButton
    Friend WithEvents Radio15lasuta As RadioButton
    Friend WithEvents LabelBacsis As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBoxMetodaPlata As TextBox
    Friend WithEvents LabelMetodaPlata As Label
    Friend WithEvents ButtonPlateste As Button
End Class
