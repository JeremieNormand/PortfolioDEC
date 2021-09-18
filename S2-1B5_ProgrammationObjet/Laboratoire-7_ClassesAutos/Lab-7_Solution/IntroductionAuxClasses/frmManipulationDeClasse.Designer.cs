
namespace IntroductionAuxClasses
{
    partial class frmManipulationDeClasse
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
            this.btnInstanciationDeuxAutos = new System.Windows.Forms.Button();
            this.btnAfficherInformationsInstances = new System.Windows.Forms.Button();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblAnnee = new System.Windows.Forms.Label();
            this.txtMarque = new System.Windows.Forms.TextBox();
            this.txtCouleur = new System.Windows.Forms.TextBox();
            this.txtAnnee = new System.Windows.Forms.TextBox();
            this.btnChangerProprietesAuto2 = new System.Windows.Forms.Button();
            this.tlyPrimaire = new System.Windows.Forms.TableLayoutPanel();
            this.tlySecondaire1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCouleurs = new System.Windows.Forms.Label();
            this.tlyPrimaire.SuspendLayout();
            this.tlySecondaire1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInstanciationDeuxAutos
            // 
            this.btnInstanciationDeuxAutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInstanciationDeuxAutos.Location = new System.Drawing.Point(63, 52);
            this.btnInstanciationDeuxAutos.Name = "btnInstanciationDeuxAutos";
            this.btnInstanciationDeuxAutos.Size = new System.Drawing.Size(295, 241);
            this.btnInstanciationDeuxAutos.TabIndex = 0;
            this.btnInstanciationDeuxAutos.Text = "Instancier deux objets de la classe Auto";
            this.btnInstanciationDeuxAutos.UseVisualStyleBackColor = true;
            this.btnInstanciationDeuxAutos.Click += new System.EventHandler(this.btnInstanciationDeuxAutos_Click);
            // 
            // btnAfficherInformationsInstances
            // 
            this.btnAfficherInformationsInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAfficherInformationsInstances.Location = new System.Drawing.Point(424, 52);
            this.btnAfficherInformationsInstances.Name = "btnAfficherInformationsInstances";
            this.btnAfficherInformationsInstances.Size = new System.Drawing.Size(295, 241);
            this.btnAfficherInformationsInstances.TabIndex = 1;
            this.btnAfficherInformationsInstances.Text = "Afficher les informations des deux instances";
            this.btnAfficherInformationsInstances.UseVisualStyleBackColor = true;
            this.btnAfficherInformationsInstances.Click += new System.EventHandler(this.btnAfficherInformationsInstances_Click);
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMarque.Location = new System.Drawing.Point(3, 93);
            this.lblMarque.Margin = new System.Windows.Forms.Padding(3);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(128, 24);
            this.lblMarque.TabIndex = 2;
            this.lblMarque.Text = "Marque :";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCouleur.Location = new System.Drawing.Point(3, 153);
            this.lblCouleur.Margin = new System.Windows.Forms.Padding(3);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(128, 24);
            this.lblCouleur.TabIndex = 3;
            this.lblCouleur.Text = "Couleur :";
            this.lblCouleur.MouseLeave += new System.EventHandler(this.lblCouleur_MouseLeave);
            this.lblCouleur.MouseHover += new System.EventHandler(this.lblCouleur_MouseHover);
            // 
            // lblAnnee
            // 
            this.lblAnnee.AutoSize = true;
            this.lblAnnee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnnee.Location = new System.Drawing.Point(3, 213);
            this.lblAnnee.Margin = new System.Windows.Forms.Padding(3);
            this.lblAnnee.Name = "lblAnnee";
            this.lblAnnee.Size = new System.Drawing.Size(128, 25);
            this.lblAnnee.TabIndex = 4;
            this.lblAnnee.Text = "Année :";
            // 
            // txtMarque
            // 
            this.txtMarque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMarque.Location = new System.Drawing.Point(163, 93);
            this.txtMarque.Name = "txtMarque";
            this.txtMarque.Size = new System.Drawing.Size(129, 22);
            this.txtMarque.TabIndex = 5;
            this.txtMarque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCouleur
            // 
            this.txtCouleur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCouleur.Location = new System.Drawing.Point(163, 153);
            this.txtCouleur.Name = "txtCouleur";
            this.txtCouleur.Size = new System.Drawing.Size(129, 22);
            this.txtCouleur.TabIndex = 6;
            this.txtCouleur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAnnee
            // 
            this.txtAnnee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnnee.Location = new System.Drawing.Point(163, 213);
            this.txtAnnee.Name = "txtAnnee";
            this.txtAnnee.Size = new System.Drawing.Size(129, 22);
            this.txtAnnee.TabIndex = 7;
            this.txtAnnee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChangerProprietesAuto2
            // 
            this.tlySecondaire1.SetColumnSpan(this.btnChangerProprietesAuto2, 3);
            this.btnChangerProprietesAuto2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangerProprietesAuto2.Location = new System.Drawing.Point(3, 3);
            this.btnChangerProprietesAuto2.Name = "btnChangerProprietesAuto2";
            this.btnChangerProprietesAuto2.Size = new System.Drawing.Size(289, 54);
            this.btnChangerProprietesAuto2.TabIndex = 8;
            this.btnChangerProprietesAuto2.Text = "Changer les propriétés de la deuxième instance";
            this.btnChangerProprietesAuto2.UseVisualStyleBackColor = true;
            this.btnChangerProprietesAuto2.Click += new System.EventHandler(this.btnChangerProprietesAuto2_Click);
            // 
            // tlyPrimaire
            // 
            this.tlyPrimaire.ColumnCount = 7;
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.31579F));
            this.tlyPrimaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.263158F));
            this.tlyPrimaire.Controls.Add(this.tlySecondaire1, 5, 1);
            this.tlyPrimaire.Controls.Add(this.btnInstanciationDeuxAutos, 1, 1);
            this.tlyPrimaire.Controls.Add(this.btnAfficherInformationsInstances, 3, 1);
            this.tlyPrimaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlyPrimaire.Location = new System.Drawing.Point(0, 0);
            this.tlyPrimaire.Name = "tlyPrimaire";
            this.tlyPrimaire.RowCount = 3;
            this.tlyPrimaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlyPrimaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tlyPrimaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlyPrimaire.Size = new System.Drawing.Size(1146, 346);
            this.tlyPrimaire.TabIndex = 9;
            // 
            // tlySecondaire1
            // 
            this.tlySecondaire1.ColumnCount = 3;
            this.tlySecondaire1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tlySecondaire1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tlySecondaire1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tlySecondaire1.Controls.Add(this.btnChangerProprietesAuto2, 0, 0);
            this.tlySecondaire1.Controls.Add(this.lblAnnee, 0, 6);
            this.tlySecondaire1.Controls.Add(this.txtAnnee, 2, 6);
            this.tlySecondaire1.Controls.Add(this.lblMarque, 0, 2);
            this.tlySecondaire1.Controls.Add(this.txtCouleur, 2, 4);
            this.tlySecondaire1.Controls.Add(this.txtMarque, 2, 2);
            this.tlySecondaire1.Controls.Add(this.lblCouleur, 0, 4);
            this.tlySecondaire1.Controls.Add(this.lblCouleurs, 0, 5);
            this.tlySecondaire1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlySecondaire1.Location = new System.Drawing.Point(785, 52);
            this.tlySecondaire1.Name = "tlySecondaire1";
            this.tlySecondaire1.RowCount = 7;
            this.tlySecondaire1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlySecondaire1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlySecondaire1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlySecondaire1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlySecondaire1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlySecondaire1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlySecondaire1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlySecondaire1.Size = new System.Drawing.Size(295, 241);
            this.tlySecondaire1.TabIndex = 10;
            // 
            // lblCouleurs
            // 
            this.lblCouleurs.AutoSize = true;
            this.tlySecondaire1.SetColumnSpan(this.lblCouleurs, 3);
            this.lblCouleurs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCouleurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleurs.Location = new System.Drawing.Point(3, 180);
            this.lblCouleurs.Name = "lblCouleurs";
            this.lblCouleurs.Size = new System.Drawing.Size(289, 30);
            this.lblCouleurs.TabIndex = 9;
            this.lblCouleurs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmManipulationDeClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 346);
            this.Controls.Add(this.tlyPrimaire);
            this.Name = "frmManipulationDeClasse";
            this.Text = "Laboratoire 07 - Introduction aux Classes - Jérémie Normand";
            this.tlyPrimaire.ResumeLayout(false);
            this.tlySecondaire1.ResumeLayout(false);
            this.tlySecondaire1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInstanciationDeuxAutos;
        private System.Windows.Forms.Button btnAfficherInformationsInstances;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblAnnee;
        private System.Windows.Forms.TextBox txtMarque;
        private System.Windows.Forms.TextBox txtCouleur;
        private System.Windows.Forms.TextBox txtAnnee;
        private System.Windows.Forms.Button btnChangerProprietesAuto2;
        private System.Windows.Forms.TableLayoutPanel tlySecondaire1;
        private System.Windows.Forms.TableLayoutPanel tlyPrimaire;
        private System.Windows.Forms.Label lblCouleurs;
    }
}

