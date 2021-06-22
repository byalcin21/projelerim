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
using System.IO;

namespace BorsaUygulaması
{
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Borsa;Integrated Security=True");
        private void Para_EKLE_Click(object sender, EventArgs e)
        {

            ParaYukleme paraYuklemeEkrani = new ParaYukleme();// burada para yukleme ekranını kullanarak nesne oluşturdum hem veri aktarımı için hemde bu forma geçiş için gerekli
            paraYuklemeEkrani.KullaniciAdilbl2.Text = KullaniciAdilbl.Text;// para yükleme ekranındaki elemanlara erişiğ kullanıcıadı labelina kullanıcı adını attım

            paraYuklemeEkrani.ShowDialog();// para ekleme buttonuna basıldığında para yükleme ekranını açacak


        }

        private void Urun_EKLE_Click(object sender, EventArgs e)
        {
            StokUrunEkle stokUrunEklemeEkrani = new StokUrunEkle();
            stokUrunEklemeEkrani.ShowDialog();// urun ekleme buttonuna basıldığında urun ekleme formu açılacak

        }

        private void Ozet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string Gecmis1,Gecmis2;
            string dosyaYolu = @"C:\Users\baran\OneDrive\Masaüstü\BorsaUygulaması2\";
            SqlCommand komut3 = new SqlCommand("SELECT *FROM Kullanici WHERE KullanıcıAdı='" + KullaniciAdilbl.Text + "' ", baglanti);// kullanıcı adına göre kullanıcı tablosunu okuyor
            SqlDataReader oku = komut3.ExecuteReader();
            while (oku.Read())
            {
                Gecmis1 =oku["Gecmis"].ToString();
                FileStream fs = File.Create(dosyaYolu + KullaniciAdilbl.Text + "_Rapor.html");
                fs.Close();// kullanıcı tablosundaki satın alım geçmişini gecmis 1 e kaydedip kullanıcı adında belirtilen dosya yolunda html uzantısı olarak oluşturuyor
                string[] Satir = File.ReadAllLines(dosyaYolu + KullaniciAdilbl.Text + "_Rapor.html");
                StreamWriter Yazıcı = new StreamWriter(dosyaYolu + KullaniciAdilbl.Text + "_Rapor.html");
                Yazıcı.WriteLine("<h3>Kullanıcı Adı :" + KullaniciAdilbl.Text + "</h3>");
                Yazıcı.WriteLine("<h3>SATIN ALMA GEÇMİŞİ  :" + Gecmis1 + "</h3>");
                Yazıcı.WriteLine("<h3></h3>");
                Yazıcı.WriteLine("<h3></h3>");
                Yazıcı.Close();
                MessageBox.Show("" + KullaniciAdilbl.Text + "_Rapor.html Dosyasına Başarıyla Rapor Yazıldı.");
                
            }
           
            baglanti.Close();
           

        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            Alim_Satim alim_Satim = new Alim_Satim();//  alim_satim formunu kullanarak nesne oluşturdum çünkü kullanıcı formundaki kullanıcı adını alım satım ekranına göndermek için gerekli 
            
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from kullanici where KullanıcıAdı='" + KullaniciAdilbl.Text + "' ", baglanti);
            SqlDataReader oku = komut2.ExecuteReader(); //kullanıcı adını kullanarak veri tabanında arama yaptım ve kullanıcıID ve guncelBakiyeye eriştim 
            while (oku.Read())// kullanıcı adını veri tabanındaki kullanıcı adıyla karşılaştırdıktan sonra atama işlemlerini yaptım
            {
                Bakiyelbl.Text = oku["guncelBakiye"].ToString();
                kid.Text = oku["kullaniciID"].ToString() ;
            }
            
            baglanti.Close();
            
        }

        private void UrunPazari_btn_Click(object sender, EventArgs e)
        {
            Alim_Satim urunPazari = new Alim_Satim();
            urunPazari.MevcutBakiyelbl.Text = Bakiyelbl.Text;// nesneyi oluşturduktan sonra nesneyi kullanarak formdaki elemanlarına eriştim ve veri aktardım
            urunPazari.KAdilbl.Text = KullaniciAdilbl.Text;
            urunPazari.kullaniciid2.Text = kid.Text;
            urunPazari.ShowDialog();//urun pazari buttonuna basıldığında Alım_satim ekranı açılacak
        }
    }
}
