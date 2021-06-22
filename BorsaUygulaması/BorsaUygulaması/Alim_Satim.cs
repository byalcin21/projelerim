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
    public partial class Alim_Satim : Form
    {
        public Alim_Satim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Borsa;Integrated Security=True");
        string kullaniciadi,satankullaniciAdi;
        string  urunisim, urunfiyat, urunmiktar,gecmis2,gecmis1,gecmistoplam;
        int miktar, fiyat, toplam = 0;
        SqlDataReader dr,dr2;
        SqlDataAdapter da;
        public int toplam2;
        public int bakiye, bakiyeson, urunMiktariSon, urunMiktari;
        private void urunlistele()
        {
            
            baglanti.Open();
            da = new SqlDataAdapter("SELECT satisID[Satis ID],urunAdi[Ürün İsmi],urunFiyati[Ürün Fiyatı(Kg)],urunMiktari[Ürün Miktarı] FROM satilanUrunler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            SatilanUrunler_DGW.DataSource = tablo;
            baglanti.Close();
        }

        private void SatinAlinanMiktar_txtbox_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgu_1 = new SqlCommand("Select *from  satilanUrunler where satisID=@satisid", baglanti);
            sorgu_1.Parameters.AddWithValue("@satisid", lblurunidwiew.Text);
            dr = sorgu_1.ExecuteReader();
            while (dr.Read())
            {
                int urunFiyati = Int32.Parse(dr["urunFiyati"].ToString());
                toplam = urunFiyati * (Int32.Parse(SatinAlinanMiktar_txtbox.Text));
                lbltoplamtutar.Text = toplam.ToString();
            }
            baglanti.Close();
        }

        private void SatilanUrunler_DGW_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            lblurunidwiew.Text = SatilanUrunler_DGW.CurrentRow.Cells[0].Value.ToString();
            UrunAdilbl.Text = SatilanUrunler_DGW.CurrentRow.Cells[1].Value.ToString();
            Miktarlbl.Text= SatilanUrunler_DGW.CurrentRow.Cells[2].Value.ToString();
            SatisFiyatilbl.Text= SatilanUrunler_DGW.CurrentRow.Cells[3].Value.ToString();
        }

        private void alıcıbakiyeazalt()
        {
            baglanti.Open();
            SqlCommand sorgu_3 = new SqlCommand("Select *from Kullanici where kullaniciID=@kullanID", baglanti);
            sorgu_3.Parameters.AddWithValue("kullanID", Convert.ToInt32(kullaniciid2.Text));
            dr2 = sorgu_3.ExecuteReader();
            while (dr2.Read())
            {
                bakiyeson = Int32.Parse(dr2["guncelBakiye"].ToString());
            }
            bakiyeson = bakiyeson - toplam;

            string bk = bakiyeson.ToString();
            dr2.Close();
            string sorgu = "update Kullanici SET guncelBakiye=@bakiyeson WHERE KullaniciID=@kullaniciID";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@bakiyeson", bk);
            komut.Parameters.AddWithValue("@kullaniciID", Convert.ToInt32(kullaniciid2.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        private void urunmiktarigetir()
        {
            baglanti.Open();
            SqlCommand sorgu_4 = new SqlCommand("Select *from satilanUrunler where satisID=@satisid", baglanti);
            sorgu_4.Parameters.AddWithValue("@satisid", lblurunidwiew.Text);
            dr = sorgu_4.ExecuteReader();
            while (dr.Read())
            {
                urunMiktari = Int32.Parse(dr["urunMiktari"].ToString());
            }
            baglanti.Close();

            dr.Close();
        }
        private void urunmiktarazalt()
        {
            baglanti.Open();
            SqlCommand sorgu_2 = new SqlCommand("Select *from satilanUrunler where satisID=@satisid", baglanti);
            sorgu_2.Parameters.AddWithValue("@satisid", lblurunidwiew.Text);
            dr = sorgu_2.ExecuteReader();
            while (dr.Read())
            {
                urunMiktariSon = Int32.Parse(dr["urunMiktari"].ToString());
            }
            urunMiktariSon = urunMiktariSon - Int32.Parse(SatinAlinanMiktar_txtbox.Text);

            string uM = urunMiktariSon.ToString();
            dr.Close();
            string sorgu = "update satilanUrunler SET urunMiktari=@urunMiktariSon WHERE satisID=@satisID";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@urunMiktariSon", uM);
            komut.Parameters.AddWithValue("@satisID", lblurunidwiew.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        private void muhasebe()
        {
            baglanti.Open();
            int komisyon = 0;
            int sonbakiye = 0;
            double urunfiyatbolu100 = toplam / 100;
            if (urunfiyatbolu100 < 1)
            {
                komisyon = 1;
            }
            else
            {
                komisyon = Int32.Parse((urunfiyatbolu100).ToString());
            }

            SqlCommand sorgu_6 = new SqlCommand("Select *from Kullanici where kullaniciID=@kullanID", baglanti);
            sorgu_6.Parameters.AddWithValue("kullanID", Convert.ToInt32(kullaniciid2.Text));
            SqlDataReader dr3 = sorgu_6.ExecuteReader();
            while (dr3.Read())
            {
                sonbakiye = Int32.Parse(dr3["guncelBakiye"].ToString());
            }


            sonbakiye -= komisyon;
            dr3.Close();
            string sorgu = "update Kullanici SET guncelBakiye=@bakiyeson WHERE KullaniciID=@kullaniciID";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@bakiyeson", sonbakiye);
            komut.Parameters.AddWithValue("@kullaniciID", Convert.ToInt32(kullaniciid2.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();

            System.Windows.Forms.MessageBox.Show("Satıştan Komisyon Olarak (%1)" + komisyon + " TL Sizin Hesabınızdan Kesildi");
        }
        void RaporYazdır()
        {
            baglanti.Open();
            DateTime tarihh = DateTime.Now;
            urunfiyat = SatisFiyatilbl.Text;
            urunmiktar = SatinAlinanMiktar_txtbox.Text;
            urunisim = UrunAdilbl.Text;
            gecmis2 = tarihh.ToString() + " " + urunisim.ToString() + " " + urunmiktar.ToString() + " " + urunfiyat.ToString() + "TL || ";
            gecmistoplam = gecmis1.ToString() + " " + gecmis2.ToString();
            SqlCommand kommut = new SqlCommand("update  Kullanici set Gecmis=@gecmis where KullanıcıAdı='" + KAdilbl.Text + "'", baglanti);
            kommut.Parameters.AddWithValue("@gecmis", gecmistoplam.ToString());
            kommut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void SatinAl_btnn_Click(object sender, EventArgs e)
        {
            bakiye = Convert.ToInt32(MevcutBakiyelbl.Text);
            urunmiktarigetir();
            
            if (bakiye >= toplam && urunMiktari >= (Int32.Parse(SatinAlinanMiktar_txtbox.Text)))
            {
                alıcıbakiyeazalt();
                urunmiktarazalt();
                muhasebe();
                RaporYazdır();
                System.Windows.Forms.MessageBox.Show("Ürün Satın Alındı.");
                bakiyegetir();
            }
            else System.Windows.Forms.MessageBox.Show("Paranız veya Ürün Miktarı yetersiz.Dilerseniz talep oluşturabilirsiniz...");
            urunlistele();
            
        }
        private void bakiyegetir()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Select *from  Kullanici where KullaniciID = @KullaniciID", baglanti);
            komut.Parameters.AddWithValue("@KullaniciID", Convert.ToInt32(kullaniciid2.Text));
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                MevcutBakiyelbl.Text = dr["guncelBakiye"].ToString();
            }
            baglanti.Close();
        }
        private void TalepEt_btn_Click(object sender, EventArgs e)
        {
            int bakiye=Convert.ToInt32(MevcutBakiyelbl.Text);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into SatilanUrunTalep (UrunAdi,Miktari,istenilenTutar,kullaniciAdi)values(@urunadi,@miktari,@tutari,@kullaniciadi)", baglanti);
            komut.Parameters.AddWithValue("@urunadi",Talep_cbox.Text);
            komut.Parameters.AddWithValue("@miktari",Convert.ToInt32(TalepMiktar_txtbox.Text));
            komut.Parameters.AddWithValue("@tutari",Convert.ToInt32(TalepTutar_txtbox.Text));
            komut.Parameters.AddWithValue("@kullaniciadi",kullaniciadi);
            komut.ExecuteNonQuery();
            MessageBox.Show("Talebiniz İletildi..");
            SqlCommand komut2 = new SqlCommand("select * from satilanUrunler where urunAdi='" +Talep_cbox.Text+ "' ", baglanti);
            SqlDataReader oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                miktar = Convert.ToInt32(oku["urunMiktari"].ToString());
                fiyat = (Convert.ToInt32((oku["urunFiyati"].ToString())));
                satankullaniciAdi = oku["KullaniciAdi"].ToString();
            }
            oku.Close();
            if(miktar>=(int.Parse(TalepMiktar_txtbox.Text)) && fiyat <= (int.Parse(TalepTutar_txtbox.Text)))
            {
                
                toplam = miktar * fiyat;
                miktar = miktar - Convert.ToInt32(TalepMiktar_txtbox.Text);
                SqlCommand komut3 = new SqlCommand("update satilanUrunler set urunMiktari=@miktari where KullaniciAdi='"+satankullaniciAdi+"'",baglanti);
               
                komut3.Parameters.AddWithValue("@miktari",miktar);
                komut3.ExecuteNonQuery();
                SqlCommand komut4  = new SqlCommand("update Kullanici set guncelBakiye=@guncel where KullanıcıAdı='"+KAdilbl.Text+"'",baglanti);
                komut4.Parameters.AddWithValue("@guncel", Convert.ToDecimal(bakiye - toplam+(toplam/100)));
                
                komut4.ExecuteNonQuery();
            }
            else { MessageBox.Show("Girilen Verilere Göre Satılan Ürün Bulunmamaktadır,Talep Sırasına Alınmıştır."); }
            baglanti.Close(); 
            bakiyegetir();
            RaporYazdır();
        }

        private void Alim_Satim_Load(object sender, EventArgs e)
        {
            kullaniciadi = KAdilbl.Text;
            urunlistele();
            baglanti.Open();
            SqlCommand kommmmut = new SqlCommand("Select *from Kullanici where KullanıcıAdı=@kullanadi", baglanti);
            kommmmut.Parameters.AddWithValue("@kullanadi",KAdilbl.Text);
            SqlDataReader oku = kommmmut.ExecuteReader();
            while (oku.Read())
            {
                gecmis1= (oku["Gecmis"].ToString());
                
            }
            baglanti.Close();



        }


        }
    }

