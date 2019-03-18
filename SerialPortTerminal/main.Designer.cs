namespace Biketest
{
    partial class main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.gbConfig = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bCreateSP = new System.Windows.Forms.Button();
            this.cbRtsEnable = new System.Windows.Forms.ComboBox();
            this.cbDtrEnable = new System.Windows.Forms.ComboBox();
            this.cbStopbits = new System.Windows.Forms.ComboBox();
            this.cbHandshake = new System.Windows.Forms.ComboBox();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.bt_W500 = new System.Windows.Forms.Button();
            this.bt_W400 = new System.Windows.Forms.Button();
            this.bt_W75 = new System.Windows.Forms.Button();
            this.bt_W250 = new System.Windows.Forms.Button();
            this.bt_W200 = new System.Windows.Forms.Button();
            this.bt_w150 = new System.Windows.Forms.Button();
            this.bt_w25 = new System.Windows.Forms.Button();
            this.bt_k = new System.Windows.Forms.Button();
            this.bt_k25 = new System.Windows.Forms.Button();
            this.bt_k15 = new System.Windows.Forms.Button();
            this.bt_B = new System.Windows.Forms.Button();
            this.bt_Z = new System.Windows.Forms.Button();
            this.bt_W50 = new System.Windows.Forms.Button();
            this.bt_O = new System.Windows.Forms.Button();
            this.bt_H = new System.Windows.Forms.Button();
            this.bt_U = new System.Windows.Forms.Button();
            this.progressBarConnected = new System.Windows.Forms.ProgressBar();
            this.bt_F = new System.Windows.Forms.Button();
            this.bt_W100 = new System.Windows.Forms.Button();
            this.bt_kls = new System.Windows.Forms.Button();
            this.lable_connected = new System.Windows.Forms.Label();
            this.bt_D = new System.Windows.Forms.Button();
            this.bt_I = new System.Windows.Forms.Button();
            this.bt_S = new System.Windows.Forms.Button();
            this.bClearSent = new System.Windows.Forms.Button();
            this.bSendData = new System.Windows.Forms.Button();
            this.tbDataToSend = new System.Windows.Forms.TextBox();
            this.lbSent = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gbConfig.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConfig
            // 
            this.gbConfig.Controls.Add(this.label8);
            this.gbConfig.Controls.Add(this.label9);
            this.gbConfig.Controls.Add(this.label7);
            this.gbConfig.Controls.Add(this.label6);
            this.gbConfig.Controls.Add(this.label5);
            this.gbConfig.Controls.Add(this.label4);
            this.gbConfig.Controls.Add(this.label3);
            this.gbConfig.Controls.Add(this.label2);
            this.gbConfig.Controls.Add(this.bCreateSP);
            this.gbConfig.Controls.Add(this.cbRtsEnable);
            this.gbConfig.Controls.Add(this.cbDtrEnable);
            this.gbConfig.Controls.Add(this.cbStopbits);
            this.gbConfig.Controls.Add(this.cbHandshake);
            this.gbConfig.Controls.Add(this.cbParity);
            this.gbConfig.Controls.Add(this.cbDataBits);
            this.gbConfig.Controls.Add(this.cbBaudRate);
            this.gbConfig.Controls.Add(this.cbPort);
            this.gbConfig.Location = new System.Drawing.Point(18, 49);
            this.gbConfig.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConfig.Name = "gbConfig";
            this.gbConfig.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConfig.Size = new System.Drawing.Size(416, 569);
            this.gbConfig.TabIndex = 0;
            this.gbConfig.TabStop = false;
            this.gbConfig.Text = "Serialport Config";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 329);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Request to Send:";
            this.label8.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 285);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Data Terminal Ready:";
            this.label9.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Stopbits:";
            this.label7.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 202);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Handshake:";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Parity:";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Databits:";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Baudrate:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            // 
            // bCreateSP
            // 
            this.bCreateSP.Location = new System.Drawing.Point(294, 363);
            this.bCreateSP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bCreateSP.Name = "bCreateSP";
            this.bCreateSP.Size = new System.Drawing.Size(112, 35);
            this.bCreateSP.TabIndex = 4;
            this.bCreateSP.Text = "Open";
            this.bCreateSP.UseVisualStyleBackColor = true;
            this.bCreateSP.Click += new System.EventHandler(this.bCreateSP_Click);
            // 
            // cbRtsEnable
            // 
            this.cbRtsEnable.FormattingEnabled = true;
            this.cbRtsEnable.Location = new System.Drawing.Point(189, 322);
            this.cbRtsEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRtsEnable.Name = "cbRtsEnable";
            this.cbRtsEnable.Size = new System.Drawing.Size(216, 28);
            this.cbRtsEnable.TabIndex = 3;
            // 
            // cbDtrEnable
            // 
            this.cbDtrEnable.FormattingEnabled = true;
            this.cbDtrEnable.Location = new System.Drawing.Point(189, 280);
            this.cbDtrEnable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDtrEnable.Name = "cbDtrEnable";
            this.cbDtrEnable.Size = new System.Drawing.Size(216, 28);
            this.cbDtrEnable.TabIndex = 3;
            // 
            // cbStopbits
            // 
            this.cbStopbits.FormattingEnabled = true;
            this.cbStopbits.Location = new System.Drawing.Point(189, 238);
            this.cbStopbits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbStopbits.Name = "cbStopbits";
            this.cbStopbits.Size = new System.Drawing.Size(216, 28);
            this.cbStopbits.TabIndex = 3;
            // 
            // cbHandshake
            // 
            this.cbHandshake.FormattingEnabled = true;
            this.cbHandshake.Location = new System.Drawing.Point(189, 197);
            this.cbHandshake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbHandshake.Name = "cbHandshake";
            this.cbHandshake.Size = new System.Drawing.Size(216, 28);
            this.cbHandshake.TabIndex = 3;
            // 
            // cbParity
            // 
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(189, 155);
            this.cbParity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(216, 28);
            this.cbParity.TabIndex = 3;
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Location = new System.Drawing.Point(189, 114);
            this.cbDataBits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(216, 28);
            this.cbDataBits.TabIndex = 3;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(189, 72);
            this.cbBaudRate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(216, 28);
            this.cbBaudRate.TabIndex = 2;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(189, 31);
            this.cbPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(216, 28);
            this.cbPort.TabIndex = 1;
            // 
            // gbData
            // 
            this.gbData.AutoSize = true;
            this.gbData.Controls.Add(this.bt_W500);
            this.gbData.Controls.Add(this.bt_W400);
            this.gbData.Controls.Add(this.bt_W75);
            this.gbData.Controls.Add(this.bt_W250);
            this.gbData.Controls.Add(this.bt_W200);
            this.gbData.Controls.Add(this.bt_w150);
            this.gbData.Controls.Add(this.bt_w25);
            this.gbData.Controls.Add(this.bt_k);
            this.gbData.Controls.Add(this.bt_k25);
            this.gbData.Controls.Add(this.bt_k15);
            this.gbData.Controls.Add(this.bt_B);
            this.gbData.Controls.Add(this.bt_Z);
            this.gbData.Controls.Add(this.bt_W50);
            this.gbData.Controls.Add(this.bt_O);
            this.gbData.Controls.Add(this.bt_H);
            this.gbData.Controls.Add(this.bt_U);
            this.gbData.Controls.Add(this.progressBarConnected);
            this.gbData.Controls.Add(this.bt_F);
            this.gbData.Controls.Add(this.bt_W100);
            this.gbData.Controls.Add(this.bt_kls);
            this.gbData.Controls.Add(this.lable_connected);
            this.gbData.Controls.Add(this.bt_D);
            this.gbData.Controls.Add(this.bt_I);
            this.gbData.Controls.Add(this.bt_S);
            this.gbData.Controls.Add(this.bClearSent);
            this.gbData.Controls.Add(this.bSendData);
            this.gbData.Controls.Add(this.tbDataToSend);
            this.gbData.Controls.Add(this.lbSent);
            this.gbData.Location = new System.Drawing.Point(442, 49);
            this.gbData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbData.Size = new System.Drawing.Size(1149, 818);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // bt_W500
            // 
            this.bt_W500.Enabled = false;
            this.bt_W500.Location = new System.Drawing.Point(734, 135);
            this.bt_W500.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_W500.Name = "bt_W500";
            this.bt_W500.Size = new System.Drawing.Size(112, 35);
            this.bt_W500.TabIndex = 29;
            this.bt_W500.Text = "W500";
            this.bt_W500.UseVisualStyleBackColor = true;
            this.bt_W500.Click += new System.EventHandler(this.bt_W500_Click);
            // 
            // bt_W400
            // 
            this.bt_W400.Enabled = false;
            this.bt_W400.Location = new System.Drawing.Point(614, 135);
            this.bt_W400.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_W400.Name = "bt_W400";
            this.bt_W400.Size = new System.Drawing.Size(112, 35);
            this.bt_W400.TabIndex = 28;
            this.bt_W400.Text = "W400";
            this.bt_W400.UseVisualStyleBackColor = true;
            this.bt_W400.Click += new System.EventHandler(this.bt_W400_Click);
            // 
            // bt_W75
            // 
            this.bt_W75.Enabled = false;
            this.bt_W75.Location = new System.Drawing.Point(734, 45);
            this.bt_W75.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_W75.Name = "bt_W75";
            this.bt_W75.Size = new System.Drawing.Size(112, 35);
            this.bt_W75.TabIndex = 27;
            this.bt_W75.Text = "W75";
            this.bt_W75.UseVisualStyleBackColor = true;
            this.bt_W75.Click += new System.EventHandler(this.bt_W75_Click);
            // 
            // bt_W250
            // 
            this.bt_W250.Enabled = false;
            this.bt_W250.Location = new System.Drawing.Point(494, 135);
            this.bt_W250.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_W250.Name = "bt_W250";
            this.bt_W250.Size = new System.Drawing.Size(112, 35);
            this.bt_W250.TabIndex = 26;
            this.bt_W250.Text = "W250";
            this.bt_W250.UseVisualStyleBackColor = true;
            this.bt_W250.Click += new System.EventHandler(this.bt_W250_Click);
            // 
            // bt_W200
            // 
            this.bt_W200.Enabled = false;
            this.bt_W200.Location = new System.Drawing.Point(734, 90);
            this.bt_W200.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_W200.Name = "bt_W200";
            this.bt_W200.Size = new System.Drawing.Size(112, 35);
            this.bt_W200.TabIndex = 25;
            this.bt_W200.Text = "W200";
            this.bt_W200.UseVisualStyleBackColor = true;
            this.bt_W200.Click += new System.EventHandler(this.bt_W200_Click);
            // 
            // bt_w150
            // 
            this.bt_w150.Enabled = false;
            this.bt_w150.Location = new System.Drawing.Point(614, 90);
            this.bt_w150.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_w150.Name = "bt_w150";
            this.bt_w150.Size = new System.Drawing.Size(112, 35);
            this.bt_w150.TabIndex = 24;
            this.bt_w150.Text = "W150";
            this.bt_w150.UseVisualStyleBackColor = true;
            this.bt_w150.Click += new System.EventHandler(this.bt_w150_Click);
            // 
            // bt_w25
            // 
            this.bt_w25.Enabled = false;
            this.bt_w25.Location = new System.Drawing.Point(494, 45);
            this.bt_w25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_w25.Name = "bt_w25";
            this.bt_w25.Size = new System.Drawing.Size(112, 35);
            this.bt_w25.TabIndex = 23;
            this.bt_w25.Text = "W25";
            this.bt_w25.UseVisualStyleBackColor = true;
            this.bt_w25.Click += new System.EventHandler(this.bt_w25_Click);
            // 
            // bt_k
            // 
            this.bt_k.Enabled = false;
            this.bt_k.Location = new System.Drawing.Point(374, 135);
            this.bt_k.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_k.Name = "bt_k";
            this.bt_k.Size = new System.Drawing.Size(112, 35);
            this.bt_k.TabIndex = 22;
            this.bt_k.Text = "k";
            this.bt_k.UseVisualStyleBackColor = true;
            this.bt_k.Click += new System.EventHandler(this.bt_k_Click);
            // 
            // bt_k25
            // 
            this.bt_k25.Enabled = false;
            this.bt_k25.Location = new System.Drawing.Point(374, 90);
            this.bt_k25.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_k25.Name = "bt_k25";
            this.bt_k25.Size = new System.Drawing.Size(112, 35);
            this.bt_k25.TabIndex = 21;
            this.bt_k25.Text = "k25";
            this.bt_k25.UseVisualStyleBackColor = true;
            this.bt_k25.Click += new System.EventHandler(this.bt_k25_Click);
            // 
            // bt_k15
            // 
            this.bt_k15.Enabled = false;
            this.bt_k15.Location = new System.Drawing.Point(374, 45);
            this.bt_k15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_k15.Name = "bt_k15";
            this.bt_k15.Size = new System.Drawing.Size(112, 35);
            this.bt_k15.TabIndex = 20;
            this.bt_k15.Text = "k15";
            this.bt_k15.UseVisualStyleBackColor = true;
            this.bt_k15.Click += new System.EventHandler(this.bt_k15_Click);
            // 
            // bt_B
            // 
            this.bt_B.Enabled = false;
            this.bt_B.Location = new System.Drawing.Point(854, 135);
            this.bt_B.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_B.Name = "bt_B";
            this.bt_B.Size = new System.Drawing.Size(112, 35);
            this.bt_B.TabIndex = 19;
            this.bt_B.Text = "B";
            this.bt_B.UseVisualStyleBackColor = true;
            this.bt_B.Click += new System.EventHandler(this.bt_B_Click);
            // 
            // bt_Z
            // 
            this.bt_Z.Enabled = false;
            this.bt_Z.Location = new System.Drawing.Point(134, 135);
            this.bt_Z.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_Z.Name = "bt_Z";
            this.bt_Z.Size = new System.Drawing.Size(112, 35);
            this.bt_Z.TabIndex = 18;
            this.bt_Z.Text = "Z";
            this.bt_Z.UseVisualStyleBackColor = true;
            this.bt_Z.Click += new System.EventHandler(this.bt_Z_Click);
            // 
            // bt_W50
            // 
            this.bt_W50.Enabled = false;
            this.bt_W50.Location = new System.Drawing.Point(614, 45);
            this.bt_W50.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_W50.Name = "bt_W50";
            this.bt_W50.Size = new System.Drawing.Size(112, 35);
            this.bt_W50.TabIndex = 17;
            this.bt_W50.Text = "W50";
            this.bt_W50.UseVisualStyleBackColor = true;
            this.bt_W50.Click += new System.EventHandler(this.bt_W50_Click);
            // 
            // bt_O
            // 
            this.bt_O.Enabled = false;
            this.bt_O.Location = new System.Drawing.Point(254, 90);
            this.bt_O.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_O.Name = "bt_O";
            this.bt_O.Size = new System.Drawing.Size(112, 35);
            this.bt_O.TabIndex = 16;
            this.bt_O.Text = "O";
            this.bt_O.UseVisualStyleBackColor = true;
            this.bt_O.Click += new System.EventHandler(this.bt_O_Click);
            // 
            // bt_H
            // 
            this.bt_H.Enabled = false;
            this.bt_H.Location = new System.Drawing.Point(254, 135);
            this.bt_H.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_H.Name = "bt_H";
            this.bt_H.Size = new System.Drawing.Size(112, 35);
            this.bt_H.TabIndex = 15;
            this.bt_H.Text = "H";
            this.bt_H.UseVisualStyleBackColor = true;
            this.bt_H.Click += new System.EventHandler(this.bt_H_Click);
            // 
            // bt_U
            // 
            this.bt_U.Enabled = false;
            this.bt_U.Location = new System.Drawing.Point(254, 45);
            this.bt_U.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_U.Name = "bt_U";
            this.bt_U.Size = new System.Drawing.Size(112, 35);
            this.bt_U.TabIndex = 14;
            this.bt_U.Text = "U";
            this.bt_U.UseVisualStyleBackColor = true;
            this.bt_U.Click += new System.EventHandler(this.bt_U_Click);
            // 
            // progressBarConnected
            // 
            this.progressBarConnected.Location = new System.Drawing.Point(947, 56);
            this.progressBarConnected.Name = "progressBarConnected";
            this.progressBarConnected.Size = new System.Drawing.Size(194, 24);
            this.progressBarConnected.TabIndex = 13;
            // 
            // bt_F
            // 
            this.bt_F.Enabled = false;
            this.bt_F.Location = new System.Drawing.Point(14, 135);
            this.bt_F.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_F.Name = "bt_F";
            this.bt_F.Size = new System.Drawing.Size(112, 35);
            this.bt_F.TabIndex = 12;
            this.bt_F.Text = "F";
            this.bt_F.UseVisualStyleBackColor = true;
            this.bt_F.Click += new System.EventHandler(this.bt_F_Click);
            // 
            // bt_W100
            // 
            this.bt_W100.Enabled = false;
            this.bt_W100.Location = new System.Drawing.Point(494, 90);
            this.bt_W100.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_W100.Name = "bt_W100";
            this.bt_W100.Size = new System.Drawing.Size(112, 35);
            this.bt_W100.TabIndex = 11;
            this.bt_W100.Text = "W100";
            this.bt_W100.UseVisualStyleBackColor = true;
            this.bt_W100.Click += new System.EventHandler(this.bt_W100_Click);
            // 
            // bt_kls
            // 
            this.bt_kls.Enabled = false;
            this.bt_kls.Location = new System.Drawing.Point(134, 90);
            this.bt_kls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_kls.Name = "bt_kls";
            this.bt_kls.Size = new System.Drawing.Size(112, 35);
            this.bt_kls.TabIndex = 10;
            this.bt_kls.Text = "s";
            this.bt_kls.UseVisualStyleBackColor = true;
            this.bt_kls.Click += new System.EventHandler(this.bt_kls_Click);
            // 
            // lable_connected
            // 
            this.lable_connected.AutoSize = true;
            this.lable_connected.Location = new System.Drawing.Point(1026, 31);
            this.lable_connected.Name = "lable_connected";
            this.lable_connected.Size = new System.Drawing.Size(58, 20);
            this.lable_connected.TabIndex = 9;
            this.lable_connected.Text = "Closed";
            // 
            // bt_D
            // 
            this.bt_D.Enabled = false;
            this.bt_D.Location = new System.Drawing.Point(14, 90);
            this.bt_D.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_D.Name = "bt_D";
            this.bt_D.Size = new System.Drawing.Size(112, 35);
            this.bt_D.TabIndex = 8;
            this.bt_D.Text = "D";
            this.bt_D.UseVisualStyleBackColor = true;
            this.bt_D.Click += new System.EventHandler(this.bt_D_Click);
            // 
            // bt_I
            // 
            this.bt_I.Enabled = false;
            this.bt_I.Location = new System.Drawing.Point(14, 45);
            this.bt_I.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_I.Name = "bt_I";
            this.bt_I.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bt_I.Size = new System.Drawing.Size(112, 35);
            this.bt_I.TabIndex = 7;
            this.bt_I.Text = "I";
            this.bt_I.UseVisualStyleBackColor = true;
            this.bt_I.Click += new System.EventHandler(this.bt_I_Click);
            // 
            // bt_S
            // 
            this.bt_S.Enabled = false;
            this.bt_S.Location = new System.Drawing.Point(134, 45);
            this.bt_S.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_S.Name = "bt_S";
            this.bt_S.Size = new System.Drawing.Size(112, 35);
            this.bt_S.TabIndex = 6;
            this.bt_S.Text = "S";
            this.bt_S.UseVisualStyleBackColor = true;
            this.bt_S.Click += new System.EventHandler(this.bt_S_Click);
            // 
            // bClearSent
            // 
            this.bClearSent.Location = new System.Drawing.Point(1029, 231);
            this.bClearSent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClearSent.Name = "bClearSent";
            this.bClearSent.Size = new System.Drawing.Size(112, 35);
            this.bClearSent.TabIndex = 5;
            this.bClearSent.Text = "Clear";
            this.bClearSent.UseVisualStyleBackColor = true;
            this.bClearSent.Click += new System.EventHandler(this.bClearSent_Click);
            // 
            // bSendData
            // 
            this.bSendData.Enabled = false;
            this.bSendData.Location = new System.Drawing.Point(1029, 193);
            this.bSendData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSendData.Name = "bSendData";
            this.bSendData.Size = new System.Drawing.Size(112, 35);
            this.bSendData.TabIndex = 4;
            this.bSendData.Text = "Send";
            this.bSendData.UseVisualStyleBackColor = true;
            this.bSendData.Click += new System.EventHandler(this.bSendData_Click);
            // 
            // tbDataToSend
            // 
            this.tbDataToSend.Enabled = false;
            this.tbDataToSend.Location = new System.Drawing.Point(18, 197);
            this.tbDataToSend.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDataToSend.Name = "tbDataToSend";
            this.tbDataToSend.Size = new System.Drawing.Size(1002, 26);
            this.tbDataToSend.TabIndex = 3;
            this.tbDataToSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbDataToSend_KeyDown);
            // 
            // lbSent
            // 
            this.lbSent.FormattingEnabled = true;
            this.lbSent.ItemHeight = 20;
            this.lbSent.Location = new System.Drawing.Point(12, 265);
            this.lbSent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbSent.Name = "lbSent";
            this.lbSent.Size = new System.Drawing.Size(1128, 524);
            this.lbSent.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 626);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 214);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1596, 35);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 29);
            this.toolStripMenuItem1.Text = "Datei";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.dateiToolStripMenuItem.Text = "Beenden";
            this.dateiToolStripMenuItem.Click += new System.EventHandler(this.dateiToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(56, 29);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 852);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BikeTest by John Lebherz";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConfig.ResumeLayout(false);
            this.gbConfig.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bCreateSP;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button bClearSent;
        private System.Windows.Forms.Button bSendData;
        private System.Windows.Forms.TextBox tbDataToSend;
        private System.Windows.Forms.ListBox lbSent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRtsEnable;
        private System.Windows.Forms.ComboBox cbDtrEnable;
        private System.Windows.Forms.ComboBox cbStopbits;
        private System.Windows.Forms.ComboBox cbHandshake;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Button bt_S;
        private System.Windows.Forms.Button bt_D;
        private System.Windows.Forms.Button bt_I;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lable_connected;
        private System.Windows.Forms.Button bt_F;
        private System.Windows.Forms.Button bt_W100;
        private System.Windows.Forms.Button bt_kls;
        private System.Windows.Forms.ProgressBar progressBarConnected;
        private System.Windows.Forms.Button bt_H;
        private System.Windows.Forms.Button bt_U;
        private System.Windows.Forms.Button bt_Z;
        private System.Windows.Forms.Button bt_W50;
        private System.Windows.Forms.Button bt_O;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button bt_B;
        private System.Windows.Forms.Button bt_k;
        private System.Windows.Forms.Button bt_k25;
        private System.Windows.Forms.Button bt_k15;
        private System.Windows.Forms.Button bt_w25;
        private System.Windows.Forms.Button bt_W250;
        private System.Windows.Forms.Button bt_W200;
        private System.Windows.Forms.Button bt_w150;
        private System.Windows.Forms.Button bt_W500;
        private System.Windows.Forms.Button bt_W400;
        private System.Windows.Forms.Button bt_W75;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

