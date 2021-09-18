
namespace MiniConvertisseur
{
    partial class MiniConvertisseur
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
            this.lblMontantAConvertir = new System.Windows.Forms.Label();
            this.lblDeviseMontantAConvertir = new System.Windows.Forms.Label();
            this.grbChange = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbUSA = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.rdbJapon = new System.Windows.Forms.RadioButton();
            this.rdbColombie = new System.Windows.Forms.RadioButton();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblMontantConverti = new System.Windows.Forms.Label();
            this.lblDeviseMontantConverti = new System.Windows.Forms.Label();
            this.txtMontantAConvertir = new System.Windows.Forms.TextBox();
            this.tblPrincipal.SuspendLayout();
            this.grbChange.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPrincipal
            // 
            this.tblPrincipal.ColumnCount = 6;
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblPrincipal.Controls.Add(this.lblMontantAConvertir, 1, 1);
            this.tblPrincipal.Controls.Add(this.lblDeviseMontantAConvertir, 4, 1);
            this.tblPrincipal.Controls.Add(this.grbChange, 1, 3);
            this.tblPrincipal.Controls.Add(this.btnConvertir, 1, 5);
            this.tblPrincipal.Controls.Add(this.lblMontantConverti, 3, 5);
            this.tblPrincipal.Controls.Add(this.lblDeviseMontantConverti, 4, 5);
            this.tblPrincipal.Controls.Add(this.txtMontantAConvertir, 3, 1);
            this.tblPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tblPrincipal.Name = "tblPrincipal";
            this.tblPrincipal.RowCount = 7;
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tblPrincipal.Size = new System.Drawing.Size(1088, 465);
            this.tblPrincipal.TabIndex = 0;
            // 
            // lblMontantAConvertir
            // 
            this.lblMontantAConvertir.AutoSize = true;
            this.tblPrincipal.SetColumnSpan(this.lblMontantAConvertir, 2);
            this.lblMontantAConvertir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMontantAConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantAConvertir.Location = new System.Drawing.Point(184, 66);
            this.lblMontantAConvertir.Name = "lblMontantAConvertir";
            this.lblMontantAConvertir.Size = new System.Drawing.Size(356, 66);
            this.lblMontantAConvertir.TabIndex = 0;
            this.lblMontantAConvertir.Text = "Entrer un montant CAN:";
            // 
            // lblDeviseMontantAConvertir
            // 
            this.lblDeviseMontantAConvertir.AutoSize = true;
            this.lblDeviseMontantAConvertir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeviseMontantAConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviseMontantAConvertir.Location = new System.Drawing.Point(727, 66);
            this.lblDeviseMontantAConvertir.Name = "lblDeviseMontantAConvertir";
            this.lblDeviseMontantAConvertir.Size = new System.Drawing.Size(175, 66);
            this.lblDeviseMontantAConvertir.TabIndex = 1;
            this.lblDeviseMontantAConvertir.Text = "$";
            this.lblDeviseMontantAConvertir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grbChange
            // 
            this.tblPrincipal.SetColumnSpan(this.grbChange, 4);
            this.grbChange.Controls.Add(this.tableLayoutPanel1);
            this.grbChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbChange.Location = new System.Drawing.Point(184, 201);
            this.grbChange.Name = "grbChange";
            this.grbChange.Size = new System.Drawing.Size(718, 60);
            this.grbChange.TabIndex = 2;
            this.grbChange.TabStop = false;
            this.grbChange.Text = "Change";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.rdbUSA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdbEuro, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdbJapon, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdbColombie, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(712, 39);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // rdbUSA
            // 
            this.rdbUSA.AutoSize = true;
            this.rdbUSA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbUSA.Location = new System.Drawing.Point(3, 3);
            this.rdbUSA.Name = "rdbUSA";
            this.rdbUSA.Size = new System.Drawing.Size(172, 33);
            this.rdbUSA.TabIndex = 0;
            this.rdbUSA.TabStop = true;
            this.rdbUSA.Text = "USA";
            this.rdbUSA.UseVisualStyleBackColor = true;
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbEuro.Location = new System.Drawing.Point(181, 3);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(172, 33);
            this.rdbEuro.TabIndex = 1;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "EURO";
            this.rdbEuro.UseVisualStyleBackColor = true;
            // 
            // rdbJapon
            // 
            this.rdbJapon.AutoSize = true;
            this.rdbJapon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbJapon.Location = new System.Drawing.Point(359, 3);
            this.rdbJapon.Name = "rdbJapon";
            this.rdbJapon.Size = new System.Drawing.Size(172, 33);
            this.rdbJapon.TabIndex = 2;
            this.rdbJapon.TabStop = true;
            this.rdbJapon.Text = "JAPON";
            this.rdbJapon.UseVisualStyleBackColor = true;
            // 
            // rdbColombie
            // 
            this.rdbColombie.AutoSize = true;
            this.rdbColombie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdbColombie.Location = new System.Drawing.Point(537, 3);
            this.rdbColombie.Name = "rdbColombie";
            this.rdbColombie.Size = new System.Drawing.Size(172, 33);
            this.rdbColombie.TabIndex = 3;
            this.rdbColombie.TabStop = true;
            this.rdbColombie.Text = "COLOMBIE";
            this.rdbColombie.UseVisualStyleBackColor = true;
            // 
            // btnConvertir
            // 
            this.tblPrincipal.SetColumnSpan(this.btnConvertir, 2);
            this.btnConvertir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Location = new System.Drawing.Point(184, 333);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(356, 60);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblMontantConverti
            // 
            this.lblMontantConverti.AutoSize = true;
            this.lblMontantConverti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMontantConverti.Location = new System.Drawing.Point(546, 330);
            this.lblMontantConverti.Name = "lblMontantConverti";
            this.lblMontantConverti.Size = new System.Drawing.Size(175, 66);
            this.lblMontantConverti.TabIndex = 4;
            this.lblMontantConverti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeviseMontantConverti
            // 
            this.lblDeviseMontantConverti.AutoSize = true;
            this.lblDeviseMontantConverti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeviseMontantConverti.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeviseMontantConverti.Location = new System.Drawing.Point(727, 330);
            this.lblDeviseMontantConverti.Name = "lblDeviseMontantConverti";
            this.lblDeviseMontantConverti.Size = new System.Drawing.Size(175, 66);
            this.lblDeviseMontantConverti.TabIndex = 5;
            this.lblDeviseMontantConverti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMontantAConvertir
            // 
            this.txtMontantAConvertir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMontantAConvertir.Location = new System.Drawing.Point(546, 69);
            this.txtMontantAConvertir.Name = "txtMontantAConvertir";
            this.txtMontantAConvertir.Size = new System.Drawing.Size(175, 22);
            this.txtMontantAConvertir.TabIndex = 6;
            this.txtMontantAConvertir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MiniConvertisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 465);
            this.Controls.Add(this.tblPrincipal);
            this.Name = "MiniConvertisseur";
            this.Text = "Mini Convertisseur de Monnaie";
            this.tblPrincipal.ResumeLayout(false);
            this.tblPrincipal.PerformLayout();
            this.grbChange.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPrincipal;
        private System.Windows.Forms.Label lblMontantAConvertir;
        private System.Windows.Forms.Label lblDeviseMontantAConvertir;
        private System.Windows.Forms.GroupBox grbChange;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton rdbUSA;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.RadioButton rdbJapon;
        private System.Windows.Forms.RadioButton rdbColombie;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblMontantConverti;
        private System.Windows.Forms.Label lblDeviseMontantConverti;
        private System.Windows.Forms.TextBox txtMontantAConvertir;
    }
}

