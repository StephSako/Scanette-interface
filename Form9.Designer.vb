<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payerProduit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payerProduit))
        Me.btnPayer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblProduitPayé = New System.Windows.Forms.Label()
        Me.lblPrixPayer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pctBxReturn = New System.Windows.Forms.PictureBox()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPayer
        '
        Me.btnPayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayer.Image = CType(resources.GetObject("btnPayer.Image"), System.Drawing.Image)
        Me.btnPayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayer.Location = New System.Drawing.Point(100, 327)
        Me.btnPayer.Name = "btnPayer"
        Me.btnPayer.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.btnPayer.Size = New System.Drawing.Size(151, 58)
        Me.btnPayer.TabIndex = 0
        Me.btnPayer.Text = "Payer"
        Me.btnPayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Produit à payer"
        '
        'lblProduitPayé
        '
        Me.lblProduitPayé.AutoSize = True
        Me.lblProduitPayé.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProduitPayé.Location = New System.Drawing.Point(121, 158)
        Me.lblProduitPayé.Name = "lblProduitPayé"
        Me.lblProduitPayé.Size = New System.Drawing.Size(107, 24)
        Me.lblProduitPayé.TabIndex = 2
        Me.lblProduitPayé.Text = "nomProduit"
        '
        'lblPrixPayer
        '
        Me.lblPrixPayer.AutoSize = True
        Me.lblPrixPayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrixPayer.Location = New System.Drawing.Point(120, 203)
        Me.lblPrixPayer.Name = "lblPrixPayer"
        Me.lblPrixPayer.Size = New System.Drawing.Size(109, 24)
        Me.lblPrixPayer.TabIndex = 3
        Me.lblPrixPayer.Text = "lblPrixPayer"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(181, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "€"
        '
        'pctBxReturn
        '
        Me.pctBxReturn.Image = CType(resources.GetObject("pctBxReturn.Image"), System.Drawing.Image)
        Me.pctBxReturn.Location = New System.Drawing.Point(318, 456)
        Me.pctBxReturn.Name = "pctBxReturn"
        Me.pctBxReturn.Size = New System.Drawing.Size(30, 30)
        Me.pctBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxReturn.TabIndex = 5
        Me.pctBxReturn.TabStop = False
        '
        'payerProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 491)
        Me.Controls.Add(Me.pctBxReturn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPrixPayer)
        Me.Controls.Add(Me.lblProduitPayé)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPayer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "payerProduit"
        Me.Text = "Payer un produit"
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPayer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblProduitPayé As Label
    Friend WithEvents lblPrixPayer As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pctBxReturn As PictureBox
End Class
