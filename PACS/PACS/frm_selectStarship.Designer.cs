
namespace PACS
{
    partial class frm_selectStarship
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_selectStarship));
            this.btn_selectspaceship = new System.Windows.Forms.Button();
            this.tbx_spaceshipname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_selectspaceship
            // 
            this.btn_selectspaceship.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_selectspaceship.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_selectspaceship.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectspaceship.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_selectspaceship.Location = new System.Drawing.Point(192, 99);
            this.btn_selectspaceship.Name = "btn_selectspaceship";
            this.btn_selectspaceship.Size = new System.Drawing.Size(75, 23);
            this.btn_selectspaceship.TabIndex = 2;
            this.btn_selectspaceship.Text = "Select";
            this.btn_selectspaceship.UseVisualStyleBackColor = false;
            this.btn_selectspaceship.Click += new System.EventHandler(this.btn_selectspaceship_Click);
            // 
            // tbx_spaceshipname
            // 
            this.tbx_spaceshipname.Location = new System.Drawing.Point(168, 71);
            this.tbx_spaceshipname.Name = "tbx_spaceshipname";
            this.tbx_spaceshipname.Size = new System.Drawing.Size(100, 20);
            this.tbx_spaceshipname.TabIndex = 1;
            this.tbx_spaceshipname.Text = "FC-G1SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(34, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Spaceship Code:";
            // 
            // frm_selectStarship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PACS.Properties.Resources._10850082;
            this.ClientSize = new System.Drawing.Size(329, 181);
            this.ControlBox = false;
            this.Controls.Add(this.btn_selectspaceship);
            this.Controls.Add(this.tbx_spaceshipname);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_selectStarship";
            this.Text = "Select Spaceship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_selectspaceship;
        private System.Windows.Forms.TextBox tbx_spaceshipname;
        private System.Windows.Forms.Label label1;
    }
}