using System;
using System.Drawing;
using System.Windows.Forms;

namespace EvenementsEtGraphique
{
    public partial class frmEvenementsEtGraphique : Form
    {
        Graphics m_graphics;
        SolidBrush m_solidBrush;
        Random m_r;

        public frmEvenementsEtGraphique()
        {
            InitializeComponent();
            m_graphics = pnlZoneGraphique.CreateGraphics();
            m_solidBrush = new SolidBrush(Color.Blue);
            m_r = new Random();
        }

        //// Zone dessin du PANEL

        void DessinRond(Color couleur, int x, int y, int rayon)
        {
            m_solidBrush.Color = couleur;
            m_graphics.FillEllipse(m_solidBrush, x, y, 2 * rayon, 2 * rayon);
        }

        void btnInitialiserZoneGraphique_Click(object sender, EventArgs e)
        {
            int largeur = pnlZoneGraphique.Width;
            int hauteur = pnlZoneGraphique.Height;
            int rayon = 60;
            
            m_graphics.Clear(Color.WhiteSmoke);
            DessinRond(Color.PaleTurquoise, largeur / 2 - rayon , hauteur / 2 - rayon, rayon);
        }

        void pnlZoneGraphique_MouseClick(object sender, MouseEventArgs e)
        {
            DessinRond(Color.Red, e.X - 20, e.Y - 20, 20);
            DessinRond(Color.White, e.X - 10, e.Y - 10, 10);
        }

        void btnDessinerDixRonds_Click(object sender, EventArgs e)
        {
            int[,] tRonds = new int[10, 2];

            for (int rondCourant = 0; rondCourant < tRonds.GetLength(0); rondCourant++)
            {
                tRonds[rondCourant, 0] = m_r.Next(0, pnlZoneGraphique.Width);
                tRonds[rondCourant, 1] = m_r.Next(0, pnlZoneGraphique.Height);
            }

            DessinageRonds(tRonds);
        }

        void DessinageRonds(int[,] tRonds)
        {
            for (int rondCourant = 0; rondCourant < tRonds.GetLength(0); rondCourant++)
            {
                DessinRond(Color.Green, tRonds[rondCourant, 0] - 12, tRonds[rondCourant, 1] - 12, 12);
            }
        }

        // Bouton presse de la souris sur le FORM

        void tlyPrimaire_MouseDown(object sender, MouseEventArgs e)
        {
            cbClickGauche.Checked = true;
            cbClickDroit.Checked = true;
        }
        void tlyPrimaire_MouseUp(object sender, MouseEventArgs e)
        {
            cbClickGauche.Checked = false;
            cbClickDroit.Checked = false;
        }

        // Position de la souris dans le PANEL & Dessin de ronds noirs

        void pnlZoneGraphique_MouseMove(object sender, MouseEventArgs e)
        {
            lblPositionX.Text = e.X.ToString();
            lblPositionY.Text = e.Y.ToString();

            if (true) // A changer pour quelque chose ressemblant a : if (molette de souris enfonce)
            {
                DessinRond(Color.Black, e.X - 5, e.Y - 5, 5);
            }
        }
        void pnlZoneGraphique_MouseLeave(object sender, EventArgs e)
        {
            lblPositionX.Text = "";
            lblPositionY.Text = "";
        }

        // Touche du clavier presse sur le FORM

        void frmEvenementsEtGraphique_KeyDown(object sender, KeyEventArgs e)
        {
            lblToucheClavierPressee.Text = e.KeyCode.ToString();
        }
    }
}
