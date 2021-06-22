
namespace BorsaUygulaması
{
    partial class Alim_Satim
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
            this.SatilanUrunler_DGW = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TalepEt_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Talep_cbox = new System.Windows.Forms.ComboBox();
            this.TalepMiktar_txtbox = new System.Windows.Forms.TextBox();
            this.TalepTutar_txtbox = new System.Windows.Forms.TextBox();
            this.KAdilbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MevcutBakiyelbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UrunAdilbl = new System.Windows.Forms.Label();
            this.Miktarlbl = new System.Windows.Forms.Label();
            this.SatisFiyatilbl = new System.Windows.Forms.Label();
            this.SatinAlinanMiktar_txtbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SatinAl_btnn = new System.Windows.Forms.Button();
            this.lblurunidwiew = new System.Windows.Forms.Label();
            this.lbltoplamtutar = new System.Windows.Forms.Label();
            this.kullaniciid2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SatilanUrunler_DGW)).BeginInit();
            this.SuspendLayout();
            // 
            // SatilanUrunler_DGW
            // 
            this.SatilanUrunler_DGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SatilanUrunler_DGW.Location = new System.Drawing.Point(340, 191);
            this.SatilanUrunler_DGW.Name = "SatilanUrunler_DGW";
            this.SatilanUrunler_DGW.RowHeadersWidth = 51;
            this.SatilanUrunler_DGW.RowTemplate.Height = 29;
            this.SatilanUrunler_DGW.Size = new System.Drawing.Size(515, 233);
            this.SatilanUrunler_DGW.TabIndex = 1;
            this.SatilanUrunler_DGW.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.SatilanUrunler_DGW_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Talep Edilecek Ürün :";
            // 
            // TalepEt_btn
            // 
            this.TalepEt_btn.Location = new System.Drawing.Point(191, 209);
            this.TalepEt_btn.Name = "TalepEt_btn";
            this.TalepEt_btn.Size = new System.Drawing.Size(94, 29);
            this.TalepEt_btn.TabIndex = 4;
            this.TalepEt_btn.Text = "TALEP ET";
            this.TalepEt_btn.UseVisualStyleBackColor = true;
            this.TalepEt_btn.Click += new System.EventHandler(this.TalepEt_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Miktarı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Talep Tutarı :";
            // 
            // Talep_cbox
            // 
            this.Talep_cbox.FormattingEnabled = true;
            this.Talep_cbox.Items.AddRange(new object[] {
            "ÜZÜM(KG)",
            "ARPA(KG)",
            "BUĞDAY(KG)",
            "DEZENFEKTAN(LİTRE)",
            "CERRAHİ MASKE(50 ADET)",
            "LİMON KOLONYASI(LİTRE)",
            "ELMA(KG)"});
            this.Talep_cbox.Location = new System.Drawing.Point(160, 109);
            this.Talep_cbox.Name = "Talep_cbox";
            this.Talep_cbox.Size = new System.Drawing.Size(125, 28);
            this.Talep_cbox.TabIndex = 7;
            // 
            // TalepMiktar_txtbox
            // 
            this.TalepMiktar_txtbox.Location = new System.Drawing.Point(160, 143);
            this.TalepMiktar_txtbox.Name = "TalepMiktar_txtbox";
            this.TalepMiktar_txtbox.Size = new System.Drawing.Size(125, 27);
            this.TalepMiktar_txtbox.TabIndex = 8;
            // 
            // TalepTutar_txtbox
            // 
            this.TalepTutar_txtbox.Location = new System.Drawing.Point(160, 176);
            this.TalepTutar_txtbox.Name = "TalepTutar_txtbox";
            this.TalepTutar_txtbox.Size = new System.Drawing.Size(125, 27);
            this.TalepTutar_txtbox.TabIndex = 9;
            // 
            // KAdilbl
            // 
            this.KAdilbl.AutoSize = true;
            this.KAdilbl.Location = new System.Drawing.Point(12, 9);
            this.KAdilbl.Name = "KAdilbl";
            this.KAdilbl.Size = new System.Drawing.Size(90, 20);
            this.KAdilbl.TabIndex = 10;
            this.KAdilbl.Text = "kullanici Adi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "İSTEDİĞİN FİYATTAN ÜRÜN TALEP ET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ürünün Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(452, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ürünün Mevcut Miktarı ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ürünün Satış Fiyatı :";
            // 
            // MevcutBakiyelbl
            // 
            this.MevcutBakiyelbl.AutoSize = true;
            this.MevcutBakiyelbl.Location = new System.Drawing.Point(817, 9);
            this.MevcutBakiyelbl.Name = "MevcutBakiyelbl";
            this.MevcutBakiyelbl.Size = new System.Drawing.Size(52, 20);
            this.MevcutBakiyelbl.TabIndex = 15;
            this.MevcutBakiyelbl.Text = "Bakiye";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mevcut Bakiyeniz :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(214, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Satın Alıcağınız Miktarı Giriniz :";
            // 
            // UrunAdilbl
            // 
            this.UrunAdilbl.AutoSize = true;
            this.UrunAdilbl.Location = new System.Drawing.Point(620, 36);
            this.UrunAdilbl.Name = "UrunAdilbl";
            this.UrunAdilbl.Size = new System.Drawing.Size(0, 20);
            this.UrunAdilbl.TabIndex = 18;
            // 
            // Miktarlbl
            // 
            this.Miktarlbl.AutoSize = true;
            this.Miktarlbl.Location = new System.Drawing.Point(620, 66);
            this.Miktarlbl.Name = "Miktarlbl";
            this.Miktarlbl.Size = new System.Drawing.Size(0, 20);
            this.Miktarlbl.TabIndex = 19;
            // 
            // SatisFiyatilbl
            // 
            this.SatisFiyatilbl.AutoSize = true;
            this.SatisFiyatilbl.Location = new System.Drawing.Point(620, 96);
            this.SatisFiyatilbl.Name = "SatisFiyatilbl";
            this.SatisFiyatilbl.Size = new System.Drawing.Size(0, 20);
            this.SatisFiyatilbl.TabIndex = 20;
            // 
            // SatinAlinanMiktar_txtbox
            // 
            this.SatinAlinanMiktar_txtbox.Location = new System.Drawing.Point(620, 123);
            this.SatinAlinanMiktar_txtbox.Name = "SatinAlinanMiktar_txtbox";
            this.SatinAlinanMiktar_txtbox.Size = new System.Drawing.Size(125, 27);
            this.SatinAlinanMiktar_txtbox.TabIndex = 21;
            this.SatinAlinanMiktar_txtbox.TextChanged += new System.EventHandler(this.SatinAlinanMiktar_txtbox_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(127, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(529, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "SATIN ALINAN HER ÜRÜNDEN % 1 MUHASEBE KOMİSYONU ALINMAKTADIR !!";
            // 
            // SatinAl_btnn
            // 
            this.SatinAl_btnn.Location = new System.Drawing.Point(744, 156);
            this.SatinAl_btnn.Name = "SatinAl_btnn";
            this.SatinAl_btnn.Size = new System.Drawing.Size(94, 29);
            this.SatinAl_btnn.TabIndex = 25;
            this.SatinAl_btnn.Text = "SATIN AL";
            this.SatinAl_btnn.UseVisualStyleBackColor = true;
            this.SatinAl_btnn.Click += new System.EventHandler(this.SatinAl_btnn_Click);
            // 
            // lblurunidwiew
            // 
            this.lblurunidwiew.AutoSize = true;
            this.lblurunidwiew.Location = new System.Drawing.Point(534, 160);
            this.lblurunidwiew.Name = "lblurunidwiew";
            this.lblurunidwiew.Size = new System.Drawing.Size(0, 20);
            this.lblurunidwiew.TabIndex = 26;
            this.lblurunidwiew.Visible = false;
            // 
            // lbltoplamtutar
            // 
            this.lbltoplamtutar.AutoSize = true;
            this.lbltoplamtutar.Location = new System.Drawing.Point(400, 160);
            this.lbltoplamtutar.Name = "lbltoplamtutar";
            this.lbltoplamtutar.Size = new System.Drawing.Size(0, 20);
            this.lbltoplamtutar.TabIndex = 27;
            this.lbltoplamtutar.Visible = false;
            // 
            // kullaniciid2
            // 
            this.kullaniciid2.AutoSize = true;
            this.kullaniciid2.Location = new System.Drawing.Point(227, 312);
            this.kullaniciid2.Name = "kullaniciid2";
            this.kullaniciid2.Size = new System.Drawing.Size(0, 20);
            this.kullaniciid2.TabIndex = 28;
            this.kullaniciid2.Visible = false;
            // 
            // Alim_Satim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorsaUygulamasiFinal.Properties.Resources.wallpapersden_com_low_poly_blue_geometry_artwork_1280x720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(887, 491);
            this.Controls.Add(this.kullaniciid2);
            this.Controls.Add(this.lbltoplamtutar);
            this.Controls.Add(this.lblurunidwiew);
            this.Controls.Add(this.SatinAl_btnn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SatinAlinanMiktar_txtbox);
            this.Controls.Add(this.SatisFiyatilbl);
            this.Controls.Add(this.Miktarlbl);
            this.Controls.Add(this.UrunAdilbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.MevcutBakiyelbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KAdilbl);
            this.Controls.Add(this.TalepTutar_txtbox);
            this.Controls.Add(this.TalepMiktar_txtbox);
            this.Controls.Add(this.Talep_cbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TalepEt_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SatilanUrunler_DGW);
            this.Name = "Alim_Satim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SATIŞ EKRANI";
            this.Load += new System.EventHandler(this.Alim_Satim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SatilanUrunler_DGW)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SatilanUrunler_DGW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button TalepEt_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Talep_cbox;
        private System.Windows.Forms.TextBox TalepMiktar_txtbox;
        private System.Windows.Forms.TextBox TalepTutar_txtbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label UrunAdilbl;
        private System.Windows.Forms.Label Miktarlbl;
        private System.Windows.Forms.Label SatisFiyatilbl;
        private System.Windows.Forms.TextBox SatinAlinanMiktar_txtbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button SatinAl_btnn;
        public System.Windows.Forms.Label KAdilbl;
        public System.Windows.Forms.Label MevcutBakiyelbl;
        private System.Windows.Forms.Label lblurunidwiew;
        private System.Windows.Forms.Label lbltoplamtutar;
        public System.Windows.Forms.Label kullaniciid2;
    }
}