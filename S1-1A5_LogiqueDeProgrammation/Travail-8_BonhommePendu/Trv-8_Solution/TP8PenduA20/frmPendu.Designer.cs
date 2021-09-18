namespace TP8Pendu
{
    partial class frmPendu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuNouvellePartie = new System.Windows.Forms.ToolStripMenuItem();
            this.panJeu = new System.Windows.Forms.Panel();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEssai = new System.Windows.Forms.Button();
            this.txtLettre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreEssais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreLettres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLettresDejaEssayees = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMotATrouver = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panDessin = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panJeu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gold;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNouvellePartie});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuNouvellePartie
            // 
            this.mnuNouvellePartie.Name = "mnuNouvellePartie";
            this.mnuNouvellePartie.Size = new System.Drawing.Size(123, 26);
            this.mnuNouvellePartie.Text = "Nouvelle Partie";
            this.mnuNouvellePartie.Click += new System.EventHandler(this.mnuNouvellePartie_Click);
            // 
            // panJeu
            // 
            this.panJeu.Controls.Add(this.txtMessage);
            this.panJeu.Controls.Add(this.label6);
            this.panJeu.Controls.Add(this.btnEssai);
            this.panJeu.Controls.Add(this.txtLettre);
            this.panJeu.Controls.Add(this.label5);
            this.panJeu.Controls.Add(this.txtNombreEssais);
            this.panJeu.Controls.Add(this.label4);
            this.panJeu.Controls.Add(this.txtNombreLettres);
            this.panJeu.Controls.Add(this.label3);
            this.panJeu.Controls.Add(this.txtLettresDejaEssayees);
            this.panJeu.Controls.Add(this.label2);
            this.panJeu.Controls.Add(this.txtMotATrouver);
            this.panJeu.Controls.Add(this.label1);
            this.panJeu.Location = new System.Drawing.Point(9, 30);
            this.panJeu.Margin = new System.Windows.Forms.Padding(4);
            this.panJeu.Name = "panJeu";
            this.panJeu.Size = new System.Drawing.Size(459, 325);
            this.panJeu.TabIndex = 1;
            this.panJeu.Visible = false;
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMessage.Location = new System.Drawing.Point(25, 272);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(388, 22);
            this.txtMessage.TabIndex = 12;
            this.txtMessage.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Message";
            // 
            // btnEssai
            // 
            this.btnEssai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEssai.Location = new System.Drawing.Point(153, 183);
            this.btnEssai.Margin = new System.Windows.Forms.Padding(4);
            this.btnEssai.Name = "btnEssai";
            this.btnEssai.Size = new System.Drawing.Size(100, 44);
            this.btnEssai.TabIndex = 10;
            this.btnEssai.Text = "Essai";
            this.btnEssai.UseVisualStyleBackColor = false;
            this.btnEssai.Click += new System.EventHandler(this.btnEssai_Click);
            // 
            // txtLettre
            // 
            this.txtLettre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtLettre.Location = new System.Drawing.Point(25, 203);
            this.txtLettre.Margin = new System.Windows.Forms.Padding(4);
            this.txtLettre.Name = "txtLettre";
            this.txtLettre.Size = new System.Drawing.Size(37, 22);
            this.txtLettre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lettre";
            // 
            // txtNombreEssais
            // 
            this.txtNombreEssais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNombreEssais.Location = new System.Drawing.Point(339, 122);
            this.txtNombreEssais.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEssais.Name = "txtNombreEssais";
            this.txtNombreEssais.ReadOnly = true;
            this.txtNombreEssais.Size = new System.Drawing.Size(37, 22);
            this.txtNombreEssais.TabIndex = 7;
            this.txtNombreEssais.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre d\'essais";
            // 
            // txtNombreLettres
            // 
            this.txtNombreLettres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNombreLettres.Location = new System.Drawing.Point(339, 48);
            this.txtNombreLettres.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreLettres.Name = "txtNombreLettres";
            this.txtNombreLettres.ReadOnly = true;
            this.txtNombreLettres.Size = new System.Drawing.Size(37, 22);
            this.txtNombreLettres.TabIndex = 5;
            this.txtNombreLettres.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de Lettres";
            // 
            // txtLettresDejaEssayees
            // 
            this.txtLettresDejaEssayees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtLettresDejaEssayees.Location = new System.Drawing.Point(25, 122);
            this.txtLettresDejaEssayees.Margin = new System.Windows.Forms.Padding(4);
            this.txtLettresDejaEssayees.Name = "txtLettresDejaEssayees";
            this.txtLettresDejaEssayees.ReadOnly = true;
            this.txtLettresDejaEssayees.Size = new System.Drawing.Size(227, 22);
            this.txtLettresDejaEssayees.TabIndex = 3;
            this.txtLettresDejaEssayees.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lettres déjà essayées";
            // 
            // txtMotATrouver
            // 
            this.txtMotATrouver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMotATrouver.Location = new System.Drawing.Point(25, 48);
            this.txtMotATrouver.Margin = new System.Windows.Forms.Padding(4);
            this.txtMotATrouver.Name = "txtMotATrouver";
            this.txtMotATrouver.ReadOnly = true;
            this.txtMotATrouver.Size = new System.Drawing.Size(227, 22);
            this.txtMotATrouver.TabIndex = 1;
            this.txtMotATrouver.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot à trouver";
            // 
            // panDessin
            // 
            this.panDessin.BackColor = System.Drawing.Color.Orange;
            this.panDessin.Location = new System.Drawing.Point(469, 30);
            this.panDessin.Margin = new System.Windows.Forms.Padding(4);
            this.panDessin.Name = "panDessin";
            this.panDessin.Size = new System.Drawing.Size(171, 325);
            this.panDessin.TabIndex = 2;
            // 
            // frmPendu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(640, 382);
            this.Controls.Add(this.panDessin);
            this.Controls.Add(this.panJeu);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPendu";
            this.Text = "Bonhomme Pendu par: Jérémie Normand";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmTP9Pendu_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panJeu.ResumeLayout(false);
            this.panJeu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuNouvellePartie;
        private System.Windows.Forms.Panel panJeu;
        private System.Windows.Forms.Panel panDessin;
        private System.Windows.Forms.TextBox txtNombreLettres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLettresDejaEssayees;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMotATrouver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLettre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreEssais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEssai;
    }
}

