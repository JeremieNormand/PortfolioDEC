using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Televisions.Classes;

namespace Televisions
{
    public partial class Formulaire : Form
    {
        private Panel tv1, tv2;
        private Graphics canevasTV1, canevasTV2;

        private Button addCercle;
        private Button addNinja;
        private Button addMonstre;
        private Button startCercles;
        private Button startNinjas;
        private Button startMonstres;
        private Button stopTV1;
        private Button stopTV2;

        private List<Thread> threadsTV1;
        private List<List<Thread>> threadsTV2;
        private enum entiteTV2 { ninja, monstre }

        private List<Cercle> cercles;
        private List<Ninja> ninjas;
        private List<Monstre> monstres;

        private int maxCercles;
        private int maxNinjas;
        private int maxMonstres;
        private int maxChakras;

        private double intervaleSecondes;

        public Formulaire()
        {
            InitializeComponent();

            tv1 = pnlTV1;
            tv2 = pnlTV2;
            canevasTV1 = tv1.CreateGraphics();
            canevasTV2 = tv2.CreateGraphics();

            addCercle = btnAjouterCercleTV1;
            addNinja = btnAjouterNinjaTV2;
            addMonstre = btnAjouterMonstreTV2;
            startCercles = btnAnimerCerclesTV1;
            startNinjas = btnAnimerNinjasTV2;
            startMonstres = btnAnimerMonstresTV2;
            stopTV1 = btnEteindreTV1;
            stopTV2 = btnEteindreTV2;

            threadsTV1 = new List<Thread>();
            threadsTV2 = new List<List<Thread>> { new List<Thread>(), new List<Thread>() };

            cercles = new List<Cercle>();
            ninjas = new List<Ninja>();
            monstres = new List<Monstre>();

            maxCercles = 16; //
            maxNinjas = 8; //
            maxMonstres = 8; //
            maxChakras = byte.MaxValue / 4; //

            startCercles.Enabled = false;
            startNinjas.Enabled = false;
            startMonstres.Enabled = false;
            stopTV1.Enabled = false;
            stopTV2.Enabled = false;

            tmr1Milliseconde.Enabled = true;
            tmr1Seconde.Enabled = true;
        }

        /* ================ Cercles - BOUTONS ================ */

        private void btnAjouterCercleTV1_Click(object sender, EventArgs e)
        {
            if (cercles.Count <= maxCercles)
            {
                Cercle c = new Cercle(tv1);
                SolidBrush crayon = new SolidBrush(c.Couleur);
                canevasTV1.FillEllipse(crayon, c.X, c.Y, c.Diametre, c.Diametre);
                cercles.Add(c);
            }
            else { addCercle.Enabled = false; }

            startCercles.Enabled = true;
            stopTV1.Enabled = true;
        }

        private void btnAnimerCerclesTV1_Click(object sender, EventArgs e)
        {
            foreach (Cercle c in cercles)
            {
                threadsTV1.Add(new Thread(new ThreadStart(c.Bouger)));
            }
            foreach (Thread t in threadsTV1)
            {
                t.Start();
            }

            addCercle.Enabled = false;
            startCercles.Enabled = false;
        }

        private void btnEteindreTV1_Click(object sender, EventArgs e)
        {
            ArreterThreadsTV1();
            canevasTV1.Clear(tv1.BackColor);
            threadsTV1.Clear();
            cercles.Clear();

            addCercle.Enabled = true;
            startCercles.Enabled = false;
            stopTV1.Enabled = false;
        }

        private void ArreterThreadsTV1()
        {
            foreach (Thread t in threadsTV1)
            {
                t.Abort();
            }
        }

        /* ================ Ninjas et Monstres - BOUTONS ================ */

        private void btnAjouterNinjaTV2_Click(object sender, EventArgs e)
        {
            if (ninjas.Count <= maxNinjas)
            {
                Ninja n = new Ninja(tv2);
                canevasTV2.DrawImage(n.Avatar, n.X, n.Y);
                ninjas.Add(n);
            }
            else { addNinja.Enabled = false; }

            startNinjas.Enabled = true;
            stopTV2.Enabled = true;
        }

        private void btnAjouterMonstreTV2_Click(object sender, EventArgs e)
        {
            if (monstres.Count <= maxMonstres)
            {
                Monstre m = new Monstre(tv2);
                canevasTV2.DrawImage(m.Avatar, m.X, m.Y);
                monstres.Add(m);
            }
            else { addMonstre.Enabled = false; }

            startMonstres.Enabled = true;
            stopTV2.Enabled = true;
        }

        private void btnAnimerNinjasTV2_Click(object sender, EventArgs e)
        {
            List<Thread> threads = threadsTV2[(int)entiteTV2.ninja];
            foreach (Ninja n in ninjas)
            {
                threads.Add(new Thread(new ThreadStart(n.Bouger)));
            }
            foreach (Thread t in threads)
            {
                t.Start();
            }

            addNinja.Enabled = false;
            startNinjas.Enabled = false;
        }

        private void btnAnimerMonstresTV2_Click(object sender, EventArgs e)
        {
            List<Thread> threads = threadsTV2[(int)entiteTV2.monstre];
            foreach (Monstre m in monstres)
            {
                threads.Add(new Thread(new ThreadStart(m.Bouger)));
            }
            foreach (Thread t in threads)
            {
                t.Start();
            }

            addMonstre.Enabled = false;
            startMonstres.Enabled = false;
        }

        private void btnEteindreTV2_Click(object sender, EventArgs e)
        {
            ArreterThreadsTV2();
            canevasTV2.Clear(tv2.BackColor);
            threadsTV2[(int)entiteTV2.ninja].Clear();
            threadsTV2[(int)entiteTV2.monstre].Clear();
            ninjas.Clear();
            monstres.Clear();

            addNinja.Enabled = true;
            addMonstre.Enabled = true;
            startNinjas.Enabled = false;
            startMonstres.Enabled = false;
            stopTV2.Enabled = false;
        }

        private void ArreterThreadsTV2()
        {
            foreach (List<Thread> list in threadsTV2)
            {
                foreach (Thread t in list)
                {
                    t.Abort();
                }
            }
        }

        /* ================ Cercles, Ninjas et Monstres - GRAPHIQUES ================ */

        private void tmr1Milliseconde_Tick(object sender, EventArgs e)
        {
            if (!startCercles.Enabled) DessinerDeplacementCerclesTV1();

            if (!startNinjas.Enabled) DessinerDeplacementNinjasTV2();
            if (!startMonstres.Enabled) DessinerDeplacementMonstresTV2();
        }

        private void DessinerDeplacementCerclesTV1()
        {
            foreach (Cercle c in cercles)
            {
                SolidBrush crayon = new SolidBrush(c.Couleur);
                canevasTV1.FillEllipse(crayon, c.X, c.Y, c.Diametre, c.Diametre);
            }
        }

        private void DessinerDeplacementNinjasTV2()
        {
            foreach (Ninja n in ninjas)
            {
                SolidBrush crayon = new SolidBrush(n.Couleur);
                if (n.Chakras > maxChakras) canevasTV2.FillEllipse(crayon, n.X, n.Y, n.Diametre, n.Diametre);
                canevasTV2.DrawImage(n.Avatar, n.X, n.Y);
            }
        }

        private void DessinerDeplacementMonstresTV2()
        {
            foreach (Monstre m in monstres)
            {
                SolidBrush crayon = new SolidBrush(m.Couleur);
                if (m.Chakras > maxChakras) canevasTV2.FillEllipse(crayon, m.X, m.Y, m.Diametre, m.Diametre);
                canevasTV2.DrawImage(m.Avatar, m.X, m.Y);
            }
        }

        /* ================ Cercles, Ninjas et Monstres - COMPTEURS ================ */

        private void tmr1Seconde_Tick(object sender, EventArgs e)
        {
            if (stopTV1.Enabled) EcoulerTempsCerclesTV1();

            if (stopTV2.Enabled)
            {
                EcoulerTempsNinjasTV2();
                EcoulerTempsMonstresTV2();
                AccroitreChakrasEntitesTV2();
            }
        }

        private void EcoulerTempsCerclesTV1()
        {
            List<int> indices = new List<int>();
            for (int idCercle = 0; idCercle < cercles.Count; ++idCercle)
            {
                if (--cercles[idCercle].Restant == 0)
                {
                    indices.Add(idCercle);
                }
            }
            for (int idIndice = indices.Count - 1; idIndice >= 0; --idIndice)
            {
                cercles.RemoveAt(indices[idIndice]);
            }
        }

        private void EcoulerTempsNinjasTV2()
        {
            List<int> indices = new List<int>();
            for (int idNinja = 0; idNinja < ninjas.Count; ++idNinja)
            {
                if (--ninjas[idNinja].Restant == 0)
                {
                    indices.Add(idNinja);
                }
            }
            for (int idIndice = indices.Count - 1; idIndice >= 0; --idIndice)
            {
                ninjas.RemoveAt(indices[idIndice]);
            }
        }

        private void EcoulerTempsMonstresTV2()
        {
            List<int> indices = new List<int>();
            for (int idMonstre = 0; idMonstre < monstres.Count; ++idMonstre)
            {
                if (--monstres[idMonstre].Restant == 0)
                {
                    indices.Add(idMonstre);
                }
            }
            for (int idIndice = indices.Count - 1; idIndice >= 0; --idIndice)
            {
                monstres.RemoveAt(indices[idIndice]);
            }
        }

        private void AccroitreChakrasEntitesTV2()
        {
            foreach (Ninja n in ninjas)
            {
                n.AccroitreChakras();
            }
            foreach (Monstre m in monstres)
            {
                m.AccroitreChakras();
            }
        }

        /* ================ FORMULAIRE ================ */

        private void Formulaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            ArreterThreadsTV1();
            ArreterThreadsTV2();
        }
    }
}
