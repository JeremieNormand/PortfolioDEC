using System.Drawing;

namespace Lab9Classe.Classes
{
    class AutoPrivate
    {
        Color m_coulAuto, m_coulRoue;

        public AutoPrivate()
        {
            m_coulAuto = Color.MediumPurple;
            m_coulRoue = Color.DarkSlateBlue;
        }

        public void ChangeCouleurAuto(string couleur)
        {
            m_coulAuto = Color.FromName(couleur);
        }

        public Color CouleurAuto()
        {
            return m_coulAuto;
        }

        public void ChangeCouleurRoue(string couleur)
        {
            m_coulRoue = Color.FromName(couleur);
        }

        public Color CouleurRoue()
        {
            return m_coulRoue;
        }
    }
}
