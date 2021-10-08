using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Televisions.Classes
{
    public class Entite
    {
        protected Panel tv;
        protected Random rnd;

        protected List<Color> couleurs;
        protected Color determinerCouleur() { return couleurs[rnd.Next(couleurs.Count)]; }
        protected Color couleur;
        public Color Couleur { get { return couleur; } }

        protected int minDiametre;
        protected int maxDiametre;
        protected int determinerDiametre() { return rnd.Next(minDiametre, maxDiametre + 1); }
        protected int diametre;
        public int Diametre { get { return diametre; } }

        protected int determinerPlageX() { return tv.Width - diametre; }
        protected int determinerPlageY() { return tv.Height - diametre; }
        protected int plageX, plageY;

        protected int determinerX() { return rnd.Next(plageX + 1); }
        protected int determinerY() { return rnd.Next(plageY + 1); }
        protected int x, y;
        public int X { get { return x; } }
        public int Y { get { return y; } }

        protected int determinerDirection() { int dir; return (dir = rnd.Next(-1, 1 + 1)) != 0 ? dir : 1; }
        protected int directionX, directionY;

        protected int maxDeplacement;
        protected int determinerDeplacement() { return rnd.Next(maxDeplacement + 1); }
        protected int deplacementX, deplacementY;

        protected double intervaleSecondes;
        public double Intervale { get { return intervaleSecondes; } }

        protected byte restantSecondes;
        public byte Restant { get { return restantSecondes; } set { restantSecondes = value; } }

        public Entite(Panel tv)
        {
            this.tv = tv;
            rnd = new Random();
            couleurs = new List<Color> { Color.FromArgb(255, 255, 255), Color.FromArgb(128, 128, 128) }; //
            couleur = determinerCouleur();

            minDiametre = 8; //
            maxDiametre = 64; //
            diametre = determinerDiametre();
            plageX = determinerPlageX();
            plageY = determinerPlageY();
            x = determinerX();
            y = determinerY();
            directionX = determinerDirection();
            directionY = determinerDirection();
            maxDeplacement = 10; //
            deplacementX = determinerDeplacement();
            deplacementY = determinerDeplacement();

            intervaleSecondes = .001;
            restantSecondes = byte.MaxValue;
        }

        public void Bouger()
        {
            do
            {
                x += deplacementX * directionX;
                if ((x = x < 0 ? 0 : x) == 0 || (x = x > plageX ? plageX : x) == plageX) /* Rectification & Validation */
                {
                    directionX *= -1;
                }
                y += deplacementX * directionY;
                if ((y = y < 0 ? 0 : y) == 0 || (y = y > plageY ? plageY : y) == plageY) /* Rectification & Validation */
                {
                    directionY *= -1;
                }
                Thread.Sleep((int)(intervaleSecondes * 1000));
            }
            while (Restant != 0);
        }
    }
}
