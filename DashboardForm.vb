Public Class DashboardForm
    Private Sub ButtonMasa1_Click(sender As Object, e As EventArgs) Handles ButtonMasa1.Click
        Me.Hide()
        Dim Masa1 As New TableInterface()
        Masa1.LabelNrMasa.Text = "Masa 1"
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
        Masa2.LabelNrMasa.Text = "Masa 2"
        Masa2.Show()
    End Sub

    Private Sub ButtonMasa3_Click(sender As Object, e As EventArgs) Handles ButtonMasa3.Click
        Me.Hide()
        Dim Masa3 As New TableInterface()
        Masa3.LabelNrMasa.Text = "Masa 3"
        Masa3.Show()
    End Sub

    Private Sub ButtonMasa4_Click(sender As Object, e As EventArgs) Handles ButtonMasa4.Click
        Me.Hide()
        Dim Masa4 As New TableInterface()
        Masa4.LabelNrMasa.Text = "Masa 4"
        Masa4.Show()
    End Sub

    Private Sub ButtonMasa5_Click(sender As Object, e As EventArgs) Handles ButtonMasa5.Click
        Me.Hide()
        Dim Masa5 As New TableInterface()
        Masa5.LabelNrMasa.Text = "Masa 5"
        Masa5.Show()
    End Sub

    Private Sub ButtonMasa6_Click(sender As Object, e As EventArgs) Handles ButtonMasa6.Click
        Me.Hide()
        Dim Masa6 As New TableInterface()
        Masa6.LabelNrMasa.Text = "Masa 6"
        Masa6.Show()
    End Sub
End Class