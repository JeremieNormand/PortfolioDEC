using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilmsDuPleinPays.Enregistrements
{
    public struct Genre
    {
        // CHAMPS

        private int _id;
        private string _nom;

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

        // CONSTRUCTEURS

        public Genre(int id_, string nom_)
        {
            _id = id_;
            _nom = nom_;
        }
    }
}
