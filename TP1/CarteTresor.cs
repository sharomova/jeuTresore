using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class CarteTresor
    {
        //liste des images Tresor
       static List<Image> listeImagesTresor = new List<Image>();
     //liste de
        public Image ImageTresor
        {
            get;
            private set;
        }

        public CarteTresor(int position)
        {
            ImageTresor = listeImagesTresor[position];
        }

        //ajouter les images dans la liste Tresor
        public static void MettreImagesDansListeTresor()
        {
            listeImagesTresor.Add(Properties.Resources.sable);
            listeImagesTresor.Add(Properties.Resources.sable);
            for (int j = 0; j <= 2; j++)
            {
                listeImagesTresor.Add(Properties.Resources.helicopter2);
                listeImagesTresor.Add(Properties.Resources.eau);
            }
            for (int i = 0; i <= 4; i++)
            {
                listeImagesTresor.Add(Properties.Resources.card);
                listeImagesTresor.Add(Properties.Resources.leon2_1);
                listeImagesTresor.Add(Properties.Resources.feu);
                listeImagesTresor.Add(Properties.Resources.wind);
            }
        }
    }
}
