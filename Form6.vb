Imports System.IO

Public Class accueilCompte

    'bouton retour à l'écran de connexion des comptes
    Private Sub pctBxReturn_Click(sender As Object, e As EventArgs) Handles pctBxReturn.Click
        'nettoyage des labels et champs de saisie
        txtBxNOM.Text = ""
        txtBxCODE.Text = ""
        lblErreurSaisieCompte.Text = ""

        'affichage de l'écran de connexion des comptes
        Me.Hide()
        comptesCoEtCr.Show()
    End Sub

    'bouton valider la création d'un compte
    Private Sub pctBxValiderSaisie_Click(sender As Object, e As EventArgs) Handles pctBxValiderSaisie.Click
        'récupération des données saisies
        Dim saisieCODE As String = txtBxCODE.Text
        Dim saisieNOM As String = txtBxNOM.Text

        'vérification des saisies
        If (saisieNOM.Length = 0 And saisieCODE.Length <> 0) Then 'si le code est renseigné mais pas le nom
            lblErreurSaisieCompte.ForeColor = Color.Red
            lblErreurSaisieCompte.Text = ("Saisissez votre nom.")
        ElseIf (saisieNOM.Length <> 0 And saisieCODE.Length = 0) Then 'si le nom est renseigné mais pas le code
            lblErreurSaisieCompte.ForeColor = Color.Red
            lblErreurSaisieCompte.Text = ("Saisissez votre code.")
        ElseIf (saisieNOM.Length = 0 And saisieCODE.Length = 0) Then 'si aucun des champs ne sont renseignés
            lblErreurSaisieCompte.ForeColor = Color.Red
            lblErreurSaisieCompte.Text = ("Remplissez chaque formulaire.")
        Else 'si les deux information ont été saisies
            'création du compteur
            Dim i As Integer = 0

            'récupération des données du fichier texte des comptes dans un tableau
            Dim listeCompte() As String = File.ReadAllLines(My.Application.Info.DirectoryPath & "\comptes.txt")

            Dim verifInfoRed As Boolean

            'boucle pour verifier l'existence des informations
            While (i <= UBound(listeCompte))
                If (saisieCODE = listeCompte(i) Or saisieNOM = listeCompte(i)) Then 'si les deux informations correspondent AU MEME compte
                    verifInfoRed = True 'la saisie existe déjà
                    Exit While
                Else
                    verifInfoRed = False 'la saisie n'existe pas déjà
                End If
                i = i + 1
            End While

            If (verifInfoRed = False) Then 'si les informations ne correspondent à aucun compte
                'nettoyage des labels
                ficheAdhérent.lblNom.Text = ""
                ficheAdhérent.lblCode.Text = ""

                'ajout à la fin du fichier
                Using sw As StreamWriter = File.AppendText(My.Application.Info.DirectoryPath & "\comptes.txt")
                    sw.WriteLine(Chr(10))
                    sw.WriteLine(saisieNOM)
                    sw.WriteLine(saisieCODE)
                End Using

                'ajout des informations dans les tableaux de codes et de noms
                ficheAdhérent.lblNom.Text = saisieNOM
                ficheAdhérent.lblCode.Text = saisieCODE

                'nettoyage des labels et champs de saisie
                txtBxNOM.Text = ""
                txtBxCODE.Text = ""
                lblErreurSaisieCompte.Text = ""

                comptesCoEtCr.btnLogOff.Enabled = True
                comptesCoEtCr.txtBxCODEA.Enabled = False
                comptesCoEtCr.btnLogIn.Enabled = False
                comptesCoEtCr.btnCréerCompteTangScan.Enabled = False

                'affichage de la fiche Adhérent associée
                Me.Hide()
                ficheAdhérent.Show()
            ElseIf (verifInfoRed = True) Then 'si les informations saisies correspondent déjà à un autre compte
                'affichage du message d'erreur
                lblErreurSaisieCompte.ForeColor = Color.Orange
                lblErreurSaisieCompte.Text = "Ces informations existent déjà."

                'nettoyage des labels et champs de saisie
                txtBxNOM.Text = ""
                txtBxCODE.Text = ""
            End If
        End If
    End Sub
End Class