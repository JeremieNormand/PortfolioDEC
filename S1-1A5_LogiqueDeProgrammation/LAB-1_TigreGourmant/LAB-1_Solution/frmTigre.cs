using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tigre
{
    public partial class frmTigre : Form
    {
        public frmTigre()
        {
            InitializeComponent();
        }
        // Fonction qui fait manger (grossir) le tigre
        private void btnMange_Click(object sender, EventArgs e)
        {
            picTigre.Left = picTigre.Left - 10;
            picTigre.Width = picTigre.Width + 20;
            picTigre.Height = picTigre.Height + 15;
            if (picTigre.Width >= Width)
            {
                MessageBox.Show("Attention, Explosion...");
                picTigre.Visible = false;
                BackColor = System.Drawing.Color.Red;
            }
        }
    }
}
