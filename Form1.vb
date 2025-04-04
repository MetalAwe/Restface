Public Class Form1
    ' Declaram doua variabile, care impreuna vor alcatui utilizatorii si parolele acestora
    Dim usernames() As String = {"admin", "user1", "guest"}
    Dim passwords() As String = {"1234", "password", "guestpass"}

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        ' citim inputul de la tastatura prin formular
        Dim username As String = TextBoxUsername.Text
        Dim password As String = TextBoxPassword.Text
        ' cream un boolean care by default este fals, acesta
        ' verificand daca textul din input alcatuieste un login adevarat
        Dim isValidUser As Boolean = False
        ' folosim o bucla for pentru a verifica loginurile
        For i As Integer = 0 To usernames.Length - 1
            If usernames(i) = username AndAlso passwords(i) = password Then
                isValidUser = True
                Exit For
            End If
        Next

        If isValidUser Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            Dim Dashboard As New DashboardForm()
            Dashboard.Show()
        Else
            LabelMessage.Text = "Invalid Username or Password!"
            LabelMessage.ForeColor = Color.Red
            LabelMessage.Visible = True
        End If
    End Sub

    Private Sub LabelLogo_Click(sender As Object, e As EventArgs) Handles LabelLogo.Click

    End Sub
End Class
