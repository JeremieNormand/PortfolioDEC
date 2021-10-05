using System;
using System.Windows.Forms;

namespace TP3
{
    public partial class frmTP3 : Form
    {
        public frmTP3()
        {
            InitializeComponent();
        }

        private void btnCalculerNoteFinale_Click(object sender, EventArgs e)
        {
            string PrenomNom = txtPrenomNom.Text;
            string Matricule = txtMatricule.Text;
            double NoteExamen1, NoteExamen2, NoteExamen3, NoteTravail1, NoteTravail2, NoteTravail3, NoteTravail4;

            int PonderationExamen1 = 20;
            int PonderationExamen2 = 20;
            int PonderationExamen3 = 30;
            int PonderationTravail1 = 20;
            int PonderationTravail2 = 10;
            int PonderationTravail3 = 20;
            int PonderationTravail4 = 15;
            double PonderationExamens = .80;
            double PonderationTravaux = .20;
            int SeuilReussite = 60;

            double NoteFinale;
            string Mention;

            bool EstValide;

            // Validations des valeurs du formulaire

            EstValide = double.TryParse(txtNoteExamen1.Text, out NoteExamen1);
            if (!EstValide || NoteExamen1 > PonderationExamen1)
            {
                MessageBox.Show("La note entrée pour l'examen 1 est invalide", "Validation Note Examen 1",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstValide = double.TryParse(txtNoteExamen2.Text, out NoteExamen2);
            if (!EstValide || NoteExamen2 > PonderationExamen2)
            {
                MessageBox.Show("La note entrée pour l'examen 2 est invalide", "Validation Note Examen 2",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstValide = double.TryParse(txtNoteExamen3.Text, out NoteExamen3);
            if (!EstValide || NoteExamen3 > PonderationExamen3)
            {
                MessageBox.Show("La note entrée pour l'examen 3 est invalide", "Validation Note Examen 3",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstValide = double.TryParse(txtNoteTravail1.Text, out NoteTravail1);
            if (!EstValide || NoteTravail1 > PonderationTravail1)
            {
                MessageBox.Show("La note entrée pour le travail 1 est invalide", "Validation Note Travail 1",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstValide = double.TryParse(txtNoteTravail2.Text, out NoteTravail2);
            if (!EstValide || NoteTravail2 > PonderationTravail2)
            {
                MessageBox.Show("La note entrée pour le travail 2 est invalide", "Validation Note Travail 2",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstValide = double.TryParse(txtNoteTravail3.Text, out NoteTravail3);
            if (!EstValide || NoteTravail3 > PonderationTravail3)
            {
                MessageBox.Show("La note entrée pour le travail 3 est invalide", "Validation Note Travail 3",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstValide = double.TryParse(txtNoteTravail4.Text, out NoteTravail4);
            if (!EstValide || NoteTravail4 > PonderationTravail4)
            {
                MessageBox.Show("La note entrée pour le travail 4 est invalide", "Validation Note Travail 4",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcul de la note finale et determination de la mention

            NoteFinale = ((NoteExamen1 + NoteExamen2 + NoteExamen3) / (PonderationExamen1 + PonderationExamen2 + PonderationExamen3) * PonderationExamens +
                (NoteTravail1 + NoteTravail2 + NoteTravail3 + NoteTravail4) / (PonderationTravail1 + PonderationTravail2 + PonderationTravail3 + PonderationTravail4) * 
                PonderationTravaux) * 100;

            if (NoteFinale < SeuilReussite)
            {
                Mention = "ÉCHEC";
            }
            else
            {
                Mention = "RÉUSSITE";
            }

            txtNoteFinale.Text = NoteFinale.ToString("0.00");
            txtMention.Text = Mention;
        }
    }
}
