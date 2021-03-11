
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
            this.btn_routeXML = new System.Windows.Forms.Button();
            this.tbx_routeXML = new System.Windows.Forms.TextBox();
            this.tbx_container = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.pnl_keys.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(11, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(434, 296);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviament dades";
            // 
            // lbx_Missatges
            // 
            this.lbx_Missatges.FormattingEnabled = true;
            this.lbx_Missatges.Location = new System.Drawing.Point(58, 147);
            this.lbx_Missatges.Name = "lbx_Missatges";
            this.lbx_Missatges.Size = new System.Drawing.Size(328, 134);
            this.lbx_Missatges.TabIndex = 5;
            // 
            // txb_port
            // 
            this.txb_port.Location = new System.Drawing.Point(58, 36);
            this.txb_port.Margin = new System.Windows.Forms.Padding(2);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(63, 20);
            this.txb_port.TabIndex = 4;
            // 
            // btn_desconnect
            // 
            this.btn_desconnect.Location = new System.Drawing.Point(289, 33);
            this.btn_desconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_desconnect.Name = "btn_desconnect";
            this.btn_desconnect.Size = new System.Drawing.Size(86, 20);
            this.btn_desconnect.TabIndex = 3;
            this.btn_desconnect.Text = "Desconnectar";
            this.btn_desconnect.UseVisualStyleBackColor = true;
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(196, 33);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(88, 20);
            this.btn_connect.TabIndex = 2;
            this.btn_connect.Text = "Connectar";
            this.btn_connect.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 113);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Missatges rebuts";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // pnl_keys
            // 
            this.pnl_keys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_keys.Controls.Add(this.btn_generate);
            this.pnl_keys.Controls.Add(this.btn_routeXML);
            this.pnl_keys.Controls.Add(this.tbx_routeXML);
            this.pnl_keys.Controls.Add(this.tbx_container);
            this.pnl_keys.Controls.Add(this.label3);
            this.pnl_keys.Controls.Add(this.label4);
            this.pnl_keys.Location = new System.Drawing.Point(464, 12);
            this.pnl_keys.Name = "pnl_keys";
            this.pnl_keys.Size = new System.Drawing.Size(502, 148);
            this.pnl_keys.TabIndex = 19;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(337, 106);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(93, 23);
            this.btn_generate.TabIndex = 7;
            this.btn_generate.Text = "Generar Claus";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_routeXML
            // 
            this.btn_routeXML.Location = new System.Drawing.Point(436, 78);
            this.btn_routeXML.Name = "btn_routeXML";
            this.btn_routeXML.Size = new System.Drawing.Size(34, 23);
            this.btn_routeXML.TabIndex = 6;
            this.btn_routeXML.Text = "...";
            this.btn_routeXML.UseVisualStyleBackColor = true;
            this.btn_routeXML.Click += new System.EventHandler(this.btn_routeXML_Click);
            // 
            // tbx_routeXML
            // 
            this.tbx_routeXML.Location = new System.Drawing.Point(142, 80);
            this.tbx_routeXML.Name = "tbx_routeXML";
            this.tbx_routeXML.Size = new System.Drawing.Size(288, 20);
            this.tbx_routeXML.TabIndex = 5;
            // 
            // tbx_container
            // 
            this.tbx_container.Location = new System.Drawing.Point(142, 36);
            this.tbx_container.Name = "tbx_container";
            this.tbx_container.Size = new System.Drawing.Size(127, 20);
            this.tbx_container.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fixer XML Public Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nom KeyContainer";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(363, 21);
            this.comboBox1.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Seleccionar Planeta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Generar identificador";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm_planet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pnl_keys);
            this.Controls.Add(this.groupBox1);
            this.Name = "frm_planet";
            this.Text = "frm_planet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnl_keys.ResumeLayout(false);
            this.pnl_keys.PerformLayout();
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
        private System.Windows.Forms.Button btn_routeXML;
        private System.Windows.Forms.TextBox tbx_routeXML;
        private System.Windows.Forms.TextBox tbx_container;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}