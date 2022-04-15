<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScelatAvvChange
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Scegli se andare nei changelog oppure negli avvenenimenti futuri:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(26, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(266, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Changelog"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(361, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(230, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Avvenimenti futuri"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ScelatAvvChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 606)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ScelatAvvChange"
        Me.Text = "Scegli se andare agli avvenimenti oppure i changelog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
