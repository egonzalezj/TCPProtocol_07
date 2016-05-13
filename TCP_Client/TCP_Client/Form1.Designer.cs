namespace TCP_Client
{
    partial class frm_TCPClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TCPClient));
            this.txt_connectionStatus = new System.Windows.Forms.TextBox();
            this.lbl_connectionStatus = new System.Windows.Forms.Label();
            this.txt_localPort = new System.Windows.Forms.TextBox();
            this.lbl_localPort = new System.Windows.Forms.Label();
            this.lbl_localIP = new System.Windows.Forms.Label();
            this.txt_localIP = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_serverPort = new System.Windows.Forms.TextBox();
            this.lbl_serverPort = new System.Windows.Forms.Label();
            this.txt_serverIP_4 = new System.Windows.Forms.TextBox();
            this.txt_serverIP_3 = new System.Windows.Forms.TextBox();
            this.txt_serverIP_2 = new System.Windows.Forms.TextBox();
            this.txt_serverIP_1 = new System.Windows.Forms.TextBox();
            this.lbl_serverIP = new System.Windows.Forms.Label();
            this.gb_connectionOptions = new System.Windows.Forms.GroupBox();
            this.gb_svgOptions = new System.Windows.Forms.GroupBox();
            this.lbl_loadSVG = new System.Windows.Forms.Label();
            this.txt_loadSVG = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lbl_width = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.lbl_height = new System.Windows.Forms.Label();
            this.gp_svgPreview = new System.Windows.Forms.GroupBox();
            this.pb_svg = new System.Windows.Forms.PictureBox();
            this.filePicker = new System.Windows.Forms.OpenFileDialog();
            this.gb_connectionOptions.SuspendLayout();
            this.gb_svgOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.gp_svgPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_svg)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_connectionStatus
            // 
            this.txt_connectionStatus.BackColor = System.Drawing.Color.Red;
            this.txt_connectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_connectionStatus.ForeColor = System.Drawing.Color.White;
            this.txt_connectionStatus.Location = new System.Drawing.Point(365, 32);
            this.txt_connectionStatus.Name = "txt_connectionStatus";
            this.txt_connectionStatus.ReadOnly = true;
            this.txt_connectionStatus.Size = new System.Drawing.Size(100, 20);
            this.txt_connectionStatus.TabIndex = 11;
            this.txt_connectionStatus.Text = "Not connected!";
            this.txt_connectionStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_connectionStatus
            // 
            this.lbl_connectionStatus.AutoSize = true;
            this.lbl_connectionStatus.Location = new System.Drawing.Point(322, 35);
            this.lbl_connectionStatus.Name = "lbl_connectionStatus";
            this.lbl_connectionStatus.Size = new System.Drawing.Size(37, 13);
            this.lbl_connectionStatus.TabIndex = 10;
            this.lbl_connectionStatus.Text = "Status";
            // 
            // txt_localPort
            // 
            this.txt_localPort.BackColor = System.Drawing.Color.White;
            this.txt_localPort.Location = new System.Drawing.Point(231, 32);
            this.txt_localPort.Name = "txt_localPort";
            this.txt_localPort.ReadOnly = true;
            this.txt_localPort.Size = new System.Drawing.Size(57, 20);
            this.txt_localPort.TabIndex = 9;
            this.txt_localPort.Text = "0";
            this.txt_localPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_localPort
            // 
            this.lbl_localPort.AutoSize = true;
            this.lbl_localPort.Location = new System.Drawing.Point(170, 35);
            this.lbl_localPort.Name = "lbl_localPort";
            this.lbl_localPort.Size = new System.Drawing.Size(55, 13);
            this.lbl_localPort.TabIndex = 8;
            this.lbl_localPort.Text = "Local Port";
            // 
            // lbl_localIP
            // 
            this.lbl_localIP.AutoSize = true;
            this.lbl_localIP.Location = new System.Drawing.Point(6, 35);
            this.lbl_localIP.Name = "lbl_localIP";
            this.lbl_localIP.Size = new System.Drawing.Size(46, 13);
            this.lbl_localIP.TabIndex = 7;
            this.lbl_localIP.Text = "Local IP";
            // 
            // txt_localIP
            // 
            this.txt_localIP.BackColor = System.Drawing.Color.White;
            this.txt_localIP.Location = new System.Drawing.Point(57, 32);
            this.txt_localIP.Name = "txt_localIP";
            this.txt_localIP.ReadOnly = true;
            this.txt_localIP.Size = new System.Drawing.Size(107, 20);
            this.txt_localIP.TabIndex = 6;
            this.txt_localIP.Text = "127.0.0.1";
            this.txt_localIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(609, 624);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 35;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(390, 69);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 29;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // txt_serverPort
            // 
            this.txt_serverPort.Location = new System.Drawing.Point(316, 71);
            this.txt_serverPort.MaxLength = 5;
            this.txt_serverPort.Name = "txt_serverPort";
            this.txt_serverPort.Size = new System.Drawing.Size(57, 20);
            this.txt_serverPort.TabIndex = 28;
            this.txt_serverPort.Text = "0";
            this.txt_serverPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_serverPort
            // 
            this.lbl_serverPort.AutoSize = true;
            this.lbl_serverPort.Location = new System.Drawing.Point(250, 74);
            this.lbl_serverPort.Name = "lbl_serverPort";
            this.lbl_serverPort.Size = new System.Drawing.Size(60, 13);
            this.lbl_serverPort.TabIndex = 27;
            this.lbl_serverPort.Text = "Server Port";
            // 
            // txt_serverIP_4
            // 
            this.txt_serverIP_4.Location = new System.Drawing.Point(203, 71);
            this.txt_serverIP_4.MaxLength = 3;
            this.txt_serverIP_4.Name = "txt_serverIP_4";
            this.txt_serverIP_4.Size = new System.Drawing.Size(41, 20);
            this.txt_serverIP_4.TabIndex = 26;
            this.txt_serverIP_4.Text = "1";
            this.txt_serverIP_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_serverIP_3
            // 
            this.txt_serverIP_3.Location = new System.Drawing.Point(156, 71);
            this.txt_serverIP_3.MaxLength = 3;
            this.txt_serverIP_3.Name = "txt_serverIP_3";
            this.txt_serverIP_3.Size = new System.Drawing.Size(41, 20);
            this.txt_serverIP_3.TabIndex = 25;
            this.txt_serverIP_3.Text = "0";
            this.txt_serverIP_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_serverIP_2
            // 
            this.txt_serverIP_2.Location = new System.Drawing.Point(109, 71);
            this.txt_serverIP_2.MaxLength = 3;
            this.txt_serverIP_2.Name = "txt_serverIP_2";
            this.txt_serverIP_2.Size = new System.Drawing.Size(41, 20);
            this.txt_serverIP_2.TabIndex = 24;
            this.txt_serverIP_2.Text = "0";
            this.txt_serverIP_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_serverIP_1
            // 
            this.txt_serverIP_1.Location = new System.Drawing.Point(62, 71);
            this.txt_serverIP_1.MaxLength = 3;
            this.txt_serverIP_1.Name = "txt_serverIP_1";
            this.txt_serverIP_1.Size = new System.Drawing.Size(41, 20);
            this.txt_serverIP_1.TabIndex = 23;
            this.txt_serverIP_1.Text = "127";
            this.txt_serverIP_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_serverIP
            // 
            this.lbl_serverIP.AutoSize = true;
            this.lbl_serverIP.Location = new System.Drawing.Point(6, 74);
            this.lbl_serverIP.Name = "lbl_serverIP";
            this.lbl_serverIP.Size = new System.Drawing.Size(51, 13);
            this.lbl_serverIP.TabIndex = 22;
            this.lbl_serverIP.Text = "Server IP";
            // 
            // gb_connectionOptions
            // 
            this.gb_connectionOptions.BackColor = System.Drawing.Color.Transparent;
            this.gb_connectionOptions.Controls.Add(this.lbl_serverIP);
            this.gb_connectionOptions.Controls.Add(this.txt_serverIP_1);
            this.gb_connectionOptions.Controls.Add(this.txt_serverIP_2);
            this.gb_connectionOptions.Controls.Add(this.txt_serverIP_3);
            this.gb_connectionOptions.Controls.Add(this.txt_serverIP_4);
            this.gb_connectionOptions.Controls.Add(this.lbl_serverPort);
            this.gb_connectionOptions.Controls.Add(this.txt_serverPort);
            this.gb_connectionOptions.Controls.Add(this.btn_connect);
            this.gb_connectionOptions.Controls.Add(this.txt_localPort);
            this.gb_connectionOptions.Controls.Add(this.txt_connectionStatus);
            this.gb_connectionOptions.Controls.Add(this.lbl_localPort);
            this.gb_connectionOptions.Controls.Add(this.lbl_connectionStatus);
            this.gb_connectionOptions.Controls.Add(this.lbl_localIP);
            this.gb_connectionOptions.Controls.Add(this.txt_localIP);
            this.gb_connectionOptions.Location = new System.Drawing.Point(12, 12);
            this.gb_connectionOptions.Name = "gb_connectionOptions";
            this.gb_connectionOptions.Size = new System.Drawing.Size(475, 102);
            this.gb_connectionOptions.TabIndex = 36;
            this.gb_connectionOptions.TabStop = false;
            this.gb_connectionOptions.Text = "Connection Options";
            // 
            // gb_svgOptions
            // 
            this.gb_svgOptions.Controls.Add(this.txt_height);
            this.gb_svgOptions.Controls.Add(this.lbl_height);
            this.gb_svgOptions.Controls.Add(this.textBox1);
            this.gb_svgOptions.Controls.Add(this.lbl_width);
            this.gb_svgOptions.Controls.Add(this.txt_name);
            this.gb_svgOptions.Controls.Add(this.lbl_name);
            this.gb_svgOptions.Controls.Add(this.btn_browse);
            this.gb_svgOptions.Controls.Add(this.txt_loadSVG);
            this.gb_svgOptions.Controls.Add(this.lbl_loadSVG);
            this.gb_svgOptions.Location = new System.Drawing.Point(12, 120);
            this.gb_svgOptions.Name = "gb_svgOptions";
            this.gb_svgOptions.Size = new System.Drawing.Size(672, 94);
            this.gb_svgOptions.TabIndex = 37;
            this.gb_svgOptions.TabStop = false;
            this.gb_svgOptions.Text = "SVG Options";
            // 
            // lbl_loadSVG
            // 
            this.lbl_loadSVG.AutoSize = true;
            this.lbl_loadSVG.Location = new System.Drawing.Point(6, 31);
            this.lbl_loadSVG.Name = "lbl_loadSVG";
            this.lbl_loadSVG.Size = new System.Drawing.Size(56, 13);
            this.lbl_loadSVG.TabIndex = 0;
            this.lbl_loadSVG.Text = "Load SVG";
            // 
            // txt_loadSVG
            // 
            this.txt_loadSVG.Location = new System.Drawing.Point(68, 28);
            this.txt_loadSVG.Name = "txt_loadSVG";
            this.txt_loadSVG.Size = new System.Drawing.Size(517, 20);
            this.txt_loadSVG.TabIndex = 1;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(591, 26);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(6, 64);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "Name:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(50, 61);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(147, 20);
            this.txt_name.TabIndex = 4;
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
            this.pb_logo.Location = new System.Drawing.Point(586, 12);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(98, 102);
            this.pb_logo.TabIndex = 38;
            this.pb_logo.TabStop = false;
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(203, 64);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.Size = new System.Drawing.Size(38, 13);
            this.lbl_width.TabIndex = 5;
            this.lbl_width.Text = "Width:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(63, 20);
            this.textBox1.TabIndex = 6;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(360, 61);
            this.txt_height.Name = "txt_height";
            this.txt_height.ReadOnly = true;
            this.txt_height.Size = new System.Drawing.Size(63, 20);
            this.txt_height.TabIndex = 8;
            // 
            // lbl_height
            // 
            this.lbl_height.AutoSize = true;
            this.lbl_height.Location = new System.Drawing.Point(316, 64);
            this.lbl_height.Name = "lbl_height";
            this.lbl_height.Size = new System.Drawing.Size(41, 13);
            this.lbl_height.TabIndex = 7;
            this.lbl_height.Text = "Height:";
            // 
            // gp_svgPreview
            // 
            this.gp_svgPreview.Controls.Add(this.pb_svg);
            this.gp_svgPreview.Location = new System.Drawing.Point(12, 220);
            this.gp_svgPreview.Name = "gp_svgPreview";
            this.gp_svgPreview.Size = new System.Drawing.Size(420, 430);
            this.gp_svgPreview.TabIndex = 39;
            this.gp_svgPreview.TabStop = false;
            this.gp_svgPreview.Text = "SVG View";
            // 
            // pb_svg
            // 
            this.pb_svg.Location = new System.Drawing.Point(6, 19);
            this.pb_svg.Name = "pb_svg";
            this.pb_svg.Size = new System.Drawing.Size(408, 405);
            this.pb_svg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_svg.TabIndex = 0;
            this.pb_svg.TabStop = false;
            // 
            // filePicker
            // 
            this.filePicker.FileName = "openFileDialog1";
            // 
            // frm_TCPClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(696, 659);
            this.Controls.Add(this.gp_svgPreview);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.gb_svgOptions);
            this.Controls.Add(this.gb_connectionOptions);
            this.Controls.Add(this.btn_close);
            this.Name = "frm_TCPClient";
            this.Text = "TCP Client";
            this.gb_connectionOptions.ResumeLayout(false);
            this.gb_connectionOptions.PerformLayout();
            this.gb_svgOptions.ResumeLayout(false);
            this.gb_svgOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.gp_svgPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_svg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_connectionStatus;
        private System.Windows.Forms.Label lbl_connectionStatus;
        private System.Windows.Forms.TextBox txt_localPort;
        private System.Windows.Forms.Label lbl_localPort;
        private System.Windows.Forms.Label lbl_localIP;
        private System.Windows.Forms.TextBox txt_localIP;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_serverPort;
        private System.Windows.Forms.Label lbl_serverPort;
        private System.Windows.Forms.TextBox txt_serverIP_4;
        private System.Windows.Forms.TextBox txt_serverIP_3;
        private System.Windows.Forms.TextBox txt_serverIP_2;
        private System.Windows.Forms.TextBox txt_serverIP_1;
        private System.Windows.Forms.Label lbl_serverIP;
        private System.Windows.Forms.GroupBox gb_connectionOptions;
        private System.Windows.Forms.GroupBox gb_svgOptions;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox txt_loadSVG;
        private System.Windows.Forms.Label lbl_loadSVG;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.Label lbl_height;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.GroupBox gp_svgPreview;
        private System.Windows.Forms.PictureBox pb_svg;
        private System.Windows.Forms.OpenFileDialog filePicker;
    }
}

