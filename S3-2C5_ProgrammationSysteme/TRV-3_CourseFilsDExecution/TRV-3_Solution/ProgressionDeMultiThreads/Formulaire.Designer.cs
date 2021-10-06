
namespace ProgressionDeMultiThreads
{
    partial class Formulaire
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
            this.components = new System.ComponentModel.Container();
            this.tblFormulaire = new System.Windows.Forms.TableLayoutPanel();
            this.tblParcours = new System.Windows.Forms.TableLayoutPanel();
            this.pnlParcoursThread3 = new System.Windows.Forms.Panel();
            this.picIndicateurThread3 = new System.Windows.Forms.PictureBox();
            this.pnlParcoursThread2 = new System.Windows.Forms.Panel();
            this.picIndicateurThread2 = new System.Windows.Forms.PictureBox();
            this.tblThread2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblThread2 = new System.Windows.Forms.Label();
            this.lblUniteThread2 = new System.Windows.Forms.Label();
            this.lblLabelThread1 = new System.Windows.Forms.Label();
            this.lblLabelThread2 = new System.Windows.Forms.Label();
            this.lblLabelThread3 = new System.Windows.Forms.Label();
            this.tblThread1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblThread1 = new System.Windows.Forms.Label();
            this.lblUniteThread1 = new System.Windows.Forms.Label();
            this.tblThread3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblThread3 = new System.Windows.Forms.Label();
            this.lblUniteThread3 = new System.Windows.Forms.Label();
            this.pnlParcoursThread1 = new System.Windows.Forms.Panel();
            this.picIndicateurThread1 = new System.Windows.Forms.PictureBox();
            this.tblControles = new System.Windows.Forms.TableLayoutPanel();
            this.btnDemarrerThreads = new System.Windows.Forms.Button();
            this.btnReinitialiserToutSaufGagnant = new System.Windows.Forms.Button();
            this.tblChrono = new System.Windows.Forms.TableLayoutPanel();
            this.lblUniteChrono = new System.Windows.Forms.Label();
            this.lblGagnant = new System.Windows.Forms.Label();
            this.lblChrono = new System.Windows.Forms.Label();
            this.lblLabelChrono = new System.Windows.Forms.Label();
            this.lblLabelGagnant = new System.Windows.Forms.Label();
            this.tmrChrono = new System.Windows.Forms.Timer(this.components);
            this.tblFormulaire.SuspendLayout();
            this.tblParcours.SuspendLayout();
            this.pnlParcoursThread3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIndicateurThread3)).BeginInit();
            this.pnlParcoursThread2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIndicateurThread2)).BeginInit();
            this.tblThread2.SuspendLayout();
            this.tblThread1.SuspendLayout();
            this.tblThread3.SuspendLayout();
            this.pnlParcoursThread1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIndicateurThread1)).BeginInit();
            this.tblControles.SuspendLayout();
            this.tblChrono.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblFormulaire
            // 
            this.tblFormulaire.ColumnCount = 1;
            this.tblFormulaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblFormulaire.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblFormulaire.Controls.Add(this.tblParcours, 0, 0);
            this.tblFormulaire.Controls.Add(this.tblControles, 0, 1);
            this.tblFormulaire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFormulaire.Location = new System.Drawing.Point(0, 0);
            this.tblFormulaire.Margin = new System.Windows.Forms.Padding(0);
            this.tblFormulaire.Name = "tblFormulaire";
            this.tblFormulaire.RowCount = 2;
            this.tblFormulaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblFormulaire.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblFormulaire.Size = new System.Drawing.Size(1307, 608);
            this.tblFormulaire.TabIndex = 0;
            // 
            // tblParcours
            // 
            this.tblParcours.ColumnCount = 3;
            this.tblParcours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblParcours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tblParcours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tblParcours.Controls.Add(this.pnlParcoursThread3, 1, 2);
            this.tblParcours.Controls.Add(this.pnlParcoursThread2, 1, 1);
            this.tblParcours.Controls.Add(this.tblThread2, 2, 1);
            this.tblParcours.Controls.Add(this.lblLabelThread1, 0, 0);
            this.tblParcours.Controls.Add(this.lblLabelThread2, 0, 1);
            this.tblParcours.Controls.Add(this.lblLabelThread3, 0, 2);
            this.tblParcours.Controls.Add(this.tblThread1, 2, 0);
            this.tblParcours.Controls.Add(this.tblThread3, 2, 2);
            this.tblParcours.Controls.Add(this.pnlParcoursThread1, 1, 0);
            this.tblParcours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblParcours.Location = new System.Drawing.Point(0, 0);
            this.tblParcours.Margin = new System.Windows.Forms.Padding(0);
            this.tblParcours.Name = "tblParcours";
            this.tblParcours.Padding = new System.Windows.Forms.Padding(25);
            this.tblParcours.RowCount = 3;
            this.tblParcours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblParcours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblParcours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblParcours.Size = new System.Drawing.Size(1307, 456);
            this.tblParcours.TabIndex = 0;
            // 
            // pnlParcoursThread3
            // 
            this.pnlParcoursThread3.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlParcoursThread3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlParcoursThread3.Controls.Add(this.picIndicateurThread3);
            this.pnlParcoursThread3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParcoursThread3.Location = new System.Drawing.Point(207, 320);
            this.pnlParcoursThread3.Margin = new System.Windows.Forms.Padding(25);
            this.pnlParcoursThread3.Name = "pnlParcoursThread3";
            this.pnlParcoursThread3.Size = new System.Drawing.Size(892, 86);
            this.pnlParcoursThread3.TabIndex = 8;
            // 
            // picIndicateurThread3
            // 
            this.picIndicateurThread3.Image = global::ProgressionDeMultiThreads.Properties.Resources.coureur_0;
            this.picIndicateurThread3.InitialImage = global::ProgressionDeMultiThreads.Properties.Resources.coureur_0;
            this.picIndicateurThread3.Location = new System.Drawing.Point(0, 22);
            this.picIndicateurThread3.Margin = new System.Windows.Forms.Padding(0);
            this.picIndicateurThread3.Name = "picIndicateurThread3";
            this.picIndicateurThread3.Size = new System.Drawing.Size(60, 60);
            this.picIndicateurThread3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIndicateurThread3.TabIndex = 2;
            this.picIndicateurThread3.TabStop = false;
            // 
            // pnlParcoursThread2
            // 
            this.pnlParcoursThread2.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlParcoursThread2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlParcoursThread2.Controls.Add(this.picIndicateurThread2);
            this.pnlParcoursThread2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParcoursThread2.Location = new System.Drawing.Point(207, 185);
            this.pnlParcoursThread2.Margin = new System.Windows.Forms.Padding(25);
            this.pnlParcoursThread2.Name = "pnlParcoursThread2";
            this.pnlParcoursThread2.Size = new System.Drawing.Size(892, 85);
            this.pnlParcoursThread2.TabIndex = 7;
            // 
            // picIndicateurThread2
            // 
            this.picIndicateurThread2.Image = global::ProgressionDeMultiThreads.Properties.Resources.coureur_0;
            this.picIndicateurThread2.InitialImage = global::ProgressionDeMultiThreads.Properties.Resources.coureur_0;
            this.picIndicateurThread2.Location = new System.Drawing.Point(0, 21);
            this.picIndicateurThread2.Margin = new System.Windows.Forms.Padding(0);
            this.picIndicateurThread2.Name = "picIndicateurThread2";
            this.picIndicateurThread2.Size = new System.Drawing.Size(60, 60);
            this.picIndicateurThread2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIndicateurThread2.TabIndex = 1;
            this.picIndicateurThread2.TabStop = false;
            // 
            // tblThread2
            // 
            this.tblThread2.ColumnCount = 2;
            this.tblThread2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblThread2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblThread2.Controls.Add(this.lblThread2, 0, 0);
            this.tblThread2.Controls.Add(this.lblUniteThread2, 1, 0);
            this.tblThread2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblThread2.Location = new System.Drawing.Point(1124, 160);
            this.tblThread2.Margin = new System.Windows.Forms.Padding(0);
            this.tblThread2.Name = "tblThread2";
            this.tblThread2.RowCount = 1;
            this.tblThread2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblThread2.Size = new System.Drawing.Size(158, 135);
            this.tblThread2.TabIndex = 4;
            // 
            // lblThread2
            // 
            this.lblThread2.AutoSize = true;
            this.lblThread2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThread2.Location = new System.Drawing.Point(0, 0);
            this.lblThread2.Margin = new System.Windows.Forms.Padding(0);
            this.lblThread2.Name = "lblThread2";
            this.lblThread2.Size = new System.Drawing.Size(94, 135);
            this.lblThread2.TabIndex = 6;
            this.lblThread2.Text = "0";
            this.lblThread2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUniteThread2
            // 
            this.lblUniteThread2.AutoSize = true;
            this.lblUniteThread2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUniteThread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniteThread2.Location = new System.Drawing.Point(94, 0);
            this.lblUniteThread2.Margin = new System.Windows.Forms.Padding(0);
            this.lblUniteThread2.Name = "lblUniteThread2";
            this.lblUniteThread2.Size = new System.Drawing.Size(64, 135);
            this.lblUniteThread2.TabIndex = 5;
            this.lblUniteThread2.Text = "%";
            this.lblUniteThread2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLabelThread1
            // 
            this.lblLabelThread1.AutoSize = true;
            this.lblLabelThread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelThread1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelThread1.Location = new System.Drawing.Point(25, 25);
            this.lblLabelThread1.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabelThread1.Name = "lblLabelThread1";
            this.lblLabelThread1.Size = new System.Drawing.Size(157, 135);
            this.lblLabelThread1.TabIndex = 0;
            this.lblLabelThread1.Text = "Thread 1";
            this.lblLabelThread1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabelThread2
            // 
            this.lblLabelThread2.AutoSize = true;
            this.lblLabelThread2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelThread2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelThread2.Location = new System.Drawing.Point(25, 160);
            this.lblLabelThread2.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabelThread2.Name = "lblLabelThread2";
            this.lblLabelThread2.Size = new System.Drawing.Size(157, 135);
            this.lblLabelThread2.TabIndex = 1;
            this.lblLabelThread2.Text = "Thread 2";
            this.lblLabelThread2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabelThread3
            // 
            this.lblLabelThread3.AutoSize = true;
            this.lblLabelThread3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelThread3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelThread3.Location = new System.Drawing.Point(25, 295);
            this.lblLabelThread3.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabelThread3.Name = "lblLabelThread3";
            this.lblLabelThread3.Size = new System.Drawing.Size(157, 136);
            this.lblLabelThread3.TabIndex = 2;
            this.lblLabelThread3.Text = "Thread 3";
            this.lblLabelThread3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblThread1
            // 
            this.tblThread1.ColumnCount = 2;
            this.tblThread1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblThread1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblThread1.Controls.Add(this.lblThread1, 0, 0);
            this.tblThread1.Controls.Add(this.lblUniteThread1, 1, 0);
            this.tblThread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblThread1.Location = new System.Drawing.Point(1124, 25);
            this.tblThread1.Margin = new System.Windows.Forms.Padding(0);
            this.tblThread1.Name = "tblThread1";
            this.tblThread1.RowCount = 1;
            this.tblThread1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblThread1.Size = new System.Drawing.Size(158, 135);
            this.tblThread1.TabIndex = 3;
            // 
            // lblThread1
            // 
            this.lblThread1.AutoSize = true;
            this.lblThread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThread1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThread1.Location = new System.Drawing.Point(0, 0);
            this.lblThread1.Margin = new System.Windows.Forms.Padding(0);
            this.lblThread1.Name = "lblThread1";
            this.lblThread1.Size = new System.Drawing.Size(94, 135);
            this.lblThread1.TabIndex = 5;
            this.lblThread1.Text = "0";
            this.lblThread1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUniteThread1
            // 
            this.lblUniteThread1.AutoSize = true;
            this.lblUniteThread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUniteThread1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniteThread1.Location = new System.Drawing.Point(94, 0);
            this.lblUniteThread1.Margin = new System.Windows.Forms.Padding(0);
            this.lblUniteThread1.Name = "lblUniteThread1";
            this.lblUniteThread1.Size = new System.Drawing.Size(64, 135);
            this.lblUniteThread1.TabIndex = 4;
            this.lblUniteThread1.Text = "%";
            this.lblUniteThread1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tblThread3
            // 
            this.tblThread3.ColumnCount = 2;
            this.tblThread3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblThread3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblThread3.Controls.Add(this.lblThread3, 0, 0);
            this.tblThread3.Controls.Add(this.lblUniteThread3, 1, 0);
            this.tblThread3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblThread3.Location = new System.Drawing.Point(1124, 295);
            this.tblThread3.Margin = new System.Windows.Forms.Padding(0);
            this.tblThread3.Name = "tblThread3";
            this.tblThread3.RowCount = 1;
            this.tblThread3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblThread3.Size = new System.Drawing.Size(158, 136);
            this.tblThread3.TabIndex = 5;
            // 
            // lblThread3
            // 
            this.lblThread3.AutoSize = true;
            this.lblThread3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblThread3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThread3.Location = new System.Drawing.Point(0, 0);
            this.lblThread3.Margin = new System.Windows.Forms.Padding(0);
            this.lblThread3.Name = "lblThread3";
            this.lblThread3.Size = new System.Drawing.Size(94, 136);
            this.lblThread3.TabIndex = 7;
            this.lblThread3.Text = "0";
            this.lblThread3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUniteThread3
            // 
            this.lblUniteThread3.AutoSize = true;
            this.lblUniteThread3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUniteThread3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniteThread3.Location = new System.Drawing.Point(94, 0);
            this.lblUniteThread3.Margin = new System.Windows.Forms.Padding(0);
            this.lblUniteThread3.Name = "lblUniteThread3";
            this.lblUniteThread3.Size = new System.Drawing.Size(64, 136);
            this.lblUniteThread3.TabIndex = 6;
            this.lblUniteThread3.Text = "%";
            this.lblUniteThread3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlParcoursThread1
            // 
            this.pnlParcoursThread1.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlParcoursThread1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlParcoursThread1.Controls.Add(this.picIndicateurThread1);
            this.pnlParcoursThread1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlParcoursThread1.Location = new System.Drawing.Point(207, 50);
            this.pnlParcoursThread1.Margin = new System.Windows.Forms.Padding(25);
            this.pnlParcoursThread1.Name = "pnlParcoursThread1";
            this.pnlParcoursThread1.Size = new System.Drawing.Size(892, 85);
            this.pnlParcoursThread1.TabIndex = 6;
            // 
            // picIndicateurThread1
            // 
            this.picIndicateurThread1.Image = global::ProgressionDeMultiThreads.Properties.Resources.coureur_0;
            this.picIndicateurThread1.InitialImage = global::ProgressionDeMultiThreads.Properties.Resources.coureur_0;
            this.picIndicateurThread1.Location = new System.Drawing.Point(0, 23);
            this.picIndicateurThread1.Margin = new System.Windows.Forms.Padding(0);
            this.picIndicateurThread1.Name = "picIndicateurThread1";
            this.picIndicateurThread1.Size = new System.Drawing.Size(60, 60);
            this.picIndicateurThread1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIndicateurThread1.TabIndex = 0;
            this.picIndicateurThread1.TabStop = false;
            // 
            // tblControles
            // 
            this.tblControles.ColumnCount = 3;
            this.tblControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblControles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblControles.Controls.Add(this.btnDemarrerThreads, 0, 0);
            this.tblControles.Controls.Add(this.btnReinitialiserToutSaufGagnant, 2, 0);
            this.tblControles.Controls.Add(this.tblChrono, 1, 0);
            this.tblControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblControles.Location = new System.Drawing.Point(0, 456);
            this.tblControles.Margin = new System.Windows.Forms.Padding(0);
            this.tblControles.Name = "tblControles";
            this.tblControles.Padding = new System.Windows.Forms.Padding(25);
            this.tblControles.RowCount = 1;
            this.tblControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblControles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblControles.Size = new System.Drawing.Size(1307, 152);
            this.tblControles.TabIndex = 1;
            // 
            // btnDemarrerThreads
            // 
            this.btnDemarrerThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDemarrerThreads.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemarrerThreads.Location = new System.Drawing.Point(25, 25);
            this.btnDemarrerThreads.Margin = new System.Windows.Forms.Padding(0);
            this.btnDemarrerThreads.Name = "btnDemarrerThreads";
            this.btnDemarrerThreads.Size = new System.Drawing.Size(377, 102);
            this.btnDemarrerThreads.TabIndex = 0;
            this.btnDemarrerThreads.Text = "Démarrer";
            this.btnDemarrerThreads.UseVisualStyleBackColor = true;
            this.btnDemarrerThreads.Click += new System.EventHandler(this.btnDemarrerThreads_Click);
            // 
            // btnReinitialiserToutSaufGagnant
            // 
            this.btnReinitialiserToutSaufGagnant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReinitialiserToutSaufGagnant.Enabled = false;
            this.btnReinitialiserToutSaufGagnant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialiserToutSaufGagnant.Location = new System.Drawing.Point(904, 25);
            this.btnReinitialiserToutSaufGagnant.Margin = new System.Windows.Forms.Padding(0);
            this.btnReinitialiserToutSaufGagnant.Name = "btnReinitialiserToutSaufGagnant";
            this.btnReinitialiserToutSaufGagnant.Size = new System.Drawing.Size(378, 102);
            this.btnReinitialiserToutSaufGagnant.TabIndex = 1;
            this.btnReinitialiserToutSaufGagnant.Text = "Réinitialiser";
            this.btnReinitialiserToutSaufGagnant.UseVisualStyleBackColor = true;
            this.btnReinitialiserToutSaufGagnant.Click += new System.EventHandler(this.btnReinitialiserToutSaufGagnant_Click);
            // 
            // tblChrono
            // 
            this.tblChrono.ColumnCount = 3;
            this.tblChrono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblChrono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tblChrono.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblChrono.Controls.Add(this.lblUniteChrono, 2, 0);
            this.tblChrono.Controls.Add(this.lblGagnant, 0, 1);
            this.tblChrono.Controls.Add(this.lblChrono, 1, 0);
            this.tblChrono.Controls.Add(this.lblLabelChrono, 0, 0);
            this.tblChrono.Controls.Add(this.lblLabelGagnant, 0, 1);
            this.tblChrono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblChrono.Location = new System.Drawing.Point(402, 25);
            this.tblChrono.Margin = new System.Windows.Forms.Padding(0);
            this.tblChrono.Name = "tblChrono";
            this.tblChrono.RowCount = 2;
            this.tblChrono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblChrono.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblChrono.Size = new System.Drawing.Size(502, 102);
            this.tblChrono.TabIndex = 2;
            // 
            // lblUniteChrono
            // 
            this.lblUniteChrono.AutoSize = true;
            this.lblUniteChrono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUniteChrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUniteChrono.Location = new System.Drawing.Point(375, 0);
            this.lblUniteChrono.Margin = new System.Windows.Forms.Padding(0);
            this.lblUniteChrono.Name = "lblUniteChrono";
            this.lblUniteChrono.Size = new System.Drawing.Size(127, 51);
            this.lblUniteChrono.TabIndex = 3;
            this.lblUniteChrono.Text = "sec";
            this.lblUniteChrono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGagnant
            // 
            this.lblGagnant.AutoSize = true;
            this.tblChrono.SetColumnSpan(this.lblGagnant, 2);
            this.lblGagnant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGagnant.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGagnant.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblGagnant.Location = new System.Drawing.Point(150, 51);
            this.lblGagnant.Margin = new System.Windows.Forms.Padding(0);
            this.lblGagnant.Name = "lblGagnant";
            this.lblGagnant.Size = new System.Drawing.Size(352, 51);
            this.lblGagnant.TabIndex = 3;
            this.lblGagnant.Text = "Thread #";
            this.lblGagnant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGagnant.Visible = false;
            // 
            // lblChrono
            // 
            this.lblChrono.AutoSize = true;
            this.lblChrono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChrono.Location = new System.Drawing.Point(150, 0);
            this.lblChrono.Margin = new System.Windows.Forms.Padding(0);
            this.lblChrono.Name = "lblChrono";
            this.lblChrono.Size = new System.Drawing.Size(225, 51);
            this.lblChrono.TabIndex = 2;
            this.lblChrono.Text = "0.0";
            this.lblChrono.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLabelChrono
            // 
            this.lblLabelChrono.AutoSize = true;
            this.lblLabelChrono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelChrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelChrono.Location = new System.Drawing.Point(0, 0);
            this.lblLabelChrono.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabelChrono.Name = "lblLabelChrono";
            this.lblLabelChrono.Size = new System.Drawing.Size(150, 51);
            this.lblLabelChrono.TabIndex = 0;
            this.lblLabelChrono.Text = "Chrono :";
            this.lblLabelChrono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLabelGagnant
            // 
            this.lblLabelGagnant.AutoSize = true;
            this.lblLabelGagnant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLabelGagnant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLabelGagnant.Location = new System.Drawing.Point(0, 51);
            this.lblLabelGagnant.Margin = new System.Windows.Forms.Padding(0);
            this.lblLabelGagnant.Name = "lblLabelGagnant";
            this.lblLabelGagnant.Size = new System.Drawing.Size(150, 51);
            this.lblLabelGagnant.TabIndex = 1;
            this.lblLabelGagnant.Text = "Gagnant :";
            this.lblLabelGagnant.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tmrChrono
            // 
            this.tmrChrono.Interval = 10;
            this.tmrChrono.Tick += new System.EventHandler(this.tmrChrono_Tick);
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1307, 608);
            this.Controls.Add(this.tblFormulaire);
            this.MaximumSize = new System.Drawing.Size(1325, 655);
            this.MinimumSize = new System.Drawing.Size(1325, 655);
            this.Name = "Formulaire";
            this.Text = "Progression de multi-threads - Jérémie Normand";
            this.tblFormulaire.ResumeLayout(false);
            this.tblParcours.ResumeLayout(false);
            this.tblParcours.PerformLayout();
            this.pnlParcoursThread3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIndicateurThread3)).EndInit();
            this.pnlParcoursThread2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIndicateurThread2)).EndInit();
            this.tblThread2.ResumeLayout(false);
            this.tblThread2.PerformLayout();
            this.tblThread1.ResumeLayout(false);
            this.tblThread1.PerformLayout();
            this.tblThread3.ResumeLayout(false);
            this.tblThread3.PerformLayout();
            this.pnlParcoursThread1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIndicateurThread1)).EndInit();
            this.tblControles.ResumeLayout(false);
            this.tblChrono.ResumeLayout(false);
            this.tblChrono.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblFormulaire;
        private System.Windows.Forms.TableLayoutPanel tblParcours;
        private System.Windows.Forms.TableLayoutPanel tblControles;
        private System.Windows.Forms.Button btnDemarrerThreads;
        private System.Windows.Forms.Button btnReinitialiserToutSaufGagnant;
        private System.Windows.Forms.TableLayoutPanel tblChrono;
        private System.Windows.Forms.Label lblUniteChrono;
        private System.Windows.Forms.Label lblGagnant;
        private System.Windows.Forms.Label lblChrono;
        private System.Windows.Forms.Label lblLabelChrono;
        private System.Windows.Forms.Label lblLabelGagnant;
        private System.Windows.Forms.TableLayoutPanel tblThread2;
        private System.Windows.Forms.Label lblThread2;
        private System.Windows.Forms.Label lblUniteThread2;
        private System.Windows.Forms.Label lblLabelThread1;
        private System.Windows.Forms.Label lblLabelThread2;
        private System.Windows.Forms.Label lblLabelThread3;
        private System.Windows.Forms.TableLayoutPanel tblThread1;
        private System.Windows.Forms.Label lblThread1;
        private System.Windows.Forms.Label lblUniteThread1;
        private System.Windows.Forms.TableLayoutPanel tblThread3;
        private System.Windows.Forms.Label lblThread3;
        private System.Windows.Forms.Label lblUniteThread3;
        private System.Windows.Forms.Panel pnlParcoursThread1;
        private System.Windows.Forms.Panel pnlParcoursThread3;
        private System.Windows.Forms.PictureBox picIndicateurThread3;
        private System.Windows.Forms.Panel pnlParcoursThread2;
        private System.Windows.Forms.PictureBox picIndicateurThread2;
        private System.Windows.Forms.PictureBox picIndicateurThread1;
        private System.Windows.Forms.Timer tmrChrono;
    }
}

