
namespace BorsaUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KullaniciAdi_textbox = new System.Windows.Forms.TextBox();
            this.Sifre_textbox = new System.Windows.Forms.TextBox();
            this.Giris_Button = new System.Windows.Forms.Button();
            this.UyeOl_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(72, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // KullaniciAdi_textbox
            // 
            this.KullaniciAdi_textbox.Location = new System.Drawing.Point(72, 87);
            this.KullaniciAdi_textbox.Name = "KullaniciAdi_textbox";
            this.KullaniciAdi_textbox.Size = new System.Drawing.Size(207, 27);
            this.KullaniciAdi_textbox.TabIndex = 2;
            // 
            // Sifre_textbox
            // 
            this.Sifre_textbox.Location = new System.Drawing.Point(72, 140);
            this.Sifre_textbox.Name = "Sifre_textbox";
            this.Sifre_textbox.Size = new System.Drawing.Size(207, 27);
            this.Sifre_textbox.TabIndex = 3;
            // 
            // Giris_Button
            // 
            this.Giris_Button.Location = new System.Drawing.Point(188, 186);
            this.Giris_Button.Name = "Giris_Button";
            this.Giris_Button.Size = new System.Drawing.Size(91, 28);
            this.Giris_Button.TabIndex = 4;
            this.Giris_Button.Text = "Giriş";
            this.Giris_Button.UseVisualStyleBackColor = true;
            this.Giris_Button.Click += new System.EventHandler(this.Giris_Button_Click);
            // 
            // UyeOl_btn
            // 
            this.UyeOl_btn.Location = new System.Drawing.Point(20, 214);
            this.UyeOl_btn.Name = "UyeOl_btn";
            this.UyeOl_btn.Size = new System.Drawing.Size(91, 29);
            this.UyeOl_btn.TabIndex = 5;
            this.UyeOl_btn.Text = "ÜYE OL";
            this.UyeOl_btn.UseVisualStyleBackColor = true;
            this.UyeOl_btn.Click += new System.EventHandler(this.UyeOl_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kayıtlı Değilim";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BorsaUygulaması.Properties.Resources.wallpapersden_com_low_poly_blue_geometry_artwork_1280x720;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(329, 287);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UyeOl_btn);
            this.Controls.Add(this.Giris_Button);
            this.Controls.Add(this.Sifre_textbox);
            this.Controls.Add(this.KullaniciAdi_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log-in Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KullaniciAdi_textbox;
        private System.Windows.Forms.TextBox Sifre_textbox;
        private System.Windows.Forms.Button Giris_Button;
        private System.Windows.Forms.Button UyeOl_btn;
        private System.Windows.Forms.Label label3;
    }
}

