Public Class Calc
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("PREMESSA PRIMA DI PROSEGUIRE: Se metterete nulla oppure metterete una stringa e non un numero dovrete cliccare su Continua per risolvere")
        Dim a As Integer = InputBox("Inserisci il numero da dividere")
        Dim b As Integer = InputBox("Inserisci il numero per la divisione. PREMESSA: Se metterete zero il risultato risulterà infinito")
        MsgBox("Il risultato è " & a / b)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("PREMESSA PRIMA DI PROSEGUIRE: Se metterete nulla oppure metterete una stringa e non un numero dovrete cliccare su Continua per risolvere")
        Dim a As Integer = InputBox("Inserisci il numero da moltiplicare")
        Dim b As Integer = InputBox("Inserisci il numero per la moltiplicazione.")
        MsgBox("Il risultato è " & a * b)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("PREMESSA PRIMA DI PROSEGUIRE: Se metterete nulla oppure metterete una stringa e non un numero dovrete cliccare su Continua per risolvere")
        Dim a As Integer = InputBox("Inserisci il numero da addizionare")
        Dim b As Integer = InputBox("Inserisci il numero per la addizione.")
        MsgBox("Il risultato è " & a + b)
    End Sub

    Private Sub Calc_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("PREMESSA PRIMA DI PROSEGUIRE: Se metterete nulla oppure metterete una stringa e non un numero dovrete cliccare su Continua per risolvere")
        Dim a As Integer = InputBox("Inserisci il numero da sottrare")
        Dim b As Integer = InputBox("Inserisci il numero per la sottrazione.")
        MsgBox("Il risultato è " & a - b)
    End Sub

End Class