using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    class SuperBouton : Button
    {
        List<Button> listeBoutonsAdjacents = new List<Button>();
        public Button BtnGauche{
            get;
            set;
        }

        public Button BtnDroite
        {
            get;
            set;
        }

        public Button BtnHaut
        {
            get;
            set;
        }
        public Button BtnBas
        {
            get;
            set;
        }

        public SuperBouton()
        {
            
        }

        public void SetAllButtons(Button btnGauche, Button btnHaut, Button btnDroite, Button btnBas){
            BtnGauche = btnGauche;
            BtnHaut = btnHaut;
            BtnDroite = btnDroite;
            BtnBas = btnBas;
            
            listeBoutonsAdjacents.Add(BtnBas);
            listeBoutonsAdjacents.Add(BtnGauche);
            listeBoutonsAdjacents.Add(BtnDroite);
            listeBoutonsAdjacents.Add(BtnHaut);
        }

        public void EnableAll()
        {
            foreach (Button btn in listeBoutonsAdjacents)
            {
                btn.Enabled = true;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            EnableAll();
        }

        


    }
}
