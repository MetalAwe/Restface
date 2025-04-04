Imports System.Runtime.CompilerServices

Public Class BonFiscal
    Private Sub TextBoxMetodaPlata_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMetodaPlata.TextChanged

    End Sub

    Private Sub BonFiscal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RadioButtonsData As Boolean = TableInterface.RadioButtonCard.Checked
        If RadioButtonsData = False Then
            TextBoxMetodaPlata.Text = "Cash"
        Else
            TextBoxMetodaPlata.Text = "Card"
        End If
    End Sub
End Class