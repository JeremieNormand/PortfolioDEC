using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9Classe
{
    public partial class FrmIntro : Form
    {
        public FrmIntro()
        {
            InitializeComponent();
        }

        private void btnMembrePub_Click(object sender, EventArgs e)
        {
            FrmMembresPublic frmMembrePublic = new FrmMembresPublic();
            frmMembrePublic.Show();
        }

        private void btnMembresPriv_Click(object sender, EventArgs e)
        {
            FrmMembresPrivate frmMembrePrivate = new FrmMembresPrivate();
            frmMembrePrivate.Show();
        }
    }
}
