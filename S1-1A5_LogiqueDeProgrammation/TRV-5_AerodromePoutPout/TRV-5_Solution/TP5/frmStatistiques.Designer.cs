namespace TP5
{
    partial class frmStatistiques
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
            this.gbStatistiques = new System.Windows.Forms.GroupBox();
            this.tblStatistiques = new System.Windows.Forms.TableLayoutPanel();
            this.gbPourcentages = new System.Windows.Forms.GroupBox();
            this.tblPourcentages = new System.Windows.Forms.TableLayoutPanel();
            this.lblUniteVancouver = new System.Windows.Forms.Label();
            this.lblPourcentageVancouver = new System.Windows.Forms.Label();
            this.lblVancouver = new System.Windows.Forms.Label();
            this.lblUniteToronto = new System.Windows.Forms.Label();
            this.lblPourcentageToronto = new System.Windows.Forms.Label();
            this.lblToronto = new System.Windows.Forms.Label();
            this.lblUniteMontreal = new System.Windows.Forms.Label();
            this.lblMontreal = new System.Windows.Forms.Label();
            this.lblPourcentageMontreal = new System.Windows.Forms.Label();
            this.tblMoyennePrixBilletsFemmesMariees = new System.Windows.Forms.TableLayoutPanel();
            this.lblMoyennePrixBilletsFemmesMariees = new System.Windows.Forms.Label();
            this.lblAnonceMoyennePrixBilletsFemmesMariees = new System.Windows.Forms.Label();
            this.lblUniteMoyennePrixBilletsFemmesMariees = new System.Windows.Forms.Label();
            this.gbStatistiques.SuspendLayout();
            this.tblStatistiques.SuspendLayout();
            this.gbPourcentages.SuspendLayout();
            this.tblPourcentages.SuspendLayout();
            this.tblMoyennePrixBilletsFemmesMariees.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbStatistiques
            // 
            this.gbStatistiques.Controls.Add(this.tblStatistiques);
            this.gbStatistiques.Location = new System.Drawing.Point(40, 12);
            this.gbStatistiques.Name = "gbStatistiques";
            this.gbStatistiques.Size = new System.Drawing.Size(728, 444);
            this.gbStatistiques.TabIndex = 4;
            this.gbStatistiques.TabStop = false;
            this.gbStatistiques.Text = "Statistiques";
            // 
            // tblStatistiques
            // 
            this.tblStatistiques.ColumnCount = 2;
            this.tblStatistiques.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatistiques.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblStatistiques.Controls.Add(this.gbPourcentages, 0, 0);
            this.tblStatistiques.Controls.Add(this.tblMoyennePrixBilletsFemmesMariees, 1, 0);
            this.tblStatistiques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatistiques.Location = new System.Drawing.Point(3, 22);
            this.tblStatistiques.Name = "tblStatistiques";
            this.tblStatistiques.RowCount = 2;
            this.tblStatistiques.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tblStatistiques.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tblStatistiques.Size = new System.Drawing.Size(722, 419);
            this.tblStatistiques.TabIndex = 0;
            // 
            // gbPourcentages
            // 
            this.gbPourcentages.Controls.Add(this.tblPourcentages);
            this.gbPourcentages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPourcentages.Location = new System.Drawing.Point(3, 3);
            this.gbPourcentages.Name = "gbPourcentages";
            this.gbPourcentages.Size = new System.Drawing.Size(355, 132);
            this.gbPourcentages.TabIndex = 0;
            this.gbPourcentages.TabStop = false;
            this.gbPourcentages.Text = "Pourcentage des billets émis pour";
            // 
            // tblPourcentages
            // 
            this.tblPourcentages.ColumnCount = 3;
            this.tblPourcentages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPourcentages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPourcentages.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPourcentages.Controls.Add(this.lblUniteVancouver, 2, 2);
            this.tblPourcentages.Controls.Add(this.lblPourcentageVancouver, 1, 2);
            this.tblPourcentages.Controls.Add(this.lblVancouver, 0, 2);
            this.tblPourcentages.Controls.Add(this.lblUniteToronto, 2, 1);
            this.tblPourcentages.Controls.Add(this.lblPourcentageToronto, 1, 1);
            this.tblPourcentages.Controls.Add(this.lblToronto, 0, 1);
            this.tblPourcentages.Controls.Add(this.lblUniteMontreal, 2, 0);
            this.tblPourcentages.Controls.Add(this.lblMontreal, 0, 0);
            this.tblPourcentages.Controls.Add(this.lblPourcentageMontreal, 1, 0);
            this.tblPourcentages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPourcentages.Location = new System.Drawing.Point(3, 22);
            this.tblPourcentages.Name = "tblPourcentages";
            this.tblPourcentages.RowCount = 3;
            this.tblPourcentages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPourcentages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPourcentages.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPourcentages.Size = new System.Drawing.Size(349, 107);
            this.tblPourcentages.TabIndex = 0;
            // 
            // lblUniteVancouver
            // 
            this.lblUniteVancouver.AutoSize = true;
            this.lblUniteVancouver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUniteVancouver.Location = new System.Drawing.Point(235, 70);
            this.lblUniteVancouver.Name = "lblUniteVancouver";
            this.lblUniteVancouver.Size = new System.Drawing.Size(111, 37);
            this.lblUniteVancouver.TabIndex = 10;
            this.lblUniteVancouver.Text = "%";
            // 
            // lblPourcentageVancouver
            // 
            this.lblPourcentageVancouver.AutoSize = true;
            this.lblPourcentageVancouver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPourcentageVancouver.Location = new System.Drawing.Point(119, 70);
            this.lblPourcentageVancouver.Name = "lblPourcentageVancouver";
            this.lblPourcentageVancouver.Size = new System.Drawing.Size(110, 37);
            this.lblPourcentageVancouver.TabIndex = 9;
            // 
            // lblVancouver
            // 
            this.lblVancouver.AutoSize = true;
            this.lblVancouver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVancouver.Location = new System.Drawing.Point(3, 70);
            this.lblVancouver.Name = "lblVancouver";
            this.lblVancouver.Size = new System.Drawing.Size(110, 37);
            this.lblVancouver.TabIndex = 8;
            this.lblVancouver.Text = "Vancouver";
            // 
            // lblUniteToronto
            // 
            this.lblUniteToronto.AutoSize = true;
            this.lblUniteToronto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUniteToronto.Location = new System.Drawing.Point(235, 35);
            this.lblUniteToronto.Name = "lblUniteToronto";
            this.lblUniteToronto.Size = new System.Drawing.Size(111, 35);
            this.lblUniteToronto.TabIndex = 7;
            this.lblUniteToronto.Text = "%";
            // 
            // lblPourcentageToronto
            // 
            this.lblPourcentageToronto.AutoSize = true;
            this.lblPourcentageToronto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPourcentageToronto.Location = new System.Drawing.Point(119, 35);
            this.lblPourcentageToronto.Name = "lblPourcentageToronto";
            this.lblPourcentageToronto.Size = new System.Drawing.Size(110, 35);
            this.lblPourcentageToronto.TabIndex = 6;
            // 
            // lblToronto
            // 
            this.lblToronto.AutoSize = true;
            this.lblToronto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblToronto.Location = new System.Drawing.Point(3, 35);
            this.lblToronto.Name = "lblToronto";
            this.lblToronto.Size = new System.Drawing.Size(110, 35);
            this.lblToronto.TabIndex = 5;
            this.lblToronto.Text = "Toronto";
            // 
            // lblUniteMontreal
            // 
            this.lblUniteMontreal.AutoSize = true;
            this.lblUniteMontreal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUniteMontreal.Location = new System.Drawing.Point(235, 0);
            this.lblUniteMontreal.Name = "lblUniteMontreal";
            this.lblUniteMontreal.Size = new System.Drawing.Size(111, 35);
            this.lblUniteMontreal.TabIndex = 4;
            this.lblUniteMontreal.Text = "%";
            // 
            // lblMontreal
            // 
            this.lblMontreal.AutoSize = true;
            this.lblMontreal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMontreal.Location = new System.Drawing.Point(3, 0);
            this.lblMontreal.Name = "lblMontreal";
            this.lblMontreal.Size = new System.Drawing.Size(110, 35);
            this.lblMontreal.TabIndex = 2;
            this.lblMontreal.Text = "Montréal";
            // 
            // lblPourcentageMontreal
            // 
            this.lblPourcentageMontreal.AutoSize = true;
            this.lblPourcentageMontreal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPourcentageMontreal.Location = new System.Drawing.Point(119, 0);
            this.lblPourcentageMontreal.Name = "lblPourcentageMontreal";
            this.lblPourcentageMontreal.Size = new System.Drawing.Size(110, 35);
            this.lblPourcentageMontreal.TabIndex = 3;
            // 
            // tblMoyennePrixBilletsFemmesMariees
            // 
            this.tblMoyennePrixBilletsFemmesMariees.ColumnCount = 2;
            this.tblMoyennePrixBilletsFemmesMariees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMoyennePrixBilletsFemmesMariees.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMoyennePrixBilletsFemmesMariees.Controls.Add(this.lblMoyennePrixBilletsFemmesMariees, 0, 1);
            this.tblMoyennePrixBilletsFemmesMariees.Controls.Add(this.lblAnonceMoyennePrixBilletsFemmesMariees, 0, 0);
            this.tblMoyennePrixBilletsFemmesMariees.Controls.Add(this.lblUniteMoyennePrixBilletsFemmesMariees, 1, 1);
            this.tblMoyennePrixBilletsFemmesMariees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMoyennePrixBilletsFemmesMariees.Location = new System.Drawing.Point(364, 3);
            this.tblMoyennePrixBilletsFemmesMariees.Name = "tblMoyennePrixBilletsFemmesMariees";
            this.tblMoyennePrixBilletsFemmesMariees.RowCount = 2;
            this.tblMoyennePrixBilletsFemmesMariees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMoyennePrixBilletsFemmesMariees.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMoyennePrixBilletsFemmesMariees.Size = new System.Drawing.Size(355, 132);
            this.tblMoyennePrixBilletsFemmesMariees.TabIndex = 1;
            // 
            // lblMoyennePrixBilletsFemmesMariees
            // 
            this.lblMoyennePrixBilletsFemmesMariees.AutoSize = true;
            this.lblMoyennePrixBilletsFemmesMariees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMoyennePrixBilletsFemmesMariees.Location = new System.Drawing.Point(3, 66);
            this.lblMoyennePrixBilletsFemmesMariees.Name = "lblMoyennePrixBilletsFemmesMariees";
            this.lblMoyennePrixBilletsFemmesMariees.Size = new System.Drawing.Size(171, 66);
            this.lblMoyennePrixBilletsFemmesMariees.TabIndex = 4;
            // 
            // lblAnonceMoyennePrixBilletsFemmesMariees
            // 
            this.lblAnonceMoyennePrixBilletsFemmesMariees.AutoSize = true;
            this.tblMoyennePrixBilletsFemmesMariees.SetColumnSpan(this.lblAnonceMoyennePrixBilletsFemmesMariees, 2);
            this.lblAnonceMoyennePrixBilletsFemmesMariees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnonceMoyennePrixBilletsFemmesMariees.Location = new System.Drawing.Point(3, 0);
            this.lblAnonceMoyennePrixBilletsFemmesMariees.Name = "lblAnonceMoyennePrixBilletsFemmesMariees";
            this.lblAnonceMoyennePrixBilletsFemmesMariees.Size = new System.Drawing.Size(349, 66);
            this.lblAnonceMoyennePrixBilletsFemmesMariees.TabIndex = 3;
            this.lblAnonceMoyennePrixBilletsFemmesMariees.Text = "Moyenne des prix de ventes des femmes mariées";
            // 
            // lblUniteMoyennePrixBilletsFemmesMariees
            // 
            this.lblUniteMoyennePrixBilletsFemmesMariees.AutoSize = true;
            this.lblUniteMoyennePrixBilletsFemmesMariees.Location = new System.Drawing.Point(180, 66);
            this.lblUniteMoyennePrixBilletsFemmesMariees.Name = "lblUniteMoyennePrixBilletsFemmesMariees";
            this.lblUniteMoyennePrixBilletsFemmesMariees.Size = new System.Drawing.Size(18, 20);
            this.lblUniteMoyennePrixBilletsFemmesMariees.TabIndex = 5;
            this.lblUniteMoyennePrixBilletsFemmesMariees.Text = "$";
            // 
            // frmStatistiques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 444);
            this.Controls.Add(this.gbStatistiques);
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "frmStatistiques";
            this.Text = "Aérodrome Pout Pout";
            this.gbStatistiques.ResumeLayout(false);
            this.tblStatistiques.ResumeLayout(false);
            this.gbPourcentages.ResumeLayout(false);
            this.tblPourcentages.ResumeLayout(false);
            this.tblPourcentages.PerformLayout();
            this.tblMoyennePrixBilletsFemmesMariees.ResumeLayout(false);
            this.tblMoyennePrixBilletsFemmesMariees.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbStatistiques;
        private System.Windows.Forms.TableLayoutPanel tblStatistiques;
        private System.Windows.Forms.GroupBox gbPourcentages;
        private System.Windows.Forms.TableLayoutPanel tblPourcentages;
        private System.Windows.Forms.Label lblUniteVancouver;
        private System.Windows.Forms.Label lblPourcentageVancouver;
        private System.Windows.Forms.Label lblVancouver;
        private System.Windows.Forms.Label lblUniteToronto;
        private System.Windows.Forms.Label lblPourcentageToronto;
        private System.Windows.Forms.Label lblToronto;
        private System.Windows.Forms.Label lblUniteMontreal;
        private System.Windows.Forms.Label lblMontreal;
        private System.Windows.Forms.Label lblPourcentageMontreal;
        private System.Windows.Forms.TableLayoutPanel tblMoyennePrixBilletsFemmesMariees;
        private System.Windows.Forms.Label lblMoyennePrixBilletsFemmesMariees;
        private System.Windows.Forms.Label lblAnonceMoyennePrixBilletsFemmesMariees;
        private System.Windows.Forms.Label lblUniteMoyennePrixBilletsFemmesMariees;
    }
}