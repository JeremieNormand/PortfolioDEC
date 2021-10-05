using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class frmTP4 : Form
    {
        int m_NombrePizzasPetites;
        int m_NombrePizzasMediums;
        int m_NombrePizzasLarges;
        int m_DiametrePizzaPetiteEnPouces;
        int m_DiametrePizzaMediumEnPouces;
        int m_DiametrePizzaLargeEnPouces;
        double m_ArgentCaisse;
        bool m_EstPizzaValide;

        public frmTP4()
        {
            m_NombrePizzasPetites = 0;
            m_NombrePizzasMediums = 0;
            m_NombrePizzasLarges = 0;
            m_DiametrePizzaPetiteEnPouces = 10;
            m_DiametrePizzaMediumEnPouces = 12;
            m_DiametrePizzaLargeEnPouces = 16;
            m_ArgentCaisse = 0.0;
            m_EstPizzaValide = false;
            InitializeComponent();
        }

        private void btnCalculerPrixVentePizza_Click(object sender, EventArgs e)
        {
            int DiametrePizzaEnPouces;
            int NombreExtras;

            double MajorationCout = 1.5;
            double CoutFixe = 3.0;
            double CoutBase = 0.035;
            double CoutExtra = 0.006;
            double Pi = 3.1416;

            double PrixVentePizza;

            // Validation des variables d'entrees

            m_EstPizzaValide = int.TryParse(txtDiametrePizzaEnPouces.Text, out DiametrePizzaEnPouces);
            if (!m_EstPizzaValide || (DiametrePizzaEnPouces != m_DiametrePizzaPetiteEnPouces && DiametrePizzaEnPouces != m_DiametrePizzaMediumEnPouces
                && DiametrePizzaEnPouces != m_DiametrePizzaLargeEnPouces))
            {
                m_EstPizzaValide = false;
                MessageBox.Show("La grandeur de pizza entrée est invalide", "Validation Diamètre Pizza",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                m_EstPizzaValide = true;
            }

            m_EstPizzaValide = int.TryParse(txtNombreExtras.Text, out NombreExtras);
            if (!m_EstPizzaValide || NombreExtras < 0 || NombreExtras > 3)
            {
                m_EstPizzaValide = false;
                MessageBox.Show("Le nombre d'extras entré est invalide", "Validation Nombre D'Extras",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                m_EstPizzaValide = true;
            }

            // Calcul du prix de vente de la pizza

            PrixVentePizza = (CoutFixe + (Pi * Math.Pow(DiametrePizzaEnPouces / 2, 2) * (CoutBase + CoutExtra * NombreExtras))) * MajorationCout;

            // Ecriture des sorties

            txtPrixVentePizza.Text = PrixVentePizza.ToString("0.00");
        }

        private void btnConfirmerVente_Click(object sender, EventArgs e)
        {
            int DiametrePizzaEnPouces;
            double PrixVentePizza;

            // Validation des variables d'entrees

            btnCalculerPrixVentePizza_Click(sender, e);

            if (!m_EstPizzaValide)
            {
                return;
            }

            DiametrePizzaEnPouces = int.Parse(txtDiametrePizzaEnPouces.Text);
            PrixVentePizza = double.Parse(txtPrixVentePizza.Text);

            if (DiametrePizzaEnPouces == m_DiametrePizzaPetiteEnPouces)
            {
                m_NombrePizzasPetites++;
            }
            else if (DiametrePizzaEnPouces == m_DiametrePizzaMediumEnPouces)
            {
                m_NombrePizzasMediums++;
            }
            else
            {
                m_NombrePizzasLarges++;
            }

            m_ArgentCaisse = m_ArgentCaisse + PrixVentePizza;

            // Ecriture des sorties

            txtNombrePizzasPetites.Text = m_NombrePizzasPetites.ToString();
            txtNombrePizzasMediums.Text = m_NombrePizzasMediums.ToString();
            txtNombrePizzasLarges.Text = m_NombrePizzasLarges.ToString();
            txtArgentCaisse.Text = m_ArgentCaisse.ToString("0.00");
        }
    }
}
