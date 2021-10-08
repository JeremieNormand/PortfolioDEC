using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Televisions.Classes
{
    public class Cercle : Entite
    {
        public Cercle(Panel tv) : base(tv)
        {
            minDiametre = 8; //
            maxDiametre = 16; //
            diametre = determinerDiametre();
            plageX = determinerPlageX();
            plageY = determinerPlageY();

            couleurs = new List<Color>
            {
                Color.Lime,
                Color.Orange,
                Color.Cyan,
                Color.Magenta,
                Color.Yellow
            };
            couleur = determinerCouleur();
        }
    }
}
