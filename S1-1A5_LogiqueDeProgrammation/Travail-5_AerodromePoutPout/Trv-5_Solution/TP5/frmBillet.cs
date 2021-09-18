using System;
using System.Windows.Forms;

namespace TP5
{
    public partial class frmBillet : Form
    {
        int m_NombreBilletsTotal;
        int m_NombreBilletsMontreal;
        int m_NombreBilletsToronto;
        int m_NombreBilletsVancouver;

        int m_NombreBiletsFemmesMariees;
        double m_SommePrixBilletsFemmesMariees;

        int m_CompteurVisibilite;

        public frmBillet()
        {
            m_NombreBilletsTotal = 0;
            m_NombreBilletsMontreal = 0;
            m_NombreBilletsToronto = 0;
            m_NombreBilletsVancouver = 0;

            m_NombreBiletsFemmesMariees = 0;
            m_SommePrixBilletsFemmesMariees = 0;

            m_CompteurVisibilite = 0;

            InitializeComponent();
        }

        private void btnEmettreBillet_Click(object sender, EventArgs e)
        {
            // Declaration des variables du problemes

            string NomDuVoyageur = txtNom.Text;
            string CodeSexe;
            string CodeStatutCivil;
            string CodeDestination;
            double PoidsBagagesEnKilos;

            string FormulePolitesse;
            string Itineraire;
            double PrixBillet;

            // Assignation et validation des variables d'entrees

            bool EstValide;

            CodeSexe = txtCodeSexe.Text;
            EstValide = ValiderCodeSexe(CodeSexe);
            if (!EstValide)
            {
                MessageBox.Show("Le code pour le sexe est invalide (M ou F)", "Validation Sexe du Voyageur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CodeStatutCivil = txtCodeStatutCivil.Text;
            EstValide = ValiderCodeStatutCivil(CodeStatutCivil);
            if (!EstValide)
            {
                MessageBox.Show("Le code pour le statut civil est invalide (M ou C)", "Validation Statut Civil du Voyageur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CodeDestination = txtCodeDestination.Text;
            EstValide = ValiderCodeDestination(CodeDestination);
            if (!EstValide)
            {
                MessageBox.Show("Le code pour la destination est invalide (M, T ou V)", "Validation Destination du Voyageur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstValide = double.TryParse(txtPoidsBagagesEnKilos.Text, out PoidsBagagesEnKilos);
            if (!EstValide)
            {
                MessageBox.Show("Le poids des bagages est invalide (nombre)", "Validation du Poids des Bagages du Voyageur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EstValide = ValiderPoidsBagages(PoidsBagagesEnKilos);
            if (!EstValide)
            {
                MessageBox.Show("Le poids des bagages est invalide (nombre suppérieur à zéro)", "Validation du Poids des Bagages du Voyageur",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determination des variables de sortie

            FormulePolitesse = DeterminerFormulePolitesse(CodeSexe, CodeStatutCivil);
            Itineraire = DeterminerItineraire(CodeDestination);
            PrixBillet = CalculerPrixBillet(CodeDestination, PoidsBagagesEnKilos);

            // Ecriture des variables de sorie

            lblFormulePolitesse.Text = FormulePolitesse;
            lblNomDuVoyageur.Text = NomDuVoyageur;
            lblItineraire.Text = Itineraire;
            lblPrixBillet.Text = PrixBillet.ToString("0.00");

            // Mise a jour des donnees pour les statistiques

            MiseAJourDonnees(CodeDestination, FormulePolitesse, PrixBillet);
        }

        private bool ValiderCodeSexe(string CodeSexe)
        {
            bool EstValide = false;
            if (CodeSexe.ToUpper() == "M" || CodeSexe.ToUpper() == "F")
            {
                EstValide = true;
            }
            return EstValide;
        }

        private bool ValiderCodeStatutCivil(string CodeStatutCivil)
        {
            bool EstValide = false;
            if (CodeStatutCivil.ToUpper() == "M" || CodeStatutCivil.ToUpper() == "C")
            {
                EstValide = true;
            }
            return EstValide;
        }

        private bool ValiderCodeDestination(string CodeDestination)
        {
            bool EstValide = false;
            if (CodeDestination.ToUpper() == "M" || CodeDestination.ToUpper() == "T" || CodeDestination.ToUpper() == "V")
            {
                EstValide = true;
            }
            return EstValide;
        }

        private bool ValiderPoidsBagages(double PoidsBagagesEnKilos)
        {
            bool EstValide = false;
            if (PoidsBagagesEnKilos >= 0)
            {
                EstValide = true;
            }
            return EstValide;
        }

        private string DeterminerFormulePolitesse(string CodeSexe, string CodeStatutCivil)
        {
            string FormulePolitesse;
            if (CodeSexe.ToUpper() == "M")
            {
                FormulePolitesse = "M.";
            }
            else if (CodeStatutCivil.ToUpper() == "M")
            {
                FormulePolitesse = "Mme";
            }
            else
            {
                FormulePolitesse = "Mlle";
            }
            return FormulePolitesse;
        }

        private string DeterminerItineraire(string CodeDestination)
        {
            string Itineraire;
            string Depart = "Québec";
            string Destination;
            if (CodeDestination.ToUpper() == "M")
            {
                Destination = "Montréal";
            }
            else if (CodeDestination.ToUpper() == "T")
            {
                Destination = "Toronto";
            }
            else
            {
                Destination = "Vancouver";
            }
            Itineraire = $"De {Depart} à : {Destination}";
            return Itineraire;
        }

        private double CalculerPrixBillet(string CodeDestination, double PoidsBagagesEnKilos)
        {
            double PrixBillet;
            if (CodeDestination.ToUpper() == "M")
            {
                PrixBillet = 100;
            }
            else if (CodeDestination.ToUpper() == "T")
            {
                PrixBillet = 200;
            }
            else
            {
                PrixBillet = 400;
            }
            if (PoidsBagagesEnKilos > 25)
            {
                PrixBillet = PrixBillet + 25 * .5 + (PoidsBagagesEnKilos - 25) * .75;
            }
            else
            {
                PrixBillet = PrixBillet + PoidsBagagesEnKilos * .5;
            }
            return PrixBillet;
        }

        private void MiseAJourDonnees(string CodeDestination, string FormulePolitesse, double PrixBillet)
        {
            m_NombreBilletsTotal++;
            if (CodeDestination.ToUpper() == "M")
            {
                m_NombreBilletsMontreal++;
            }
            else if (CodeDestination.ToUpper() == "T")
            {
                m_NombreBilletsToronto++;
            }
            else
            {
                m_NombreBilletsVancouver++;
            }
            if (FormulePolitesse == "Mme")
            {
                m_NombreBiletsFemmesMariees++;
                m_SommePrixBilletsFemmesMariees += PrixBillet;
            }
        }

        private void btnAfficherStatistiques_Click(object sender, EventArgs e)
        {
            // Declaration des variables

            double PourcentageMontreal = 0;
            double PourcentageToronto = 0;
            double PourcentageVancouver = 0;

            double MoyennePrixBilletsFemmesMariees = 0;

            // Validation et assignation des variables

            if (m_NombreBilletsTotal != 0)
            {
                PourcentageMontreal = (double)m_NombreBilletsMontreal / m_NombreBilletsTotal * 100;
                PourcentageToronto = (double)m_NombreBilletsToronto / m_NombreBilletsTotal * 100;
                PourcentageVancouver = (double)m_NombreBilletsVancouver / m_NombreBilletsTotal * 100;

                MoyennePrixBilletsFemmesMariees = m_SommePrixBilletsFemmesMariees / m_NombreBiletsFemmesMariees;
            }

            // Ecriture des variables de sortie

            lblPourcentageMontreal.Text = PourcentageMontreal.ToString("0.0");
            lblPourcentageToronto.Text = PourcentageToronto.ToString("0.0");
            lblPourcentageVancouver.Text = PourcentageVancouver.ToString("0.0");
            lblMoyennePrixBilletsFemmesMariees.Text = MoyennePrixBilletsFemmesMariees.ToString("0.00");

            // Affichage du groupbox statistiques

            if (m_CompteurVisibilite % 2 == 0)
            {
                gbStatistiques.Visible = true;
                m_CompteurVisibilite++;
            }
            else
            {
                gbStatistiques.Visible = false;
                m_CompteurVisibilite--;
            }
        }
    }
}
