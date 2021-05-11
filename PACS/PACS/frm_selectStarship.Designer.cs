
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
            this.btn_selectspaceship = new System.Windows.Forms.Button();
            this.tbx_spaceshipname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_selectspaceship
            // 
            this.btn_selectspaceship.Location = new System.Drawing.Point(192, 99);
            this.btn_selectspaceship.Name = "btn_selectspaceship";
            this.btn_selectspaceship.Size = new System.Drawing.Size(75, 23);
            this.btn_selectspaceship.TabIndex = 5;
            this.btn_selectspaceship.Text = "Select";
            this.btn_selectspaceship.UseVisualStyleBackColor = true;
            this.btn_selectspaceship.Click += new System.EventHandler(this.btn_selectspaceship_Click);
            // 
            // tbx_spaceshipname
            // 
            this.tbx_spaceshipname.Location = new System.Drawing.Point(167, 58);
            this.tbx_spaceshipname.Name = "tbx_spaceshipname";
            this.tbx_spaceshipname.Size = new System.Drawing.Size(100, 20);
            this.tbx_spaceshipname.TabIndex = 4;
            this.tbx_spaceshipname.Text = "FC-G1SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spaceship Code:";
            // 
            // frm_selectStarship
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 181);
            this.Controls.Add(this.btn_selectspaceship);
            this.Controls.Add(this.tbx_spaceshipname);
            this.Controls.Add(this.label1);
            this.Name = "frm_selectStarship";
            this.Text = "frm_selectStarship";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_selectspaceship;
        private System.Windows.Forms.TextBox tbx_spaceshipname;
        private System.Windows.Forms.Label label1;
    }
}