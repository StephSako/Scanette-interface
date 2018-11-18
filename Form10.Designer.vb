<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class accueilProduits
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accueilProduits))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstBxCategorie = New System.Windows.Forms.ListBox()
        Me.btnAjouterProduit = New System.Windows.Forms.Button()
        Me.lstBxProduitsMag = New System.Windows.Forms.ListBox()
        Me.btnSuppProduit = New System.Windows.Forms.Button()
        Me.btnScanner = New System.Windows.Forms.Button()
        Me.lstBxPrix = New System.Windows.Forms.ListBox()
        Me.btnPayer = New System.Windows.Forms.Button()
        Me.lstBxProduits = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrixRestant = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPrix = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblErreurListe = New System.Windows.Forms.Label()
        Me.pctBxReturn = New System.Windows.Forms.PictureBox()
        Me.lstBxQuantite = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstBxCategorie)
        Me.GroupBox2.Controls.Add(Me.btnAjouterProduit)
        Me.GroupBox2.Controls.Add(Me.lstBxProduitsMag)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(348, 194)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Liste des produits"
        '
        'lstBxCategorie
        '
        Me.lstBxCategorie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBxCategorie.FormattingEnabled = True
        Me.lstBxCategorie.ItemHeight = 18
        Me.lstBxCategorie.Location = New System.Drawing.Point(6, 20)
        Me.lstBxCategorie.Name = "lstBxCategorie"
        Me.lstBxCategorie.Size = New System.Drawing.Size(129, 166)
        Me.lstBxCategorie.TabIndex = 23
        '
        'btnAjouterProduit
        '
        Me.btnAjouterProduit.BackColor = System.Drawing.Color.White
        Me.btnAjouterProduit.Image = CType(resources.GetObject("btnAjouterProduit.Image"), System.Drawing.Image)
        Me.btnAjouterProduit.Location = New System.Drawing.Point(141, 91)
        Me.btnAjouterProduit.Name = "btnAjouterProduit"
        Me.btnAjouterProduit.Size = New System.Drawing.Size(33, 33)
        Me.btnAjouterProduit.TabIndex = 10
        Me.btnAjouterProduit.UseVisualStyleBackColor = False
        '
        'lstBxProduitsMag
        '
        Me.lstBxProduitsMag.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBxProduitsMag.FormattingEnabled = True
        Me.lstBxProduitsMag.ItemHeight = 18
        Me.lstBxProduitsMag.Location = New System.Drawing.Point(180, 20)
        Me.lstBxProduitsMag.Name = "lstBxProduitsMag"
        Me.lstBxProduitsMag.Size = New System.Drawing.Size(162, 166)
        Me.lstBxProduitsMag.TabIndex = 22
        '
        'btnSuppProduit
        '
        Me.btnSuppProduit.BackColor = System.Drawing.Color.Red
        Me.btnSuppProduit.Image = CType(resources.GetObject("btnSuppProduit.Image"), System.Drawing.Image)
        Me.btnSuppProduit.Location = New System.Drawing.Point(152, 208)
        Me.btnSuppProduit.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSuppProduit.Name = "btnSuppProduit"
        Me.btnSuppProduit.Size = New System.Drawing.Size(34, 34)
        Me.btnSuppProduit.TabIndex = 20
        Me.btnSuppProduit.UseVisualStyleBackColor = False
        '
        'btnScanner
        '
        Me.btnScanner.BackColor = System.Drawing.Color.White
        Me.btnScanner.Image = CType(resources.GetObject("btnScanner.Image"), System.Drawing.Image)
        Me.btnScanner.Location = New System.Drawing.Point(102, 209)
        Me.btnScanner.Name = "btnScanner"
        Me.btnScanner.Size = New System.Drawing.Size(33, 33)
        Me.btnScanner.TabIndex = 17
        Me.btnScanner.UseVisualStyleBackColor = False
        '
        'lstBxPrix
        '
        Me.lstBxPrix.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBxPrix.FormattingEnabled = True
        Me.lstBxPrix.ItemHeight = 18
        Me.lstBxPrix.Location = New System.Drawing.Point(152, 265)
        Me.lstBxPrix.Name = "lstBxPrix"
        Me.lstBxPrix.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstBxPrix.Size = New System.Drawing.Size(55, 202)
        Me.lstBxPrix.TabIndex = 16
        '
        'btnPayer
        '
        Me.btnPayer.BackColor = System.Drawing.Color.White
        Me.btnPayer.Image = CType(resources.GetObject("btnPayer.Image"), System.Drawing.Image)
        Me.btnPayer.Location = New System.Drawing.Point(53, 209)
        Me.btnPayer.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPayer.Name = "btnPayer"
        Me.btnPayer.Size = New System.Drawing.Size(34, 34)
        Me.btnPayer.TabIndex = 21
        Me.btnPayer.UseVisualStyleBackColor = False
        '
        'lstBxProduits
        '
        Me.lstBxProduits.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBxProduits.FormattingEnabled = True
        Me.lstBxProduits.ItemHeight = 18
        Me.lstBxProduits.Location = New System.Drawing.Point(4, 265)
        Me.lstBxProduits.Name = "lstBxProduits"
        Me.lstBxProduits.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstBxProduits.Size = New System.Drawing.Size(146, 202)
        Me.lstBxProduits.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblPrixRestant)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.lblPrix)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(250, 296)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(94, 143)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "€"
        '
        'lblPrixRestant
        '
        Me.lblPrixRestant.AutoSize = True
        Me.lblPrixRestant.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPrixRestant.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixRestant.Location = New System.Drawing.Point(25, 117)
        Me.lblPrixRestant.Name = "lblPrixRestant"
        Me.lblPrixRestant.Size = New System.Drawing.Size(32, 18)
        Me.lblPrixRestant.TabIndex = 8
        Me.lblPrixRestant.Text = "--,--"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Prix restant"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "€"
        '
        'lblPrix
        '
        Me.lblPrix.AutoSize = True
        Me.lblPrix.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPrix.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrix.Location = New System.Drawing.Point(26, 57)
        Me.lblPrix.Name = "lblPrix"
        Me.lblPrix.Size = New System.Drawing.Size(32, 18)
        Me.lblPrix.TabIndex = 5
        Me.lblPrix.Text = "--,--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Prix total"
        '
        'lblErreurListe
        '
        Me.lblErreurListe.AutoSize = True
        Me.lblErreurListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErreurListe.Location = New System.Drawing.Point(7, 472)
        Me.lblErreurListe.Name = "lblErreurListe"
        Me.lblErreurListe.Size = New System.Drawing.Size(0, 16)
        Me.lblErreurListe.TabIndex = 21
        '
        'pctBxReturn
        '
        Me.pctBxReturn.Image = CType(resources.GetObject("pctBxReturn.Image"), System.Drawing.Image)
        Me.pctBxReturn.Location = New System.Drawing.Point(318, 455)
        Me.pctBxReturn.Name = "pctBxReturn"
        Me.pctBxReturn.Size = New System.Drawing.Size(30, 30)
        Me.pctBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxReturn.TabIndex = 22
        Me.pctBxReturn.TabStop = False
        '
        'lstBxQuantite
        '
        Me.lstBxQuantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBxQuantite.FormattingEnabled = True
        Me.lstBxQuantite.ItemHeight = 18
        Me.lstBxQuantite.Location = New System.Drawing.Point(209, 265)
        Me.lstBxQuantite.Name = "lstBxQuantite"
        Me.lstBxQuantite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstBxQuantite.Size = New System.Drawing.Size(32, 202)
        Me.lstBxQuantite.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Produits"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(162, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Prix"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(208, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Qté"
        '
        'accueilProduits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 491)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstBxQuantite)
        Me.Controls.Add(Me.pctBxReturn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSuppProduit)
        Me.Controls.Add(Me.lblErreurListe)
        Me.Controls.Add(Me.btnScanner)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lstBxPrix)
        Me.Controls.Add(Me.lstBxProduits)
        Me.Controls.Add(Me.btnPayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "accueilProduits"
        Me.Text = "Gestion des produits"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSuppProduit As Button
    Friend WithEvents btnScanner As Button
    Friend WithEvents lstBxPrix As ListBox
    Friend WithEvents btnPayer As Button
    Friend WithEvents btnAjouterProduit As Button
    Friend WithEvents lstBxProduits As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPrixRestant As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPrix As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblErreurListe As Label
    Friend WithEvents pctBxReturn As PictureBox
    Friend WithEvents lstBxProduitsMag As ListBox
    Friend WithEvents lstBxCategorie As ListBox
    Friend WithEvents lstBxQuantite As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
End Class
