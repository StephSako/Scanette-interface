Public Class ficheProduit

    'recuperer la taille de la liste selectionnée dans le comboBox en se servant de la liste Produit de la Form accueilListes
    Function nbProd() As Integer
        'recuperer l'indice du dernier emplacement de produit vide || taille effective
        Dim taille As Integer = 0

        'compter tous les produits QUI ONT ETE SAISIS (le tableau a déjà alloué des string vides, il faut donc
        'compter la taille relative du tableau
        For i As Integer = 0 To accueilListes.listeProduit(cmbBxListeAjout.SelectedIndex).Count - 1
            If (accueilListes.listeProduit(cmbBxListeAjout.SelectedIndex)(i) <> "") Then
                taille = taille + 1
            End If
        Next

        'la fonction retourne le nombre de produits de la liste selectionnée dans la comboBox
        Return taille
    End Function

    'compter tous les produits QUI ONT ETE SCANNES (le tableau a déjà alloué des string vides, il faut donc
    'compter la taille relative du tableau
    Function nbProdScan() As Integer
        'recuperer l'indice du dernier emplacement de produit vide || taille effective
        Dim taille As Integer = 0

        For i As Integer = 0 To accueilListes.listeProduit(cmbBxListeAjout.SelectedIndex).Count - 1
            If (accueilListes.listeProduitScan(cmbBxListeAjout.SelectedIndex)(i) = True) Then
                taille = taille + 1
            End If
        Next

        Return taille 'retourne la nombre de produits scannés dans la liste selectionnée dans le ComboBox
    End Function

    'trackbar valuée de la quantité de produits voulus
    Private Sub trckBrQuantité_Scroll(sender As Object, e As EventArgs) Handles trckBrQuantité.Scroll
        'affichage de la valeur de la trackbar
        lblValeurTrckBr.Text = trckBrQuantité.Value
        'affichage du prix en fonction de la quantité et du prix unitiare
        Dim valeurPrix As Double = lblPrixProduit.Text
        lblPrixQuantité.Text = (trckBrQuantité.Value * valeurPrix)
    End Sub

    'bouton retour à l'écran de choix du scan
    Private Sub pctBxReturn_Click(sender As Object, e As EventArgs) Handles pctBxReturn.Click
        'nettoyage et initialisations des labels et autres
        trckBrQuantité.Value = 1
        lblPrixQuantité.Text = " - -,--"
        lblValeurTrckBr.Text = trckBrQuantité.Value
        lblErreur.Text = ""

        'affichage de l'écran de choix de scan
        Me.Hide()
        ChoixScan.Show()
    End Sub

    'bouton d'ajout d'un produit
    Private Sub btnAjouterProduit_Click(sender As Object, e As EventArgs) Handles btnAjouterProduit.Click
        Dim nb As Integer
        Dim rangPrixP As Integer

        If (cmbBxListeAjout.SelectedIndex <> -1) Then 'si aucune liste n'est selectionnée
            If (nbProd() < 10) Then 'si la liste n'est pas encore pleine
                For x As Integer = 0 To 9
                    'si le produit a déjà été payé :
                    If (lblNomProduit.Text = Mid(accueilListes.listeProduit(cmbBxListeAjout.SelectedIndex)(x), 3) And Mid(accueilListes.listeProduit(cmbBxListeAjout.SelectedIndex)(x), 1, 1) = "√") Then
                        nb = 5
                        Exit For
                        'si le produit a été scanné, il a mise à jour du prix et de la quantité :
                    ElseIf (lblNomProduit.Text = accueilListes.listeProduit(cmbBxListeAjout.SelectedIndex)(x)) Then
                        nb = 1
                        rangPrixP = x
                        Exit For
                        'si le produit n'a pas été scanné ni payé, il est alors ajouté à la liste de produits :
                    ElseIf (lblNomProduit.Text <> accueilListes.listeProduit(cmbBxListeAjout.SelectedIndex)(x)) Then
                        nb = 2
                    End If
                Next
            Else
                nb = 3
            End If
        Else
            nb = 4
        End If

        Dim prix As Double = lblPrixProduit.Text
        Dim quantite As Integer = trckBrQuantité.Value
        lblPrixQuantité.Text = prix * quantite
        Dim prixQuantite As Double = lblPrixQuantité.Text
        If (nb = 5) Then
            lblErreur.ForeColor = Color.Red
            lblErreur.Text = "Produit existant déjà payé."
        ElseIf (nb = 1) Then
            'remplacer le prix par quantité * prix
            accueilListes.listePrix(cmbBxListeAjout.SelectedIndex)(rangPrixP) = prixQuantite
            accueilListes.listeQuantite(cmbBxListeAjout.SelectedIndex)(rangPrixP) = quantite
            accueilListes.listeProduitScan(cmbBxListeAjout.SelectedIndex)(rangPrixP) = True
            lblErreur.ForeColor = Color.Green
            lblErreur.Text = "Produit existant mis à jour."
        ElseIf (nb = 2) Then
            'ajout dans la liste de produit
            accueilListes.listeProduit(cmbBxListeAjout.SelectedIndex)(nbProd()) = lblNomProduit.Text
            'le produit devient donc scanné
            accueilListes.listeProduitScan(cmbBxListeAjout.SelectedIndex)(nbProd() - 1) = True
            'ajout du prix du produit dans la liste des prix
            accueilListes.listePrix(cmbBxListeAjout.SelectedIndex)(nbProd() - 1) = prixQuantite
            'ajout de la quantité du produit dans la liste des quantités
            accueilListes.listeQuantite(cmbBxListeAjout.SelectedIndex)(nbProd() - 1) = quantite
            lblErreur.ForeColor = Color.DarkGreen
            lblErreur.Text = "Produit ajouté à la liste."
        ElseIf (nb = 3) Then
            lblErreur.ForeColor = Color.Red
            lblErreur.Text = "La liste selectionnée n'a plus de place."
        ElseIf (nb = 4) Then
            lblErreur.ForeColor = Color.Red
            lblErreur.Text = "Aucune liste selectionnée."
        End If
    End Sub

    'bouton renvoyant à l'écran de gestion des listes
    Private Sub btnGererListes_Click(sender As Object, e As EventArgs) Handles btnGererListes.Click
        'nettoyage et initialisations des labels, boutons et autres
        trckBrQuantité.Value = 1
        lblPrixQuantité.Text = "--,--"
        lblValeurTrckBr.Text = "--"
        lblErreur.Text = ""
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
End Class