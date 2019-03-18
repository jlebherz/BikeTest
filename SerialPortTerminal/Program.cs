using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Biketest
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
            //new Splash().Show();
            //System.Threading.Thread.Sleep(3000);
            //Application.Run(new main());
        }
    }
}
