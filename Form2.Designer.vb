<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChoixScan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChoixScan))
        Me.lblTitreChoixScan = New System.Windows.Forms.Label()
        Me.btnScanAuto = New System.Windows.Forms.Button()
        Me.pnlSaisie = New System.Windows.Forms.Panel()
        Me.pctBxValiderSaisie = New System.Windows.Forms.PictureBox()
        Me.lblSaisie = New System.Windows.Forms.Label()
        Me.txtBxSaisieScan = New System.Windows.Forms.TextBox()
        Me.pctBxReturn = New System.Windows.Forms.PictureBox()
        Me.lblTxtErreur = New System.Windows.Forms.Label()
        Me.GererLesListes = New System.Windows.Forms.Button()
        Me.pnlSaisie.SuspendLayout()
        CType(Me.pctBxValiderSaisie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitreChoixScan
        '
        Me.lblTitreChoixScan.AutoSize = True
        Me.lblTitreChoixScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitreChoixScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreChoixScan.Location = New System.Drawing.Point(32, 56)
        Me.lblTitreChoixScan.Name = "lblTitreChoixScan"
        Me.lblTitreChoixScan.Size = New System.Drawing.Size(288, 31)
        Me.lblTitreChoixScan.TabIndex = 0
        Me.lblTitreChoixScan.Text = "Que voulez-vous faire ?"
        '
        'btnScanAuto
        '
        Me.btnScanAuto.BackColor = System.Drawing.Color.White
        Me.btnScanAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnScanAuto.Image = CType(resources.GetObject("btnScanAuto.Image"), System.Drawing.Image)
        Me.btnScanAuto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnScanAuto.Location = New System.Drawing.Point(45, 129)
        Me.btnScanAuto.Name = "btnScanAuto"
        Me.btnScanAuto.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btnScanAuto.Size = New System.Drawing.Size(265, 100)
        Me.btnScanAuto.TabIndex = 1
        Me.btnScanAuto.Text = "Scan automatique"
        Me.btnScanAuto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnScanAuto.UseVisualStyleBackColor = False
        '
        'pnlSaisie
        '
        Me.pnlSaisie.BackColor = System.Drawing.Color.White
        Me.pnlSaisie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlSaisie.Controls.Add(Me.pctBxValiderSaisie)
        Me.pnlSaisie.Controls.Add(Me.lblSaisie)
        Me.pnlSaisie.Controls.Add(Me.txtBxSaisieScan)
        Me.pnlSaisie.Location = New System.Drawing.Point(45, 271)
        Me.pnlSaisie.Name = "pnlSaisie"
        Me.pnlSaisie.Size = New System.Drawing.Size(265, 145)
        Me.pnlSaisie.TabIndex = 2
        '
        'pctBxValiderSaisie
        '
        Me.pctBxValiderSaisie.BackColor = System.Drawing.Color.Transparent
        Me.pctBxValiderSaisie.Image = CType(resources.GetObject("pctBxValiderSaisie.Image"), System.Drawing.Image)
        Me.pctBxValiderSaisie.Location = New System.Drawing.Point(109, 97)
        Me.pctBxValiderSaisie.Name = "pctBxValiderSaisie"
        Me.pctBxValiderSaisie.Size = New System.Drawing.Size(41, 41)
        Me.pctBxValiderSaisie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxValiderSaisie.TabIndex = 4
        Me.pctBxValiderSaisie.TabStop = False
        '
        'lblSaisie
        '
        Me.lblSaisie.AutoSize = True
        Me.lblSaisie.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaisie.Location = New System.Drawing.Point(7, 23)
        Me.lblSaisie.Name = "lblSaisie"
        Me.lblSaisie.Size = New System.Drawing.Size(248, 18)
        Me.lblSaisie.TabIndex = 1
        Me.lblSaisie.Text = "Saisie manuelle du code produit"
        '
        'txtBxSaisieScan
        '
        Me.txtBxSaisieScan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxSaisieScan.Location = New System.Drawing.Point(97, 60)
        Me.txtBxSaisieScan.MaxLength = 6
        Me.txtBxSaisieScan.Name = "txtBxSaisieScan"
        Me.txtBxSaisieScan.Size = New System.Drawing.Size(63, 26)
        Me.txtBxSaisieScan.TabIndex = 0
        '
        'pctBxReturn
        '
        Me.pctBxReturn.BackColor = System.Drawing.SystemColors.Control
        Me.pctBxReturn.Image = CType(resources.GetObject("pctBxReturn.Image"), System.Drawing.Image)
        Me.pctBxReturn.Location = New System.Drawing.Point(318, 455)
        Me.pctBxReturn.Name = "pctBxReturn"
        Me.pctBxReturn.Size = New System.Drawing.Size(32, 32)
        Me.pctBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxReturn.TabIndex = 3
        Me.pctBxReturn.TabStop = False
        '
        'lblTxtErreur
        '
        Me.lblTxtErreur.AutoSize = True
        Me.lblTxtErreur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxtErreur.Location = New System.Drawing.Point(88, 425)
        Me.lblTxtErreur.Name = "lblTxtErreur"
        Me.lblTxtErreur.Size = New System.Drawing.Size(11, 13)
        Me.lblTxtErreur.TabIndex = 5
        Me.lblTxtErreur.Text = " "
        Me.lblTxtErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GererLesListes
        '
        Me.GererLesListes.BackColor = System.Drawing.Color.White
        Me.GererLesListes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GererLesListes.Image = CType(resources.GetObject("GererLesListes.Image"), System.Drawing.Image)
        Me.GererLesListes.Location = New System.Drawing.Point(4, 447)
        Me.GererLesListes.Name = "GererLesListes"
        Me.GererLesListes.Size = New System.Drawing.Size(40, 40)
        Me.GererLesListes.TabIndex = 12
        Me.GererLesListes.UseVisualStyleBackColor = False
        '
        'ChoixScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 491)
        Me.Controls.Add(Me.GererLesListes)
        Me.Controls.Add(Me.lblTxtErreur)
        Me.Controls.Add(Me.pctBxReturn)
        Me.Controls.Add(Me.pnlSaisie)
        Me.Controls.Add(Me.btnScanAuto)
        Me.Controls.Add(Me.lblTitreChoixScan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChoixScan"
        Me.Text = "Scanner un produit"
        Me.pnlSaisie.ResumeLayout(False)
        Me.pnlSaisie.PerformLayout()
        CType(Me.pctBxValiderSaisie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitreChoixScan As Label
    Friend WithEvents btnScanAuto As Button
    Friend WithEvents pnlSaisie As Panel
    Friend WithEvents lblSaisie As Label
    Friend WithEvents txtBxSaisieScan As TextBox
    Friend WithEvents pctBxReturn As PictureBox
    Friend WithEvents pctBxValiderSaisie As PictureBox
    Friend WithEvents lblTxtErreur As Label
    Friend WithEvents GererLesListes As Button
End Class
