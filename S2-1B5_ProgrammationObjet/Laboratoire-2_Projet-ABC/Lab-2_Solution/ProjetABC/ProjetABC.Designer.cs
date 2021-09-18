
namespace ProjetABC
{
    partial class ProjetABC
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
            this.lblEntreeA = new System.Windows.Forms.Label();
            this.lblEntreeB = new System.Windows.Forms.Label();
            this.txtEntreeA = new System.Windows.Forms.TextBox();
            this.txtEntreeB = new System.Windows.Forms.TextBox();
            this.btnAdditionner = new System.Windows.Forms.Button();
            this.btnSommation = new System.Windows.Forms.Button();
            this.lblSortieC = new System.Windows.Forms.Label();
            this.txtSortieC = new System.Windows.Forms.TextBox();
            this.tblEntreesBtnsEtSorties = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tblEntreesBtnsEtSorties.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEntreeA
            // 
            this.lblEntreeA.AutoSize = true;
            this.tblEntreesBtnsEtSorties.SetColumnSpan(this.lblEntreeA, 2);
            this.lblEntreeA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntreeA.Location = new System.Drawing.Point(115, 0);
            this.lblEntreeA.MinimumSize = new System.Drawing.Size(0, 40);
            this.lblEntreeA.Name = "lblEntreeA";
            this.lblEntreeA.Size = new System.Drawing.Size(218, 58);
            this.lblEntreeA.TabIndex = 0;
            this.lblEntreeA.Text = "A";
            this.lblEntreeA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEntreeB
            // 
            this.lblEntreeB.AutoSize = true;
            this.tblEntreesBtnsEtSorties.SetColumnSpan(this.lblEntreeB, 2);
            this.lblEntreeB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEntreeB.Location = new System.Drawing.Point(563, 0);
            this.lblEntreeB.MinimumSize = new System.Drawing.Size(0, 40);
            this.lblEntreeB.Name = "lblEntreeB";
            this.lblEntreeB.Size = new System.Drawing.Size(218, 58);
            this.lblEntreeB.TabIndex = 1;
            this.lblEntreeB.Text = "B";
            this.lblEntreeB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEntreeA
            // 
            this.tblEntreesBtnsEtSorties.SetColumnSpan(this.txtEntreeA, 2);
            this.txtEntreeA.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEntreeA.Location = new System.Drawing.Point(115, 61);
            this.txtEntreeA.Name = "txtEntreeA";
            this.txtEntreeA.Size = new System.Drawing.Size(218, 22);
            this.txtEntreeA.TabIndex = 2;
            this.txtEntreeA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEntreeB
            // 
            this.tblEntreesBtnsEtSorties.SetColumnSpan(this.txtEntreeB, 2);
            this.txtEntreeB.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtEntreeB.Location = new System.Drawing.Point(563, 61);
            this.txtEntreeB.Name = "txtEntreeB";
            this.txtEntreeB.Size = new System.Drawing.Size(218, 22);
            this.txtEntreeB.TabIndex = 3;
            this.txtEntreeB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdditionner
            // 
            this.tblEntreesBtnsEtSorties.SetColumnSpan(this.btnAdditionner, 3);
            this.btnAdditionner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdditionner.Location = new System.Drawing.Point(115, 120);
            this.btnAdditionner.Name = "btnAdditionner";
            this.btnAdditionner.Size = new System.Drawing.Size(330, 53);
            this.btnAdditionner.TabIndex = 4;
            this.btnAdditionner.Text = "Additionner";
            this.btnAdditionner.UseVisualStyleBackColor = true;
            this.btnAdditionner.Click += new System.EventHandler(this.btnAdditionner_Click);
            // 
            // btnSommation
            // 
            this.tblEntreesBtnsEtSorties.SetColumnSpan(this.btnSommation, 3);
            this.btnSommation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSommation.Location = new System.Drawing.Point(451, 120);
            this.btnSommation.Name = "btnSommation";
            this.btnSommation.Size = new System.Drawing.Size(330, 53);
            this.btnSommation.TabIndex = 5;
            this.btnSommation.Text = "Sommation";
            this.btnSommation.UseVisualStyleBackColor = true;
            this.btnSommation.Click += new System.EventHandler(this.btnSommation_Click);
            // 
            // lblSortieC
            // 
            this.lblSortieC.AutoSize = true;
            this.tblEntreesBtnsEtSorties.SetColumnSpan(this.lblSortieC, 2);
            this.lblSortieC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSortieC.Location = new System.Drawing.Point(339, 176);
            this.lblSortieC.MinimumSize = new System.Drawing.Size(0, 40);
            this.lblSortieC.Name = "lblSortieC";
            this.lblSortieC.Size = new System.Drawing.Size(218, 59);
            this.lblSortieC.TabIndex = 6;
            this.lblSortieC.Text = "C";
            this.lblSortieC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSortieC
            // 
            this.tblEntreesBtnsEtSorties.SetColumnSpan(this.txtSortieC, 2);
            this.txtSortieC.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSortieC.Location = new System.Drawing.Point(339, 238);
            this.txtSortieC.Name = "txtSortieC";
            this.txtSortieC.ReadOnly = true;
            this.txtSortieC.Size = new System.Drawing.Size(218, 22);
            this.txtSortieC.TabIndex = 7;
            this.txtSortieC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tblEntreesBtnsEtSorties
            // 
            this.tblEntreesBtnsEtSorties.ColumnCount = 8;
            this.tblEntreesBtnsEtSorties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEntreesBtnsEtSorties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEntreesBtnsEtSorties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEntreesBtnsEtSorties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEntreesBtnsEtSorties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEntreesBtnsEtSorties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEntreesBtnsEtSorties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEntreesBtnsEtSorties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblEntreesBtnsEtSorties.Controls.Add(this.lblEntreeA, 1, 0);
            this.tblEntreesBtnsEtSorties.Controls.Add(this.txtSortieC, 3, 4);
            this.tblEntreesBtnsEtSorties.Controls.Add(this.txtEntreeA, 1, 1);
            this.tblEntreesBtnsEtSorties.Controls.Add(this.lblSortieC, 3, 3);
            this.tblEntreesBtnsEtSorties.Controls.Add(this.btnSommation, 4, 2);
            this.tblEntreesBtnsEtSorties.Controls.Add(this.txtEntreeB, 5, 1);
            this.tblEntreesBtnsEtSorties.Controls.Add(this.lblEntreeB, 5, 0);
            this.tblEntreesBtnsEtSorties.Controls.Add(this.btnAdditionner, 1, 2);
            this.tblEntreesBtnsEtSorties.Controls.Add(this.lblMessage, 3, 5);
            this.tblEntreesBtnsEtSorties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblEntreesBtnsEtSorties.Location = new System.Drawing.Point(0, 0);
            this.tblEntreesBtnsEtSorties.Name = "tblEntreesBtnsEtSorties";
            this.tblEntreesBtnsEtSorties.RowCount = 6;
            this.tblEntreesBtnsEtSorties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tblEntreesBtnsEtSorties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblEntreesBtnsEtSorties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblEntreesBtnsEtSorties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblEntreesBtnsEtSorties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblEntreesBtnsEtSorties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tblEntreesBtnsEtSorties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblEntreesBtnsEtSorties.Size = new System.Drawing.Size(899, 354);
            this.tblEntreesBtnsEtSorties.TabIndex = 8;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.tblEntreesBtnsEtSorties.SetColumnSpan(this.lblMessage, 2);
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Location = new System.Drawing.Point(339, 294);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(218, 60);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjetABC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 354);
            this.Controls.Add(this.tblEntreesBtnsEtSorties);
            this.Name = "ProjetABC";
            this.Text = "Projet ABC - Jeremie Normand";
            this.tblEntreesBtnsEtSorties.ResumeLayout(false);
            this.tblEntreesBtnsEtSorties.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEntreeA;
        private System.Windows.Forms.TableLayoutPanel tblEntreesBtnsEtSorties;
        private System.Windows.Forms.TextBox txtSortieC;
        private System.Windows.Forms.TextBox txtEntreeA;
        private System.Windows.Forms.Label lblSortieC;
        private System.Windows.Forms.Button btnSommation;
        private System.Windows.Forms.Button btnAdditionner;
        private System.Windows.Forms.TextBox txtEntreeB;
        private System.Windows.Forms.Label lblEntreeB;
        private System.Windows.Forms.Label lblMessage;
    }
}

