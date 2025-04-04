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
        RadioButton5 = New RadioButton()
        RadioButton10 = New RadioButton()
        RadioButton15 = New RadioButton()
        LabelBacsis = New Label()
        SuspendLayout()
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Location = New Point(29, 183)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(41, 19)
        RadioButton5.TabIndex = 0
        RadioButton5.TabStop = True
        RadioButton5.Text = "5%"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton10
        ' 
        RadioButton10.AutoSize = True
        RadioButton10.Location = New Point(29, 208)
        RadioButton10.Name = "RadioButton10"
        RadioButton10.Size = New Size(47, 19)
        RadioButton10.TabIndex = 1
        RadioButton10.TabStop = True
        RadioButton10.Text = "10%"
        RadioButton10.UseVisualStyleBackColor = True
        ' 
        ' RadioButton15
        ' 
        RadioButton15.AutoSize = True
        RadioButton15.Location = New Point(29, 233)
        RadioButton15.Name = "RadioButton15"
        RadioButton15.Size = New Size(47, 19)
        RadioButton15.TabIndex = 2
        RadioButton15.TabStop = True
        RadioButton15.Text = "15%"
        RadioButton15.UseVisualStyleBackColor = True
        ' 
        ' LabelBacsis
        ' 
        LabelBacsis.AutoSize = True
        LabelBacsis.Location = New Point(29, 165)
        LabelBacsis.Name = "LabelBacsis"
        LabelBacsis.Size = New Size(39, 15)
        LabelBacsis.TabIndex = 3
        LabelBacsis.Text = "Bacsis"
        ' 
        ' BonFiscal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(560, 270)
        Controls.Add(LabelBacsis)
        Controls.Add(RadioButton15)
        Controls.Add(RadioButton10)
        Controls.Add(RadioButton5)
        Margin = New Padding(2)
        Name = "BonFiscal"
        ShowIcon = False
        Text = "Bon Fiscal"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents RadioButton15 As RadioButton
    Friend WithEvents LabelBacsis As Label
End Class
