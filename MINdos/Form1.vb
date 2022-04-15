Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (CheckBox1.Checked = True) Then
            Dim consapevole = InputBox("SCRIVI 'SONO CONSAPEVOLE DI QUELLO CHE POTREBBE ACCADERE' PER CONTINUARE.")
            If (consapevole = "SONO CONSAPEVOLE DI QUELLO CHE POTREBBE ACCADERE") Then
                Form2.Show()
            Else
                MsgBox("SCRIVI CHE SEI CONSAPEVOLE DI QUELLO CHE POTREBBE ACCADERE PER CONTINUARE!!! PREMESSA: BISOGNA METTERE ANCHE LE MAIUSCOLE")
            End If
        Else
            MsgBox("ACCETTA I TERMINI DI LICENZA PER POTER CONTINUARE!!!")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim password = InputBox("Inserisci una password")
        Dim carPass As Integer
        carPass = password.Length
        If (carPass <= 1) Then
            Button2.Text = "un carattere"
        ElseIf (carPass >= 0) Then
            Button2.Text = carPass & " caratteri"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
