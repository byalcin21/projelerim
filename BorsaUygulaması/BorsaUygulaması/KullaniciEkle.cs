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
    public partial class KullaniciEkle : Form
    {
        public KullaniciEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Borsa;Integrated Security=True");
        private void Kullanici_ekle_btn_Click(object sender, EventArgs e)
        {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Kullanici(Adı,Soyadı,TC,Telefon,email,KullanıcıAdı,Şifre,Adres) values(@Adı,@Soyadı,@TC,@Telefon,@email,@KullanıcıAdı,@Şifre,@Adres) ", baglanti);
                komut.Parameters.AddWithValue("@Adı", Ad_textbox.Text);// textboxlara girilen değerleri veri tabanına bağlanarak kullanici tablosuna yazdırdım 
                komut.Parameters.AddWithValue("@Soyadı", Soyad_textbox.Text);
                komut.Parameters.AddWithValue("@TC", TC_textbox.Text);
                komut.Parameters.AddWithValue("@Telefon", Telefon_textbox.Text);
                komut.Parameters.AddWithValue("@email", email_textbox.Text);
                komut.Parameters.AddWithValue("@KullanıcıAdı", KullaniciAdi_textbox.Text);
                komut.Parameters.AddWithValue("@Şifre", Sifre_textbox.Text);
                komut.Parameters.AddWithValue("@Adres", Adres_textbox.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi.");

                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";
                    }
                }
            
            baglanti.Close();

        }
    }
}
