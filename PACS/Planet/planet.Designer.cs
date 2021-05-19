
namespace Planet
{
    partial class planet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(planet));
            this.cbx_selectplanet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_selectplanet = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sendfile = new System.Windows.Forms.Button();
            this.btn_answerTCP = new System.Windows.Forms.Button();
            this.cbx_selectmessage = new System.Windows.Forms.ComboBox();
            this.lbx_Missatges = new System.Windows.Forms.ListBox();
            this.txb_port = new System.Windows.Forms.TextBox();
            this.btn_desconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_generarIdentificador = new System.Windows.Forms.Button();
            this.btn_generarclaus = new System.Windows.Forms.Button();
            this.btn_checkERmessage = new System.Windows.Forms.Button();
            this.btn_checkvalidationCodes = new System.Windows.Forms.Button();
            this.btn_createfiles = new System.Windows.Forms.Button();
            this.btn_checkfiles = new System.Windows.Forms.Button();
            this.btn_checkPACSSOL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_selectplanet
            // 
            this.cbx_selectplanet.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_selectplanet.ForeColor = System.Drawing.Color.Navy;
            this.cbx_selectplanet.FormattingEnabled = true;
            this.cbx_selectplanet.Location = new System.Drawing.Point(99, 22);
            this.cbx_selectplanet.Name = "cbx_selectplanet";
            this.cbx_selectplanet.Size = new System.Drawing.Size(165, 28);
            this.cbx_selectplanet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Planet";
            // 
            // btn_selectplanet
            // 
            this.btn_selectplanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_selectplanet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_selectplanet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_selectplanet.FlatAppearance.BorderSize = 0;
            this.btn_selectplanet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_selectplanet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectplanet.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_selectplanet.Location = new System.Drawing.Point(281, 26);
            this.btn_selectplanet.Name = "btn_selectplanet";
            this.btn_selectplanet.Size = new System.Drawing.Size(157, 23);
            this.btn_selectplanet.TabIndex = 2;
            this.btn_selectplanet.Text = "Select";
            this.btn_selectplanet.UseVisualStyleBackColor = false;
            this.btn_selectplanet.Click += new System.EventHandler(this.btn_selectplanet_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_sendfile);
            this.groupBox1.Controls.Add(this.btn_answerTCP);
            this.groupBox1.Controls.Add(this.cbx_selectmessage);
            this.groupBox1.Controls.Add(this.lbx_Missatges);
            this.groupBox1.Controls.Add(this.txb_port);
            this.groupBox1.Controls.Add(this.btn_desconnect);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(29, 121);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(409, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data gathering";
            // 
            // btn_sendfile
            // 
            this.btn_sendfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_sendfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sendfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sendfile.Location = new System.Drawing.Point(252, 312);
            this.btn_sendfile.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sendfile.Name = "btn_sendfile";
            this.btn_sendfile.Size = new System.Drawing.Size(139, 23);
            this.btn_sendfile.TabIndex = 14;
            this.btn_sendfile.Text = "Send file";
            this.btn_sendfile.UseVisualStyleBackColor = false;
            this.btn_sendfile.Click += new System.EventHandler(this.btn_sendfile_Click);
            // 
            // btn_answerTCP
            // 
            this.btn_answerTCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_answerTCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_answerTCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_answerTCP.Location = new System.Drawing.Point(252, 285);
            this.btn_answerTCP.Margin = new System.Windows.Forms.Padding(2);
            this.btn_answerTCP.Name = "btn_answerTCP";
            this.btn_answerTCP.Size = new System.Drawing.Size(139, 23);
            this.btn_answerTCP.TabIndex = 11;
            this.btn_answerTCP.Text = "Send message";
            this.btn_answerTCP.UseVisualStyleBackColor = false;
            this.btn_answerTCP.Click += new System.EventHandler(this.btn_answerTCP_Click);
            // 
            // cbx_selectmessage
            // 
            this.cbx_selectmessage.ForeColor = System.Drawing.SystemColors.Highlight;
            this.cbx_selectmessage.FormattingEnabled = true;
            this.cbx_selectmessage.Items.AddRange(new object[] {
            "VR - Validation Result - Validation in Progress",
            "VR - Validation Result - Access Denied",
            "VR - Validation Result - Access Granted"});
            this.cbx_selectmessage.Location = new System.Drawing.Point(13, 285);
            this.cbx_selectmessage.Name = "cbx_selectmessage";
            this.cbx_selectmessage.Size = new System.Drawing.Size(234, 24);
            this.cbx_selectmessage.TabIndex = 10;
            // 
            // lbx_Missatges
            // 
            this.lbx_Missatges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(184)))), ((int)(((byte)(188)))));
            this.lbx_Missatges.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbx_Missatges.Enabled = false;
            this.lbx_Missatges.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_Missatges.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.ItemHeight = 18;
            this.lbx_Missatges.Location = new System.Drawing.Point(12, 84);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(379, 180);
            this.lbx_Missatges.TabIndex = 0;
            // 
            // txb_port
            // 
            this.txb_port.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.txb_port.Location = new System.Drawing.Point(55, 27);
            this.txb_port.Margin = new System.Windows.Forms.Padding(2);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(74, 22);
            this.txb_port.TabIndex = 5;
            this.txb_port.Text = "4000";
            // 
            // btn_desconnect
            // 
            this.btn_desconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_desconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_desconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desconnect.Location = new System.Drawing.Point(289, 27);
            this.btn_desconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_desconnect.Name = "btn_desconnect";
            this.btn_desconnect.Size = new System.Drawing.Size(102, 23);
            this.btn_desconnect.TabIndex = 7;
            this.btn_desconnect.Text = "Disconnect";
            this.btn_desconnect.UseVisualStyleBackColor = false;
            this.btn_desconnect.Click += new System.EventHandler(this.btn_desconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.Location = new System.Drawing.Point(179, 27);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(106, 23);
            this.btn_connect.TabIndex = 6;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Communications";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Port";
            // 
            // btn_generarIdentificador
            // 
            this.btn_generarIdentificador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_generarIdentificador.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_generarIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_generarIdentificador.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_generarIdentificador.Location = new System.Drawing.Point(281, 55);
            this.btn_generarIdentificador.Name = "btn_generarIdentificador";
            this.btn_generarIdentificador.Size = new System.Drawing.Size(157, 23);
            this.btn_generarIdentificador.TabIndex = 3;
            this.btn_generarIdentificador.Text = "Generate identifier";
            this.btn_generarIdentificador.UseVisualStyleBackColor = false;
            this.btn_generarIdentificador.Click += new System.EventHandler(this.btn_generarIdentificador_Click);
            // 
            // btn_generarclaus
            // 
            this.btn_generarclaus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_generarclaus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_generarclaus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_generarclaus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_generarclaus.Location = new System.Drawing.Point(281, 84);
            this.btn_generarclaus.Name = "btn_generarclaus";
            this.btn_generarclaus.Size = new System.Drawing.Size(157, 23);
            this.btn_generarclaus.TabIndex = 4;
            this.btn_generarclaus.Text = "Generate keys";
            this.btn_generarclaus.UseVisualStyleBackColor = false;
            this.btn_generarclaus.Click += new System.EventHandler(this.btn_generarclaus_Click);
            // 
            // btn_checkERmessage
            // 
            this.btn_checkERmessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_checkERmessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkERmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_checkERmessage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_checkERmessage.Location = new System.Drawing.Point(463, 193);
            this.btn_checkERmessage.Name = "btn_checkERmessage";
            this.btn_checkERmessage.Size = new System.Drawing.Size(162, 23);
            this.btn_checkERmessage.TabIndex = 8;
            this.btn_checkERmessage.Text = "Check Entry Response";
            this.btn_checkERmessage.UseVisualStyleBackColor = false;
            this.btn_checkERmessage.Click += new System.EventHandler(this.btn_checkERmessage_Click);
            // 
            // btn_checkvalidationCodes
            // 
            this.btn_checkvalidationCodes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_checkvalidationCodes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkvalidationCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_checkvalidationCodes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_checkvalidationCodes.Location = new System.Drawing.Point(463, 223);
            this.btn_checkvalidationCodes.Name = "btn_checkvalidationCodes";
            this.btn_checkvalidationCodes.Size = new System.Drawing.Size(162, 23);
            this.btn_checkvalidationCodes.TabIndex = 9;
            this.btn_checkvalidationCodes.Text = "Check Validation Codes";
            this.btn_checkvalidationCodes.UseVisualStyleBackColor = false;
            this.btn_checkvalidationCodes.Click += new System.EventHandler(this.btn_checkvalidationCodes_Click);
            // 
            // btn_createfiles
            // 
            this.btn_createfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_createfiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_createfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_createfiles.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_createfiles.Location = new System.Drawing.Point(463, 312);
            this.btn_createfiles.Name = "btn_createfiles";
            this.btn_createfiles.Size = new System.Drawing.Size(162, 23);
            this.btn_createfiles.TabIndex = 13;
            this.btn_createfiles.Text = "Create files";
            this.btn_createfiles.UseVisualStyleBackColor = false;
            this.btn_createfiles.Click += new System.EventHandler(this.btn_createfiles_Click);
            // 
            // btn_checkfiles
            // 
            this.btn_checkfiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_checkfiles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_checkfiles.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_checkfiles.Location = new System.Drawing.Point(463, 283);
            this.btn_checkfiles.Name = "btn_checkfiles";
            this.btn_checkfiles.Size = new System.Drawing.Size(162, 23);
            this.btn_checkfiles.TabIndex = 12;
            this.btn_checkfiles.Text = "Delete Previous Files";
            this.btn_checkfiles.UseVisualStyleBackColor = false;
            this.btn_checkfiles.Click += new System.EventHandler(this.btn_checkfiles_Click);
            // 
            // btn_checkPACSSOL
            // 
            this.btn_checkPACSSOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(134)))), ((int)(((byte)(187)))));
            this.btn_checkPACSSOL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_checkPACSSOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_checkPACSSOL.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_checkPACSSOL.Location = new System.Drawing.Point(463, 342);
            this.btn_checkPACSSOL.Name = "btn_checkPACSSOL";
            this.btn_checkPACSSOL.Size = new System.Drawing.Size(162, 23);
            this.btn_checkPACSSOL.TabIndex = 15;
            this.btn_checkPACSSOL.Text = "Check File";
            this.btn_checkPACSSOL.UseVisualStyleBackColor = false;
            this.btn_checkPACSSOL.Click += new System.EventHandler(this.btn_checkPACSSOL_Click);
            // 
            // planet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Planet.Properties.Resources._18272626c9d0e8d194bcde66ec3e2806;
            this.ClientSize = new System.Drawing.Size(637, 490);
            this.Controls.Add(this.btn_checkPACSSOL);
            this.Controls.Add(this.btn_checkfiles);
            this.Controls.Add(this.btn_createfiles);
            this.Controls.Add(this.btn_checkvalidationCodes);
            this.Controls.Add(this.btn_checkERmessage);
            this.Controls.Add(this.btn_generarclaus);
            this.Controls.Add(this.btn_generarIdentificador);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_selectplanet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_selectplanet);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "planet";
            this.Opacity = 0.98D;
            this.Text = "Planet";
            this.Load += new System.EventHandler(this.planet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_selectplanet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_selectplanet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbx_Missatges;
        private System.Windows.Forms.TextBox txb_port;
        private System.Windows.Forms.Button btn_desconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_answerTCP;
        private System.Windows.Forms.ComboBox cbx_selectmessage;
        private System.Windows.Forms.Button btn_sendfile;
        private System.Windows.Forms.Button btn_generarIdentificador;
        private System.Windows.Forms.Button btn_generarclaus;
        private System.Windows.Forms.Button btn_checkERmessage;
        private System.Windows.Forms.Button btn_checkvalidationCodes;
        private System.Windows.Forms.Button btn_createfiles;
        private System.Windows.Forms.Button btn_checkfiles;
        private System.Windows.Forms.Button btn_checkPACSSOL;
    }
}

