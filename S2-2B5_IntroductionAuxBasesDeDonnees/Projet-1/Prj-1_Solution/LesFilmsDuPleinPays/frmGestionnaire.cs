using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LesFilmsDuPleinPays.Enregistrements;
using LesFilmsDuPleinPays.Operations;

namespace LesFilmsDuPleinPays
{
    public partial class frmGestionnaire : Form
    {
        // STRUCTURES

        private struct CheckList
        {
            public bool Id;
            public bool Titre;
            public bool Date;
            public bool Duree;
            public bool Resume;
            public bool Genre;
            public bool Realisateur;
            public bool Roles;
        }



        // CHAMPS

        OperationBD _Operation_BD;

        FilmComplet _Film_Complet_Select;
        FilmComplet _Film_Complet_Update;
        FilmComplet _Film_Complet_Update_Modifie;
        FilmComplet _Film_Complet_Insert;
        FilmComplet _Film_Complet_Delete;

        CheckList _Modifications_Update;
        CheckList _Modifications_Insert;

        CheckList _Erreurs_Update;
        CheckList _Erreurs_Insert;

        bool _valide_update;
        bool _valide_delete;

        bool _updatable_select;
        bool _updatable_update;
        bool _updatable_delete;

        // CONSTRUCTEURS

        public frmGestionnaire()
        {
            _Operation_BD = new OperationBD();

            _Film_Complet_Select = new FilmComplet();
            _Film_Complet_Update = new FilmComplet();
            _Film_Complet_Update_Modifie = new FilmComplet();
            _Film_Complet_Insert = new FilmComplet();
            _Film_Complet_Delete = new FilmComplet();

            _Modifications_Update = new CheckList();
            _Modifications_Insert = new CheckList();

            _Erreurs_Update = new CheckList();
            _Erreurs_Insert = new CheckList();

            _valide_update = false;
            _valide_delete = false;

            _updatable_select = true;
            _updatable_update = true;
            _updatable_delete = true;

            InitializeComponent();
        }



        // METHODES

        // - Gestionnaire

        private void frmGestionnaire_Load(object sender_, EventArgs event_)
        {
            InitialiserSelect();
            InitialiserUpdate();
            InitialiserInsert();
            InitialiserDelete();
        }



        // - Accueil

        private void btnAllerAOngletSelect_Click(object sender_, EventArgs event_)
        {
            tbcGestionnaire.SelectedTab = tabSelect;
        }

        private void btnAllerAOngletUpdate_Click(object sender_, EventArgs event_)
        {
            tbcGestionnaire.SelectedTab = tabUpdate;
        }

        private void btnAllerAOngletInsert_Click(object sender_, EventArgs event_)
        {
            tbcGestionnaire.SelectedTab = tabInsert;
        }

        private void btnAllerAOngletDelete_Click(object sender_, EventArgs event_)
        {
            tbcGestionnaire.SelectedTab = tabDelete;
        }



        // - Select

        // - - Initialisation

        private void RemplirCbxTitreSelect()
        {
            ComboBox CbxTitre = cbxTitreSelect;
            CbxTitre.Items.Clear();
            bool flawless;
            List<Film> LstFilm = _Operation_BD.GetAllFilms(out flawless);
            if (flawless && LstFilm != null && LstFilm.Count > 0)
            {
                foreach (Film Film in LstFilm)
                {
                    CbxTitre.Items.Add(Film.Titre);
                }
            }
        }

        private void InitialiserDgvRolesCompletsSelect()
        {
            DataGridView DgvRoles = dgvRolesCompletsSelect;
            DgvRoles.Rows.Clear();
            DgvRoles.ColumnCount = 2;
            DgvRoles.Columns[0].Name = "Nom";
            DgvRoles.Columns[1].Name = "Rôle";
        }

        private void MettreABlancSelect()
        {
            _updatable_select = false;
            cbxTitreSelect.SelectedIndex = -1;
            txtIdSelect.Text = null;
            datDateSelect.Value = DateTime.Now;
            txtDureeSelect.Text = null;
            txtResumeSelect.Text = null;
            txtGenreSelect.Text = null;
            txtRealisateurSelect.Text = null;
            dgvRolesCompletsSelect.Rows.Clear();
            picAfficheSelect.Image = null;
            _updatable_select = true;
        }

        private void InitialiserSelect()
        {
            _Film_Complet_Select = new FilmComplet();
            RemplirCbxTitreSelect();
            InitialiserDgvRolesCompletsSelect();
            MettreABlancSelect();
        }

        private void FillSelect(FilmComplet film_complet_)
        {
            _updatable_select = false;
            cbxTitreSelect.SelectedIndex = cbxTitreSelect.FindStringExact(film_complet_.Titre);
            txtIdSelect.Text = film_complet_.Id.ToString();
            datDateSelect.Value = film_complet_.Date;
            txtDureeSelect.Text = film_complet_.Duree.ToString();
            txtResumeSelect.Text = film_complet_.Resume;
            txtGenreSelect.Text = film_complet_.GenreNom;
            txtRealisateurSelect.Text = $"{film_complet_.RealisateurPrenom} {film_complet_.RealisateurNom}";
            DataGridView DgvRoles = dgvRolesCompletsSelect;
            DgvRoles.Rows.Clear();
            if (film_complet_.LstRoleComplet != null && film_complet_.LstRoleComplet.Count > 0)
            {
                foreach (RoleComplet Role in film_complet_.LstRoleComplet)
                {
                    DgvRoles.Rows.Add($"{Role.Prenom} {Role.Nom}", Role.RoleNom);
                }
            }
            try
            {
                picAfficheSelect.Image = Image.FromFile($"../../Affiches/{film_complet_.Affiche}");
            }
            catch (Exception)
            {
                
            }
            _updatable_select = true;
        }


        // - - Fonction

        private void cbxTitreSelect_SelectedIndexChanged(object sender_, EventArgs event_)
        {
            if (_updatable_select)
            {
                ComboBox CbxTitre = cbxTitreSelect;
                string titre = CbxTitre.SelectedItem.ToString();
                bool flawless;
                _Film_Complet_Select = _Operation_BD.GetFilmCompletWith(titre, out flawless);
                _Film_Complet_Select.LstRoleComplet = _Operation_BD.GetAllRolesCompletsWith(titre, out flawless);
                if (flawless)
                {
                    FillSelect(_Film_Complet_Select);
                }
                else
                {
                    MettreABlancSelect();
                    MessageBox.Show("Une erreur est survenue avec Oracle.");
                }
            }
        }



        // - Update

        // - - Initialisation

        private void RemplirCbxIdUpdate()
        {
            ComboBox CbxId = cbxIdUpdate;
            CbxId.Items.Clear();
            bool flawless;
            List<Film> LstFilm = _Operation_BD.GetAllFilms(out flawless);
            if (flawless && LstFilm != null && LstFilm.Count > 0)
            {
                foreach (Film Film in LstFilm)
                {
                    CbxId.Items.Add(Film.Id);
                }
            }
        }

        private void RemplirCbxGenreUpdate()
        {
            ComboBox CbxGenre = cbxGenreUpdate;
            CbxGenre.Items.Clear();
            bool flawless;
            List<Genre> LstGenre = _Operation_BD.GetAllGenres(out flawless);
            if (flawless && LstGenre != null && LstGenre.Count > 0)
            {
                foreach (Genre Genre in LstGenre)
                {
                    CbxGenre.Items.Add(Genre.Nom);
                }
            }
        }

        private void RemplirCbxRealisateurUpdate()
        {
            ComboBox CbxRealisateur = cbxRealisateurUpdate;
            CbxRealisateur.Items.Clear();
            bool flawless;
            List<Realisateur> LstRealisateur = _Operation_BD.GetAllRealisateurs(out flawless);
            if (flawless && LstRealisateur != null && LstRealisateur.Count > 0)
            {
                foreach (Realisateur Realisateur in LstRealisateur)
                {
                    CbxRealisateur.Items.Add($"{Realisateur.Prenom} {Realisateur.Nom}");
                }
            }
        }

        private void InitialiserDgvRolesCompletsUpdate()
        {
            DataGridView DgvRolesComplets = dgvRolesCompletsUpdate;
            DgvRolesComplets.Rows.Clear();
            DgvRolesComplets.ColumnCount = 2;
            DgvRolesComplets.Columns[0].Name = "Nom";
            DgvRolesComplets.Columns[1].Name = "Rôle";
        }

        private void MettreABlancUpdate()
        {
            _updatable_update = false;
            Color Color = Color.White;
            txtTitreUpdate.Text = null;
            txtTitreUpdate.BackColor = Color;
            cbxIdUpdate.SelectedIndex = -1;
            datDateUpdate.Value = DateTime.Now;
            txtDureeUpdate.Text = null;
            txtDureeUpdate.BackColor = Color;
            txtResumeUpdate.Text = null;
            txtResumeUpdate.BackColor = Color;
            cbxGenreUpdate.SelectedIndex = -1;
            cbxGenreUpdate.BackColor = Color;
            cbxRealisateurUpdate.SelectedIndex = -1;
            cbxRealisateurUpdate.BackColor = Color;
            dgvRolesCompletsUpdate.Rows.Clear();
            _updatable_update = true;
        }

        private void InitialiserUpdate()
        {
            _Film_Complet_Update = new FilmComplet();
            RemplirCbxIdUpdate();
            RemplirCbxGenreUpdate();
            RemplirCbxRealisateurUpdate();
            InitialiserDgvRolesCompletsUpdate();
            MettreABlancUpdate();
        }

        private void FillUpdate(FilmComplet film_complet_)
        {
            _updatable_update = false;
            txtTitreUpdate.Text = film_complet_.Titre;
            cbxIdUpdate.SelectedIndex = cbxIdUpdate.FindStringExact(film_complet_.Id.ToString());
            datDateUpdate.Value = film_complet_.Date;
            txtDureeUpdate.Text = film_complet_.Duree.ToString();
            txtResumeUpdate.Text = film_complet_.Resume;
            cbxGenreUpdate.SelectedIndex = cbxGenreUpdate.FindStringExact(film_complet_.GenreNom);
            cbxRealisateurUpdate.SelectedIndex = cbxRealisateurUpdate.FindStringExact($"{film_complet_.RealisateurPrenom} {film_complet_.RealisateurNom}");
            DataGridView DgvRoles = dgvRolesCompletsUpdate;
            DgvRoles.Rows.Clear();
            if (film_complet_.LstRoleComplet != null && film_complet_.LstRoleComplet.Count > 0)
            {
                foreach (RoleComplet Role in film_complet_.LstRoleComplet)
                {
                    DgvRoles.Rows.Add($"{Role.Prenom} {Role.Nom}", Role.RoleNom);
                }
            }
            _updatable_update = true;
        }


        // - - Fonctions

        private void CbxIdUpdate_SelectedIndexChanged(int film_id_)
        {
            if (_updatable_update)
            {
                bool flawless;
                _Film_Complet_Update = _Operation_BD.GetFilmCompletWith(film_id_, out flawless);
                _Film_Complet_Update.LstRoleComplet = _Operation_BD.GetAllRolesCompletsWith(film_id_, out flawless);
                if (flawless)
                {
                    _valide_update = true;
                    MettreABlancUpdate();
                    FillUpdate(_Film_Complet_Update);
                }
                else
                {
                    _valide_update = false;
                    MettreABlancUpdate();
                    MessageBox.Show("Une erreur est survenue avec Oracle.");
                }
            }
        }

        private void cbxIdUpdate_SelectedIndexChanged(object sender_, EventArgs event_)
        {
            if (_updatable_update)
            {
                ComboBox CbxId = cbxIdUpdate;
                int id = int.Parse(CbxId.SelectedItem.ToString());
                CbxIdUpdate_SelectedIndexChanged(id);
            }
        }

        private void txtTitreUpdate_Validating(object sender_, CancelEventArgs event_)
        {
            if (_valide_update)
            {
                TextBox TxtTitre = txtTitreUpdate;
                if (TxtTitre.Text == null)
                {
                    _Erreurs_Update.Titre = true;
                    _Modifications_Update.Titre = false;
                    TxtTitre.BackColor = Color.LightPink;
                }
                else if (TxtTitre.Text == "")
                {
                    _Erreurs_Update.Titre = true;
                    _Modifications_Update.Titre = false;
                    TxtTitre.BackColor = Color.LightPink;
                }
                else if (TxtTitre.Text == _Film_Complet_Update.Titre)
                {
                    _Erreurs_Update.Titre = false;
                    _Modifications_Update.Titre = false;
                    TxtTitre.BackColor = Color.White;
                }
                else
                {
                    _Erreurs_Update.Titre = false;
                    _Modifications_Update.Titre = true;
                    TxtTitre.BackColor = Color.PaleGoldenrod;
                }
            }
        }

        private void datDateUpdate_Validating(object sender_, CancelEventArgs event_)
        {
            if (_valide_update)
            {
                DateTimePicker DatDate = datDateUpdate;
                if (DatDate.Value == _Film_Complet_Update.Date)
                {
                    _Modifications_Update.Date = false;
                    DatDate.BackColor = Color.White;
                }
                else
                {
                    _Modifications_Update.Date = true;
                    DatDate.BackColor = Color.PaleGoldenrod;
                }
            }
        }

        private void txtDureeUpdate_Validating(object sender_, CancelEventArgs event_)
        {
            if (_valide_update)
            {
                TextBox TxtDuree = txtDureeUpdate;
                if (TxtDuree.Text == null)
                {
                    _Erreurs_Update.Duree = true;
                    _Modifications_Update.Duree = false;
                    TxtDuree.BackColor = Color.LightPink;
                }
                else if (TxtDuree.Text == "")
                {
                    _Erreurs_Update.Duree = true;
                    _Modifications_Update.Duree = false;
                    TxtDuree.BackColor = Color.LightPink;
                }
                else if (!int.TryParse(TxtDuree.Text, out int duree))
                {
                    _Erreurs_Update.Duree = true;
                    _Modifications_Update.Duree = false;
                    TxtDuree.BackColor = Color.LightPink;
                }
                else if (duree < 0)
                {
                    _Erreurs_Update.Duree = true;
                    _Modifications_Update.Duree = false;
                    TxtDuree.BackColor = Color.LightPink;
                }
                else if (duree == _Film_Complet_Update.Duree)
                {
                    _Erreurs_Update.Duree = false;
                    _Modifications_Update.Duree = false;
                    TxtDuree.BackColor = Color.White;
                }
                else
                {
                    _Erreurs_Update.Duree = false;
                    _Modifications_Update.Duree = true;
                    TxtDuree.BackColor = Color.PaleGoldenrod;
                }
            }
        }

        private void txtResumeUpdate_Validating(object sender_, CancelEventArgs event_)
        {
            if (_valide_update)
            {
                TextBox TxtResume = txtResumeUpdate;
                if (TxtResume.Text == null)
                {
                    _Erreurs_Update.Resume = true;
                    _Modifications_Update.Resume = false;
                    TxtResume.BackColor = Color.LightPink;
                }
                else if (TxtResume.Text == "")
                {
                    _Erreurs_Update.Resume = true;
                    _Modifications_Update.Resume = false;
                    TxtResume.BackColor = Color.LightPink;
                }
                else if (TxtResume.Text == _Film_Complet_Update.Resume)
                {
                    _Erreurs_Update.Resume = false;
                    _Modifications_Update.Resume = false;
                    TxtResume.BackColor = Color.White;
                }
                else
                {
                    _Erreurs_Update.Resume = false;
                    _Modifications_Update.Resume = true;
                    TxtResume.BackColor = Color.PaleGoldenrod;
                }
            }
        }

        private void cbxGenreUpdate_Validating(object sender_, CancelEventArgs event_)
        {
            if (_valide_update)
            {
                ComboBox CbxGenre = cbxGenreUpdate;
                if (CbxGenre.SelectedItem.ToString() == _Film_Complet_Update.GenreNom)
                {
                    _Erreurs_Update.Genre = false;
                    _Modifications_Update.Genre = false;
                    CbxGenre.BackColor = Color.White;
                }
                else if (CbxGenre.SelectedIndex > -1)
                {
                    _Erreurs_Update.Genre = false;
                    _Modifications_Update.Genre = true;
                    CbxGenre.BackColor = Color.PaleGoldenrod;
                }
                else
                {
                    _Erreurs_Update.Genre = true;
                    _Modifications_Update.Genre = false;
                    CbxGenre.BackColor = Color.LightPink;
                }
            }
        }

        private void cbxRealisateurUpdate_Validating(object sender_, CancelEventArgs event_)
        {
            if (_valide_update)
            {
                ComboBox CbxRealisateur = cbxRealisateurUpdate;
                if (CbxRealisateur.SelectedItem.ToString() == $"{_Film_Complet_Update.RealisateurPrenom} {_Film_Complet_Update.RealisateurNom}")
                {
                    _Erreurs_Update.Realisateur = false;
                    _Modifications_Update.Realisateur = false;
                    CbxRealisateur.BackColor = Color.White;
                }
                else if (CbxRealisateur.SelectedIndex > -1)
                {
                    _Erreurs_Update.Realisateur = false;
                    _Modifications_Update.Realisateur = true;
                    CbxRealisateur.BackColor = Color.PaleGoldenrod;
                }
                else
                {
                    _Erreurs_Update.Realisateur = true;
                    _Modifications_Update.Realisateur = false;
                    CbxRealisateur.BackColor = Color.LightPink;
                }
            }
        }

        private void btnReinitialiserUpdate_Click(object sender_, EventArgs event_)
        {
            _valide_update = false;
            _Modifications_Update = new CheckList();
            _Erreurs_Update = new CheckList();
            MettreABlancUpdate();
        }

        private FilmComplet ExtraireFilmCompletDeUpdate()
        {
            FilmComplet Film = new FilmComplet();
            Film.Id = int.Parse(cbxIdUpdate.SelectedItem.ToString());
            Film.Titre = txtTitreUpdate.Text;
            Film.Date = datDateUpdate.Value;
            Film.Duree = int.Parse(txtDureeUpdate.Text);
            Film.Resume = txtResumeUpdate.Text;
            string affiche = $"{Film.Date.Year}_";
            foreach (string item in Film.Titre.Split(' '))
            {
                affiche += item.Substring(0, 1).ToUpper() + item.Substring(1, item.Length - 1);
            }
            Film.Affiche = affiche + ".jpg";
            Film.GenreNom = cbxGenreUpdate.SelectedItem.ToString();
            Film.GenreId = _Operation_BD.GetGenreIdByName(Film.GenreNom);
            Film.RealisateurNom = cbxRealisateurUpdate.SelectedItem.ToString().Split(' ')[1];
            Film.RealisateurPrenom = cbxRealisateurUpdate.SelectedItem.ToString().Split(' ')[0];
            Film.RealisateurId = _Operation_BD.GetRealisateurIdByName(Film.RealisateurNom, Film.RealisateurPrenom);
            Film.LstRoleComplet = new List<RoleComplet>();
            return Film;
        }

        private void btnModifierFilmComplet_Click(object sender_, EventArgs event_)
        {
            if (_valide_update)
            {
                if (!EvaluerPresenceDe(true, _Erreurs_Update) && EvaluerPresenceDe(true, _Modifications_Update))
                {
                    int id = int.Parse(cbxIdUpdate.SelectedItem.ToString());
                    bool flawless;
                    _Film_Complet_Update_Modifie = ExtraireFilmCompletDeUpdate();
                    _Operation_BD.UpdateFilmCompletWith(_Film_Complet_Update_Modifie, out flawless);
                    if (flawless)
                    {
                        _Film_Complet_Update = new FilmComplet();
                        _Film_Complet_Update_Modifie = new FilmComplet();
                        _Modifications_Update = new CheckList();
                        _Erreurs_Update = new CheckList();
                        InitialiserSelect();
                        InitialiserUpdate();
                        InitialiserInsert();
                        InitialiserDelete();
                        CbxIdUpdate_SelectedIndexChanged(id);
                    }
                    else
                    {
                        _valide_update = false;
                        MettreABlancUpdate();
                        MessageBox.Show("Une erreur est survenue avec Oracle.");
                    }
                }
                else
                {
                    MessageBox.Show("Il ne doit pas y avoir d'erreurs et au moins un champ doit être modifié.");
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un film à modifier par son Id.");
            }
        }




        // - Insert

        // - - Initialisation

        private void InitialiserTxtIdInsert()
        {
            TextBox TxtId = txtIdInsert;
            TxtId.Text = null;
            bool flawless;
            List<Film> LstFilm = _Operation_BD.GetAllFilms(out flawless);
            if (flawless && LstFilm != null && LstFilm.Count > 0)
            {
                int newId = 0;
                foreach (Film Film in LstFilm)
                {
                    if (Film.Id > newId)
                    {
                        newId = Film.Id + 1;
                    }
                }
                TxtId.Text = newId.ToString();
            }
            else
            {
                MessageBox.Show("Une erreur est survenue avec Oracle.");
            }
        }

        private void RemplirCbxGenreInsert()
        {
            ComboBox CbxGenre = cbxGenreInsert;
            CbxGenre.Items.Clear();
            bool flawless;
            List<Genre> LstGenre = _Operation_BD.GetAllGenres(out flawless);
            if (flawless && LstGenre != null && LstGenre.Count > 0)
            {
                foreach (Genre Genre in LstGenre)
                {
                    CbxGenre.Items.Add(Genre.Nom);
                }
            }
        }

        private void RemplirCbxRealisateurInsert()
        {
            ComboBox CbxRealisateur = cbxRealisateurInsert;
            CbxRealisateur.Items.Clear();
            bool flawless;
            List<Realisateur> LstRealisateur = _Operation_BD.GetAllRealisateurs(out flawless);
            if (flawless && LstRealisateur != null && LstRealisateur.Count > 0)
            {
                foreach (Realisateur Realisateur in LstRealisateur)
                {
                    CbxRealisateur.Items.Add($"{Realisateur.Prenom} {Realisateur.Nom}");
                }
            }
        }

        private void InitialiserDgvRolesCompletsInsert()
        {
            DataGridView DgvRoles = dgvRolesCompletsInsert;
            DgvRoles.Rows.Clear();
            DgvRoles.ColumnCount = 2;
            DgvRoles.Columns[0].Name = "Nom";
            DgvRoles.Columns[1].Name = "Rôle";
        }

        private void MettreABlancInsert()
        {
            Color Color = Color.White;
            txtTitreInsert.Text = null;
            txtTitreInsert.BackColor = Color;
            InitialiserTxtIdInsert();
            datDateInsert.Value = DateTime.Now;
            txtDureeInsert.Text = null;
            txtDureeInsert.BackColor = Color;
            txtResumeInsert.Text = null;
            txtResumeInsert.BackColor = Color;
            cbxGenreInsert.SelectedIndex = -1;
            cbxGenreInsert.BackColor = Color;
            cbxRealisateurInsert.SelectedIndex = -1;
            cbxRealisateurInsert.BackColor = Color;
            dgvRolesCompletsInsert.Rows.Clear();
        }

        private void InitialiserInsert()
        {
            _Film_Complet_Insert = new FilmComplet();
            InitialiserTxtIdInsert();
            RemplirCbxGenreInsert();
            RemplirCbxRealisateurInsert();
            InitialiserDgvRolesCompletsInsert();
            MettreABlancInsert();
        }


        // - - Fonction

        private void txtTitreInsert_Validating(object sender_, CancelEventArgs event_)
        {
            TextBox TxtTitre = txtTitreInsert;
            if (TxtTitre.Text == null)
            {
                _Erreurs_Insert.Titre = true;
                _Modifications_Insert.Titre = false;
                TxtTitre.BackColor = Color.LightPink;
            }
            else if (TxtTitre.Text == "")
            {
                _Erreurs_Insert.Titre = true;
                _Modifications_Insert.Titre = false;
                TxtTitre.BackColor = Color.LightPink;
            }
            else
            {
                _Erreurs_Insert.Titre = false;
                _Modifications_Insert.Titre = true;
                TxtTitre.BackColor = Color.White;
            }
        }

        private void txtDureeInsert_Validating(object sender_, CancelEventArgs event_)
        {
            TextBox TxtDuree = txtDureeInsert;
            if (TxtDuree.Text == null)
            {
                _Erreurs_Insert.Duree = true;
                _Modifications_Insert.Duree = false;
                TxtDuree.BackColor = Color.LightPink;
            }
            else if (TxtDuree.Text == "")
            {
                _Erreurs_Insert.Duree = true;
                _Modifications_Insert.Duree = false;
                TxtDuree.BackColor = Color.LightPink;
            }
            else if (!int.TryParse(TxtDuree.Text, out int duree))
            {
                _Erreurs_Insert.Duree = true;
                _Modifications_Insert.Duree = false;
                TxtDuree.BackColor = Color.LightPink;
            }
            else if (duree < 0)
            {
                _Erreurs_Insert.Duree = true;
                _Modifications_Insert.Duree = false;
                TxtDuree.BackColor = Color.LightPink;
            }
            else
            {
                _Erreurs_Insert.Duree = false;
                _Modifications_Insert.Duree = true;
                TxtDuree.BackColor = Color.White;
            }
        }

        private void txtResumeInsert_Validating(object sender_, CancelEventArgs event_)
        {
            TextBox TxtResume = txtResumeInsert;
            if (TxtResume.Text == null)
            {
                _Erreurs_Insert.Resume = true;
                _Modifications_Insert.Resume = false;
                TxtResume.BackColor = Color.LightPink;
            }
            else if (TxtResume.Text == "")
            {
                _Erreurs_Insert.Resume = true;
                _Modifications_Insert.Resume = false;
                TxtResume.BackColor = Color.LightPink;
            }
            else
            {
                _Erreurs_Insert.Resume = false;
                _Modifications_Insert.Resume = true;
                TxtResume.BackColor = Color.White;
            }
        }

        private void cbxGenreInsert_Validating(object sender_, CancelEventArgs event_)
        {
            ComboBox CbxGenre = cbxGenreInsert;
            if (CbxGenre.SelectedIndex > -1)
            {
                _Erreurs_Insert.Genre = false;
                _Modifications_Insert.Genre = true;
                CbxGenre.BackColor = Color.White;
            }
            else
            {
                _Erreurs_Insert.Genre = true;
                _Modifications_Insert.Genre = false;
                CbxGenre.BackColor = Color.LightPink;
            }
        }

        private void cbxRealisateurInsert_Validating(object sender_, CancelEventArgs event_)
        {
            ComboBox CbxRealisateur = cbxRealisateurInsert;
            if (CbxRealisateur.SelectedIndex > -1)
            {
                _Erreurs_Insert.Realisateur = false;
                _Modifications_Insert.Realisateur = true;
                CbxRealisateur.BackColor = Color.White;
            }
            else
            {
                _Erreurs_Insert.Realisateur = true;
                _Modifications_Insert.Realisateur = false;
                CbxRealisateur.BackColor = Color.LightPink;
            }
        }

        private void btnReinitialiserInsert_Click(object sender_, EventArgs event_)
        {
            _Modifications_Insert = new CheckList();
            _Erreurs_Insert = new CheckList();
            MettreABlancInsert();
        }

        private FilmComplet ExtraireFilmCompletDeInsert()
        {
            FilmComplet Film = new FilmComplet();
            Film.Id = int.Parse(txtIdInsert.Text);
            Film.Titre = txtTitreInsert.Text;
            Film.Date = datDateInsert.Value;
            Film.Duree = int.Parse(txtDureeInsert.Text);
            Film.Resume = txtResumeInsert.Text;
            string affiche = $"{Film.Date.Year}_";
            foreach (string item in Film.Titre.Split(' '))
            {
                affiche += item.Substring(0, 1).ToUpper() + item.Substring(1, item.Length - 1);
            }
            Film.Affiche = affiche + ".jpg";
            Film.GenreNom = cbxGenreInsert.SelectedItem.ToString();
            Film.GenreId = _Operation_BD.GetGenreIdByName(Film.GenreNom);
            Film.RealisateurNom = cbxRealisateurInsert.SelectedItem.ToString().Split(' ')[1];
            Film.RealisateurPrenom = cbxRealisateurInsert.SelectedItem.ToString().Split(' ')[0];
            Film.RealisateurId = _Operation_BD.GetRealisateurIdByName(Film.RealisateurNom, Film.RealisateurPrenom);
            Film.LstRoleComplet = new List<RoleComplet>();
            return Film;
        }

        private void btnInsererFilmComplet_Click(object sender_, EventArgs event_)
        {
            _Modifications_Insert.Id = true;
            _Modifications_Insert.Date = true;
            _Modifications_Insert.Roles = true;
            if (!EvaluerPresenceDe(true, _Erreurs_Insert) && !EvaluerPresenceDe(false, _Modifications_Insert))
            {
                bool flawless;
                _Film_Complet_Insert = ExtraireFilmCompletDeInsert();
                _Operation_BD.InsertFilmCompletWith(_Film_Complet_Insert, out flawless);
                if (flawless)
                {
                    _Modifications_Insert = new CheckList();
                    _Erreurs_Insert = new CheckList();
                    InitialiserSelect();
                    InitialiserUpdate();
                    InitialiserInsert();
                    InitialiserDelete();
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue avec Oracle.");
                }
            }
            else
            {
                MessageBox.Show("Il ne doit pas y avoir d'erreurs et tous les champs doivent être remplis.");
            }
        }




        // - Delete

        // - - Initialisation

        private void RemplirCbxIdDelete()
        {
            ComboBox CbxId = cbxIdDelete;
            CbxId.Items.Clear();
            bool flawless;
            List<Film> LstFilm = _Operation_BD.GetAllFilms(out flawless);
            if (flawless && LstFilm != null && LstFilm.Count > 0)
            {
                foreach (Film Film in LstFilm)
                {
                    CbxId.Items.Add(Film.Id);
                }
            }
        }

        private void InitialiserDgvRolesCompletsDelete()
        {
            DataGridView DgvRoles = dgvRolesCompletsDelete;
            DgvRoles.Rows.Clear();
            DgvRoles.ColumnCount = 2;
            DgvRoles.Columns[0].Name = "Nom";
            DgvRoles.Columns[1].Name = "Rôle";
        }

        private void MettreABlancDelete()
        {
            _updatable_delete = false;
            txtTitreDelete.Text = null;
            cbxIdDelete.SelectedIndex = -1;
            datDateDelete.Value = DateTime.Now;
            txtDureeDelete.Text = null;
            txtResumeDelete.Text = null;
            txtGenreDelete.Text = null;
            txtRealisateurDelete.Text = null;
            dgvRolesCompletsDelete.Rows.Clear();
            _updatable_delete = true;
        }

        private void InitialiserDelete()
        {
            _Film_Complet_Delete = new FilmComplet();
            RemplirCbxIdDelete();
            InitialiserDgvRolesCompletsDelete();
            MettreABlancDelete();
        }

        private void FillDelete(FilmComplet film_complet_)
        {
            _updatable_delete = false;
            txtTitreDelete.Text = film_complet_.Titre;
            cbxIdDelete.SelectedIndex = cbxIdDelete.FindStringExact(film_complet_.Id.ToString());
            datDateDelete.Value = film_complet_.Date;
            txtDureeDelete.Text = film_complet_.Duree.ToString();
            txtResumeDelete.Text = film_complet_.Resume;
            txtGenreDelete.Text = film_complet_.GenreNom;
            txtRealisateurDelete.Text = $"{film_complet_.RealisateurPrenom} {film_complet_.RealisateurNom}";
            DataGridView DgvRoles = dgvRolesCompletsDelete;
            DgvRoles.Rows.Clear();
            if (film_complet_.LstRoleComplet != null && film_complet_.LstRoleComplet.Count > 0)
            {
                foreach (RoleComplet Role in film_complet_.LstRoleComplet)
                {
                    DgvRoles.Rows.Add($"{Role.Prenom} {Role.Nom}", Role.RoleNom);
                }
            }
            _updatable_delete = true;
        }


        // - - Fonction

        private void cbxIdDelete_SelectedIndexChanged(object sender_, EventArgs event_)
        {
            if (_updatable_delete)
            {
                ComboBox CbxId = cbxIdDelete;
                int id = int.Parse(CbxId.SelectedItem.ToString());
                bool flawless;
                _Film_Complet_Delete = _Operation_BD.GetFilmCompletWith(id, out flawless);
                _Film_Complet_Delete.LstRoleComplet = _Operation_BD.GetAllRolesCompletsWith(id, out flawless);
                if (flawless)
                {
                    _valide_delete = true;
                    FillDelete(_Film_Complet_Delete);
                }
                else
                {
                    _valide_delete = false;
                    MettreABlancDelete();
                    MessageBox.Show("Une erreur est survenue avec Oracle.");
                }
            }
        }

        private void SupprimerFilmComplet(int film_id_, out bool flawless_)
        {
            _Operation_BD.DeleteRolesWith(film_id_, out flawless_);
            if (!flawless_)
            {
                MessageBox.Show("Les rôles associés n'ont pas pu être supprimer.");
            }
            _Operation_BD.DeleteFilmWith(film_id_, out flawless_);
            if (!flawless_)
            {
                MessageBox.Show("Le film n'a pas pu être supprimer.");
            }
        }

        private void btnSupprimerFilmComplet_Click(object sender_, EventArgs event_)
        {
            if (_valide_delete)
            {
                int id = int.Parse(cbxIdDelete.SelectedItem.ToString());
                bool flawless;
                SupprimerFilmComplet(id, out flawless);
                if (flawless)
                {
                    InitialiserSelect();
                    InitialiserUpdate();
                    InitialiserInsert();
                    InitialiserDelete();
                    _valide_delete = false;
                }
                else
                {
                    MessageBox.Show("Une erreur est survenue avec Oracle.");
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un film à supprimer par son Id.");
            }
        }



        // - Autres

        private bool EvaluerPresenceDe(bool valeur_, CheckList Check_List_)
        {
            bool contientValeur = false;
            foreach (var item in typeof(CheckList).GetFields())
            {
                if ((bool)item.GetValue(Check_List_) == valeur_)
                {
                    contientValeur = true;
                }
            }
            return contientValeur;
        }
    }
}
