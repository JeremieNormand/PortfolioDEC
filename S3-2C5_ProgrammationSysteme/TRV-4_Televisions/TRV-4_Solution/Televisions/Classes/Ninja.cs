using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Televisions.Properties;

namespace Televisions.Classes
{
    public class Ninja : Combattant
    {
        private List<string> noms;
        protected string determinerNom() { return noms[rnd.Next(noms.Count)]; }
        private string nom;
        public string Nom { get { return nom; } }

        public Ninja(Panel tv) : base(tv)
        {
            noms = new List<string>
            {
                "Shikamaru",
                "Yamato",
                "Hinata",
                "Kimimaro",
                "Kakashi",
                "Naruto"
            };
            nom = determinerNom();

            couleurs = new List<Color>
            {
                Color.FromArgb(64, 173, 216, 230),
                Color.FromArgb(64, 135, 206, 235),
                Color.FromArgb(64, 135, 206, 250)
            };
            couleur = determinerCouleur();

            avatars = new List<Image>
            {
                Resources.ninja_konoha,
                Resources.ninja_sunagakure,
                Resources.ninja_anbu
            };
            avatar = new Bitmap(determinerAvatar(), diametre, diametre);

            if (nom == "Naruto")
            {
                couleur = Color.FromArgb(128, 255, 69, 0);
                avatar = new Bitmap(Resources.naruto, diametre, diametre);
                chakras = byte.MaxValue / 8; //
            }
        }
    }
}
