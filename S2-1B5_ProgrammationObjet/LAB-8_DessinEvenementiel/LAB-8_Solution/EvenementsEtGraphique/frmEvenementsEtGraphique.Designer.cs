
namespace EvenementsEtGraphique
{
    partial class frmEvenementsEtGraphique
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlyPrimaire = new System.Windows.Forms.TableLayoutPanel();
            this.tlyBoutonsSourisPresses = new System.Windows.Forms.TableLayoutPanel();
            this.lblBoutonsSourisPresses = new System.Windows.Forms.Label();
            this.cbClickGauche = new System.Windows.Forms.CheckBox();
            this.cbClickDroit = new System.Windows.Forms.CheckBox();
            this.tlyPositionSouris = new System.Windows.Forms.TableLayoutPanel();
            this.lblPositionX = new System.Windows.Forms.Label();
            this.lblPositionSouris = new System.Windows.Forms.Label();
            this.lblEtiquettePositionX = new System.Windows.Forms.Label();
            this.lblEtiquettePositionY = new System.Windows.Forms.Label();
            this.lblPositionY = new System.Windows.Forms.Label();
            this.tlyToucheClavierPressee = new System.Windows.Forms.TableLayoutPanel();
            this.lblToucheClavierPressee = new System.Windows.Forms.Label();
            this.lblEtiquetteToucheClavierPressee = new System.Windows.Forms.Label();
            this.tlyZoneGraphique = new System.Windows.Forms.TableLayoutPanel();
            this.lblZoneGraphique = new System.Windows.Forms.Label();
            this.btnInitialiserZoneGraphique = new System.Windows.Forms.Button();
            this.btnDessinerDixRonds = new System.Windows.Forms.Button();
            this.pnlZoneGraphique = new System.Windows.Forms.Panel();
            this.tlyPrimaire.SuspendLayout();
            this.tlyBoutonsSourisPresses.SuspendLayout();
            this.tlyPositionSouris.SuspendLayout();
            this.tlyToucheClavierPressee.SuspendLayout();
            this.tlyZoneGraphique.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlyPrimaire
            // 
            this.tlyPrimaire.ColumnCount = 5;
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlyPrimaire.Controls.Add(this.tlyBoutonsSourisPresses, 1, 1);
            this.tlyPrimaire.Controls.Add(this.tlyPositionSouris, 1, 4);
            this.tlyPrimaire.Controls.Add(this.tlyToucheClavierPressee, 1, 6);
            this.tlyPrimaire.Controls.Add(this.tlyZoneGraphique, 3, 1);
            this.tlyPrimaire.Controls.Add(this.pnlZoneGraphique, 3, 3);
            this.tlyPrimaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlyPrimaire.Location = new System.Drawing.Point(0, 0);
            this.tlyPrimaire.Name = "tlyPrimaire";
            this.tlyPrimaire.RowCount = 8;
            this.tlyPrimaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlyPrimaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlyPrimaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlyPrimaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlyPrimaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlyPrimaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlyPrimaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlyPrimaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlyPrimaire.Size = new System.Drawing.Size(1177, 526);
            this.tlyPrimaire.TabIndex = 0;
            this.tlyPrimaire.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlyPrimaire_MouseDown);
            this.tlyPrimaire.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tlyPrimaire_MouseUp);
            // 
            // tlyBoutonsSourisPresses
            // 
            this.tlyBoutonsSourisPresses.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tlyBoutonsSourisPresses.ColumnCount = 3;
            this.tlyBoutonsSourisPresses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlyBoutonsSourisPresses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlyBoutonsSourisPresses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlyBoutonsSourisPresses.Controls.Add(this.lblBoutonsSourisPresses, 0, 0);
            this.tlyBoutonsSourisPresses.Controls.Add(this.cbClickGauche, 0, 2);
            this.tlyBoutonsSourisPresses.Controls.Add(this.cbClickDroit, 2, 2);
            this.tlyBoutonsSourisPresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlyBoutonsSourisPresses.Location = new System.Drawing.Point(109, 55);
            this.tlyBoutonsSourisPresses.Name = "tlyBoutonsSourisPresses";
            this.tlyBoutonsSourisPresses.Padding = new System.Windows.Forms.Padding(10);
            this.tlyBoutonsSourisPresses.RowCount = 3;
            this.tlyPrimaire.SetRowSpan(this.tlyBoutonsSourisPresses, 2);
            this.tlyBoutonsSourisPresses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlyBoutonsSourisPresses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlyBoutonsSourisPresses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlyBoutonsSourisPresses.Size = new System.Drawing.Size(422, 98);
            this.tlyBoutonsSourisPresses.TabIndex = 0;
            // 
            // lblBoutonsSourisPresses
            // 
            this.lblBoutonsSourisPresses.AutoSize = true;
            this.tlyBoutonsSourisPresses.SetColumnSpan(this.lblBoutonsSourisPresses, 3);
            this.lblBoutonsSourisPresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBoutonsSourisPresses.Location = new System.Drawing.Point(13, 10);
            this.lblBoutonsSourisPresses.Name = "lblBoutonsSourisPresses";
            this.lblBoutonsSourisPresses.Size = new System.Drawing.Size(396, 26);
            this.lblBoutonsSourisPresses.TabIndex = 0;
            this.lblBoutonsSourisPresses.Text = "Bouton pressé de la souris sur le FORM";
            this.lblBoutonsSourisPresses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbClickGauche
            // 
            this.cbClickGauche.AutoSize = true;
            this.cbClickGauche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbClickGauche.Location = new System.Drawing.Point(13, 65);
            this.cbClickGauche.Name = "cbClickGauche";
            this.cbClickGauche.Size = new System.Drawing.Size(154, 20);
            this.cbClickGauche.TabIndex = 1;
            this.cbClickGauche.Text = "GAUCHE";
            this.cbClickGauche.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClickGauche.UseVisualStyleBackColor = true;
            // 
            // cbClickDroit
            // 
            this.cbClickDroit.AutoSize = true;
            this.cbClickDroit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbClickDroit.Location = new System.Drawing.Point(253, 65);
            this.cbClickDroit.Name = "cbClickDroit";
            this.cbClickDroit.Size = new System.Drawing.Size(156, 20);
            this.cbClickDroit.TabIndex = 2;
            this.cbClickDroit.Text = "DROIT";
            this.cbClickDroit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbClickDroit.UseVisualStyleBackColor = true;
            // 
            // tlyPositionSouris
            // 
            this.tlyPositionSouris.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tlyPositionSouris.ColumnCount = 5;
            this.tlyPositionSouris.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlyPositionSouris.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlyPositionSouris.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlyPositionSouris.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlyPositionSouris.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlyPositionSouris.Controls.Add(this.lblPositionX, 0, 2);
            this.tlyPositionSouris.Controls.Add(this.lblPositionSouris, 0, 0);
            this.tlyPositionSouris.Controls.Add(this.lblEtiquettePositionX, 0, 2);
            this.tlyPositionSouris.Controls.Add(this.lblEtiquettePositionY, 3, 2);
            this.tlyPositionSouris.Controls.Add(this.lblPositionY, 4, 2);
            this.tlyPositionSouris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlyPositionSouris.Location = new System.Drawing.Point(109, 211);
            this.tlyPositionSouris.Name = "tlyPositionSouris";
            this.tlyPositionSouris.Padding = new System.Windows.Forms.Padding(10);
            this.tlyPositionSouris.RowCount = 3;
            this.tlyPositionSouris.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlyPositionSouris.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlyPositionSouris.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlyPositionSouris.Size = new System.Drawing.Size(422, 99);
            this.tlyPositionSouris.TabIndex = 1;
            // 
            // lblPositionX
            // 
            this.lblPositionX.AutoSize = true;
            this.lblPositionX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPositionX.Location = new System.Drawing.Point(93, 62);
            this.lblPositionX.Name = "lblPositionX";
            this.lblPositionX.Size = new System.Drawing.Size(74, 27);
            this.lblPositionX.TabIndex = 3;
            this.lblPositionX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPositionSouris
            // 
            this.lblPositionSouris.AutoSize = true;
            this.tlyPositionSouris.SetColumnSpan(this.lblPositionSouris, 5);
            this.lblPositionSouris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPositionSouris.Location = new System.Drawing.Point(13, 10);
            this.lblPositionSouris.Name = "lblPositionSouris";
            this.lblPositionSouris.Size = new System.Drawing.Size(396, 26);
            this.lblPositionSouris.TabIndex = 1;
            this.lblPositionSouris.Text = "Position de la souris dans le PANEL";
            this.lblPositionSouris.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEtiquettePositionX
            // 
            this.lblEtiquettePositionX.AutoSize = true;
            this.lblEtiquettePositionX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEtiquettePositionX.Location = new System.Drawing.Point(13, 62);
            this.lblEtiquettePositionX.Name = "lblEtiquettePositionX";
            this.lblEtiquettePositionX.Size = new System.Drawing.Size(74, 27);
            this.lblEtiquettePositionX.TabIndex = 2;
            this.lblEtiquettePositionX.Text = "X";
            this.lblEtiquettePositionX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEtiquettePositionY
            // 
            this.lblEtiquettePositionY.AutoSize = true;
            this.lblEtiquettePositionY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEtiquettePositionY.Location = new System.Drawing.Point(253, 62);
            this.lblEtiquettePositionY.Name = "lblEtiquettePositionY";
            this.lblEtiquettePositionY.Size = new System.Drawing.Size(74, 27);
            this.lblEtiquettePositionY.TabIndex = 4;
            this.lblEtiquettePositionY.Text = "Y";
            this.lblEtiquettePositionY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPositionY
            // 
            this.lblPositionY.AutoSize = true;
            this.lblPositionY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPositionY.Location = new System.Drawing.Point(333, 62);
            this.lblPositionY.Name = "lblPositionY";
            this.lblPositionY.Size = new System.Drawing.Size(76, 27);
            this.lblPositionY.TabIndex = 5;
            this.lblPositionY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlyToucheClavierPressee
            // 
            this.tlyToucheClavierPressee.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tlyToucheClavierPressee.ColumnCount = 1;
            this.tlyToucheClavierPressee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlyToucheClavierPressee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlyToucheClavierPressee.Controls.Add(this.lblToucheClavierPressee, 0, 2);
            this.tlyToucheClavierPressee.Controls.Add(this.lblEtiquetteToucheClavierPressee, 0, 0);
            this.tlyToucheClavierPressee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlyToucheClavierPressee.Location = new System.Drawing.Point(109, 368);
            this.tlyToucheClavierPressee.Name = "tlyToucheClavierPressee";
            this.tlyToucheClavierPressee.Padding = new System.Windows.Forms.Padding(10);
            this.tlyToucheClavierPressee.RowCount = 3;
            this.tlyToucheClavierPressee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlyToucheClavierPressee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlyToucheClavierPressee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlyToucheClavierPressee.Size = new System.Drawing.Size(422, 99);
            this.tlyToucheClavierPressee.TabIndex = 2;
            // 
            // lblToucheClavierPressee
            // 
            this.lblToucheClavierPressee.AutoSize = true;
            this.lblToucheClavierPressee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToucheClavierPressee.Location = new System.Drawing.Point(13, 62);
            this.lblToucheClavierPressee.Name = "lblToucheClavierPressee";
            this.lblToucheClavierPressee.Size = new System.Drawing.Size(396, 27);
            this.lblToucheClavierPressee.TabIndex = 4;
            this.lblToucheClavierPressee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEtiquetteToucheClavierPressee
            // 
            this.lblEtiquetteToucheClavierPressee.AutoSize = true;
            this.lblEtiquetteToucheClavierPressee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEtiquetteToucheClavierPressee.Location = new System.Drawing.Point(13, 10);
            this.lblEtiquetteToucheClavierPressee.Name = "lblEtiquetteToucheClavierPressee";
            this.lblEtiquetteToucheClavierPressee.Size = new System.Drawing.Size(396, 26);
            this.lblEtiquetteToucheClavierPressee.TabIndex = 2;
            this.lblEtiquetteToucheClavierPressee.Text = "Touche du clavier pressé sur le FORM";
            this.lblEtiquetteToucheClavierPressee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlyZoneGraphique
            // 
            this.tlyZoneGraphique.ColumnCount = 5;
            this.tlyZoneGraphique.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.66667F));
            this.tlyZoneGraphique.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tlyZoneGraphique.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlyZoneGraphique.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tlyZoneGraphique.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlyZoneGraphique.Controls.Add(this.lblZoneGraphique, 0, 0);
            this.tlyZoneGraphique.Controls.Add(this.btnInitialiserZoneGraphique, 2, 0);
            this.tlyZoneGraphique.Controls.Add(this.btnDessinerDixRonds, 4, 0);
            this.tlyZoneGraphique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlyZoneGraphique.Location = new System.Drawing.Point(643, 55);
            this.tlyZoneGraphique.Name = "tlyZoneGraphique";
            this.tlyZoneGraphique.RowCount = 1;
            this.tlyZoneGraphique.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlyZoneGraphique.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tlyZoneGraphique.Size = new System.Drawing.Size(422, 46);
            this.tlyZoneGraphique.TabIndex = 3;
            // 
            // lblZoneGraphique
            // 
            this.lblZoneGraphique.AutoSize = true;
            this.lblZoneGraphique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblZoneGraphique.Location = new System.Drawing.Point(3, 0);
            this.lblZoneGraphique.Name = "lblZoneGraphique";
            this.lblZoneGraphique.Size = new System.Drawing.Size(190, 46);
            this.lblZoneGraphique.TabIndex = 1;
            this.lblZoneGraphique.Text = "Zone dessin du PANEL";
            this.lblZoneGraphique.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnInitialiserZoneGraphique
            // 
            this.btnInitialiserZoneGraphique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInitialiserZoneGraphique.Location = new System.Drawing.Point(227, 3);
            this.btnInitialiserZoneGraphique.Name = "btnInitialiserZoneGraphique";
            this.btnInitialiserZoneGraphique.Size = new System.Drawing.Size(78, 40);
            this.btnInitialiserZoneGraphique.TabIndex = 2;
            this.btnInitialiserZoneGraphique.Text = "Initialiser";
            this.btnInitialiserZoneGraphique.UseVisualStyleBackColor = true;
            this.btnInitialiserZoneGraphique.Click += new System.EventHandler(this.btnInitialiserZoneGraphique_Click);
            // 
            // btnDessinerDixRonds
            // 
            this.btnDessinerDixRonds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDessinerDixRonds.Location = new System.Drawing.Point(339, 3);
            this.btnDessinerDixRonds.Name = "btnDessinerDixRonds";
            this.btnDessinerDixRonds.Size = new System.Drawing.Size(80, 40);
            this.btnDessinerDixRonds.TabIndex = 3;
            this.btnDessinerDixRonds.Text = "10 Ronds";
            this.btnDessinerDixRonds.UseVisualStyleBackColor = true;
            this.btnDessinerDixRonds.Click += new System.EventHandler(this.btnDessinerDixRonds_Click);
            // 
            // pnlZoneGraphique
            // 
            this.pnlZoneGraphique.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlZoneGraphique.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlZoneGraphique.Location = new System.Drawing.Point(643, 159);
            this.pnlZoneGraphique.Name = "pnlZoneGraphique";
            this.tlyPrimaire.SetRowSpan(this.pnlZoneGraphique, 4);
            this.pnlZoneGraphique.Size = new System.Drawing.Size(422, 308);
            this.pnlZoneGraphique.TabIndex = 4;
            this.pnlZoneGraphique.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlZoneGraphique_MouseClick);
            this.pnlZoneGraphique.MouseLeave += new System.EventHandler(this.pnlZoneGraphique_MouseLeave);
            this.pnlZoneGraphique.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlZoneGraphique_MouseMove);
            // 
            // frmEvenementsEtGraphique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 526);
            this.Controls.Add(this.tlyPrimaire);
            this.KeyPreview = true;
            this.Name = "frmEvenementsEtGraphique";
            this.Text = "Laboratoire 08 - Événements et Graphique - Jérémie Normand";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEvenementsEtGraphique_KeyDown);
            this.tlyPrimaire.ResumeLayout(false);
            this.tlyBoutonsSourisPresses.ResumeLayout(false);
            this.tlyBoutonsSourisPresses.PerformLayout();
            this.tlyPositionSouris.ResumeLayout(false);
            this.tlyPositionSouris.PerformLayout();
            this.tlyToucheClavierPressee.ResumeLayout(false);
            this.tlyToucheClavierPressee.PerformLayout();
            this.tlyZoneGraphique.ResumeLayout(false);
            this.tlyZoneGraphique.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlyPrimaire;
        private System.Windows.Forms.TableLayoutPanel tlyBoutonsSourisPresses;
        private System.Windows.Forms.Label lblBoutonsSourisPresses;
        private System.Windows.Forms.CheckBox cbClickGauche;
        private System.Windows.Forms.CheckBox cbClickDroit;
        private System.Windows.Forms.TableLayoutPanel tlyPositionSouris;
        private System.Windows.Forms.Label lblPositionSouris;
        private System.Windows.Forms.Label lblEtiquettePositionX;
        private System.Windows.Forms.TableLayoutPanel tlyToucheClavierPressee;
        private System.Windows.Forms.Label lblEtiquetteToucheClavierPressee;
        private System.Windows.Forms.TableLayoutPanel tlyZoneGraphique;
        private System.Windows.Forms.Label lblZoneGraphique;
        private System.Windows.Forms.Label lblPositionX;
        private System.Windows.Forms.Label lblEtiquettePositionY;
        private System.Windows.Forms.Label lblPositionY;
        private System.Windows.Forms.Label lblToucheClavierPressee;
        private System.Windows.Forms.Button btnInitialiserZoneGraphique;
        private System.Windows.Forms.Button btnDessinerDixRonds;
        private System.Windows.Forms.Panel pnlZoneGraphique;
    }
}

