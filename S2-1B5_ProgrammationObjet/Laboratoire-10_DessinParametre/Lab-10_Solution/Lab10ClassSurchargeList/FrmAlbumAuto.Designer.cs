namespace Lab10ClassSurchargeList
{
    partial class FrmAlbumAuto
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnregistreChoix = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panPhoto = new System.Windows.Forms.Panel();
            this.cbxDiametreLune = new System.Windows.Forms.ComboBox();
            this.btnAffiche = new System.Windows.Forms.Button();
            this.cbxCouleurLune = new System.Windows.Forms.ComboBox();
            this.cbxCouleurAuto = new System.Windows.Forms.ComboBox();
            this.cbxCouleurRoue = new System.Windows.Forms.ComboBox();
            this.btnAfficheAlbum = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCielBleu = new System.Windows.Forms.RadioButton();
            this.rbCielNoir = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Lune: ";
            // 
            // btnEnregistreChoix
            // 
            this.btnEnregistreChoix.Location = new System.Drawing.Point(487, 20);
            this.btnEnregistreChoix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnregistreChoix.Name = "btnEnregistreChoix";
            this.btnEnregistreChoix.Size = new System.Drawing.Size(108, 68);
            this.btnEnregistreChoix.TabIndex = 17;
            this.btnEnregistreChoix.Text = "Photographier";
            this.btnEnregistreChoix.UseVisualStyleBackColor = true;
            this.btnEnregistreChoix.Click += new System.EventHandler(this.btnEnregistreChoix_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Auto: ";
            // 
            // panPhoto
            // 
            this.panPhoto.Location = new System.Drawing.Point(131, 121);
            this.panPhoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panPhoto.Name = "panPhoto";
            this.panPhoto.Size = new System.Drawing.Size(465, 213);
            this.panPhoto.TabIndex = 16;
            // 
            // cbxDiametreLune
            // 
            this.cbxDiametreLune.AutoCompleteCustomSource.AddRange(new string[] {
            "20",
            "50",
            "100"});
            this.cbxDiametreLune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDiametreLune.FormattingEnabled = true;
            this.cbxDiametreLune.Items.AddRange(new object[] {
            "20",
            "40",
            "80"});
            this.cbxDiametreLune.Location = new System.Drawing.Point(300, 20);
            this.cbxDiametreLune.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxDiametreLune.Name = "cbxDiametreLune";
            this.cbxDiametreLune.Size = new System.Drawing.Size(160, 24);
            this.cbxDiametreLune.TabIndex = 12;
            // 
            // btnAffiche
            // 
            this.btnAffiche.Location = new System.Drawing.Point(47, 356);
            this.btnAffiche.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAffiche.Name = "btnAffiche";
            this.btnAffiche.Size = new System.Drawing.Size(267, 55);
            this.btnAffiche.TabIndex = 15;
            this.btnAffiche.Text = "Afficher la photo actuelle";
            this.btnAffiche.UseVisualStyleBackColor = true;
            this.btnAffiche.Click += new System.EventHandler(this.btnAffiche_Click);
            // 
            // cbxCouleurLune
            // 
            this.cbxCouleurLune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCouleurLune.FormattingEnabled = true;
            this.cbxCouleurLune.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "White"});
            this.cbxCouleurLune.Location = new System.Drawing.Point(131, 20);
            this.cbxCouleurLune.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCouleurLune.Name = "cbxCouleurLune";
            this.cbxCouleurLune.Size = new System.Drawing.Size(160, 24);
            this.cbxCouleurLune.TabIndex = 11;
            // 
            // cbxCouleurAuto
            // 
            this.cbxCouleurAuto.AutoCompleteCustomSource.AddRange(new string[] {
            "Red",
            "Blue",
            "Black"});
            this.cbxCouleurAuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCouleurAuto.FormattingEnabled = true;
            this.cbxCouleurAuto.Items.AddRange(new object[] {
            "Gold",
            "Red",
            "Green"});
            this.cbxCouleurAuto.Location = new System.Drawing.Point(131, 63);
            this.cbxCouleurAuto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCouleurAuto.Name = "cbxCouleurAuto";
            this.cbxCouleurAuto.Size = new System.Drawing.Size(160, 24);
            this.cbxCouleurAuto.TabIndex = 13;
            // 
            // cbxCouleurRoue
            // 
            this.cbxCouleurRoue.AutoCompleteCustomSource.AddRange(new string[] {
            "Petite",
            "Moyenne",
            "Grosse"});
            this.cbxCouleurRoue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCouleurRoue.FormattingEnabled = true;
            this.cbxCouleurRoue.Items.AddRange(new object[] {
            "Green",
            "Brown",
            "Yellow"});
            this.cbxCouleurRoue.Location = new System.Drawing.Point(300, 63);
            this.cbxCouleurRoue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCouleurRoue.Name = "cbxCouleurRoue";
            this.cbxCouleurRoue.Size = new System.Drawing.Size(160, 24);
            this.cbxCouleurRoue.TabIndex = 14;
            // 
            // btnAfficheAlbum
            // 
            this.btnAfficheAlbum.Location = new System.Drawing.Point(328, 356);
            this.btnAfficheAlbum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAfficheAlbum.Name = "btnAfficheAlbum";
            this.btnAfficheAlbum.Size = new System.Drawing.Size(267, 55);
            this.btnAfficheAlbum.TabIndex = 18;
            this.btnAfficheAlbum.Text = "Afficher l\'album";
            this.btnAfficheAlbum.UseVisualStyleBackColor = true;
            this.btnAfficheAlbum.Click += new System.EventHandler(this.btnAfficheAlbum_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbCielBleu);
            this.groupBox1.Controls.Add(this.rbCielNoir);
            this.groupBox1.Location = new System.Drawing.Point(47, 113);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(76, 102);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ciel";
            // 
            // rbCielBleu
            // 
            this.rbCielBleu.AutoSize = true;
            this.rbCielBleu.Location = new System.Drawing.Point(9, 53);
            this.rbCielBleu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCielBleu.Name = "rbCielBleu";
            this.rbCielBleu.Size = new System.Drawing.Size(57, 21);
            this.rbCielBleu.TabIndex = 1;
            this.rbCielBleu.Text = "Bleu";
            this.rbCielBleu.UseVisualStyleBackColor = true;
            // 
            // rbCielNoir
            // 
            this.rbCielNoir.AutoSize = true;
            this.rbCielNoir.Checked = true;
            this.rbCielNoir.Location = new System.Drawing.Point(9, 25);
            this.rbCielNoir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbCielNoir.Name = "rbCielNoir";
            this.rbCielNoir.Size = new System.Drawing.Size(55, 21);
            this.rbCielNoir.TabIndex = 0;
            this.rbCielNoir.TabStop = true;
            this.rbCielNoir.Text = "Noir";
            this.rbCielNoir.UseVisualStyleBackColor = true;
            // 
            // FrmAlbumAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAfficheAlbum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnregistreChoix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panPhoto);
            this.Controls.Add(this.cbxDiametreLune);
            this.Controls.Add(this.btnAffiche);
            this.Controls.Add(this.cbxCouleurLune);
            this.Controls.Add(this.cbxCouleurAuto);
            this.Controls.Add(this.cbxCouleurRoue);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAlbumAuto";
            this.Text = "Album d\'auto - Jérémie Normand";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnregistreChoix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panPhoto;
        private System.Windows.Forms.ComboBox cbxDiametreLune;
        private System.Windows.Forms.Button btnAffiche;
        private System.Windows.Forms.ComboBox cbxCouleurLune;
        private System.Windows.Forms.ComboBox cbxCouleurAuto;
        private System.Windows.Forms.ComboBox cbxCouleurRoue;
        private System.Windows.Forms.Button btnAfficheAlbum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbCielBleu;
        private System.Windows.Forms.RadioButton rbCielNoir;
    }
}

