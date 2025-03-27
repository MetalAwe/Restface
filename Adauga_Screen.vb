Public Class Adauga_Screen
    Private Sub ButtonInapoi_Click(sender As Object, e As EventArgs) Handles ButtonInapoi.Click
        Me.Hide()
        Dim TableInterface As New TableInterface
        TableInterface.Show()
    End Sub
End Class