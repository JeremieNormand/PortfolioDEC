using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;
using LesFilmsDuPleinPays.Enregistrements;

namespace LesFilmsDuPleinPays.Operations
{
    public class OperationFichier
    {
        // CHAMPS

        private string _fichier;

        // CONSTRUCTEURS

        public OperationFichier()
        {
            _fichier = Application.StartupPath + @"\fichier.txt";
        }

        // METHODES

        public void EnregistrerRolesComplets(List<RoleComplet> Lst_Role_Complet_)
        {
            if (Lst_Role_Complet_ != null && Lst_Role_Complet_.Count > 0)
            {
                using (StreamWriter Writer = new StreamWriter(_fichier))
                {
                    foreach (RoleComplet RoleComplet in Lst_Role_Complet_)
                    {
                        Writer.WriteLine($"{RoleComplet.Nom},{RoleComplet.Prenom},{RoleComplet.RoleNom}");
                    }
                }
            }
        }

        public List<RoleComplet> ExtraireRolesComplets()
        {
            List<RoleComplet> LstRoleComplet = new List<RoleComplet>();
            using (StreamReader Reader = new StreamReader(_fichier))
            {
                string ligne = "";
                while ((ligne = Reader.ReadLine()) != null)
                {
                    RoleComplet RoleComplet = new RoleComplet();
                    RoleComplet.Nom = ligne.Split(',')[0];
                    RoleComplet.Prenom = ligne.Split(',')[1];
                    RoleComplet.RoleNom = ligne.Split(',')[2];
                    LstRoleComplet.Add(RoleComplet);
                }
            }
            return LstRoleComplet;
        }
    }
}
