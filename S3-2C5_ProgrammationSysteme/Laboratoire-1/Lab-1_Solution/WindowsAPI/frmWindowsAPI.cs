using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAPI
{
    public partial class frmWindowsAPI : Form
    {
        [DllImport("User32.dll")]
        static extern bool MessageBeep(int beepType);

        [DllImport("Kernel32.dll")]
        static extern int GetFileAttributesA(string lpFileName);

        [DllImport("Kernel32.dll")]
        static extern int WinExec(string LpCmdLin, int uCmdShow);

        public frmWindowsAPI()
        {
            InitializeComponent();
        }

        private void btnAfficherSalutation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salutation!");
        }

        private void btnFaireBeepWindows_Click(object sender, EventArgs e)
        {
            MessageBeep(0);
        }

        private void btnAfficherFicherAttributs_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GetFileAttributesA(AppDomain.CurrentDomain.BaseDirectory).ToString());
        }

        private void btnExecuterBlocNote_Click(object sender, EventArgs e)
        {
            WinExec("notepad.exe", 1);
        }
    }
}
