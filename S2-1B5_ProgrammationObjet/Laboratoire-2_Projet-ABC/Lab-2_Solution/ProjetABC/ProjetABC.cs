using System;
using System.Windows.Forms;

namespace ProjetABC
{
    public partial class ProjetABC : Form
    {
        public ProjetABC()
        {
            InitializeComponent();
        }

        private void btnAdditionner_Click(object sender, EventArgs e)
        {
            // Initialisation des variables

            double EntreeA;
            double EntreeB;

            bool SontValide;

            int SortieC;
            string Message;

            // Lecture et Validation des entrees

            SontValide = double.TryParse(txtEntreeA.Text, out EntreeA);

            if (!SontValide)
            {
                return;
            }

            SontValide = double.TryParse(txtEntreeB.Text, out EntreeB);

            if (!SontValide)
            {
                return;
            }

            // Addition et Determination du message

            SortieC = (int)EntreeA + (int)EntreeB;

            if (SortieC < 0)
            {
                Message = "Deshonneur";
            }
            else if (SortieC < 60)
            {
                Message = "Echec";
            }
            else
            {
                Message = "Succes";
            }

            // Ecriture des sorties

            txtSortieC.Text = SortieC.ToString();
            lblMessage.Text = Message;
        }

        private void btnSommation_Click(object sender, EventArgs e)
        {
            // Initialisation des variables

            double EntreeA;
            double EntreeB;

            bool SontValide;

            int SortieC = 0;
            string Message;

            // Lecture et Validation des entrees

            SontValide = double.TryParse(txtEntreeA.Text, out EntreeA);

            if (!SontValide)
            {
                return;
            }

            SontValide = double.TryParse(txtEntreeB.Text, out EntreeB);

            if (!SontValide)
            {
                return;
            }

            // Sommation des nombre et Determination du message

            if (EntreeA > EntreeB)
            {
                for (int NombreCourant = (int)EntreeA; NombreCourant >= (int)EntreeB; NombreCourant--)
                {
                    SortieC += NombreCourant;
                }
            }
            else
            {
                for (int NombreCourant = (int)EntreeA; NombreCourant <= (int)EntreeB; NombreCourant++)
                {
                    SortieC += NombreCourant;
                }
            }
            

            if (SortieC < 0)
            {
                Message = "Sommation negative";
            }
            else if (SortieC > 0)
            {
                Message = "Sommation positive";
            }
            else
            {
                Message = "Sommation neutre";
            }

            // Ecriture des sorties

            txtSortieC.Text = SortieC.ToString();
            lblMessage.Text = Message;
        }
    }
}
