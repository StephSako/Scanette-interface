Imports System.IO

Public Class comptesCoEtCr
    'bouton de connexion à Google+
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pctrBxGoogle.Click
        'message d'avertissement (service non disponible)
        MessageBox.Show(text:="Vous ne pouvez pas utiliser cette fonction sur cet appareil.",
                        caption:="Fonction non disponible",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Hand)
    End Sub

    'bouton retour à l'écran d'accueil TangScan
    Private Sub pctBxReturn_Click(sender As Object, e As EventArgs) Handles pctBxReturn.Click
        'nettoyage des formulaires de saisie et des labels
        txtBxCODEA.Text = ""
        lblErreurCo.Text = ""

        'affichage de l'écran d'accueil
        Me.Hide()
        AccueilTangscan.Show()
    End Sub

    'bouton de connexion à Evernote
    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles pctrBxEvernote.Click
        'message d'avertissement (service non disponible)
        MessageBox.Show(text:="Vous ne pouvez pas utiliser cette fonction sur cet appareil.",
                        caption:="Fonction non disponible",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Hand)
    End Sub

    'bouton de connexion à OneNote
    Private Sub pctrBxOneNote_Click(sender As Object, e As EventArgs) Handles pctrBxOneNote.Click
        'message d'avertissement (service non disponible)
        MessageBox.Show(text:="Vous ne pouvez pas utiliser cette fonction sur cet appareil.",
                        caption:="Fonction non disponible",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Hand)
    End Sub

    'bouton d'affichage de l'écran d'accueil des comptes
    Private Sub btnCréerCompteTangScan_Click(sender As Object, e As EventArgs) Handles btnCréerCompteTangScan.Click
        'nettoyage des formulaires de saisie et des labels
        txtBxCODEA.Text = ""
        lblErreurCo.Text = ""

        'affichage de l'écran d'accueil des comptes
        Me.Hide()
        accueilCompte.Show()
    End Sub

    'bouton de connexion
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        'récupération de la saisie du champ de saisie du code Adhérent
        Dim saisieCODEco As String = txtBxCODEA.Text

        'recuperation de toutes les informaions de comptes
        Dim infosComptes() As String = File.ReadAllLines(My.Application.Info.DirectoryPath & "\comptes.txt")

        If (infosComptes.Count = 0) Then 'si aucun compte TangScan n'a été créé, l'utilisateur ne peut se connetcer
            'logiquement à aucun compte
            lblErreurCo.ForeColor = Color.DarkRed
            lblErreurCo.Text = ("Aucun compte TangScan n'a été" & Chr(13) & "créé sur cet appareil.")
        ElseIf (saisieCODEco.Length = 0) Then 'si l'utilisateur n'a rien saisi
            lblErreurCo.ForeColor = Color.Red
            lblErreurCo.Text = ("Saisissez votre code.")
        Else 'sinon il y a vérification 
            'création du compteur
            Dim i As Integer = 0
            Dim indCompteAd As Integer

            Dim verifInfoCo As Boolean = False

            'boucle pour verifier l'existence des informations
            While (i <= infosComptes.Count - 1)
                If (saisieCODEco = infosComptes(i)) Then 'si le code correspond à un déjà existant ...
                    verifInfoCo = True '... la saisie est correcte et un compte associé existe ...
                    indCompteAd = i '... et on récupère l'indice dans le tableau de codes
                    Exit While
                Else
                    verifInfoCo = False '... sinon la saisie est incorrecte
                End If
                i = i + 1
            End While

            If (verifInfoCo = False) Then 'si il n'y a pas de compte correspondant ...
                'nettoyage des champs de saisie
                txtBxCODEA.Text = ""

                '... il y a affichage d'une erreur de connexion
                lblErreurCo.ForeColor = Color.DarkOrange
                lblErreurCo.Text = ("Saisie non correcte.")
            ElseIf (verifInfoCo = True) Then

                'nettoyage des labels et champs de saisie
                txtBxCODEA.Text = ""
                lblErreurCo.Text = ""

                'affichage du nom et du code du compte assoié dans l'écran fiche Adhérent
                ficheAdhérent.lblNom.Text = infosComptes(indCompteAd - 1)
                ficheAdhérent.lblCode.Text = infosComptes(indCompteAd)

                btnLogOff.Enabled = True
                txtBxCODEA.Enabled = False
                btnLogIn.Enabled = False
                btnCréerCompteTangScan.Enabled = False

                'affichage de l'écran fiche Adhérent
                Me.Hide()
                ficheAdhérent.Show()
            End If
        End If
    End Sub

    'bouton de déconnection : actif que lorsqu'un compte est déjà actif
    Private Sub btnLogOff_Click(sender As Object, e As EventArgs) Handles btnLogOff.Click
        'initialisation des boutons
        btnLogOff.Enabled = False
        btnLogIn.Enabled = True
        txtBxCODEA.Enabled = True
        btnCréerCompteTangScan.Enabled = True
    End Sub
End Class