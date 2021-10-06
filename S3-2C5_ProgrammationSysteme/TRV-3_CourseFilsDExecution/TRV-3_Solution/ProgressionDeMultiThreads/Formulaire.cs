using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ProgressionDeMultiThreads
{
    public partial class Formulaire : Form
    {
        private double chrono;

        private long compteurMax;
        private long compteur1;
        private long compteur2;
        private long compteur3;

        private bool estTermine1;
        private bool estTermine2;
        private bool estTermine3;

        public Formulaire()
        {
            chrono = .0;

            compteurMax = 1_000_000_000;
            compteur1 = 0;
            compteur2 = 0;
            compteur3 = 0;

            estTermine1 = false;
            estTermine2 = false;
            estTermine3 = false;

            InitializeComponent();
        }

        private void FonctionThread1()
        {
            Random rnd = new Random();
            int boost = rnd.Next(1, 5);
            while (compteur1 <= compteurMax) compteur1 += rnd.Next(0, 15) * boost;
            estTermine1 = true;
        }

        private void FonctionThread2()
        {
            Random rnd = new Random();
            int boost = rnd.Next(1, 5);
            while (compteur2 <= compteurMax) compteur2 += rnd.Next(0, 15) * boost;
            estTermine2 = true;
        }

        private void FonctionThread3()
        {
            Random rnd = new Random();
            int boost = rnd.Next(1, 5);
            while (compteur3 <= compteurMax) compteur3 += rnd.Next(0, 15) * boost;
            estTermine3 = true;
        }

        private void btnDemarrerThreads_Click(object sender, EventArgs e)
        {
            tmrChrono.Start();

            Thread thread1 = new Thread(new ThreadStart(FonctionThread1));
            thread1.Priority = ThreadPriority.Lowest;
            thread1.Start();

            Thread thread2 = new Thread(new ThreadStart(FonctionThread2));
            thread2.Priority = ThreadPriority.Highest;
            thread2.Start();

            Thread thread3 = new Thread(new ThreadStart(FonctionThread3));
            thread3.Priority = ThreadPriority.BelowNormal;
            thread3.Start();

            btnDemarrerThreads.Enabled = false;
            btnReinitialiserToutSaufGagnant.Enabled = false;
        }

        private void tmrChrono_Tick(object sender, EventArgs e)
        {
            if (!ValiderSiTermine())
            {
                AvancerChrono();
                AvancerPourcentages();
                AvancerIndicateurs();
            }
            else
            {
                AfficherGagnants();
                tmrChrono.Stop();
                estTermine1 = false;
                estTermine2 = false;
                estTermine3 = false;
                btnReinitialiserToutSaufGagnant.Enabled = true;
            }
        }

        private bool ValiderSiTermine()
        {
            if (estTermine1 || estTermine2 || estTermine3)
            {
                return true;
            }
            return false;
        }

        private void AvancerChrono()
        {
            chrono += .01;
            lblChrono.Text = chrono.ToString("0.0");
        }

        private void AvancerPourcentages()
        {
            lblThread1.Text = ((double)compteur1 / compteurMax * 100).ToString("0");
            lblThread2.Text = ((double)compteur2 / compteurMax * 100).ToString("0");
            lblThread3.Text = ((double)compteur3 / compteurMax * 100).ToString("0");
        }

        private void AvancerIndicateurs()
        {
            int distanceX = pnlParcoursThread1.Width - picIndicateurThread1.Width;

            Point position1 = new Point((int)(distanceX * compteur1 / compteurMax), picIndicateurThread1.Location.Y);
            picIndicateurThread1.Location = position1;

            Point position2 = new Point((int)(distanceX * compteur2 / compteurMax), picIndicateurThread2.Location.Y);
            picIndicateurThread2.Location = position2;

            Point position3 = new Point((int)(distanceX * compteur3 / compteurMax), picIndicateurThread3.Location.Y);
            picIndicateurThread3.Location = position3;
        }

        private void AfficherGagnants()
        {
            lblGagnant.Text = chrono.ToString("0.00") + " sec :";
            if (estTermine1)
            {
                lblGagnant.Text += " Thread-1";
            }
            if (estTermine2)
            {
                lblGagnant.Text += " Thread-2";
            }
            if (estTermine3)
            {
                lblGagnant.Text += " Thread-3";
            }
            lblGagnant.Visible = true;
        }

        private void btnReinitialiserToutSaufGagnant_Click(object sender, EventArgs e)
        {
            tmrChrono.Stop();
            estTermine1 = false;
            estTermine2 = false;
            estTermine3 = false;
            ReinitialiserToutSaufGagnant();
            btnDemarrerThreads.Enabled = true;
            btnReinitialiserToutSaufGagnant.Enabled = false;
        }

        private void ReinitialiserToutSaufGagnant()
        {
            chrono = 0;
            lblChrono.Text = "0.0";

            compteur1 = 0;
            compteur2 = 0;
            compteur3 = 0;

            lblThread1.Text = "0";
            lblThread2.Text = "0";
            lblThread3.Text = "0";

            Point position1 = new Point(0, picIndicateurThread1.Location.Y);
            picIndicateurThread1.Location = position1;

            Point position2 = new Point(0, picIndicateurThread2.Location.Y);
            picIndicateurThread2.Location = position2;

            Point position3 = new Point(0, picIndicateurThread3.Location.Y);
            picIndicateurThread3.Location = position3;
        }
    }
}
