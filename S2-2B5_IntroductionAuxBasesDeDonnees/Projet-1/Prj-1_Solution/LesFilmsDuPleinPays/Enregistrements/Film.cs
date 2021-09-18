using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilmsDuPleinPays.Enregistrements
{
    public struct Film
    {
        // CHAMPS

        private int _id;
        private string _titre;
        private DateTime _Date;
        private string _resume;
        private string _affiche;
        private int _duree;
        private int _genre_id;
        private int _realisateur_id;

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
        public int RealisateurId
        {
            get { return _realisateur_id; }
            set { _realisateur_id = value; }
        }

        // CONSTRUCTEURS

        public Film(int id_, string titre_, DateTime Date_, string resume_, string affiche_, int duree_, int genre_id_, int realisateur_id_)
        {
            _id = id_;
            _titre = titre_;
            _Date = Date_;
            _resume = resume_;
            _affiche = affiche_;
            _duree = duree_;
            _genre_id = genre_id_;
            _realisateur_id = realisateur_id_;
        }
    }
}
