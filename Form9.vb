Public Class payerProduit

    'bouton de paiement du produit selectionné
    Private Sub btnPayer_Click(sender As Object, e As EventArgs) Handles btnPayer.Click
        'sauvegarde du nom du produit selectionné précedemment dans l'écran de gestion des produits
        Dim chProduit As String = accueilProduits.lstBxProduits.SelectedItem.ToString

        'modification dans la liste écrite des produits en ajoutant un "checked" devant le nom du produit pour indiquer qu'il est
        'payé
        accueilListes.listeProduit(accueilListes.lstBxListes.SelectedIndex)(accueilProduits.lstBxProduits.SelectedIndex) = "√ " + chProduit
        'nettoyage des labels d'erreur
        accueilListes.lblErreurListe.Text = ""

        'message de confirmation du paiement du produit
        MessageBox.Show(text:="La liste a bien été payée.",
                        caption:="Liste payée.",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Information)

        'le produit est payé : son êtat de "payé" est donc à vrai dans le tableau listeProduitPayé (tableau de booléens)
        accueilListes.listeProduitPayés(accueilListes.lstBxListes.SelectedIndex)(accueilProduits.lstBxProduits.SelectedIndex) = True

        'vérification de l'avancée de paiement de la liste dans lequel le produit a été payé : si une liste devient entièrement7
        'payée (tous les produits sont payés), alors on ajoute un "checked" devant le nom de cette liste
        If (accueilListes.listeTotPayée() = False And accueilListes.nbProdPayés() = accueilListes.nbProd()) Then 'appel de la fonction de accueilListes (nom de la Form) qui 
            'détermine si une liste est entièrement payée après le paiement d'un produit
            Dim nomListe As String = accueilListes.lstBxListes.SelectedItem.ToString
            Dim rang As Integer = accueilListes.lstBxListes.SelectedIndex
            'on supprime le nom de la liste ...
            accueilListes.lstBxListes.Items.RemoveAt(rang)
            '... pour le remplacer en ajoutant un "checked" devant son nom
            accueilListes.lstBxListes.Items.Insert(rang, "√ " + nomListe)
        End If

        'réinitialisation des différents API
        accueilProduits.btnPayer.Enabled = False
        accueilProduits.lstBxProduits.SelectedIndex = -1
    End Sub

    'bouton retour à l'écran de gestion des listes
    Private Sub pctBxReturn_Click(sender As Object, e As EventArgs) Handles pctBxReturn.Click
        'nettoyage des labels
        lblPrixPayer.Text = ""
        lblProduitPayé.Text = ""

        'nettoyage et réinitialisation du listBox des prix et des produit, boutons et des labels de prix et d'erreur
        accueilProduits.lstBxPrix.Items.Clear()
        accueilProduits.lstBxProduits.Items.Clear()
        accueilListes.lstBxListes.SelectedIndex = -1
        accueilListes.lblPrix.Text = "--,--"
        accueilListes.lblPrixRestant.Text = "--,--"
        accueilListes.lstBxListes.SelectedIndex = -1
        accueilListes.txtBxModifierList.Enabled = False
        accueilListes.btnModifierList.Enabled = False
        accueilListes.btnSuppListe.Enabled = False
        accueilListes.btnPartager.Enabled = False
        accueilListes.btnGérerProduits.Enabled = False

        'affichage de l'écran de gestion des listes
        Me.Hide()
        accueilListes.Show()
    End Sub
End Class