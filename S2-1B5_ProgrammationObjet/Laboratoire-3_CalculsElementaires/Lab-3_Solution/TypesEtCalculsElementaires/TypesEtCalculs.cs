using System;
using System.Windows.Forms;

namespace TypesEtCalculsElementaires
{
    public partial class TypesEtCalculs : Form
    {
        public TypesEtCalculs()
        {
            InitializeComponent();
        }

        private void btnEvaluerExpression1_Click(object sender, EventArgs e)
        {
            // Initialisation des variables

            int EntreeA, EntreeB;
            decimal SortieC;

            // Lecture et Validation des entrees

            if (!int.TryParse(txtEntreeA.Text, out EntreeA))
            {
                MessageBox.Show("L'entrée 'A' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }
            if (!int.TryParse(txtEntreeB.Text, out EntreeB))
            {
                MessageBox.Show("L'entrée 'B' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }

            // Validation de la fesabilite du calcul mathematique

            if (EntreeA - EntreeB == 0)
            {
                MessageBox.Show("Il est impossible de faire une division par zéro.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Division par zéro";
                return;
            }

            // Evaluation de l'expression mathematique avec les entrees A et B

            SortieC = (decimal)(EntreeA + EntreeB) / (EntreeA - EntreeB);

            // Ecriture des sorties

            txtSortieC.Text = SortieC.ToString();
            lblCommentaire.Text = "Ok";
        }

        private void btnEvaluerExpression2_Click(object sender, EventArgs e)
        {
            // Initialisation des variables

            int EntreeA, EntreeB;
            decimal SortieC;

            // Lecture et Validation des entrees

            if (!int.TryParse(txtEntreeA.Text, out EntreeA))
            {
                MessageBox.Show("L'entrée 'A' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }
            if (!int.TryParse(txtEntreeB.Text, out EntreeB))
            {
                MessageBox.Show("L'entrée 'B' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }

            // Validation de la fesabilite du calcul mathematique

            if (EntreeA + EntreeB == 0)
            {
                MessageBox.Show("Il est impossible de faire une division par zéro.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Division par zéro";
                return;
            }

            // Evaluation de l'expression mathematique avec les entrees A et B

            SortieC = (decimal)(Math.Pow(EntreeA, 2) + 2 * Math.Pow(EntreeB, 3)) / (2 * (EntreeA + EntreeB));

            // Ecriture des sorties

            txtSortieC.Text = SortieC.ToString();
            lblCommentaire.Text = "Ok";
        }

        private void btnEvaluerExpression3_Click(object sender, EventArgs e)
        {
            // Initialisation des variables

            int EntreeA, EntreeB;
            decimal SortieC;

            // Lecture et Validation des entrees

            if (!int.TryParse(txtEntreeA.Text, out EntreeA))
            {
                MessageBox.Show("L'entrée 'A' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }
            if (!int.TryParse(txtEntreeB.Text, out EntreeB))
            {
                MessageBox.Show("L'entrée 'B' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }

            // Validation de la fesabilite du calcul mathematique

            if (EntreeA - EntreeB == 0 && EntreeA + EntreeB == 0)
            {
                MessageBox.Show("Il est impossible de faire une division par zéro.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Division par zéro";
                return;
            }

            // Evaluation de l'expression mathematique avec les entrees A et B

            double Argument1 = 2 * EntreeA * EntreeB;
            double Argument2 = (double)(EntreeA + EntreeB) / (2 * (EntreeA - EntreeB));
            double Argument3 = Math.Pow(EntreeA, 2) * Math.Pow(EntreeB, 3) * Math.Pow(EntreeA + EntreeB, -23);

            SortieC = (decimal)(Argument1 + Argument2 + Argument3);

            // Ecriture des sorties

            txtSortieC.Text = SortieC.ToString();
            lblCommentaire.Text = "Ok";
        }

        private void btnEvaluerExpression4_Click(object sender, EventArgs e)
        {
            // Initialisation des variables

            int EntreeA, EntreeB;
            decimal SortieC;

            // Lecture et Validation des entrees

            if (!int.TryParse(txtEntreeA.Text, out EntreeA))
            {
                MessageBox.Show("L'entrée 'A' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }
            if (!int.TryParse(txtEntreeB.Text, out EntreeB))
            {
                MessageBox.Show("L'entrée 'B' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }

            // Validation de la fesabilite du calcul mathematique

            if (EntreeA - EntreeB == 0)
            {
                MessageBox.Show("Il est impossible de faire une division par zéro.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Division par zéro";
                return;
            }
            if ((EntreeA + EntreeB) / (EntreeA - EntreeB) < 0)
            {
                MessageBox.Show("Incapable d'effectuer le radical d'un nombre négatif.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Radical négatif";
                return;
            }

            // Evaluation de l'expression mathematique avec les entrees A et B

            SortieC = (decimal)(Math.Pow((double)(EntreeA + EntreeB) / (EntreeA - EntreeB), 1/2));

            // Ecriture des sorties

            txtSortieC.Text = SortieC.ToString();
            lblCommentaire.Text = "Ok";
        }

        private void btnEvaluerExpression5_Click(object sender, EventArgs e)
        {
            // Initialisation des variables

            int EntreeA, EntreeB;
            decimal SortieC;

            // Lecture et Validation des entrees

            if (!int.TryParse(txtEntreeA.Text, out EntreeA))
            {
                MessageBox.Show("L'entrée 'A' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }
            if (!int.TryParse(txtEntreeB.Text, out EntreeB))
            {
                MessageBox.Show("L'entrée 'B' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }

            // Validation de la fesabilite du calcul mathematique

            if (EntreeA - EntreeB == 0)
            {
                MessageBox.Show("Il est impossible de faire une division par zéro.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Division par zéro";
                return;
            }

            // Evaluation de l'expression mathematique avec les entrees A et B

            double Numerateur = Math.Pow(EntreeA, 2) - Math.Pow(EntreeB, 2);
            double Denominateur = Math.Pow(EntreeA - EntreeB, 2);

            SortieC = (decimal)Math.Pow(Numerateur / Denominateur, 1/3);

            // Ecriture des sorties

            txtSortieC.Text = SortieC.ToString();
            lblCommentaire.Text = "Ok";
        }

        private void btnEvaluerExpression6_Click(object sender, EventArgs e)
        {
            // Initialisation des variables

            int EntreeA, EntreeB;
            decimal SortieC;

            // Lecture et Validation des entrees

            if (!int.TryParse(txtEntreeA.Text, out EntreeA))
            {
                MessageBox.Show("L'entrée 'A' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }
            if (!int.TryParse(txtEntreeB.Text, out EntreeB))
            {
                MessageBox.Show("L'entrée 'B' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }

            // Validation de la fesabilite du calcul mathematique

            if (EntreeA < 0 || EntreeB < 0)
            {
                MessageBox.Show("Il est impossible d'avoir une note inférieur à zéro.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Note(s) négative(s)";
                return;
            }
            if (EntreeA > 15 || EntreeB > 25)
            {
                MessageBox.Show("Il est impossible d'avoir une note supérieur à 15 pour 'A' et 25 pour 'B'.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Limite supérieur";
                return;
            }

            // Evaluation de l'expression mathematique avec les entrees A et B

            SortieC = 100 * ((decimal)EntreeA / 15 / 2 + (decimal)EntreeB / 25 / 2);

            // Ecriture des sorties

            txtSortieC.Text = SortieC.ToString();
            lblCommentaire.Text = "La note a deux decimales (arrondie) est de " + SortieC.ToString("0.00") + "%";
        }

        private void btnEvaluerExpression7_Click(object sender, EventArgs e)
        {
            // Initialisation des variables

            int EntreeA, EntreeB;
            decimal SortieC;

            // Lecture et Validation des entrees

            if (!int.TryParse(txtEntreeA.Text, out EntreeA))
            {
                MessageBox.Show("L'entrée 'A' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }
            if (!int.TryParse(txtEntreeB.Text, out EntreeB))
            {
                MessageBox.Show("L'entrée 'B' doit être un nombre entier.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Ça va pas";
                return;
            }

            // Validation de la fesabilite du calcul mathematique

            if (EntreeA + EntreeB == 0)
            {
                MessageBox.Show("Il est impossible de faire une division par zéro.");
                txtSortieC.Text = "";
                lblCommentaire.Text = "Division par zéro";
                return;
            }

            // Evaluation de l'expression mathematique avec les entrees A et B

            SortieC = (decimal)EntreeA / (EntreeA + EntreeB) * 100;

            // Ecriture des sorties

            txtSortieC.Text = SortieC.ToString();
            lblCommentaire.Text = "Le pourcentage de filles a deux decimales (arrondie) est de " + (100 - SortieC).ToString("0.00") + "%";
        }
    }
}
