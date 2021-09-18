using System.Drawing;

namespace Lab9Classe.Classes
{
    class SoleilPrivate
    {
        Color m_couleur;
        int m_taille;

        public SoleilPrivate()
        {
            m_couleur = Color.DodgerBlue;
            m_taille = 32;
        }

        public void ChangeCouleurSoleil(string couleur)
        {
            m_couleur = Color.FromName(couleur);
        }

        public Color CouleurSoleil()
        {
            return m_couleur;
        }

        public void ChangeTailleSoleil(int rayon)
        {
            m_taille = rayon;
        }

        public int RayonSoleil()
        {
            return m_taille;
        }
    }
}
