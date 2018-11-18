<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class accueilListes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accueilListes))
        Me.lstBxListes = New System.Windows.Forms.ListBox()
        Me.grpBxNomListe = New System.Windows.Forms.GroupBox()
        Me.btnGérerProduits = New System.Windows.Forms.Button()
        Me.btnPayerListe = New System.Windows.Forms.Button()
        Me.btnPartager = New System.Windows.Forms.Button()
        Me.btnSuppListe = New System.Windows.Forms.Button()
        Me.btnAjouterListe = New System.Windows.Forms.Button()
        Me.txtBxNewNomListe = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPrixRestant = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPrix = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pctBxReturn = New System.Windows.Forms.PictureBox()
        Me.lblErreurListe = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnModifierList = New System.Windows.Forms.Button()
        Me.txtBxModifierList = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grpBxNomListe.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstBxListes
        '
        Me.lstBxListes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBxListes.FormattingEnabled = True
        Me.lstBxListes.HorizontalScrollbar = True
        Me.lstBxListes.ItemHeight = 18
        Me.lstBxListes.Location = New System.Drawing.Point(20, 18)
        Me.lstBxListes.Name = "lstBxListes"
        Me.lstBxListes.Size = New System.Drawing.Size(191, 166)
        Me.lstBxListes.TabIndex = 0
        '
        'grpBxNomListe
        '
        Me.grpBxNomListe.Controls.Add(Me.btnGérerProduits)
        Me.grpBxNomListe.Controls.Add(Me.btnPayerListe)
        Me.grpBxNomListe.Controls.Add(Me.btnPartager)
        Me.grpBxNomListe.Controls.Add(Me.btnSuppListe)
        Me.grpBxNomListe.Controls.Add(Me.btnAjouterListe)
        Me.grpBxNomListe.Controls.Add(Me.txtBxNewNomListe)
        Me.grpBxNomListe.Controls.Add(Me.lstBxListes)
        Me.grpBxNomListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBxNomListe.Location = New System.Drawing.Point(49, 12)
        Me.grpBxNomListe.Name = "grpBxNomListe"
        Me.grpBxNomListe.Size = New System.Drawing.Size(271, 255)
        Me.grpBxNomListe.TabIndex = 1
        Me.grpBxNomListe.TabStop = False
        Me.grpBxNomListe.Text = "Listes"
        '
        'btnGérerProduits
        '
        Me.btnGérerProduits.BackColor = System.Drawing.Color.White
        Me.btnGérerProduits.Image = CType(resources.GetObject("btnGérerProduits.Image"), System.Drawing.Image)
        Me.btnGérerProduits.Location = New System.Drawing.Point(226, 18)
        Me.btnGérerProduits.Margin = New System.Windows.Forms.Padding(0)
        Me.btnGérerProduits.Name = "btnGérerProduits"
        Me.btnGérerProduits.Size = New System.Drawing.Size(34, 34)
        Me.btnGérerProduits.TabIndex = 24
        Me.btnGérerProduits.UseVisualStyleBackColor = False
        '
        'btnPayerListe
        '
        Me.btnPayerListe.BackColor = System.Drawing.Color.White
        Me.btnPayerListe.Image = CType(resources.GetObject("btnPayerListe.Image"), System.Drawing.Image)
        Me.btnPayerListe.Location = New System.Drawing.Point(226, 75)
        Me.btnPayerListe.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPayerListe.Name = "btnPayerListe"
        Me.btnPayerListe.Size = New System.Drawing.Size(34, 34)
        Me.btnPayerListe.TabIndex = 23
        Me.btnPayerListe.UseVisualStyleBackColor = False
        '
        'btnPartager
        '
        Me.btnPartager.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPartager.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPartager.Image = CType(resources.GetObject("btnPartager.Image"), System.Drawing.Image)
        Me.btnPartager.Location = New System.Drawing.Point(226, 190)
        Me.btnPartager.Margin = New System.Windows.Forms.Padding(3, 10, 0, 3)
        Me.btnPartager.Name = "btnPartager"
        Me.btnPartager.Size = New System.Drawing.Size(34, 33)
        Me.btnPartager.TabIndex = 0
        Me.btnPartager.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPartager.UseVisualStyleBackColor = False
        '
        'btnSuppListe
        '
        Me.btnSuppListe.BackColor = System.Drawing.Color.Red
        Me.btnSuppListe.Image = CType(resources.GetObject("btnSuppListe.Image"), System.Drawing.Image)
        Me.btnSuppListe.Location = New System.Drawing.Point(226, 132)
        Me.btnSuppListe.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSuppListe.Name = "btnSuppListe"
        Me.btnSuppListe.Size = New System.Drawing.Size(34, 34)
        Me.btnSuppListe.TabIndex = 19
        Me.btnSuppListe.UseVisualStyleBackColor = False
        '
        'btnAjouterListe
        '
        Me.btnAjouterListe.BackColor = System.Drawing.Color.White
        Me.btnAjouterListe.Image = CType(resources.GetObject("btnAjouterListe.Image"), System.Drawing.Image)
        Me.btnAjouterListe.Location = New System.Drawing.Point(96, 216)
        Me.btnAjouterListe.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAjouterListe.Name = "btnAjouterListe"
        Me.btnAjouterListe.Size = New System.Drawing.Size(35, 34)
        Me.btnAjouterListe.TabIndex = 22
        Me.btnAjouterListe.UseVisualStyleBackColor = False
        '
        'txtBxNewNomListe
        '
        Me.txtBxNewNomListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxNewNomListe.Location = New System.Drawing.Point(42, 190)
        Me.txtBxNewNomListe.Name = "txtBxNewNomListe"
        Me.txtBxNewNomListe.Size = New System.Drawing.Size(149, 21)
        Me.txtBxNewNomListe.TabIndex = 21
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
        Me.GroupBox1.Location = New System.Drawing.Point(186, 273)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(156, 150)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Description"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 112)
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
        Me.lblPrixRestant.Location = New System.Drawing.Point(35, 112)
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
        Me.Label7.Size = New System.Drawing.Size(99, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Reste à payer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "€ (*)"
        '
        'lblPrix
        '
        Me.lblPrix.AutoSize = True
        Me.lblPrix.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPrix.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrix.Location = New System.Drawing.Point(35, 61)
        Me.lblPrix.Name = "lblPrix"
        Me.lblPrix.Size = New System.Drawing.Size(32, 18)
        Me.lblPrix.TabIndex = 5
        Me.lblPrix.Text = "--,--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Prix total de la liste"
        '
        'pctBxReturn
        '
        Me.pctBxReturn.Image = CType(resources.GetObject("pctBxReturn.Image"), System.Drawing.Image)
        Me.pctBxReturn.Location = New System.Drawing.Point(317, 454)
        Me.pctBxReturn.Name = "pctBxReturn"
        Me.pctBxReturn.Size = New System.Drawing.Size(30, 30)
        Me.pctBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxReturn.TabIndex = 4
        Me.pctBxReturn.TabStop = False
        '
        'lblErreurListe
        '
        Me.lblErreurListe.AutoSize = True
        Me.lblErreurListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErreurListe.Location = New System.Drawing.Point(6, 451)
        Me.lblErreurListe.Name = "lblErreurListe"
        Me.lblErreurListe.Size = New System.Drawing.Size(0, 16)
        Me.lblErreurListe.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(2, 476)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 12)
        Me.Label8.TabIndex = 7
        '
        'btnModifierList
        '
        Me.btnModifierList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModifierList.Location = New System.Drawing.Point(35, 79)
        Me.btnModifierList.Name = "btnModifierList"
        Me.btnModifierList.Size = New System.Drawing.Size(100, 42)
        Me.btnModifierList.TabIndex = 12
        Me.btnModifierList.Text = "Modifier"
        Me.btnModifierList.UseVisualStyleBackColor = True
        '
        'txtBxModifierList
        '
        Me.txtBxModifierList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxModifierList.Location = New System.Drawing.Point(28, 41)
        Me.txtBxModifierList.Name = "txtBxModifierList"
        Me.txtBxModifierList.Size = New System.Drawing.Size(117, 20)
        Me.txtBxModifierList.TabIndex = 13
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnModifierList)
        Me.GroupBox4.Controls.Add(Me.txtBxModifierList)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(9, 273)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(171, 150)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Modifier une liste"
        '
        'accueilListes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 491)
        Me.Controls.Add(Me.lblErreurListe)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.pctBxReturn)
        Me.Controls.Add(Me.grpBxNomListe)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "accueilListes"
        Me.Text = "Listes de course"
        Me.grpBxNomListe.ResumeLayout(False)
        Me.grpBxNomListe.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBxListes As ListBox
    Friend WithEvents grpBxNomListe As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pctBxReturn As PictureBox
    Friend WithEvents lblErreurListe As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblPrix As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblPrixRestant As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnModifierList As Button
    Friend WithEvents txtBxModifierList As TextBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnSuppListe As Button
    Friend WithEvents btnAjouterListe As Button
    Friend WithEvents txtBxNewNomListe As TextBox
    Friend WithEvents btnPartager As Button
    Friend WithEvents btnPayerListe As Button
    Friend WithEvents btnGérerProduits As Button
End Class
