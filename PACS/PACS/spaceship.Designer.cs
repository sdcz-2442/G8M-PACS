
namespace PACS
{
    partial class spaceship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(spaceship));
            this.lbl_spaceshipname = new System.Windows.Forms.Label();
            this.cbx_selectplanet = new System.Windows.Forms.ComboBox();
            this.cbx_codedelivery = new System.Windows.Forms.ComboBox();
            this.cbx_deliverydate = new System.Windows.Forms.ComboBox();
            this.btn_networkrequest = new System.Windows.Forms.Button();
            this.lbx_console = new System.Windows.Forms.ListBox();
            this.lbl_networkstatus = new System.Windows.Forms.Label();
            this.tbx_ipplanet = new System.Windows.Forms.TextBox();
            this.tbx_port = new System.Windows.Forms.TextBox();
            this.cbx_messages = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_sendmessage = new System.Windows.Forms.Button();
            this.lbl_events = new System.Windows.Forms.ListBox();
            this.btn_sendfiles = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_decomp = new System.Windows.Forms.Button();
            this.btn_sendvalidationcode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_spaceshipname
            // 
            this.lbl_spaceshipname.AutoSize = true;
            this.lbl_spaceshipname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_spaceshipname.Enabled = false;
            this.lbl_spaceshipname.Font = new System.Drawing.Font("SimSun-ExtB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_spaceshipname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_spaceshipname.Location = new System.Drawing.Point(22, 19);
            this.lbl_spaceshipname.Name = "lbl_spaceshipname";
            this.lbl_spaceshipname.Size = new System.Drawing.Size(186, 35);
            this.lbl_spaceshipname.TabIndex = 0;
            this.lbl_spaceshipname.Text = "Spaceship";
            // 
            // cbx_selectplanet
            // 
            this.cbx_selectplanet.FormattingEnabled = true;
            this.cbx_selectplanet.Location = new System.Drawing.Point(154, 232);
            this.cbx_selectplanet.Name = "cbx_selectplanet";
            this.cbx_selectplanet.Size = new System.Drawing.Size(194, 21);
            this.cbx_selectplanet.TabIndex = 5;
            // 
            // cbx_codedelivery
            // 
            this.cbx_codedelivery.FormattingEnabled = true;
            this.cbx_codedelivery.Location = new System.Drawing.Point(154, 260);
            this.cbx_codedelivery.Name = "cbx_codedelivery";
            this.cbx_codedelivery.Size = new System.Drawing.Size(194, 21);
            this.cbx_codedelivery.TabIndex = 6;
            // 
            // cbx_deliverydate
            // 
            this.cbx_deliverydate.FormattingEnabled = true;
            this.cbx_deliverydate.Location = new System.Drawing.Point(154, 288);
            this.cbx_deliverydate.Name = "cbx_deliverydate";
            this.cbx_deliverydate.Size = new System.Drawing.Size(194, 21);
            this.cbx_deliverydate.TabIndex = 7;
            // 
            // btn_networkrequest
            // 
            this.btn_networkrequest.BackColor = System.Drawing.Color.Maroon;
            this.btn_networkrequest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_networkrequest.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_networkrequest.Location = new System.Drawing.Point(231, 12);
            this.btn_networkrequest.Name = "btn_networkrequest";
            this.btn_networkrequest.Size = new System.Drawing.Size(117, 23);
            this.btn_networkrequest.TabIndex = 1;
            this.btn_networkrequest.Text = "Network Request";
            this.btn_networkrequest.UseVisualStyleBackColor = false;
            this.btn_networkrequest.Click += new System.EventHandler(this.btn_networkrequest_Click);
            // 
            // lbx_console
            // 
            this.lbx_console.BackColor = System.Drawing.Color.Maroon;
            this.lbx_console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbx_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.ItemHeight = 16;
            this.lbx_console.Location = new System.Drawing.Point(27, 114);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(321, 96);
            this.lbx_console.TabIndex = 0;
            // 
            // lbl_networkstatus
            // 
            this.lbl_networkstatus.AutoSize = true;
            this.lbl_networkstatus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_networkstatus.Enabled = false;
            this.lbl_networkstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_networkstatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_networkstatus.Location = new System.Drawing.Point(25, 84);
            this.lbl_networkstatus.Name = "lbl_networkstatus";
            this.lbl_networkstatus.Size = new System.Drawing.Size(97, 16);
            this.lbl_networkstatus.TabIndex = 0;
            this.lbl_networkstatus.Text = "Network Status";
            // 
            // tbx_ipplanet
            // 
            this.tbx_ipplanet.Location = new System.Drawing.Point(137, 82);
            this.tbx_ipplanet.Name = "tbx_ipplanet";
            this.tbx_ipplanet.Size = new System.Drawing.Size(127, 20);
            this.tbx_ipplanet.TabIndex = 3;
            this.tbx_ipplanet.Text = "127.0.0.1";
            // 
            // tbx_port
            // 
            this.tbx_port.Location = new System.Drawing.Point(270, 82);
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(78, 20);
            this.tbx_port.TabIndex = 4;
            this.tbx_port.Text = "8080";
            // 
            // cbx_messages
            // 
            this.cbx_messages.FormattingEnabled = true;
            this.cbx_messages.Items.AddRange(new object[] {
            "ER - Entry Requirement",
            "VK - Validation Key"});
            this.cbx_messages.Location = new System.Drawing.Point(154, 337);
            this.cbx_messages.Name = "cbx_messages";
            this.cbx_messages.Size = new System.Drawing.Size(194, 21);
            this.cbx_messages.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(24, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Planet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(24, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Code Delivery";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(24, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Delivery Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(25, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Send Message";
            // 
            // btn_sendmessage
            // 
            this.btn_sendmessage.BackColor = System.Drawing.Color.Maroon;
            this.btn_sendmessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sendmessage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sendmessage.Location = new System.Drawing.Point(234, 365);
            this.btn_sendmessage.Name = "btn_sendmessage";
            this.btn_sendmessage.Size = new System.Drawing.Size(114, 23);
            this.btn_sendmessage.TabIndex = 9;
            this.btn_sendmessage.Text = "Send Message";
            this.btn_sendmessage.UseVisualStyleBackColor = false;
            this.btn_sendmessage.Click += new System.EventHandler(this.btn_sendmessage_Click);
            // 
            // lbl_events
            // 
            this.lbl_events.BackColor = System.Drawing.Color.Maroon;
            this.lbl_events.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_events.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_events.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_events.FormattingEnabled = true;
            this.lbl_events.ItemHeight = 15;
            this.lbl_events.Location = new System.Drawing.Point(27, 485);
            this.lbl_events.Name = "lbl_events";
            this.lbl_events.Size = new System.Drawing.Size(321, 152);
            this.lbl_events.TabIndex = 0;
            // 
            // btn_sendfiles
            // 
            this.btn_sendfiles.BackColor = System.Drawing.Color.Maroon;
            this.btn_sendfiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sendfiles.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sendfiles.Location = new System.Drawing.Point(234, 423);
            this.btn_sendfiles.Name = "btn_sendfiles";
            this.btn_sendfiles.Size = new System.Drawing.Size(114, 23);
            this.btn_sendfiles.TabIndex = 11;
            this.btn_sendfiles.Text = "Send File";
            this.btn_sendfiles.UseVisualStyleBackColor = false;
            this.btn_sendfiles.Click += new System.EventHandler(this.btn_sendfiles_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Maroon;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_connect.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_connect.Location = new System.Drawing.Point(231, 41);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(117, 23);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_decomp
            // 
            this.btn_decomp.BackColor = System.Drawing.Color.Brown;
            this.btn_decomp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_decomp.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_decomp.Location = new System.Drawing.Point(234, 452);
            this.btn_decomp.Name = "btn_decomp";
            this.btn_decomp.Size = new System.Drawing.Size(114, 23);
            this.btn_decomp.TabIndex = 12;
            this.btn_decomp.Text = "Decode File";
            this.btn_decomp.UseVisualStyleBackColor = false;
            this.btn_decomp.Click += new System.EventHandler(this.btn_decomp_Click);
            // 
            // btn_sendvalidationcode
            // 
            this.btn_sendvalidationcode.BackColor = System.Drawing.Color.Maroon;
            this.btn_sendvalidationcode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sendvalidationcode.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_sendvalidationcode.Location = new System.Drawing.Point(234, 394);
            this.btn_sendvalidationcode.Name = "btn_sendvalidationcode";
            this.btn_sendvalidationcode.Size = new System.Drawing.Size(114, 23);
            this.btn_sendvalidationcode.TabIndex = 10;
            this.btn_sendvalidationcode.Text = "Send Validation Code";
            this.btn_sendvalidationcode.UseVisualStyleBackColor = false;
            this.btn_sendvalidationcode.Click += new System.EventHandler(this.btn_sendvalidationcode_Click);
            // 
            // spaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PACS.Properties.Resources.jiFGbE;
            this.ClientSize = new System.Drawing.Size(375, 664);
            this.Controls.Add(this.btn_sendvalidationcode);
            this.Controls.Add(this.btn_decomp);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.btn_sendfiles);
            this.Controls.Add(this.lbl_events);
            this.Controls.Add(this.btn_sendmessage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_messages);
            this.Controls.Add(this.tbx_port);
            this.Controls.Add(this.tbx_ipplanet);
            this.Controls.Add(this.lbl_networkstatus);
            this.Controls.Add(this.lbx_console);
            this.Controls.Add(this.btn_networkrequest);
            this.Controls.Add(this.cbx_deliverydate);
            this.Controls.Add(this.cbx_codedelivery);
            this.Controls.Add(this.cbx_selectplanet);
            this.Controls.Add(this.lbl_spaceshipname);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "spaceship";
            this.Opacity = 0.97D;
            this.Text = "Spaceship";
            this.Load += new System.EventHandler(this.spaceship_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_spaceshipname;
        private System.Windows.Forms.ComboBox cbx_selectplanet;
        private System.Windows.Forms.ComboBox cbx_codedelivery;
        private System.Windows.Forms.ComboBox cbx_deliverydate;
        private System.Windows.Forms.Button btn_networkrequest;
        private System.Windows.Forms.ListBox lbx_console;
        private System.Windows.Forms.Label lbl_networkstatus;
        private System.Windows.Forms.TextBox tbx_ipplanet;
        private System.Windows.Forms.TextBox tbx_port;
        private System.Windows.Forms.ComboBox cbx_messages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_sendmessage;
        private System.Windows.Forms.ListBox lbl_events;
        private System.Windows.Forms.Button btn_sendfiles;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_decomp;
        private System.Windows.Forms.Button btn_sendvalidationcode;
    }
}

