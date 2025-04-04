Imports System.IO
Imports System.Text

Public Class TableInterface
    Private Sub ButtonInapoi_Click(sender As Object, e As EventArgs) Handles ButtonInapoi.Click
        Me.Hide()
        Dim Dashboard As New DashboardForm
        Dashboard.Show()
    End Sub
    Private Sub ButtonPlata_Click(sender As Object, e As EventArgs) Handles ButtonPlata.Click
        'My.Computer.FileSystem.WriteAllText("Bon_Fiscal.txt", "---Bon Fiscal---" + Environment.NewLine + "'Artists Pub' SRL" + Environment.NewLine + "Municipiul Bucuresti" + Environment.NewLine + "str. Lt. Gh. Saidac Nr.7" + Environment.NewLine + "***" + Environment.NewLine, False)
        'Dim RadioButtonsData As Boolean = RadioButtonCard.Checked
        'If RadioButtonsData = False Then
        'My.Computer.FileSystem.WriteAllText("Bon_Fiscal.txt", "Plata CASH" + Environment.NewLine, True)
        'Else
        'My.Computer.FileSystem.WriteAllText("Bon_Fiscal.txt", "Plata CARD" + Environment.NewLine, True)
        'End If
        Me.Hide()
        Dim Bon_Fiscal As New BonFiscal
        Bon_Fiscal.Show()
    End Sub

    Private Sub TableInterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim line As String
        Dim MancareReader As New StreamReader("mancare.txt")
        line = MancareReader.ReadLine
        Dim MyNode() As TreeNode
        MyNode = TreeView1.Nodes.Find("NodeMancare", True)
        Dim sonNode As TreeNode
        Do While line <> Nothing
            sonNode = MyNode(0).Nodes.Add(line)
            line = MancareReader.ReadLine
        Loop
        MancareReader.Close()
        Dim BauturaReader As New StreamReader("bautura.txt")
        line = BauturaReader.ReadLine
        MyNode = TreeView1.Nodes.Find("NodeBautura", True)
        Do While line <> Nothing
            sonNode = MyNode(0).Nodes.Add(line)
            line = BauturaReader.ReadLine
        Loop
        BauturaReader.Close()
        Try
            Dim FileReader As New StreamReader("Bon_Fiscal.txt", Encoding.Default)
            Dim Info As String = Nothing
            Dim SplittedInfo() As String
            While (FileReader.Peek() <> -1)
                Info = FileReader.ReadLine()
                SplittedInfo = Split(Info)
            End While
            FileReader.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonAdaugaM_Click(sender As Object, e As EventArgs) Handles ButtonAdaugaM.Click
        Me.Hide()
        Dim AdaugaAliment As New Adauga_Screen
        Adauga_Screen.Show()
    End Sub

    Private Sub ButtonSterge_Click(sender As Object, e As EventArgs) Handles ButtonSterge.Click
        LabelEroare.Hide()
        If TreeView1.SelectedNode.Text <> "Mancare" AndAlso TreeView1.SelectedNode.Text <> "Bauturi" Then
            ' Read all lines from the file into a List
            Dim lines As List(Of String) = System.IO.File.ReadAllLines("mancare.txt").ToList()
            Dim selectedLine As String = TreeView1.SelectedNode.Text
            ' Remove the line from the list
            lines.RemoveAll(Function(line) line = selectedLine)
            ' I used a lambda function here ^
            System.IO.File.WriteAllLines("mancare.txt", lines)
            TreeView1.SelectedNode.Remove()
            Me.Refresh()
            MessageBox.Show("Aliment sters cu succes.")
        Else
            LabelEroare.Show()
            LabelEroare.ForeColor = Color.Red
            LabelEroare.Text = "Nu poti sterge categoriile!"
        End If
    End Sub


    Private Sub TreeView1_DoubleClick(sender As Object, e As EventArgs) Handles TreeView1.DoubleClick
        If TreeView1.SelectedNode.Text <> "Mancare" AndAlso TreeView1.SelectedNode.Text <> "Bauturi" Then
            ListBoxCheck.Items.Add(TreeView1.SelectedNode.Text)
        End If
    End Sub
End Class