Imports System.IO 'importation de System.IO pour pouvoir utiliser l'écriture dans un fichier texte

Public Class partagerUneListe
    'bouton retour à l'écran de gestion des listes
    Private Sub pctBxReturn_Click(sender As Object, e As EventArgs) Handles pctBxReturn.Click
        'nettoyage des labels
        lblTitreListePartage.Text = ""
        lblListePartage.Text = ""
        accueilListes.lstBxListes.SelectedIndex = -1
        accueilListes.lblPrix.Text = "0"
        accueilListes.lblPrixRestant.Text = "0"

        'initialisation et "décochage" de chaque radios
        radioMessenger.Checked = False
        radioGoogle.Checked = False
        radioBluetooth.Checked = False
        radioSMSTexto.Checked = False
        radioeMail.Checked = False
        radioFichierTxt.Checked = False

        'affichage de l'écran de gestion des listes
        Me.Hide()
        accueilListes.Show()
    End Sub

    'bouton de vérification et validation de partage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPartager.Click

        'si le radio pour Messenger, Google+ ou SMS sont cochés, affichr un message d'erreur (service non disponible ici)
        If (radioMessenger.Checked = True Or radioGoogle.Checked = True Or radioSMSTexto.Checked = True) Then
            MessageBox.Show(text:="Vous ne pouvez pas utiliser cette fonction sur cet appareil.",
                        caption:="Fonction non disponible",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Hand)
            'sinon si le radio pour le partage de liste par fichier texte est coché ...
        ElseIf (radioFichierTxt.Checked = True) Then
            Dim sw As New StreamWriter(My.Application.Info.DirectoryPath & "\Listes sauvegardées\" + accueilListes.lstBxListes.SelectedItem.ToString + ".txt")
            sw.WriteLine(lblListePartage.Text) '... le contenu de la liste est écrit dans le fichier texte
            sw.Close()
            'My.Computer.FileSystem.RenameFile(My.Application.Info.DirectoryPath & "\Listes sauvegardées\" + accueilListes.lstBxListes.SelectedItem.ToString + ".txt")
            MessageBox.Show(text:="Le fichier texte a été créé avec succès.",
                        caption:="Fichier texte créé.",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Information) '... puis un message de confirmation est affiché
        End If
    End Sub
End Class