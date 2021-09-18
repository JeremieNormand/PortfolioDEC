using System;
using System.Windows.Forms;

namespace TP6
{
    public partial class frmTP6 : Form
    {
        int m_NombreDEtoiles;

        public frmTP6()
        {
            m_NombreDEtoiles = 0;

            InitializeComponent();
        }

        private void btnAfficherSommeDeUnACent_Click(object sender, EventArgs e)
        {
            // Calculer la somme des nombres de 1 a 100

            int Somme = CalculerSommeDeXaY(1, 100);

            // Afficher le resultat de la somme des nombres de 1 a 100

            MessageBox.Show($"Le résultat de la somme des nombres de 1 à 100 est de {Somme}", "Somme 1 ... 100",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int CalculerSommeDeXaY(int NombreDeDepart, int NombreDeFin)
        {
            int Somme = 0;
            for (int NombreCourant = NombreDeDepart; NombreCourant <= NombreDeFin; NombreCourant++)
            {
                Somme += NombreCourant;
            }

            return Somme;
        }

        private void btnAfficherSommeDeXaY_Click(object sender, EventArgs e)
        {
            // Declaration des variables

            int NombreDeDepart;
            int NombreDeFin;

            int Somme;

            bool EstValide;

            // Lecture et validation des entrees

            EstValide = int.TryParse(txtNombreDeDepartSomme.Text, out NombreDeDepart);
            EstValide = !EstValide ? EstValide : ValiderEntierPositifNonNul(NombreDeDepart);
            if (!EstValide)
            {
                MessageBox.Show("Le nombre de départ 'X' est invalide (entier positif non nul)", "Validation du Nombre de Départ",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstValide = int.TryParse(txtNombreDeFinSomme.Text, out NombreDeFin);
            EstValide = !EstValide ? EstValide : ValiderEntierPositifNonNul(NombreDeFin);
            if (!EstValide)
            {
                MessageBox.Show("Le nombre de fin 'Y' est invalide (entier positif non nul)", "Validation du Nombre de Fin",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcul de la somme de X a Y

            if (NombreDeDepart < NombreDeFin)
            {
                Somme = CalculerSommeDeXaY(NombreDeDepart, NombreDeFin);
            }
            else
            {
                Somme = CalculerSommeDeXaY(NombreDeFin, NombreDeDepart);
            }

            // Affichage du resultat de la somme des nombres de X a Y

            MessageBox.Show($"Le résultat de la somme des nombres de {NombreDeDepart} à {NombreDeFin} est de {Somme}", "Somme X ... Y",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool ValiderEntierPositifNonNul(int Nombre)
        {
            bool EstValide = true;
            if (Nombre <= 0)
            {
                EstValide = false;
            }

            return EstValide;
        }

        private void btnAfficherPuissance_Click(object sender, EventArgs e)
        {
            // Declaration des variables

            int Base;
            int Puissance;

            int Resultat;

            bool EstValide;

            // Lecture et validation des entrees
            
            EstValide = int.TryParse(txtBase.Text, out Base);
            EstValide = !EstValide ? EstValide : ValiderEntierPositifNonNul(Base);
            if (!EstValide)
            {
                MessageBox.Show("La base est invalide (entier positif non nul)", "Validation de la Base",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstValide = int.TryParse(txtPuissance.Text, out Puissance);
            EstValide = !EstValide ? EstValide : ValiderEntierPositifNonNul(Puissance);
            if (!EstValide)
            {
                MessageBox.Show("La puissance est invalide (entier positif non nul)", "Validation de la Puissance",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcul du resultat de la base elevee a la puissance
            
            Resultat = CalculerPuissance(Base, Puissance);

            // Affichage du resultat de la base elevee a la puissance

            MessageBox.Show($"Le résultat de la base {Base} élevée à la puissance {Puissance} est de {Resultat}", "Puissance",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private int CalculerPuissance(int Base, int Puissance)
        {
            int Resultat = Base;
            while (Puissance > 1)
            {
                Resultat *= Base;
                Puissance--;
            }

            return Resultat;
        }

        private void btnAfficherDecompte_Click(object sender, EventArgs e)
        {
            // Initialisation

            lstDecompte.Items.Clear();
            
            // Declaration des variables

            int NombreX;
            int NombreY;

            bool EstValide;

            // Lecture et validation des entrees

            EstValide = int.TryParse(txtNombreX.Text, out NombreX);
            EstValide = !EstValide ? EstValide : ValiderEntierNegatifOuNul(NombreX);
            if (!EstValide)
            {
                MessageBox.Show("Le premier nombre 'X' est invalide (entier négatif)", "Validation du Premier Nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstValide = int.TryParse(txtNombreY.Text, out NombreY);
            EstValide = !EstValide ? EstValide : ValiderEntierNegatifOuNul(NombreY);
            if (!EstValide)
            {
                MessageBox.Show("Le deuxième nombre 'Y' est invalide (entier négatif)", "Validation du Deuxième Nombre",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Affichage du decompte

            if (NombreX < NombreY)
            {
                for (int Nombre = NombreX; Nombre <= NombreY; Nombre++)
                {
                    lstDecompte.Items.Add(Nombre);
                }
            }
            else
            {
                for (int Nombre = NombreY; Nombre <= NombreX; Nombre++)
                {
                    lstDecompte.Items.Add(Nombre);
                }
            }
        }

        private bool ValiderEntierNegatifOuNul(int Nombre)
        {
            bool EstValide = true;
            if (Nombre > 0)
            {
                EstValide = false;
            }

            return EstValide;
        }

        private void btnAjouterLigneEtEtoile_Click(object sender, EventArgs e)
        {
            // Declaration des variables

            string Ligne = "";

            // Affichage de la ligne d'etoiles

            m_NombreDEtoiles++;
            for (int Etoile = 1; Etoile <= m_NombreDEtoiles; Etoile++)
            {
                Ligne = Ligne + "*";
            }
            lstLignesEtEtoiles.Items.Add(Ligne);
        }

        private void btnAfficherRepetitionsNombre_Click(object sender, EventArgs e)
        {
            // Declaration des variables

            int NombreARepeter;
            int NombreDeRepetitions;

            string RepetitionsNombre = "";

            bool EstValide;

            // Lecture et validation des entrees

            EstValide = int.TryParse(txtNombreARepeter.Text, out NombreARepeter);
            if (!EstValide)
            {
                MessageBox.Show("Le nombre à répéter est invalide (nombre entier)", "Validation du Nombre à Répéter",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EstValide = int.TryParse(txtNombreDeRepetitions.Text, out NombreDeRepetitions);
            EstValide = !EstValide ? EstValide : ValiderEntierPositifSuperieurAUn(NombreDeRepetitions);
            if (!EstValide)
            {
                MessageBox.Show("Le nombre de répétitions est invalide (entier suppérieur à 1)", "Validation du Nombre de Répétitions",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Affichage des repetitions du nombre

            do
            {
                RepetitionsNombre += NombreARepeter.ToString() + " ";
                NombreDeRepetitions--;
            } while (NombreDeRepetitions > 0);

            txtRepetitionsNombre.Text = RepetitionsNombre;
        }

        private bool ValiderEntierPositifSuperieurAUn(int Nombre)
        {
            bool EstValide = true;
            if (Nombre < 2)
            {
                EstValide = false;
            }

            return EstValide;
        }

        private void btnAfficherInverseDeNombre_Click(object sender, EventArgs e)
        {
            // Declaration des variables

            int NombreAInverser;
            int Restant;
            
            int InverseDeNombre = 0;

            bool EstValide;

            // Lecture et validation des entrees

            EstValide = int.TryParse(txtNombreAInverser.Text, out NombreAInverser);
            EstValide = !EstValide ? EstValide : ValiderEntierPositifEgalOuSuperieurADix(NombreAInverser);
            if (!EstValide)
            {
                MessageBox.Show("Le nombre à inverser est invalide (entier suppérieur ou égal à 10)", "Validation du Nombre à Inverser",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calcul de l'inverse du nombre

            while (NombreAInverser > 0)
            {
                Restant = NombreAInverser % 10;
                InverseDeNombre = (InverseDeNombre * 10) + Restant;
                NombreAInverser = NombreAInverser / 10;
            }

            // Affichage de l'inverse du nombre

            lblInverseDeNombre.Text = InverseDeNombre.ToString();
        }

        private bool ValiderEntierPositifEgalOuSuperieurADix(int Nombre)
        {
            bool EstValide = true;
            if (Nombre < 10)
            {
                EstValide = false;
            }

            return EstValide;
        }
    }
}
