
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
            this.AdminOnayi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kullanici_Ekle
            // 
            this.Kullanici_Ekle.Location = new System.Drawing.Point(26, 37);
            this.Kullanici_Ekle.Name = "Kullanici_Ekle";
            this.Kullanici_Ekle.Size = new System.Drawing.Size(174, 63);
            this.Kullanici_Ekle.TabIndex = 0;
            this.Kullanici_Ekle.Text = "KULLANICI EKLE";
            this.Kullanici_Ekle.UseVisualStyleBackColor = true;
            this.Kullanici_Ekle.Click += new System.EventHandler(this.Kullanici_Ekle_Click);
            // 
            // AdminOnayi
            // 
            this.AdminOnayi.Location = new System.Drawing.Point(26, 100);
            this.AdminOnayi.Name = "AdminOnayi";
            this.AdminOnayi.Size = new System.Drawing.Size(174, 63);
            this.AdminOnayi.TabIndex = 2;
            this.AdminOnayi.Text = "ADMİN ONAY EKRANI";
            this.AdminOnayi.UseVisualStyleBackColor = true;
            this.AdminOnayi.Click += new System.EventHandler(this.AdminOnay_Click);
            // 
            // AdminAnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorsaUygulamasiFinal.Properties.Resources.wallpapersden_com_low_poly_blue_geometry_artwork_1280x720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(265, 261);
            this.Controls.Add(this.AdminOnayi);
            this.Controls.Add(this.Kullanici_Ekle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminAnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAnaMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Kullanici_Ekle;
        private System.Windows.Forms.Button AdminOnayi;
        private System.Windows.Forms.Button button4;
    }
}