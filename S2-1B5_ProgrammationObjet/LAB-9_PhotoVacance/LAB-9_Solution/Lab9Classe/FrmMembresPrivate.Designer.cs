namespace Lab9Classe
{
    partial class FrmMembresPrivate
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
            this.btnChoix = new System.Windows.Forms.Button();
            this.panPhoto = new System.Windows.Forms.Panel();
            this.btnAffiche = new System.Windows.Forms.Button();
            this.cbxCouleurRoue = new System.Windows.Forms.ComboBox();
            this.cbxCouleurAuto = new System.Windows.Forms.ComboBox();
            this.cbxRayonSoleil = new System.Windows.Forms.ComboBox();
            this.cbxCouleurSoleil = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChoix
            // 
            this.btnChoix.Location = new System.Drawing.Point(515, 46);
            this.btnChoix.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoix.Name = "btnChoix";
            this.btnChoix.Size = new System.Drawing.Size(108, 68);
            this.btnChoix.TabIndex = 17;
            this.btnChoix.Text = "Enregistrer les choix";
            this.btnChoix.UseVisualStyleBackColor = true;
            this.btnChoix.Click += new System.EventHandler(this.btnChoix_Click);
            // 
            // panPhoto
            // 
            this.panPhoto.Location = new System.Drawing.Point(67, 154);
            this.panPhoto.Margin = new System.Windows.Forms.Padding(4);
            this.panPhoto.Name = "panPhoto";
            this.panPhoto.Size = new System.Drawing.Size(557, 213);
            this.panPhoto.TabIndex = 16;
            // 
            // btnAffiche
            // 
            this.btnAffiche.Location = new System.Drawing.Point(71, 382);
            this.btnAffiche.Margin = new System.Windows.Forms.Padding(4);
            this.btnAffiche.Name = "btnAffiche";
            this.btnAffiche.Size = new System.Drawing.Size(553, 55);
            this.btnAffiche.TabIndex = 15;
            this.btnAffiche.Text = "Affiche la photo";
            this.btnAffiche.UseVisualStyleBackColor = true;
            this.btnAffiche.Click += new System.EventHandler(this.btnAffiche_Click);
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
            "Black",
            "Brown",
            "Red"});
            this.cbxCouleurRoue.Location = new System.Drawing.Point(320, 89);
            this.cbxCouleurRoue.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCouleurRoue.Name = "cbxCouleurRoue";
            this.cbxCouleurRoue.Size = new System.Drawing.Size(160, 24);
            this.cbxCouleurRoue.TabIndex = 14;
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
            "Blue",
            "Red",
            "Black"});
            this.cbxCouleurAuto.Location = new System.Drawing.Point(151, 89);
            this.cbxCouleurAuto.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCouleurAuto.Name = "cbxCouleurAuto";
            this.cbxCouleurAuto.Size = new System.Drawing.Size(160, 24);
            this.cbxCouleurAuto.TabIndex = 13;
            // 
            // cbxRayonSoleil
            // 
            this.cbxRayonSoleil.AutoCompleteCustomSource.AddRange(new string[] {
            "20",
            "50",
            "100"});
            this.cbxRayonSoleil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRayonSoleil.FormattingEnabled = true;
            this.cbxRayonSoleil.Items.AddRange(new object[] {
            "20",
            "40",
            "80"});
            this.cbxRayonSoleil.Location = new System.Drawing.Point(320, 46);
            this.cbxRayonSoleil.Margin = new System.Windows.Forms.Padding(4);
            this.cbxRayonSoleil.Name = "cbxRayonSoleil";
            this.cbxRayonSoleil.Size = new System.Drawing.Size(160, 24);
            this.cbxRayonSoleil.TabIndex = 12;
            // 
            // cbxCouleurSoleil
            // 
            this.cbxCouleurSoleil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCouleurSoleil.FormattingEnabled = true;
            this.cbxCouleurSoleil.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Black"});
            this.cbxCouleurSoleil.Location = new System.Drawing.Point(151, 46);
            this.cbxCouleurSoleil.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCouleurSoleil.Name = "cbxCouleurSoleil";
            this.cbxCouleurSoleil.Size = new System.Drawing.Size(160, 24);
            this.cbxCouleurSoleil.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Auto: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Soleil: ";
            // 
            // FrmMembresPrivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 483);
            this.Controls.Add(this.btnChoix);
            this.Controls.Add(this.panPhoto);
            this.Controls.Add(this.btnAffiche);
            this.Controls.Add(this.cbxCouleurRoue);
            this.Controls.Add(this.cbxCouleurAuto);
            this.Controls.Add(this.cbxRayonSoleil);
            this.Controls.Add(this.cbxCouleurSoleil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMembresPrivate";
            this.Text = "FrmMembresPrivate";
            this.Shown += new System.EventHandler(this.FrmMembresPrivate_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChoix;
        private System.Windows.Forms.Panel panPhoto;
        private System.Windows.Forms.Button btnAffiche;
        private System.Windows.Forms.ComboBox cbxCouleurRoue;
        private System.Windows.Forms.ComboBox cbxCouleurAuto;
        private System.Windows.Forms.ComboBox cbxRayonSoleil;
        private System.Windows.Forms.ComboBox cbxCouleurSoleil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}