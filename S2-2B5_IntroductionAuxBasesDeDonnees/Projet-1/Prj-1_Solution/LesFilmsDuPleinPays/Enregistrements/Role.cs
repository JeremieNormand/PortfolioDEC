using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilmsDuPleinPays.Enregistrements
{
    public struct Role
    {
        // CHAMPS

        private int _film_id;
        private int _acteur_id;
        private string _nom;

        // PROPRIETES

        public int FilmId
        {
            get { return _film_id; }
            set { _film_id = value; }
        }
        public int ActeurId
        {
            get { return _acteur_id; }
            set { _acteur_id = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        // CONSTRUCTEURS

        public Role(int film_id_, int acteur_id_, string nom_)
        {
            _film_id = film_id_;
            _acteur_id = acteur_id_;
            _nom = nom_;
        }
    }
}
