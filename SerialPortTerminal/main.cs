using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Threading;

namespace Biketest
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(bt_B, "aktuelle Last");
            toolTip1.SetToolTip(bt_W100, "setze Last auf 100W");
            toolTip1.SetToolTip(bt_W50, "setze Last auf 50W");
            toolTip1.SetToolTip(bt_w150, "setze Last auf 150W");
            toolTip1.SetToolTip(bt_W75, "setze Last auf 75W");
            toolTip1.SetToolTip(bt_w25, "setze Last auf 25W");
            toolTip1.SetToolTip(bt_W200, "setze Last auf 200W");
            toolTip1.SetToolTip(bt_W250, "setze Last auf 250W");
            toolTip1.SetToolTip(bt_W400, "setze Last auf 400W");
            toolTip1.SetToolTip(bt_W500, "setze Last auf 500W");
            toolTip1.SetToolTip(bt_I, "zeige Geräteinfo");
            toolTip1.SetToolTip(bt_D, "aktuelle Drehzahl");
            toolTip1.SetToolTip(bt_H, "Herzfrequenz");
            toolTip1.SetToolTip(bt_Z, "starte EKG");
            toolTip1.SetToolTip(bt_O, "Systole");
            toolTip1.SetToolTip(bt_U, "Diastole");
            toolTip1.SetToolTip(bt_F, "Ende (3x senden)");
            toolTip1.SetToolTip(bt_S, "Start mit Ruheblutdruck\r danach Start mit P0");
            toolTip1.SetToolTip(bt_kls, "Start mit P0 ohne Ruheblutdruck");
            toolTip1.SetToolTip(bt_k, "Sattel Position\rErsten beiden Ziffern: Ist-Position\rLetzte beiden Ziffern: Soll-Position");
            toolTip1.SetToolTip(bt_k15, "Sattel nach Position 15");
            toolTip1.SetToolTip(bt_k25, "Sattel nach position 25");
            
        }

        SerialPort serialPort; //Serialport den wir später verwenden - globale Deklaration
        Boolean GotoClose = false;
        
        delegate void InvokeLB(string Data);

        InvokeLB lbRecievedDelegate;
        private byte[] buffer;
        private object stringComparer;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bCreateSP_Click(object sender, EventArgs e)
        {

        
            if (!serialPort.IsOpen)
            {
                serialPort.PortName = cbPort.Text;
                serialPort.BaudRate = Convert.ToInt32(cbBaudRate.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbParity.Text);
                serialPort.DataBits = Convert.ToInt16(cbDataBits.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbStopbits.Text);
                serialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), cbHandshake.Text);
                serialPort.RtsEnable = Boolean.Parse(cbRtsEnable.Text);
                serialPort.DtrEnable = Boolean.Parse(cbDtrEnable.Text);
                serialPort.NewLine = "\r";
                serialPort.Open(); //Serialport öffnen
                lbRecievedDelegate = new InvokeLB(InvokeLBRecieved);
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived); //DataRecieved Event abonnieren
                SetButtonsState(true);
                this.bCreateSP.Text = "Close";
                this.lable_connected.Text = "Connected";
                this.progressBarConnected.Value = 100;
                //this.progressBarConnected.
                goto ende_create;
            }
            if (serialPort.IsOpen)
            {
                GotoClose = true;
                serialPort.Close();
                serialPort.Dispose();
                this.lable_connected.Text = "Closed";
                this.bCreateSP.Text = "Open";
                this.progressBarConnected.Value = 0;
                SetButtonsState(false);
            }
            ende_create:
            cbPort.Show();
        }

        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            this.Invoke(new EventHandler(DoUpdate));

        }

        void DoUpdate(object s, EventArgs e)
        {
            StringComparer stringComparer = StringComparer.OrdinalIgnoreCase;
            string RecievedLine;
            RecievedLine = serialPort.ReadLine();
            //if (stringComparer.Equals("D\r", RecievedLine)){ richTextBox1.Text = "ABC"; } else { richTextBox1.Text = "DEF"; }
            //richTextBox1.Text = RecievedLine;
                lbSent.Invoke(lbRecievedDelegate, new object[] { RecievedLine });
        }
        void InvokeLBRecieved(string Data)
        {
            lbSent.Items.Add(Data);
            lbSent.Items.Add(" ");
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in SerialPort.GetPortNames())
            {
                cbPort.Items.Add(item);
            }
            cbPort.Text = cbPort.Items[0].ToString();

            foreach (var item in Enum.GetNames(typeof(Parity)))
            {
                cbParity.Items.Add(item);
            }
            cbParity.Text = cbParity.Items[0].ToString();

            foreach (var item in Enum.GetNames(typeof(StopBits)))
            {
               cbStopbits.Items.Add(item);
            }
            cbStopbits.Text = cbStopbits.Items[1].ToString();

            cbBaudRate.Items.Add("110");
            cbBaudRate.Items.Add("300");
            cbBaudRate.Items.Add("600");
            cbBaudRate.Items.Add("1200");
            cbBaudRate.Items.Add("2400");
            cbBaudRate.Items.Add("4800");
            cbBaudRate.Items.Add("9600");
            cbBaudRate.Items.Add("14400");
            cbBaudRate.Items.Add("19200");
            cbBaudRate.Items.Add("28800");
            cbBaudRate.Items.Add("38400");
            cbBaudRate.Items.Add("56000");
            cbBaudRate.Items.Add("57600");
            cbBaudRate.Items.Add("115200");
            cbBaudRate.Text = cbBaudRate.Items[10].ToString();

            cbDataBits.Items.Add("5");
            cbDataBits.Items.Add("6");
            cbDataBits.Items.Add("7");
            cbDataBits.Items.Add("8");
            cbDataBits.Items.Add("9");
            cbDataBits.Text = "8";


            foreach (var item in Enum.GetNames(typeof( Handshake)))
            {
                cbHandshake.Items.Add(item);
            }
            cbHandshake.Text = cbHandshake.Items[0].ToString();

            cbDtrEnable.Items.Add("True");
            cbDtrEnable.Items.Add("False");
            cbDtrEnable.Text = "False";

            cbRtsEnable.Items.Add("True");
            cbRtsEnable.Items.Add("False");
            cbRtsEnable.Text = "False";


        }

        private void bSendData_Click(object sender, EventArgs e)
        {
            serialPort.Write(tbDataToSend.Text+"\r");
            lbSent.Items.Add(tbDataToSend.Text);
            tbDataToSend.Clear();
            tbDataToSend.Focus();
        }

        private void SetButtonsState(Boolean state)
        {
            Boolean DisState;
            DisState = true;
            if (state) { DisState = false; }
            if (!state) { DisState = true; }
            bt_S.Enabled = state;
            bt_I.Enabled = state;
            bt_D.Enabled = state;
            bt_kls.Enabled = state;
            bt_W100.Enabled = state;
            bt_F.Enabled = state;
            bt_U.Enabled = state;
            bt_H.Enabled = state;
            bt_O.Enabled = state;
            bt_W50.Enabled = state;
            bt_w25.Enabled = state;
            bt_W75.Enabled = state;
            bt_w150.Enabled = state;
            bt_W250.Enabled = state;
            bt_W200.Enabled = state;
            bt_W400.Enabled = state;
            bt_W500.Enabled = state;
            bt_Z.Enabled = state;
            bt_B.Enabled = state;
            bSendData.Enabled = state;
            bt_k.Enabled = state;
            bt_k15.Enabled = state;
            bt_k25.Enabled = state;
            tbDataToSend.Enabled = state;

            cbPort.Enabled = DisState;
            cbBaudRate.Enabled = DisState;
            cbDataBits.Enabled = DisState;
            cbParity.Enabled = DisState;
            cbHandshake.Enabled = DisState;
            cbStopbits.Enabled = DisState;
            cbDtrEnable.Enabled = DisState;
            cbRtsEnable.Enabled = DisState;
        }

        private void bClearSent_Click(object sender, EventArgs e)
        {
            lbSent.Items.Clear();
        }

        private void bt_S_Click(object sender, EventArgs e)
        {
            serialPort.Write("S\r");
            lbSent.Items.Add("S");
        }

        private void bt_I_Click(object sender, EventArgs e)
        {
            serialPort.Write("I\r");
            lbSent.Items.Add("I");
        }

        private void bt_D_Click(object sender, EventArgs e)
        {
            serialPort.Write("D\r");
            lbSent.Items.Add("D");
        }

        private void bt_kls_Click(object sender, EventArgs e)
        {
            serialPort.Write("s\r");
            lbSent.Items.Add("s");
        }

        private void bt_W100_Click(object sender, EventArgs e)
        {
            serialPort.Write("W100\r");
            lbSent.Items.Add("W100");
        }

        private void bt_F_Click(object sender, EventArgs e)
        {
            serialPort.Write("F\r");
            lbSent.Items.Add("F");
        }

        private void bt_U_Click(object sender, EventArgs e)
        {
            serialPort.Write("U\r");
            lbSent.Items.Add("U");
        }

        private void bt_H_Click(object sender, EventArgs e)
        {
            serialPort.Write("H\r");
            lbSent.Items.Add("H");
        }

        private void bt_O_Click(object sender, EventArgs e)
        {
            serialPort.Write("O\r");
            lbSent.Items.Add("O");
        }

        private void bt_W50_Click(object sender, EventArgs e)
        {
            serialPort.Write("W050\r");
            lbSent.Items.Add("W050");
        }

        private void bt_Z_Click(object sender, EventArgs e)
        {
            serialPort.Write("Z\r");
            lbSent.Items.Add("Z");
        }

        private void dateiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serialPort.Close();
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("        BikeTest by John Lebherz \r       www.systemhaus-lebherz.de");
            new About().Show(this);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://iq-5.de");
        }

        private void bt_B_Click(object sender, EventArgs e)
        {
            serialPort.Write("B\r");
            lbSent.Items.Add("B");
        }

        private void bt_k15_Click(object sender, EventArgs e)
        {
            serialPort.Write("k15\r");
            lbSent.Items.Add("k15");
        }

        private void bt_k25_Click(object sender, EventArgs e)
        {
            serialPort.Write("k25\r");
            lbSent.Items.Add("k25");
        }

        private void bt_k_Click(object sender, EventArgs e)
        {
            serialPort.Write("k\r");
            lbSent.Items.Add("k");
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void bt_w25_Click(object sender, EventArgs e)
        {
            serialPort.Write("W025\r");
            lbSent.Items.Add("W025");
        }

        private void bt_W75_Click(object sender, EventArgs e)
        {
            serialPort.Write("W075\r");
            lbSent.Items.Add("W075");
        }

        private void bt_w150_Click(object sender, EventArgs e)
        {
            serialPort.Write("W150\r");
            lbSent.Items.Add("W150");
        }

        private void bt_W200_Click(object sender, EventArgs e)
        {
            serialPort.Write("W200\r");
            lbSent.Items.Add("W200");
        }

        private void bt_W250_Click(object sender, EventArgs e)
        {
            serialPort.Write("W250\r");
            lbSent.Items.Add("W250");
        }

        private void bt_W400_Click(object sender, EventArgs e)
        {
            serialPort.Write("W400\r");
            lbSent.Items.Add("W400");
        }

        private void bt_W500_Click(object sender, EventArgs e)
        {
            serialPort.Write("W500\r");
            lbSent.Items.Add("W500");
        }
        
        private void tbDataToSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                serialPort.Write(tbDataToSend.Text + "\r");
                lbSent.Items.Add(tbDataToSend.Text);
                tbDataToSend.Clear();
                tbDataToSend.Focus();
            }    
        }
    }
}
