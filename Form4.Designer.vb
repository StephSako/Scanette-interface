<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class partagerUneListe
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(partagerUneListe))
        Me.radioSMSTexto = New System.Windows.Forms.RadioButton()
        Me.radioGoogle = New System.Windows.Forms.RadioButton()
        Me.radioBluetooth = New System.Windows.Forms.RadioButton()
        Me.radioMessenger = New System.Windows.Forms.RadioButton()
        Me.radioFichierTxt = New System.Windows.Forms.RadioButton()
        Me.pctBxReturn = New System.Windows.Forms.PictureBox()
        Me.btnPartager = New System.Windows.Forms.Button()
        Me.radioeMail = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblTitreListePartage = New System.Windows.Forms.Label()
        Me.lblListePartage = New System.Windows.Forms.Label()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radioSMSTexto
        '
        Me.radioSMSTexto.AutoSize = True
        Me.radioSMSTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioSMSTexto.Location = New System.Drawing.Point(4, 155)
        Me.radioSMSTexto.Name = "radioSMSTexto"
        Me.radioSMSTexto.Size = New System.Drawing.Size(121, 28)
        Me.radioSMSTexto.TabIndex = 2
        Me.radioSMSTexto.TabStop = True
        Me.radioSMSTexto.Text = "SMS Texto"
        Me.radioSMSTexto.UseVisualStyleBackColor = True
        '
        'radioGoogle
        '
        Me.radioGoogle.AutoSize = True
        Me.radioGoogle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioGoogle.Location = New System.Drawing.Point(4, 87)
        Me.radioGoogle.Name = "radioGoogle"
        Me.radioGoogle.Size = New System.Drawing.Size(106, 28)
        Me.radioGoogle.TabIndex = 3
        Me.radioGoogle.TabStop = True
        Me.radioGoogle.Text = "Google +"
        Me.radioGoogle.UseVisualStyleBackColor = True
        '
        'radioBluetooth
        '
        Me.radioBluetooth.AutoSize = True
        Me.radioBluetooth.Enabled = False
        Me.radioBluetooth.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioBluetooth.Location = New System.Drawing.Point(4, 53)
        Me.radioBluetooth.Name = "radioBluetooth"
        Me.radioBluetooth.Size = New System.Drawing.Size(203, 28)
        Me.radioBluetooth.TabIndex = 4
        Me.radioBluetooth.TabStop = True
        Me.radioBluetooth.Text = "Bluetooth (désactivé)"
        Me.radioBluetooth.UseVisualStyleBackColor = True
        '
        'radioMessenger
        '
        Me.radioMessenger.AutoSize = True
        Me.radioMessenger.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioMessenger.Location = New System.Drawing.Point(4, 19)
        Me.radioMessenger.Name = "radioMessenger"
        Me.radioMessenger.Size = New System.Drawing.Size(123, 28)
        Me.radioMessenger.TabIndex = 5
        Me.radioMessenger.TabStop = True
        Me.radioMessenger.Text = "Messenger"
        Me.radioMessenger.UseVisualStyleBackColor = True
        '
        'radioFichierTxt
        '
        Me.radioFichierTxt.AutoSize = True
        Me.radioFichierTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioFichierTxt.Location = New System.Drawing.Point(4, 189)
        Me.radioFichierTxt.Name = "radioFichierTxt"
        Me.radioFichierTxt.Size = New System.Drawing.Size(131, 28)
        Me.radioFichierTxt.TabIndex = 6
        Me.radioFichierTxt.TabStop = True
        Me.radioFichierTxt.Text = "Fichier texte"
        Me.radioFichierTxt.UseVisualStyleBackColor = True
        '
        'pctBxReturn
        '
        Me.pctBxReturn.Image = CType(resources.GetObject("pctBxReturn.Image"), System.Drawing.Image)
        Me.pctBxReturn.Location = New System.Drawing.Point(319, 456)
        Me.pctBxReturn.Name = "pctBxReturn"
        Me.pctBxReturn.Size = New System.Drawing.Size(30, 30)
        Me.pctBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxReturn.TabIndex = 7
        Me.pctBxReturn.TabStop = False
        '
        'btnPartager
        '
        Me.btnPartager.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPartager.Image = CType(resources.GetObject("btnPartager.Image"), System.Drawing.Image)
        Me.btnPartager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPartager.Location = New System.Drawing.Point(131, 440)
        Me.btnPartager.Name = "btnPartager"
        Me.btnPartager.Size = New System.Drawing.Size(105, 40)
        Me.btnPartager.TabIndex = 8
        Me.btnPartager.Text = "Partager"
        Me.btnPartager.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPartager.UseVisualStyleBackColor = True
        '
        'radioeMail
        '
        Me.radioeMail.AutoSize = True
        Me.radioeMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radioeMail.Location = New System.Drawing.Point(4, 121)
        Me.radioeMail.Name = "radioeMail"
        Me.radioeMail.Size = New System.Drawing.Size(75, 28)
        Me.radioeMail.TabIndex = 9
        Me.radioeMail.TabStop = True
        Me.radioeMail.Text = "Email"
        Me.radioeMail.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioeMail)
        Me.GroupBox1.Controls.Add(Me.radioMessenger)
        Me.GroupBox1.Controls.Add(Me.radioFichierTxt)
        Me.GroupBox1.Controls.Add(Me.radioBluetooth)
        Me.GroupBox1.Controls.Add(Me.radioSMSTexto)
        Me.GroupBox1.Controls.Add(Me.radioGoogle)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(71, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(227, 220)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choisissez votre mode de partage"
        '
        'lblTitreListePartage
        '
        Me.lblTitreListePartage.AutoSize = True
        Me.lblTitreListePartage.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreListePartage.Location = New System.Drawing.Point(140, 3)
        Me.lblTitreListePartage.Name = "lblTitreListePartage"
        Me.lblTitreListePartage.Size = New System.Drawing.Size(120, 33)
        Me.lblTitreListePartage.TabIndex = 11
        Me.lblTitreListePartage.Text = "TitreListe"
        '
        'lblListePartage
        '
        Me.lblListePartage.BackColor = System.Drawing.Color.White
        Me.lblListePartage.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListePartage.Location = New System.Drawing.Point(101, 42)
        Me.lblListePartage.Name = "lblListePartage"
        Me.lblListePartage.Size = New System.Drawing.Size(165, 160)
        Me.lblListePartage.TabIndex = 12
        '
        'partagerUneListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 491)
        Me.Controls.Add(Me.lblListePartage)
        Me.Controls.Add(Me.lblTitreListePartage)
        Me.Controls.Add(Me.btnPartager)
        Me.Controls.Add(Me.pctBxReturn)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "partagerUneListe"
        Me.Text = "Partager une liste"
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radioSMSTexto As RadioButton
    Friend WithEvents radioGoogle As RadioButton
    Friend WithEvents radioBluetooth As RadioButton
    Friend WithEvents radioMessenger As RadioButton
    Friend WithEvents radioFichierTxt As RadioButton
    Friend WithEvents pctBxReturn As PictureBox
    Friend WithEvents btnPartager As Button
    Friend WithEvents radioeMail As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTitreListePartage As Label
    Friend WithEvents lblListePartage As Label
End Class
