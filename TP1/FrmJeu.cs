using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class FrmJeu : Form
    {

        List<CarteTresor> listeCartesTresor = new List<CarteTresor>();
        List<CarteInnod> listeImageInnod = new List<CarteInnod>();
        //liste des Boutons du champe
        List<Button> listeBoutonsJeu = new List<Button>();
        //liste des Boutons Rouge
        List<Button> BoutonsRouge = new List<Button>();
        //liste des Boutons Vert
        List<Button> BoutonsVert = new List<Button>();
        //liste des images
        List<CartesJeu> listeImagesBouton = new List<CartesJeu>();
        List<CartesJeu> CartesInnodation = new List<CartesJeu>();
        // Create  List qui est les indexes des image jeu
        List<int> lstNumero = new List<int>();
        // Create  List qui est les indexes des image innodation
        List<int> lstInnod = new List<int>();
        // Create  List qui est les indexes 6 image innodation
        List<int> lstSix = new List<int>();
        //Create  List qui est l'image de l'eau
        List<int> imageEau = new List<int>();
        //Create  List qui est l'image du sable
        List<int> imageSable = new List<int>();
        //Create  List qui est l'image du helicopter
        List<int> imageHelic = new List<int>();
        int niveau; //le nieau de l'eau
        int numInnod = 0; //nombre cartes innodation
        int numTresor = 0; //nombre cartes Tresor
        int cmptRouge = 0; //compter nombre action joueur rouge
        int cmptVert = 0; //compter nombre action joueur vert
        int comptCartDef = 0;//compter carte Tresor enleves
        const int eau = 50;// pour comparer avec l'image de l'eau
        bool tourRouge = false;//savoir  si le toure rouge
        bool tourVert = false;//savoir  si le toure vert
        bool echange = false;//savoir si il veut faire echange
        bool tropCarte = false;//si il y a trop carte
        bool resteCarte = false;//compter nombre carte qui reste
        bool secher = false;//si bouton avec sable clique

        public FrmJeu(int niveau)
        {
            this.niveau = niveau;
            InitializeComponent();
            CartesJeu.MettreImagesDansListe();
            CarteInnod.MettreImagesDansListeInondation();
            CarteTresor.MettreImagesDansListeTresor();
            AjoutesCartesInnodation();
            AjouterBoutons();
            AjoutesImageChamp();
            AjouterImagesBoutons();
            AjoutesCartesTresor();
            btnInnodation.Enabled = false;
            btnTresor.Enabled = false;
            NiveauDeau();
            IndiquerBoutons();
            JouerRouge();

        }
       
        //ajouter les boutons dans la liste
        public void AjouterBoutons()
        {
            listeBoutonsJeu.Add(button1);
            listeBoutonsJeu.Add(button2);
            listeBoutonsJeu.Add(button3);
            listeBoutonsJeu.Add(button4);
            listeBoutonsJeu.Add(button5);
            listeBoutonsJeu.Add(button6);
            listeBoutonsJeu.Add(button7);
            listeBoutonsJeu.Add(button8);
            listeBoutonsJeu.Add(button9);
            listeBoutonsJeu.Add(button10);
            listeBoutonsJeu.Add(button11);
            listeBoutonsJeu.Add(button12);
            listeBoutonsJeu.Add(button13);
            listeBoutonsJeu.Add(button14);
            listeBoutonsJeu.Add(button15);
            listeBoutonsJeu.Add(button16);
            listeBoutonsJeu.Add(button17);
            listeBoutonsJeu.Add(button18);
            listeBoutonsJeu.Add(button19);
            listeBoutonsJeu.Add(button20);
            listeBoutonsJeu.Add(button21);
            listeBoutonsJeu.Add(button22);
            listeBoutonsJeu.Add(button23);
            listeBoutonsJeu.Add(button24);

        }
        public void AjouterImageSable()
        {
            imageEau.Add(3);
            imageEau.Add(5);
            imageEau.Add(7);
            imageHelic.Add(2);
            imageHelic.Add(4); 
            imageHelic.Add(6);
            imageSable.Add(0);
            imageSable.Add(1);

        }
       
        ///pour ajouter les images innodation et du jeu dans les listes 
        public void AjoutesImageChamp()
        {
            for (int i = 0; i < lstNumero.Count; i++)
            {
                listeImagesBouton.Add(new CartesJeu(i));
            }
            //ajouter des boutons Rouge dans la liste
            BoutonsRouge.Add(btnRouge1);
            BoutonsRouge.Add(btnRouge2);
            BoutonsRouge.Add(btnRouge3);
            BoutonsRouge.Add(btnRouge4);
            BoutonsRouge.Add(btnRouge5);
            BoutonsRouge.Add(btnRouge6);
            //ajouter des boutons Vert dans la liste
            BoutonsVert.Add(btnVert1);
            BoutonsVert.Add(btnVert2);
            BoutonsVert.Add(btnVert3);
            BoutonsVert.Add(btnVert4);
            BoutonsVert.Add(btnVert5);
            BoutonsVert.Add(btnVert6);

           // DesactiverBoutonJoueurs();
        }
        //methode qui faire les boutons des joueurs non actives
        //public void DesactiverBoutonJoueurs()
        //{
        //    for (int i = 0; i < BoutonsRouge.Count; i++)
        //    {
        //        BoutonsRouge[i].Enabled = false;
        //    }
        //    for (int i = 0; i < BoutonsVert.Count; i++)
        //    {
        //        BoutonsVert[i].Enabled = false;
        //    }
        //}
        ///pour ajouter les cartes innodation dans la liste 
        public void AjoutesCartesInnodation()
        {
            tableauAleatoire(24, lstInnod);

            for (int i = 0; i < lstInnod.Count; i++)
            {
                CartesInnodation.Add(new CartesJeu(lstInnod[i]));
                listeImageInnod.Add(new CarteInnod(lstInnod[i]));
            }
        }
        ///pour ajouter les cartes Tresor dans la liste 
        public void AjoutesCartesTresor()
        {
            tableauAleatoire(28, lstNumero);

            for (int i = 0; i < lstNumero.Count; i++)
            {
                listeCartesTresor.Add(new CarteTresor(lstNumero[i]));
                listeCartesTresor[i].ImageTresor.Tag = lstNumero[i];

            }
            for (int i = 25; i < 28; i++)
            {
                listeCartesTresor.Add(new CarteTresor(i));
                listeCartesTresor[i].ImageTresor.Tag = i;

            }
            
            //ajouter cartes tresor a la tables des joueurs
            AjouterImageSable();
            PlaserImageJoueur(btnRouge1);
            numTresor = numTresor + 1;
            PlaserImageJoueur(btnRouge2);
            numTresor = numTresor + 1;
            PlaserImageJoueur(btnVert1);
            numTresor = numTresor + 1;
            PlaserImageJoueur(btnVert2);
            numTresor = numTresor + 1;
        }
        private void PlaserImageJoueur(Button bouton)
        {
            bool existe = false;
                for (int k = 0; k < imageEau.Count; k++)
                {
                    if ((int)listeCartesTresor[numTresor].ImageTresor.Tag == imageEau[k])
                    {
                        existe = true;
                    }
                }
                if (!existe)
                {
                    bouton.BackgroundImage = listeCartesTresor[numTresor].ImageTresor;
                    return;
                }
                else
                {
                    numTresor = numTresor + 1;
                    PlaserImageJoueur(bouton);
                }
            }
        //methode qui peut savoir si il y a l'eau dans bouton
        private void IndiquerBoutons()
        {
            for (int i = 0; i < listeBoutonsJeu.Count; i++)
            {
                listeBoutonsJeu[i].Enabled = false;
                listeBoutonsJeu[i].Tag = eau;
            }
        }
        //pour ajouter les images dans les boutons
        private void AjouterImagesBoutons()
        {            
            tableauAleatoire(24, lstNumero);
            for (int i = 0; i < listeBoutonsJeu.Count; i++)
            {
                listeBoutonsJeu[i].BackgroundImage = new CartesJeu(lstNumero[i]).ImagesBouton;
                if (lstNumero[i] == 0)
                {
                    //mettre le joueur rouge
                    pnlRouge.Location = listeBoutonsJeu[i].Location;
                }
                if (lstNumero[i] == 4)
                {
                    //mettre le joueur vert
                    pnlVert.Location = listeBoutonsJeu[i].Location;
                }
            }
            tableauAleatoire(6, lstSix);
            for (int j = 0; j < 6; j++)
            {
                for (int i = 0; i < CartesInnodation.Count; i++)
                {
                    if (listeBoutonsJeu[lstNumero[j]].BackgroundImage == CartesInnodation[i].ImagesBouton)
                    {
                        listeBoutonsJeu[lstNumero[j]].BackgroundImage = listeImageInnod[i].ImageInondation;
                    }
                }
            }
        }
        private void tableauAleatoire(int tailleTab, List<int> lst)
        {
            //  Random class pour creer nb
            Random rndNb = new Random();

            // Generer  random numero entre 0 et 23
            int number = rndNb.Next(0, 23 + 1);
            lst.Add(number);
            // compteur pour arreter 
            int count = 0;

            do // Repete
            {
                number = rndNb.Next(0, 23 + 1);
                // Si numero n'est pas dans la list...
                if (!lst.Contains(number))
                {
                    // ajouter
                    lst.Add(number);
                    count++;
                }

                // Incremente le compteur
                count++;
            } while (count < 10 * tailleTab); // Faire ...
        }
        private void NiveauDeau()
        {
            trcbNiveauJeu.Value = niveau;

        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnRegles_Click(object sender, EventArgs e)
        {
            Regles Regles = new Regles();
            Regles.Show();
        }
        //methode qui ouvre cartes innodation
        private void btnInnodation_Click(object sender, EventArgs e)
        {
            btnDefInod.Text = String.Empty;

            if (numInnod <= 23)
            {
                if (trcbNiveauJeu.Value < 4)
                {
                    for (int i = 0; i <= 1; i++)
                    {
                        btnDefInod.BackgroundImage = CartesInnodation[numInnod].ImagesBouton;
                        PlacerLeau(numInnod);
                        PlacerCartesInnodation();
                    }
                }
                if (trcbNiveauJeu.Value >= 4 & trcbNiveauJeu.Value < 6)
                {
                    for (int i = 0; i <= 2; i++)
                    {
                        btnDefInod.BackgroundImage = CartesInnodation[numInnod].ImagesBouton;
                        PlacerLeau(numInnod);
                        PlacerCartesInnodation();
                    }
                }
                if (trcbNiveauJeu.Value >= 6 & trcbNiveauJeu.Value < 8)
                {
                    for (int i = 0; i <= 3; i++)
                    {
                        btnDefInod.BackgroundImage = CartesInnodation[numInnod].ImagesBouton;
                        PlacerLeau(numInnod);
                        PlacerCartesInnodation();
                    }
                }
                if (trcbNiveauJeu.Value >= 8 & trcbNiveauJeu.Value < 10)
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        btnDefInod.BackgroundImage = CartesInnodation[numInnod].ImagesBouton;
                        PlacerLeau(numInnod);
                        PlacerCartesInnodation();
                    }
                }
                if (trcbNiveauJeu.Value == 10)
                {
                    AfficherPerdu();
                }
            }
            else
            {
                numInnod = 0;
            }
            btnInnodation.Enabled = false;
        }
        //methide qui compte les cartes et commenceavec premier
        private void PlacerCartesInnodation()
        {
            if (numInnod < 23)
            {
                numInnod++;
            }
            else
            {
                numInnod = 0;
            }

        }
        //methode qui affiche Form Perdu
        private void AfficherPerdu()
        {
            FrmResultat perdu = new FrmResultat(trcbNiveauJeu.Value);
            perdu.BackgroundImage = Properties.Resources.lost1;
            perdu.Show();
            this.Hide();
        }
        //methode suit de placer l'eau sur les boutines du jeu
        private void PlacerLeau(int indice)
        {
            Image water = Properties.Resources.Water2;
            for (int i = 0; i < listeBoutonsJeu.Count; i++)
            {
                    if (listeBoutonsJeu[i].BackgroundImage == CartesInnodation[indice].ImagesBouton)
                    {
                        listeBoutonsJeu[i].BackgroundImage = listeImageInnod[indice].ImageInondation;
                    }
                    else if (listeBoutonsJeu[i].BackgroundImage == listeImageInnod[indice].ImageInondation)
                        {
                            listeBoutonsJeu[i].BackgroundImage = water;
                            listeBoutonsJeu[i].Tag = i;
                            listeBoutonsJeu[i].Enabled = false;
                        }
                    }
            VerifierLeau();
                }
        //methode qui verifier si touts les boutons ont l'image du l'eau
        public void VerifierLeau()
        {
            int somme = 0;//verifier les image des boutons
            for (int i = 0; i < listeBoutonsJeu.Count; i++)
            {
                if ((int)listeBoutonsJeu[i].Tag != eau)
                {
                    somme++;
                }              
            }
            if (somme == 24)
            {
                AfficherPerdu();
            }
        }
        //methode qui faire le bouton rouge actif
        private void ActiverBoutonRouge()
        {
            foreach (Button btn in listeBoutonsJeu)
            {
                btn.Enabled = false;             
            }
            //faire les boutons actif
            for (int i = 0; i < listeBoutonsJeu.Count; i++)
            {
                if (listeBoutonsJeu[i].Location.X == pnlRouge.Location.X & listeBoutonsJeu[i].Location.Y == pnlRouge.Location.Y & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X == pnlRouge.Location.X - 115 & listeBoutonsJeu[i].Location.Y == pnlRouge.Location.Y & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X == pnlRouge.Location.X + 115 & listeBoutonsJeu[i].Location.Y == pnlRouge.Location.Y & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X == pnlRouge.Location.X & listeBoutonsJeu[i].Location.Y == pnlRouge.Location.Y - 115 & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X == pnlRouge.Location.X & listeBoutonsJeu[i].Location.Y == pnlRouge.Location.Y + 115 & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
            }
          

        }
        //methode qui joue la role dujoueur rouge
        public void JouerRouge()
        {
            //lblActRouge.ForeColor = Color.Red;
            lblActRouge.BackColor = Color.OrangeRed;
            cmptRouge = 1;
            //tourRouge = true;
            ActiverBoutonRouge();
          
        }
        //methode qui joue la role dujoueur vert
        public void JouerVert()
        {
            //lblActVert.ForeColor = Color.Red;
            lblActVert.BackColor = Color.OrangeRed;
            cmptVert = 1;
           // tourVert = true;
            ActiverBoutonVert();
        }
        //methode qui faire le bouton rouge actif
        public void ActiverBoutonVert()
        {
            foreach (Button btn in listeBoutonsJeu)
            {
                btn.Enabled = false;
            }
            //faire les boutons actif
            for (int i = 0; i < listeBoutonsJeu.Count; i++)
            {
                if (listeBoutonsJeu[i].Location.X == pnlVert.Location.X & listeBoutonsJeu[i].Location.Y == pnlVert.Location.Y & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X - 115 == pnlVert.Location.X & listeBoutonsJeu[i].Location.Y == pnlVert.Location.Y & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X + 115 == pnlVert.Location.X & listeBoutonsJeu[i].Location.Y == pnlVert.Location.Y & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X == pnlVert.Location.X & listeBoutonsJeu[i].Location.Y == pnlVert.Location.Y - 115 & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X == pnlVert.Location.X & listeBoutonsJeu[i].Location.Y == pnlVert.Location.Y + 115 & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X - 115 == pnlVert.Location.X & listeBoutonsJeu[i].Location.Y == pnlVert.Location.Y - 115 & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X - 115 == pnlVert.Location.X & listeBoutonsJeu[i].Location.Y == pnlVert.Location.Y + 115 & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X + 115 == pnlVert.Location.X & listeBoutonsJeu[i].Location.Y == pnlVert.Location.Y - 115 & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
                if (listeBoutonsJeu[i].Location.X + 115 == pnlVert.Location.X & listeBoutonsJeu[i].Location.Y == pnlVert.Location.Y + 115 & (int)listeBoutonsJeu[i].Tag == eau)
                {
                    listeBoutonsJeu[i].Enabled = true;
                }
            }

        }
        //methode qui faire 3 action pour les deux joueurs
        public void JouerPartie(Button button)
        {
            if (secher)
            {
                SecherBouton(button);
                secher = false;
            }
            if (!btnInnodation.Enabled)
            {
                //partie Rouge
                if (cmptRouge > 0 & cmptRouge < 4)
                {
                    tourRouge = true;
                    if (rdbDepRouge.Checked)
                    {
                        pnlRouge.Location = button.Location;
                        rdbDepRouge.Checked = false;
                        cmptRouge++;
                    }
                    if (rdbAssecRouge.Checked)
                    {
                        SecherBouton(button);
                        rdbAssecRouge.Checked = false;
                        cmptRouge++;
                    }
                    lbNbRouge.Text = Convert.ToString(cmptRouge - 1);
                    ActiverBoutonRouge();
                    if (pnlRouge.Location == pnlVert.Location)
                    {
                        EchangeCartes(cmptRouge, BoutonsRouge);
                        //ActiverBoutonVert();
                        lbNbRouge.Text = Convert.ToString(cmptRouge - 1);
                    }
                }
                if (cmptRouge == 4)
                {
                    btnTresor.Enabled = true;
                    rdbTresVert.Checked = false;
                    MessageBox.Show("Prenez les cartes Tresor!");
                }
                //partie Vert
                if (cmptVert > 0 & cmptVert < 4)
                {
                    tourVert = true;
                    if (rdbDepVert.Checked)
                    {
                        pnlVert.Location = button.Location;
                        rdbDepVert.Checked = false;
                        cmptVert++;
                    }
                    if (rdbAssecVert.Checked)
                    {
                        SecherBouton(button);
                        rdbAssecVert.Checked = false;
                        cmptVert++;
                    }
                    lbNbVert.Text = Convert.ToString(cmptVert - 1);
                    ActiverBoutonVert();
                    if (pnlRouge.Location == pnlVert.Location)
                    {
                        EchangeCartes(cmptVert, BoutonsVert);
                        //ActiverBoutonRouge();
                        lbNbVert.Text = Convert.ToString(cmptVert - 1);
                    }
                }
                if (cmptVert == 4)
                {
                    btnTresor.Enabled = true;
                    MessageBox.Show("Prenez les cartes Tresor!");
                }
            }
            else
            {
                MessageBox.Show("Prenez les cartes Inondation!");
            }
        }
        private void SecherBouton(Button button)
        {
            for (int j = 0; j < CartesInnodation.Count; j++)
            {
                if (button.BackgroundImage == listeImageInnod[j].ImageInondation)
                {
                    button.BackgroundImage = CartesInnodation[j].ImagesBouton;
                }
               
            }
        }
        public void EchangeCartes(int compteur, List<Button> listeBoutons)
        {
            pnlVert.Location = new Point(pnlVert.Location.X+50, pnlVert.Location.Y);
            var result = MessageBox.Show("Voulez-vous donner une carte Tresor ?", "",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Sélectionner une carte !");
                echange = true;
                for (int i = 0; i < listeBoutons.Count; i++)
                {
                    listeBoutons[i].Enabled = true;
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
           JouerPartie(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JouerPartie(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            JouerPartie(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            JouerPartie(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            JouerPartie(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            JouerPartie(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            JouerPartie(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            JouerPartie(button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            JouerPartie(button9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            JouerPartie(button10);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            JouerPartie(button11);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            JouerPartie(button12);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            JouerPartie(button13);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            JouerPartie(button14);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            JouerPartie(button15);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            JouerPartie(button16);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            JouerPartie(button17);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            JouerPartie(button18);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            JouerPartie(button19);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            JouerPartie(button20);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            JouerPartie(button21);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            JouerPartie(button22);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            JouerPartie(button23);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            JouerPartie(button24);
        }
        public void EnleverCarte(List<Button> bouton)
        {
            if (bouton[5].BackgroundImage != null)
            {
                MessageBox.Show("Il faut choisir et défausser la carte de trop!");
                for (int i = 0; i < bouton.Count; i++)
                {
                    bouton[i].Enabled = true;
                }
                tropCarte = true;
            }
        }

        private void btnTresor_Click(object sender, EventArgs e)
        {
             btnDefTresor.Text = String.Empty;
           
             if (tourRouge)
             {
                 CompareImageEau(BoutonsRouge);                
                 
                 btnInnodation.Enabled = true;
                 tourRouge = false;
                 lblActRouge.BackColor = Color.NavajoWhite;
                 cmptRouge = 0;
                 lbNbRouge.Text = Convert.ToString(cmptRouge);
                 EnleverCarte(BoutonsRouge);
                 JouerVert();               
             }

             if (tourVert)
             {
                 CompareImageEau(BoutonsVert);
                
                 btnInnodation.Enabled = true;
                 tourVert = false;
                 lblActVert.BackColor = Color.NavajoWhite;
                 cmptVert = 0;
                 lbNbVert.Text = Convert.ToString(cmptVert);
                 EnleverCarte(BoutonsVert);
                 JouerRouge();
             }
             btnTresor.Enabled = false;
             if (!tropCarte)
             {
                 MessageBox.Show("Prenez les cartes Inondation!");
             }

        }
    
        //methode qui faire comparaisone des cartes Tresor avec image d'eau
        public void CompareImageEau(List<Button> boutonJoueur)
        {
            bool existe = false;
            if (resteCarte)
            {
                comptCartDef = 1;
                resteCarte = false;
            }
            for (comptCartDef = 0; comptCartDef <= 1; comptCartDef++)
            {
                btnDefTresor.BackgroundImage = listeCartesTresor[numTresor].ImageTresor;
                for (int k = 0; k < imageEau.Count; k++)
                {
                    if ((int)listeCartesTresor[numTresor].ImageTresor.Tag == imageEau[k])
                    {
                        existe = true;
                        FrmLeau leau = new FrmLeau();
                        leau.Show();
                        trcbNiveauJeu.Value++;
                    }
                }
                for (int j = 0; j < boutonJoueur.Count; j++)
                {
                   
                        if (boutonJoueur[j].BackgroundImage == null & !existe)
                        {
                            boutonJoueur[j].BackgroundImage = listeCartesTresor[numTresor].ImageTresor;
                            boutonJoueur[j].BackgroundImage.Tag = listeCartesTresor[numTresor].ImageTresor.Tag;
                            break;
                        }                    
                }
                if (numTresor < 27)
                {
                    numTresor++;
                }
                else
                {
                    numTresor = 0;
                }
            }
        }
        //methode qui faire echange des cartes entre les joueurs
        public void DonnerCarte(List<Button> Boutons, Button btnActif, int compt)
        {
            
                for (int i = 0; i < Boutons.Count; i++)
                {
                    if (Boutons[i].BackgroundImage == null)
                    {
                        Boutons[i].BackgroundImage = btnActif.BackgroundImage;
                        btnActif.BackgroundImage = null;
                    }
                
                echange = false;              
            }
        }
        private void DeffocerCarte(Button btnActif, List<Button> Boutons)
        {
            btnDefTresor.BackgroundImage = btnActif.BackgroundImage;
            btnActif.BackgroundImage = null;
            for (int i = 0; i < Boutons.Count; i++)
            {
                if (Boutons[i].BackgroundImage == null)
                {
                    Boutons[i].BackgroundImage = Boutons[5].BackgroundImage;
                    Boutons[5].BackgroundImage = null;
                }
            }
            tropCarte = false;
            if (resteCarte)
            {
                CompareImageEau(Boutons);
        
            }
            MessageBox.Show("Prenez les cartes Inondation!");
        }

        private void btnRouge1_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsVert, btnRouge1, cmptRouge);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnRouge1, BoutonsRouge);
            }
            ComparerImajeSable(btnRouge1, BoutonsRouge);
        }

        private void btnRouge2_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsVert, btnRouge2, cmptRouge);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnRouge2, BoutonsRouge);
            }
            ComparerImajeSable(btnRouge2, BoutonsRouge);
        }

        private void btnRouge3_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsVert, btnRouge3, cmptRouge);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnRouge3, BoutonsRouge);
            }
            ComparerImajeSable(btnRouge3, BoutonsRouge);
        }

        private void btnRouge4_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsVert, btnRouge4, cmptRouge);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnRouge4, BoutonsRouge);
            }
            ComparerImajeSable(btnRouge4, BoutonsRouge);
        }

        private void btnRouge5_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsVert, btnRouge5, cmptRouge);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnRouge5, BoutonsRouge);
            }
            ComparerImajeSable(btnRouge5, BoutonsRouge);
        }

        private void btnRouge6_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsVert, btnRouge6, cmptRouge);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnRouge6, BoutonsRouge);
            }
            ComparerImajeSable(btnRouge6, BoutonsRouge);
        }

        private void btnVert1_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsRouge, btnVert1, cmptVert);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnVert1, BoutonsVert);
            }
            ComparerImajeSable(btnVert1, BoutonsVert);
        }

        private void btnVert2_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsRouge, btnVert2, cmptVert);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnVert2, BoutonsVert);
            }
            ComparerImajeSable(btnVert2, BoutonsVert);
        }

        private void btnVert3_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsRouge, btnVert3, cmptVert);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnVert3, BoutonsVert);
            }
            ComparerImajeSable(btnVert3, BoutonsVert);
        }

        private void btnVert4_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsRouge, btnVert4, cmptVert);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnVert4, BoutonsVert);
            }
            ComparerImajeSable(btnVert4, BoutonsVert);
        }

        private void btnVert5_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsRouge, btnVert5, cmptVert);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnVert5, BoutonsVert);
            }
            ComparerImajeSable(btnVert5, BoutonsVert);
        }

        private void btnVert6_Click(object sender, EventArgs e)
        {
            if (echange)
            {
                DonnerCarte(BoutonsRouge, btnVert6, cmptVert);
            }
            if (tropCarte)
            {
                DeffocerCarte(btnVert6, BoutonsVert);
            }
            ComparerImajeSable(btnVert6, BoutonsVert);
        }
        private void ComparerImajeSable(Button bouton, List<Button> listeBoutons)
        {          
            for (int k = 0; k < imageSable.Count; k++)
            {
                if ((int)bouton.BackgroundImage.Tag == imageSable[k])
                {
                    secher = true;
                }
            }
            if (secher)
            {
                var result = MessageBox.Show("Voulez-vous sécher ?", "",
                                               MessageBoxButtons.YesNo,
                                               MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (Button btn in listeBoutonsJeu)
                    {
                        btn.Enabled = true;
                    }
                }
                else
                {
                    secher = false;
                }
                DeffocerCarte(bouton, listeBoutons);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
            
            }
        }
    
