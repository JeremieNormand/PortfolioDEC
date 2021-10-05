/*******************************************************
 * TP8 - Bonhomme Pendu
 * Logique de programmation (420-1A5-LL)
 * Session Automne 2019
 * Par Jeremie Normand
 * En date du : 2020-11-19
 * ****************************************************/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP8Pendu
{
    public partial class frmPendu : Form
    {
        System.Random m_GenerateurAleatoire = new System.Random(System.DateTime.Now.Millisecond);
        int m_EtapeDessin;
        int m_NombreEssais;
        int m_NombreDeLettres;
        string m_MotCherche;
        string m_MotATrouver;
        System.Drawing.Graphics m_FormsGraphics;
        string m_LettresPermises;

        public frmPendu()
        {
            InitializeComponent();
            m_FormsGraphics = panDessin.CreateGraphics();
            m_EtapeDessin = -1;
            m_LettresPermises = "ABCDEFGHIJKLMNOPQRSTUVWXYZ-";
        }

        // Méthode  qui traite 1 essai du joueur
        // Écrivez votre code dans cette méthode
        private void btnEssai_Click(object sender, EventArgs e)
        {
            // Valide le caractere entre par l'utilisateur
            if (!ValiderCaractere(txtLettre.Text, m_LettresPermises, txtLettresDejaEssayees.Text))
            {
                return;
            }

            /* Si valide */

            // Incremente le nombre d'essais de un
            txtNombreEssais.Text = Convert.ToString(++m_NombreEssais);

            // Ajoute la lettre au lettres deja essayees
            txtLettresDejaEssayees.Text += txtLettre.Text.ToUpper();

            // Determine l'action a entreprendre en fonction de si la lettre entree est presente dans le mot cherche
            if (DeterminerSiPresent(txtLettre.Text, m_MotCherche))
            {
                txtMotATrouver.Text = CompleterMot(txtMotATrouver.Text, m_MotCherche, txtLettre.Text);
            }
            else
            {
                m_EtapeDessin++;
                Dessine();
            }

            // Determine si l'utilisateur a gagner ou s'il a perdu, fait rien si la partie n'est pas terminee
            if (EstTrouve(txtMotATrouver.Text, m_MotCherche))
            {
                txtMessage.Text = "BRAVO";
                TerminerPartie();
            }
            else if (m_EtapeDessin > 8)
            {
                txtMessage.Text = "Meilleur chance la prochaine fois!";
                txtMotATrouver.Text = m_MotCherche;
                TerminerPartie();
            }

        }

        private bool ValiderCaractere(string Lettre, string LettresPermises, string LettresEssayees)
        {
            if (Lettre.Length != 1)
            {
                MessageBox.Show("Il doit y avoir un et un seul caractère dans Lettre.", "Validation de la Lettre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (LettresPermises.IndexOf(Lettre.ToUpper()) < 0)
            {
                MessageBox.Show("Le caractère entré n'est pas une lettre valide.", "Validation de la Lettre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (LettresEssayees.IndexOf(Lettre.ToUpper()) > -1)
            {
                MessageBox.Show("La lettre entrée a déjà été essayée.", "Validation de la Lettre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool DeterminerSiPresent(string Lettre, string Mot)
        {
            if (Mot.IndexOf(Lettre.ToUpper()) > -1)
            {
                return true;
            }

            return false;
        }

        private string CompleterMot(string MotIncomplet, string MotComplet, string Lettre)
        {
            string MotPartiellementComplet = "";
            for (int IndiceDeLettre = 0; IndiceDeLettre < MotComplet.Length; ++IndiceDeLettre)
            {
                if (MotComplet[IndiceDeLettre] == Lettre.ToUpper()[0])
                {
                    MotPartiellementComplet += MotComplet[IndiceDeLettre];
                }
                else
                {
                    MotPartiellementComplet += MotIncomplet[IndiceDeLettre];
                }
            }
            return MotPartiellementComplet;
        }

        private bool EstTrouve(string MotTrouve, string MotCherche)
        {
            if (MotTrouve == MotCherche)
            {
                return true;
            }

            return false;
        }

        private void TerminerPartie()
        {
            btnEssai.Enabled = false;
            txtLettre.Enabled = false;
            mnuNouvellePartie.Visible = true;
        }

        // Fonction qui initialise une nouvelle partie
        private void mnuNouvellePartie_Click(object sender, EventArgs e)
        {
            string[] ListeMots = new string[10]{    "AUTOMNE", "COLLEGE",
                                                    "ORDINATEUR", "FICHIER",
                                                    "LANGAGE", "SESSION",
                                                    "ECONOMIE", "SOUSBOIS",
                                                    "DIMANCHE", "JANVIER"};
            int indice;
            m_MotCherche = ListeMots[m_GenerateurAleatoire.Next(0, 10)];
            m_NombreDeLettres = m_MotCherche.Length;
            m_MotATrouver = "";
            for (indice = 0; indice < m_NombreDeLettres; indice++)
                m_MotATrouver += '?';
            txtMotATrouver.Text = m_MotATrouver;
            txtNombreLettres.Text = m_NombreDeLettres.ToString();
            m_EtapeDessin = -1;
            m_NombreEssais = 0;
            txtLettre.Text = "";
            txtMessage.Text = "";
            txtLettresDejaEssayees.Text = "";
            txtNombreEssais.Text = m_NombreEssais.ToString();
            panJeu.Visible = true;
            panJeu.Enabled = true;
            panDessin.Invalidate();
            mnuNouvellePartie.Visible = false;
            txtLettre.Enabled = true;
            btnEssai.Enabled = true;
            txtLettre.Focus();
        }
        //Fonction qui dessine une partie du bonhomme selon la variable m_Dessin
        public void Dessine()
        {
            SolidBrush MaBrosse = new SolidBrush(Color.Black);
            Pen MonCrayon = new Pen(MaBrosse, 4);
            int[,] TCoord ={{35, 30, 50, 50},
                            {60, 80, 60, 175},
                            {60, 175, 40, 225},
                            {60, 175, 80, 225},
                            {60, 130, 20, 120},
                            {60, 130, 100, 120},
                            {45, 40, 9, 9},
                            {65, 40, 9, 9},
                            {56, 55, 7, 7},
                            {50, 70, 70, 70}};
            if (m_EtapeDessin == 0 || m_EtapeDessin >= 6 && m_EtapeDessin <= 8)
                m_FormsGraphics.DrawEllipse(MonCrayon, TCoord[m_EtapeDessin, 0], TCoord[m_EtapeDessin, 1],
                TCoord[m_EtapeDessin, 2], TCoord[m_EtapeDessin, 3]);
            else if (m_EtapeDessin < 10)
                m_FormsGraphics.DrawLine(MonCrayon, TCoord[m_EtapeDessin, 0], TCoord[m_EtapeDessin, 1],
                TCoord[m_EtapeDessin, 2], TCoord[m_EtapeDessin, 3]);

            MaBrosse.Dispose();
            MonCrayon.Dispose();
        }
        // ré-Affichage du dessin lors du rafraîchissement de la fenêtre par Windows
        private void frmTP9Pendu_Paint(object sender, PaintEventArgs e)
        {
            int Temp = m_EtapeDessin;
            for (m_EtapeDessin = 0; m_EtapeDessin <= Temp; m_EtapeDessin++)
                Dessine();
            m_EtapeDessin = Temp;
        }
    }
}
