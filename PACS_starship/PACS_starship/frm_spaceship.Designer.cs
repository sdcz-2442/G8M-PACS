
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_port = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sendfile = new System.Windows.Forms.Button();
            this.cbx_deliverydate = new System.Windows.Forms.ComboBox();
            this.cbx_codedelivery = new System.Windows.Forms.ComboBox();
            this.cbx_selectplanet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_sendmessages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_messages = new System.Windows.Forms.ComboBox();
            this.tbx_ipplanet = new System.Windows.Forms.TextBox();
            this.lbx_console = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_networkstatus = new System.Windows.Forms.Label();
            this.btn_sendping = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Panel();
            this.minimize_click = new System.Windows.Forms.PictureBox();
            this.maximize_click = new System.Windows.Forms.PictureBox();
            this.close_click = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbx_pubkey = new System.Windows.Forms.TextBox();
            this.btn_steps = new System.Windows.Forms.Button();
            this.lbx_events = new System.Windows.Forms.ListBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_connectTCPIP2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.lbl_port.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_click)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_click)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_click)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbx_port);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.tbx_ipplanet);
            this.panel1.Controls.Add(this.lbx_console);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_networkstatus);
            this.panel1.Controls.Add(this.btn_sendping);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 536);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label5.Location = new System.Drawing.Point(224, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Port:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label4.Location = new System.Drawing.Point(28, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "IP:";
            // 
            // tbx_port
            // 
            this.tbx_port.Location = new System.Drawing.Point(279, 53);
            this.tbx_port.Multiline = true;
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(73, 22);
            this.tbx_port.TabIndex = 2;
            this.tbx_port.TextChanged += new System.EventHandler(this.tbx_port_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.btn_sendfile);
            this.groupBox2.Controls.Add(this.cbx_deliverydate);
            this.groupBox2.Controls.Add(this.cbx_codedelivery);
            this.groupBox2.Controls.Add(this.cbx_selectplanet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btn_sendmessages);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbx_messages);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.groupBox2.Location = new System.Drawing.Point(32, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transmissions";
            // 
            // btn_sendfile
            // 
            this.btn_sendfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.btn_sendfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_sendfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_sendfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_sendfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendfile.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_sendfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendfile.Location = new System.Drawing.Point(246, 203);
            this.btn_sendfile.Name = "btn_sendfile";
            this.btn_sendfile.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_sendfile.Size = new System.Drawing.Size(102, 31);
            this.btn_sendfile.TabIndex = 25;
            this.btn_sendfile.Text = "2Send File";
            this.btn_sendfile.UseVisualStyleBackColor = false;
            this.btn_sendfile.Click += new System.EventHandler(this.btn_sendfile_Click);
            // 
            // cbx_deliverydate
            // 
            this.cbx_deliverydate.FormattingEnabled = true;
            this.cbx_deliverydate.Location = new System.Drawing.Point(22, 141);
            this.cbx_deliverydate.Name = "cbx_deliverydate";
            this.cbx_deliverydate.Size = new System.Drawing.Size(218, 32);
            this.cbx_deliverydate.TabIndex = 24;
            // 
            // cbx_codedelivery
            // 
            this.cbx_codedelivery.FormattingEnabled = true;
            this.cbx_codedelivery.Location = new System.Drawing.Point(22, 103);
            this.cbx_codedelivery.Name = "cbx_codedelivery";
            this.cbx_codedelivery.Size = new System.Drawing.Size(218, 32);
            this.cbx_codedelivery.TabIndex = 23;
            // 
            // cbx_selectplanet
            // 
            this.cbx_selectplanet.FormattingEnabled = true;
            this.cbx_selectplanet.Location = new System.Drawing.Point(22, 64);
            this.cbx_selectplanet.Name = "cbx_selectplanet";
            this.cbx_selectplanet.Size = new System.Drawing.Size(218, 32);
            this.cbx_selectplanet.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label6.Location = new System.Drawing.Point(6, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Output:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label7.Location = new System.Drawing.Point(80, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "None";
            // 
            // btn_sendmessages
            // 
            this.btn_sendmessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.btn_sendmessages.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_sendmessages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_sendmessages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_sendmessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendmessages.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendmessages.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_sendmessages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendmessages.Location = new System.Drawing.Point(247, 166);
            this.btn_sendmessages.Name = "btn_sendmessages";
            this.btn_sendmessages.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_sendmessages.Size = new System.Drawing.Size(102, 31);
            this.btn_sendmessages.TabIndex = 5;
            this.btn_sendmessages.Text = "1Send Message";
            this.btn_sendmessages.UseVisualStyleBackColor = false;
            this.btn_sendmessages.Click += new System.EventHandler(this.btn_sendmessages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Select message:";
            // 
            // cbx_messages
            // 
            this.cbx_messages.FormattingEnabled = true;
            this.cbx_messages.Items.AddRange(new object[] {
            "ER - Entry Requirement",
            "VR - Validation Result",
            "VK - Validation Key"});
            this.cbx_messages.Location = new System.Drawing.Point(22, 186);
            this.cbx_messages.Name = "cbx_messages";
            this.cbx_messages.Size = new System.Drawing.Size(218, 32);
            this.cbx_messages.TabIndex = 4;
            // 
            // tbx_ipplanet
            // 
            this.tbx_ipplanet.Location = new System.Drawing.Point(64, 52);
            this.tbx_ipplanet.Multiline = true;
            this.tbx_ipplanet.Name = "tbx_ipplanet";
            this.tbx_ipplanet.Size = new System.Drawing.Size(151, 22);
            this.tbx_ipplanet.TabIndex = 1;
            // 
            // lbx_console
            // 
            this.lbx_console.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbx_console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(31)))));
            this.lbx_console.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbx_console.ForeColor = System.Drawing.Color.White;
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.Location = new System.Drawing.Point(32, 156);
            this.lbx_console.Margin = new System.Windows.Forms.Padding(1);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(320, 106);
            this.lbx_console.TabIndex = 0;
            this.lbx_console.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label3.Location = new System.Drawing.Point(28, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Status:";
            // 
            // lbl_networkstatus
            // 
            this.lbl_networkstatus.AutoSize = true;
            this.lbl_networkstatus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_networkstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_networkstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.lbl_networkstatus.Location = new System.Drawing.Point(99, 126);
            this.lbl_networkstatus.Name = "lbl_networkstatus";
            this.lbl_networkstatus.Size = new System.Drawing.Size(74, 20);
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
            this.btn_sendping.TabIndex = 3;
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
            // lbl_port
            // 
            this.lbl_port.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_port.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbl_port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(6)))), ((int)(((byte)(14)))));
            this.lbl_port.Controls.Add(this.minimize_click);
            this.lbl_port.Controls.Add(this.maximize_click);
            this.lbl_port.Controls.Add(this.close_click);
            this.lbl_port.Controls.Add(this.panel3);
            this.lbl_port.Controls.Add(this.panel2);
            this.lbl_port.Controls.Add(this.flowLayoutPanel2);
            this.lbl_port.Location = new System.Drawing.Point(0, 0);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(940, 28);
            this.lbl_port.TabIndex = 13;
            this.lbl_port.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseDown);
            this.lbl_port.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseMove);
            this.lbl_port.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topbar_MouseUp);
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
            this.panel4.Controls.Add(this.tbx_pubkey);
            this.panel4.Location = new System.Drawing.Point(655, 176);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(285, 159);
            this.panel4.TabIndex = 15;
            // 
            // tbx_pubkey
            // 
            this.tbx_pubkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_pubkey.Location = new System.Drawing.Point(14, 14);
            this.tbx_pubkey.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_pubkey.Multiline = true;
            this.tbx_pubkey.Name = "tbx_pubkey";
            this.tbx_pubkey.Size = new System.Drawing.Size(258, 129);
            this.tbx_pubkey.TabIndex = 34;
            this.tbx_pubkey.TextChanged += new System.EventHandler(this.tbx_pubkey_TextChanged);
            // 
            // btn_steps
            // 
            this.btn_steps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_steps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.btn_steps.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_steps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_steps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_steps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_steps.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_steps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_steps.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_steps.Location = new System.Drawing.Point(674, 341);
            this.btn_steps.Name = "btn_steps";
            this.btn_steps.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_steps.Size = new System.Drawing.Size(126, 31);
            this.btn_steps.TabIndex = 7;
            this.btn_steps.Text = "VR Response";
            this.btn_steps.UseVisualStyleBackColor = false;
            this.btn_steps.Click += new System.EventHandler(this.btn_steps_Click);
            // 
            // lbx_events
            // 
            this.lbx_events.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbx_events.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(12)))), ((int)(((byte)(31)))));
            this.lbx_events.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbx_events.ForeColor = System.Drawing.Color.White;
            this.lbx_events.FormattingEnabled = true;
            this.lbx_events.Location = new System.Drawing.Point(428, 46);
            this.lbx_events.Margin = new System.Windows.Forms.Padding(1);
            this.lbx_events.Name = "lbx_events";
            this.lbx_events.Size = new System.Drawing.Size(223, 522);
            this.lbx_events.TabIndex = 21;
            this.lbx_events.TabStop = false;
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.btn_open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_open.Location = new System.Drawing.Point(674, 68);
            this.btn_open.Name = "btn_open";
            this.btn_open.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_open.Size = new System.Drawing.Size(75, 31);
            this.btn_open.TabIndex = 6;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = false;
            // 
            // btn_connectTCPIP2
            // 
            this.btn_connectTCPIP2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_connectTCPIP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.btn_connectTCPIP2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.btn_connectTCPIP2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_connectTCPIP2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.btn_connectTCPIP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connectTCPIP2.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connectTCPIP2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.btn_connectTCPIP2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_connectTCPIP2.Location = new System.Drawing.Point(674, 429);
            this.btn_connectTCPIP2.Name = "btn_connectTCPIP2";
            this.btn_connectTCPIP2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_connectTCPIP2.Size = new System.Drawing.Size(126, 31);
            this.btn_connectTCPIP2.TabIndex = 22;
            this.btn_connectTCPIP2.Text = "Connect";
            this.btn_connectTCPIP2.UseVisualStyleBackColor = false;
            this.btn_connectTCPIP2.Click += new System.EventHandler(this.btn_connectTCPIP2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(216)))), ((int)(((byte)(129)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(111)))), ((int)(((byte)(138)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(138)))), ((int)(((byte)(94)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(251)))), ((int)(((byte)(225)))));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(674, 466);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 23;
            this.button1.Text = "Disconnect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_spaceship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(11)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(940, 578);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_connectTCPIP2);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.lbx_events);
            this.Controls.Add(this.btn_steps);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lbl_port);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.lbl_port.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_click)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_click)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_click)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel lbl_port;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox close_click;
        private System.Windows.Forms.PictureBox maximize_click;
        private System.Windows.Forms.PictureBox minimize_click;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_sendping;
        private System.Windows.Forms.ListBox lbx_console;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_networkstatus;
        private System.Windows.Forms.TextBox tbx_ipplanet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_messages;
        private System.Windows.Forms.Button btn_sendmessages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_port;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_steps;
        private System.Windows.Forms.ListBox lbx_events;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox tbx_pubkey;
        private System.Windows.Forms.ComboBox cbx_selectplanet;
        private System.Windows.Forms.ComboBox cbx_deliverydate;
        private System.Windows.Forms.ComboBox cbx_codedelivery;
        private System.Windows.Forms.Button btn_connectTCPIP2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_sendfile;
    }
}