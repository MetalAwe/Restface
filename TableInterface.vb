Imports System.IO
Imports System.Text

Public Class TableInterface
    Private Sub ButtonInapoi_Click(sender As Object, e As EventArgs) Handles ButtonInapoi.Click
        Me.Hide()
        Dim Dashboard As New DashboardForm
        Dashboard.Show()
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Text <> "Mancare" AndAlso TreeView1.SelectedNode.Text <> "Bauturi" Then
            ListBoxCheck.Items.Add(TreeView1.SelectedNode.Text)
        End If
    End Sub

    Private Sub ButtonPlata_Click(sender As Object, e As EventArgs) Handles ButtonPlata.Click
        My.Computer.FileSystem.WriteAllText("Bon_Fiscal.txt", "---Bon Fiscal---" + Environment.NewLine + "'Artists Pub' SRL" + Environment.NewLine + "Municipiul Bucuresti" + Environment.NewLine + "str. Lt. Gh. Saidac Nr.7" + Environment.NewLine + "***" + Environment.NewLine, False)
        'TODO
        Try
            For i = 0 To ListBoxCheck.Items.Count - 1
                Dim NewData As String = ListBoxCheck.Items(i).ToString
                If NewData = "Snitel de pui" Then
                    My.Computer.FileSystem.WriteAllText("Bon_Fiscal.txt", NewData + " " + "32 lei" + Environment.NewLine, True)
                ElseIf NewData = "Cordon Bleu" Then
                    My.Computer.FileSystem.WriteAllText("Bon_Fiscal.txt", NewData + " " + "40 lei" + Environment.NewLine, True)
                ElseIf NewData = "Supa de perisoare" Then
                    My.Computer.FileSystem.WriteAllText("Bon_Fiscal.txt", NewData + " " + "20 lei" + Environment.NewLine, True)
                End If
            Next
        Catch ex As Exception
            'sunt sigur ca ceva interesant vine aici
        End Try
        Dim RadioButtonsData As Boolean = RadioButtonCard.Checked
        If RadioButtonsData = False Then
            My.Computer.FileSystem.WriteAllText("Bon_Fiscal.txt", "Plata CASH" + Environment.NewLine, True)
        Else
            My.Computer.FileSystem.WriteAllText("Bon_Fiscal.txt", "Plata CARD" + Environment.NewLine, True)
        End If

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
End Class