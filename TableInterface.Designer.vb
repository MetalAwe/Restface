Imports System.Drawing.Printing

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TableInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim TreeNode1 As TreeNode = New TreeNode("Mancare")
        Dim TreeNode2 As TreeNode = New TreeNode("Bauturi")
        ButtonInapoi = New Button()
        RadioButtonCash = New RadioButton()
        RadioButtonCard = New RadioButton()
        ButtonPlata = New Button()
        ListBoxCheck = New ListBox()
        TreeView1 = New TreeView()
        ButtonAdaugaM = New Button()
        LabelAlimentNou = New Label()
        ButtonSterge = New Button()
        LabelSterge = New Label()
        LabelEroare = New Label()
        SuspendLayout()
        ' 
        ' ButtonInapoi
        ' 
        ButtonInapoi.Location = New Point(35, 12)
        ButtonInapoi.Name = "ButtonInapoi"
        ButtonInapoi.Size = New Size(112, 34)
        ButtonInapoi.TabIndex = 20
        ButtonInapoi.Text = "<< Inapoi"
        ButtonInapoi.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonCash
        ' 
        RadioButtonCash.AutoSize = True
        RadioButtonCash.Checked = True
        RadioButtonCash.Location = New Point(35, 320)
        RadioButtonCash.Name = "RadioButtonCash"
        RadioButtonCash.Size = New Size(75, 29)
        RadioButtonCash.TabIndex = 21
        RadioButtonCash.TabStop = True
        RadioButtonCash.Text = "Cash"
        RadioButtonCash.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonCard
        ' 
        RadioButtonCard.AutoSize = True
        RadioButtonCard.Location = New Point(35, 355)
        RadioButtonCard.Name = "RadioButtonCard"
        RadioButtonCard.Size = New Size(74, 29)
        RadioButtonCard.TabIndex = 22
        RadioButtonCard.Text = "Card"
        RadioButtonCard.UseVisualStyleBackColor = True
        ' 
        ' ButtonPlata
        ' 
        ButtonPlata.Location = New Point(35, 390)
        ButtonPlata.Name = "ButtonPlata"
        ButtonPlata.Size = New Size(112, 34)
        ButtonPlata.TabIndex = 23
        ButtonPlata.Text = "Plateste"
        ButtonPlata.UseVisualStyleBackColor = True
        ' 
        ' ListBoxCheck
        ' 
        ListBoxCheck.FormattingEnabled = True
        ListBoxCheck.ItemHeight = 25
        ListBoxCheck.Location = New Point(35, 67)
        ListBoxCheck.Name = "ListBoxCheck"
        ListBoxCheck.Size = New Size(180, 229)
        ListBoxCheck.TabIndex = 24
        ' 
        ' TreeView1
        ' 
        TreeView1.Location = New Point(259, 68)
        TreeView1.Name = "TreeView1"
        TreeNode1.Name = "NodeMancare"
        TreeNode1.Text = "Mancare"
        TreeNode2.Name = "NodeBautura"
        TreeNode2.Text = "Bauturi"
        TreeView1.Nodes.AddRange(New TreeNode() {TreeNode1, TreeNode2})
        TreeView1.Size = New Size(296, 228)
        TreeView1.TabIndex = 27
        ' 
        ' ButtonAdaugaM
        ' 
        ButtonAdaugaM.Location = New Point(259, 362)
        ButtonAdaugaM.Name = "ButtonAdaugaM"
        ButtonAdaugaM.Size = New Size(112, 34)
        ButtonAdaugaM.TabIndex = 28
        ButtonAdaugaM.Text = "Adauga"
        ButtonAdaugaM.UseVisualStyleBackColor = True
        ' 
        ' LabelAlimentNou
        ' 
        LabelAlimentNou.AutoSize = True
        LabelAlimentNou.Location = New Point(259, 324)
        LabelAlimentNou.Name = "LabelAlimentNou"
        LabelAlimentNou.Size = New Size(117, 25)
        LabelAlimentNou.TabIndex = 30
        LabelAlimentNou.Text = "Aliment nou?"
        ' 
        ' ButtonSterge
        ' 
        ButtonSterge.Location = New Point(425, 362)
        ButtonSterge.Name = "ButtonSterge"
        ButtonSterge.Size = New Size(112, 34)
        ButtonSterge.TabIndex = 31
        ButtonSterge.Text = "Sterge"
        ButtonSterge.UseVisualStyleBackColor = True
        ' 
        ' LabelSterge
        ' 
        LabelSterge.AutoSize = True
        LabelSterge.Location = New Point(425, 324)
        LabelSterge.Name = "LabelSterge"
        LabelSterge.Size = New Size(130, 25)
        LabelSterge.TabIndex = 32
        LabelSterge.Text = "Aliment gresit?"
        ' 
        ' LabelEroare
        ' 
        LabelEroare.AutoSize = True
        LabelEroare.Location = New Point(259, 416)
        LabelEroare.Name = "LabelEroare"
        LabelEroare.Size = New Size(103, 25)
        LabelEroare.TabIndex = 33
        LabelEroare.Text = "LabelEroare"
        LabelEroare.Visible = False
        ' 
        ' TableInterface
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 450)
        Controls.Add(LabelEroare)
        Controls.Add(LabelSterge)
        Controls.Add(ButtonSterge)
        Controls.Add(LabelAlimentNou)
        Controls.Add(ButtonAdaugaM)
        Controls.Add(TreeView1)
        Controls.Add(ListBoxCheck)
        Controls.Add(ButtonPlata)
        Controls.Add(RadioButtonCard)
        Controls.Add(RadioButtonCash)
        Controls.Add(ButtonInapoi)
        Name = "TableInterface"
        ShowIcon = False
        Text = "Table Interface"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonInapoi As Button
    Friend WithEvents RadioButtonCash As RadioButton
    Friend WithEvents RadioButtonCard As RadioButton
    Friend WithEvents ButtonPlata As Button
    Friend WithEvents ListBoxCheck As ListBox
    Friend WithEvents LabelBauturi As Label
    Friend WithEvents LabelMancare As Label
    Friend WithEvents TreeView1 As TreeView
    Public Property PrintDoc As PrintDocument
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents ButtonAdaugaM As Button
    Friend WithEvents ButtonAdaugaB As Button
    Friend WithEvents LabelAlimentNou As Label
    Friend WithEvents ButtonSterge As Button
    Friend WithEvents LabelSterge As Label
    Friend WithEvents LabelEroare As Label
End Class
