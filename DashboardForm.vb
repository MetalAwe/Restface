Public Class DashboardForm
    Private Sub ButtonMasa1_Click(sender As Object, e As EventArgs) Handles ButtonMasa1.Click
        Me.Hide()
        Dim Masa1 As New TableInterface()
        Masa1.Show()
    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Me.Hide()
        Dim LoginForm As New Form1
        LoginForm.Show()
    End Sub

    Private Sub ButtonMasa2_Click(sender As Object, e As EventArgs) Handles ButtonMasa2.Click
        Me.Hide()
        Dim Masa2 As New TableInterface()
        Masa2.Show()
    End Sub
End Class