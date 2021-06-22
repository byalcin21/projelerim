using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BorsaUygulaması
{ 
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Borsa;Integrated Security=True");
        
        private void Giris_Button_Click(object sender, EventArgs e)
        {AdminAnaMenu frm2 = new AdminAnaMenu();
            baglanti.Open();
            SqlDataReader reader;
            SqlCommand komut = new SqlCommand("Select * from Kullanici where KullanıcıAdı = @KullanıcıAdı and Şifre = @Şifre", baglanti);
            komut.Parameters.AddWithValue("@KullanıcıAdı", KullaniciAdi_textbox.Text);//parametreler
            komut.Parameters.AddWithValue("@Şifre", Sifre_textbox.Text);
            reader = komut.ExecuteReader();
            while (reader.Read())
            {
                Kullanici frm3 = new Kullanici();
                this.Hide();
                frm3.ShowDialog();
                this.Close();

            }
            
            if (KullaniciAdi_textbox.Text == "Admin" && Sifre_textbox.Text == "admin123")
            {
                MessageBox.Show("Giriş Başarılı..");
                this.Hide();
                frm2.ShowDialog();
                this.Close();
            }
            else
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
                MessageBox.Show("Giriş Başarısız. Kullanıcı Adı veya Şifre Hatalı  !!!"); 
            }
           
            baglanti.Close();

            

        }

        private void UyeOl_btn_Click(object sender, EventArgs e)
        {
            KullaniciEkle frm4 = new KullaniciEkle();
            frm4.ShowDialog();
        }
    }
}
