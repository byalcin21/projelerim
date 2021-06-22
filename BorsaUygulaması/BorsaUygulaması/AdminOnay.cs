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
    public partial class AdminOnay : Form
    {
        public AdminOnay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Borsa;Integrated Security=True");
        SqlDataAdapter da;// birden fazla fonkisyonda data adapter ve Sqlcommand kullandığımız için public sınıfın içerisinde tanımladık
        SqlCommand komut;

        private void urunonaylistele()
        {
           
            baglanti.Open();

            da = new SqlDataAdapter("SELECT urunlerID[Talep ID] ,KullaniciAdi[Kullanıcı Adı],UrunIsmi[Ürün İsmi],urunFiyati[Ürün Fiyatı(Kg)],UrunMiktari[Ürün Miktarı] FROM Urunler", baglanti);
            DataTable tablo = new DataTable();// data adapter ile ürünler tablosundan data gridwiew e veri aktardık 
            da.Fill(tablo);//data adapter i doldurduk ve onun aracılığla urundatagridWiewe attım
            UrunDGW.DataSource = tablo;
            baglanti.Close();

        }
        private void paraonaylistele()
        {
            baglanti.Open();
            da = new SqlDataAdapter("SELECT talepID[Talep ID],KullaniciID[Kllanıcı ID],KullaniciAdi[Kullanıcı Adı],talepPara[Para Talep Miktarı] FROM talep", baglanti);
            DataTable tablo = new DataTable();//para onaylama tabcontrolundeki paraDGW e data adapter ile veri tabanından veri aktarımı yaptım
            da.Fill(tablo);
            ParaDGW.DataSource = tablo;
            baglanti.Close();
        }
        private void urunonayla()
        {

            try
            {
                baglanti.Open();
                komut = new SqlCommand("insert into satilanUrunler (urunAdi,urunMiktari,urunFiyati,KullaniciAdi) VALUES (@urunadi,@urunmiktari,@urunfiyati,@kullaniciadi) ", baglanti);
                komut.Parameters.AddWithValue("@urunadi", UrunAdi_txtbox.Text);// urun onaylama buttonuna basıldıgında calısacak olan bu fonksiyonda onaylandığında textboxlardaki değerleri satilan ürünler tablosuna aktardım
                komut.Parameters.AddWithValue("@urunfiyati", UrunFiyat_txtbox.Text);
                komut.Parameters.AddWithValue("@urunmiktari", UrunMiktar_txtbox.Text);
                komut.Parameters.AddWithValue("@kullaniciadi", SatanKullanıcıAdi_txtbox.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                uruntaleptemizle();// urun talebini onayladıktan sonra talep no ile talep tablosundan silen kodların bulunduğu fonksiyonu çağırdım
                urunonaylistele();// sonra tekrardan urun onaylamayı listeledim silinen taleplerin gitmesi için
                MessageBox.Show("Ürün Onaylandı!", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                MessageBox.Show(hatamsj.Message);
                baglanti.Close();
            }


        }

        private void paraonayla()
        {
            int idd = 0;
            int toplam = 0;
            try
            {
                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("select * from Kullanici where KullanıcıAdı='"+KullaniciAdi_txtboxx.Text+"'", baglanti);
                SqlDataReader oku = komut1.ExecuteReader();// kullanıcı adınagöre kullanıcı tablosundan verileri getirdim ve datareader ile kullanıcı id ve güncel bakiyeyi değişkene ve para label ına attım
                while (oku.Read())
                {
                    idd = Convert.ToInt32(oku["kullaniciID"]);
                    para.Text = oku["guncelBakiye"].ToString();
                    para.Text = Convert.ToString(Convert.ToInt32(Convert.ToDecimal(para.Text)));
                }
                oku.Close();// data reader ı açık bırakınca sql e komut gönderilmediğinden kapattım
                SqlCommand komut2 = new SqlCommand("update Kullanici SET guncelBakiye=@paraMiktari WHERE kullaniciID='"+idd+"'",baglanti);
                komut2.Parameters.AddWithValue("@kullaniciID", Convert.ToInt32(kullaniciIDlbl.Text));// değişkene attıgım id numarası ile kullanıcı tablosundaki güncel bakiyeyi yeniledim
                toplam= Convert.ToInt32(TalepMiktari_txtboxx.Text) + Convert.ToInt32(para.Text);
                string toplamstr = Convert.ToString(toplam);
                komut2.Parameters.AddWithValue("@paraMiktari", Convert.ToDecimal(Convert.ToInt32(toplam)));// güncel bakiye = güncel bakiye + onaylanan para
               
                komut2.ExecuteNonQuery();
                baglanti.Close();
                parataleptemizle();// onayladığım para taleplerini silmek için para talep temizleme fonksiyonunu çağırdım
                paraonaylistele();
                MessageBox.Show("Para Talebi Onaylandı!", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                baglanti.Close();
            }

        }
        private void parataleptemizle()
        {
            baglanti.Open();
            string sorgu = "DELETE FROM talep WHERE talepID=@ıd";
            komut = new SqlCommand(sorgu, baglanti);// para onayladıktan sonra ve reddettikten sonra çağıracağım bu fonksiyonda para taleplerini talep id ye göre veri tabanından silen kodlar burada mevcuttur
            komut.Parameters.AddWithValue("@ıd", Convert.ToInt32(ParaTalepNo_txtbox.Text));
            komut.ExecuteNonQuery();
            baglanti.Close(); 
        }

        private void uruntaleptemizle()
        {
            baglanti.Open();
            string sorgu = "DELETE FROM Urunler WHERE urunlerID=@urunID";
            komut = new SqlCommand(sorgu, baglanti);// para talep temizlemede yaptığım gibi buradada ürün idsine göre ürünler tablosundan onaylanan ve reddedilen ürünleri sildim
            komut.Parameters.AddWithValue("@urunID", Convert.ToInt32(UrunTalepNo_txtbox.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
        }


        private void AdminOnay_Load(object sender, EventArgs e)
        {
            urunonaylistele();//form un load kısmını datagridwiewlerin içerisine verileri ekran açılır açılmaz yüklenmesi için ürün onay listele ve para onay listele fonksiyonlarını çağırdım
            paraonaylistele();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UrunTalepNo_txtbox.Text = UrunDGW.CurrentRow.Cells[0].Value.ToString();// bu kısımda mause çift tıklama yaptığımızda form ekranındaki textboxlara bilgilerin aktarılmasını sağlıyoruz
            SatanKullanıcıAdi_txtbox.Text = UrunDGW.CurrentRow.Cells[1].Value.ToString();
            UrunAdi_txtbox.Text = UrunDGW.CurrentRow.Cells[2].Value.ToString();
            UrunFiyat_txtbox.Text = UrunDGW.CurrentRow.Cells[3].Value.ToString();
            UrunMiktar_txtbox.Text = UrunDGW.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunonayla();// ürün onaylama buttonuna bastıgımızda ürün onayla fonksiyonunu çalıştırdık
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uruntaleptemizle(); //ürün reddetme buttonuna bastığımızda ürün talep temizle fonksiyonunu çalıştırdık
            MessageBox.Show("Ürün Talebi Reddedildi !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paraonayla();// para onayla buttonuna bastığımızda paraonayla fonkisyonunu çalıştırdık
            paraonaylistele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parataleptemizle();
            MessageBox.Show("Para Talebi Reddedildi !", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            paraonaylistele();
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ParaTalepNo_txtbox.Text = ParaDGW.CurrentRow.Cells[0].Value.ToString();// para onaylama datagridviewin üstünde çift tıklama yaptıgımızda textboxların dolmasını sağladık
            kullaniciIDlbl.Text = ParaDGW.CurrentRow.Cells[1].Value.ToString();
            KullaniciAdi_txtboxx.Text = ParaDGW.CurrentRow.Cells[2].Value.ToString();
            TalepMiktari_txtboxx.Text = Convert.ToString(Convert.ToInt32(Convert.ToDecimal(ParaDGW.CurrentRow.Cells[3].Value.ToString())));

        }
    }
}
