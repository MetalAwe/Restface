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
        components = New ComponentModel.Container()
        Dim TreeNode1 As TreeNode = New TreeNode("Mancare")
        Dim TreeNode2 As TreeNode = New TreeNode("Bauturi")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TableInterface))
        ButtonInapoi = New Button()
        RadioButtonCash = New RadioButton()
        RadioButtonCard = New RadioButton()
        ButtonPlata = New Button()
        ListBoxCheck = New ListBox()
        TreeView1 = New TreeView()
        ImageList1 = New ImageList(components)
        ButtonAdaugaM = New Button()
        LabelAlimentNou = New Label()
        ButtonSterge = New Button()
        Label1 = New Label()
        LabelEroare = New Label()
        SuspendLayout()
        ' 
        ' ButtonInapoi
        ' 
        ButtonInapoi.Location = New Point(24, 7)
        ButtonInapoi.Margin = New Padding(2)
        ButtonInapoi.Name = "ButtonInapoi"
        ButtonInapoi.Size = New Size(78, 20)
        ButtonInapoi.TabIndex = 20
        ButtonInapoi.Text = "<< Inapoi"
        ButtonInapoi.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonCash
        ' 
        RadioButtonCash.AutoSize = True
        RadioButtonCash.Checked = True
        RadioButtonCash.Location = New Point(24, 192)
        RadioButtonCash.Margin = New Padding(2)
        RadioButtonCash.Name = "RadioButtonCash"
        RadioButtonCash.Size = New Size(51, 19)
        RadioButtonCash.TabIndex = 21
        RadioButtonCash.TabStop = True
        RadioButtonCash.Text = "Cash"
        RadioButtonCash.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonCard
        ' 
        RadioButtonCard.AutoSize = True
        RadioButtonCard.Location = New Point(24, 213)
        RadioButtonCard.Margin = New Padding(2)
        RadioButtonCard.Name = "RadioButtonCard"
        RadioButtonCard.Size = New Size(50, 19)
        RadioButtonCard.TabIndex = 22
        RadioButtonCard.Text = "Card"
        RadioButtonCard.UseVisualStyleBackColor = True
        ' 
        ' ButtonPlata
        ' 
        ButtonPlata.Location = New Point(24, 234)
        ButtonPlata.Margin = New Padding(2)
        ButtonPlata.Name = "ButtonPlata"
        ButtonPlata.Size = New Size(78, 25)
        ButtonPlata.TabIndex = 23
        ButtonPlata.Text = "Plateste"
        ButtonPlata.UseVisualStyleBackColor = True
        ' 
        ' ListBoxCheck
        ' 
        ListBoxCheck.FormattingEnabled = True
        ListBoxCheck.ItemHeight = 15
        ListBoxCheck.Location = New Point(24, 40)
        ListBoxCheck.Margin = New Padding(2)
        ListBoxCheck.Name = "ListBoxCheck"
        ListBoxCheck.Size = New Size(127, 139)
        ListBoxCheck.TabIndex = 24
        ' 
        ' TreeView1
        ' 
        TreeView1.ImageIndex = 0
        TreeView1.ImageList = ImageList1
        TreeView1.Location = New Point(181, 41)
        TreeView1.Margin = New Padding(2)
        TreeView1.Name = "TreeView1"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = "NodeMancare"
        TreeNode1.SelectedImageKey = "food_icon.png"
        TreeNode1.Text = "Mancare"
        TreeNode2.Name = "NodeBautura"
        TreeNode2.Text = "Bauturi"
        TreeView1.Nodes.AddRange(New TreeNode() {TreeNode1, TreeNode2})
        TreeView1.SelectedImageIndex = 0
        TreeView1.Size = New Size(208, 138)
        TreeView1.TabIndex = 27
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "drinks_icon.png")
        ImageList1.Images.SetKeyName(1, "food_icon.png")
        ' 
        ' ButtonAdaugaM
        ' 
        ButtonAdaugaM.Location = New Point(181, 217)
        ButtonAdaugaM.Margin = New Padding(2)
        ButtonAdaugaM.Name = "ButtonAdaugaM"
        ButtonAdaugaM.Size = New Size(78, 23)
        ButtonAdaugaM.TabIndex = 28
        ButtonAdaugaM.Text = "Adauga"
        ButtonAdaugaM.UseVisualStyleBackColor = True
        ' 
        ' LabelAlimentNou
        ' 
        LabelAlimentNou.AutoSize = True
        LabelAlimentNou.Location = New Point(181, 194)
        LabelAlimentNou.Margin = New Padding(2, 0, 2, 0)
        LabelAlimentNou.Name = "LabelAlimentNou"
        LabelAlimentNou.Size = New Size(78, 15)
        LabelAlimentNou.TabIndex = 30
        LabelAlimentNou.Text = "Aliment nou?"
        ' 
        ' ButtonSterge
        ' 
        ButtonSterge.Location = New Point(293, 217)
        ButtonSterge.Name = "ButtonSterge"
        ButtonSterge.Size = New Size(75, 23)
        ButtonSterge.TabIndex = 31
        ButtonSterge.Text = "Sterge"
        ButtonSterge.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(293, 194)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 15)
        Label1.TabIndex = 32
        Label1.Text = "Aliment gresit?"
        ' 
        ' LabelEroare
        ' 
        LabelEroare.AutoSize = True
        LabelEroare.Location = New Point(183, 248)
        LabelEroare.Name = "LabelEroare"
        LabelEroare.Size = New Size(41, 15)
        LabelEroare.TabIndex = 33
        LabelEroare.Text = "Label2"
        LabelEroare.Visible = False
        ' 
        ' TableInterface
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(420, 270)
        Controls.Add(LabelEroare)
        Controls.Add(Label1)
        Controls.Add(ButtonSterge)
        Controls.Add(LabelAlimentNou)
        Controls.Add(ButtonAdaugaM)
        Controls.Add(TreeView1)
        Controls.Add(ListBoxCheck)
        Controls.Add(ButtonPlata)
        Controls.Add(RadioButtonCard)
        Controls.Add(RadioButtonCash)
        Controls.Add(ButtonInapoi)
        Margin = New Padding(2)
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
    Public WithEvents ImageList1 As ImageList
    Friend WithEvents ButtonSterge As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelEroare As Label
End Class
