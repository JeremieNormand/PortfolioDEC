using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Televisions.Properties;

namespace Televisions.Classes
{
    public class Monstre : Combattant
    {
        private List<string> types;
        protected string determinerType() { return types[rnd.Next(types.Count)]; }
        private string type;
        public string Type { get { return type; } }

        public Monstre(Panel tv) : base(tv)
        {
            types = new List<string>
            {
                "Spectre",
                "Troll"
            };
            type = determinerType();

            couleurs = new List<Color>
            {
                Color.FromArgb(64, 148, 0, 211),
                Color.FromArgb(64, 0, 250, 154),
                Color.FromArgb(64, 255, 255, 0)
            };
            couleur = determinerCouleur();

            avatars = new List<Image>
            {
                Resources.monstre_a,
                Resources.monstre_b
            };
            avatar = new Bitmap(determinerAvatar(), diametre, diametre);

            chakras = byte.MaxValue / 16; //
        }
    }
}
