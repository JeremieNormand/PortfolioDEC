using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Televisions.Properties;

namespace Televisions.Classes
{
    public class Combattant : Entite
    {
        protected List<Image> avatars;
        protected Image determinerAvatar() { return avatars[rnd.Next(avatars.Count)]; }
        protected Image avatar;
        public Image Avatar { get { return avatar; } }

        protected byte gainChakras() { return (byte)rnd.Next((byte)Math.Log(byte.MaxValue + 1, 2)); }
        protected byte chakras;
        public byte Chakras { get { return chakras; } }
        public void AccroitreChakras() { chakras += gainChakras(); }

        public Combattant(Panel tv) : base(tv)
        {
            minDiametre = 32; //
            maxDiametre = 64; //
            diametre = determinerDiametre();
            plageX = determinerPlageX();
            plageY = determinerPlageY();

            avatars = new List<Image>
            {
                Resources.Combattant_0
            };
            avatar = new Bitmap(determinerAvatar(), diametre, diametre);

            chakras = 0;
        }
    }
}
