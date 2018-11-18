Public Class payerUneListe

    'bouton retour à l'écran de gestion des listes
    Private Sub pctBxReturn_Click(sender As Object, e As EventArgs) Handles pctBxReturn.Click
        'nettoyage et initialisations des labels et autres
        lblTitreListeAPayer.Text = ""
        lstBxProd.Items.Clear()
        accueilListes.lstBxListes.SelectedIndex = -1
        accueilListes.lblPrix.Text = "--,--"
        accueilListes.lblPrixRestant.Text = "--,--"

        'affichage de l'céran de gestion des listes
        Me.Hide()
        accueilListes.Show()
    End Sub

    'bouton pour payer une liste
    Private Sub btnPayer_Click(sender As Object, e As EventArgs) Handles btnPayer.Click
        'modification dans la liste écrite des produits QUI ONT ETE SCANNE
        For x As Integer = 0 To accueilListes.nbProd() - 1
            If (accueilListes.listeProduitScan(accueilListes.lstBxListes.SelectedIndex)(x) = True And Mid(accueilListes.listeProduit(accueilListes.lstBxListes.SelectedIndex)(x), 1) <> "√") Then
                accueilListes.listeProduit(accueilListes.lstBxListes.SelectedIndex)(x) = "√ " + accueilListes.listeProduit(accueilListes.lstBxListes.SelectedIndex)(x)
                accueilListes.listeProduitPayés(accueilListes.lstBxListes.SelectedIndex)(x) = True 'l'index du produit selectionné dans le tableau de booléens de produits payés est donc à vrai
            End If
        Next

        'message de confirmation
        MessageBox.Show(text:="Le produit a bien été payé.",
                        caption:="Produit payé.",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Information)

        'si la liste a été entièrement payée, un "checked" est ajouté devant le nom de la liste
        Dim nomListe As String = accueilListes.lstBxListes.SelectedItem.ToString
        If (accueilListes.listeTotPayée() = False) Then
            Dim nb As Integer = accueilListes.lstBxListes.SelectedIndex
            accueilListes.lstBxListes.Items.RemoveAt(accueilListes.lstBxListes.SelectedIndex)
            accueilListes.lstBxListes.Items.Insert(nb, "√ " + nomListe)
        End If
    End Sub

    Private Sub lstBxProd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBxProd.SelectedIndexChanged

    End Sub
End Class