Imports System.IO 'importation de System.IO pour pouvoir utiliser l'écriture dans un fichier texte

'bouton écran de scan
Public Class AccueilTangscan
    Private Sub btnScannerProduit_Click(sender As Object, e As EventArgs) Handles btnScannerProduit.Click
        Hide()
        ChoixScan.Show()
    End Sub

    'bouton sortie de l'application
    Private Sub pctBxExit_Click(sender As Object, e As EventArgs) Handles pctBxExit.Click
        Dim result = MessageBox.Show(text:="Voulez-vous vraiment quitter ?",
                        caption:="Quitter ?",
                        buttons:=MessageBoxButtons.YesNo,
                        icon:=MessageBoxIcon.Hand)
        'si l'utilisateur clique sur 'Yes', l'application se ferme et le programme s'arrête
        If (result = DialogResult.Yes) Then
            Dispose() 'fermeture définitive
        End If
    End Sub

    'bouton pour accéder aux comptes
    Private Sub pctrBxCompte_Click(sender As Object, e As EventArgs) Handles pctrBxCompte.Click
        'affichage de l'écran de gestion des comptes
        Hide()
        comptesCoEtCr.Show()
    End Sub

    'bouton qui détermine si un compte est déjà connecté ou pas en entrée
    Private Sub lblCompte_Click(sender As Object, e As EventArgs) Handles lblCompte.Click
        If (comptesCoEtCr.btnLogIn.Enabled = True) Then 'si un compte n'est pas connecté, le bouton Se Déconnecter est indisponible
            comptesCoEtCr.btnLogOff.Enabled = False
            comptesCoEtCr.btnCréerCompteTangScan.Enabled = True
        ElseIf (comptesCoEtCr.btnLogOff.Enabled = True) Then 'si un compte est connecté, le bouton Se Connecter est indisponible
            comptesCoEtCr.btnLogIn.Enabled = False
            comptesCoEtCr.btnCréerCompteTangScan.Enabled = False
            comptesCoEtCr.txtBxCODEA.Enabled = False
        End If

        'affichage de l'écran des comptes
        Hide()
        comptesCoEtCr.Show()
    End Sub

    'bouton pour accéder à l'écran de gestion des listes
    Private Sub btnGérerListes_Click(sender As Object, e As EventArgs) Handles btnGérerListes.Click
        'lorsqu'on arrive sur l'écran de gestion de listes, aucune liste n'est selectionnée, les boutons pour gérer ces listes sont donc désactivés
        accueilProduits.btnPayer.Enabled = False
        accueilProduits.lstBxProduits.Enabled = False
        accueilProduits.btnAjouterProduit.Enabled = False
        accueilListes.lblPrix.Enabled = False
        accueilListes.lblPrixRestant.Enabled = False
        accueilProduits.lstBxProduits.Enabled = False
        accueilListes.txtBxModifierList.Enabled = False
        accueilListes.btnModifierList.Enabled = False
        accueilProduits.lstBxProduits.Enabled = False
        accueilListes.btnSuppListe.Enabled = False
        accueilProduits.btnSuppProduit.Enabled = False
        accueilListes.btnPartager.Enabled = False
        accueilProduits.btnScanner.Enabled = False
        accueilListes.btnGérerProduits.Enabled = False
        accueilListes.btnPayerListe.Enabled = False
        accueilListes.lstBxListes.SelectedIndex = -1

        'nettoyer la listBox des prix et des produits
        accueilProduits.lstBxProduits.Items.Clear()
        accueilProduits.lstBxPrix.Items.Clear()

        'affichage de l'écran de gestion des listes
        Me.Hide()
        accueilListes.Show()
    End Sub

    'dès que l'on arrive sur le menu principal, ...
    Private Sub AccueilTangscan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '... il a création d'un fichier texte de tous les produits disponibles dans le magasin avec leur catégorie, descriptif, prix et code
        Dim swListeTousLesProduits As New StreamWriter(My.Application.Info.DirectoryPath & "\ListeDeTousLesProduits.txt")

        'pour chaque produit, affiché son nom, son prix et son code
        For j As Integer = 0 To ChoixScan.listeCategorie.Count - 1
            swListeTousLesProduits.WriteLine(vbCrLf & ChoixScan.listeCategorie(j).ToUpper)
            For x As Integer = 0 To ChoixScan.listProduitsEnr(j).Count - 1
                Dim prixProduitEcrire As String = ChoixScan.listPrixProduitsEnr(j)(x)
                swListeTousLesProduits.WriteLine(ChoixScan.listProduitsEnr(j)(x) + " - " + ChoixScan.codeListProduitsEnr(j)(x) + " - " + prixProduitEcrire + "€")
                swListeTousLesProduits.WriteLine("-> " + ChoixScan.listDescrProduitsEnr(j)(x))
            Next
        Next
        'fermeture et sauvegarde du fichier texte
        swListeTousLesProduits.Close()

        'pour chaque catégorie, affiché son nom dans les choix de produits dans l'écran de gestion des produits puisque les
        'catégories sont toujours les mêmes quelque soit la liste selectionnée
        For x As Integer = 0 To ChoixScan.listeCategorie.Count - 1
            accueilProduits.lstBxCategorie.Items.Add(ChoixScan.listeCategorie(x))
        Next
    End Sub
End Class
