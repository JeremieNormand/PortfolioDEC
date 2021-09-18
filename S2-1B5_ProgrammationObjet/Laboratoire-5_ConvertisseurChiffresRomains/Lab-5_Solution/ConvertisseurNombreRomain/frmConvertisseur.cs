using System;
using System.Windows.Forms;

namespace ConvertisseurNombreRomain
{
    public partial class frmConvertisseur : Form
    {
        string[] m_tUnitesRomaines = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] m_tDizainesRomaines = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] m_tCentainesRomaines = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] m_tMilliersRomains = { "", "M", "MM", "MMM", "MMMM" };

        public frmConvertisseur()
        {
            InitializeComponent();
        }

        // Valide qu'un nombre decimal est compris entre 1 et 4 999
        bool ValiderNombreDecimal(int nombreDecimal)
        {
            if (nombreDecimal < 1 || nombreDecimal > 4999)
            {
                return false;
            }

            return true;
        }

        // Construit le nombre romain avec des chiffres romains a partir d'un nombre decimal
        string TraduitDecimalEnRomain(int nombreDecimal)
        {
            string NombreRomain = "";

            NombreRomain += m_tMilliersRomains[nombreDecimal / 1000];
            NombreRomain += m_tCentainesRomaines[(nombreDecimal % 1000) / 100];
            NombreRomain += m_tDizainesRomaines[(nombreDecimal % 100) / 10];
            NombreRomain += m_tUnitesRomaines[nombreDecimal % 10];

            return NombreRomain;
        }

        // Methode associe au click du bouton Convertir
        private void btnConvertirDecimalEnRomain_Click(object sender, EventArgs e)
        {
            int NombreDecimal;
            if (!int.TryParse(txtNombreDecimal.Text, out NombreDecimal))
            {
                MessageBox.Show("Entrez un nombre entier.");
                txtNombreRomain.Text = "nulla";
                return;
            }
            if (!ValiderNombreDecimal(NombreDecimal))
            {
                MessageBox.Show("Entrez un nombre compris entre 1 et 4 999.");
                txtNombreRomain.Text = "nulla";
                return;
            }

            txtNombreRomain.Text = TraduitDecimalEnRomain(NombreDecimal);
        }
    }
}
