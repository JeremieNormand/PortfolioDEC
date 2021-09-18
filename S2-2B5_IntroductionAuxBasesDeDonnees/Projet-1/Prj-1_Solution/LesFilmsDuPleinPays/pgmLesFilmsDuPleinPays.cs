using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LesFilmsDuPleinPays.Enregistrements;
using LesFilmsDuPleinPays.Operations;

namespace LesFilmsDuPleinPays
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmConnexionServeur());



        //    OperationBD OperationBD = new OperationBD();



        //    // test de la connexion au serveur

        //    MessageBox.Show($"Connecté au réseau du Cégep : {OperationBD.GetStatutConnexion()}");



        //    // test d'une instruction SELECT

        //    bool sEstExecuteSansProbleme = true;
        //    string affichage = "### Test d'une instruction SELECT sur la base de données ###\n";
        //    affichage += "\n";
        //    List<Film> LstFilm = OperationBD.GetAllFilms(out sEstExecuteSansProbleme);
        //    affichage += "----------------------------------------------------------------\n";
        //    affichage += $"Exécution sans problème : {sEstExecuteSansProbleme}\n";
        //    affichage += "----------------------------------------------------------------\n";
        //    affichage += "\n";
        //    affichage += $"- {LstFilm.Count} films ont été récupéré.\n";
        //    affichage += "\n";
        //    affichage += "Les titres sont les suivants :\n";
        //    affichage += "--------------------------------\n";
        //    foreach (Film Film in LstFilm)
        //    {
        //        affichage += $"- {Film.Titre}\n";
        //    }
        //    MessageBox.Show(affichage);



        //    // test d'une instruction DELETE

        //    sEstExecuteSansProbleme = true;
        //    affichage = "### Test d'une instruction DELETE sur la base de données ###\n";
        //    affichage += "\n";
        //    int filmId = 6;
        //    FilmComplet FilmComplet = OperationBD.GetFilmCompletWith(filmId, out sEstExecuteSansProbleme);
        //    FilmComplet.LstRoleComplet = OperationBD.GetAllRolesCompletsWith(filmId, out sEstExecuteSansProbleme);
        //    affichage += $"Exécution du SELECT sans problème : {sEstExecuteSansProbleme}\n";
        //    affichage += "\n";
        //    affichage += $"Nombre de films dans la base de données : {LstFilm.Count}\n";
        //    affichage += $"Titre du film à supprimer : {FilmComplet.Titre}\n";
        //    affichage += $"Nombre de rôles associés : {FilmComplet.LstRoleComplet.Count}\n";
        //    affichage += $"\n";
        //    affichage += "----------------------------------------------------------------\n";
        //    affichage += "** Exécution de l'instruction DELETE sur les rôles associés et sur le film **\n";
        //    affichage += "----------------------------------------------------------------\n";
        //    affichage += $"\n";
        //    OperationBD.DeleteFilmWith(filmId, out sEstExecuteSansProbleme);
        //    affichage += $"Exécution du DELETE sans problème : {sEstExecuteSansProbleme}\n";
        //    FilmComplet = OperationBD.GetFilmCompletWith(filmId, out sEstExecuteSansProbleme);
        //    FilmComplet.LstRoleComplet = OperationBD.GetAllRolesCompletsWith(filmId, out sEstExecuteSansProbleme);
        //    LstFilm = OperationBD.GetAllFilms(out sEstExecuteSansProbleme);
        //    affichage += $"Exécution du SELECT à blanc sans problème : {sEstExecuteSansProbleme}\n";
        //    affichage += $"\n";
        //    affichage += $"Nombre de films restant dans la base de données : {LstFilm.Count}\n";
        //    affichage += $"Titre du film obtenue après suppression : {FilmComplet.Titre}\n";
        //    affichage += $"Nombre de rôles associés après suppression : {FilmComplet.LstRoleComplet.Count}\n";
        //    MessageBox.Show(affichage);



        //    // test d'une instruction INSERT

        //    sEstExecuteSansProbleme = true;
        //    affichage = "### Test d'une instruction INSERT sur la base de données ###\n";
        //    affichage += "\n";
        //    foreach (Film Film in LstFilm)
        //    {
        //        if (Film.Id > filmId)
        //        {
        //            filmId = Film.Id;
        //        }
        //    }
        //    affichage += $"Nombre de films dans la base de données : {LstFilm.Count}\n";
        //    affichage += $"Titre du film à insérer : {FilmComplet.Titre}\n";
        //    affichage += $"\n";
        //    affichage += "----------------------------------------------------------------\n";
        //    affichage += "** Exécution de l'instruction INSERT **\n";
        //    affichage += "----------------------------------------------------------------\n";
        //    affichage += $"\n";
        //    OperationBD.InsertFilmWith(FilmComplet, out sEstExecuteSansProbleme);
        //    affichage += $"Exécution du INSERT sans problème : {sEstExecuteSansProbleme}\n";
        //    FilmComplet = OperationBD.GetFilmCompletWith(filmId, out sEstExecuteSansProbleme);
        //    FilmComplet.LstRoleComplet = OperationBD.GetAllRolesCompletsWith(filmId, out sEstExecuteSansProbleme);
        //    LstFilm = OperationBD.GetAllFilms(out sEstExecuteSansProbleme);
        //    affichage += $"Exécution du SELECT à blanc sans problème : {sEstExecuteSansProbleme}\n";
        //    affichage += $"\n";
        //    affichage += $"Nombre de films après insertion dans la base de données : {LstFilm.Count}\n";
        //    affichage += $"Titre du film obtenue après insertion : {FilmComplet.Titre}\n";
        //    MessageBox.Show(affichage);



        //    // test d'une instruction SELECT pour tester la connexion

        //    sEstExecuteSansProbleme = true;
        //    affichage = "### Test d'une instruction SELECT pour tester la connexion ###\n";
        //    affichage += "\n";
        //    LstFilm = OperationBD.GetAllFilms(out sEstExecuteSansProbleme);
        //    affichage += "----------------------------------------------------------------\n";
        //    affichage += $"Exécution sans problème : {sEstExecuteSansProbleme}\n";
        //    affichage += "----------------------------------------------------------------\n";
        //    affichage += "\n";
        //    affichage += $"- {LstFilm.Count} films ont été récupéré.\n";
        //    affichage += "\n";
        //    affichage += "Les titres sont les suivants :\n";
        //    affichage += "--------------------------------\n";
        //    foreach (Film Film in LstFilm)
        //    {
        //        affichage += $"- {Film.Titre}\n";
        //    }
        //    MessageBox.Show(affichage);
        }
    }
}
