using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class CarteInnod
    {

        //liste des images inondation
        static List<Image> listeImagesInondation = new List<Image>();
        
        public Image ImageInondation
        {
            get;
            private set;
        }

        public CarteInnod(int position)
        {
            ImageInondation = listeImagesInondation[position];
         
        }

        //ajouter les images dans la liste inondation
        public static void MettreImagesDansListeInondation()
        {
            listeImagesInondation.Add(Properties.Resources.bronze_gate_flooded);
            listeImagesInondation.Add(Properties.Resources.cave_embers_flooded);
            listeImagesInondation.Add(Properties.Resources.cave_of_shadows_flooded);
            listeImagesInondation.Add(Properties.Resources.cliff_of_abandon_flooded);
            listeImagesInondation.Add(Properties.Resources.copper_gate_flooded);
            listeImagesInondation.Add(Properties.Resources.coral_palace_flooded);
            listeImagesInondation.Add(Properties.Resources.crimson_forest_flooded);
            listeImagesInondation.Add(Properties.Resources.dunes_of_deception_flooded);
            listeImagesInondation.Add(Properties.Resources.fools_landing_flooded);
            listeImagesInondation.Add(Properties.Resources.gold_gate_flooded);
            listeImagesInondation.Add(Properties.Resources.howling_garden_flooded);
            listeImagesInondation.Add(Properties.Resources.iron_gate_flooded);
            listeImagesInondation.Add(Properties.Resources.lost_lagoon_flooded);
            listeImagesInondation.Add(Properties.Resources.misty_march_flooded);
            listeImagesInondation.Add(Properties.Resources.observatory_flooded);
            listeImagesInondation.Add(Properties.Resources.phantom_rock_flooded);
            listeImagesInondation.Add(Properties.Resources.silver_gate_flooded);
            listeImagesInondation.Add(Properties.Resources.temple_of_the_moon_flooded);
            listeImagesInondation.Add(Properties.Resources.temple_of_the_sun_flooded);
            listeImagesInondation.Add(Properties.Resources.tidal_palace_flooded);
            listeImagesInondation.Add(Properties.Resources.twilight_hollow_flooded);
            listeImagesInondation.Add(Properties.Resources.watchtower_flooded);
            listeImagesInondation.Add(Properties.Resources.whispering_garden_flooded);
            listeImagesInondation.Add(Properties.Resources.breakers_bridge_flooded);

        }
    }
}
