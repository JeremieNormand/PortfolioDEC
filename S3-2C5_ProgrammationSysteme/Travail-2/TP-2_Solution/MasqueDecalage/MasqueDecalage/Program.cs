using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasqueDecalage
{
    static class Program
    {
        /// <summary>
        /// JL Normand - 2021/09/16
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMasqueDecalage());
        }
    }
}
