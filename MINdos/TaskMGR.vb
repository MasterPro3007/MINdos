Public Class TaskMGR
    Private Sub TaskMGR_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmdAdmin.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        cmdAdmin.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cmdAdmin.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Calc.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Calc.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        cmdAdmin.Hide()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Calc.Hide()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If Panel2.Visible = True Then
            Panel2.Visible = False
            Panel1.Visible = True
        End If
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        If Panel1.Visible = True Then
            Panel1.Visible = False
            Panel2.Visible = True
        End If
    End Sub
End Class