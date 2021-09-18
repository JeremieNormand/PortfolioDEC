using System;
using System.Windows.Forms;

namespace MiniConvertisseur
{
    public partial class MiniConvertisseur : Form
    {
        double m_DollarAmericainsParDollarCanadien;
        double m_EurosParDollarCanadien;
        double m_YensParDollarCanadien;
        double m_PesosColombiensParDollarCanadien;

        string m_SymboleDollarAmericain;
        string m_SymboleEuro;
        string m_SymboleYen;
        string m_SymbolePesoColombien;

        public MiniConvertisseur()
        {
            InitializeComponent();

            m_DollarAmericainsParDollarCanadien = .77;
            m_EurosParDollarCanadien = .69;
            m_YensParDollarCanadien = 84.34;
            m_PesosColombiensParDollarCanadien = 2541.78;

            m_SymboleDollarAmericain = "$ US";
            m_SymboleEuro = "Euro";
            m_SymboleYen = "Yen";
            m_SymbolePesoColombien = "COP";
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            // Initialisation des variables
            double MontantAConvertir;
            double MontantConverti;
            bool EstMontantValide;

            // Validation du montant a convertir
            EstMontantValide = double.TryParse(txtMontantAConvertir.Text, out MontantAConvertir);
            if (!EstMontantValide || !ValiderMontant(MontantAConvertir))
            {
                return;
            }

            // Conversion du montant selon le choix de pays
            if (rdbUSA.Checked)
            {
                MontantConverti = MontantAConvertir * m_DollarAmericainsParDollarCanadien;
                lblDeviseMontantConverti.Text = m_SymboleDollarAmericain;
            }
            else if (rdbEuro.Checked)
            {
                MontantConverti = MontantAConvertir * m_EurosParDollarCanadien;
                lblDeviseMontantConverti.Text = m_SymboleEuro;
            }
            else if (rdbJapon.Checked)
            {
                MontantConverti = MontantAConvertir * m_YensParDollarCanadien;
                lblDeviseMontantConverti.Text = m_SymboleYen;
            }
            else
            {
                MontantConverti = MontantAConvertir * m_PesosColombiensParDollarCanadien;
                lblDeviseMontantConverti.Text = m_SymbolePesoColombien;
            }

            // Sortie
            lblMontantConverti.Text = MontantConverti.ToString("0.00");
        }

        private bool ValiderMontant(double Montant)
        {
            if (Montant < 0)
            {
                return false;
            }

            return true;
        }
    }
}
