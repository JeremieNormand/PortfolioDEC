using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Lab10ClassSurchargeList.Classes;

namespace Lab10ClassSurchargeList
{
    public partial class FrmAlbumAuto : Form
    {
        Graphics m_gPanPhoto;

        // membres à déclarer m_ciel, m_auto, m_lune
        Color m_ciel;
        Auto m_auto;
        Lune m_lune;

        // membres List à déclarer m_lstCiel, m_lstAuto, m_lstLune
        List<Color> m_lstCiel;
        List<Auto> m_lstAuto;
        List<Lune> m_lstLune;

        public FrmAlbumAuto()
        {
            InitializeComponent();

            // gestion des boutons
            btnAffiche.Enabled = false;
            btnAfficheAlbum.Enabled = false;

            // avoir des choix par défaut dans les comboBox
            cbxCouleurAuto.SelectedIndex = 0;
            cbxCouleurRoue.SelectedIndex = 0;
            cbxCouleurLune.SelectedIndex = 0;
            cbxDiametreLune.SelectedIndex = 0;
            
            m_gPanPhoto = panPhoto.CreateGraphics();

            // les 2 membres à initialiser (m_auto et m_lune)
            m_auto = new Auto();
            m_lune = new Lune();

            // les 3 membres List à initialiser 
            m_lstCiel = new List<Color>();
            m_lstAuto = new List<Auto>();
            m_lstLune = new List<Lune>();
        }

        // MÉTHOODE DE DESSIN 
        // (il faut avoir créé les classes des fichiers Auto.cs et Lune.cs)
        // à décommenter lorsque m_auto et m_lune seront déclarées et initialisées
        private void DessineAuto()
        {
            Color couleurAuto = m_auto.m_couleurAuto;
            Color couleurRoue = m_auto.m_couleurRoue;
            SolidBrush auto = new SolidBrush(couleurAuto);
            Pen roue = new Pen(couleurRoue, 4);
            m_gPanPhoto.FillRectangle(auto, 75, 90, 100, 30);
            m_gPanPhoto.FillRectangle(auto, 100, 75, 40, 40);
            m_gPanPhoto.DrawEllipse(roue, 90, 110, 20, 20);
            m_gPanPhoto.DrawEllipse(roue, 140, 110, 20, 20);
        }
        private void DessineLune()
        {
            Color couleurLune = m_lune.m_couleur;
            int diametreLune = m_lune.getDiametreLune();
            SolidBrush lunaire = new SolidBrush(couleurLune);
            m_gPanPhoto.FillEllipse(lunaire, 250, 20, diametreLune, diametreLune);
        }
        
        // il faut avoir créé les classes des fichiers Auto.cs et Lune.cs
        private void DessineAuto(Auto automobile)
        {
            Color couleurAuto = automobile.m_couleurAuto;
            Color couleurRoue = automobile.m_couleurRoue;
            SolidBrush auto = new SolidBrush(couleurAuto);
            Pen roue = new Pen(couleurRoue, 4);
            m_gPanPhoto.FillRectangle(auto, 75, 90, 100, 30);
            m_gPanPhoto.FillRectangle(auto, 100, 75, 40, 40);
            m_gPanPhoto.DrawEllipse(roue, 90, 110, 20, 20);
            m_gPanPhoto.DrawEllipse(roue, 140, 110, 20, 20);
        }
        private void DessineLune(Lune lune)
        {
            Color couleurLune = lune.m_couleur;
            int diametreLune = lune.getDiametreLune();
            SolidBrush lunaire = new SolidBrush(couleurLune);
            m_gPanPhoto.FillEllipse(lunaire, 250, 20, diametreLune, diametreLune);
        }
        
        private void btnEnregistreChoix_Click(object sender, EventArgs e)
        {
            // déclarations des variables locales de type Auto et Lune pour l'album
            Auto auto;
            Lune lune;

            // récupération des choix des comboBox
            string couleurAuto = cbxCouleurAuto.SelectedItem.ToString();
            string couleurRoue = cbxCouleurRoue.SelectedItem.ToString();
            string couleurLune = cbxCouleurLune.SelectedItem.ToString();
            int diametreLune = Convert.ToInt32(cbxDiametreLune.SelectedItem);

            // affectation de m_ciel dépendant des radioButton
            if (rbCielNoir.Checked)
            {
                m_ciel = Color.Black;
            }
            else
            {
                m_ciel = Color.Navy;
            }

            // affectation des membres de m_auto pour afficher la photo actuelle
            m_auto.m_couleurAuto = Color.FromName(couleurAuto);
            m_auto.m_couleurRoue = Color.FromName(couleurRoue);

            // affectation des membres de m_lune pour afficher la photo actuelle
            m_lune.m_couleur = Color.FromName(couleurLune);
            m_lune.setDiametreLune(diametreLune);

            // POUR AFFICHER L'ALBUM ---------
            // Ajout dans les listes de la couleur du ciel,  d'un nouvel auto et d'une nouvelle lune 
            m_lstCiel.Add(m_ciel);
            auto = new Auto(couleurAuto, couleurRoue);
            m_lstAuto.Add(auto);
            lune = new Lune(couleurLune, diametreLune);
            m_lstLune.Add(lune);

            // -------------------------------
            // gestion des boutons
            btnEnregistreChoix.Enabled = false;
            btnAffiche.Enabled = true;
            btnAfficheAlbum.Enabled = true;
        }

        private void btnAffiche_Click(object sender, EventArgs e)
        {
            btnEnregistreChoix.Enabled = true;
            btnAffiche.Enabled = false;

            // Affichage de la photo actuelle avec les membres
            // la photo est constituée d'un auto, d'une lune et d'un ciel
            m_gPanPhoto.Clear(m_ciel);
            DessineAuto();
            DessineLune();
        }
        
        private void btnAfficheAlbum_Click(object sender, EventArgs e)
        {
            btnEnregistreChoix.Enabled = true;
            btnAffiche.Enabled = false;

            // Boucle affichant les photos enregistrées à laide de listes
            for (int photoCourante = 0; photoCourante < m_lstAuto.Count; photoCourante++)
            {
                m_gPanPhoto.Clear(m_lstCiel[photoCourante]);
                DessineAuto(m_lstAuto[photoCourante]);
                DessineLune(m_lstLune[photoCourante]);
                Thread.Sleep(1000);
            }
        }
    }
}
