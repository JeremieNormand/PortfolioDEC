using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesFilmsDuPleinPays.Enregistrements
{
    public struct RoleComplet
    {
        // CHAMPS

        private string _nom;
        private string _prenom;
        private string _role_nom;

        // PROPRIETES

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
        public string RoleNom
        {
            get { return _role_nom; }
            set { _role_nom = value; }
        }

        // CONSTRUCTEURS

        public RoleComplet(string nom_, string prenom_, string role_nom_)
        {
            _nom = nom_;
            _prenom = prenom_;
            _role_nom = role_nom_;
        }
    }
}
