<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class comptesCoEtCr
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(comptesCoEtCr))
        Me.grpBxSeConnecter = New System.Windows.Forms.GroupBox()
        Me.btnLogOff = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblErreurCo = New System.Windows.Forms.Label()
        Me.lblSaisieEmail = New System.Windows.Forms.Label()
        Me.txtBxCODEA = New System.Windows.Forms.TextBox()
        Me.grpBxSynchroniser = New System.Windows.Forms.GroupBox()
        Me.pctrBxEvernote = New System.Windows.Forms.PictureBox()
        Me.pctrBxOneNote = New System.Windows.Forms.PictureBox()
        Me.pctrBxGoogle = New System.Windows.Forms.PictureBox()
        Me.btnCréerCompteTangScan = New System.Windows.Forms.Button()
        Me.pctBxReturn = New System.Windows.Forms.PictureBox()
        Me.grpBxSeConnecter.SuspendLayout()
        Me.grpBxSynchroniser.SuspendLayout()
        CType(Me.pctrBxEvernote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctrBxOneNote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctrBxGoogle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBxSeConnecter
        '
        Me.grpBxSeConnecter.Controls.Add(Me.btnLogOff)
        Me.grpBxSeConnecter.Controls.Add(Me.btnLogIn)
        Me.grpBxSeConnecter.Controls.Add(Me.lblErreurCo)
        Me.grpBxSeConnecter.Controls.Add(Me.lblSaisieEmail)
        Me.grpBxSeConnecter.Controls.Add(Me.txtBxCODEA)
        Me.grpBxSeConnecter.Controls.Add(Me.grpBxSynchroniser)
        Me.grpBxSeConnecter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBxSeConnecter.Location = New System.Drawing.Point(12, 12)
        Me.grpBxSeConnecter.Name = "grpBxSeConnecter"
        Me.grpBxSeConnecter.Size = New System.Drawing.Size(330, 396)
        Me.grpBxSeConnecter.TabIndex = 0
        Me.grpBxSeConnecter.TabStop = False
        Me.grpBxSeConnecter.Text = "Se connecter à son compte TangScan"
        '
        'btnLogOff
        '
        Me.btnLogOff.BackColor = System.Drawing.Color.White
        Me.btnLogOff.Image = CType(resources.GetObject("btnLogOff.Image"), System.Drawing.Image)
        Me.btnLogOff.Location = New System.Drawing.Point(291, 13)
        Me.btnLogOff.Name = "btnLogOff"
        Me.btnLogOff.Size = New System.Drawing.Size(34, 34)
        Me.btnLogOff.TabIndex = 10
        Me.btnLogOff.UseVisualStyleBackColor = False
        '
        'btnLogIn
        '
        Me.btnLogIn.BackColor = System.Drawing.Color.White
        Me.btnLogIn.Image = CType(resources.GetObject("btnLogIn.Image"), System.Drawing.Image)
        Me.btnLogIn.Location = New System.Drawing.Point(134, 153)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(50, 50)
        Me.btnLogIn.TabIndex = 9
        Me.btnLogIn.UseVisualStyleBackColor = False
        '
        'lblErreurCo
        '
        Me.lblErreurCo.AutoSize = True
        Me.lblErreurCo.Location = New System.Drawing.Point(27, 232)
        Me.lblErreurCo.Name = "lblErreurCo"
        Me.lblErreurCo.Size = New System.Drawing.Size(0, 18)
        Me.lblErreurCo.TabIndex = 7
        Me.lblErreurCo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSaisieEmail
        '
        Me.lblSaisieEmail.AutoSize = True
        Me.lblSaisieEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaisieEmail.Location = New System.Drawing.Point(52, 37)
        Me.lblSaisieEmail.Name = "lblSaisieEmail"
        Me.lblSaisieEmail.Size = New System.Drawing.Size(225, 20)
        Me.lblSaisieEmail.TabIndex = 4
        Me.lblSaisieEmail.Text = "Saisissez votre code Client"
        '
        'txtBxCODEA
        '
        Me.txtBxCODEA.Location = New System.Drawing.Point(59, 98)
        Me.txtBxCODEA.Name = "txtBxCODEA"
        Me.txtBxCODEA.Size = New System.Drawing.Size(206, 24)
        Me.txtBxCODEA.TabIndex = 2
        '
        'grpBxSynchroniser
        '
        Me.grpBxSynchroniser.Controls.Add(Me.pctrBxEvernote)
        Me.grpBxSynchroniser.Controls.Add(Me.pctrBxOneNote)
        Me.grpBxSynchroniser.Controls.Add(Me.pctrBxGoogle)
        Me.grpBxSynchroniser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBxSynchroniser.Location = New System.Drawing.Point(6, 270)
        Me.grpBxSynchroniser.Name = "grpBxSynchroniser"
        Me.grpBxSynchroniser.Size = New System.Drawing.Size(318, 120)
        Me.grpBxSynchroniser.TabIndex = 1
        Me.grpBxSynchroniser.TabStop = False
        Me.grpBxSynchroniser.Text = "Synchroniser un compte en ligne"
        '
        'pctrBxEvernote
        '
        Me.pctrBxEvernote.BackColor = System.Drawing.Color.Transparent
        Me.pctrBxEvernote.Image = CType(resources.GetObject("pctrBxEvernote.Image"), System.Drawing.Image)
        Me.pctrBxEvernote.Location = New System.Drawing.Point(119, 31)
        Me.pctrBxEvernote.Name = "pctrBxEvernote"
        Me.pctrBxEvernote.Size = New System.Drawing.Size(75, 75)
        Me.pctrBxEvernote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrBxEvernote.TabIndex = 2
        Me.pctrBxEvernote.TabStop = False
        '
        'pctrBxOneNote
        '
        Me.pctrBxOneNote.BackColor = System.Drawing.Color.Transparent
        Me.pctrBxOneNote.Image = CType(resources.GetObject("pctrBxOneNote.Image"), System.Drawing.Image)
        Me.pctrBxOneNote.Location = New System.Drawing.Point(237, 31)
        Me.pctrBxOneNote.Name = "pctrBxOneNote"
        Me.pctrBxOneNote.Size = New System.Drawing.Size(75, 75)
        Me.pctrBxOneNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrBxOneNote.TabIndex = 1
        Me.pctrBxOneNote.TabStop = False
        '
        'pctrBxGoogle
        '
        Me.pctrBxGoogle.BackColor = System.Drawing.Color.Transparent
        Me.pctrBxGoogle.Image = CType(resources.GetObject("pctrBxGoogle.Image"), System.Drawing.Image)
        Me.pctrBxGoogle.Location = New System.Drawing.Point(6, 31)
        Me.pctrBxGoogle.Name = "pctrBxGoogle"
        Me.pctrBxGoogle.Size = New System.Drawing.Size(75, 75)
        Me.pctrBxGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrBxGoogle.TabIndex = 0
        Me.pctrBxGoogle.TabStop = False
        '
        'btnCréerCompteTangScan
        '
        Me.btnCréerCompteTangScan.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCréerCompteTangScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCréerCompteTangScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCréerCompteTangScan.Location = New System.Drawing.Point(87, 414)
        Me.btnCréerCompteTangScan.Name = "btnCréerCompteTangScan"
        Me.btnCréerCompteTangScan.Size = New System.Drawing.Size(173, 45)
        Me.btnCréerCompteTangScan.TabIndex = 1
        Me.btnCréerCompteTangScan.Text = "Créer un compte TangScan"
        Me.btnCréerCompteTangScan.UseVisualStyleBackColor = False
        '
        'pctBxReturn
        '
        Me.pctBxReturn.BackColor = System.Drawing.Color.Transparent
        Me.pctBxReturn.Image = CType(resources.GetObject("pctBxReturn.Image"), System.Drawing.Image)
        Me.pctBxReturn.Location = New System.Drawing.Point(316, 454)
        Me.pctBxReturn.Name = "pctBxReturn"
        Me.pctBxReturn.Size = New System.Drawing.Size(32, 32)
        Me.pctBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxReturn.TabIndex = 4
        Me.pctBxReturn.TabStop = False
        '
        'comptesCoEtCr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 491)
        Me.Controls.Add(Me.pctBxReturn)
        Me.Controls.Add(Me.btnCréerCompteTangScan)
        Me.Controls.Add(Me.grpBxSeConnecter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "comptesCoEtCr"
        Me.Text = "Se connecter / Créer un compte"
        Me.grpBxSeConnecter.ResumeLayout(False)
        Me.grpBxSeConnecter.PerformLayout()
        Me.grpBxSynchroniser.ResumeLayout(False)
        CType(Me.pctrBxEvernote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctrBxOneNote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctrBxGoogle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpBxSeConnecter As GroupBox
    Friend WithEvents grpBxSynchroniser As GroupBox
    Friend WithEvents pctrBxOneNote As PictureBox
    Friend WithEvents pctrBxGoogle As PictureBox
    Friend WithEvents pctrBxEvernote As PictureBox
    Friend WithEvents lblSaisieEmail As Label
    Friend WithEvents txtBxCODEA As TextBox
    Friend WithEvents btnCréerCompteTangScan As Button
    Friend WithEvents pctBxReturn As PictureBox
    Friend WithEvents lblErreurCo As Label
    Friend WithEvents btnLogIn As Button
    Friend WithEvents btnLogOff As Button
End Class
