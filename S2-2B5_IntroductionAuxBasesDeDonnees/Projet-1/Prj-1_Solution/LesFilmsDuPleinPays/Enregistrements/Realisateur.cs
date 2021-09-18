using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilmsDuPleinPays.Enregistrements
{
    public struct Realisateur
    {
        // CHAMPS

        private int _id;
        private string _nom;
        private string _prenom;
        private int _genre_id;

        // PROPRIETES

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public int GenreId
        {
            get { return _genre_id; }
            set { _genre_id = value; }
        }

        // CONSTRUCTEURS

        public Realisateur(int id_, string nom_, string prenom_, int genre_id_)
        {
            _id = id_;
            _nom = nom_;
            _prenom = prenom_;
            _genre_id = genre_id_;
        }
    }
}
