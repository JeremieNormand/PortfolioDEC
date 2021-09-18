using System;
using System.Drawing;
using System.Windows.Forms;
using Lab9Classe.Classes;

namespace Lab9Classe
{
    public partial class FrmMembresPrivate : Form
    {
        Graphics m_gPanPhoto;
        SoleilPrivate m_Soleil;
        AutoPrivate m_Auto;

        public FrmMembresPrivate()
        {
            InitializeComponent();
            m_gPanPhoto = panPhoto.CreateGraphics();
            m_Soleil = new SoleilPrivate();
            m_Auto = new AutoPrivate();
            cbxCouleurSoleil.SelectedIndex = 0;
            cbxRayonSoleil.SelectedIndex = 0;
            cbxCouleurAuto.SelectedIndex = 0;
            cbxCouleurRoue.SelectedIndex = 0;
        }

        private void FrmMembresPrivate_Shown(object sender, EventArgs e)
        {
            DessineSoleil();
            DessineAuto();
            btnAffiche.Enabled = false;
        }

        private void DessineSoleil()
        {
            SolidBrush soleil = new SolidBrush(m_Soleil.CouleurSoleil());
            m_gPanPhoto.FillEllipse(soleil, 300, 20, m_Soleil.RayonSoleil(), m_Soleil.RayonSoleil());
        }
        private void DessineAuto()
        {
            SolidBrush auto = new SolidBrush(m_Auto.CouleurAuto());
            Pen roue = new Pen(m_Auto.CouleurRoue(), 4);
            m_gPanPhoto.FillRectangle(auto, 100, 80, 100, 30);
            m_gPanPhoto.FillRectangle(auto, 125, 65, 40, 40);
            m_gPanPhoto.DrawEllipse(roue, 115, 100, 20, 20);
            m_gPanPhoto.DrawEllipse(roue, 165, 100, 20, 20);
        }

        private void btnAffiche_Click(object sender, EventArgs e)
        {
            m_gPanPhoto.Clear(Color.Honeydew);
            DessineSoleil();
            DessineAuto();
            btnChoix.Enabled = true;
            btnAffiche.Enabled = false;
        }

        private void btnChoix_Click(object sender, EventArgs e)
        {
            m_Soleil.ChangeCouleurSoleil(cbxCouleurSoleil.SelectedItem.ToString());
            m_Soleil.ChangeTailleSoleil(Convert.ToInt32(cbxRayonSoleil.SelectedItem));

            m_Auto.ChangeCouleurAuto(cbxCouleurAuto.SelectedItem.ToString());
            m_Auto.ChangeCouleurRoue(cbxCouleurRoue.SelectedItem.ToString());

            btnChoix.Enabled = false;
            btnAffiche.Enabled = true;
        }
    }
}
