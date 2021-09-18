namespace TP2
{
    partial class frmTP2
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
            this.btnCalculerEscompte = new System.Windows.Forms.Button();
            this.btnCalculerHydro = new System.Windows.Forms.Button();
            this.lblQuantiteAchetee = new System.Windows.Forms.Label();
            this.lblPrixUnitaire = new System.Windows.Forms.Label();
            this.lblMontantEscompte = new System.Windows.Forms.Label();
            this.lblMontantTotalVente = new System.Windows.Forms.Label();
            this.txtQuantiteAchetee = new System.Windows.Forms.TextBox();
            this.txtPrixUnitaire = new System.Windows.Forms.TextBox();
            this.txtMontantEscompte = new System.Windows.Forms.TextBox();
            this.txtMontantTotalVente = new System.Windows.Forms.TextBox();
            this.gbEscompte = new System.Windows.Forms.GroupBox();
            this.gbHydro = new System.Windows.Forms.GroupBox();
            this.txtMontantTotal = new System.Windows.Forms.TextBox();
            this.lblMontantTotal = new System.Windows.Forms.Label();
            this.txtMontantTaxe = new System.Windows.Forms.TextBox();
            this.lblMontantTaxe = new System.Windows.Forms.Label();
            this.txtMontantFacture = new System.Windows.Forms.TextBox();
            this.lblMontantFacture = new System.Windows.Forms.Label();
            this.txtNombreKilowattsConsomes = new System.Windows.Forms.TextBox();
            this.lblNombreKilowattsConsommes = new System.Windows.Forms.Label();
            this.txtNombreJoursFactures = new System.Windows.Forms.TextBox();
            this.lblNombreJoursFactures = new System.Windows.Forms.Label();
            this.txtNumeroAbonne = new System.Windows.Forms.TextBox();
            this.lblNumeroAbonne = new System.Windows.Forms.Label();
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.tblPrixVente = new System.Windows.Forms.TableLayoutPanel();
            this.tblHydroCegep = new System.Windows.Forms.TableLayoutPanel();
            this.gbEscompte.SuspendLayout();
            this.gbHydro.SuspendLayout();
            this.tblPrincipal.SuspendLayout();
            this.tblPrixVente.SuspendLayout();
            this.tblHydroCegep.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculerEscompte
            // 
            this.tblPrixVente.SetColumnSpan(this.btnCalculerEscompte, 4);
            this.btnCalculerEscompte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalculerEscompte.Location = new System.Drawing.Point(13, 54);
            this.btnCalculerEscompte.Name = "btnCalculerEscompte";
            this.btnCalculerEscompte.Size = new System.Drawing.Size(620, 35);
            this.btnCalculerEscompte.TabIndex = 6;
            this.btnCalculerEscompte.Text = "Calculer l\'escompte";
            this.btnCalculerEscompte.UseVisualStyleBackColor = true;
            // 
            // btnCalculerHydro
            // 
            this.tblHydroCegep.SetColumnSpan(this.btnCalculerHydro, 4);
            this.btnCalculerHydro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalculerHydro.Location = new System.Drawing.Point(13, 111);
            this.btnCalculerHydro.Name = "btnCalculerHydro";
            this.btnCalculerHydro.Size = new System.Drawing.Size(620, 43);
            this.btnCalculerHydro.TabIndex = 18;
            this.btnCalculerHydro.Text = "Calculer Hydro-Cégep";
            this.btnCalculerHydro.UseVisualStyleBackColor = true;
            // 
            // lblQuantiteAchetee
            // 
            this.lblQuantiteAchetee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuantiteAchetee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuantiteAchetee.Location = new System.Drawing.Point(13, 10);
            this.lblQuantiteAchetee.Name = "lblQuantiteAchetee";
            this.lblQuantiteAchetee.Size = new System.Drawing.Size(150, 41);
            this.lblQuantiteAchetee.TabIndex = 2;
            this.lblQuantiteAchetee.Text = "Quantité achetée";
            this.lblQuantiteAchetee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrixUnitaire
            // 
            this.lblPrixUnitaire.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrixUnitaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrixUnitaire.Location = new System.Drawing.Point(325, 10);
            this.lblPrixUnitaire.Name = "lblPrixUnitaire";
            this.lblPrixUnitaire.Size = new System.Drawing.Size(150, 41);
            this.lblPrixUnitaire.TabIndex = 4;
            this.lblPrixUnitaire.Text = "Prix unitaire";
            this.lblPrixUnitaire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMontantEscompte
            // 
            this.lblMontantEscompte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontantEscompte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMontantEscompte.Location = new System.Drawing.Point(13, 92);
            this.lblMontantEscompte.Name = "lblMontantEscompte";
            this.lblMontantEscompte.Size = new System.Drawing.Size(150, 44);
            this.lblMontantEscompte.TabIndex = 7;
            this.lblMontantEscompte.Text = "Montant escompte";
            this.lblMontantEscompte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMontantTotalVente
            // 
            this.lblMontantTotalVente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontantTotalVente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMontantTotalVente.Location = new System.Drawing.Point(325, 92);
            this.lblMontantTotalVente.Name = "lblMontantTotalVente";
            this.lblMontantTotalVente.Size = new System.Drawing.Size(150, 44);
            this.lblMontantTotalVente.TabIndex = 9;
            this.lblMontantTotalVente.Text = "Montant total";
            this.lblMontantTotalVente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQuantiteAchetee
            // 
            this.txtQuantiteAchetee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuantiteAchetee.Location = new System.Drawing.Point(169, 13);
            this.txtQuantiteAchetee.Multiline = true;
            this.txtQuantiteAchetee.Name = "txtQuantiteAchetee";
            this.txtQuantiteAchetee.Size = new System.Drawing.Size(150, 35);
            this.txtQuantiteAchetee.TabIndex = 3;
            // 
            // txtPrixUnitaire
            // 
            this.txtPrixUnitaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrixUnitaire.Location = new System.Drawing.Point(481, 13);
            this.txtPrixUnitaire.Multiline = true;
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.Size = new System.Drawing.Size(152, 35);
            this.txtPrixUnitaire.TabIndex = 5;
            // 
            // txtMontantEscompte
            // 
            this.txtMontantEscompte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMontantEscompte.Location = new System.Drawing.Point(169, 95);
            this.txtMontantEscompte.Multiline = true;
            this.txtMontantEscompte.Name = "txtMontantEscompte";
            this.txtMontantEscompte.ReadOnly = true;
            this.txtMontantEscompte.Size = new System.Drawing.Size(150, 38);
            this.txtMontantEscompte.TabIndex = 8;
            // 
            // txtMontantTotalVente
            // 
            this.txtMontantTotalVente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMontantTotalVente.Location = new System.Drawing.Point(481, 95);
            this.txtMontantTotalVente.Multiline = true;
            this.txtMontantTotalVente.Name = "txtMontantTotalVente";
            this.txtMontantTotalVente.ReadOnly = true;
            this.txtMontantTotalVente.Size = new System.Drawing.Size(152, 38);
            this.txtMontantTotalVente.TabIndex = 10;
            // 
            // gbEscompte
            // 
            this.gbEscompte.Controls.Add(this.tblPrixVente);
            this.gbEscompte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEscompte.Location = new System.Drawing.Point(13, 13);
            this.gbEscompte.Name = "gbEscompte";
            this.gbEscompte.Size = new System.Drawing.Size(652, 171);
            this.gbEscompte.TabIndex = 1;
            this.gbEscompte.TabStop = false;
            this.gbEscompte.Text = "Prix de vente";
            // 
            // gbHydro
            // 
            this.gbHydro.Controls.Add(this.tblHydroCegep);
            this.gbHydro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbHydro.Location = new System.Drawing.Point(13, 190);
            this.gbHydro.Name = "gbHydro";
            this.gbHydro.Size = new System.Drawing.Size(652, 291);
            this.gbHydro.TabIndex = 11;
            this.gbHydro.TabStop = false;
            this.gbHydro.Text = "Facturation Hydro-Cégep";
            // 
            // txtMontantTotal
            // 
            this.txtMontantTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMontantTotal.Location = new System.Drawing.Point(169, 209);
            this.txtMontantTotal.Multiline = true;
            this.txtMontantTotal.Name = "txtMontantTotal";
            this.txtMontantTotal.ReadOnly = true;
            this.txtMontantTotal.Size = new System.Drawing.Size(150, 44);
            this.txtMontantTotal.TabIndex = 24;
            // 
            // lblMontantTotal
            // 
            this.lblMontantTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontantTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMontantTotal.Location = new System.Drawing.Point(13, 206);
            this.lblMontantTotal.Name = "lblMontantTotal";
            this.lblMontantTotal.Size = new System.Drawing.Size(150, 50);
            this.lblMontantTotal.TabIndex = 23;
            this.lblMontantTotal.Text = "Montant total";
            this.lblMontantTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMontantTaxe
            // 
            this.txtMontantTaxe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMontantTaxe.Location = new System.Drawing.Point(481, 160);
            this.txtMontantTaxe.Multiline = true;
            this.txtMontantTaxe.Name = "txtMontantTaxe";
            this.txtMontantTaxe.ReadOnly = true;
            this.txtMontantTaxe.Size = new System.Drawing.Size(152, 43);
            this.txtMontantTaxe.TabIndex = 22;
            // 
            // lblMontantTaxe
            // 
            this.lblMontantTaxe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontantTaxe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMontantTaxe.Location = new System.Drawing.Point(325, 157);
            this.lblMontantTaxe.Name = "lblMontantTaxe";
            this.lblMontantTaxe.Size = new System.Drawing.Size(150, 49);
            this.lblMontantTaxe.TabIndex = 21;
            this.lblMontantTaxe.Text = "Montant taxe";
            this.lblMontantTaxe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMontantFacture
            // 
            this.txtMontantFacture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMontantFacture.Location = new System.Drawing.Point(169, 160);
            this.txtMontantFacture.Multiline = true;
            this.txtMontantFacture.Name = "txtMontantFacture";
            this.txtMontantFacture.ReadOnly = true;
            this.txtMontantFacture.Size = new System.Drawing.Size(150, 43);
            this.txtMontantFacture.TabIndex = 20;
            // 
            // lblMontantFacture
            // 
            this.lblMontantFacture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMontantFacture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMontantFacture.Location = new System.Drawing.Point(13, 157);
            this.lblMontantFacture.Name = "lblMontantFacture";
            this.lblMontantFacture.Size = new System.Drawing.Size(150, 49);
            this.lblMontantFacture.TabIndex = 19;
            this.lblMontantFacture.Text = "Montant facture";
            this.lblMontantFacture.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreKilowattsConsomes
            // 
            this.txtNombreKilowattsConsomes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreKilowattsConsomes.Location = new System.Drawing.Point(481, 62);
            this.txtNombreKilowattsConsomes.Multiline = true;
            this.txtNombreKilowattsConsomes.Name = "txtNombreKilowattsConsomes";
            this.txtNombreKilowattsConsomes.Size = new System.Drawing.Size(152, 43);
            this.txtNombreKilowattsConsomes.TabIndex = 17;
            // 
            // lblNombreKilowattsConsommes
            // 
            this.lblNombreKilowattsConsommes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreKilowattsConsommes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreKilowattsConsommes.Location = new System.Drawing.Point(325, 59);
            this.lblNombreKilowattsConsommes.Name = "lblNombreKilowattsConsommes";
            this.lblNombreKilowattsConsommes.Size = new System.Drawing.Size(150, 49);
            this.lblNombreKilowattsConsommes.TabIndex = 16;
            this.lblNombreKilowattsConsommes.Text = "Nombre kilowatts";
            this.lblNombreKilowattsConsommes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombreJoursFactures
            // 
            this.txtNombreJoursFactures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreJoursFactures.Location = new System.Drawing.Point(169, 62);
            this.txtNombreJoursFactures.Multiline = true;
            this.txtNombreJoursFactures.Name = "txtNombreJoursFactures";
            this.txtNombreJoursFactures.Size = new System.Drawing.Size(150, 43);
            this.txtNombreJoursFactures.TabIndex = 15;
            // 
            // lblNombreJoursFactures
            // 
            this.lblNombreJoursFactures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombreJoursFactures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreJoursFactures.Location = new System.Drawing.Point(13, 59);
            this.lblNombreJoursFactures.Name = "lblNombreJoursFactures";
            this.lblNombreJoursFactures.Size = new System.Drawing.Size(150, 49);
            this.lblNombreJoursFactures.TabIndex = 14;
            this.lblNombreJoursFactures.Text = "Nombre de jours";
            this.lblNombreJoursFactures.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNumeroAbonne
            // 
            this.txtNumeroAbonne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNumeroAbonne.Location = new System.Drawing.Point(169, 13);
            this.txtNumeroAbonne.Multiline = true;
            this.txtNumeroAbonne.Name = "txtNumeroAbonne";
            this.txtNumeroAbonne.Size = new System.Drawing.Size(150, 43);
            this.txtNumeroAbonne.TabIndex = 13;
            // 
            // lblNumeroAbonne
            // 
            this.lblNumeroAbonne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNumeroAbonne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNumeroAbonne.Location = new System.Drawing.Point(13, 10);
            this.lblNumeroAbonne.Name = "lblNumeroAbonne";
            this.lblNumeroAbonne.Size = new System.Drawing.Size(150, 49);
            this.lblNumeroAbonne.TabIndex = 12;
            this.lblNumeroAbonne.Text = "Numéro d\'abonné";
            this.lblNumeroAbonne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 1;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPrincipal.Controls.Add(this.gbHydro, 0, 1);
            this.tblPrincipal.Controls.Add(this.gbEscompte, 0, 0);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.Padding = new System.Windows.Forms.Padding(10);
            this.tblPrincipal.RowCount = 2;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tblPrincipal.Size = new System.Drawing.Size(678, 494);
            this.tblPrincipal.TabIndex = 12;
            // 
            // tblPrixVente
            // 
            this.tblPrixVente.ColumnCount = 4;
            this.tblPrixVente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPrixVente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPrixVente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPrixVente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblPrixVente.Controls.Add(this.lblQuantiteAchetee, 0, 0);
            this.tblPrixVente.Controls.Add(this.txtMontantTotalVente, 3, 2);
            this.tblPrixVente.Controls.Add(this.txtQuantiteAchetee, 1, 0);
            this.tblPrixVente.Controls.Add(this.lblMontantTotalVente, 2, 2);
            this.tblPrixVente.Controls.Add(this.lblPrixUnitaire, 2, 0);
            this.tblPrixVente.Controls.Add(this.txtMontantEscompte, 1, 2);
            this.tblPrixVente.Controls.Add(this.txtPrixUnitaire, 3, 0);
            this.tblPrixVente.Controls.Add(this.lblMontantEscompte, 0, 2);
            this.tblPrixVente.Controls.Add(this.btnCalculerEscompte, 0, 1);
            this.tblPrixVente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrixVente.Location = new System.Drawing.Point(3, 22);
            this.tblPrixVente.Name = "tblPrixVente";
            this.tblPrixVente.Padding = new System.Windows.Forms.Padding(10);
            this.tblPrixVente.RowCount = 3;
            this.tblPrixVente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPrixVente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPrixVente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblPrixVente.Size = new System.Drawing.Size(646, 146);
            this.tblPrixVente.TabIndex = 11;
            // 
            // tblHydroCegep
            // 
            this.tblHydroCegep.ColumnCount = 4;
            this.tblHydroCegep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblHydroCegep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblHydroCegep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblHydroCegep.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblHydroCegep.Controls.Add(this.lblNumeroAbonne, 0, 0);
            this.tblHydroCegep.Controls.Add(this.txtMontantTotal, 1, 4);
            this.tblHydroCegep.Controls.Add(this.txtNumeroAbonne, 1, 0);
            this.tblHydroCegep.Controls.Add(this.lblMontantTotal, 0, 4);
            this.tblHydroCegep.Controls.Add(this.lblNombreJoursFactures, 0, 1);
            this.tblHydroCegep.Controls.Add(this.txtMontantTaxe, 3, 3);
            this.tblHydroCegep.Controls.Add(this.txtNombreJoursFactures, 1, 1);
            this.tblHydroCegep.Controls.Add(this.lblMontantTaxe, 2, 3);
            this.tblHydroCegep.Controls.Add(this.lblNombreKilowattsConsommes, 2, 1);
            this.tblHydroCegep.Controls.Add(this.txtMontantFacture, 1, 3);
            this.tblHydroCegep.Controls.Add(this.txtNombreKilowattsConsomes, 3, 1);
            this.tblHydroCegep.Controls.Add(this.lblMontantFacture, 0, 3);
            this.tblHydroCegep.Controls.Add(this.btnCalculerHydro, 0, 2);
            this.tblHydroCegep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblHydroCegep.Location = new System.Drawing.Point(3, 22);
            this.tblHydroCegep.Name = "tblHydroCegep";
            this.tblHydroCegep.Padding = new System.Windows.Forms.Padding(10);
            this.tblHydroCegep.RowCount = 5;
            this.tblHydroCegep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblHydroCegep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblHydroCegep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblHydroCegep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblHydroCegep.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblHydroCegep.Size = new System.Drawing.Size(646, 266);
            this.tblHydroCegep.TabIndex = 25;
            // 
            // frmTP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 494);
            this.Controls.Add(this.tblPrincipal);
            this.MinimumSize = new System.Drawing.Size(700, 550);
            this.Name = "frmTP2";
            this.Text = "TP2 par Jérémie Normand";
            this.gbEscompte.ResumeLayout(false);
            this.gbHydro.ResumeLayout(false);
            this.tblPrincipal.ResumeLayout(false);
            this.tblPrixVente.ResumeLayout(false);
            this.tblPrixVente.PerformLayout();
            this.tblHydroCegep.ResumeLayout(false);
            this.tblHydroCegep.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculerEscompte;
        private System.Windows.Forms.Button btnCalculerHydro;
        private System.Windows.Forms.Label lblQuantiteAchetee;
        private System.Windows.Forms.Label lblPrixUnitaire;
        private System.Windows.Forms.Label lblMontantEscompte;
        private System.Windows.Forms.Label lblMontantTotalVente;
        private System.Windows.Forms.TextBox txtQuantiteAchetee;
        private System.Windows.Forms.TextBox txtPrixUnitaire;
        private System.Windows.Forms.TextBox txtMontantEscompte;
        private System.Windows.Forms.TextBox txtMontantTotalVente;
        private System.Windows.Forms.GroupBox gbEscompte;
        private System.Windows.Forms.GroupBox gbHydro;
        private System.Windows.Forms.TextBox txtMontantTotal;
        private System.Windows.Forms.Label lblMontantTotal;
        private System.Windows.Forms.TextBox txtMontantTaxe;
        private System.Windows.Forms.Label lblMontantTaxe;
        private System.Windows.Forms.TextBox txtMontantFacture;
        private System.Windows.Forms.Label lblMontantFacture;
        private System.Windows.Forms.TextBox txtNombreKilowattsConsomes;
        private System.Windows.Forms.Label lblNombreKilowattsConsommes;
        private System.Windows.Forms.TextBox txtNombreJoursFactures;
        private System.Windows.Forms.Label lblNombreJoursFactures;
        private System.Windows.Forms.TextBox txtNumeroAbonne;
        private System.Windows.Forms.Label lblNumeroAbonne;
        private System.Windows.Forms.TableLayoutPanel tblPrixVente;
        private System.Windows.Forms.TableLayoutPanel tblHydroCegep;
        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
    }
}

