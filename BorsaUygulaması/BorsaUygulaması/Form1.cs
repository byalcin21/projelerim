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
        {
            AdminAnaMenu admin = new AdminAnaMenu();

            Alim_Satim alim_Satim = new Alim_Satim();//  alim_satim formunu kullanarak nesne oluşturdum çünkü kullanıcı formundaki kullanıcı adını alım satım ekranına göndermek için gerekli 
            alim_Satim.KAdilbl.Text = KullaniciAdi_textbox.Text;
            baglanti.Open();
            SqlDataReader reader;
            SqlCommand komut = new SqlCommand("Select * from Kullanici where KullanıcıAdı = @KullanıcıAdı and Şifre = @Şifre", baglanti);// veri tabanından verileri çekip data readerla okutup textboxlardaki textlerle karşılaştırıyoruz ve giriş işleminin kontrolünü sağlıyoruz
            komut.Parameters.AddWithValue("@KullanıcıAdı", KullaniciAdi_textbox.Text);//parametreler
            komut.Parameters.AddWithValue("@Şifre", Sifre_textbox.Text);
            reader = komut.ExecuteReader();
            while (reader.Read())
            { 
               
                Kullanici KullaniciEkrani = new Kullanici();// kullanıcı ekranını kullanarak nesne tanımladım ekran geçişi ve formlar arası veri aktarımı için kullanıcam
                KullaniciEkrani.KullaniciAdilbl.Text = KullaniciAdi_textbox.Text;
                MessageBox.Show("Giriş Başarılı Hoşgeldin "+KullaniciAdi_textbox.Text+" :)");
                this.Hide();// ekranı açmadan önce gizledim ekranı açtım ve diğer ekranı kapattım 
                KullaniciEkrani.ShowDialog();
                this.Close();

            }
            
            if (KullaniciAdi_textbox.Text == "Admin" && Sifre_textbox.Text == "admin123")
            {
               
                MessageBox.Show("Giriş Başarılı Hoşgeldin Admin :)");
                this.Hide();
                admin.ShowDialog();
                this.Close();
            }
            else
            {
                foreach (Control item in this.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text = "";// eğer kullanıcı adı ve şifre eşleşmezse textboxların textlerini temizler ve giriş başarısız mesajını verir.
                    }
                }
                MessageBox.Show("Giriş Başarısız. Kullanıcı Adı veya Şifre Hatalı  !!!"); 
            }
           
            baglanti.Close();

            

        }

        private void UyeOl_btn_Click(object sender, EventArgs e)
        {
            KullaniciEkle KayitEkrani = new KullaniciEkle();
            KayitEkrani.ShowDialog();// eğer kullanıcı kayıtlı değilse giriş ekranından kayıt olması için kayıt ekranına yönlendirilir
        }
    }
}
