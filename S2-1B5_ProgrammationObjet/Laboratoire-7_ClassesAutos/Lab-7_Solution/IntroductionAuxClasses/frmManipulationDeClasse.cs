using System;
using System.Windows.Forms;

namespace IntroductionAuxClasses
{
    public partial class frmManipulationDeClasse : Form
    {
        public string[] m_tCouleurs;
        public Auto m_auto1, m_auto2;

        public frmManipulationDeClasse()
        {
            InitializeComponent();
            m_tCouleurs = new string[7] { "bleu", "blanc", "rouge", "noir", "jaune", "orange", "vert" };
            btnAfficherInformationsInstances.Enabled = false;
            btnChangerProprietesAuto2.Enabled = false;
            lblMarque.Enabled = false;
            txtMarque.Enabled = false;
            lblCouleur.Enabled = false;
            txtCouleur.Enabled = false;
            lblAnnee.Enabled = false;
            txtAnnee.Enabled = false;
        }

        public void ActiverChampsEtBoutons()
        {
            btnAfficherInformationsInstances.Enabled = true;
            btnChangerProprietesAuto2.Enabled = true;
            lblMarque.Enabled = true;
            txtMarque.Enabled = true;
            lblCouleur.Enabled = true;
            txtCouleur.Enabled = true;
            lblAnnee.Enabled = true;
            txtAnnee.Enabled = true;
        }

        private void btnInstanciationDeuxAutos_Click(object sender, EventArgs e)
        {
            m_auto1 = new Auto();
            m_auto1.m_marque = "corvette";
            m_auto1.m_couleur = "brun";
            m_auto1.m_annee = 1999;
            m_auto2 = new Auto("corvette", "brun", 1999);
            ActiverChampsEtBoutons();
        }

        private void btnAfficherInformationsInstances_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Instance 1 : " + m_auto1.Information());
            MessageBox.Show("Instance 2 : " + m_auto2.Information());
        }

        private void btnChangerProprietesAuto2_Click(object sender, EventArgs e)
        {
            int indiceCouleur, annee;
            if (txtMarque.Text == "")
            {
                return;
            }
            if (!int.TryParse(txtCouleur.Text, out indiceCouleur) || !int.TryParse(txtAnnee.Text, out annee))
            {
                return;
            }
            m_auto2.m_marque = txtMarque.Text;
            m_auto2.m_annee = annee;
            m_auto2.ChangeCouleur(m_tCouleurs, indiceCouleur);
        }

        private void lblCouleur_MouseHover(object sender, EventArgs e)
        {
            lblCouleurs.Text = "bleu blanc rouge noir jaune orange vert"; 
        }

        private void lblCouleur_MouseLeave(object sender, EventArgs e)
        {
            lblCouleurs.Text = "";
        }
    }
}
