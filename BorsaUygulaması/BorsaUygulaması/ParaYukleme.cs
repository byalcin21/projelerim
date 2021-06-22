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
using System.Xml;

namespace BorsaUygulaması
{
    public partial class ParaYukleme : Form
    {
        public ParaYukleme()
        {
            InitializeComponent();
        }
        int id=0;
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=Borsa;Integrated Security=True");
        private void btn_bakEk_Click(object sender, EventArgs e)
        {
            
            
            int para=0;
            string USD,EURO,STERLIN;
            string kaynak = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();// xml okuyucuya kaynağı yükledim ve merkez bankasındaki dolar euro ve sterlinin o anlık değerine eriştim ve bunları bir değişkene attım
            xmlDoc.Load(kaynak);
            USD = (xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml);
            EURO =(xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml);
            STERLIN = (xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml);
            // comboboxtaki seçim dolar olursa dolar üzerinden euro olursa euro, sterlin olursa sterlin (GBP) tl olursa tl üzerinden işleme aldım.
            if (Convert.ToString(parabirimicmbx.SelectedItem)=="DOLAR")
            {
                
                para =Convert.ToInt32(Convert.ToDecimal(USD)); // her if içerisinde aynı işlemi yaptım, önce siteden aldığım değeri decimale çevirdim çünkü virgüllü halde işlem yapamıyoruz
                para =Convert.ToInt32(Convert.ToString(para)) * Convert.ToInt32(tbx_ekBak.Text);// daha sonra decimali int e çevirdim sonra tekrardan stringe çevirdim ve son kez int e çevirdim ve textboxtan girilen değerle çarptım
                para = para / 10000;//sonra int türünde olduğu için kolayca bölme işlemi yaptım decimalde iken bunu yapamıyoruz 10000 e böldüm çünkü sitedeki değerler virgülden sonra 4 basamaklı her basamak için 10^1, 4 basamak için 10^4=10000

            }
            else if (Convert.ToString(parabirimicmbx.SelectedItem) == "EURO")
            {
                para = Convert.ToInt32(Convert.ToDecimal(EURO));
                para = Convert.ToInt32(Convert.ToString(para)) * Convert.ToInt32(tbx_ekBak.Text);
                para = para / 10000;
            }
            else if (Convert.ToString(parabirimicmbx.SelectedItem) == "STERLIN")
            {

                para = Convert.ToInt32(Convert.ToDecimal(STERLIN));
                para = Convert.ToInt32(Convert.ToString(para)) * Convert.ToInt32(tbx_ekBak.Text);
                para = para / 10000;
            }
            else para =(Convert.ToInt32(tbx_ekBak.Text));// diğerlerinden farklı olarak burada tl olduğu için direktmen int e çevirip aşağıda parametre kullanarak veri tabanına değerini girdim

            try
            {
                if (baglanti.State == ConnectionState.Closed)


                    baglanti.Open();
                string kayit = "insert into talep(KullaniciID,KullaniciAdi,talepPara) values (@id,@kullaniciadi,@Tpara)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);//burada talep tablosuna aşağıda aldığımız kullanıcıid yi, labeldeki kullanıcıAdı nı ve işlemlerini yaptığımız para talep tutarını decimale çevirerek attım çünkü veri tabanında column name in değişkeni money bu da virgülden sonra 4 basamaklı olduğu için   
                komut.Parameters.AddWithValue("@id", id);
                komut.Parameters.AddWithValue("@kullaniciadi",KullaniciAdilbl2.Text);
                komut.Parameters.AddWithValue("@Tpara", Convert.ToDecimal(para));
                komut.ExecuteNonQuery();
                MessageBox.Show("Bakiye Talebi İletildi");
                tbx_ekBak.Clear();
                baglanti.Close();
            }

            catch (Exception hata)
            {
                MessageBox.Show("Islemde hata olustu\n" + hata.Message);
            }
        }

        private void ParaYukleme_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from kullanici where KullanıcıAdı='" + KullaniciAdilbl2.Text + "' ", baglanti);
            SqlDataReader oku = komut2.ExecuteReader(); //kullanıcı adını kullanarak veri tabanında arama yaptım ve kullanıcıID ve guncelBakiyeye eriştim 
            while (oku.Read())// kullanıcı adını veri tabanındaki kullanıcı adıyla karşılaştırdıktan sonra atama işlemlerini yaptım
            {
                id = Convert.ToInt32(oku["kullaniciID"]);
                Mbakiye.Text = oku["guncelBakiye"].ToString();
                Alim_Satim alim_Satim = new Alim_Satim();// Alım satım ekranındaki mevcut bakiye labelına veri göndermek için alım satım ekranın adını kullanarak bir nesne oluşturdum
                alim_Satim.MevcutBakiyelbl.Text = Mbakiye.Text;// nesneyi oluşturduktan sonra nesneyi kullanarak formdaki elemanlarına eriştim ve veri aktardım
            }
            oku.Close();
        }
    }
}
