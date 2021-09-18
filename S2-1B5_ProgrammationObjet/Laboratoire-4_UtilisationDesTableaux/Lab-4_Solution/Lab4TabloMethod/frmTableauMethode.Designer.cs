namespace Lab4TabloMethod
{
    partial class frmTableauMethode
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVendeurs = new System.Windows.Forms.Button();
            this.btnAfficheTotalParTrimestres = new System.Windows.Forms.Button();
            this.btnVentesParVendeurs = new System.Windows.Forms.Button();
            this.btnAfficheVenteDuVendeur = new System.Windows.Forms.Button();
            this.btnFaireToutesDemandes = new System.Windows.Forms.Button();
            this.cbVendeurs = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnVendeurs
            // 
            this.btnVendeurs.Location = new System.Drawing.Point(37, 34);
            this.btnVendeurs.Name = "btnVendeurs";
            this.btnVendeurs.Size = new System.Drawing.Size(480, 32);
            this.btnVendeurs.TabIndex = 0;
            this.btnVendeurs.Text = "Afficher les vendeurs";
            this.btnVendeurs.UseVisualStyleBackColor = true;
            this.btnVendeurs.Click += new System.EventHandler(this.btnVendeurs_Click);
            // 
            // btnAfficheTotalParTrimestres
            // 
            this.btnAfficheTotalParTrimestres.Location = new System.Drawing.Point(38, 129);
            this.btnAfficheTotalParTrimestres.Name = "btnAfficheTotalParTrimestres";
            this.btnAfficheTotalParTrimestres.Size = new System.Drawing.Size(479, 33);
            this.btnAfficheTotalParTrimestres.TabIndex = 1;
            this.btnAfficheTotalParTrimestres.Text = "Afficher les ventes totales par trimestre";
            this.btnAfficheTotalParTrimestres.UseVisualStyleBackColor = true;
            this.btnAfficheTotalParTrimestres.Click += new System.EventHandler(this.btnAfficheTotalParTrimestres_Click);
            // 
            // btnVentesParVendeurs
            // 
            this.btnVentesParVendeurs.Location = new System.Drawing.Point(38, 79);
            this.btnVentesParVendeurs.Name = "btnVentesParVendeurs";
            this.btnVentesParVendeurs.Size = new System.Drawing.Size(479, 33);
            this.btnVentesParVendeurs.TabIndex = 2;
            this.btnVentesParVendeurs.Text = "Afficher les ventes par vendeur";
            this.btnVentesParVendeurs.UseVisualStyleBackColor = true;
            this.btnVentesParVendeurs.Click += new System.EventHandler(this.btnVentesParVendeurs_Click);
            // 
            // btnAfficheVenteDuVendeur
            // 
            this.btnAfficheVenteDuVendeur.Location = new System.Drawing.Point(38, 182);
            this.btnAfficheVenteDuVendeur.Name = "btnAfficheVenteDuVendeur";
            this.btnAfficheVenteDuVendeur.Size = new System.Drawing.Size(338, 33);
            this.btnAfficheVenteDuVendeur.TabIndex = 3;
            this.btnAfficheVenteDuVendeur.Text = "Afficher La Vente Totale Du Vendeur";
            this.btnAfficheVenteDuVendeur.UseVisualStyleBackColor = true;
            this.btnAfficheVenteDuVendeur.Click += new System.EventHandler(this.btnAfficheVenteDuVendeur_Click);
            // 
            // btnFaireToutesDemandes
            // 
            this.btnFaireToutesDemandes.Location = new System.Drawing.Point(38, 252);
            this.btnFaireToutesDemandes.Name = "btnFaireToutesDemandes";
            this.btnFaireToutesDemandes.Size = new System.Drawing.Size(479, 33);
            this.btnFaireToutesDemandes.TabIndex = 4;
            this.btnFaireToutesDemandes.Text = "Faire toutes les demandes";
            this.btnFaireToutesDemandes.UseVisualStyleBackColor = true;
            this.btnFaireToutesDemandes.Click += new System.EventHandler(this.btnFaireDemandes_Click);
            // 
            // cbVendeurs
            // 
            this.cbVendeurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendeurs.FormattingEnabled = true;
            this.cbVendeurs.Items.AddRange(new object[] {
            "Samuel",
            "Roger",
            "Josée",
            "Serge",
            "Yvan",
            "Julie",
            "Mélissa"});
            this.cbVendeurs.Location = new System.Drawing.Point(396, 185);
            this.cbVendeurs.Name = "cbVendeurs";
            this.cbVendeurs.Size = new System.Drawing.Size(121, 28);
            this.cbVendeurs.TabIndex = 5;
            // 
            // frmTableauMethode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 324);
            this.Controls.Add(this.cbVendeurs);
            this.Controls.Add(this.btnFaireToutesDemandes);
            this.Controls.Add(this.btnAfficheVenteDuVendeur);
            this.Controls.Add(this.btnVentesParVendeurs);
            this.Controls.Add(this.btnAfficheTotalParTrimestres);
            this.Controls.Add(this.btnVendeurs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmTableauMethode";
            this.Text = "Tableaux et Introduction aux Méthodes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVendeurs;
        private System.Windows.Forms.Button btnAfficheTotalParTrimestres;
        private System.Windows.Forms.Button btnVentesParVendeurs;
        private System.Windows.Forms.Button btnAfficheVenteDuVendeur;
        private System.Windows.Forms.Button btnFaireToutesDemandes;
        private System.Windows.Forms.ComboBox cbVendeurs;
    }
}

