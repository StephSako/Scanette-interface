<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class accueilCompte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(accueilCompte))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pctBxValiderSaisie = New System.Windows.Forms.PictureBox()
        Me.txtBxNOM = New System.Windows.Forms.TextBox()
        Me.txtBxCODE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pctBxReturn = New System.Windows.Forms.PictureBox()
        Me.lblErreurSaisieCompte = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pctBxValiderSaisie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.pctBxValiderSaisie)
        Me.GroupBox1.Controls.Add(Me.txtBxNOM)
        Me.GroupBox1.Controls.Add(Me.txtBxCODE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 281)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Créer un compte TangScan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(78, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Entrez votre NOM"
        '
        'pctBxValiderSaisie
        '
        Me.pctBxValiderSaisie.BackColor = System.Drawing.Color.Transparent
        Me.pctBxValiderSaisie.Image = CType(resources.GetObject("pctBxValiderSaisie.Image"), System.Drawing.Image)
        Me.pctBxValiderSaisie.Location = New System.Drawing.Point(137, 231)
        Me.pctBxValiderSaisie.Name = "pctBxValiderSaisie"
        Me.pctBxValiderSaisie.Size = New System.Drawing.Size(41, 41)
        Me.pctBxValiderSaisie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxValiderSaisie.TabIndex = 5
        Me.pctBxValiderSaisie.TabStop = False
        '
        'txtBxNOM
        '
        Me.txtBxNOM.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBxNOM.Location = New System.Drawing.Point(49, 175)
        Me.txtBxNOM.Name = "txtBxNOM"
        Me.txtBxNOM.Size = New System.Drawing.Size(221, 22)
        Me.txtBxNOM.TabIndex = 3
        '
        'txtBxCODE
        '
        Me.txtBxCODE.Location = New System.Drawing.Point(51, 78)
        Me.txtBxCODE.Name = "txtBxCODE"
        Me.txtBxCODE.Size = New System.Drawing.Size(219, 22)
        Me.txtBxCODE.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Saisissez votre code adhérent"
        '
        'pctBxReturn
        '
        Me.pctBxReturn.Image = CType(resources.GetObject("pctBxReturn.Image"), System.Drawing.Image)
        Me.pctBxReturn.Location = New System.Drawing.Point(316, 454)
        Me.pctBxReturn.Name = "pctBxReturn"
        Me.pctBxReturn.Size = New System.Drawing.Size(32, 32)
        Me.pctBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxReturn.TabIndex = 6
        Me.pctBxReturn.TabStop = False
        '
        'lblErreurSaisieCompte
        '
        Me.lblErreurSaisieCompte.AutoSize = True
        Me.lblErreurSaisieCompte.Location = New System.Drawing.Point(48, 402)
        Me.lblErreurSaisieCompte.Name = "lblErreurSaisieCompte"
        Me.lblErreurSaisieCompte.Size = New System.Drawing.Size(0, 13)
        Me.lblErreurSaisieCompte.TabIndex = 7
        '
        'accueilCompte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 491)
        Me.Controls.Add(Me.lblErreurSaisieCompte)
        Me.Controls.Add(Me.pctBxReturn)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "accueilCompte"
        Me.Text = "Créer un compte TangScan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pctBxValiderSaisie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBxNOM As TextBox
    Friend WithEvents txtBxCODE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents pctBxValiderSaisie As PictureBox
    Friend WithEvents pctBxReturn As PictureBox
    Friend WithEvents lblErreurSaisieCompte As Label
End Class
