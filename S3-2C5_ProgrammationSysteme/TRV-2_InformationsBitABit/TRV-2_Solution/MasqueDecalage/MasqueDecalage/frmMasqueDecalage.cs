using System;
using System.Windows.Forms;

namespace MasqueDecalage
{
    public partial class frmMasqueDecalage : Form
    {
        // heure avant date

        // anomalie avec les secondes - investiguer le corrige

        uint[] temps =
        {
            3247998492, 3279396729, 2926558652, 2130065906, 2395699451,
            3814201359, 1984496033, 2585988554, 2064086791, 3207116534
        };

        enum Msk // Masques
        {
            Seconde = 0b1_111,
            Minute = 0b11_1111,
            Heure = 0b1_1111,
            Jour = 0b1_1111,
            Mois = 0b_1111,
            Annee = 0b111_1111
        }

        enum Pst // Positions
        {
            Seconde = 0,
            Minute = 5,
            Heure = 11,
            Jour = 16,
            Mois = 21,
            Annee = 25
        }

        int indiceHeure;
        int indiceDate;

        public frmMasqueDecalage()
        {
            InitializeComponent();
            indiceHeure = 0;
            indiceDate = 0;
        }

        private void btnHeure_Click(object sender, EventArgs e) // *uint optionnel pour la lisibilite
        {
            uint seconde = (uint)(temps[indiceHeure] >> (int)Pst.Seconde) & (uint)Msk.Seconde;
            uint minute = (uint)(temps[indiceHeure] >> (int)Pst.Minute) & (uint)Msk.Minute;
            uint heure = (uint)(temps[indiceHeure] >> (int)Pst.Heure) & (uint)Msk.Heure;

            txtHeure.Text = $"{heure:D2}:{minute:D2}:{seconde:D2}";

            indiceHeure = indiceHeure < (temps.Length - 1) ? ++indiceHeure : 0;
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            uint jour = (uint)(temps[indiceDate]/Math.Pow(2,(int)Pst.Jour)) & (uint)Msk.Jour;
            uint mois = (uint)(temps[indiceDate]/Math.Pow(2,(int)Pst.Mois)) & (uint)Msk.Mois;
            uint annee = (uint)(temps[indiceDate]/Math.Pow(2,(int)Pst.Annee)) & (uint)Msk.Annee;
            annee += 1900;

            txtDate.Text = $"{annee}-{mois:D2}-{jour:D2}";

            indiceDate = indiceDate < (temps.Length - 1) ? ++indiceDate : 0;
        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
