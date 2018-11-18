<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class payerUneListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(payerUneListe))
        Me.lblTitreListeAPayer = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPrix = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPayer = New System.Windows.Forms.Button()
        Me.pctBxReturn = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRemise = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lstBxProd = New System.Windows.Forms.ListBox()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitreListeAPayer
        '
        Me.lblTitreListeAPayer.AutoSize = True
        Me.lblTitreListeAPayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreListeAPayer.Location = New System.Drawing.Point(128, 10)
        Me.lblTitreListeAPayer.Name = "lblTitreListeAPayer"
        Me.lblTitreListeAPayer.Size = New System.Drawing.Size(111, 25)
        Me.lblTitreListeAPayer.TabIndex = 13
        Me.lblTitreListeAPayer.Text = "TitreListe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(190, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 24)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "€"
        '
        'lblPrix
        '
        Me.lblPrix.AutoSize = True
        Me.lblPrix.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPrix.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrix.Location = New System.Drawing.Point(142, 305)
        Me.lblPrix.Name = "lblPrix"
        Me.lblPrix.Size = New System.Drawing.Size(39, 24)
        Me.lblPrix.TabIndex = 16
        Me.lblPrix.Text = "--,--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(95, 237)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Prix total de la liste"
        '
        'btnPayer
        '
        Me.btnPayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPayer.Image = CType(resources.GetObject("btnPayer.Image"), System.Drawing.Image)
        Me.btnPayer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPayer.Location = New System.Drawing.Point(98, 345)
        Me.btnPayer.Name = "btnPayer"
        Me.btnPayer.Padding = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.btnPayer.Size = New System.Drawing.Size(160, 58)
        Me.btnPayer.TabIndex = 18
        Me.btnPayer.Text = "Payer"
        Me.btnPayer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPayer.UseVisualStyleBackColor = True
        '
        'pctBxReturn
        '
        Me.pctBxReturn.Image = CType(resources.GetObject("pctBxReturn.Image"), System.Drawing.Image)
        Me.pctBxReturn.Location = New System.Drawing.Point(318, 456)
        Me.pctBxReturn.Name = "pctBxReturn"
        Me.pctBxReturn.Size = New System.Drawing.Size(30, 30)
        Me.pctBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxReturn.TabIndex = 19
        Me.pctBxReturn.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Liste des produits scannés"
        '
        'lblRemise
        '
        Me.lblRemise.AutoSize = True
        Me.lblRemise.Location = New System.Drawing.Point(68, 264)
        Me.lblRemise.Name = "lblRemise"
        Me.lblRemise.Size = New System.Drawing.Size(0, 13)
        Me.lblRemise.TabIndex = 21
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(98, 409)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'lstBxProd
        '
        Me.lstBxProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBxProd.FormattingEnabled = True
        Me.lstBxProd.ItemHeight = 20
        Me.lstBxProd.Location = New System.Drawing.Point(96, 65)
        Me.lstBxProd.Name = "lstBxProd"
        Me.lstBxProd.Size = New System.Drawing.Size(160, 164)
        Me.lstBxProd.TabIndex = 23
        '
        'payerUneListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 491)
        Me.Controls.Add(Me.lstBxProd)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblRemise)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pctBxReturn)
        Me.Controls.Add(Me.btnPayer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPrix)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTitreListeAPayer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "payerUneListe"
        Me.Text = "Payer une liste"
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitreListeAPayer As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPrix As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPayer As Button
    Friend WithEvents pctBxReturn As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRemise As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lstBxProd As ListBox
End Class
