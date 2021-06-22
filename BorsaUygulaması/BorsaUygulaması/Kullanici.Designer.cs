
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
            this.Ozet_btn = new System.Windows.Forms.Button();
            this.KullaniciAdilbl = new System.Windows.Forms.Label();
            this.UrunPazari_btn = new System.Windows.Forms.Button();
            this.Bakiyelbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gecmislbl = new System.Windows.Forms.Label();
            this.kid = new System.Windows.Forms.Label();
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
            this.Urun_EKLE.Size = new System.Drawing.Size(182, 29);
            this.Urun_EKLE.TabIndex = 1;
            this.Urun_EKLE.Text = "STOĞA ÜRÜN EKLE";
            this.Urun_EKLE.UseVisualStyleBackColor = true;
            this.Urun_EKLE.Click += new System.EventHandler(this.Urun_EKLE_Click);
            // 
            // Ozet_btn
            // 
            this.Ozet_btn.Location = new System.Drawing.Point(44, 138);
            this.Ozet_btn.Name = "Ozet_btn";
            this.Ozet_btn.Size = new System.Drawing.Size(182, 29);
            this.Ozet_btn.TabIndex = 2;
            this.Ozet_btn.Text = "RAPOR AL";
            this.Ozet_btn.UseVisualStyleBackColor = true;
            this.Ozet_btn.Click += new System.EventHandler(this.Ozet_Click);
            // 
            // KullaniciAdilbl
            // 
            this.KullaniciAdilbl.AutoSize = true;
            this.KullaniciAdilbl.Location = new System.Drawing.Point(12, 9);
            this.KullaniciAdilbl.Name = "KullaniciAdilbl";
            this.KullaniciAdilbl.Size = new System.Drawing.Size(86, 20);
            this.KullaniciAdilbl.TabIndex = 3;
            this.KullaniciAdilbl.Text = "kullanıcıAdı";
            // 
            // UrunPazari_btn
            // 
            this.UrunPazari_btn.Location = new System.Drawing.Point(44, 173);
            this.UrunPazari_btn.Name = "UrunPazari_btn";
            this.UrunPazari_btn.Size = new System.Drawing.Size(182, 29);
            this.UrunPazari_btn.TabIndex = 4;
            this.UrunPazari_btn.Text = "ÜRÜN PAZARI";
            this.UrunPazari_btn.UseVisualStyleBackColor = true;
            this.UrunPazari_btn.Click += new System.EventHandler(this.UrunPazari_btn_Click);
            // 
            // Bakiyelbl
            // 
            this.Bakiyelbl.AutoSize = true;
            this.Bakiyelbl.Location = new System.Drawing.Point(368, 9);
            this.Bakiyelbl.Name = "Bakiyelbl";
            this.Bakiyelbl.Size = new System.Drawing.Size(52, 20);
            this.Bakiyelbl.TabIndex = 5;
            this.Bakiyelbl.Text = "Bakiye";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mevcut Bakiye :";
            // 
            // gecmislbl
            // 
            this.gecmislbl.AutoSize = true;
            this.gecmislbl.Location = new System.Drawing.Point(287, 142);
            this.gecmislbl.Name = "gecmislbl";
            this.gecmislbl.Size = new System.Drawing.Size(0, 20);
            this.gecmislbl.TabIndex = 7;
            this.gecmislbl.Visible = false;
            // 
            // kid
            // 
            this.kid.AutoSize = true;
            this.kid.Location = new System.Drawing.Point(346, 158);
            this.kid.Name = "kid";
            this.kid.Size = new System.Drawing.Size(0, 20);
            this.kid.TabIndex = 8;
            this.kid.Visible = false;
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorsaUygulamasiFinal.Properties.Resources.wallpapersden_com_low_poly_blue_geometry_artwork_1280x720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 272);
            this.Controls.Add(this.kid);
            this.Controls.Add(this.gecmislbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Bakiyelbl);
            this.Controls.Add(this.UrunPazari_btn);
            this.Controls.Add(this.KullaniciAdilbl);
            this.Controls.Add(this.Ozet_btn);
            this.Controls.Add(this.Urun_EKLE);
            this.Controls.Add(this.Para_EKLE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Para_EKLE;
        private System.Windows.Forms.Button Urun_EKLE;
        private System.Windows.Forms.Button Ozet_btn;
        public System.Windows.Forms.Label KullaniciAdilbl;
        private System.Windows.Forms.Button UrunPazari_btn;
        public System.Windows.Forms.Label Bakiyelbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label gecmislbl;
        public System.Windows.Forms.Label kid;
    }
}