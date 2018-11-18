<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ficheAdhérent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ficheAdhérent))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCode = New System.Windows.Forms.Label()
        Me.lblNom = New System.Windows.Forms.Label()
        Me.grpBxInfosAdh = New System.Windows.Forms.GroupBox()
        Me.pctBxReturn = New System.Windows.Forms.PictureBox()
        Me.grpBxInfosAdh.SuspendLayout()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Votre nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(186, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Votre code Adhérent"
        '
        'lblCode
        '
        Me.lblCode.AutoSize = True
        Me.lblCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCode.Location = New System.Drawing.Point(7, 220)
        Me.lblCode.Name = "lblCode"
        Me.lblCode.Size = New System.Drawing.Size(105, 24)
        Me.lblCode.TabIndex = 2
        Me.lblCode.Text = "labelCode"
        '
        'lblNom
        '
        Me.lblNom.AutoSize = True
        Me.lblNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNom.Location = New System.Drawing.Point(7, 94)
        Me.lblNom.Name = "lblNom"
        Me.lblNom.Size = New System.Drawing.Size(99, 24)
        Me.lblNom.TabIndex = 5
        Me.lblNom.Text = "labelNom"
        '
        'grpBxInfosAdh
        '
        Me.grpBxInfosAdh.Controls.Add(Me.Label2)
        Me.grpBxInfosAdh.Controls.Add(Me.lblCode)
        Me.grpBxInfosAdh.Controls.Add(Me.lblNom)
        Me.grpBxInfosAdh.Controls.Add(Me.Label1)
        Me.grpBxInfosAdh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBxInfosAdh.Location = New System.Drawing.Point(22, 75)
        Me.grpBxInfosAdh.Name = "grpBxInfosAdh"
        Me.grpBxInfosAdh.Size = New System.Drawing.Size(298, 255)
        Me.grpBxInfosAdh.TabIndex = 6
        Me.grpBxInfosAdh.TabStop = False
        Me.grpBxInfosAdh.Text = "Vos informations de compte"
        '
        'pctBxReturn
        '
        Me.pctBxReturn.Image = CType(resources.GetObject("pctBxReturn.Image"), System.Drawing.Image)
        Me.pctBxReturn.Location = New System.Drawing.Point(316, 454)
        Me.pctBxReturn.Name = "pctBxReturn"
        Me.pctBxReturn.Size = New System.Drawing.Size(32, 32)
        Me.pctBxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctBxReturn.TabIndex = 7
        Me.pctBxReturn.TabStop = False
        '
        'ficheAdhérent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 491)
        Me.Controls.Add(Me.pctBxReturn)
        Me.Controls.Add(Me.grpBxInfosAdh)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ficheAdhérent"
        Me.Text = "Vos informations"
        Me.grpBxInfosAdh.ResumeLayout(False)
        Me.grpBxInfosAdh.PerformLayout()
        CType(Me.pctBxReturn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCode As Label
    Friend WithEvents lblNom As Label
    Friend WithEvents grpBxInfosAdh As GroupBox
    Friend WithEvents pctBxReturn As PictureBox
End Class
