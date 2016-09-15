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
    public partial class FrmOptions : Form
    {
        public FrmOptions()
        {
            InitializeComponent();
            trbNiveau.Value = 2;
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            FrmJeu jeu = new FrmJeu(trbNiveau.Value);
            jeu.Show();
            this.Hide();
        }

        private void trbNiveau_Scroll(object sender, EventArgs e)
        {
           
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            FrmDebut menu = new FrmDebut();
            menu.Show();
            this.Hide();
        }
    }
}
