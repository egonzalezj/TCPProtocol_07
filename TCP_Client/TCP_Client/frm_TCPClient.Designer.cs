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
            this.txt_height = new System.Windows.Forms.TextBox();
            this.lbl_height = new System.Windows.Forms.Label();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.lbl_width = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_browse = new System.Windows.Forms.Button();
            this.txt_loadSVG = new System.Windows.Forms.TextBox();
            this.lbl_loadSVG = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
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
            resources.ApplyResources(this.txt_connectionStatus, "txt_connectionStatus");
            this.txt_connectionStatus.BackColor = System.Drawing.Color.Red;
            this.txt_connectionStatus.ForeColor = System.Drawing.Color.White;
            this.txt_connectionStatus.Name = "txt_connectionStatus";
            this.txt_connectionStatus.ReadOnly = true;
            // 
            // lbl_connectionStatus
            // 
            resources.ApplyResources(this.lbl_connectionStatus, "lbl_connectionStatus");
            this.lbl_connectionStatus.Name = "lbl_connectionStatus";
            // 
            // txt_localPort
            // 
            resources.ApplyResources(this.txt_localPort, "txt_localPort");
            this.txt_localPort.BackColor = System.Drawing.Color.White;
            this.txt_localPort.Name = "txt_localPort";
            this.txt_localPort.ReadOnly = true;
            // 
            // lbl_localPort
            // 
            resources.ApplyResources(this.lbl_localPort, "lbl_localPort");
            this.lbl_localPort.Name = "lbl_localPort";
            // 
            // lbl_localIP
            // 
            resources.ApplyResources(this.lbl_localIP, "lbl_localIP");
            this.lbl_localIP.Name = "lbl_localIP";
            // 
            // txt_localIP
            // 
            resources.ApplyResources(this.txt_localIP, "txt_localIP");
            this.txt_localIP.BackColor = System.Drawing.Color.White;
            this.txt_localIP.Name = "txt_localIP";
            this.txt_localIP.ReadOnly = true;
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.Name = "btn_close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_connect
            // 
            resources.ApplyResources(this.btn_connect, "btn_connect");
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // txt_serverPort
            // 
            resources.ApplyResources(this.txt_serverPort, "txt_serverPort");
            this.txt_serverPort.Name = "txt_serverPort";
            // 
            // lbl_serverPort
            // 
            resources.ApplyResources(this.lbl_serverPort, "lbl_serverPort");
            this.lbl_serverPort.Name = "lbl_serverPort";
            // 
            // txt_serverIP_4
            // 
            resources.ApplyResources(this.txt_serverIP_4, "txt_serverIP_4");
            this.txt_serverIP_4.Name = "txt_serverIP_4";
            // 
            // txt_serverIP_3
            // 
            resources.ApplyResources(this.txt_serverIP_3, "txt_serverIP_3");
            this.txt_serverIP_3.Name = "txt_serverIP_3";
            // 
            // txt_serverIP_2
            // 
            resources.ApplyResources(this.txt_serverIP_2, "txt_serverIP_2");
            this.txt_serverIP_2.Name = "txt_serverIP_2";
            // 
            // txt_serverIP_1
            // 
            resources.ApplyResources(this.txt_serverIP_1, "txt_serverIP_1");
            this.txt_serverIP_1.Name = "txt_serverIP_1";
            // 
            // lbl_serverIP
            // 
            resources.ApplyResources(this.lbl_serverIP, "lbl_serverIP");
            this.lbl_serverIP.Name = "lbl_serverIP";
            // 
            // gb_connectionOptions
            // 
            resources.ApplyResources(this.gb_connectionOptions, "gb_connectionOptions");
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
            this.gb_connectionOptions.Name = "gb_connectionOptions";
            this.gb_connectionOptions.TabStop = false;
            // 
            // gb_svgOptions
            // 
            resources.ApplyResources(this.gb_svgOptions, "gb_svgOptions");
            this.gb_svgOptions.Controls.Add(this.txt_height);
            this.gb_svgOptions.Controls.Add(this.lbl_height);
            this.gb_svgOptions.Controls.Add(this.txt_width);
            this.gb_svgOptions.Controls.Add(this.lbl_width);
            this.gb_svgOptions.Controls.Add(this.txt_name);
            this.gb_svgOptions.Controls.Add(this.lbl_name);
            this.gb_svgOptions.Controls.Add(this.btn_browse);
            this.gb_svgOptions.Controls.Add(this.txt_loadSVG);
            this.gb_svgOptions.Controls.Add(this.lbl_loadSVG);
            this.gb_svgOptions.Name = "gb_svgOptions";
            this.gb_svgOptions.TabStop = false;
            // 
            // txt_height
            // 
            resources.ApplyResources(this.txt_height, "txt_height");
            this.txt_height.BackColor = System.Drawing.Color.White;
            this.txt_height.Name = "txt_height";
            this.txt_height.ReadOnly = true;
            // 
            // lbl_height
            // 
            resources.ApplyResources(this.lbl_height, "lbl_height");
            this.lbl_height.Name = "lbl_height";
            // 
            // txt_width
            // 
            resources.ApplyResources(this.txt_width, "txt_width");
            this.txt_width.BackColor = System.Drawing.Color.White;
            this.txt_width.Name = "txt_width";
            this.txt_width.ReadOnly = true;
            // 
            // lbl_width
            // 
            resources.ApplyResources(this.lbl_width, "lbl_width");
            this.lbl_width.Name = "lbl_width";
            // 
            // txt_name
            // 
            resources.ApplyResources(this.txt_name, "txt_name");
            this.txt_name.BackColor = System.Drawing.Color.White;
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            // 
            // lbl_name
            // 
            resources.ApplyResources(this.lbl_name, "lbl_name");
            this.lbl_name.Name = "lbl_name";
            // 
            // btn_browse
            // 
            resources.ApplyResources(this.btn_browse, "btn_browse");
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // txt_loadSVG
            // 
            resources.ApplyResources(this.txt_loadSVG, "txt_loadSVG");
            this.txt_loadSVG.Name = "txt_loadSVG";
            // 
            // lbl_loadSVG
            // 
            resources.ApplyResources(this.lbl_loadSVG, "lbl_loadSVG");
            this.lbl_loadSVG.Name = "lbl_loadSVG";
            // 
            // pb_logo
            // 
            resources.ApplyResources(this.pb_logo, "pb_logo");
            this.pb_logo.BackColor = System.Drawing.Color.Transparent;
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.TabStop = false;
            // 
            // gp_svgPreview
            // 
            resources.ApplyResources(this.gp_svgPreview, "gp_svgPreview");
            this.gp_svgPreview.Controls.Add(this.pb_svg);
            this.gp_svgPreview.Name = "gp_svgPreview";
            this.gp_svgPreview.TabStop = false;
            // 
            // pb_svg
            // 
            resources.ApplyResources(this.pb_svg, "pb_svg");
            this.pb_svg.Name = "pb_svg";
            this.pb_svg.TabStop = false;
            // 
            // filePicker
            // 
            this.filePicker.DefaultExt = "svg";
            resources.ApplyResources(this.filePicker, "filePicker");
            // 
            // frm_TCPClient
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gp_svgPreview);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.gb_svgOptions);
            this.Controls.Add(this.gb_connectionOptions);
            this.Controls.Add(this.btn_close);
            this.Name = "frm_TCPClient";
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
        private System.Windows.Forms.TextBox txt_width;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.GroupBox gp_svgPreview;
        private System.Windows.Forms.PictureBox pb_svg;
        private System.Windows.Forms.OpenFileDialog filePicker;
    }
}

