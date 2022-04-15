<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskMGR
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 30)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(345, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Esegui eseutore di commandi (SOLO ADMIN)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(21, 102)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(239, 32)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Esegui Calcolatrice"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(389, 35)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(162, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Chiudi (Solo se aperto)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(389, 107)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(162, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Chiudi (Solo se aperto)"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(619, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 48)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Nascondi (Solo se aperto)"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(619, 88)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 42)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Nascodi (Solo se aperto)"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Location = New System.Drawing.Point(12, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(834, 272)
        Me.Panel1.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Button4.Location = New System.Drawing.Point(12, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(195, 40)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Esegui/Chiudi/Nascondi"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button8.Location = New System.Drawing.Point(246, 13)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(328, 23)
        Me.Button8.TabIndex = 11
        Me.Button8.Text = "Processi in esecuzione di sistema"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Yellow
        Me.Button9.Location = New System.Drawing.Point(580, 22)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(254, 23)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "Diventa uno sviluppatore"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 337)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(834, 318)
        Me.Panel2.TabIndex = 9
        Me.Panel2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "checkIfInited"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TermsCheck"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "AccountRegister"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(362, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SystemRecordService - Sistema di registrazione commandi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "services.sc"
        '
        'TaskMGR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 664)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TaskMGR"
        Me.Text = "Gestione attività"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
