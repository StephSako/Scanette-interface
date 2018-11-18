Public Class accueilListes
    'liste de tous les produits( max = 10 listes à 10 produits)
    Public listeProduit()() As String = {New String() {"", "", "", "", "", "", "", "", "", ""},
                                         New String() {"", "", "", "", "", "", "", "", "", ""},
                                         New String() {"", "", "", "", "", "", "", "", "", ""},
                                         New String() {"", "", "", "", "", "", "", "", "", ""},
                                         New String() {"", "", "", "", "", "", "", "", "", ""},
                                         New String() {"", "", "", "", "", "", "", "", "", ""},
                                         New String() {"", "", "", "", "", "", "", "", "", ""},
                                         New String() {"", "", "", "", "", "", "", "", "", ""},
                                         New String() {"", "", "", "", "", "", "", "", "", ""},
                                         New String() {"", "", "", "", "", "", "", "", "", ""}}

    'liste de tous les produits scannés qui permettra de ne pas payer les produits non scannés
    Public listeProduitScan()() As Boolean = {New Boolean() {False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False}}

    'liste de tous les produits payés
    Public listeProduitPayés()() As Boolean = {New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False},
                                             New Boolean() {False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False, False}}

    'liste de tous les prix de chaque produit
    Public listePrix()() As Double = {New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                      New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                      New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                      New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                      New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                      New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                      New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                      New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                      New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                      New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}

    'liste de toutes les quantités de chaque produit
    Public listeQuantite()() As Double = {New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                          New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                          New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                          New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                          New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                          New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                          New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                          New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                          New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                          New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}}

    Function nbProd() As Integer
        'recuperer l'indice du dernier emplacement de produit vide || taille effective
        Dim taille As Integer = 0

        For i As Integer = 0 To listeProduit(lstBxListes.SelectedIndex).Count - 1
            If (listeProduit(lstBxListes.SelectedIndex)(i) <> "") Then
                taille = taille + 1
            End If
        Next

        Return taille
    End Function

    'déterminer si un produit est scanné avec paramètre
    Function produitScan(n As Integer) As Boolean
        If (listeProduitScan(lstBxListes.SelectedIndex)(n) = True) Then
            Return True
        Else
            Return False
        End If
    End Function

    'déterminer le nombre de produits scannés
    Function nbProdScanné() As Integer
        Dim nbProdScannés As Integer = 0
        For j As Integer = 0 To listeProduitScan(lstBxListes.SelectedIndex).Count - 1
            If (listeProduitScan(lstBxListes.SelectedIndex)(j) = True) Then
                nbProdScannés = nbProdScannés + 1
            End If
        Next
        Return nbProdScannés
    End Function

    'déterminer si un produit est payé avec paramètre
    Function produitPayé(n As Integer) As Boolean
        If (listeProduitPayés(lstBxListes.SelectedIndex)(n) = True) Then
            Return True
        Else
            Return False
        End If
    End Function

    'retourne le nombre de produits payés
    Function nbProdPayés() As Integer
        Dim nbProdPayes As Integer = 0
        For j As Integer = 0 To listeProduitPayés(lstBxListes.SelectedIndex).Count - 1
            If (listeProduitPayés(lstBxListes.SelectedIndex)(j) = True) Then
                nbProdPayes = nbProdPayes + 1
            End If
        Next

        Return nbProdPayes
    End Function

    'déterminer si une liste est totalement payée, si oui modifier son nom sinon rien faire
    'vérification faire lorsque l'on paye un produit ET lorsque l'on paye une liste entièrement
    Public Function listeTotPayée() As Boolean
        If (Mid(lstBxListes.SelectedItem.ToString, 1, 1) = "√" And nbProd() = nbProdPayés()) Then
            Return True
        Else
            Return False
        End If
    End Function

    'bouton retour à l'écran d'accueil
    Private Sub pctBxReturn_Click(sender As Object, e As EventArgs) Handles pctBxReturn.Click
        'nettoyage des labels et autres
        accueilProduits.lstBxProduits.Text = ""
        lblErreurListe.Text = ""
        txtBxNewNomListe.Text = ""
        lblPrix.Text = "--,--"
        lblPrixRestant.Text = "--,--"
        accueilProduits.lstBxPrix.Items.Clear()

        'affichage de l'écran d'accueil
        Me.Hide()
        AccueilTangscan.Show()
    End Sub

    'bouton permettant de modifier le nom d'une liste
    Private Sub btnModifierList_Click(sender As Object, e As EventArgs) Handles btnModifierList.Click
        Dim saisieNewNomListe As String = txtBxModifierList.Text

        'si la saisie n'est pas vide ou trop petite
        If (saisieNewNomListe.Length = 0 Or saisieNewNomListe.Length < 3) Then
            lblErreurListe.ForeColor = Color.Red
            lblErreurListe.Text = ("Nom de 3 caractères minimum.")
        Else
            Dim nbRangM As Integer = lstBxListes.SelectedIndex
            lstBxListes.Items.RemoveAt(nbRangM)
            lstBxListes.Items.Insert(nbRangM, txtBxModifierList.Text)
            'mise à jour dans le comboBox de la fiche produit
            ficheProduit.cmbBxListeAjout.Items.RemoveAt(nbRangM)
            ficheProduit.cmbBxListeAjout.Items.Insert(nbRangM, txtBxModifierList.Text)

            'nettoyage des labels et autres
            txtBxModifierList.Text = ""
            lblErreurListe.Text = ""
            txtBxModifierList.Enabled = False
            btnModifierList.Enabled = False
        End If
    End Sub

    'bouton pour supprimer une liste
    Private Sub btnSuppListe_Click(sender As Object, e As EventArgs) Handles btnSuppListe.Click
        Dim rangSupp As Integer = lstBxListes.SelectedIndex

        'supprimer une liste
        For j As Integer = rangSupp To listeProduit.Count - 1
            If (j < 9) Then
                For i As Integer = 0 To listeProduit(lstBxListes.SelectedIndex).Count - 1
                    'remplacement de la liste suivante || décalage vers vers le haut de toutes les listes en dessous de la liste supprimée
                    listeProduit(j)(i) = listeProduit(j + 1)(i)
                    listePrix(j)(i) = listePrix(j + 1)(i)

                    'suppression de la liste dans la liste écrite des listes
                    listeProduit(j + 1)(i) = ""
                    'idem pour le prix
                    listePrix(j + 1)(i) = 0

                Next
            ElseIf (j = 9) Then
                For i As Integer = 0 To listeProduit(lstBxListes.SelectedIndex).Count - 1
                    'suppression de la liste dans la liste écrite des listes
                    listeProduit(j)(i) = ""
                    'idem pour le prix
                    listePrix(j)(i) = 0
                Next
            End If
        Next

        'nettoyage de la listBox des listes
        ficheProduit.cmbBxListeAjout.Items.RemoveAt(lstBxListes.SelectedIndex)
        lstBxListes.Items.RemoveAt(lstBxListes.SelectedIndex)

        'nettoyage de la listBox des prix
        accueilProduits.lstBxPrix.Items.Clear()

        btnSuppListe.Enabled = False
    End Sub

    'bouton de création et d'ajout d'une liste de course
    Private Sub btnAjouterListe_Click_1(sender As Object, e As EventArgs) Handles btnAjouterListe.Click
        lblPrix.Text = "0"
        lblPrixRestant.Text = "0"
        Dim saisieNewNomListe As String = txtBxNewNomListe.Text

        'si la saisie n'est pas vide ou trop petite
        If (saisieNewNomListe.Length = Nothing Or saisieNewNomListe.Length < 3) Then
            lblErreurListe.ForeColor = Color.Red
            lblErreurListe.Text = ("Nom de 3 caractères minimum.")
        Else
            'création du compteur
            Dim i As Integer = 1
            Dim verifExistListe As Boolean = False

            'boucle pour verifier l'existence d'une liste
            While (i <= lstBxListes.Items.Count)
                If (saisieNewNomListe = lstBxListes.Items(i - 1)) Then
                    verifExistListe = True
                    Exit While
                Else
                    verifExistListe = False
                End If
                i += 1
            End While

            'verification si la liste existe déjà ou pas
            If (verifExistListe = False) Then 'elle n'existe donc pas

                'remplissage de la liste de liste
                lstBxListes.Items.Add(saisieNewNomListe)
                'ajout de la nouvelle liste dans le comboBox de la ficheProduit
                ficheProduit.cmbBxListeAjout.Items.Add(saisieNewNomListe)

                'nettoyage des listBoxs et labels
                accueilProduits.lstBxPrix.Items.Clear()
                accueilProduits.lstBxProduits.Items.Clear()
                lblErreurListe.Text = ""

            ElseIf (verifExistListe = True) Then
                lblErreurListe.ForeColor = Color.Orange
                lblErreurListe.Text = "Cette liste existe déjà."
            End If
            'nettoyage des formulaires
            txtBxNewNomListe.Text = ""
            lstBxListes.SelectedIndex = -1
        End If
    End Sub

    'bouton pour partager une liste
    Private Sub btnPartager_Click(sender As Object, e As EventArgs) Handles btnPartager.Click
        'nettoyage et initialisations des labels et autres
        txtBxModifierList.Enabled = False
        btnModifierList.Enabled = False
        btnSuppListe.Enabled = False
        btnPartager.Enabled = False
        lblPrix.Text = "--,--"
        lblPrixRestant.Text = "--,--"
        lblErreurListe.Text = ""

        'decocher tous les radios
        partagerUneListe.radioMessenger.Checked = True
        partagerUneListe.radioGoogle.Checked = False
        partagerUneListe.radioBluetooth.Checked = False
        partagerUneListe.radioSMSTexto.Checked = False
        partagerUneListe.radioeMail.Checked = False
        partagerUneListe.radioFichierTxt.Checked = False

        'afficher le nom de la liste dans l'écran de partage
        partagerUneListe.lblTitreListePartage.Text = lstBxListes.SelectedItem

        'affichage de la liste des produits de la liste selectionnée dans l'écran de partage
        If (lstBxListes.SelectedIndex <> -1) Then
            For x As Integer = 0 To nbProd()
                If (listeProduit(lstBxListes.SelectedIndex)(x) <> Nothing) Then
                    partagerUneListe.lblListePartage.Text = partagerUneListe.lblListePartage.Text & listeProduit(lstBxListes.SelectedIndex)(x) & vbCrLf
                End If
            Next
        End If

        'affichage de l'écran de partage d'une liste
        Me.Hide()
        partagerUneListe.Show()
    End Sub

    'bouton qui affiche l'écran de gestion des produits de la liste selectionnée
    Private Sub btnGérerProduits_Click_1(sender As Object, e As EventArgs) Handles btnGérerProduits.Click
        'nettoyer la listBox des produits
        accueilProduits.lstBxProduitsMag.Items.Clear()
        accueilProduits.lstBxProduits.Items.Clear()
        accueilProduits.lstBxPrix.Items.Clear()
        accueilProduits.lstBxQuantite.Items.Clear()
        accueilProduits.lstBxCategorie.SelectedIndex = -1

        'somme de tous les prix des produits de la liste sélectionnée
        Dim sommePrix As Double = 0
        'somme de tous les prix restants des produits de la liste sélectionnée
        Dim sommePrixRestant As Double = 0

        'affichage de la liste des produits de la liste selectionnée
        If (lstBxListes.SelectedIndex <> -1) Then
            For x As Integer = 0 To nbProd() - 1
                accueilProduits.lstBxProduits.Items.Add(listeProduit(lstBxListes.SelectedIndex)(x))
                accueilProduits.lstBxPrix.Items.Add(listePrix(lstBxListes.SelectedIndex)(x))
                accueilProduits.lstBxQuantite.Items.Add(listeQuantite(lstBxListes.SelectedIndex)(x))

                'prix total
                sommePrix = sommePrix + listePrix(lstBxListes.SelectedIndex)(x)

                If (produitPayé(x) = False) Then 'si le produit n'est pas payé on additionne son prix
                    'addition de chaque prix des produits de la liste sélectionnée
                    sommePrixRestant = sommePrixRestant + listePrix(lstBxListes.SelectedIndex)(x)
                ElseIf (produitPayé(x) = True) Then
                    sommePrixRestant = sommePrixRestant + 0
                End If
            Next
        End If

        'affichage des prix
        lblPrixRestant.Text = sommePrixRestant
        lblPrix.Text = sommePrix
        accueilProduits.lblPrixRestant.Text = sommePrixRestant
        accueilProduits.lblPrix.Text = sommePrix

        'initialisations des boutons
        accueilProduits.btnScanner.Enabled = True
        accueilProduits.lstBxProduits.Enabled = True
        accueilProduits.lstBxProduitsMag.Enabled = False
        accueilProduits.btnAjouterProduit.Enabled = False
        accueilProduits.btnPayer.Enabled = False

        'nettoyage du label d'erreur
        lblErreurListe.Text = ""

        'affichage de l'écran de gestion des produits de la liste selectionnée
        Me.Hide()
        accueilProduits.Show()
    End Sub

    'lorsqu'une liste est selectionnée, il faut gérer certains boutons
    Private Sub lstBxListes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBxListes.SelectedIndexChanged
        'rendre les controles indisponible si aucun élément n'est sélectionné
        If (lstBxListes.SelectedIndex = -1) Then
            txtBxModifierList.Enabled = False
            btnModifierList.Enabled = False
            btnSuppListe.Enabled = False
            btnPartager.Enabled = False
            btnGérerProduits.Enabled = False
            btnPayerListe.Enabled = False
        Else
            btnPayerListe.Enabled = True
            If (Mid(lstBxListes.SelectedItem.ToString, 1, 1) = "√") Then
                btnModifierList.Enabled = False
                txtBxModifierList.Enabled = False
                btnSuppListe.Enabled = False
            Else
                btnModifierList.Enabled = True
                txtBxModifierList.Enabled = True
                btnSuppListe.Enabled = True
            End If
            btnPartager.Enabled = True
            btnGérerProduits.Enabled = True
        End If

            'initialisations des prix
            Dim sommePrix As Double = 0
        Dim sommePrixRestant As Double = 0

        If (lstBxListes.SelectedIndex <> -1) Then
            'addition des prix du nouveau produit avec les autres
            For x As Integer = 0 To nbProd()
                'prix total
                sommePrix = sommePrix + listePrix(lstBxListes.SelectedIndex)(x)

                'vérifier au cas ou on ajouterai un produit apres avoir payé un article, il faut mettre a jour le prix restant
                If (produitPayé(x) = False) Then 'si le produit n'est pas payé on additionne son prix
                    'addition de chaque prix des produits de la liste sélectionnée
                    sommePrixRestant = sommePrixRestant + listePrix(lstBxListes.SelectedIndex)(x)
                ElseIf (produitPayé(x) = True) Then
                    sommePrixRestant = sommePrixRestant + 0
                End If
            Next
        End If

        'affichage des prix
        lblPrix.Text = sommePrix
        lblPrixRestant.Text = sommePrixRestant
    End Sub

    'bouton pour payer une liste
    Private Sub btnPayerListe_Click(sender As Object, e As EventArgs) Handles btnPayerListe.Click
        If ((nbProdScanné() - nbProdPayés() > 0) And nbProdScanné() > 0 And nbProdPayés() < nbProd()) Then
            'nettoyage et initialisations des labels et autres
            txtBxModifierList.Enabled = False
            btnModifierList.Enabled = False
            btnSuppListe.Enabled = False
            btnPartager.Enabled = False
            lblPrix.Text = " - -,--"
            lblPrixRestant.Text = "--,--"
            lblErreurListe.Text = ""

            'recuperation du nom de la liste
            Dim nomListe As String = lstBxListes.SelectedItem.ToString
            payerUneListe.lblTitreListeAPayer.Text = nomListe

            'calcul du PRIX des PRODUITS SCANNES
            Dim prixListesProdScan As Double = 0
            For j As Integer = 0 To ChoixScan.listProduitsEnr.Count - 1
                If (listeProduitScan(lstBxListes.SelectedIndex)(j) = True) Then
                    prixListesProdScan = prixListesProdScan + listePrix(lstBxListes.SelectedIndex)(j)
                End If
            Next
            'affichage du prix
            payerUneListe.lblPrix.Text = prixListesProdScan

            'affichage de tous les produits scannés
            For x As Integer = 0 To nbProd() - 1
                If (listeProduitScan(lstBxListes.SelectedIndex)(x) = True) Then
                    payerUneListe.lstBxProd.Items.Add(listeProduit(lstBxListes.SelectedIndex)(x))
                End If
            Next

            'reduction de 5% sur le prix totale de la liste si l'utilisateur est Adhérent à TangScan
            Dim prixReduit As Double = (prixListesProdScan - ((5 / 100) * prixListesProdScan))
            If (comptesCoEtCr.btnLogOff.Enabled = True) Then
                lblErreurListe.ForeColor = Color.Green
                payerUneListe.lblRemise.Text = "Vous avez droit à une réduction" & Chr(13) & "    de 5% pour votre fidélité."
                payerUneListe.lblPrix.Text = Math.Round(prixReduit, 2)
            Else
                lblErreurListe.ForeColor = Color.Orange
                payerUneListe.lblRemise.Text = "          Bénéficiez d'une remise de 5%" & Chr(13) & "en souscrivant à un compte Fidélité TangScan."
                payerUneListe.lblPrix.Text = prixListesProdScan
            End If

            'affichage de l'écran de paiement de la liste
            Me.Hide()
            payerUneListe.Show()
        Else
            '... affichage d'un message d'erreur
            MessageBox.Show(text:="Scannez au moins un produit non payé pour payer une liste.",
                        caption:="Produits non scannés",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Hand)

        End If
    End Sub
End Class