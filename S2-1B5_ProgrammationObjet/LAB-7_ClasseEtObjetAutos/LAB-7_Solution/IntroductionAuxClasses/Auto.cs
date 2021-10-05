namespace IntroductionAuxClasses
{
    public class Auto
    {
        public string m_marque;
        public string m_couleur;
        public int m_annee;

        public Auto()
        {

        }

        public Auto(string marque, string couleur, int annee)
        {
            m_marque = marque;
            m_couleur = couleur;
            m_annee = annee;
        }

        public string Information()
        {
            return $"\n----------------\nmarque :\t{m_marque}\nannée :\t{m_annee}\ncouleur :\t{m_couleur}";
        }

        public void ChangeCouleur(string[] couleurs, int couleur)
        {
            if (couleur < 0 || couleur > couleurs.Length)
            {
                return;
            }
            m_couleur = couleurs[couleur];
        }

    }
}
