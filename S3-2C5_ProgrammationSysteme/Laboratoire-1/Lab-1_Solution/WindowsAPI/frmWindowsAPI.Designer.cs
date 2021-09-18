
namespace WindowsAPI
{
    partial class frmWindowsAPI
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
            this.tblBoutons = new System.Windows.Forms.TableLayoutPanel();
            this.btnExecuterBlocNote = new System.Windows.Forms.Button();
            this.btnAfficherFicherAttributs = new System.Windows.Forms.Button();
            this.btnFaireBeepWindows = new System.Windows.Forms.Button();
            this.btnAfficherSalutation = new System.Windows.Forms.Button();
            this.tblBoutons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblBoutons
            // 
            this.tblBoutons.ColumnCount = 1;
            this.tblBoutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblBoutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblBoutons.Controls.Add(this.btnExecuterBlocNote, 0, 3);
            this.tblBoutons.Controls.Add(this.btnAfficherFicherAttributs, 0, 2);
            this.tblBoutons.Controls.Add(this.btnFaireBeepWindows, 0, 1);
            this.tblBoutons.Controls.Add(this.btnAfficherSalutation, 0, 0);
            this.tblBoutons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBoutons.Location = new System.Drawing.Point(0, 0);
            this.tblBoutons.Name = "tblBoutons";
            this.tblBoutons.RowCount = 4;
            this.tblBoutons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBoutons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBoutons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBoutons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBoutons.Size = new System.Drawing.Size(516, 332);
            this.tblBoutons.TabIndex = 0;
            // 
            // btnExecuterBlocNote
            // 
            this.btnExecuterBlocNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExecuterBlocNote.Location = new System.Drawing.Point(10, 259);
            this.btnExecuterBlocNote.Margin = new System.Windows.Forms.Padding(10);
            this.btnExecuterBlocNote.Name = "btnExecuterBlocNote";
            this.btnExecuterBlocNote.Size = new System.Drawing.Size(496, 63);
            this.btnExecuterBlocNote.TabIndex = 4;
            this.btnExecuterBlocNote.Text = "Ouvrir le bloc-notes";
            this.btnExecuterBlocNote.UseVisualStyleBackColor = true;
            this.btnExecuterBlocNote.Click += new System.EventHandler(this.btnExecuterBlocNote_Click);
            // 
            // btnAfficherFicherAttributs
            // 
            this.btnAfficherFicherAttributs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAfficherFicherAttributs.Location = new System.Drawing.Point(10, 176);
            this.btnAfficherFicherAttributs.Margin = new System.Windows.Forms.Padding(10);
            this.btnAfficherFicherAttributs.Name = "btnAfficherFicherAttributs";
            this.btnAfficherFicherAttributs.Size = new System.Drawing.Size(496, 63);
            this.btnAfficherFicherAttributs.TabIndex = 3;
            this.btnAfficherFicherAttributs.Text = "Attributs de fichier";
            this.btnAfficherFicherAttributs.UseVisualStyleBackColor = true;
            this.btnAfficherFicherAttributs.Click += new System.EventHandler(this.btnAfficherFicherAttributs_Click);
            // 
            // btnFaireBeepWindows
            // 
            this.btnFaireBeepWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFaireBeepWindows.Location = new System.Drawing.Point(10, 93);
            this.btnFaireBeepWindows.Margin = new System.Windows.Forms.Padding(10);
            this.btnFaireBeepWindows.Name = "btnFaireBeepWindows";
            this.btnFaireBeepWindows.Size = new System.Drawing.Size(496, 63);
            this.btnFaireBeepWindows.TabIndex = 2;
            this.btnFaireBeepWindows.Text = "Beep Windows";
            this.btnFaireBeepWindows.UseVisualStyleBackColor = true;
            this.btnFaireBeepWindows.Click += new System.EventHandler(this.btnFaireBeepWindows_Click);
            // 
            // btnAfficherSalutation
            // 
            this.btnAfficherSalutation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAfficherSalutation.Location = new System.Drawing.Point(10, 10);
            this.btnAfficherSalutation.Margin = new System.Windows.Forms.Padding(10);
            this.btnAfficherSalutation.Name = "btnAfficherSalutation";
            this.btnAfficherSalutation.Size = new System.Drawing.Size(496, 63);
            this.btnAfficherSalutation.TabIndex = 1;
            this.btnAfficherSalutation.Text = "Salutation";
            this.btnAfficherSalutation.UseVisualStyleBackColor = true;
            this.btnAfficherSalutation.Click += new System.EventHandler(this.btnAfficherSalutation_Click);
            // 
            // frmWindowsAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 332);
            this.Controls.Add(this.tblBoutons);
            this.Name = "frmWindowsAPI";
            this.Text = "Essai de l\'interface de programmation d\'application (API) Windows - Jérémie Norma" +
    "nd";
            this.tblBoutons.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TableLayoutPanel tblBoutons;
        private System.Windows.Forms.Button btnExecuterBlocNote;
        private System.Windows.Forms.Button btnAfficherFicherAttributs;
        private System.Windows.Forms.Button btnFaireBeepWindows;
        private System.Windows.Forms.Button btnAfficherSalutation;
    }
}

