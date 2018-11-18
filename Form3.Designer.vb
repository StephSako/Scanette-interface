<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ficheProduit
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ficheProduit))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblEuro = New System.Windows.Forms.Label()
        Me.lblCodeProduit = New System.Windows.Forms.Label()
        Me.lblPrixProduit = New System.Windows.Forms.Label()
        Me.pctrBxProduit = New System.Windows.Forms.PictureBox()
        Me.lblDescriptionProduit = New System.Windows.Forms.Label()
        Me.lblNomProduit = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGererListes = New System.Windows.Forms.Button()
        Me.btnAjouterProduit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPrixQuantité = New System.Windows.Forms.Label()
        Me.lblValeurTrckBr = New System.Windows.Forms.Label()
        Me.cmbBxListeAjout = New System.Windows.Forms.ComboBox()
        Me.lblAjouterListeScan = New System.Windows.Forms.Label()
        Me.lblQuantité = New System.Windows.Forms.Label()
        Me.trckBrQuantité = New System.Windows.Forms.TrackBar()
        Me.pctBxReturn = New System.Windows.Forms.PictureBox()
        Me.lblErreur = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pctrBxProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trckBrQuantité, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblEuro)
        Me.Panel1.Controls.Add(Me.lblCodeProduit)
        Me.Panel1.Controls.Add(Me.lblPrixProduit)
        Me.Panel1.Controls.Add(Me.pctrBxProduit)
        Me.Panel1.Controls.Add(Me.lblDescriptionProduit)
        Me.Panel1.Controls.Add(Me.lblNomProduit)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 210)
        Me.Panel1.TabIndex = 0
        '
        'lblEuro
        '
        Me.lblEuro.AutoSize = True
        Me.lblEuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEuro.Location = New System.Drawing.Point(179, 155)
        Me.lblEuro.Name = "lblEuro"
        Me.lblEuro.Size = New System.Drawing.Size(20, 24)
        Me.lblEuro.TabIndex = 5
        Me.lblEuro.Text = "€"
        '
        'lblCodeProduit
        '
        Me.lblCodeProduit.AutoSize = True
        Me.lblCodeProduit.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodeProduit.Location = New System.Drawing.Point(128, 185)
        Me.lblCodeProduit.Name = "lblCodeProduit"
        Me.lblCodeProduit.Size = New System.Drawing.Size(93, 17)
        Me.lblCodeProduit.TabIndex = 4
        Me.lblCodeProduit.Text = "[code produit]"
        '
        'lblPrixProduit
        '
        Me.lblPrixProduit.AutoSize = True
        Me.lblPrixProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixProduit.Location = New System.Drawing.Point(129, 156)
        Me.lblPrixProduit.Name = "lblPrixProduit"
        Me.lblPrixProduit.Size = New System.Drawing.Size(39, 24)
        Me.lblPrixProduit.TabIndex = 3
        Me.lblPrixProduit.Text = "--,--"
        '
        'pctrBxProduit
        '
        Me.pctrBxProduit.Location = New System.Drawing.Point(3, 5)
        Me.pctrBxProduit.Name = "pctrBxProduit"
        Me.pctrBxProduit.Size = New System.Drawing.Size(136, 131)
        Me.pctrBxProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrBxProduit.TabIndex = 2
        Me.pctrBxProduit.TabStop = False
        '
        'lblDescriptionProduit
        '
        Me.lblDescriptionProduit.BackColor = System.Drawing.SystemColors.Control
        Me.lblDescriptionProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionProduit.Location = New System.Drawing.Point(145, 43)
        Me.lblDescriptionProduit.Name = "lblDescriptionProduit"
        Me.lblDescriptionProduit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDescriptionProduit.Size = New System.Drawing.Size(175, 93)
        Me.lblDescriptionProduit.TabIndex = 1
        Me.lblDescriptionProduit.Text = "[description produit]"
        Me.lblDescriptionProduit.UseCompatibleTextRendering = True
        '
        'lblNomProduit
        '
        Me.lblNomProduit.AutoSize = True
        Me.lblNomProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomProduit.Location = New System.Drawing.Point(162, 5)
        Me.lblNomProduit.Name = "lblNomProduit"
        Me.lblNomProduit.Size = New System.Drawing.Size(168, 29)
        Me.lblNomProduit.TabIndex = 0
        Me.lblNomProduit.Text = "[nom produit]"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnGererListes)
        Me.Panel2.Controls.Add(Me.btnAjouterProduit)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.lblPrixQuantité)
        Me.Panel2.Controls.Add(Me.lblValeurTrckBr)
        Me.Panel2.Controls.Add(Me.cmbBxListeAjout)
        Me.Panel2.Controls.Add(Me.lblAjouterListeScan)
        Me.Panel2.Controls.Add(Me.lblQuantité)
        Me.Panel2.Controls.Add(Me.trckBrQuantité)
        Me.Panel2.Location = New System.Drawing.Point(12, 228)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(330, 210)
        Me.Panel2.TabIndex = 1
        '
        'btnGererListes
        '
        Me.btnGererListes.BackColor = System.Drawing.Color.White
        Me.btnGererListes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGererListes.Image = CType(resources.GetObject("btnGererListes.Image"), System.Drawing.Image)
        Me.btnGererListes.Location = New System.Drawing.Point(275, 33)
        Me.btnGererListes.Name = "btnGererListes"
        Me.btnGererListes.Size = New System.Drawing.Size(45, 45)
        Me.btnGererListes.TabIndex = 13
        Me.btnGererListes.UseVisualStyleBackColor = False
        '
        'btnAjouterProduit
        '
        Me.btnAjouterProduit.BackColor = System.Drawing.Color.White
        Me.btnAjouterProduit.Image = CType(resources.GetObject("btnAjouterProduit.Image"), System.Drawing.Image)
        Me.btnAjouterProduit.Location = New System.Drawing.Point(275, 156)
        Me.btnAjouterProduit.Name = "btnAjouterProduit"
        Me.btnAjouterProduit.Size = New System.Drawing.Size(45, 45)
        Me.btnAjouterProduit.TabIndex = 12
        Me.btnAjouterProduit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(171, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "€"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 150)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lblPrixQuantité
        '
        Me.lblPrixQuantité.AutoSize = True
        Me.lblPrixQuantité.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixQuantité.Location = New System.Drawing.Point(100, 161)
        Me.lblPrixQuantité.Name = "lblPrixQuantité"
        Me.lblPrixQuantité.Size = New System.Drawing.Size(44, 24)
        Me.lblPrixQuantité.TabIndex = 9
        Me.lblPrixQuantité.Text = "--,--"
        '
        'lblValeurTrckBr
        '
        Me.lblValeurTrckBr.AutoSize = True
        Me.lblValeurTrckBr.BackColor = System.Drawing.Color.Transparent
        Me.lblValeurTrckBr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValeurTrckBr.Location = New System.Drawing.Point(297, 105)
        Me.lblValeurTrckBr.Name = "lblValeurTrckBr"
        Me.lblValeurTrckBr.Size = New System.Drawing.Size(26, 25)
        Me.lblValeurTrckBr.TabIndex = 5
        Me.lblValeurTrckBr.Text = "--"
        '
        'cmbBxListeAjout
        '
        Me.cmbBxListeAjout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBxListeAjout.FormattingEnabled = True
        Me.cmbBxListeAjout.Location = New System.Drawing.Point(108, 43)
        Me.cmbBxListeAjout.Name = "cmbBxListeAjout"
        Me.cmbBxListeAjout.Size = New System.Drawing.Size(155, 28)
        Me.cmbBxListeAjout.TabIndex = 8
        Me.cmbBxListeAjout.TabStop = False
        Me.cmbBxListeAjout.Text = "--------------------------"
        '
        'lblAjouterListeScan
        '
        Me.lblAjouterListeScan.AutoSize = True
        Me.lblAjouterListeScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAjouterListeScan.Location = New System.Drawing.Point(4, 42)
        Me.lblAjouterListeScan.Name = "lblAjouterListeScan"
        Me.lblAjouterListeScan.Size = New System.Drawing.Size(98, 25)
        Me.lblAjouterListeScan.TabIndex = 6
        Me.lblAjouterListeScan.Text = "Ajouter à"
        '
        'lblQuantité
        '
        Me.lblQuantité.AutoSize = True
        Me.lblQuantité.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantité.Location = New System.Drawing.Point(4, 96)
        Me.lblQuantité.Name = "lblQuantité"
        Me.lblQuantité.Size = New System.Drawing.Size(93, 25)
        Me.lblQuantité.TabIndex = 5
        Me.lblQuantité.Text = "Quantité"
        '
        'trckBrQuantité
        '
        Me.trckBrQuantité.AutoSize = False
        Me.trckBrQuantité.BackColor = System.Drawing.Color.White
        Me.trckBrQuantité.Location = New System.Drawing.Point(96, 96)
        Me.trckBrQuantité.Minimum = 1
        Me.trckBrQuantité.Name = "trckBrQuantité"
        Me.trckBrQuantité.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.trckBrQuantité.Size = New System.Drawing.Size(198, 45)
        Me.trckBrQuantité.TabIndex = 0
        Me.trckBrQuantité.TickStyle = System.Windows.Forms.TickStyle.TopLeft
        Me.trckBrQuantité.Value = 1
        '
        'pctBxReturn
        '
        Me.pctBxReturn.BackColor = System.Drawing.SystemColors.Control
        Me.pctBxReturn.Image = CType(resources.GetObject("pctBxReturn.Image"), System.Drawing.Image)
        Me.pctBxReturn.Location = New System.Drawing.Point(319, 454)
        Me.pctBxReturn.Name = "pctBxReturn"
        Me.pctBxReturn.Size = New System.Drawing.Size(32, 32)
        Me.pctBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxReturn.TabIndex = 4
        Me.pctBxReturn.TabStop = False
        '
        'lblErreur
        '
        Me.lblErreur.AutoSize = True
        Me.lblErreur.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErreur.ForeColor = System.Drawing.Color.Red
        Me.lblErreur.Location = New System.Drawing.Point(16, 450)
        Me.lblErreur.Name = "lblErreur"
        Me.lblErreur.Size = New System.Drawing.Size(0, 16)
        Me.lblErreur.TabIndex = 5
        '
        'ficheProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(357, 491)
        Me.Controls.Add(Me.lblErreur)
        Me.Controls.Add(Me.pctBxReturn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ficheProduit"
        Me.Text = "Fiche produit"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pctrBxProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trckBrQuantité, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pctBxReturn As PictureBox
    Friend WithEvents lblNomProduit As Label
    Friend WithEvents lblDescriptionProduit As Label
    Friend WithEvents pctrBxProduit As PictureBox
    Friend WithEvents lblPrixProduit As Label
    Friend WithEvents lblCodeProduit As Label
    Friend WithEvents lblQuantité As Label
    Friend WithEvents trckBrQuantité As TrackBar
    Friend WithEvents lblAjouterListeScan As Label
    Friend WithEvents lblEuro As Label
    Friend WithEvents cmbBxListeAjout As ComboBox
    Friend WithEvents lblValeurTrckBr As Label
    Friend WithEvents lblPrixQuantité As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAjouterProduit As Button
    Friend WithEvents lblErreur As Label
    Friend WithEvents btnGererListes As Button
End Class
