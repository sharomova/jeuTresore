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
    public partial class Regles : Form
    {
        int compteur = 0;  // copteur pour compter le nombre des pages
        // Les images avec des regles du jeu
        Image page1 = Properties.Resources.page1; 
        Image page2 = Properties.Resources.page2;
        Image page3 = Properties.Resources.page3;
        Image page4 = Properties.Resources.page4;
        Image page5 = Properties.Resources.page5;
        Image page6 = Properties.Resources.page6;
        Image page7 = Properties.Resources.page7;
        Image page8 = Properties.Resources.page8;
        
        public Regles()
        {
            InitializeComponent();
        }
         
        //pour fermer la fenetre des regles
        private void btnMenu_Click(object sender, EventArgs e)
        {
                 this.Hide();
        }

        // methode qui affiche chaque page suivant
        private void btnSuivant_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (compteur == 0)
                {
                    pctPageGauche.BackgroundImage = page3;
                    pctPageDroite.BackgroundImage = page4;
                    compteur++;
                    break;// arreter le compteur
                }
                if (compteur == 1)
                {
                    pctPageGauche.BackgroundImage = page5;
                    pctPageDroite.BackgroundImage = page6;
                    compteur++;
                    break;// arreter le compteur
                }
                if (compteur == 2)
                {
                    pctPageGauche.BackgroundImage = page7;
                    pctPageDroite.BackgroundImage = page8;
                    compteur++;
                    break;// arreter le compteur
                }
            }

        }

        // methode qui affiche chaque page precedent
        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (compteur == 1)
                {
                    pctPageGauche.BackgroundImage = page1;
                    pctPageDroite.BackgroundImage = page2;
                    compteur--;
                    break;// arreter le compteur
                }
                if (compteur == 2)
                {
                    pctPageGauche.BackgroundImage = page3;
                    pctPageDroite.BackgroundImage = page4;
                    compteur--;
                    break;// arreter le compteur
                }
                if (compteur == 3)
                {
                    pctPageGauche.BackgroundImage = page5;
                    pctPageDroite.BackgroundImage = page6;
                    compteur--;
                    break;// arreter le compteur
                }
            }
        }
    }
}
