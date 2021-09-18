using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LesFilmsDuPleinPays.Operations;

namespace LesFilmsDuPleinPays
{
    public partial class frmConnexionServeur : Form
    {
        OperationBD _Operation_BD;
        bool _connecte;

        public frmConnexionServeur()
        {
            _Operation_BD = new OperationBD();
            _connecte = _Operation_BD.GetStatutConnexion();
            InitializeComponent();
        }

        private void AppliquerStyleSelonStatutConnexion(bool connecte_)
        {
            TextBox TxtStatut = txtStatutConnexion;
            if (connecte_)
            {
                TxtStatut.Text = "CONNECTÉ";
                TxtStatut.BackColor = Color.PaleGreen;
            }
            else
            {
                TxtStatut.Text = "NON CONNECTÉ";
                TxtStatut.BackColor = Color.LightPink;
            }    
        }

        private void frmConnexionServeur_Load(object sender_, EventArgs event_)
        {
            AppliquerStyleSelonStatutConnexion(_connecte);
        }

        private void RafraichirStatutConnexion()
        {
            _connecte = _Operation_BD.GetStatutConnexion();
            AppliquerStyleSelonStatutConnexion(_connecte);
        }

        private void btnRafraichirStatutConnexion_Click(object sender_, EventArgs event_)
        {
            RafraichirStatutConnexion();
        }

        private void btnQuitter_Click(object sender_, EventArgs event_)
        {
            Close();
        }

        private void btnAccederGestionnaire_Click(object sender, EventArgs e)
        {
            RafraichirStatutConnexion();
            if (_connecte)
            {
                Form frmGestionnaire = new frmGestionnaire();
                frmGestionnaire.ShowDialog();
            }
        }
    }
}
