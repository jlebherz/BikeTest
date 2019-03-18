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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            

        }
        Microsoft.Win32.RegistryKey key;
        Timer tmr;
        Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        //Int32 demo_to = 1502747476;
        Int32 demo_to;
        string BerechneterActivateString;

        private void Splash_Load(object sender, EventArgs e)
        {
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Systemhaus-Lebherz\\BikeTest");
            //if(key.GetValue("installed")!=null)MessageBox.Show(key.GetValue("installed").ToString());
            if (key.GetValue("installed") == null)key.SetValue("installed", ((Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds)+ 432000);
            if (key.GetValue("installed") != null) demo_to = Int32.Parse(key.GetValue("installed").ToString());
            //MessageBox.Show(demo_to.ToString());
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            main mf = new main();
            mf.Show();
            this.Hide();
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            //MessageBox.Show(key.GetValue("activated").ToString());
            tmr = new Timer();
            tmr.Interval = 3000;
            tmr.Start();
            Microsoft.Win32.RegistryKey localMachine = Microsoft.Win32.RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, Microsoft.Win32.RegistryView.Registry64);
            Microsoft.Win32.RegistryKey windowsNTKey = localMachine.OpenSubKey(@"Software\Microsoft\Windows NT\CurrentVersion");
            object productID = windowsNTKey.GetValue("ProductId");
            string ActivateID="";
            if(key.GetValue("activated")!=null) ActivateID = key.GetValue("activated").ToString();
            string AktivierungsAnforderungsString = SHA1(productID.ToString()).Substring(0, 4) + "-" + SHA1(productID.ToString()).Substring(5, 4);
            BerechneterActivateString=SHA1(AktivierungsAnforderungsString).Substring(0, 4) + "-" + SHA1(AktivierungsAnforderungsString).Substring(5, 4);
            //MessageBox.Show(BerechneterActivateString);
            // if (key.GetValue("activated") != null) if (ActivateID == BerechneterActivateString)
            //{
            // lbl_top.Text = "Software aktiviert!";
            lbl_top.Text = "";
            tmr.Tick += tmr_Tick;
                goto no_demo;
           // }

            
            if (unixTimestamp < demo_to)
            {
                tmr.Tick += tmr_Tick;

                lbl_top.Text = "Demo bis "+conv_Timestamp2Date(demo_to);
            }
            if (unixTimestamp > demo_to)
            {
                bt_close.Visible = true;
                bt_activate.Visible = true;
                tb_ActivateString.Visible = true;
                
                lbl_top.Text = "DEMO abgelaufen\r\nAktivierungs ID: " + AktivierungsAnforderungsString;
            }
            no_demo:
            int TTest;
        }

        public String SHA1(String plaintext)
        {
            try
            {
                System.Security.Cryptography.SHA1 sha1 = System.Security.Cryptography.SHA1.Create();
                byte[] bytes = System.Text.Encoding.ASCII.GetBytes(plaintext);
                byte[] hash = sha1.ComputeHash(bytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hash.Length; i++)
                    sb.Append(hash[i].ToString("x2"));

                return sb.ToString();
            }
            catch
            {
                return null;
            }
        }

        private string conv_Timestamp2Date(int Timestamp)
        {
            System.DateTime dateTime = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);  
            dateTime = dateTime.AddSeconds(Timestamp);
            string Date = dateTime.ToShortDateString()/* + ", " + dateTime.ToShortTimeString()*/;
            return Date;
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://iq-5.de");
        }

        private void bt_activate_Click(object sender, EventArgs e)
        {
            if (tb_ActivateString.Text == BerechneterActivateString)
                {
                key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Systemhaus-Lebherz\\BikeTest");
                key.SetValue("activated", tb_ActivateString.Text);
                MessageBox.Show("erfolgreich aktiviert!");
                Close();
            }
            if(tb_ActivateString.Text != BerechneterActivateString) MessageBox.Show("Aktivierungs Code falsch");
        }
    }
}
