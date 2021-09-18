using System;
using System.Windows.Forms;

namespace LabSem6h2020
{
    public partial class frmExerMethode : Form
    {
        // variables membres
        int[] m_Tableau;
        Random m_r;
        int[,] m_t2D;

        public frmExerMethode()
        {
            InitializeComponent();
            m_Tableau = new int[25];
            m_r = new Random();
            m_t2D = new int[5,5];
            Reset25(); 
        }
        // Méthodes des no 1 à 6 de la première partie
        double Surface(double rayon) // 1)
        {
            double dSurface;
            dSurface = Math.PI * rayon * rayon; // ou Math.PI * Math.pow(rayon,2)
            return dSurface;
        }
        double CalculerPerimetreRectangle(double longueur, double largeur) // 2)
        {
            return 2 * longueur + 2 * largeur;
        }
        double CalculerVolumeSphere(double rayon) // 3)
        {
            return 4 * Math.PI * Math.Pow(rayon, 3) / 3;
        }
        bool DeterminerSiAnneeBissextile(int annee) // 4)
        {
            return (annee % 4 == 0 && annee % 100 != 0) || annee % 400 == 0 ? true : false;
        }
        double CalculerVolumeConeOuPyramide(double aireBase, double hauteur) // 5)
        {
            return aireBase * hauteur / 3;
        }
        double CalculerDistanceEntreDeuxPoints(double coord1X, double coord1Y, double coord2X, double coord2Y) // 6)
        {
            return Math.Sqrt(Math.Pow(coord2X - coord1X, 2) + Math.Pow(coord2Y - coord1Y, 2));
        }

        // Méthode Reset25 de la deuxième partie
        void Reset25()
        {
            for (int nombreCourant = 0; nombreCourant < m_Tableau.Length; nombreCourant++)
            {
                m_Tableau[nombreCourant] = m_r.Next(0, 100);
            }
        }
        // PREMIÈRE PARTIE
        //
        private void btnTestMethodes_Click(object sender, EventArgs e)
        { 
            // déclaration des variables locales
            double rayon, surface;
            // 1)
            if (double.TryParse(txtR.Text, out rayon) == false)
            {
                MessageBox.Show("Erreur de conversion du rayon");
            }
            //Appel
            surface = Surface(rayon);
            // Affichage
            MessageBox.Show("La surface d'un cercle de rayon " + rayon + " = " + surface);

            // 2)
            // Declaration
            double longueur, largeur;
            // Lecture et validation
            if (!double.TryParse(txtLongueur.Text, out longueur))
            {
                MessageBox.Show("La longueur doit etre un nombre.");
            }
            else if (!double.TryParse(txtLargeur.Text, out largeur))
            {
                MessageBox.Show("La largeur doit etre un nombre.");
            }
            else
            {
            // Appel et affichage
                MessageBox.Show($"Le perimetre d'un rectangle de longueur {longueur} et de largeur {largeur} = {CalculerPerimetreRectangle(longueur, largeur)}");
            }

            // 3)
            // Declaration
            
            // Lecture et validation
            if (!double.TryParse(txtR.Text, out rayon))
            {
                MessageBox.Show("Le rayon doit etre un nombre.");
            }
            else
            {
            // Appel et affichage
                MessageBox.Show($"Le volume d'une sphere de rayon {rayon} = {CalculerVolumeSphere(rayon)}");
            }

            // 4) 
            // Declaration
            int annee;
            // Lecture et validation
            if (!int.TryParse(txtAn.Text, out annee))
            {
                MessageBox.Show("L'annee doit etre un nombre entier.");
            }
            else
            {
            // Appel et affichage
                MessageBox.Show($"Est-ce que l'annee {annee} est une annee bissextille, {DeterminerSiAnneeBissextile(annee)}");
            }

            // 5) 
            // Declaration
            
            // Appel et affichage
            MessageBox.Show($"Le volume d'un cone ou d'une pyramide ayant un aire de base et une hauteur respectivement egal a 5 est de {CalculerVolumeConeOuPyramide(5, 5)}");
    
            // 6) 
            // Declaration
            double coord1X, coord1Y, coord2X, coord2Y;
            // Lecture et validation
            if (!double.TryParse(txtX1.Text, out coord1X))
            {
                MessageBox.Show("X1 doit etre un nombre.");
            }
            else if (!double.TryParse(txtY1.Text, out coord1Y))
            {
                MessageBox.Show("Y1 doit etre un nombre.");
            }
            else if (!double.TryParse(txtX2.Text, out coord2X))
            {
                MessageBox.Show("X2 doit etre un nombre.");
            }
            else if (!double.TryParse(txtY2.Text, out coord2Y))
            {
                MessageBox.Show("Y2 doit etre un nombre.");
            }
            else
            {
            // Appel et affichage
                MessageBox.Show($"La distance entre les points ({coord1X};{coord1Y}) et ({coord2X};{coord2Y}) est de {CalculerDistanceEntreDeuxPoints(coord1X, coord1Y, coord2X, coord2Y)}");
            }
        }
        // DEUXIÈME PARTIE
        // fait les exercices a) et b) de recherches dans un tableau 1D p.22-23 a) et b )
        private void btnTest25_Click(object sender, EventArgs e)
        {   
            //a)
            int[,] tValeurs = new int[10, 14];
            for (int ligne = 0; ligne < tValeurs.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < tValeurs.GetLength(1); colonne++)
                {
                    tValeurs[ligne, colonne] = (ligne + 1) * 10 + colonne;
                }
            }

            //b)
            int SommeLigne = 0; // somme de la derniere ligne de ^
            for (int colonne = 0; colonne < tValeurs.GetLength(1); colonne++)
            {
                SommeLigne += tValeurs[tValeurs.GetLength(0) - 1, colonne];
            }
            MessageBox.Show($"La somme de la derniere ligne est de {SommeLigne}.");

        }
        // Renouvelle le contenu du tableau 1D de 25 int
        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset25();
        }

        // place le tableau 1D membre de 25 int dans un tableau 2D membre 5x5 int
        private void btnInit5x5_Click(object sender, EventArgs e)
        {
            for (int ligne = 0; ligne < m_t2D.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < m_t2D.GetLength(1); colonne++)
                {
                    m_t2D[ligne, colonne] = m_Tableau[ligne * m_t2D.GetLength(1) + colonne];
                }
            }
        }

        // refait les recherches du bouton btnTest25 dans le tableau 5x5
        private void btnTest5x5_Click(object sender, EventArgs e)
        {
            //a)
            int NombreMax = m_t2D[0, 0];
            int[] CoordNombreMax = { 0, 0 };
            for (int ligne = 0; ligne < m_t2D.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < m_t2D.GetLength(1); colonne++)
                {
                    if (NombreMax < m_t2D[ligne, colonne])
                    {
                        NombreMax = m_t2D[ligne, colonne];
                        CoordNombreMax[0] = ligne;
                        CoordNombreMax[1] = colonne;
                    }
                }
            }
            MessageBox.Show($"La valeur max est de {NombreMax} et elle est au coordonnees ({CoordNombreMax[0]};{CoordNombreMax[1]}).");

            //b)
            int NbFrequenceDe1 = 0;
            for (int ligne = 0; ligne < m_t2D.GetLength(0); ligne++)
            {
                for (int colonne = 0; colonne < m_t2D.GetLength(1); colonne++)
                {
                    if (m_t2D[ligne, colonne] == 1)
                    {
                        NbFrequenceDe1++;
                    }
                }
            }
            MessageBox.Show($"Le frequence d'apparition du nombre 1 est de {NbFrequenceDe1}.");
        }

    }
}
