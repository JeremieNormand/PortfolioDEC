namespace TP5
{
    partial class frmBillet
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
            this.tblPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.gbDonneesDuVoyageur = new System.Windows.Forms.GroupBox();
            this.tblDonneesDuVoyageur = new System.Windows.Forms.TableLayoutPanel();
            this.txtPoidsBagagesEnKilos = new System.Windows.Forms.TextBox();
            this.lblPoidsBagagesEnKilos = new System.Windows.Forms.Label();
            this.txtCodeDestination = new System.Windows.Forms.TextBox();
            this.lblCodeDestination = new System.Windows.Forms.Label();
            this.txtCodeStatutCivil = new System.Windows.Forms.TextBox();
            this.lblCodeStatutCivil = new System.Windows.Forms.Label();
            this.txtCodeSexe = new System.Windows.Forms.TextBox();
            this.lblCodeSexe = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.tblBoutons = new System.Windows.Forms.TableLayoutPanel();
            this.btnAfficherStatistiques = new System.Windows.Forms.Button();
            this.btnEmettreBillet = new System.Windows.Forms.Button();
            this.tblBilletEmis = new System.Windows.Forms.TableLayoutPanel();
            this.lblUnitePrixBillet = new System.Windows.Forms.Label();
            this.lblPrixBillet = new System.Windows.Forms.Label();
            this.lblAnoncePrixBillet = new System.Windows.Forms.Label();
            this.lblItineraire = new System.Windows.Forms.Label();
            this.lblFormulePolitesse = new System.Windows.Forms.Label();
            this.lblNomDuVoyageur = new System.Windows.Forms.Label();
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
            this.tblPrincipal.SuspendLayout();
            this.gbDonneesDuVoyageur.SuspendLayout();
            this.tblDonneesDuVoyageur.SuspendLayout();
            this.tblBoutons.SuspendLayout();
            this.tblBilletEmis.SuspendLayout();
            this.gbStatistiques.SuspendLayout();
            this.tblStatistiques.SuspendLayout();
            this.gbPourcentages.SuspendLayout();
            this.tblPourcentages.SuspendLayout();
            this.tblMoyennePrixBilletsFemmesMariees.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 1;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPrincipal.Controls.Add(this.gbDonneesDuVoyageur, 0, 0);
            this.tblPrincipal.Controls.Add(this.tblBoutons, 0, 1);
            this.tblPrincipal.Controls.Add(this.tblBilletEmis, 0, 2);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 3;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tblPrincipal.Size = new System.Drawing.Size(728, 444);
            this.tblPrincipal.TabIndex = 0;
            // 
            // gbDonneesDuVoyageur
            // 
            this.gbDonneesDuVoyageur.Controls.Add(this.gbStatistiques);
            this.gbDonneesDuVoyageur.Controls.Add(this.tblDonneesDuVoyageur);
            this.gbDonneesDuVoyageur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDonneesDuVoyageur.Location = new System.Drawing.Point(3, 3);
            this.gbDonneesDuVoyageur.Name = "gbDonneesDuVoyageur";
            this.gbDonneesDuVoyageur.Size = new System.Drawing.Size(722, 216);
            this.gbDonneesDuVoyageur.TabIndex = 0;
            this.gbDonneesDuVoyageur.TabStop = false;
            this.gbDonneesDuVoyageur.Text = "Saisir les données du voyageur";
            // 
            // tblDonneesDuVoyageur
            // 
            this.tblDonneesDuVoyageur.ColumnCount = 4;
            this.tblDonneesDuVoyageur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDonneesDuVoyageur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDonneesDuVoyageur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDonneesDuVoyageur.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDonneesDuVoyageur.Controls.Add(this.txtPoidsBagagesEnKilos, 2, 3);
            this.tblDonneesDuVoyageur.Controls.Add(this.lblPoidsBagagesEnKilos, 0, 3);
            this.tblDonneesDuVoyageur.Controls.Add(this.txtCodeDestination, 2, 2);
            this.tblDonneesDuVoyageur.Controls.Add(this.lblCodeDestination, 0, 2);
            this.tblDonneesDuVoyageur.Controls.Add(this.txtCodeStatutCivil, 3, 1);
            this.tblDonneesDuVoyageur.Controls.Add(this.lblCodeStatutCivil, 2, 1);
            this.tblDonneesDuVoyageur.Controls.Add(this.txtCodeSexe, 1, 1);
            this.tblDonneesDuVoyageur.Controls.Add(this.lblCodeSexe, 0, 1);
            this.tblDonneesDuVoyageur.Controls.Add(this.lblNom, 0, 0);
            this.tblDonneesDuVoyageur.Controls.Add(this.txtNom, 1, 0);
            this.tblDonneesDuVoyageur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDonneesDuVoyageur.Location = new System.Drawing.Point(3, 22);
            this.tblDonneesDuVoyageur.Name = "tblDonneesDuVoyageur";
            this.tblDonneesDuVoyageur.RowCount = 4;
            this.tblDonneesDuVoyageur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDonneesDuVoyageur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDonneesDuVoyageur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDonneesDuVoyageur.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDonneesDuVoyageur.Size = new System.Drawing.Size(716, 191);
            this.tblDonneesDuVoyageur.TabIndex = 0;
            // 
            // txtPoidsBagagesEnKilos
            // 
            this.tblDonneesDuVoyageur.SetColumnSpan(this.txtPoidsBagagesEnKilos, 2);
            this.txtPoidsBagagesEnKilos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPoidsBagagesEnKilos.Location = new System.Drawing.Point(361, 144);
            this.txtPoidsBagagesEnKilos.Name = "txtPoidsBagagesEnKilos";
            this.txtPoidsBagagesEnKilos.Size = new System.Drawing.Size(352, 26);
            this.txtPoidsBagagesEnKilos.TabIndex = 9;
            // 
            // lblPoidsBagagesEnKilos
            // 
            this.lblPoidsBagagesEnKilos.AutoSize = true;
            this.tblDonneesDuVoyageur.SetColumnSpan(this.lblPoidsBagagesEnKilos, 2);
            this.lblPoidsBagagesEnKilos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPoidsBagagesEnKilos.Location = new System.Drawing.Point(3, 141);
            this.lblPoidsBagagesEnKilos.Name = "lblPoidsBagagesEnKilos";
            this.lblPoidsBagagesEnKilos.Size = new System.Drawing.Size(352, 50);
            this.lblPoidsBagagesEnKilos.TabIndex = 8;
            this.lblPoidsBagagesEnKilos.Text = "Poids des bagages (Kilo)";
            // 
            // txtCodeDestination
            // 
            this.tblDonneesDuVoyageur.SetColumnSpan(this.txtCodeDestination, 2);
            this.txtCodeDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodeDestination.Location = new System.Drawing.Point(361, 97);
            this.txtCodeDestination.Name = "txtCodeDestination";
            this.txtCodeDestination.Size = new System.Drawing.Size(352, 26);
            this.txtCodeDestination.TabIndex = 7;
            // 
            // lblCodeDestination
            // 
            this.lblCodeDestination.AutoSize = true;
            this.tblDonneesDuVoyageur.SetColumnSpan(this.lblCodeDestination, 2);
            this.lblCodeDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodeDestination.Location = new System.Drawing.Point(3, 94);
            this.lblCodeDestination.Name = "lblCodeDestination";
            this.lblCodeDestination.Size = new System.Drawing.Size(352, 47);
            this.lblCodeDestination.TabIndex = 6;
            this.lblCodeDestination.Text = "Destination (M, T ou V)";
            // 
            // txtCodeStatutCivil
            // 
            this.txtCodeStatutCivil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodeStatutCivil.Location = new System.Drawing.Point(540, 50);
            this.txtCodeStatutCivil.Name = "txtCodeStatutCivil";
            this.txtCodeStatutCivil.Size = new System.Drawing.Size(173, 26);
            this.txtCodeStatutCivil.TabIndex = 5;
            // 
            // lblCodeStatutCivil
            // 
            this.lblCodeStatutCivil.AutoSize = true;
            this.lblCodeStatutCivil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodeStatutCivil.Location = new System.Drawing.Point(361, 47);
            this.lblCodeStatutCivil.Name = "lblCodeStatutCivil";
            this.lblCodeStatutCivil.Size = new System.Drawing.Size(173, 47);
            this.lblCodeStatutCivil.TabIndex = 4;
            this.lblCodeStatutCivil.Text = "Statut (M ou C)";
            // 
            // txtCodeSexe
            // 
            this.txtCodeSexe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodeSexe.Location = new System.Drawing.Point(182, 50);
            this.txtCodeSexe.Name = "txtCodeSexe";
            this.txtCodeSexe.Size = new System.Drawing.Size(173, 26);
            this.txtCodeSexe.TabIndex = 3;
            // 
            // lblCodeSexe
            // 
            this.lblCodeSexe.AutoSize = true;
            this.lblCodeSexe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCodeSexe.Location = new System.Drawing.Point(3, 47);
            this.lblCodeSexe.Name = "lblCodeSexe";
            this.lblCodeSexe.Size = new System.Drawing.Size(173, 47);
            this.lblCodeSexe.TabIndex = 2;
            this.lblCodeSexe.Text = "Sexe (M ou F)";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNom.Location = new System.Drawing.Point(3, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(173, 47);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.tblDonneesDuVoyageur.SetColumnSpan(this.txtNom, 3);
            this.txtNom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNom.Location = new System.Drawing.Point(182, 3);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(531, 26);
            this.txtNom.TabIndex = 1;
            // 
            // tblBoutons
            // 
            this.tblBoutons.ColumnCount = 2;
            this.tblBoutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBoutons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBoutons.Controls.Add(this.btnAfficherStatistiques, 1, 0);
            this.tblBoutons.Controls.Add(this.btnEmettreBillet, 0, 0);
            this.tblBoutons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBoutons.Location = new System.Drawing.Point(3, 225);
            this.tblBoutons.Name = "tblBoutons";
            this.tblBoutons.RowCount = 1;
            this.tblBoutons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblBoutons.Size = new System.Drawing.Size(722, 49);
            this.tblBoutons.TabIndex = 1;
            // 
            // btnAfficherStatistiques
            // 
            this.btnAfficherStatistiques.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAfficherStatistiques.Location = new System.Drawing.Point(364, 3);
            this.btnAfficherStatistiques.Name = "btnAfficherStatistiques";
            this.btnAfficherStatistiques.Size = new System.Drawing.Size(355, 43);
            this.btnAfficherStatistiques.TabIndex = 1;
            this.btnAfficherStatistiques.Text = "Statistiques";
            this.btnAfficherStatistiques.UseVisualStyleBackColor = true;
            this.btnAfficherStatistiques.Click += new System.EventHandler(this.btnAfficherStatistiques_Click);
            // 
            // btnEmettreBillet
            // 
            this.btnEmettreBillet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEmettreBillet.Location = new System.Drawing.Point(3, 3);
            this.btnEmettreBillet.Name = "btnEmettreBillet";
            this.btnEmettreBillet.Size = new System.Drawing.Size(355, 43);
            this.btnEmettreBillet.TabIndex = 0;
            this.btnEmettreBillet.Text = "Emission du billet";
            this.btnEmettreBillet.UseVisualStyleBackColor = true;
            this.btnEmettreBillet.Click += new System.EventHandler(this.btnEmettreBillet_Click);
            // 
            // tblBilletEmis
            // 
            this.tblBilletEmis.ColumnCount = 4;
            this.tblBilletEmis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBilletEmis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBilletEmis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBilletEmis.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblBilletEmis.Controls.Add(this.lblUnitePrixBillet, 3, 2);
            this.tblBilletEmis.Controls.Add(this.lblPrixBillet, 2, 2);
            this.tblBilletEmis.Controls.Add(this.lblAnoncePrixBillet, 0, 2);
            this.tblBilletEmis.Controls.Add(this.lblItineraire, 0, 1);
            this.tblBilletEmis.Controls.Add(this.lblFormulePolitesse, 0, 0);
            this.tblBilletEmis.Controls.Add(this.lblNomDuVoyageur, 1, 0);
            this.tblBilletEmis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblBilletEmis.Location = new System.Drawing.Point(3, 280);
            this.tblBilletEmis.Name = "tblBilletEmis";
            this.tblBilletEmis.RowCount = 3;
            this.tblBilletEmis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBilletEmis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBilletEmis.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblBilletEmis.Size = new System.Drawing.Size(722, 161);
            this.tblBilletEmis.TabIndex = 2;
            // 
            // lblUnitePrixBillet
            // 
            this.lblUnitePrixBillet.AutoSize = true;
            this.lblUnitePrixBillet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUnitePrixBillet.Location = new System.Drawing.Point(543, 106);
            this.lblUnitePrixBillet.Name = "lblUnitePrixBillet";
            this.lblUnitePrixBillet.Size = new System.Drawing.Size(176, 55);
            this.lblUnitePrixBillet.TabIndex = 6;
            this.lblUnitePrixBillet.Text = "$";
            // 
            // lblPrixBillet
            // 
            this.lblPrixBillet.AutoSize = true;
            this.lblPrixBillet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrixBillet.Location = new System.Drawing.Point(363, 106);
            this.lblPrixBillet.Name = "lblPrixBillet";
            this.lblPrixBillet.Size = new System.Drawing.Size(174, 55);
            this.lblPrixBillet.TabIndex = 5;
            // 
            // lblAnoncePrixBillet
            // 
            this.lblAnoncePrixBillet.AutoSize = true;
            this.tblBilletEmis.SetColumnSpan(this.lblAnoncePrixBillet, 2);
            this.lblAnoncePrixBillet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnoncePrixBillet.Location = new System.Drawing.Point(3, 106);
            this.lblAnoncePrixBillet.Name = "lblAnoncePrixBillet";
            this.lblAnoncePrixBillet.Size = new System.Drawing.Size(354, 55);
            this.lblAnoncePrixBillet.TabIndex = 4;
            this.lblAnoncePrixBillet.Text = "Prix du billet";
            // 
            // lblItineraire
            // 
            this.lblItineraire.AutoSize = true;
            this.tblBilletEmis.SetColumnSpan(this.lblItineraire, 4);
            this.lblItineraire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItineraire.Location = new System.Drawing.Point(3, 53);
            this.lblItineraire.Name = "lblItineraire";
            this.lblItineraire.Size = new System.Drawing.Size(716, 53);
            this.lblItineraire.TabIndex = 3;
            // 
            // lblFormulePolitesse
            // 
            this.lblFormulePolitesse.AutoSize = true;
            this.lblFormulePolitesse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormulePolitesse.Location = new System.Drawing.Point(3, 0);
            this.lblFormulePolitesse.Name = "lblFormulePolitesse";
            this.lblFormulePolitesse.Size = new System.Drawing.Size(174, 53);
            this.lblFormulePolitesse.TabIndex = 1;
            // 
            // lblNomDuVoyageur
            // 
            this.lblNomDuVoyageur.AutoSize = true;
            this.tblBilletEmis.SetColumnSpan(this.lblNomDuVoyageur, 3);
            this.lblNomDuVoyageur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNomDuVoyageur.Location = new System.Drawing.Point(183, 0);
            this.lblNomDuVoyageur.Name = "lblNomDuVoyageur";
            this.lblNomDuVoyageur.Size = new System.Drawing.Size(536, 53);
            this.lblNomDuVoyageur.TabIndex = 2;
            // 
            // gbStatistiques
            // 
            this.gbStatistiques.Controls.Add(this.tblStatistiques);
            this.gbStatistiques.Location = new System.Drawing.Point(-1, -1);
            this.gbStatistiques.Name = "gbStatistiques";
            this.gbStatistiques.Size = new System.Drawing.Size(728, 444);
            this.gbStatistiques.TabIndex = 5;
            this.gbStatistiques.TabStop = false;
            this.gbStatistiques.Text = "Statistiques";
            this.gbStatistiques.Visible = false;
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
            // frmBillet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 444);
            this.Controls.Add(this.tblPrincipal);
            this.MaximumSize = new System.Drawing.Size(750, 500);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "frmBillet";
            this.Text = "Aérodrome Pout Pout";
            this.tblPrincipal.ResumeLayout(false);
            this.gbDonneesDuVoyageur.ResumeLayout(false);
            this.tblDonneesDuVoyageur.ResumeLayout(false);
            this.tblDonneesDuVoyageur.PerformLayout();
            this.tblBoutons.ResumeLayout(false);
            this.tblBilletEmis.ResumeLayout(false);
            this.tblBilletEmis.PerformLayout();
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

        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.GroupBox gbDonneesDuVoyageur;
        private System.Windows.Forms.TableLayoutPanel tblDonneesDuVoyageur;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCodeSexe;
        private System.Windows.Forms.Label lblCodeSexe;
        private System.Windows.Forms.Label lblPoidsBagagesEnKilos;
        private System.Windows.Forms.TextBox txtCodeDestination;
        private System.Windows.Forms.Label lblCodeDestination;
        private System.Windows.Forms.TextBox txtCodeStatutCivil;
        private System.Windows.Forms.Label lblCodeStatutCivil;
        private System.Windows.Forms.TextBox txtPoidsBagagesEnKilos;
        private System.Windows.Forms.TableLayoutPanel tblBoutons;
        private System.Windows.Forms.Button btnAfficherStatistiques;
        private System.Windows.Forms.Button btnEmettreBillet;
        private System.Windows.Forms.TableLayoutPanel tblBilletEmis;
        private System.Windows.Forms.Label lblFormulePolitesse;
        private System.Windows.Forms.Label lblNomDuVoyageur;
        private System.Windows.Forms.Label lblUnitePrixBillet;
        private System.Windows.Forms.Label lblPrixBillet;
        private System.Windows.Forms.Label lblAnoncePrixBillet;
        private System.Windows.Forms.Label lblItineraire;
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

