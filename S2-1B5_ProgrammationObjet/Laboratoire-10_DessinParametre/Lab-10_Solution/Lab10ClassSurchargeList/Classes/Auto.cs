using System.Drawing;

namespace Lab10ClassSurchargeList.Classes
{
    class Auto
    {
        public Color m_couleurAuto;
        public Color m_couleurRoue;

        public Auto()
        {
            m_couleurAuto = Color.GhostWhite;
            m_couleurRoue = Color.Black;
        }

        public Auto(string couleurAuto, string couleurRoue)
        {
            m_couleurAuto = Color.FromName(couleurAuto);
            m_couleurRoue = Color.FromName(couleurRoue);
        }
    }
}
