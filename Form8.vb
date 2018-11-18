Public Class ficheAdhérent
    'ici sont affichées les informations sur le compte du client

    'bouton retour à l'écran de connexion et création de comptes
    Private Sub pctBxReturn_Click(sender As Object, e As EventArgs) Handles pctBxReturn.Click
        'nettoyage des labels
        lblNom.Text = ""
        lblCode.Text = ""

        'affichage de l'écran de connexion et création de comptes
        Me.Hide()
        comptesCoEtCr.Show()
    End Sub

    'dès l'arrivée sur cet écran, il y a l'initialisation des boutons : la décconexion est activée puisqu'un compte est loggé
    'et les boutons pour se connecter sont indisponibles
    Private Sub ficheAdhérent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initialisations des boutons
        comptesCoEtCr.btnLogOff.Enabled = True
        comptesCoEtCr.txtBxCODEA.Enabled = False
        comptesCoEtCr.btnLogIn.Enabled = False
        comptesCoEtCr.btnCréerCompteTangScan.Enabled = False
    End Sub
End Class