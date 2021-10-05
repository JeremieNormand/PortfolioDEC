namespace Tigre
{
    partial class frmTigre
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
            this.btnMange = new System.Windows.Forms.Button();
            this.picTigre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picTigre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMange
            // 
            this.btnMange.BackColor = System.Drawing.Color.OrangeRed;
            this.btnMange.Location = new System.Drawing.Point(150, 215);
            this.btnMange.Name = "btnMange";
            this.btnMange.Size = new System.Drawing.Size(75, 23);
            this.btnMange.TabIndex = 0;
            this.btnMange.Text = "Mange";
            this.btnMange.UseVisualStyleBackColor = false;
            this.btnMange.Click += new System.EventHandler(this.btnMange_Click);
            // 
            // picTigre
            // 
            this.picTigre.Image = global::Tigre.Properties.Resources.tigre;
            this.picTigre.Location = new System.Drawing.Point(63, 151);
            this.picTigre.Name = "picTigre";
            this.picTigre.Size = new System.Drawing.Size(309, 155);
            this.picTigre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTigre.TabIndex = 1;
            this.picTigre.TabStop = false;
            // 
            // frmTigre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(479, 438);
            this.Controls.Add(this.btnMange);
            this.Controls.Add(this.picTigre);
            this.Name = "frmTigre";
            this.Text = "La gourmandise, c\'est dangereux...";
            ((System.ComponentModel.ISupportInitialize)(this.picTigre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMange;
        private System.Windows.Forms.PictureBox picTigre;
    }
}

