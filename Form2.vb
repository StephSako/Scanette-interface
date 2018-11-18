Public Class ChoixScan
    'déclarations de toutes les images
    'FOURNITURE
    Public imgStylo As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Fourniture\stylo.jpg")
    Public imgColle As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Fourniture\colle.jpg")
    Public imgFeuille As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Fourniture\feuille.jpg")
    Public imgTrousse As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Fourniture\trousse.jpg")
    Public imgStabilos As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Fourniture\stabilos.jpg")
    Public imgAgrafeuse As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Fourniture\agrafeuse.jpg")
    Public imgClasseur As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Fourniture\classeur.jpg")
    Public imgCahier As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Fourniture\cahier.jpg")
    Public imgEquerre As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Fourniture\equerre.jpg")

    'ALIMENTATION
    Public imgCroissant As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Alimentation\croissant.jpg")
    Public imgSteakHaché As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Alimentation\steak_haché.jpg")
    Public imgFrites As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Alimentation\frites.jpg")
    Public imgSalade As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Alimentation\salade.jpg")
    Public imgBanane As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Alimentation\banane.jpg")
    Public imgYaourt As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Alimentation\yaourt.jpg")
    Public imgPates As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Alimentation\pates.jpg")
    Public imgSoupe As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Alimentation\soupe.jpg")
    Public imgOeuf As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Alimentation\oeuf.png")

    'ELECTROMENAGER
    Public imgFour As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Electroménager\four.jpg")
    Public imgMicroOnde As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Electroménager\micro_onde.jpg")
    Public imgApirateur As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Electroménager\aspirateur.jpg")
    Public imgMachineALaver As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Electroménager\machine_à_laver.jpg")
    Public imgLaveVaisselle As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Electroménager\lave_vaisselle.jpg")
    Public imgLecteurDVD As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Electroménager\lecteur_DVD.jpg")
    Public imgOrdinateur As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Electroménager\ordinateur.jpg")
    Public imgTVPlasma As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Electroménager\tv_plasma.jpg")
    Public imgPS3 As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Electroménager\ps3.jpg")

    'CULTURE
    Public imgDeadpool As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Culture\deadpool.jpg")
    Public imgFifa18 As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Culture\fifa_18.jpg")
    Public imgWar As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Culture\war.jpg")
    Public imgLigneVerte As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Culture\ligne_verte.jpg")
    Public imgGTA5 As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Culture\gta_5.jpg")
    Public imgCherub As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Culture\cherub.jpg")
    Public imgOnePiece As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Culture\one_piece.jpg")
    Public img2006 As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Culture\2006.jpg")
    Public img127Heures As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Culture\127_heures.jpg")

    'HYGIENE
    Public imgBrosseADent As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Hygiene\brosse_à_dent.png")
    Public imgSavon As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Hygiene\savon_marseille.jpg")
    Public imgPoire As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Hygiene\poire_à_lavement.jpg")
    Public imgCotonTige As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Hygiene\coton_tige.jpg")
    Public imgDentifrice As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Hygiene\dentifrice.png")
    Public imgPreservatif As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Hygiene\preservatif.jpg")
    Public imgGant As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Hygiene\gant.jpg")
    Public imgShampooing As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Hygiene\shampooing.jpg")
    Public imgDemaquillant As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Hygiene\demaquillant.jpg")

    'VETEMENT
    Public imgChapeau As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Vêtement\chapeau.jpg")
    Public imgTshirt As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Vêtement\tshirt.jpg")
    Public imgChemise As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Vêtement\chemise.jpg")
    Public imgSandale As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Vêtement\sandale.jpg")
    Public imgBasket As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Vêtement\basket.jpg")
    Public imgJeans As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Vêtement\jeans.jpg")
    Public imgPyjama As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Vêtement\pyjama.jpg")
    Public imgLunette As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Vêtement\lunette.jpg")
    Public imgRobe As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Vêtement\robe.jpg")

    'BRICOLAGE
    Public imgMarteau As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Bricolage\marteau.jpg")
    Public imgPioche As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Bricolage\pioche.jpg")
    Public imgBoiteVis As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Bricolage\boite_vis.jpg")
    Public imgTronconneuse As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Bricolage\tronconneuse.jpg")
    Public imgBoiteBoulons As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Bricolage\boite_boulons.jpg")
    Public imgNiveau As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Bricolage\niveau.jpg")
    Public imgTournevis As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Bricolage\tournevis.jpg")
    Public imgScie As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Bricolage\scie.jpg")
    Public imgPerceuse As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Bricolage\perceuse.jpg")

    'JARDINERIE
    Public imgRateau As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Jardinerie\rateau.jpg")
    Public imgTondeuse As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Jardinerie\tondeuse.jpg")
    Public imgBinette As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Jardinerie\binette.jpg")
    Public imgPelle As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Jardinerie\pelle.jpg")
    Public imgBrouette As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Jardinerie\brouette.jpg")
    Public imgPotDeFleur As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Jardinerie\pot_de_fleur.jpg")
    Public imgGrainesFraises As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Jardinerie\graines_fraises.jpg")
    Public imgCoupeHaie As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Jardinerie\coupe_haie.jpg")
    Public imgArrosoir As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Jardinerie\arrosoir.jpg")

    'SPORT
    Public imgBallon As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Sport\ballon.jpg")
    Public imgRaquette As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Sport\raquette.jpg")
    Public imgBandeau As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Sport\bandeau.jpg")
    Public imgPetanque As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Sport\petanque.jpg")
    Public imgMaillot As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Sport\maillot_de_bain.jpg")
    Public imgTuba As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Sport\tuba.jpg")
    Public imgImpermeable As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Sport\impermeable.jpg")
    Public imgVelo As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Sport\velo.jpg")
    Public imgPatin As Image = System.Drawing.Bitmap.FromFile(My.Application.Info.DirectoryPath & "\Sport\patin_à_glace.jpg")

    'déclaration et remplissage du tableau d'images
    Dim listImgProduitsEnr()() As Image = {New Image() {imgStylo, imgColle, imgFeuille, imgTrousse, imgStabilos, imgAgrafeuse, imgClasseur, imgCahier, imgEquerre},
                                           New Image() {imgCroissant, imgSteakHaché, imgFrites, imgSalade, imgBanane, imgYaourt, imgPates, imgSoupe, imgOeuf},
                                           New Image() {imgFour, imgMicroOnde, imgApirateur, imgMachineALaver, imgLaveVaisselle, imgLecteurDVD, imgOrdinateur, imgTVPlasma, imgPS3},
                                           New Image() {imgDeadpool, imgFifa18, imgWar, imgLigneVerte, imgGTA5, imgCherub, imgOnePiece, img2006, img127Heures},
                                           New Image() {imgBrosseADent, imgSavon, imgPoire, imgCotonTige, imgDentifrice, imgPreservatif, imgGant, imgShampooing, imgDemaquillant},
                                           New Image() {imgChapeau, imgTshirt, imgChemise, imgSandale, imgBasket, imgJeans, imgPyjama, imgLunette, imgRobe},
                                           New Image() {imgMarteau, imgPioche, imgBoiteVis, imgTronconneuse, imgBoiteBoulons, imgNiveau, imgTournevis, imgScie, imgPerceuse},
                                           New Image() {imgRateau, imgTondeuse, imgBinette, imgPelle, imgBrouette, imgPotDeFleur, imgGrainesFraises, imgCoupeHaie, imgArrosoir},
                                           New Image() {imgBallon, imgRaquette, imgBandeau, imgPetanque, imgMaillot, imgTuba, imgImpermeable, imgVelo, imgPatin}}

    'déclaration et remplissage du tableau de catégories
    Public listeCategorie() As String = {"Fourniture", "Alimentation", "Electroménager", "Culture", "Hygiene", "Vêtement", "Bricolage", "Jardinerie", "Sport"}

    'déclaration et remplissage des produits enregistrés dans la base de données
    Public listProduitsEnr()() As String = {New String() {"Stylo", "Bâton de colle", "Feuille", "Trousse", "Stabilos", "Agrafeuse", "Classeur", "Cahier", "Equerre"},
                                            New String() {"Croissants", "Steak Haché", "Frites", "Salade", "Chips banane", "Yaourt", "Pâte", "Soupe", "Oeuf"},
                                            New String() {"Four", "Micro-onde", "Aspirateur", "Machine à laver", "Lave-vaisselle", "Lecteur DVD", "Ordinateur", "TV Plasma", "Playstation 3"},
                                            New String() {"DeadPool", "FIFA 18 PS4", "WAR - U2", "La ligne verte", "GTA V", "CHERUB - Mission 5", "One Piece - 60", "2006 : Le Parcours", "127 Heures"},
                                            New String() {"Brosse à dent", "Savon de Marseille", "Poire à lavement", "Coton tige", "Dentifrice", "Présevatif", "Gant", "Shampooing", "Démaquillant"},
                                            New String() {"Chapeau", "T-shirt", "Chemise", "Sandale", "Basket", "Jean's", "Pyjama", "Lunette de soleil", "Robe"},
                                            New String() {"Marteau", "Pioche", "Boîte de vis", "Tronçonneuse", "Boîte de boulons", "Niveau", "Tournevis", "Scie", "Perçeuse"},
                                            New String() {"Rateau", "Tondeuse", "Binette", "Pelle", "Brouette", "Pot de fleur", "Graines fraisier", "Coupe-haie", "Arrosoir"},
                                            New String() {"Ballon basket", "Raquette Tennis", "Bandeau", "Boule Pétanque", "Maillot de bain", "Masque/tuba", "Imperméable", "Vélo", "Patin à glace"}}

    'déclaration et création des prix de chaque produit
    Public listPrixProduitsEnr()() As Double = {New Double() {1.65, 1.91, 15.0, 5.3, 12.99, 19.9, 2.99, 1.96, 5.82},
                                                New Double() {3.4, 12.6, 1.65, 4.3, 1.2, 3.9, 1.01, 2.07, 3.15},
                                                New Double() {269, 49.99, 39.99, 399, 352, 37.9, 290.79, 269, 267.99},
                                                New Double() {9.04, 99.99, 26.31, 5.8, 16.99, 15.0, 17.01, 11, 10.23},
                                                New Double() {11.9, 4.01, 11.9, 1.85, 9.79, 6.9, 4.19, 15.5, 4.95},
                                                New Double() {45, 19.95, 25, 39, 49.99, 24, 37.9, 71, 26},
                                                New Double() {39.7, 43.91, 4.71, 109, 18.56, 2.5, 4.9, 79.9, 169.4},
                                                New Double() {16.94, 99.9, 8.85, 13.5, 24.99, 29.9, 4.5, 74.9, 4.9},
                                                New Double() {7.9, 99999, 16, 40, 109.9, 29.99, 19.2, 199.99, 39.95}}

    'déclaration et création des descriptions de chaque produit
    Public listDescrProduitsEnr()() As String = {New String() {"Stylo bille 4 couleurs medium Bic", "Bâton de colle Scotch 19 g", "Staples Papier Couleur A4 (210 x 297 mm) 80g/m² 500 feuilles", "Trousse écolier ronde safetool", "Etui de 20 feutres point 88 - STABILO", "Agrafeuse manuelle R53", "Classeur à levier gris anthracite", "Clairefontaine - A4 - 21 x 29 7 cm - Petits carreaux - 96 pag", "Equerre Bleue 21cm 60°/30°"},
                                                 New String() {"10 croissants, pur beurre.", "10 steaks hachés, 5% M.G maximum, origine France", "Frites four XL 1kg", "Mix - Salade Italienne composée de pâtes, d'allumettes de jambon cru", "Chips de banane salees 70g", "Lot de 6 yaourts fermier nature", "Panzani - Pâtes fantaisies Penne rigate", "Pursoup veloute 10 legumes", "Oeufs de nos villages - Oeufs bio"},
                                                 New String() {"Whirlpool AKP 250 IX Four - Électrique - Encastrable - 59,5 cm - 51 L", "Proline GM20S SILVER Micro ondes et gril", "Listo AS80 L1 - Aspirateur sans sac", "Samsung WF70F5E5W4X Machine à laver à ouverture frontale - 63 L", "Bosch SMS40D62EU 640B.EU Lave-vaisselle - 60 cm - Blanc", "Philips DVP2850 Lecteur DVD", "PC avec écran Dell Optiplex 780 - Core Duo 2,60 GHz + Ecran 22'", "Samsung 5 Series UE32J5000AW - 80 cm - TV LED - 1080p", "Samsung 5 Series UE32J5000AW - 80 cm - TV LED - 1080p"},
                                                 New String() {"Deadpool DVD - DVD Zone 2", "FIFA 18 Édition ICONE PS4 Jeux", "War - Edition deluxe - CD album", "La Ligne verte - Edition Collector - DVD Zone 2", "Grand Theft Auto V - [Jeu pour PS3]", "CHERUB - Les survivants - Livre", "One piece - pour une poignée de berrys", "Les Bleus, un parcours de légende - Coupe du monde de la Fifa", "127 Heures - Édition Digibook Collector + Livret - Blu-Ray"},
                                                 New String() {"1 brosse à dents électrique Oral B Advance Power", "Savon de marseille vert olive", "Poire à Lavement Shower Play P3", "Sterilux Coton-Tiges bâtonnets ouatés boite de 200", "Regenerate dentifrice expert - 75 ml Dentifrices", "Manix Endurance Longue Durée 14 préservatifs", "Lot de 4 gants de toilette coton 420 g/m² Tertio", "Shampoing Silver 500ml", "Yves Rocher Huile Micellaire Démaquillante Tous Types de Peaux"},
                                                 New String() {"Levi's-Wide Brimmed Fedora-Black", "Urban Classics Tshirt imprimé, Homme, Taille: L, Noir", "New Look Chemise, Homme, Taille: L, Blanc", "Sandales et nu-pieds Femme, Or et Bronze", "Nike T-Lite XI chaussures sport homme Taille 45", "New Look Dempsey Slim Jean slim, Homme, Taille: 30x30, Bleu", "Petit Bateau Pyjama Garçon à carreaux bleu/blanc", "Ray-ban - rb 4201 622/8g alex", "Anna Field Robe fourreau, Femme, Taille: 42, Noir"},
                                                 New String() {"Marteau aimanté 10 mm Vergez Blanchard VB2_7371", "Pioche de terrassier en fibre - fiskars leborgne", "vis placo 3,5x25 boîte de 1000", "Tronçonneuse thermique silex® 62cc / guide 18-45 cm", "Boulon bois trcc 10x160 boite de 25 zingue blanc - LENNIE", "Mini niveau à bulle 18 mm", "Tournevis Torx avec 13 embouts à double tête", "Scie pierre tendre outibat - manche bois - longueur 700 mm", "Perceuse visseuse makita 18v 3ah lion ddf453sfe"},
                                                 New String() {"Râteau 16 dents courbes emmanché 1,5m - OUTILS PERRIN", "Tondeuse thermique poussée 40cm 99cc t40p 99p", "Binette en frêne de première qualité - 1350 mm - SILVERLINE", "Pelle ronde col de cygne revex", "Brouette pour travaux de Bricolage et jardinage charge 100 kg", "Pot de fleurs Dublin - diamètre 37,5 cm - Vert", "Fraisier temptation (50 graines)", "Taille Haies 500 W 55 cm - GT5055", "Arrosoir Parisien vert 11L"},
                                                 New String() {"Ballon de basket en PVC", "Raquette Wilson Federer 100", "Bandeau Nike Pro Swoosh 2.0", "Boules de pétanque Obut Loisir inox maori 73mm 10610", "Iodus Maillot de bain une pièce Orange", "Masque de Surface Easybreath Bleu - Plongee - SUBEA", "Coupe-vent double filet Rouge - result R205X - Taille M Rouge", "VTT ROCKRIDER 340 BLANC 26 - VELO TOUT TERRAIN - B'TWIN", "Patins à glace Tempish Dream"}}

    'déclaration et création des codes de chaque produit
    Public codeListProduitsEnr()() As String = {New String() {"300069", "679211", "962439", "574506", "211206", "555236", "319024", "992022", "727414"},
                                                New String() {"319025", "992021", "727415", "354208", "875412", "312064", "146736", "679210", "962438"},
                                                New String() {"312065", "146735", "941604", "718949", "911667", "623073", "151369", "643302", "985301"},
                                                New String() {"600213", "708883", "828506", "943767", "104338", "900824", "805087", "298699", "138300"},
                                                New String() {"476271", "894194", "548110", "906064", "604933", "255505", "369778", "891537", "790601"},
                                                New String() {"220705", "528669", "269801", "344003", "603627", "978014", "325884", "734543", "612907"},
                                                New String() {"727510", "625588", "534142", "925258", "557182", "985612", "658767", "360931", "927046"},
                                                New String() {"237127", "218169", "107489", "587307", "993514", "685597", "101720", "112352", "927724"},
                                                New String() {"440099", "706512", "529271", "163797", "666987", "201984", "318669", "665505", "885090"}}

    'récupération de l'indice de la catégorie
    Public indCatégorieSaisi As Integer
    'récupération de l'indice du produit
    Public indProduitSaisi As Integer

    'affichage du message pour le scan automatique (non disponible sur cet appareil
    Private Sub btnScanAuto_Click(sender As Object, e As EventArgs) Handles btnScanAuto.Click
        'nettoyage du label d'erreur
        lblTxtErreur.Text = ""
        MessageBox.Show(text:="Vous ne pouvez pas utiliser cette fonction sur cet appareil.",
                        caption:="Fonction non disponible",
                        buttons:=MessageBoxButtons.OK,
                        icon:=MessageBoxIcon.Hand)
    End Sub

    'bouton vérifier et valider la saisie du code
    Private Sub pctBxValiderSaisie_Click(sender As Object, e As EventArgs) Handles pctBxValiderSaisie.Click
        Dim saisie As String = txtBxSaisieScan.Text

        'si l'utilisateur n'a rien saisit, il y erreur
        If (saisie.Length = Nothing Or saisie.Length < 6) Then
            'affichage de l'erreur
            lblTxtErreur.ForeColor = Color.Red
            lblTxtErreur.Text = ("Saisissez un code de 6 caractères.")
        Else
            'je créé un booléen pour verifier la concordance du code
            Dim verifCode As Boolean
            verifCode = True

            'création du compteur
            Dim i As Integer = 0

            'boucle pour verifier chaque valeur du tableau tant qu'elle ne correspond pas au code saisi
            For x As Integer = 0 To listeCategorie.Count - 1
                For j As Integer = 0 To codeListProduitsEnr(x).Count - 1
                    If (saisie = codeListProduitsEnr(x)(j)) Then
                        verifCode = True 'le code correspond : tout va bien
                        indProduitSaisi = j 'enregistrement de l'index du produit
                        Exit For
                    Else
                        verifCode = False 'le code n'existe pas : erreur
                    End If
                Next
                If (verifCode = True) Then
                    indCatégorieSaisi = x 'enregistrement de l'index de la catégorie
                    Exit For
                End If
            Next

            'dernière vérification du code et affichage en conséquence
            If verifCode = True Then
                'nettoyage des labels et textbox remplis
                lblTxtErreur.Text = ""
                txtBxSaisieScan.Text = ""

                'affichage de la fiche produit correspondant au code saisit par l'utilisateur
                Me.Hide()
                ficheProduit.Show()

                'affichage du nom, prix, code, photos et description du produit dans lécran ficheProduit
                ficheProduit.lblNomProduit.Text = listProduitsEnr(indCatégorieSaisi)(indProduitSaisi)
                ficheProduit.lblDescriptionProduit.Text = listDescrProduitsEnr(indCatégorieSaisi)(indProduitSaisi)
                ficheProduit.lblPrixProduit.Text = listPrixProduitsEnr(indCatégorieSaisi)(indProduitSaisi)
                ficheProduit.lblCodeProduit.Text = codeListProduitsEnr(indCatégorieSaisi)(indProduitSaisi)
                ficheProduit.pctrBxProduit.Image = listImgProduitsEnr(indCatégorieSaisi)(indProduitSaisi)

                'affichage de la valeur de la trackbar
                ficheProduit.lblValeurTrckBr.Text = ficheProduit.trckBrQuantité.Value
                'affichage du prix en fonction de la quantité et du prix unitaire
                Dim prix As Double = ficheProduit.lblPrixProduit.Text
                ficheProduit.lblPrixQuantité.Text = prix * ficheProduit.trckBrQuantité.Value

                ficheProduit.cmbBxListeAjout.SelectedIndex = -1
                ficheProduit.cmbBxListeAjout.Text = "--------------------------"

            ElseIf verifCode = False Then 'le prix ne correpond à aucun code existant
                lblTxtErreur.ForeColor = Color.Orange
                lblTxtErreur.Text = ("Votre code ne correspond à aucun produit.")
            End If
        End If
    End Sub

    'bouton retour au menu principal
    Private Sub pctBxReturn_Click(sender As Object, e As EventArgs) Handles pctBxReturn.Click
        'nettoyage des labels
        lblTxtErreur.Text = ""
        txtBxSaisieScan.Text = ""

        'affichage de l'acceuil
        Me.Hide()
        AccueilTangscan.Show()
    End Sub

    'bouton gérer les listes
    Private Sub créerUneListe_Click(sender As Object, e As EventArgs) Handles GererLesListes.Click
        'nettoyage du label erreur
        txtBxSaisieScan.Text = ""

        'mettre les boutons de gestion d'une liste indisponible puisqu'aucune liste n'est selectionnée en arrivant depuis la fiche produit
        accueilListes.lstBxListes.SelectedIndex = -1
        accueilListes.txtBxModifierList.Enabled = False
        accueilListes.btnModifierList.Enabled = False
        accueilListes.btnSuppListe.Enabled = False
        accueilListes.btnPartager.Enabled = False
        accueilListes.btnPartager.Enabled = False
        accueilListes.btnGérerProduits.Enabled = False

        'affichag de la page gestion des listes
        Me.Hide()
        accueilListes.Show()
    End Sub
End Class