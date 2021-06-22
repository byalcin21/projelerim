
namespace BorsaUygulaması
{
    partial class Kullanici
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kullanici));
            this.Para_EKLE = new System.Windows.Forms.Button();
            this.Urun_EKLE = new System.Windows.Forms.Button();
            this.Ozet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Para_EKLE
            // 
            this.Para_EKLE.Location = new System.Drawing.Point(44, 68);
            this.Para_EKLE.Name = "Para_EKLE";
            this.Para_EKLE.Size = new System.Drawing.Size(182, 29);
            this.Para_EKLE.TabIndex = 0;
            this.Para_EKLE.Text = "CÜZDANA PARA YÜKLE";
            this.Para_EKLE.UseVisualStyleBackColor = true;
            this.Para_EKLE.Click += new System.EventHandler(this.Para_EKLE_Click);
            // 
            // Urun_EKLE
            // 
            this.Urun_EKLE.Location = new System.Drawing.Point(44, 103);
            this.Urun_EKLE.Name = "Urun_EKLE";
            this.Urun_EKLE.Size = new System.Drawing.Size(172, 29);
            this.Urun_EKLE.TabIndex = 1;
            this.Urun_EKLE.Text = "STOĞA ÜRÜN EKLE";
            this.Urun_EKLE.UseVisualStyleBackColor = true;
            this.Urun_EKLE.Click += new System.EventHandler(this.Urun_EKLE_Click);
            // 
            // Ozet
            // 
            this.Ozet.Location = new System.Drawing.Point(44, 138);
            this.Ozet.Name = "Ozet";
            this.Ozet.Size = new System.Drawing.Size(118, 29);
            this.Ozet.TabIndex = 2;
            this.Ozet.Text = "SİPARİŞ ÖZETİ";
            this.Ozet.UseVisualStyleBackColor = true;
            this.Ozet.Click += new System.EventHandler(this.Ozet_Click);
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorsaUygulamasiFinal.Properties.Resources.wallpapersden_com_low_poly_blue_geometry_artwork_1280x720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(303, 213);
            this.Controls.Add(this.Ozet);
            this.Controls.Add(this.Urun_EKLE);
            this.Controls.Add(this.Para_EKLE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Para_EKLE;
        private System.Windows.Forms.Button Urun_EKLE;
        private System.Windows.Forms.Button Ozet;
    }
}