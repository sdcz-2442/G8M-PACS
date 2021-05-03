
namespace G8_Planet
{
    partial class frm_planet
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbx_Missatges = new System.Windows.Forms.ListBox();
            this.txb_port = new System.Windows.Forms.TextBox();
            this.btn_desconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_keys = new System.Windows.Forms.Panel();
            this.btn_generate = new System.Windows.Forms.Button();
            this.tbx_routeXML = new System.Windows.Forms.TextBox();
            this.tbx_container = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_port = new System.Windows.Forms.Panel();
            this.minimize_click = new System.Windows.Forms.PictureBox();
            this.maximize_click = new System.Windows.Forms.PictureBox();
            this.close_click = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_identificadorplaneta = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_port = new System.Windows.Forms.TextBox();
            this.tbx_ipplanet = new System.Windows.Forms.TextBox();
            this.btn_sendping = new System.Windows.Forms.Button();
            this.btn_sendmessages = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnl_keys.SuspendLayout();
            this.lbl_port.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_click)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_click)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_click)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbx_Missatges);
            this.groupBox1.Controls.Add(this.txb_port);
            this.groupBox1.Controls.Add(this.btn_desconnect);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(69, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(579, 364);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviament dades";
            // 
            // lbx_Missatges
            // 
            this.lbx_Missatges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.ItemHeight = 16;
            this.lbx_Missatges.Location = new System.Drawing.Point(77, 181);
            this.lbx_Missatges.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(436, 164);
            this.lbx_Missatges.TabIndex = 5;
            // 
            // txb_port
            // 
            this.txb_port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txb_port.Location = new System.Drawing.Point(75, 52);
            this.txb_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(97, 22);
            this.txb_port.TabIndex = 4;
            // 
            // btn_desconnect
            // 
            this.btn_desconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(235)))));
            this.btn_desconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desconnect.Location = new System.Drawing.Point(381, 52);
            this.btn_desconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_desconnect.Name = "btn_desconnect";
            this.btn_desconnect.Size = new System.Drawing.Size(115, 28);
            this.btn_desconnect.TabIndex = 3;
            this.btn_desconnect.Text = "Desconnectar";
            this.btn_desconnect.UseVisualStyleBackColor = false;
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(235)))));
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Location = new System.Drawing.Point(259, 52);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(117, 28);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connectar";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Missatges rebuts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // pnl_keys
            // 
            this.pnl_keys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_keys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_keys.Controls.Add(this.btn_generate);
            this.pnl_keys.Controls.Add(this.tbx_routeXML);
            this.pnl_keys.Controls.Add(this.tbx_container);
            this.pnl_keys.Controls.Add(this.label3);
            this.pnl_keys.Controls.Add(this.label4);
            this.pnl_keys.Location = new System.Drawing.Point(688, 54);
            this.pnl_keys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_keys.Name = "pnl_keys";
            this.pnl_keys.Size = new System.Drawing.Size(669, 182);
            this.pnl_keys.TabIndex = 19;
            this.pnl_keys.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_keys_Paint);
            // 
            // btn_generate
            // 
            this.btn_generate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(235)))));
            this.btn_generate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generate.Location = new System.Drawing.Point(449, 130);
            this.btn_generate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(124, 28);
            this.btn_generate.TabIndex = 7;
            this.btn_generate.Text = "Generar Claus";
            this.btn_generate.UseVisualStyleBackColor = false;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // tbx_routeXML
            // 
            this.tbx_routeXML.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.tbx_routeXML.Location = new System.Drawing.Point(189, 98);
            this.tbx_routeXML.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_routeXML.Name = "tbx_routeXML";
            this.tbx_routeXML.Size = new System.Drawing.Size(383, 22);
            this.tbx_routeXML.TabIndex = 5;
            // 
            // tbx_container
            // 
            this.tbx_container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.tbx_container.Location = new System.Drawing.Point(189, 44);
            this.tbx_container.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbx_container.Name = "tbx_container";
            this.tbx_container.Size = new System.Drawing.Size(168, 22);
            this.tbx_container.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fixer XML Public Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nom KeyContainer";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 30);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(483, 39);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.Tag = "Planets";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(235)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(211, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 39);
            this.button1.TabIndex = 21;
            this.button1.Text = "Seleccionar Planeta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(235)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(387, 142);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 39);
            this.button2.TabIndex = 22;
            this.button2.Text = "Generar identificador";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lbl_port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(173)))), ((int)(((byte)(235)))));
            this.lbl_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_port.Controls.Add(this.minimize_click);
            this.lbl_port.Controls.Add(this.maximize_click);
            this.lbl_port.Controls.Add(this.close_click);
            this.lbl_port.Controls.Add(this.panel3);
            this.lbl_port.Controls.Add(this.panel2);
            this.lbl_port.Controls.Add(this.flowLayoutPanel2);
            this.lbl_port.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_port.Location = new System.Drawing.Point(0, 0);
            this.lbl_port.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(1387, 28);
            this.lbl_port.TabIndex = 23;
            this.lbl_port.Paint += new System.Windows.Forms.PaintEventHandler(this.lbl_port_Paint);
            // 
            // minimize_click
            // 
            this.minimize_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimize_click.Location = new System.Drawing.Point(1318, 4);
            this.minimize_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimize_click.Name = "minimize_click";
            this.minimize_click.Size = new System.Drawing.Size(15, 15);
            this.minimize_click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize_click.TabIndex = 17;
            this.minimize_click.TabStop = false;
            // 
            // maximize_click
            // 
            this.maximize_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximize_click.Location = new System.Drawing.Point(1340, 4);
            this.maximize_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maximize_click.Name = "maximize_click";
            this.maximize_click.Size = new System.Drawing.Size(15, 15);
            this.maximize_click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.maximize_click.TabIndex = 16;
            this.maximize_click.TabStop = false;
            // 
            // close_click
            // 
            this.close_click.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_click.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.close_click.Location = new System.Drawing.Point(1364, 4);
            this.close_click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.close_click.Name = "close_click";
            this.close_click.Size = new System.Drawing.Size(15, 16);
            this.close_click.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_click.TabIndex = 14;
            this.close_click.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(760, 18);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(650, 3);
            this.panel3.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(659, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 4);
            this.panel2.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(560, 2);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(850, 6);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_sendmessages);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbx_port);
            this.panel1.Controls.Add(this.tbx_ipplanet);
            this.panel1.Controls.Add(this.btn_sendping);
            this.panel1.Controls.Add(this.lbl_identificadorplaneta);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pnl_keys);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1410, 651);
            this.panel1.TabIndex = 24;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_identificadorplaneta
            // 
            this.lbl_identificadorplaneta.AutoSize = true;
            this.lbl_identificadorplaneta.Location = new System.Drawing.Point(251, 80);
            this.lbl_identificadorplaneta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_identificadorplaneta.Name = "lbl_identificadorplaneta";
            this.lbl_identificadorplaneta.Size = new System.Drawing.Size(0, 17);
            this.lbl_identificadorplaneta.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label5.Location = new System.Drawing.Point(891, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 29);
            this.label5.TabIndex = 26;
            this.label5.Text = "Port:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(191)))), ((int)(((byte)(141)))));
            this.label6.Location = new System.Drawing.Point(695, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "IP:";
            // 
            // tbx_port
            // 
            this.tbx_port.Location = new System.Drawing.Point(946, 281);
            this.tbx_port.Multiline = true;
            this.tbx_port.Name = "tbx_port";
            this.tbx_port.Size = new System.Drawing.Size(73, 22);
            this.tbx_port.TabIndex = 23;
            // 
            // tbx_ipplanet
            // 
            this.tbx_ipplanet.Location = new System.Drawing.Point(731, 280);
            this.tbx_ipplanet.Multiline = true;
            this.tbx_ipplanet.Name = "tbx_ipplanet";
            this.tbx_ipplanet.Size = new System.Drawing.Size(151, 22);
            this.tbx_ipplanet.TabIndex = 22;
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
            this.btn_sendping.Location = new System.Drawing.Point(890, 320);
            this.btn_sendping.Name = "btn_sendping";
            this.btn_sendping.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_sendping.Size = new System.Drawing.Size(129, 28);
            this.btn_sendping.TabIndex = 24;
            this.btn_sendping.Text = "Network Request";
            this.btn_sendping.UseVisualStyleBackColor = false;
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
            this.btn_sendmessages.Location = new System.Drawing.Point(1070, 320);
            this.btn_sendmessages.Name = "btn_sendmessages";
            this.btn_sendmessages.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btn_sendmessages.Size = new System.Drawing.Size(83, 31);
            this.btn_sendmessages.TabIndex = 27;
            this.btn_sendmessages.Text = "Send Message";
            this.btn_sendmessages.UseVisualStyleBackColor = false;
            this.btn_sendmessages.Click += new System.EventHandler(this.btn_sendmessages_Click);
            // 
            // frm_planet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1387, 678);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_planet";
            this.Text = "frm_planet";
            this.Load += new System.EventHandler(this.frm_planet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_keys.ResumeLayout(false);
            this.pnl_keys.PerformLayout();
            this.lbl_port.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize_click)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximize_click)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_click)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbx_Missatges;
        private System.Windows.Forms.TextBox txb_port;
        private System.Windows.Forms.Button btn_desconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_keys;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox tbx_container;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel lbl_port;
        private System.Windows.Forms.PictureBox minimize_click;
        private System.Windows.Forms.PictureBox maximize_click;
        private System.Windows.Forms.PictureBox close_click;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_identificadorplaneta;
        private System.Windows.Forms.TextBox tbx_routeXML;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btn_genArch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_port;
        private System.Windows.Forms.TextBox tbx_ipplanet;
        private System.Windows.Forms.Button btn_sendping;
        private System.Windows.Forms.Button btn_sendmessages;
    }
}