Imports System.IO
Imports System.Runtime.CompilerServices

Public Class Adauga_Screen
    Private Sub ButtonInapoi_Click(sender As Object, e As EventArgs) Handles ButtonInapoi.Click
        Me.Hide()
        Dim TableInterface As New TableInterface
        TableInterface.Show()
    End Sub
    Private Sub ButtonAccepta_Click(sender As Object, e As EventArgs) Handles ButtonAccepta.Click
        Dim line As String
        Dim filepath As String
        If (RadioBautura.Checked) Then
            filepath = "bautura.txt"
        Else
            filepath = "mancare.txt"
        End If
        Dim Writer As StreamWriter = File.AppendText(filepath)
        Writer.WriteLine(TextBox1.Text)
        Writer.Close()
        Me.Hide()
        Dim TableInterface As New TableInterface
        TableInterface.Show()
    End Sub
End Class