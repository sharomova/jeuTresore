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
    public partial class FrmDebut : Form
    {
        public FrmDebut()
        {
            InitializeComponent();
        }

        private void regles_Click(object sender, EventArgs e)
        {
            Regles Regles = new Regles();
            Regles.Show();
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            FrmOptions options = new FrmOptions();
            options.Show();
            this.Hide();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
