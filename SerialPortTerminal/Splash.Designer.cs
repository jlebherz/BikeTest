namespace Biketest
{
    partial class Splash
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_top = new System.Windows.Forms.Label();
            this.bt_close = new System.Windows.Forms.Button();
            this.tb_ActivateString = new System.Windows.Forms.TextBox();
            this.bt_activate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 207);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_top
            // 
            this.lbl_top.AutoSize = true;
            this.lbl_top.Location = new System.Drawing.Point(121, 34);
            this.lbl_top.Name = "lbl_top";
            this.lbl_top.Size = new System.Drawing.Size(56, 20);
            this.lbl_top.TabIndex = 2;
            this.lbl_top.Text = "lbl_top";
            // 
            // bt_close
            // 
            this.bt_close.Location = new System.Drawing.Point(540, 23);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(90, 31);
            this.bt_close.TabIndex = 3;
            this.bt_close.Text = "Close";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Visible = false;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // tb_ActivateString
            // 
            this.tb_ActivateString.Location = new System.Drawing.Point(125, 92);
            this.tb_ActivateString.Name = "tb_ActivateString";
            this.tb_ActivateString.Size = new System.Drawing.Size(164, 26);
            this.tb_ActivateString.TabIndex = 4;
            this.tb_ActivateString.Visible = false;
            // 
            // bt_activate
            // 
            this.bt_activate.Location = new System.Drawing.Point(295, 91);
            this.bt_activate.Name = "bt_activate";
            this.bt_activate.Size = new System.Drawing.Size(90, 31);
            this.bt_activate.TabIndex = 5;
            this.bt_activate.Text = "Aktivieren";
            this.bt_activate.UseVisualStyleBackColor = true;
            this.bt_activate.Visible = false;
            this.bt_activate.Click += new System.EventHandler(this.bt_activate_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 503);
            this.ControlBox = false;
            this.Controls.Add(this.bt_activate);
            this.Controls.Add(this.tb_ActivateString);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.lbl_top);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            this.Shown += new System.EventHandler(this.Splash_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_top;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.TextBox tb_ActivateString;
        private System.Windows.Forms.Button bt_activate;
    }
}