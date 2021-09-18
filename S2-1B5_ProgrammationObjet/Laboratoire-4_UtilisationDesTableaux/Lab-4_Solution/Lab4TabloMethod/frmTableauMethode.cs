using System;
using System.Windows.Forms;

namespace Lab4TabloMethod
{
    public partial class frmTableauMethode : Form
    {
        // Déclaration et initialisation des tableaux membres  en même temps pour alléger le code

        string[] m_tVendeurs = { "Samuel", "Roger", "Josée", "Serge", "Yvan", "Julie", "Mélissa" };


        double[,] m_tVentesTrim = {     {1200, 2200, 2200},
                                        {1400, 1200, 1200},
                                        {2200, 1600, 1200},
                                        {1200, 1500, 1400},
                                        {2600, 1700, 2200},
                                        {1500, 1200, 1200},
                                        {2700, 1400, 2550}      };

        double[] m_tTotalVparTrimestre = new double[3];

        public frmTableauMethode()
        {
            InitializeComponent();
            cbVendeurs.SelectedItem = m_tVendeurs[0];
        }
        // Les méthodes à créer
        public void AfficherVendeurs()
        {
            string Affichage = "Nos redoutables vendeurs:\r-----------------------------------";
            // parcours du tableau des vendeurs et tous les afficher
            foreach (string vendeur in m_tVendeurs)
            {
                Affichage += "\n" + vendeur;
            }
            MessageBox.Show(Affichage);
        }

        public void AfficherVentesParVendeur()
        {
            string Affichage = "Ventes trimestrielles par vendeur:\r---------------------------------------------";
            // parcours du tableau des vendeurs et de tableau des ventes trimestrielles
            for (int vendeur = 0; vendeur < m_tVendeurs.Length; vendeur++)
            {
                Affichage += "\n" + m_tVendeurs[vendeur];
                for (int trimestre = 0; trimestre < m_tVentesTrim.GetLength(1); trimestre++)
                {
                    Affichage += "\t" + m_tVentesTrim[vendeur, trimestre].ToString("C");
                }
            }
            MessageBox.Show(Affichage);
        }

        public void AfficherVentesTotalesParTrimestre()
        {
            string Affichage = "Ventes totales par trimestre:\r---------------------------------------------";
            // parcours du tableau des ventes trimestrielles, placer les totaux dans m_tTotalVparTrimestre
            for (int trimestre = 0; trimestre < m_tVentesTrim.GetLength(1); trimestre++)
            {
                Affichage += "\n" + $"Trimestre {trimestre} :";
                for (int vendeur = 0; vendeur < m_tVentesTrim.GetLength(0); vendeur++)
                {
                    m_tTotalVparTrimestre[trimestre] += m_tVentesTrim[vendeur, trimestre];
                }
                Affichage += "\t" + m_tTotalVparTrimestre[trimestre].ToString("C");
                m_tTotalVparTrimestre[trimestre] = 0;
            }
            MessageBox.Show(Affichage);
        }

        public void AfficherVenteTotalVendeur()
        {
            double totalV = 0.0;
            int vendeur = 0;
            string Affichage = "Ventes totales du vendeur: " + cbVendeurs.SelectedItem + "\r---------------------------------------------\r";
            // recherche dans tableau des vendeurs, calculer la somme des ventes du vendeur sélectionné
            vendeur = Array.IndexOf(m_tVendeurs, cbVendeurs.SelectedItem);
            for (int trimestre = 0; trimestre < m_tVentesTrim.GetLength(1); trimestre++)
            {
                totalV += m_tVentesTrim[vendeur, trimestre];
            }
            Affichage += "\n" + totalV.ToString("C");
            MessageBox.Show(Affichage);
        }

        // Les méthodes associées aux boutons
        private void btnVendeurs_Click(object sender, EventArgs e)
        {
            AfficherVendeurs();
        }

        private void btnVentesParVendeurs_Click(object sender, EventArgs e)
        {
            AfficherVentesParVendeur();
        }

        private void btnAfficheTotalParTrimestres_Click(object sender, EventArgs e)
        {
            AfficherVentesTotalesParTrimestre();
        }

        private void btnAfficheVenteDuVendeur_Click(object sender, EventArgs e)
        {
            AfficherVenteTotalVendeur();
        }

        private void btnFaireDemandes_Click(object sender, EventArgs e)
        {
            AfficherVendeurs();
            AfficherVentesParVendeur();
            AfficherVentesTotalesParTrimestre();
            AfficherVenteTotalVendeur();
        }
    }
}
