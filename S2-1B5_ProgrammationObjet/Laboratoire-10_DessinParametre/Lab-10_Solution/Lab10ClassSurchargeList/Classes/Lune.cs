using System.Drawing;

namespace Lab10ClassSurchargeList.Classes
{
    class Lune
    {
        public Color m_couleur;
        private int m_diametre;

        public Lune()
        {
            m_couleur = Color.WhiteSmoke;
            m_diametre = 32;
        }

        public Lune(string couleur, int diametre)
        {
            m_couleur = Color.FromName(couleur);
            m_diametre = diametre;
        }

        public int getDiametreLune()
        {
            return m_diametre;
        }

        public void setDiametreLune(int diametre)
        {
            m_diametre = diametre;
        }

        public void setDiametreLune(string diametre)
        {
            m_diametre = int.Parse(diametre);
        }
    }
}
