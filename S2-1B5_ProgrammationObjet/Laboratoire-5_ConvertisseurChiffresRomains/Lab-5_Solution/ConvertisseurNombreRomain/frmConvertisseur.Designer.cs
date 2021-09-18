
namespace ConvertisseurNombreRomain
{
    partial class frmConvertisseur
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
            this.tblEntreeBtnEtSortie = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombreDecimal = new System.Windows.Forms.Label();
            this.txtNombreDecimal = new System.Windows.Forms.TextBox();
            this.btnConvertirDecimalEnRomain = new System.Windows.Forms.Button();
            this.lblNombreRomain = new System.Windows.Forms.Label();
            this.txtNombreRomain = new System.Windows.Forms.TextBox();
            this.tblEntreeBtnEtSortie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblEntreeBtnEtSortie
            // 
            this.tblEntreeBtnEtSortie.ColumnCount = 6;
            this.tblEntreeBtnEtSortie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.405406F));
            this.tblEntreeBtnEtSortie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62162F));
            this.tblEntreeBtnEtSortie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.54054F));
            this.tblEntreeBtnEtSortie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.405406F));
            this.tblEntreeBtnEtSortie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62162F));
            this.tblEntreeBtnEtSortie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.405406F));
            this.tblEntreeBtnEtSortie.Controls.Add(this.lblNombreDecimal, 1, 1);
            this.tblEntreeBtnEtSortie.Controls.Add(this.txtNombreDecimal, 2, 1);
            this.tblEntreeBtnEtSortie.Controls.Add(this.btnConvertirDecimalEnRomain, 4, 1);
            this.tblEntreeBtnEtSortie.Controls.Add(this.lblNombreRomain, 1, 3);
            this.tblEntreeBtnEtSortie.Controls.Add(this.txtNombreRomain, 2, 3);
            this.tblEntreeBtnEtSortie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEntreeBtnEtSortie.Location = new System.Drawing.Point(0, 0);
            this.tblEntreeBtnEtSortie.Name = "tblEntreeBtnEtSortie";
            this.tblEntreeBtnEtSortie.RowCount = 5;
            this.tblEntreeBtnEtSortie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15812F));
            this.tblEntreeBtnEtSortie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.26281F));
            this.tblEntreeBtnEtSortie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15812F));
            this.tblEntreeBtnEtSortie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.26281F));
            this.tblEntreeBtnEtSortie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15812F));
            this.tblEntreeBtnEtSortie.Size = new System.Drawing.Size(782, 161);
            this.tblEntreeBtnEtSortie.TabIndex = 0;
            // 
            // lblNombreDecimal
            // 
            this.lblNombreDecimal.AutoSize = true;
            this.lblNombreDecimal.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreDecimal.Location = new System.Drawing.Point(45, 27);
            this.lblNombreDecimal.Margin = new System.Windows.Forms.Padding(3);
            this.lblNombreDecimal.Name = "lblNombreDecimal";
            this.lblNombreDecimal.Size = new System.Drawing.Size(163, 17);
            this.lblNombreDecimal.TabIndex = 0;
            this.lblNombreDecimal.Text = "Nombre Decimal :";
            // 
            // txtNombreDecimal
            // 
            this.txtNombreDecimal.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombreDecimal.Location = new System.Drawing.Point(214, 27);
            this.txtNombreDecimal.Name = "txtNombreDecimal";
            this.txtNombreDecimal.Size = new System.Drawing.Size(311, 22);
            this.txtNombreDecimal.TabIndex = 1;
            this.txtNombreDecimal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConvertirDecimalEnRomain
            // 
            this.btnConvertirDecimalEnRomain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConvertirDecimalEnRomain.Location = new System.Drawing.Point(573, 27);
            this.btnConvertirDecimalEnRomain.Name = "btnConvertirDecimalEnRomain";
            this.tblEntreeBtnEtSortie.SetRowSpan(this.btnConvertirDecimalEnRomain, 3);
            this.btnConvertirDecimalEnRomain.Size = new System.Drawing.Size(163, 104);
            this.btnConvertirDecimalEnRomain.TabIndex = 2;
            this.btnConvertirDecimalEnRomain.Text = "Convertir";
            this.btnConvertirDecimalEnRomain.UseVisualStyleBackColor = true;
            this.btnConvertirDecimalEnRomain.Click += new System.EventHandler(this.btnConvertirDecimalEnRomain_Click);
            // 
            // lblNombreRomain
            // 
            this.lblNombreRomain.AutoSize = true;
            this.lblNombreRomain.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNombreRomain.Location = new System.Drawing.Point(45, 94);
            this.lblNombreRomain.Margin = new System.Windows.Forms.Padding(3);
            this.lblNombreRomain.Name = "lblNombreRomain";
            this.lblNombreRomain.Size = new System.Drawing.Size(163, 17);
            this.lblNombreRomain.TabIndex = 3;
            this.lblNombreRomain.Text = "Nombre Romain :";
            // 
            // txtNombreRomain
            // 
            this.txtNombreRomain.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNombreRomain.Location = new System.Drawing.Point(214, 94);
            this.txtNombreRomain.Name = "txtNombreRomain";
            this.txtNombreRomain.ReadOnly = true;
            this.txtNombreRomain.Size = new System.Drawing.Size(311, 22);
            this.txtNombreRomain.TabIndex = 4;
            this.txtNombreRomain.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmConvertisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 161);
            this.Controls.Add(this.tblEntreeBtnEtSortie);
            this.Name = "frmConvertisseur";
            this.Text = "Convertisseur de nombre Decimal a nombre Romain";
            this.tblEntreeBtnEtSortie.ResumeLayout(false);
            this.tblEntreeBtnEtSortie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblEntreeBtnEtSortie;
        private System.Windows.Forms.Label lblNombreDecimal;
        private System.Windows.Forms.TextBox txtNombreDecimal;
        private System.Windows.Forms.Button btnConvertirDecimalEnRomain;
        private System.Windows.Forms.Label lblNombreRomain;
        private System.Windows.Forms.TextBox txtNombreRomain;
    }
}

