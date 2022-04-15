<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Changelog
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(359, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHANGELOG 2022 MINDOS!!!"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(963, 588)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Abbiamo aggiunto: La possibilità di poter usare il menù start (aggiunto nel 12/01" &
    "/2022), menù contestuale (06/01/2022) e in fine aggiunta del CMD (17/02/2022)"
        '
        'Changelog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(997, 679)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Changelog"
        Me.Text = "Changelog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
