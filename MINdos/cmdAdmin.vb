Public Class cmdAdmin
    Private Sub cmdAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim commando = InputBox("Inserisci un commando (per aiuto: help)")
        If (commando = "help") Then
            Label3.Text = "per entrare nella calcolatrice: Calc, VBedit (Visual Basic editor)"
        Else
            Label3.Text = "Commando sconosciuto."
        End If
    End Sub
End Class