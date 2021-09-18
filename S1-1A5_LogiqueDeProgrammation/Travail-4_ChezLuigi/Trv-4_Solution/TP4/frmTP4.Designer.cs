namespace TP4
{
    partial class frmTP4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTP4));
            this.tblPrincipale = new System.Windows.Forms.TableLayoutPanel();
            this.txtArgentCaisse = new System.Windows.Forms.TextBox();
            this.lblArgentCaisse = new System.Windows.Forms.Label();
            this.grbNombrePizzasVendues = new System.Windows.Forms.GroupBox();
            this.tblNombrePizzasVendues = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombrePizzasLarges = new System.Windows.Forms.Label();
            this.txtNombrePizzasMediums = new System.Windows.Forms.TextBox();
            this.lblNombrePizzasMediums = new System.Windows.Forms.Label();
            this.lblNombrePizzasPetites = new System.Windows.Forms.Label();
            this.txtNombrePizzasPetites = new System.Windows.Forms.TextBox();
            this.txtNombrePizzasLarges = new System.Windows.Forms.TextBox();
            this.btnConfirmerVente = new System.Windows.Forms.Button();
            this.txtPrixVentePizza = new System.Windows.Forms.TextBox();
            this.lblPrixVentePizza = new System.Windows.Forms.Label();
            this.grbCriteresPizza = new System.Windows.Forms.GroupBox();
            this.tblCriteresPizza = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombreExtras = new System.Windows.Forms.TextBox();
            this.lblNombreExtras = new System.Windows.Forms.Label();
            this.lblDiametrePizzaEnPouces = new System.Windows.Forms.Label();
            this.txtDiametrePizzaEnPouces = new System.Windows.Forms.TextBox();
            this.btnCalculerPrixVentePizza = new System.Windows.Forms.Button();
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.tblPrincipale.SuspendLayout();
            this.grbNombrePizzasVendues.SuspendLayout();
            this.tblNombrePizzasVendues.SuspendLayout();
            this.grbCriteresPizza.SuspendLayout();
            this.tblCriteresPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPrincipale
            // 
            this.tblPrincipale.ColumnCount = 2;
            this.tblPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipale.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrincipale.Controls.Add(this.txtArgentCaisse, 1, 6);
            this.tblPrincipale.Controls.Add(this.lblArgentCaisse, 0, 6);
            this.tblPrincipale.Controls.Add(this.grbNombrePizzasVendues, 0, 5);
            this.tblPrincipale.Controls.Add(this.btnConfirmerVente, 0, 4);
            this.tblPrincipale.Controls.Add(this.txtPrixVentePizza, 1, 3);
            this.tblPrincipale.Controls.Add(this.lblPrixVentePizza, 0, 3);
            this.tblPrincipale.Controls.Add(this.grbCriteresPizza, 0, 1);
            this.tblPrincipale.Controls.Add(this.btnCalculerPrixVentePizza, 0, 2);
            this.tblPrincipale.Controls.Add(this.pcbLogo, 0, 0);
            this.tblPrincipale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipale.Location = new System.Drawing.Point(0, 0);
            this.tblPrincipale.Margin = new System.Windows.Forms.Padding(15);
            this.tblPrincipale.Name = "tblPrincipale";
            this.tblPrincipale.Padding = new System.Windows.Forms.Padding(10);
            this.tblPrincipale.RowCount = 7;
            this.tblPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92639F));
            this.tblPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.5184F));
            this.tblPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407361F));
            this.tblPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407361F));
            this.tblPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407361F));
            this.tblPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.92576F));
            this.tblPrincipale.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.407361F));
            this.tblPrincipale.Size = new System.Drawing.Size(434, 511);
            this.tblPrincipale.TabIndex = 0;
            // 
            // txtArgentCaisse
            // 
            this.txtArgentCaisse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtArgentCaisse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArgentCaisse.ForeColor = System.Drawing.Color.DimGray;
            this.txtArgentCaisse.Location = new System.Drawing.Point(220, 465);
            this.txtArgentCaisse.Name = "txtArgentCaisse";
            this.txtArgentCaisse.ReadOnly = true;
            this.txtArgentCaisse.Size = new System.Drawing.Size(201, 22);
            this.txtArgentCaisse.TabIndex = 8;
            this.txtArgentCaisse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblArgentCaisse
            // 
            this.lblArgentCaisse.AutoSize = true;
            this.lblArgentCaisse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArgentCaisse.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArgentCaisse.ForeColor = System.Drawing.Color.White;
            this.lblArgentCaisse.Location = new System.Drawing.Point(13, 462);
            this.lblArgentCaisse.Name = "lblArgentCaisse";
            this.lblArgentCaisse.Size = new System.Drawing.Size(201, 39);
            this.lblArgentCaisse.TabIndex = 7;
            this.lblArgentCaisse.Text = "Argent en caisse";
            // 
            // grbNombrePizzasVendues
            // 
            this.tblPrincipale.SetColumnSpan(this.grbNombrePizzasVendues, 2);
            this.grbNombrePizzasVendues.Controls.Add(this.tblNombrePizzasVendues);
            this.grbNombrePizzasVendues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbNombrePizzasVendues.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNombrePizzasVendues.ForeColor = System.Drawing.Color.White;
            this.grbNombrePizzasVendues.Location = new System.Drawing.Point(13, 338);
            this.grbNombrePizzasVendues.Name = "grbNombrePizzasVendues";
            this.grbNombrePizzasVendues.Size = new System.Drawing.Size(408, 121);
            this.grbNombrePizzasVendues.TabIndex = 6;
            this.grbNombrePizzasVendues.TabStop = false;
            this.grbNombrePizzasVendues.Text = "Nombre de pizzas vendues";
            // 
            // tblNombrePizzasVendues
            // 
            this.tblNombrePizzasVendues.ColumnCount = 2;
            this.tblNombrePizzasVendues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNombrePizzasVendues.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblNombrePizzasVendues.Controls.Add(this.lblNombrePizzasLarges, 0, 2);
            this.tblNombrePizzasVendues.Controls.Add(this.txtNombrePizzasMediums, 1, 1);
            this.tblNombrePizzasVendues.Controls.Add(this.lblNombrePizzasMediums, 0, 1);
            this.tblNombrePizzasVendues.Controls.Add(this.lblNombrePizzasPetites, 0, 0);
            this.tblNombrePizzasVendues.Controls.Add(this.txtNombrePizzasPetites, 1, 0);
            this.tblNombrePizzasVendues.Controls.Add(this.txtNombrePizzasLarges, 1, 2);
            this.tblNombrePizzasVendues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblNombrePizzasVendues.Location = new System.Drawing.Point(3, 18);
            this.tblNombrePizzasVendues.Name = "tblNombrePizzasVendues";
            this.tblNombrePizzasVendues.RowCount = 3;
            this.tblNombrePizzasVendues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblNombrePizzasVendues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblNombrePizzasVendues.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblNombrePizzasVendues.Size = new System.Drawing.Size(402, 100);
            this.tblNombrePizzasVendues.TabIndex = 0;
            // 
            // lblNombrePizzasLarges
            // 
            this.lblNombrePizzasLarges.AutoSize = true;
            this.lblNombrePizzasLarges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombrePizzasLarges.Location = new System.Drawing.Point(3, 66);
            this.lblNombrePizzasLarges.Name = "lblNombrePizzasLarges";
            this.lblNombrePizzasLarges.Size = new System.Drawing.Size(195, 34);
            this.lblNombrePizzasLarges.TabIndex = 4;
            this.lblNombrePizzasLarges.Text = "Larges";
            // 
            // txtNombrePizzasMediums
            // 
            this.txtNombrePizzasMediums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombrePizzasMediums.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombrePizzasMediums.Location = new System.Drawing.Point(204, 36);
            this.txtNombrePizzasMediums.Name = "txtNombrePizzasMediums";
            this.txtNombrePizzasMediums.ReadOnly = true;
            this.txtNombrePizzasMediums.Size = new System.Drawing.Size(195, 22);
            this.txtNombrePizzasMediums.TabIndex = 3;
            this.txtNombrePizzasMediums.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombrePizzasMediums
            // 
            this.lblNombrePizzasMediums.AutoSize = true;
            this.lblNombrePizzasMediums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombrePizzasMediums.Location = new System.Drawing.Point(3, 33);
            this.lblNombrePizzasMediums.Name = "lblNombrePizzasMediums";
            this.lblNombrePizzasMediums.Size = new System.Drawing.Size(195, 33);
            this.lblNombrePizzasMediums.TabIndex = 2;
            this.lblNombrePizzasMediums.Text = "Mediums";
            // 
            // lblNombrePizzasPetites
            // 
            this.lblNombrePizzasPetites.AutoSize = true;
            this.lblNombrePizzasPetites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombrePizzasPetites.Location = new System.Drawing.Point(3, 0);
            this.lblNombrePizzasPetites.Name = "lblNombrePizzasPetites";
            this.lblNombrePizzasPetites.Size = new System.Drawing.Size(195, 33);
            this.lblNombrePizzasPetites.TabIndex = 0;
            this.lblNombrePizzasPetites.Text = "Petites";
            // 
            // txtNombrePizzasPetites
            // 
            this.txtNombrePizzasPetites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombrePizzasPetites.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombrePizzasPetites.Location = new System.Drawing.Point(204, 3);
            this.txtNombrePizzasPetites.Name = "txtNombrePizzasPetites";
            this.txtNombrePizzasPetites.ReadOnly = true;
            this.txtNombrePizzasPetites.Size = new System.Drawing.Size(195, 22);
            this.txtNombrePizzasPetites.TabIndex = 1;
            this.txtNombrePizzasPetites.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombrePizzasLarges
            // 
            this.txtNombrePizzasLarges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombrePizzasLarges.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombrePizzasLarges.Location = new System.Drawing.Point(204, 69);
            this.txtNombrePizzasLarges.Name = "txtNombrePizzasLarges";
            this.txtNombrePizzasLarges.ReadOnly = true;
            this.txtNombrePizzasLarges.Size = new System.Drawing.Size(195, 22);
            this.txtNombrePizzasLarges.TabIndex = 5;
            this.txtNombrePizzasLarges.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirmerVente
            // 
            this.btnConfirmerVente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmerVente.BackgroundImage")));
            this.tblPrincipale.SetColumnSpan(this.btnConfirmerVente, 2);
            this.btnConfirmerVente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmerVente.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmerVente.ForeColor = System.Drawing.Color.White;
            this.btnConfirmerVente.Location = new System.Drawing.Point(13, 302);
            this.btnConfirmerVente.Name = "btnConfirmerVente";
            this.btnConfirmerVente.Size = new System.Drawing.Size(408, 30);
            this.btnConfirmerVente.TabIndex = 5;
            this.btnConfirmerVente.Text = "Confirmer la vente";
            this.btnConfirmerVente.UseVisualStyleBackColor = true;
            this.btnConfirmerVente.Click += new System.EventHandler(this.btnConfirmerVente_Click);
            // 
            // txtPrixVentePizza
            // 
            this.txtPrixVentePizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrixVentePizza.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixVentePizza.ForeColor = System.Drawing.Color.DimGray;
            this.txtPrixVentePizza.Location = new System.Drawing.Point(220, 266);
            this.txtPrixVentePizza.Name = "txtPrixVentePizza";
            this.txtPrixVentePizza.ReadOnly = true;
            this.txtPrixVentePizza.Size = new System.Drawing.Size(201, 22);
            this.txtPrixVentePizza.TabIndex = 4;
            this.txtPrixVentePizza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPrixVentePizza
            // 
            this.lblPrixVentePizza.AutoSize = true;
            this.lblPrixVentePizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrixVentePizza.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixVentePizza.ForeColor = System.Drawing.Color.White;
            this.lblPrixVentePizza.Location = new System.Drawing.Point(13, 263);
            this.lblPrixVentePizza.Name = "lblPrixVentePizza";
            this.lblPrixVentePizza.Size = new System.Drawing.Size(201, 36);
            this.lblPrixVentePizza.TabIndex = 3;
            this.lblPrixVentePizza.Text = "Prix de la pizza";
            // 
            // grbCriteresPizza
            // 
            this.tblPrincipale.SetColumnSpan(this.grbCriteresPizza, 2);
            this.grbCriteresPizza.Controls.Add(this.tblCriteresPizza);
            this.grbCriteresPizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbCriteresPizza.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCriteresPizza.ForeColor = System.Drawing.Color.White;
            this.grbCriteresPizza.Location = new System.Drawing.Point(13, 140);
            this.grbCriteresPizza.Name = "grbCriteresPizza";
            this.grbCriteresPizza.Size = new System.Drawing.Size(408, 84);
            this.grbCriteresPizza.TabIndex = 0;
            this.grbCriteresPizza.TabStop = false;
            this.grbCriteresPizza.Text = "Critères de la pizza";
            // 
            // tblCriteresPizza
            // 
            this.tblCriteresPizza.ColumnCount = 2;
            this.tblCriteresPizza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCriteresPizza.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCriteresPizza.Controls.Add(this.txtNombreExtras, 1, 1);
            this.tblCriteresPizza.Controls.Add(this.lblNombreExtras, 0, 1);
            this.tblCriteresPizza.Controls.Add(this.lblDiametrePizzaEnPouces, 0, 0);
            this.tblCriteresPizza.Controls.Add(this.txtDiametrePizzaEnPouces, 1, 0);
            this.tblCriteresPizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblCriteresPizza.Location = new System.Drawing.Point(3, 18);
            this.tblCriteresPizza.Name = "tblCriteresPizza";
            this.tblCriteresPizza.RowCount = 2;
            this.tblCriteresPizza.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCriteresPizza.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblCriteresPizza.Size = new System.Drawing.Size(402, 63);
            this.tblCriteresPizza.TabIndex = 0;
            // 
            // txtNombreExtras
            // 
            this.txtNombreExtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNombreExtras.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombreExtras.Location = new System.Drawing.Point(204, 34);
            this.txtNombreExtras.Name = "txtNombreExtras";
            this.txtNombreExtras.Size = new System.Drawing.Size(195, 22);
            this.txtNombreExtras.TabIndex = 3;
            this.txtNombreExtras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreExtras
            // 
            this.lblNombreExtras.AutoSize = true;
            this.lblNombreExtras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNombreExtras.Location = new System.Drawing.Point(3, 31);
            this.lblNombreExtras.Name = "lblNombreExtras";
            this.lblNombreExtras.Size = new System.Drawing.Size(195, 32);
            this.lblNombreExtras.TabIndex = 2;
            this.lblNombreExtras.Text = "Nombre d\'extras";
            // 
            // lblDiametrePizzaEnPouces
            // 
            this.lblDiametrePizzaEnPouces.AutoSize = true;
            this.lblDiametrePizzaEnPouces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiametrePizzaEnPouces.Location = new System.Drawing.Point(3, 0);
            this.lblDiametrePizzaEnPouces.Name = "lblDiametrePizzaEnPouces";
            this.lblDiametrePizzaEnPouces.Size = new System.Drawing.Size(195, 31);
            this.lblDiametrePizzaEnPouces.TabIndex = 0;
            this.lblDiametrePizzaEnPouces.Text = "Diamètre (pouce)";
            // 
            // txtDiametrePizzaEnPouces
            // 
            this.txtDiametrePizzaEnPouces.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiametrePizzaEnPouces.ForeColor = System.Drawing.Color.DimGray;
            this.txtDiametrePizzaEnPouces.Location = new System.Drawing.Point(204, 3);
            this.txtDiametrePizzaEnPouces.Name = "txtDiametrePizzaEnPouces";
            this.txtDiametrePizzaEnPouces.Size = new System.Drawing.Size(195, 22);
            this.txtDiametrePizzaEnPouces.TabIndex = 1;
            this.txtDiametrePizzaEnPouces.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculerPrixVentePizza
            // 
            this.btnCalculerPrixVentePizza.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculerPrixVentePizza.BackgroundImage")));
            this.tblPrincipale.SetColumnSpan(this.btnCalculerPrixVentePizza, 2);
            this.btnCalculerPrixVentePizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalculerPrixVentePizza.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculerPrixVentePizza.ForeColor = System.Drawing.Color.White;
            this.btnCalculerPrixVentePizza.Location = new System.Drawing.Point(13, 230);
            this.btnCalculerPrixVentePizza.Name = "btnCalculerPrixVentePizza";
            this.btnCalculerPrixVentePizza.Size = new System.Drawing.Size(408, 30);
            this.btnCalculerPrixVentePizza.TabIndex = 1;
            this.btnCalculerPrixVentePizza.Text = "Calculer le prix de vente de la pizza";
            this.btnCalculerPrixVentePizza.UseVisualStyleBackColor = true;
            this.btnCalculerPrixVentePizza.Click += new System.EventHandler(this.btnCalculerPrixVentePizza_Click);
            // 
            // pcbLogo
            // 
            this.tblPrincipale.SetColumnSpan(this.pcbLogo, 2);
            this.pcbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbLogo.Image")));
            this.pcbLogo.Location = new System.Drawing.Point(13, 13);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(408, 121);
            this.pcbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbLogo.TabIndex = 9;
            this.pcbLogo.TabStop = false;
            // 
            // frmTP4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.tblPrincipale);
            this.MaximumSize = new System.Drawing.Size(450, 550);
            this.MinimumSize = new System.Drawing.Size(450, 550);
            this.Name = "frmTP4";
            this.Text = "Gestion des ventes de pizzas de la pizzeria de Luigi";
            this.tblPrincipale.ResumeLayout(false);
            this.tblPrincipale.PerformLayout();
            this.grbNombrePizzasVendues.ResumeLayout(false);
            this.tblNombrePizzasVendues.ResumeLayout(false);
            this.tblNombrePizzasVendues.PerformLayout();
            this.grbCriteresPizza.ResumeLayout(false);
            this.tblCriteresPizza.ResumeLayout(false);
            this.tblCriteresPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPrincipale;
        private System.Windows.Forms.TextBox txtArgentCaisse;
        private System.Windows.Forms.Label lblArgentCaisse;
        private System.Windows.Forms.GroupBox grbNombrePizzasVendues;
        private System.Windows.Forms.TableLayoutPanel tblNombrePizzasVendues;
        private System.Windows.Forms.Label lblNombrePizzasLarges;
        private System.Windows.Forms.TextBox txtNombrePizzasMediums;
        private System.Windows.Forms.Label lblNombrePizzasMediums;
        private System.Windows.Forms.Label lblNombrePizzasPetites;
        private System.Windows.Forms.TextBox txtNombrePizzasPetites;
        private System.Windows.Forms.TextBox txtNombrePizzasLarges;
        private System.Windows.Forms.Button btnConfirmerVente;
        private System.Windows.Forms.TextBox txtPrixVentePizza;
        private System.Windows.Forms.Label lblPrixVentePizza;
        private System.Windows.Forms.GroupBox grbCriteresPizza;
        private System.Windows.Forms.TableLayoutPanel tblCriteresPizza;
        private System.Windows.Forms.TextBox txtNombreExtras;
        private System.Windows.Forms.Label lblNombreExtras;
        private System.Windows.Forms.Label lblDiametrePizzaEnPouces;
        private System.Windows.Forms.TextBox txtDiametrePizzaEnPouces;
        private System.Windows.Forms.Button btnCalculerPrixVentePizza;
        private System.Windows.Forms.PictureBox pcbLogo;
    }
}

