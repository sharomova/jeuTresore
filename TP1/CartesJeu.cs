using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    class CartesJeu 
    {    
        //liste des images
        static List<Image> listeImagesBouton = new List<Image>();

        public Image ImagesBouton 
        {
            get;
           private set;
        }

        public  CartesJeu(int position)
        {
            ImagesBouton = listeImagesBouton[position];
            MettreImagesDansListe();
        }
       

        //ajouter les images dans la liste
        public static void MettreImagesDansListe()
        {
                listeImagesBouton.Add(Properties.Resources.bronze_gate);
                listeImagesBouton.Add(Properties.Resources.cave_embers);
                listeImagesBouton.Add(Properties.Resources.cave_of_shadows);
                listeImagesBouton.Add(Properties.Resources.cliff_of_abandon);
                listeImagesBouton.Add(Properties.Resources.copper_gate);
                listeImagesBouton.Add(Properties.Resources.coral_palace);
                listeImagesBouton.Add(Properties.Resources.crimson_forest);
                listeImagesBouton.Add(Properties.Resources.dunes_of_deception);
                listeImagesBouton.Add(Properties.Resources.fools_landing);
                listeImagesBouton.Add(Properties.Resources.gold_gate);
                listeImagesBouton.Add(Properties.Resources.howling_garden);
                listeImagesBouton.Add(Properties.Resources.iron_gate);
                listeImagesBouton.Add(Properties.Resources.lost_lagoon);
                listeImagesBouton.Add(Properties.Resources.misty_march);
                listeImagesBouton.Add(Properties.Resources.observatory);
                listeImagesBouton.Add(Properties.Resources.phantom_rock);
                listeImagesBouton.Add(Properties.Resources.silver_gate);
                listeImagesBouton.Add(Properties.Resources.temple_of_the_moon);
                listeImagesBouton.Add(Properties.Resources.temple_of_the_sun);
                listeImagesBouton.Add(Properties.Resources.tidal_palace);
                listeImagesBouton.Add(Properties.Resources.twilight_hollow);
                listeImagesBouton.Add(Properties.Resources.watchtower);
                listeImagesBouton.Add(Properties.Resources.whispering_garden);
                listeImagesBouton.Add(Properties.Resources.breakers_bridge);
            
        }

        public void ChangerImageBoutons(int positionImage)
        {
            //this.BackgroundImage = listeImagesBouton[positionImage];             
            
        }



        //internal void AjouterBoutons(CartesJeu button1, CartesJeu button2, CartesJeu button3, CartesJeu button4, CartesJeu button5, CartesJeu button6, CartesJeu button7, CartesJeu button8, CartesJeu button9, CartesJeu button10, CartesJeu button11, CartesJeu button12, CartesJeu button13, CartesJeu button14, CartesJeu button15, CartesJeu button16, CartesJeu button17, CartesJeu button18, CartesJeu button19, CartesJeu button20, CartesJeu button21, CartesJeu button22, CartesJeu button23, CartesJeu button24, List<int> lstNumero)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
