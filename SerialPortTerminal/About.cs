using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Biketest
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            dotNET_Version.Text=".NET Framework Version: "+ Environment.Version.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("http://iq-5.de");
        }
    }
}
