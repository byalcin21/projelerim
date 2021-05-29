
namespace BorsaUygulaması
{
    partial class AdminAnaMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAnaMenu));
            this.Kullanici_Ekle = new System.Windows.Forms.Button();
            this.Alici_Onay = new System.Windows.Forms.Button();
            this.Alim_Satim_Goster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kullanici_Ekle
            // 
            this.Kullanici_Ekle.Location = new System.Drawing.Point(12, 12);
            this.Kullanici_Ekle.Name = "Kullanici_Ekle";
            this.Kullanici_Ekle.Size = new System.Drawing.Size(143, 29);
            this.Kullanici_Ekle.TabIndex = 0;
            this.Kullanici_Ekle.Text = "KULLANICI EKLE";
            this.Kullanici_Ekle.UseVisualStyleBackColor = true;
            this.Kullanici_Ekle.Click += new System.EventHandler(this.Kullanici_Ekle_Click);
            // 
            // Alici_Onay
            // 
            this.Alici_Onay.Location = new System.Drawing.Point(12, 47);
            this.Alici_Onay.Name = "Alici_Onay";
            this.Alici_Onay.Size = new System.Drawing.Size(143, 29);
            this.Alici_Onay.TabIndex = 1;
            this.Alici_Onay.Text = "ADMİN ONAY";
            this.Alici_Onay.UseVisualStyleBackColor = true;
            this.Alici_Onay.Click += new System.EventHandler(this.Alici_Onay_Click);
            // 
            // Alim_Satim_Goster
            // 
            this.Alim_Satim_Goster.Location = new System.Drawing.Point(12, 82);
            this.Alim_Satim_Goster.Name = "Alim_Satim_Goster";
            this.Alim_Satim_Goster.Size = new System.Drawing.Size(143, 29);
            this.Alim_Satim_Goster.TabIndex = 3;
            this.Alim_Satim_Goster.Text = "ALIM- SATIM";
            this.Alim_Satim_Goster.UseVisualStyleBackColor = true;
            this.Alim_Satim_Goster.Click += new System.EventHandler(this.Alim_Satim_Goster_Click);
            // 
            // AdminAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorsaUygulaması.Properties.Resources.wallpapersden_com_low_poly_blue_geometry_artwork_1280x720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(271, 276);
            this.Controls.Add(this.Alim_Satim_Goster);
            this.Controls.Add(this.Alici_Onay);
            this.Controls.Add(this.Kullanici_Ekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAnaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Kullanici_Ekle;
        private System.Windows.Forms.Button Alici_Onay;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Alim_Satim_Goster;
    }
}