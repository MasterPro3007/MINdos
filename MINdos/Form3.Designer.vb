<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "calcolatrice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(351, 669)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(550, 23)
        Me.ProgressBar1.TabIndex = 2
        Me.ProgressBar1.Value = 99
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(0, 793)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Start"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(91, 794)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(289, 22)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "Clicca per eseguire un commando nel CMD"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(47, 792)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(38, 24)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "^"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button10)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Location = New System.Drawing.Point(0, 529)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 259)
        Me.Panel1.TabIndex = 11
        Me.Panel1.Visible = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button10.Location = New System.Drawing.Point(0, 150)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(292, 23)
        Me.Button10.TabIndex = 14
        Me.Button10.Text = "Riga di commando >"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Location = New System.Drawing.Point(298, 150)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 100)
        Me.Panel3.TabIndex = 13
        Me.Panel3.Visible = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button9.Location = New System.Drawing.Point(3, 61)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(292, 23)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "Calcolatrice"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button6.Location = New System.Drawing.Point(0, 32)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(292, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Esecutore di commandi (Admin)"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.Location = New System.Drawing.Point(0, 3)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(292, 23)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Gestione attività"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.Button13)
        Me.Panel2.Controls.Add(Me.Button12)
        Me.Panel2.Controls.Add(Me.Button11)
        Me.Panel2.Location = New System.Drawing.Point(301, 640)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(314, 139)
        Me.Panel2.TabIndex = 12
        Me.Panel2.Visible = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button13.Location = New System.Drawing.Point(0, 62)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(183, 23)
        Me.Button13.TabIndex = 2
        Me.Button13.Text = "Mostra"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button12.Location = New System.Drawing.Point(0, 32)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(183, 23)
        Me.Button12.TabIndex = 1
        Me.Button12.Text = "Nascondi"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button11.Location = New System.Drawing.Point(0, 3)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(307, 23)
        Me.Button11.TabIndex = 0
        Me.Button11.Text = "Mostra solo casella di testo"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.IndianRed
        Me.Panel4.Controls.Add(Me.Button7)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(0, 380)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(433, 408)
        Me.Panel4.TabIndex = 13
        Me.Panel4.Visible = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button7.Location = New System.Drawing.Point(298, 212)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(129, 71)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Funzioni di spegnimento ->"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Controls.Add(Me.Button16)
        Me.Panel5.Controls.Add(Me.Button15)
        Me.Panel5.Controls.Add(Me.Button14)
        Me.Panel5.Location = New System.Drawing.Point(433, 532)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(238, 142)
        Me.Panel5.TabIndex = 2
        Me.Panel5.Visible = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.DarkOrange
        Me.Button16.Location = New System.Drawing.Point(6, 76)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(217, 23)
        Me.Button16.TabIndex = 5
        Me.Button16.Text = "Sospendi MINdos"
        Me.Button16.UseVisualStyleBackColor = False
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.White
        Me.Button15.Location = New System.Drawing.Point(6, 37)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(217, 23)
        Me.Button15.TabIndex = 4
        Me.Button15.Text = "Riavvia MINdos"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Red
        Me.Button14.Location = New System.Drawing.Point(6, 3)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(217, 23)
        Me.Button14.TabIndex = 3
        Me.Button14.Text = "Spegni MINdos"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(13, 48)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 61)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Changelog            / Avvenimenti foturi"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button8.Location = New System.Drawing.Point(0, 91)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(307, 37)
        Me.Button8.TabIndex = 3
        Me.Button8.Text = "Mostra testo casella di ricerca"
        Me.Button8.UseVisualStyleBackColor = False
        Me.Button8.Visible = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1143, 817)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form3"
        Me.Text = "                                                                                 " &
    "                                              MINdos Desktop"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button7 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Button16 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button8 As Button
End Class
