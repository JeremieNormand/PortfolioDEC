namespace Lab9Classe
{
    partial class FrmMembresPublic
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCouleurSoleil = new System.Windows.Forms.ComboBox();
            this.cbxRayonSoleil = new System.Windows.Forms.ComboBox();
            this.cbxCouleurAuto = new System.Windows.Forms.ComboBox();
            this.cbxCouleurRoue = new System.Windows.Forms.ComboBox();
            this.btnAffiche = new System.Windows.Forms.Button();
            this.panPhoto = new System.Windows.Forms.Panel();
            this.btnChoix = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soleil: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Auto: ";
            // 
            // cbxCouleurSoleil
            // 
            this.cbxCouleurSoleil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCouleurSoleil.FormattingEnabled = true;
            this.cbxCouleurSoleil.Items.AddRange(new object[] {
            "Red",
            "Orange",
            "Black"});
            this.cbxCouleurSoleil.Location = new System.Drawing.Point(87, 31);
            this.cbxCouleurSoleil.Name = "cbxCouleurSoleil";
            this.cbxCouleurSoleil.Size = new System.Drawing.Size(121, 21);
            this.cbxCouleurSoleil.TabIndex = 2;
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
            this.cbxRayonSoleil.Location = new System.Drawing.Point(214, 31);
            this.cbxRayonSoleil.Name = "cbxRayonSoleil";
            this.cbxRayonSoleil.Size = new System.Drawing.Size(121, 21);
            this.cbxRayonSoleil.TabIndex = 3;
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
            this.cbxCouleurAuto.Location = new System.Drawing.Point(87, 66);
            this.cbxCouleurAuto.Name = "cbxCouleurAuto";
            this.cbxCouleurAuto.Size = new System.Drawing.Size(121, 21);
            this.cbxCouleurAuto.TabIndex = 4;
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
            this.cbxCouleurRoue.Location = new System.Drawing.Point(214, 66);
            this.cbxCouleurRoue.Name = "cbxCouleurRoue";
            this.cbxCouleurRoue.Size = new System.Drawing.Size(121, 21);
            this.cbxCouleurRoue.TabIndex = 5;
            // 
            // btnAffiche
            // 
            this.btnAffiche.Location = new System.Drawing.Point(27, 304);
            this.btnAffiche.Name = "btnAffiche";
            this.btnAffiche.Size = new System.Drawing.Size(415, 45);
            this.btnAffiche.TabIndex = 6;
            this.btnAffiche.Text = "Affiche la photo";
            this.btnAffiche.UseVisualStyleBackColor = true;
            this.btnAffiche.Click += new System.EventHandler(this.btnAffiche_Click);
            // 
            // panPhoto
            // 
            this.panPhoto.Location = new System.Drawing.Point(24, 119);
            this.panPhoto.Name = "panPhoto";
            this.panPhoto.Size = new System.Drawing.Size(418, 173);
            this.panPhoto.TabIndex = 7;
            // 
            // btnChoix
            // 
            this.btnChoix.Location = new System.Drawing.Point(360, 31);
            this.btnChoix.Name = "btnChoix";
            this.btnChoix.Size = new System.Drawing.Size(81, 55);
            this.btnChoix.TabIndex = 8;
            this.btnChoix.Text = "Enregistrer les choix";
            this.btnChoix.UseVisualStyleBackColor = true;
            this.btnChoix.Click += new System.EventHandler(this.btnChoix_Click);
            // 
            // FrmMembresPublc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 374);
            this.Controls.Add(this.btnChoix);
            this.Controls.Add(this.panPhoto);
            this.Controls.Add(this.btnAffiche);
            this.Controls.Add(this.cbxCouleurRoue);
            this.Controls.Add(this.cbxCouleurAuto);
            this.Controls.Add(this.cbxRayonSoleil);
            this.Controls.Add(this.cbxCouleurSoleil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMembresPublc";
            this.Text = "FrmMembresPublc";
            this.Shown += new System.EventHandler(this.FrmMembresPublc_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCouleurSoleil;
        private System.Windows.Forms.ComboBox cbxRayonSoleil;
        private System.Windows.Forms.ComboBox cbxCouleurAuto;
        private System.Windows.Forms.ComboBox cbxCouleurRoue;
        private System.Windows.Forms.Button btnAffiche;
        private System.Windows.Forms.Panel panPhoto;
        private System.Windows.Forms.Button btnChoix;
    }
}