
namespace G8_Starship
{
    partial class frm_spaceship
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbx_ipplanet = new System.Windows.Forms.TextBox();
            this.lbx_console = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_networkstatus = new System.Windows.Forms.Label();
            this.btn_sendping = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_privatekey = new System.Windows.Forms.Label();
            this.tbx_privatekey = new System.Windows.Forms.TextBox();
            this.btn_generatecoordinates = new System.Windows.Forms.Button();
            this.topbar = new System.Windows.Forms.Panel();
            this.minimize_click = new System.Windows.Forms.PictureBox();
            this.maximize_click = new System.Windows.Forms.PictureBox();
            this.close_click = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_click)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_click)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_click)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.tbx_ipplanet);
            this.panel1.Controls.Add(this.lbx_console);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_networkstatus);
            this.panel1.Controls.Add(this.btn_sendping);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 536);
            this.panel1.TabIndex = 0;
            // 
            // tbx_ipplanet
            // 
            this.tbx_ipplanet.Location = new System.Drawing.Point(64, 52);
            this.tbx_ipplanet.Multiline = true;
            this.tbx_ipplanet.Name = "tbx_ipplanet";
            this.tbx_ipplanet.Size = new System.Drawing.Size(151, 22);
            this.tbx_ipplanet.TabIndex = 4;
            // 
            // lbx_console
            // 
            this.lbx_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(31)))));
            this.lbx_console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbx_console.ForeColor = System.Drawing.Color.White;
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.Location = new System.Drawing.Point(32, 156);
            this.lbx_console.Margin = new System.Windows.Forms.Padding(1);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(320, 132);
            this.lbx_console.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label3.Location = new System.Drawing.Point(28, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Status:";
            // 
            // lbl_networkstatus
            // 
            this.lbl_networkstatus.AutoSize = true;
            this.lbl_networkstatus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_networkstatus.Font = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_networkstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.lbl_networkstatus.Location = new System.Drawing.Point(99, 126);
            this.lbl_networkstatus.Name = "lbl_networkstatus";
            this.lbl_networkstatus.Size = new System.Drawing.Size(72, 19);
            this.lbl_networkstatus.TabIndex = 16;
            this.lbl_networkstatus.Text = "Waiting...";
            // 
            // btn_sendping
            // 
            this.btn_sendping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.btn_sendping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_sendping.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_sendping.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_sendping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendping.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_sendping.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendping.Location = new System.Drawing.Point(223, 92);
            this.btn_sendping.Name = "btn_sendping";
            this.btn_sendping.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_sendping.Size = new System.Drawing.Size(129, 28);
            this.btn_sendping.TabIndex = 15;
            this.btn_sendping.Text = "Network Request";
            this.btn_sendping.UseVisualStyleBackColor = false;
            this.btn_sendping.Click += new System.EventHandler(this.btn_sendping_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label2.Location = new System.Drawing.Point(26, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "Communication System";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_privatekey);
            this.groupBox1.Controls.Add(this.tbx_privatekey);
            this.groupBox1.Controls.Add(this.btn_generatecoordinates);
            this.groupBox1.Font = new System.Drawing.Font("HP Simplified Hans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.groupBox1.Location = new System.Drawing.Point(577, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 152);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate coordinates";
            // 
            // lbl_privatekey
            // 
            this.lbl_privatekey.AutoSize = true;
            this.lbl_privatekey.Font = new System.Drawing.Font("HP Simplified Hans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_privatekey.Location = new System.Drawing.Point(28, 41);
            this.lbl_privatekey.Name = "lbl_privatekey";
            this.lbl_privatekey.Size = new System.Drawing.Size(154, 22);
            this.lbl_privatekey.TabIndex = 3;
            this.lbl_privatekey.Text = "Insert Private Key";
            // 
            // tbx_privatekey
            // 
            this.tbx_privatekey.Location = new System.Drawing.Point(32, 86);
            this.tbx_privatekey.Name = "tbx_privatekey";
            this.tbx_privatekey.Size = new System.Drawing.Size(129, 35);
            this.tbx_privatekey.TabIndex = 2;
            // 
            // btn_generatecoordinates
            // 
            this.btn_generatecoordinates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.btn_generatecoordinates.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_generatecoordinates.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_generatecoordinates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_generatecoordinates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generatecoordinates.Font = new System.Drawing.Font("Gill Sans MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generatecoordinates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_generatecoordinates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_generatecoordinates.Location = new System.Drawing.Point(180, 83);
            this.btn_generatecoordinates.Name = "btn_generatecoordinates";
            this.btn_generatecoordinates.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_generatecoordinates.Size = new System.Drawing.Size(113, 38);
            this.btn_generatecoordinates.TabIndex = 1;
            this.btn_generatecoordinates.Text = "Generate";
            this.btn_generatecoordinates.UseVisualStyleBackColor = false;
            // 
            // topbar
            // 
            this.topbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topbar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.topbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(6)))), ((int)(((byte)(14)))));
            this.topbar.Controls.Add(this.minimize_click);
            this.topbar.Controls.Add(this.maximize_click);
            this.topbar.Controls.Add(this.close_click);
            this.topbar.Controls.Add(this.panel3);
            this.topbar.Controls.Add(this.panel2);
            this.topbar.Controls.Add(this.flowLayoutPanel2);
            this.topbar.Location = new System.Drawing.Point(0, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(940, 28);
            this.topbar.TabIndex = 13;
            this.topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseDown);
            this.topbar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseMove);
            this.topbar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseUp);
            // 
            // minimize_click
            // 
            this.minimize_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_click.Image = global::PACS_starship.Properties.Resources.minimize_icon;
            this.minimize_click.Location = new System.Drawing.Point(874, 4);
            this.minimize_click.Name = "minimize_click";
            this.minimize_click.Size = new System.Drawing.Size(15, 15);
            this.minimize_click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_click.TabIndex = 17;
            this.minimize_click.TabStop = false;
            this.minimize_click.Click += new System.EventHandler(this.minimize_click_Click);
            // 
            // maximize_click
            // 
            this.maximize_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_click.Image = global::PACS_starship.Properties.Resources.window_open_icon;
            this.maximize_click.Location = new System.Drawing.Point(895, 4);
            this.maximize_click.Name = "maximize_click";
            this.maximize_click.Size = new System.Drawing.Size(15, 15);
            this.maximize_click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximize_click.TabIndex = 16;
            this.maximize_click.TabStop = false;
            this.maximize_click.Click += new System.EventHandler(this.maximize_click_Click);
            // 
            // close_click
            // 
            this.close_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_click.Image = global::PACS_starship.Properties.Resources.close_icon;
            this.close_click.Location = new System.Drawing.Point(919, 4);
            this.close_click.Name = "close_click";
            this.close_click.Size = new System.Drawing.Size(15, 15);
            this.close_click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_click.TabIndex = 14;
            this.close_click.TabStop = false;
            this.close_click.Click += new System.EventHandler(this.close_click_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.panel3.Location = new System.Drawing.Point(1, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 1);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.panel2.Location = new System.Drawing.Point(-1, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 2);
            this.panel2.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(850, 4);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(31)))));
            this.panel4.Location = new System.Drawing.Point(680, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(260, 159);
            this.panel4.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.groupBox2.Location = new System.Drawing.Point(32, 308);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 210);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transmissions";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ER - Entry Requirement",
            "VR - Validation Result",
            "VK - Validation Key"});
            this.comboBox1.Location = new System.Drawing.Point(23, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 31);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(19, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Select message:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(239, 64);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(55, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "Send Message";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 22);
            this.textBox1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label4.Location = new System.Drawing.Point(28, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "IP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Leelawadee", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label5.Location = new System.Drawing.Point(224, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Port:";
            // 
            // frm_spaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(11)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(940, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_spaceship";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_formTemplate";
            this.Load += new System.EventHandler(this.frm_spaceship_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.topbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_click)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_click)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_click)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox close_click;
        private System.Windows.Forms.PictureBox maximize_click;
        private System.Windows.Forms.PictureBox minimize_click;
        private System.Windows.Forms.Button btn_generatecoordinates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_privatekey;
        private System.Windows.Forms.TextBox tbx_privatekey;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_sendping;
        private System.Windows.Forms.ListBox lbx_console;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_networkstatus;
        private System.Windows.Forms.TextBox tbx_ipplanet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}