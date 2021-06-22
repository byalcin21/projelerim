
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
            this.Mbakiye = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_ekBak = new System.Windows.Forms.TextBox();
            this.KullaniciAdilbl2 = new System.Windows.Forms.Label();
            this.parabirimicmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_bakEk
            // 
            this.btn_bakEk.Location = new System.Drawing.Point(230, 179);
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
            // Mbakiye
            // 
            this.Mbakiye.AutoSize = true;
            this.Mbakiye.Location = new System.Drawing.Point(180, 57);
            this.Mbakiye.Name = "Mbakiye";
            this.Mbakiye.Size = new System.Drawing.Size(17, 20);
            this.Mbakiye.TabIndex = 2;
            this.Mbakiye.Text = "0";
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
            // KullaniciAdilbl2
            // 
            this.KullaniciAdilbl2.AutoSize = true;
            this.KullaniciAdilbl2.Location = new System.Drawing.Point(12, 9);
            this.KullaniciAdilbl2.Name = "KullaniciAdilbl2";
            this.KullaniciAdilbl2.Size = new System.Drawing.Size(0, 20);
            this.KullaniciAdilbl2.TabIndex = 5;
            // 
            // parabirimicmbx
            // 
            this.parabirimicmbx.FormattingEnabled = true;
            this.parabirimicmbx.Items.AddRange(new object[] {
            "DOLAR",
            "TL",
            "EURO",
            "STERLIN"});
            this.parabirimicmbx.Location = new System.Drawing.Point(180, 126);
            this.parabirimicmbx.Name = "parabirimicmbx";
            this.parabirimicmbx.Size = new System.Drawing.Size(151, 28);
            this.parabirimicmbx.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "PARA BİRİMİ :";
            // 
            // ParaYukleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorsaUygulamasiFinal.Properties.Resources.wallpapersden_com_low_poly_blue_geometry_artwork_1280x720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(363, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.parabirimicmbx);
            this.Controls.Add(this.KullaniciAdilbl2);
            this.Controls.Add(this.tbx_ekBak);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mbakiye);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_bakEk);
            this.Name = "ParaYukleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParaYukleme";
            this.Load += new System.EventHandler(this.ParaYukleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_bakEk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Mbakiye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_ekBak;
        public System.Windows.Forms.Label KullaniciAdilbl2;
        private System.Windows.Forms.ComboBox parabirimicmbx;
        private System.Windows.Forms.Label label2;
    }
}