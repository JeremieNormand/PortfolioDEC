using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilmsDuPleinPays.Enregistrements
{
    public struct FilmComplet
    {
        // CHAMPS

        private int _id;
        private string _titre;
        private DateTime _Date;
        private string _resume;
        private string _affiche;
        private int _duree;
        private int _genre_id;
        private string _genre_nom;
        private int _realisateur_id;
        private string _realisateur_nom;
        private string _realisateur_prenom;
        private List<RoleComplet> _Lst_Role_Complet;

        // PROPRIETES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }
        public DateTime Date
        {
            get { return _Date; }
            set { _Date = value; }
        }
        public string Resume
        {
            get { return _resume; }
            set { _resume = value; }
        }
        public string Affiche
        {
            get { return _affiche; }
            set { _affiche = value; }
        }
        public int Duree
        {
            get { return _duree; }
            set { _duree = value; }
        }
        public int GenreId
        {
            get { return _genre_id; }
            set { _genre_id = value; }
        }
        public string GenreNom
        {
            get { return _genre_nom; }
            set { _genre_nom = value; }
        }
        public int RealisateurId
        {
            get { return _realisateur_id; }
            set { _realisateur_id = value; }
        }
        public string RealisateurNom
        {
            get { return _realisateur_nom; }
            set { _realisateur_nom = value; }
        }
        public string RealisateurPrenom
        {
            get { return _realisateur_prenom; }
            set { _realisateur_prenom = value; }
        }
        public List<RoleComplet> LstRoleComplet
        {
            get { return _Lst_Role_Complet; }
            set { _Lst_Role_Complet = value; }
        }

        // CONSTRUCTEURS

        public FilmComplet(int id_, string titre_, DateTime Date_, string resume_, string affiche_, int duree_, int genre_id_, string genre_nom_, int realisateur_id_, string realisateur_nom_, string realisateur_prenom_, List<RoleComplet> Lst_Role_Complet_)
        {
            _id = id_;
            _titre = titre_;
            _Date = Date_;
            _resume = resume_;
            _affiche = affiche_;
            _duree = duree_;
            _genre_id = genre_id_;
            _genre_nom = genre_nom_;
            _realisateur_id = realisateur_id_;
            _realisateur_nom = realisateur_nom_;
            _realisateur_prenom = realisateur_prenom_;
            _Lst_Role_Complet = Lst_Role_Complet_;
        }
    }
}
