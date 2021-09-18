using System;
using System.Drawing;
using System.Windows.Forms;
using Lab9Classe.Classes;

namespace Lab9Classe
{
    public partial class FrmMembresPublic : Form
    {
        Graphics m_gPanPhoto;
        SoleilPublic m_pubSoleil;
        AutoPublic m_pubAuto;

        public FrmMembresPublic()
        {
            InitializeComponent();
            m_gPanPhoto = panPhoto.CreateGraphics();
            m_pubSoleil = new SoleilPublic();
            m_pubAuto = new AutoPublic();
            cbxCouleurSoleil.SelectedIndex = 0;
            cbxRayonSoleil.SelectedIndex = 0;
            cbxCouleurAuto.SelectedIndex = 0;
            cbxCouleurRoue.SelectedIndex = 0;      
        }

        private void FrmMembresPublc_Shown(object sender, EventArgs e)
        {
            DessineSoleil();
            DessineAuto();
            btnAffiche.Enabled = false;
        }

        private void DessineSoleil()
        {
            SolidBrush soleil = new SolidBrush(m_pubSoleil.m_couleur);       
            m_gPanPhoto.FillEllipse(soleil, 300, 20, m_pubSoleil.m_rayon, m_pubSoleil.m_rayon);
        }
        private void DessineAuto()
        {
            SolidBrush auto = new SolidBrush(m_pubAuto.m_couleurAuto);
            Pen roue = new Pen(m_pubAuto.m_couleurRoue, 4);
            m_gPanPhoto.FillRectangle(auto, 100, 80, 100, 30);
            m_gPanPhoto.FillRectangle(auto, 125, 65, 40, 40);
            m_gPanPhoto.DrawEllipse(roue, 115, 100, 20, 20);
            m_gPanPhoto.DrawEllipse(roue, 165, 100, 20, 20);
        }

        private void btnAffiche_Click(object sender, EventArgs e)
        {
            m_gPanPhoto.Clear(Color.BurlyWood);
            DessineSoleil();
            DessineAuto();
            btnChoix.Enabled = true;
            btnAffiche.Enabled = false;
        }

        private void btnChoix_Click(object sender, EventArgs e)
        {
            m_pubSoleil.m_couleur = Color.FromName(cbxCouleurSoleil.SelectedItem.ToString());
            m_pubSoleil.m_rayon = Convert.ToInt32(cbxRayonSoleil.SelectedItem);

            m_pubAuto.m_couleurAuto = Color.FromName(cbxCouleurAuto.SelectedItem.ToString());
            m_pubAuto.m_couleurRoue = Color.FromName(cbxCouleurRoue.SelectedItem.ToString());

            btnChoix.Enabled = false;
            btnAffiche.Enabled = true;
        }
    }
}
