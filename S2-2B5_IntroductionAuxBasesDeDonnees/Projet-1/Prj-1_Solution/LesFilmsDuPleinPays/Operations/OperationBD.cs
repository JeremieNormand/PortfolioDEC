using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using LesFilmsDuPleinPays.Enregistrements;
using System.Windows.Forms;

namespace LesFilmsDuPleinPays.Operations
{
    public class OperationBD
    {
        // CHAMPS

        private string _hote;
        private string _service;
        private string _identifiant;
        private string _password;
        private string _clef_de_connexion;
        private OracleConnection _Connexion;

        // CONSTRUCTEURS

        public OperationBD()
        {
            _hote = "10.2.0.7";
            _service = "1521/orcl";
            _identifiant = "normandj";
            _password = "1334718";
            _clef_de_connexion = $"User Id={_identifiant}; Password={_password}; Data Source={_hote}:{_service}; Pooling=false";
            _Connexion = new OracleConnection(_clef_de_connexion);
        }

        // METHODES

        public bool GetStatutConnexion()
        {
            bool statutConnexion;
            try
            {
                Ping Ping = new Ping();
                PingReply Reponse = Ping.Send(_hote, 2000);
                if (Reponse.Status.ToString() == "Success")
                {
                    statutConnexion = true;
                }
                else
                {
                    statutConnexion = false;
                }
            }
            catch (Exception)
            {
                _Connexion.Close();
                statutConnexion = false;
            }
            return statutConnexion;
        }

        public List<Film> GetAllFilms(out bool flawless_)
        {
            List<Film> LstFilm = new List<Film>();
            try
            {
                _Connexion.Open();
                string requete = "SELECT * FROM films ORDER BY film_id";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                OracleDataReader Reader = Instruction.ExecuteReader();
                while (Reader.Read())
                {
                    Film Film = new Film();
                    Film.Id = int.Parse(Reader["film_id"].ToString());
                    Film.Titre = Reader["film_titre"].ToString();
                    Film.Date = DateTime.Parse(Reader["film_dateParution"].ToString());
                    Film.Resume = Reader["film_resume"].ToString();
                    Film.Affiche = Reader["film_affiche"].ToString();
                    Film.Duree = int.Parse(Reader["film_duree"].ToString());
                    Film.GenreId = int.Parse(Reader["genre_id"].ToString());
                    Film.RealisateurId = int.Parse(Reader["realisateur_id"].ToString());
                    LstFilm.Add(Film);
                }
                Reader.Close();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
            return LstFilm;
        }

        public List<Realisateur> GetAllRealisateurs(out bool flawless_)
        {
            List<Realisateur> LstRealisateur = new List<Realisateur>();
            try
            {
                _Connexion.Open();
                string requete = "SELECT * FROM realisateurs ORDER BY realisateur_nom, realisateur_prenom";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                OracleDataReader Reader = Instruction.ExecuteReader();
                while (Reader.Read())
                {
                    Realisateur Realisateur = new Realisateur();
                    Realisateur.Id = int.Parse(Reader["realisateur_id"].ToString());
                    Realisateur.Nom = Reader["realisateur_nom"].ToString();
                    Realisateur.Prenom = Reader["realisateur_prenom"].ToString();
                    Realisateur.GenreId = int.Parse(Reader["genre_id"].ToString());
                    LstRealisateur.Add(Realisateur);
                }
                Reader.Close();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
            return LstRealisateur;
        }

        public List<Acteur> GetAllActeurs(out bool flawless_)
        {
            List<Acteur> LstActeur = new List<Acteur>();
            try
            {
                _Connexion.Open();
                string requete = "SELECT * FROM acteurs ORDER BY acteur_nom, acteur_prenom";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                OracleDataReader Reader = Instruction.ExecuteReader();
                while (Reader.Read())
                {
                    Acteur Acteur = new Acteur();
                    Acteur.Id = int.Parse(Reader["acteur_id"].ToString());
                    Acteur.Nom = Reader["acteur_nom"].ToString();
                    Acteur.Prenom = Reader["acteur_prenom"].ToString();
                    LstActeur.Add(Acteur);
                }
                Reader.Close();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
            return LstActeur;
        }

        public List<Role> GetAllRoles(out bool flawless_)
        {
            List<Role> LstRole = new List<Role>();
            try
            {
                _Connexion.Open();
                string requete = "SELECT * FROM roles ORDER BY role_nom";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                OracleDataReader Reader = Instruction.ExecuteReader();
                while (Reader.Read())
                {
                    Role Role = new Role();
                    Role.FilmId = int.Parse(Reader["film_id"].ToString());
                    Role.ActeurId = int.Parse(Reader["acteur_id"].ToString());
                    Role.Nom = Reader["role_nom"].ToString();
                    LstRole.Add(Role);
                }
                Reader.Close();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
            return LstRole;
        }

        public List<Genre> GetAllGenres(out bool flawless_)
        {
            List<Genre> LstGenre = new List<Genre>();
            try
            {
                _Connexion.Open();
                string requete = "SELECT * FROM genres ORDER BY genre_nom";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                OracleDataReader Reader = Instruction.ExecuteReader();
                while (Reader.Read())
                {
                    Genre Genre = new Genre();
                    Genre.Id = int.Parse(Reader["genre_id"].ToString());
                    Genre.Nom = Reader["genre_nom"].ToString();
                    LstGenre.Add(Genre);
                }
                Reader.Close();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
            return LstGenre;
        }

        public List<RoleComplet> GetAllRolesCompletsWith(int film_id_, out bool flawless_)
        {
            List<RoleComplet> LstRoleComplet = new List<RoleComplet>();
            try
            {
                _Connexion.Open();
                string requete = $"SELECT * FROM roles r INNER JOIN acteurs a ON r.acteur_id = a.acteur_id INNER JOIN films f ON r.film_id = f.film_id WHERE f.film_id = {film_id_}";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                OracleDataReader Reader = Instruction.ExecuteReader();
                while (Reader.Read())
                {
                    RoleComplet RoleComplet = new RoleComplet();
                    RoleComplet.Nom = Reader["acteur_nom"].ToString();
                    RoleComplet.Prenom = Reader["acteur_prenom"].ToString();
                    RoleComplet.RoleNom = Reader["role_nom"].ToString();
                    LstRoleComplet.Add(RoleComplet);
                }
                Reader.Close();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
            return LstRoleComplet;
        }

        public List<RoleComplet> GetAllRolesCompletsWith(string film_titre_, out bool flawless_)
        {
            List<RoleComplet> LstRoleComplet = new List<RoleComplet>();
            try
            {
                _Connexion.Open();
                string requete = $"SELECT * FROM roles r INNER JOIN acteurs a ON r.acteur_id = a.acteur_id INNER JOIN films f ON r.film_id = f.film_id WHERE f.film_titre = '{film_titre_}'";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                OracleDataReader Reader = Instruction.ExecuteReader();
                while (Reader.Read())
                {
                    RoleComplet RoleComplet = new RoleComplet();
                    RoleComplet.Nom = Reader["acteur_nom"].ToString();
                    RoleComplet.Prenom = Reader["acteur_prenom"].ToString();
                    RoleComplet.RoleNom = Reader["role_nom"].ToString();
                    LstRoleComplet.Add(RoleComplet);
                }
                Reader.Close();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
            return LstRoleComplet;
        }

        public FilmComplet GetFilmCompletWith(int film_id_, out bool flawless_)
        {
            FilmComplet FilmComplet = new FilmComplet();
            try
            {
                _Connexion.Open();
                string requete = $"SELECT * FROM films f INNER JOIN genres g ON f.genre_id = g.genre_id INNER JOIN realisateurs r ON f.realisateur_id = r.realisateur_id WHERE f.film_id = {film_id_}";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                OracleDataReader Reader = Instruction.ExecuteReader();
                Reader.Read();
                FilmComplet.Id = int.Parse(Reader["film_id"].ToString());
                FilmComplet.Titre = Reader["film_titre"].ToString();
                FilmComplet.Date = DateTime.Parse(Reader["film_dateParution"].ToString());
                FilmComplet.Resume = Reader["film_resume"].ToString();
                FilmComplet.Affiche = Reader["film_affiche"].ToString();
                FilmComplet.Duree = int.Parse(Reader["film_duree"].ToString());
                FilmComplet.GenreId = int.Parse(Reader["genre_id"].ToString());
                FilmComplet.GenreNom = Reader["genre_nom"].ToString();
                FilmComplet.RealisateurId = int.Parse(Reader["realisateur_id"].ToString());
                FilmComplet.RealisateurNom = Reader["realisateur_nom"].ToString();
                FilmComplet.RealisateurPrenom = Reader["realisateur_prenom"].ToString();
                FilmComplet.LstRoleComplet = new List<RoleComplet>();
                Reader.Close();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
            return FilmComplet;
        }

        public FilmComplet GetFilmCompletWith(string film_titre_, out bool flawless_)
        {
            FilmComplet FilmComplet = new FilmComplet();
            try
            {
                _Connexion.Open();
                string requete = $"SELECT * FROM films f INNER JOIN genres g ON f.genre_id = g.genre_id INNER JOIN realisateurs r ON f.realisateur_id = r.realisateur_id WHERE f.film_titre = '{film_titre_}'";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                OracleDataReader Reader = Instruction.ExecuteReader();
                Reader.Read();
                FilmComplet.Id = int.Parse(Reader["film_id"].ToString());
                FilmComplet.Titre = Reader["film_titre"].ToString();
                FilmComplet.Date = DateTime.Parse(Reader["film_dateParution"].ToString());
                FilmComplet.Resume = Reader["film_resume"].ToString();
                FilmComplet.Affiche = Reader["film_affiche"].ToString();
                FilmComplet.Duree = int.Parse(Reader["film_duree"].ToString());
                FilmComplet.GenreId = int.Parse(Reader["genre_id"].ToString());
                FilmComplet.GenreNom = Reader["genre_nom"].ToString();
                FilmComplet.RealisateurId = int.Parse(Reader["realisateur_id"].ToString());
                FilmComplet.RealisateurNom = Reader["realisateur_nom"].ToString();
                FilmComplet.RealisateurPrenom = Reader["realisateur_prenom"].ToString();
                FilmComplet.LstRoleComplet = new List<RoleComplet>();
                Reader.Close();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
            return FilmComplet;
        }

        public int GetGenreIdByName(string genre_nom_)
        {
            bool flawless;
            List<Genre> LstGenre = GetAllGenres(out flawless);
            if (flawless)
            {
                int id = 0;
                foreach (Genre Genre in LstGenre)
                {
                    if (Genre.Nom == genre_nom_)
                    {
                        id = Genre.Id;
                    }
                }
                return id;
            }
            else
            {
                return 0;
            }
        }

        public int GetRealisateurIdByName(string nom_, string prenom_)
        {
            bool flawless;
            List<Realisateur> LstRealisateur = GetAllRealisateurs(out flawless);
            if (flawless)
            {
                int id = 0;
                foreach (Realisateur Realisateur in LstRealisateur)
                {
                    if (Realisateur.Nom == nom_ && Realisateur.Prenom == prenom_)
                    {
                        id = Realisateur.Id;
                    }
                }
                return id;
            }
            else
            {
                return 0;
            }
        }

        public void UpdateFilmCompletWith(FilmComplet film_complet_, out bool flawless_)
        {
            try
            {
                _Connexion.Open();
                string requete = "ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD'";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                Instruction.ExecuteNonQuery();
                requete = $"UPDATE films SET film_titre = '{film_complet_.Titre}', film_duree = {film_complet_.Duree}, film_resume = '{film_complet_.Resume}', film_dateParution = CAST('{film_complet_.Date.ToString("yyyy-MM-dd")}' AS DATE), film_affiche = '{film_complet_.Affiche}', genre_id = {film_complet_.GenreId}, realisateur_id = {film_complet_.RealisateurId} WHERE film_id = {film_complet_.Id}";
                Instruction = new OracleCommand(requete, _Connexion);
                Instruction.ExecuteNonQuery();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
        }

        public void InsertFilmCompletWith(FilmComplet film_complet_, out bool flawless_)
        {
            try
            {
                _Connexion.Open();
                string requete = "ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD'";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                Instruction.ExecuteNonQuery();
                requete = $"INSERT INTO films VALUES (seq_films_film_id.NEXTVAL, '{film_complet_.Titre}', {film_complet_.Duree}, '{film_complet_.Resume}', CAST('{film_complet_.Date.ToString("yyyy-MM-dd")}' AS DATE), '{film_complet_.Affiche}', {film_complet_.GenreId}, {film_complet_.RealisateurId})";
                Instruction = new OracleCommand(requete, _Connexion);
                Instruction.ExecuteNonQuery();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
        }

        public void DeleteRolesWith(int film_id_, out bool flawless_)
        {
            try
            {
                _Connexion.Open();
                string requete = $"DELETE FROM roles WHERE film_id = {film_id_}";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                Instruction.ExecuteNonQuery();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
        }

        public void DeleteFilmWith(int film_id_, out bool flawless_)
        {
            try
            {
                _Connexion.Open();
                string requete = $"DELETE FROM films WHERE film_id = {film_id_}";
                OracleCommand Instruction = new OracleCommand(requete, _Connexion);
                Instruction.ExecuteNonQuery();
                _Connexion.Close();
                flawless_ = true;
            }
            catch (Exception Exception_)
            {
                _Connexion.Close();
                flawless_ = false;
                MessageBox.Show(Exception_.Message);
            }
        }
    }
}
