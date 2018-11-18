<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccueilTangscan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccueilTangscan))
        Me.lblTitrePpl = New System.Windows.Forms.Label()
        Me.btnScannerProduit = New System.Windows.Forms.Button()
        Me.btnGérerListes = New System.Windows.Forms.Button()
        Me.lblCompte = New System.Windows.Forms.Label()
        Me.pctrBxCompte = New System.Windows.Forms.PictureBox()
        Me.pctBxLogo = New System.Windows.Forms.PictureBox()
        Me.pctBxExit = New System.Windows.Forms.PictureBox()
        CType(Me.pctrBxCompte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBxExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitrePpl
        '
        Me.lblTitrePpl.AutoSize = True
        Me.lblTitrePpl.Font = New System.Drawing.Font("Rockwell", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitrePpl.Location = New System.Drawing.Point(77, 139)
        Me.lblTitrePpl.Name = "lblTitrePpl"
        Me.lblTitrePpl.Size = New System.Drawing.Size(199, 46)
        Me.lblTitrePpl.TabIndex = 0
        Me.lblTitrePpl.Text = "TangScan"
        '
        'btnScannerProduit
        '
        Me.btnScannerProduit.BackColor = System.Drawing.Color.White
        Me.btnScannerProduit.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnScannerProduit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScannerProduit.Image = CType(resources.GetObject("btnScannerProduit.Image"), System.Drawing.Image)
        Me.btnScannerProduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnScannerProduit.Location = New System.Drawing.Point(85, 203)
        Me.btnScannerProduit.Name = "btnScannerProduit"
        Me.btnScannerProduit.Size = New System.Drawing.Size(180, 85)
        Me.btnScannerProduit.TabIndex = 1
        Me.btnScannerProduit.Text = "Scanner un produit"
        Me.btnScannerProduit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnScannerProduit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnScannerProduit.UseVisualStyleBackColor = False
        '
        'btnGérerListes
        '
        Me.btnGérerListes.BackColor = System.Drawing.Color.White
        Me.btnGérerListes.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnGérerListes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGérerListes.Image = CType(resources.GetObject("btnGérerListes.Image"), System.Drawing.Image)
        Me.btnGérerListes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGérerListes.Location = New System.Drawing.Point(85, 309)
        Me.btnGérerListes.Name = "btnGérerListes"
        Me.btnGérerListes.Size = New System.Drawing.Size(180, 85)
        Me.btnGérerListes.TabIndex = 2
        Me.btnGérerListes.Text = "Gérer ses listes"
        Me.btnGérerListes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGérerListes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGérerListes.UseVisualStyleBackColor = False
        '
        'lblCompte
        '
        Me.lblCompte.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompte.Location = New System.Drawing.Point(147, 416)
        Me.lblCompte.Name = "lblCompte"
        Me.lblCompte.Size = New System.Drawing.Size(112, 49)
        Me.lblCompte.TabIndex = 3
        Me.lblCompte.Text = "Votre Compte"
        Me.lblCompte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pctrBxCompte
        '
        Me.pctrBxCompte.BackColor = System.Drawing.Color.Transparent
        Me.pctrBxCompte.Image = CType(resources.GetObject("pctrBxCompte.Image"), System.Drawing.Image)
        Me.pctrBxCompte.Location = New System.Drawing.Point(91, 416)
        Me.pctrBxCompte.Name = "pctrBxCompte"
        Me.pctrBxCompte.Size = New System.Drawing.Size(50, 49)
        Me.pctrBxCompte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctrBxCompte.TabIndex = 4
        Me.pctrBxCompte.TabStop = False
        '
        'pctBxLogo
        '
        Me.pctBxLogo.BackColor = System.Drawing.Color.Transparent
        Me.pctBxLogo.Image = CType(resources.GetObject("pctBxLogo.Image"), System.Drawing.Image)
        Me.pctBxLogo.Location = New System.Drawing.Point(114, 12)
        Me.pctBxLogo.Name = "pctBxLogo"
        Me.pctBxLogo.Size = New System.Drawing.Size(115, 109)
        Me.pctBxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxLogo.TabIndex = 5
        Me.pctBxLogo.TabStop = False
        '
        'pctBxExit
        '
        Me.pctBxExit.BackColor = System.Drawing.Color.Transparent
        Me.pctBxExit.Image = CType(resources.GetObject("pctBxExit.Image"), System.Drawing.Image)
        Me.pctBxExit.Location = New System.Drawing.Point(307, 5)
        Me.pctBxExit.Name = "pctBxExit"
        Me.pctBxExit.Size = New System.Drawing.Size(41, 40)
        Me.pctBxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxExit.TabIndex = 6
        Me.pctBxExit.TabStop = False
        '
        'AccueilTangscan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(354, 491)
        Me.Controls.Add(Me.pctBxExit)
        Me.Controls.Add(Me.pctBxLogo)
        Me.Controls.Add(Me.pctrBxCompte)
        Me.Controls.Add(Me.lblCompte)
        Me.Controls.Add(Me.btnGérerListes)
        Me.Controls.Add(Me.btnScannerProduit)
        Me.Controls.Add(Me.lblTitrePpl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AccueilTangscan"
        Me.Text = "TangScan : l'application pour faire vos courses"
        CType(Me.pctrBxCompte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBxExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitrePpl As Label
    Friend WithEvents btnScannerProduit As Button
    Friend WithEvents btnGérerListes As Button
    Friend WithEvents lblCompte As Label
    Friend WithEvents pctrBxCompte As PictureBox
    Friend WithEvents pctBxLogo As PictureBox
    Friend WithEvents pctBxExit As PictureBox
End Class
