
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
            this.btn_encryptpublickey = new System.Windows.Forms.Button();
            this.btn_decomp = new System.Windows.Forms.Button();
            this.btn_sendvalidationcode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_spaceshipname
            // 
            this.lbl_spaceshipname.AutoSize = true;
            this.lbl_spaceshipname.Location = new System.Drawing.Point(24, 9);
            this.lbl_spaceshipname.Name = "lbl_spaceshipname";
            this.lbl_spaceshipname.Size = new System.Drawing.Size(57, 13);
            this.lbl_spaceshipname.TabIndex = 0;
            this.lbl_spaceshipname.Text = "Spaceship";
            // 
            // cbx_selectplanet
            // 
            this.cbx_selectplanet.FormattingEnabled = true;
            this.cbx_selectplanet.Location = new System.Drawing.Point(104, 230);
            this.cbx_selectplanet.Name = "cbx_selectplanet";
            this.cbx_selectplanet.Size = new System.Drawing.Size(121, 21);
            this.cbx_selectplanet.TabIndex = 1;
            // 
            // cbx_codedelivery
            // 
            this.cbx_codedelivery.FormattingEnabled = true;
            this.cbx_codedelivery.Location = new System.Drawing.Point(104, 258);
            this.cbx_codedelivery.Name = "cbx_codedelivery";
            this.cbx_codedelivery.Size = new System.Drawing.Size(121, 21);
            this.cbx_codedelivery.TabIndex = 2;
            // 
            // cbx_deliverydate
            // 
            this.cbx_deliverydate.FormattingEnabled = true;
            this.cbx_deliverydate.Location = new System.Drawing.Point(104, 286);
            this.cbx_deliverydate.Name = "cbx_deliverydate";
            this.cbx_deliverydate.Size = new System.Drawing.Size(121, 21);
            this.cbx_deliverydate.TabIndex = 3;
            // 
            // btn_networkrequest
            // 
            this.btn_networkrequest.Location = new System.Drawing.Point(113, 9);
            this.btn_networkrequest.Name = "btn_networkrequest";
            this.btn_networkrequest.Size = new System.Drawing.Size(117, 23);
            this.btn_networkrequest.TabIndex = 4;
            this.btn_networkrequest.Text = "Network Request";
            this.btn_networkrequest.UseVisualStyleBackColor = true;
            this.btn_networkrequest.Click += new System.EventHandler(this.btn_networkrequest_Click);
            // 
            // lbx_console
            // 
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.Location = new System.Drawing.Point(27, 114);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(203, 95);
            this.lbx_console.TabIndex = 5;
            // 
            // lbl_networkstatus
            // 
            this.lbl_networkstatus.AutoSize = true;
            this.lbl_networkstatus.Location = new System.Drawing.Point(24, 66);
            this.lbl_networkstatus.Name = "lbl_networkstatus";
            this.lbl_networkstatus.Size = new System.Drawing.Size(80, 13);
            this.lbl_networkstatus.TabIndex = 6;
            this.lbl_networkstatus.Text = "Network Status";
            // 
            // tbx_ipplanet
            // 
            this.tbx_ipplanet.Location = new System.Drawing.Point(27, 83);
            this.tbx_ipplanet.Name = "tbx_ipplanet";
            this.tbx_ipplanet.Size = new System.Drawing.Size(100, 20);
            this.tbx_ipplanet.TabIndex = 7;
            this.tbx_ipplanet.Text = "127.0.0.1";
            // 
            // tbx_port
            // 
            this.tbx_port.Location = new System.Drawing.Point(152, 83);
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(78, 20);
            this.tbx_port.TabIndex = 8;
            this.tbx_port.Text = "8080";
            // 
            // cbx_messages
            // 
            this.cbx_messages.FormattingEnabled = true;
            this.cbx_messages.Items.AddRange(new object[] {
            "ER - Entry Requirement",
            "VR - Validation Result",
            "VK - Validation Key"});
            this.cbx_messages.Location = new System.Drawing.Point(104, 319);
            this.cbx_messages.Name = "cbx_messages";
            this.cbx_messages.Size = new System.Drawing.Size(121, 21);
            this.cbx_messages.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Planet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Code Delivery";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Delivery Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Send Message";
            // 
            // btn_sendmessage
            // 
            this.btn_sendmessage.Location = new System.Drawing.Point(113, 346);
            this.btn_sendmessage.Name = "btn_sendmessage";
            this.btn_sendmessage.Size = new System.Drawing.Size(114, 23);
            this.btn_sendmessage.TabIndex = 14;
            this.btn_sendmessage.Text = "Send Message";
            this.btn_sendmessage.UseVisualStyleBackColor = true;
            this.btn_sendmessage.Click += new System.EventHandler(this.btn_sendmessage_Click);
            // 
            // lbl_events
            // 
            this.lbl_events.FormattingEnabled = true;
            this.lbl_events.Location = new System.Drawing.Point(27, 434);
            this.lbl_events.Name = "lbl_events";
            this.lbl_events.Size = new System.Drawing.Size(203, 108);
            this.lbl_events.TabIndex = 15;
            // 
            // btn_sendfiles
            // 
            this.btn_sendfiles.Location = new System.Drawing.Point(113, 404);
            this.btn_sendfiles.Name = "btn_sendfiles";
            this.btn_sendfiles.Size = new System.Drawing.Size(114, 23);
            this.btn_sendfiles.TabIndex = 16;
            this.btn_sendfiles.Text = "Send File";
            this.btn_sendfiles.UseVisualStyleBackColor = true;
            this.btn_sendfiles.Click += new System.EventHandler(this.btn_sendfiles_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(113, 39);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(117, 23);
            this.btn_connect.TabIndex = 17;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_encryptpublickey
            // 
            this.btn_encryptpublickey.Location = new System.Drawing.Point(259, 404);
            this.btn_encryptpublickey.Name = "btn_encryptpublickey";
            this.btn_encryptpublickey.Size = new System.Drawing.Size(132, 23);
            this.btn_encryptpublickey.TabIndex = 18;
            this.btn_encryptpublickey.Text = "Get Validation Key";
            this.btn_encryptpublickey.UseVisualStyleBackColor = true;
            this.btn_encryptpublickey.Click += new System.EventHandler(this.btn_encryptpublickey_Click);
            // 
            // btn_decomp
            // 
            this.btn_decomp.Location = new System.Drawing.Point(259, 434);
            this.btn_decomp.Name = "btn_decomp";
            this.btn_decomp.Size = new System.Drawing.Size(132, 23);
            this.btn_decomp.TabIndex = 19;
            this.btn_decomp.Text = "Decode File";
            this.btn_decomp.UseVisualStyleBackColor = true;
            this.btn_decomp.Click += new System.EventHandler(this.btn_decomp_Click);
            // 
            // btn_sendvalidationcode
            // 
            this.btn_sendvalidationcode.Location = new System.Drawing.Point(113, 376);
            this.btn_sendvalidationcode.Name = "btn_sendvalidationcode";
            this.btn_sendvalidationcode.Size = new System.Drawing.Size(112, 23);
            this.btn_sendvalidationcode.TabIndex = 20;
            this.btn_sendvalidationcode.Text = "Send Validation Code";
            this.btn_sendvalidationcode.UseVisualStyleBackColor = true;
            this.btn_sendvalidationcode.Click += new System.EventHandler(this.btn_sendvalidationcode_Click);
            // 
            // spaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 568);
            this.Controls.Add(this.btn_sendvalidationcode);
            this.Controls.Add(this.btn_decomp);
            this.Controls.Add(this.btn_encryptpublickey);
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
            this.Name = "spaceship";
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
        private System.Windows.Forms.Button btn_encryptpublickey;
        private System.Windows.Forms.Button btn_decomp;
        private System.Windows.Forms.Button btn_sendvalidationcode;
    }
}

