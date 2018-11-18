Public Class accueilProduits

    'bouton pour payer un seul produit selectionné
    Private Sub btnPayer_Click(sender As Object, e As EventArgs) Handles btnPayer.Click
        lblErreurListe.Text = ""
        accueilListes.txtBxNewNomListe.Text = ""
        lstBxProduitsMag.SelectedIndex = -1
        'booléen qui détermine si le produit a été scanné
        Dim prodScanné As Boolean = False

        If (accueilListes.listeProduitScan(accueilListes.lstBxListes.SelectedIndex)(lstBxProduits.SelectedIndex) = True) Then
            prodScanné = True 'si le produit a été scanné : ok
        ElseIf (accueilListes.listeProduitScan(accueilListes.lstBxListes.SelectedIndex)(lstBxProduits.SelectedIndex) = False) Then
            prodScanné = False 'si le produit n'a pas été scanné : pas ok
        End If

        If (prodScanné = True) Then 'si le produit a été scanné, le paiement est alors autorisé (plus de sécurité)
            'affichage du nom dans l'écran de paiement
            payerProduit.lblProduitPayé.Text = accueilListes.listeProduit(accueilListes.lstBxListes.SelectedIndex)(lstBxProduits.SelectedIndex)

            'affichage du prix dans l'écran de paiement
            Dim prixProduitAPayer As String = accueilListes.listePrix(accueilListes.lstBxListes.SelectedIndex)(lstBxProduits.SelectedIndex)
            payerProduit.lblPrixPayer.Text = prixProduitAPayer

            'affichage de l'écran de paiement du produit
            Me.Hide()
            payerProduit.Show()

        ElseIf (prodScanné = False) Then 'si le produit n'a pas été scanné ...
            '... affichage d'un message d'erreur
            MessageBox.Show(text:="Pour plus de sécurité, vous devez scanner ce produit afin de le payer.",
                        caption:="Produit non scanné",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Hand)
        End If
    End Sub

    'bouton d'affichage de l'écran de choix des scan
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnScanner.Click
        'nettoyage et initailisations des labels et autres
        lstBxProduits.Text = ""
        lblErreurListe.Text = ""
        accueilListes.txtBxNewNomListe.Text = ""
        lblPrix.Text = "--,--"
        lblPrixRestant.Text = "--,--"

        'deselectionner tous les items de listBoxProduits
        lstBxProduits.SelectedIndex = -1

        'nettoyer la listBox des prix
        lstBxPrix.Items.Clear()

        'affichage de l'écran de choix des scan
        Me.Hide()
        ChoixScan.Show()
    End Sub

    'bouton pour supprimer un produit
    Private Sub btnSuppProduit_Click(sender As Object, e As EventArgs) Handles btnSuppProduit.Click
        'recuperation des index du produit selectionné
        Dim rangListe As Integer = accueilListes.lstBxListes.SelectedIndex
        Dim nomListe As String = accueilListes.lstBxListes.SelectedItem.ToString
        Dim rangSuppProduit As Integer = lstBxProduits.SelectedIndex

        For j As Integer = rangSuppProduit To 9
            If (j < 9) Then 'si la liste n'est pas pleine ...
                '... on remplace l'item du dessous par celui du dessus
                accueilListes.listeProduit(rangListe)(j) = accueilListes.listeProduit(rangListe)(j + 1)
                accueilListes.listePrix(rangListe)(j) = accueilListes.listePrix(rangListe)(j + 1)
                accueilListes.listeProduitPayés(rangListe)(j) = accueilListes.listePrix(rangListe)(j + 1)
                accueilListes.listeProduitScan(rangListe)(j) = accueilListes.listeProduitScan(rangListe)(j + 1)
                accueilListes.listeQuantite(rangListe)(j) = accueilListes.listeQuantite(rangListe)(j + 1)

                '... suppression de l'item au dessus
                accueilListes.listeProduit(rangListe)(j + 1) = ""
                accueilListes.listePrix(rangListe)(j + 1) = 0
                accueilListes.listeProduitPayés(rangListe)(j + 1) = False
                accueilListes.listeProduitScan(rangListe)(j) = False
                accueilListes.listeQuantite(rangListe)(j) = 0
            ElseIf (j = 9) Then 'si la liste est pleine...
                ' ... on supprime juste le dernier item
                accueilListes.listeProduit(rangListe)(j) = ""
                accueilListes.listePrix(rangListe)(j) = 0
                accueilListes.listeProduitPayés(rangListe)(j) = False
                accueilListes.listeProduitScan(rangListe)(j) = False
                accueilListes.listeQuantite(rangListe)(j) = 0
            End If
        Next

        'suppression des noms dans la listBox
        lstBxProduits.Items.RemoveAt(rangSuppProduit)
        lstBxPrix.Items.RemoveAt(rangSuppProduit)
        lstBxQuantite.Items.RemoveAt(rangSuppProduit)

        'addition des prix du nouveau produit avec les autres
        Dim sommePrix As Double
        Dim sommePrixRestant As Double = 0

        'addition des prix du nouveau produit avec les autres
        For x As Integer = 0 To accueilListes.nbProd()
            'prix total
            sommePrix = sommePrix + accueilListes.listePrix(accueilListes.lstBxListes.SelectedIndex)(x)

            'vérifier au cas ou on ajouterai un produit apres avoir payé un article, il faut mettre a jour le prix restant
            If (accueilListes.produitPayé(x) = False) Then 'si le produit n'est pas payé on additionne son prix
                'addition de chaque prix des produits de la liste sélectionnée
                sommePrixRestant = sommePrixRestant + accueilListes.listePrix(accueilListes.lstBxListes.SelectedIndex)(x)
            ElseIf (accueilListes.produitPayé(x) = True) Then
                sommePrixRestant = sommePrixRestant + 0
            End If
        Next

        'affichage des prix
        lblPrix.Text = sommePrix
        lblPrixRestant.Text = sommePrixRestant

        'mise à jour des prix dans l'écran de gestion des listes
        accueilListes.lblPrix.Text = sommePrix
        accueilListes.lblPrixRestant.Text = sommePrixRestant

        'si la liste est payée après la suppression du produit, il y a mise à jour de son nom avec un "checked" ajouté devant son nom
        Dim nomListe2 As String = accueilListes.lstBxListes.SelectedItem.ToString
        If (accueilListes.listeTotPayée() = False And accueilListes.nbProdPayés() = accueilListes.nbProd() And accueilListes.nbProd() > 0) Then
            Dim nb As Integer = accueilListes.lstBxListes.SelectedIndex
            accueilListes.lstBxListes.Items.RemoveAt(accueilListes.lstBxListes.SelectedIndex)
            accueilListes.lstBxListes.Items.Insert(nb, "√ " + nomListe2)
        End If
        'le bouton supprimer est donc indisponible
        btnSuppProduit.Enabled = False
    End Sub

    'listeBox : déterminer l'enabled de chaque bouton en fonction de l'êtat de paimement du produit selectionné
    Private Sub lstBxProduits_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBxProduits.SelectedIndexChanged
        btnScanner.Enabled = True

        If (lstBxProduits.SelectedIndex <> -1) Then 'si aucun produit n'est selectionné

            'si le produit selectionné est payé
            If (accueilListes.listeProduitPayés(accueilListes.lstBxListes.SelectedIndex)(lstBxProduits.SelectedIndex) = True) Then
                btnSuppProduit.Enabled = False
                btnPayer.Enabled = False
            Else
                btnSuppProduit.Enabled = True
                btnPayer.Enabled = True
            End If
        Else
            btnSuppProduit.Enabled = False
            btnPayer.Enabled = False
        End If
    End Sub

    'bouton pour ajouter un produit à notre liste de course
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouterProduit.Click
        Dim nomProduitAjout As String = lstBxProduitsMag.SelectedItem.ToString
        Dim rangPrix As Integer = 0
        Dim sommePrix As Double = 0
        Dim sommePrixRestant As Double = 0
        lstBxProduits.SelectedIndex = -1
        Dim listePleine As Boolean = (accueilListes.nbProd() = 10)
        Dim verifExistProduit As Boolean = False

        If (listePleine <> True) Then 'si la liste est pleine
            'verification si le produit existe déjà ou pas dans la liste des produits saisie par l'utilisateur
            If (accueilListes.nbProd() <> 0) Then
                For x As Integer = 0 To accueilListes.nbProd() - 1
                    If (accueilListes.listeProduit(accueilListes.lstBxListes.SelectedIndex)(x) = nomProduitAjout) Then
                        verifExistProduit = True
                        Exit For
                    Else
                        verifExistProduit = False
                    End If
                Next
            End If

            If (verifExistProduit = False) Then 'il n'existe pas
                Dim prixProduit As Double = ChoixScan.listPrixProduitsEnr(lstBxCategorie.SelectedIndex)(lstBxProduitsMag.SelectedIndex)

                'affichage dans la listBox
                lstBxProduits.Items.Add(nomProduitAjout)
                lstBxPrix.Items.Add(prixProduit)
                Dim quantiteDeBase As Integer = 1
                lstBxQuantite.Items.Add(quantiteDeBase)
                'ajout dans la liste de produit
                accueilListes.listeProduit(accueilListes.lstBxListes.SelectedIndex)(accueilListes.nbProd()) = nomProduitAjout
                'ajout du prix du produit dans la liste des prix
                accueilListes.listePrix(accueilListes.lstBxListes.SelectedIndex)(accueilListes.nbProd() - 1) = prixProduit
                'ajout de la quantité du produit dans la liste des quantités
                accueilListes.listeQuantite(accueilListes.lstBxListes.SelectedIndex)(accueilListes.nbProd() - 1) = quantiteDeBase

                'addition des prix du nouveau produit avec les autres
                For x As Integer = 0 To accueilListes.nbProd()
                    'prix total
                    sommePrix = sommePrix + accueilListes.listePrix(accueilListes.lstBxListes.SelectedIndex)(x)

                    'vérifier au cas ou on ajouterai un produit apres avoir payé un article, il faut mettre a jour le prix restant
                    If (accueilListes.produitPayé(x) = False) Then 'si le produit n'est pas payé on additionne son prix
                        'addition de chaque prix des produits de la liste sélectionnée
                        sommePrixRestant = sommePrixRestant + accueilListes.listePrix(accueilListes.lstBxListes.SelectedIndex)(x)
                    ElseIf (accueilListes.produitPayé(x) = True) Then
                        sommePrixRestant = sommePrixRestant + 0
                    End If
                Next
                'affichage des prix
                lblPrix.Text = sommePrix
                lblPrixRestant.Text = sommePrixRestant
                accueilListes.lblPrix.Text = sommePrix
                accueilListes.lblPrixRestant.Text = sommePrixRestant

                'nettoyage des formulaires
                lstBxProduitsMag.SelectedIndex = -1
                lblErreurListe.Text = ""

                'si une liste est deja entierement payée, il faut changer son nom car elle n'est donc plus
                'entièrement payée
                Dim nomListe As String = accueilListes.lstBxListes.SelectedItem.ToString
                If (Mid(nomListe, 1, 1) = "√") Then
                    Dim nb As Integer = accueilListes.lstBxListes.SelectedIndex
                    accueilListes.lstBxListes.Items.RemoveAt(accueilListes.lstBxListes.SelectedIndex)
                    accueilListes.lstBxListes.Items.Insert(nb, Mid(nomListe, 3))
                End If

            ElseIf (verifExistProduit = True) Then 'il existe
                'affichage de l'erreur
                lblErreurListe.ForeColor = Color.Orange
                lblErreurListe.Text = "Ce produit existe déjà."
                lstBxProduitsMag.SelectedIndex = -1
            End If
        ElseIf (listePleine = True) Then 'si la liste est pleine
            lblErreurListe.ForeColor = Color.Red
            lblErreurListe.Text = "Liste pleine."
        End If
    End Sub

    'à l'arrivée sur cet écran, les listbox des prix et des quantités sont inselectionnables ... parce qu'il 
    'n'y a rien à selectionner
    Private Sub accueilProduits_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstBxPrix.Enabled = False
        lstBxQuantite.Enabled = False
    End Sub

    'bouton retour à l'écran de gestion des listes
    Private Sub pctBxReturn_Click(sender As Object, e As EventArgs) Handles pctBxReturn.Click
        'nettoyage et initalisations des labels et autres
        lstBxProduits.Text = ""
        lstBxProduitsMag.SelectedIndex = -1
        lstBxProduits.SelectedIndex = -1
        accueilListes.lstBxListes.SelectedIndex = -1
        accueilListes.txtBxModifierList.Enabled = False
        accueilListes.btnModifierList.Enabled = False
        accueilListes.btnSuppListe.Enabled = False
        accueilListes.btnPartager.Enabled = False
        accueilListes.btnPartager.Enabled = False
        accueilListes.btnGérerProduits.Enabled = False

        'affichage de l'écran de gestion des listes
        Me.Hide()
        accueilListes.Show()
    End Sub

    'affichage de chaque produit pour chaque catégories de produits
    Private Sub lstBxCategorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBxCategorie.SelectedIndexChanged
        lstBxProduitsMag.Items.Clear()

        If (lstBxCategorie.SelectedIndex = -1) Then
            lstBxProduitsMag.Enabled = False
        Else 'si la liste est selectionnée, il y a affchage de ses produits
            For x As Integer = 0 To ChoixScan.listProduitsEnr(lstBxCategorie.SelectedIndex).Count - 1
                lstBxProduitsMag.Items.Add(ChoixScan.listProduitsEnr(lstBxCategorie.SelectedIndex)(x))
            Next
            lstBxProduitsMag.Enabled = True
        End If
    End Sub

    'si un produit est selectionné, on peut alors l'ajouter
    Private Sub lstBxProduitsMag_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBxProduitsMag.SelectedIndexChanged
        If (lstBxProduitsMag.SelectedIndex = -1) Then
            btnAjouterProduit.Enabled = False
        ElseIf (lstBxProduitsMag.SelectedIndex <> -1) Then
            btnAjouterProduit.Enabled = True
        End If
    End Sub
End Class