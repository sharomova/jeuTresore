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
    public partial class FrmResultat : Form
    {
        int niveau;
        int resultat;
        public FrmResultat(int resultat)
        {
            this.resultat = resultat;
            InitializeComponent();
            AfficgerResultat();
            
        }
        private void AfficgerResultat()
        {
            if (resultat == 10)
            {
                lblResultat.Text = "Vous avez perdu !";
            }
        }
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            FrmDebut debut = new FrmDebut();
            debut.Show();
            FrmJeu jeu = new FrmJeu(niveau);
            jeu.Hide();
            this.Hide();
        }
    }
}
