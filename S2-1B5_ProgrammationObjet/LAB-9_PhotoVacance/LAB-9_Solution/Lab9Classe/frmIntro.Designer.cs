namespace Lab9Classe
{
    partial class FrmIntro
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
            this.btnMembrePub = new System.Windows.Forms.Button();
            this.btnMembresPriv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMembrePub
            // 
            this.btnMembrePub.Location = new System.Drawing.Point(46, 37);
            this.btnMembrePub.Name = "btnMembrePub";
            this.btnMembrePub.Size = new System.Drawing.Size(180, 89);
            this.btnMembrePub.TabIndex = 0;
            this.btnMembrePub.Text = "Création de classes avec membres public";
            this.btnMembrePub.UseVisualStyleBackColor = true;
            this.btnMembrePub.Click += new System.EventHandler(this.btnMembrePub_Click);
            // 
            // btnMembresPriv
            // 
            this.btnMembresPriv.Location = new System.Drawing.Point(271, 37);
            this.btnMembresPriv.Name = "btnMembresPriv";
            this.btnMembresPriv.Size = new System.Drawing.Size(180, 89);
            this.btnMembresPriv.TabIndex = 1;
            this.btnMembresPriv.Text = "Création de classes avec membres private";
            this.btnMembresPriv.UseVisualStyleBackColor = true;
            this.btnMembresPriv.Click += new System.EventHandler(this.btnMembresPriv_Click);
            // 
            // FrmIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 188);
            this.Controls.Add(this.btnMembresPriv);
            this.Controls.Add(this.btnMembrePub);
            this.Name = "FrmIntro";
            this.Text = "FrmIntro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMembrePub;
        private System.Windows.Forms.Button btnMembresPriv;
    }
}

