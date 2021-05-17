
namespace BorsaUygulaması
{
    partial class ParaYukleme
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
            this.btn_bakEk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_ekBak = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_bakEk
            // 
            this.btn_bakEk.Location = new System.Drawing.Point(192, 151);
            this.btn_bakEk.Name = "btn_bakEk";
            this.btn_bakEk.Size = new System.Drawing.Size(94, 29);
            this.btn_bakEk.TabIndex = 0;
            this.btn_bakEk.Text = "YÜKLE";
            this.btn_bakEk.UseVisualStyleBackColor = true;
            this.btn_bakEk.Click += new System.EventHandler(this.btn_bakEk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "MEVCUT BAKİYE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "YÜKLENİCEK TUTAR :";
            // 
            // tbx_ekBak
            // 
            this.tbx_ekBak.Location = new System.Drawing.Point(180, 93);
            this.tbx_ekBak.Name = "tbx_ekBak";
            this.tbx_ekBak.Size = new System.Drawing.Size(125, 27);
            this.tbx_ekBak.TabIndex = 4;
            // 
            // ParaYukleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorsaUygulaması.Properties.Resources.wallpapersden_com_low_poly_blue_geometry_artwork_1280x720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 220);
            this.Controls.Add(this.tbx_ekBak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bakEk);
            this.Name = "ParaYukleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParaYukleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bakEk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_ekBak;
    }
}