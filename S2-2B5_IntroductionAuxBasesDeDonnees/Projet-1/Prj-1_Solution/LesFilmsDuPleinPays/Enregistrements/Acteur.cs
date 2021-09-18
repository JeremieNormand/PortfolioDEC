using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilmsDuPleinPays.Enregistrements
{
    public struct Acteur
    {
        // CHAMPS

        private int _id;
        private string _nom;
        private string _prenom;

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

        // CONSTRUCTEURS

        public Acteur(int id_, string nom_, string prenom_)
        {
            _id = id_;
            _nom = nom_;
            _prenom = prenom_;
        }
    }
}
