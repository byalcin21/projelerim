
namespace BorsaUygulaması
{
    partial class StokUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokUrunEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UrunEkle_btn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NUDMiktar = new System.Windows.Forms.NumericUpDown();
            this.txt_Para = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMiktar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SATICAĞINIZ ÜRÜNÜ SEÇİNİZ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÜRÜNÜN MİKTARINI GİRİN(KG) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÜRÜNÜN BİRİM FİYATI :";
            // 
            // UrunEkle_btn
            // 
            this.UrunEkle_btn.Location = new System.Drawing.Point(266, 199);
            this.UrunEkle_btn.Name = "UrunEkle_btn";
            this.UrunEkle_btn.Size = new System.Drawing.Size(94, 29);
            this.UrunEkle_btn.TabIndex = 3;
            this.UrunEkle_btn.Text = "EKLE";
            this.UrunEkle_btn.UseVisualStyleBackColor = true;
            this.UrunEkle_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ÜZÜM(KG)",
            "ARPA(KG)",
            "BUĞDAY(KG)",
            "DEZENFEKTAN(LİTRE)",
            "CERRAHİ MASKE(50 ADET)",
            "LİMON KOLONYASI(LİTRE)",
            "ELMA(KG)"});
            this.comboBox1.Location = new System.Drawing.Point(242, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // NUDMiktar
            // 
            this.NUDMiktar.Location = new System.Drawing.Point(243, 108);
            this.NUDMiktar.Name = "NUDMiktar";
            this.NUDMiktar.Size = new System.Drawing.Size(150, 27);
            this.NUDMiktar.TabIndex = 5;
            // 
            // txt_Para
            // 
            this.txt_Para.Location = new System.Drawing.Point(243, 147);
            this.txt_Para.Name = "txt_Para";
            this.txt_Para.Size = new System.Drawing.Size(150, 27);
            this.txt_Para.TabIndex = 6;
            // 
            // StokUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorsaUygulamasiFinal.Properties.Resources.wallpapersden_com_low_poly_blue_geometry_artwork_1280x720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 252);
            this.Controls.Add(this.txt_Para);
            this.Controls.Add(this.NUDMiktar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.UrunEkle_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StokUrunEkle";
            ((System.ComponentModel.ISupportInitialize)(this.NUDMiktar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UrunEkle_btn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown NUDMiktar;
        private System.Windows.Forms.TextBox txt_Para;
    }
}