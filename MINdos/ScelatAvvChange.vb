Public Class ScelatAvvChange
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Changelog.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Avvenimenti.Show()
        Me.Close()
    End Sub
End Class