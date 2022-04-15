Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Benvenuto sul Desktop di MINdos! Qui troveraì tutte le applicazioni essenziali per il tuo computer/PC.")
    End Sub
    Private Sub Form3_Click(sender As Object, e As EventArgs)
        If (Panel1.Enabled = True) Then
            Panel1.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Calc.Show()
        MsgBox("PER RIAVERE IL DESKTOP UNA VOLTA CHIUSA L'APP ANDARE SU MINdos Setup E RI-CLICCARE INIZIA.")
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        If (Panel5.Visible = True) Then
            Panel5.Visible = False
        End If
        If (Panel4.Visible = True) Then
            Panel4.Visible = False
        End If
        If (Panel1.Visible = False) Then
            Panel1.Visible = True
        ElseIf (Panel1.Visible = True) Then
            Panel1.Visible = False
        End If
        If (Panel2.Visible = True) Then
            Panel2.Visible = False
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Calc.Show()
        MsgBox("PER RIAVERE IL DESKTOP UNA VOLTA CHIUSA L'APP ANDARE SU MINdos Setup E RI-CLICCARE INIZIA.")
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        MsgBox("PER RIAVERE IL DESKTOP UNA VOLTA CHIUSA L'APP ANDARE SU MINdos Setup E RI-CLICCARE INIZIA.")
        Me.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        MsgBox("PER RIAVERE IL DESKTOP UNA VOLTA CHIUSA L'APP ANDARE SU MINdos Setup E RI-CLICCARE INIZIA.")
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        cmdAdmin.Show()
        MsgBox("PER RIAVERE IL DESKTOP UNA VOLTA CHIUSA L'APP ANDARE SU MINdos Setup E RI-CLICCARE INIZIA.")
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        MsgBox("PER RIAVERE IL DESKTOP UNA VOLTA CHIUSA L'APP ANDARE SU MINdos Setup E RI-CLICCARE INIZIA.")
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TaskMGR.Show()
        MsgBox("PER RIAVERE IL DESKTOP UNA VOLTA CHIUSA L'APP ANDARE SU MINdos Setup E RI-CLICCARE INIZIA.")
        Me.Hide()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox2.Visible = False
        Button12.Visible = False
        Button13.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox2.Text = ""
        Button8.Visible = True
        Button11.Visible = False
        Panel2.Visible = False
        Panel2.Visible = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If (Panel2.Visible = False) Then
            Panel2.Visible = True
        ElseIf (Panel2.Visible = True) Then
            Panel2.Visible = False
        End If
        If (TextBox2.Visible = False) Then
            Button12.Visible = False
            Button13.Visible = True
        End If
        If (TextBox2.Visible = True) Then
            Button12.Visible = True
            Button13.Visible = False
        End If
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        cmdAdmin.Show()
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox2.Visible = True
        Button13.Visible = False
        Button12.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Panel1.Visible = True) Then
            Panel1.Visible = False
        End If
        If (Panel2.Visible = True) Then
            Panel2.Visible = False
        End If
        If (Panel5.Visible = True) Then
            Panel5.Visible = False
        End If
        Label2.Text = Form1.TextBox1.Text
        If (Panel4.Visible = False) Then
            Panel4.Visible = True
        ElseIf (Panel4.Visible = True) Then
            Panel5.Visible = False
            Panel4.Visible = False
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click_2(sender As Object, e As EventArgs) Handles Button7.Click
        If (Panel5.Visible = False) Then
            Panel5.Visible = True
        ElseIf (Panel4.Visible = True) Then
            Panel5.Visible = False
        End If
    End Sub

    Private Sub Button14_Click_1(sender As Object, e As EventArgs) Handles Button14.Click
        Me.Close()
        Calc.Close()
        Form1.Close()
        TaskMGR.Close()
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Me.Hide()
        Calc.Close()
        TaskMGR.Close()
        Me.Show()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        ScelatAvvChange.Show()
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Me.Hide()
        Calc.Hide()
        TaskMGR.Hide()
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox2.Text = "Clicca per inserire un commando nel CMD"
        Button11.Visible = True
        Button8.Visible = False
        Panel2.Visible = False
        Panel2.Visible = True
    End Sub
End Class