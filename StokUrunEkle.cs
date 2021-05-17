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
    public partial class StokUrunEkle : Form
    {
        public StokUrunEkle()
        {
            InitializeComponent();
        }
      
        SqlConnection baglanti = new SqlConnection("Data Source= DARKOLD\\DARKOLD;Initial Catalog=Urun;Integrated Security=True");
        Urun urun1 = new Urun();
        private void button1_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();

            urun1.Isim = comboBox1.Text;
            urun1.Miktar = Convert.ToInt32(numericUpDown1.Text);

            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kayit = "INSERT into Urunler(UrunIsmi, UrunMiktari, urunFiyati) values (@UrunIsmi, @UrunMiktari, @urunFiyati)";
                // string kayit = "SELECT * FROM Urunler";

                SqlCommand komut = new SqlCommand(kayit, baglanti);

                
                komut.Parameters.AddWithValue("@UrunIsmi", urun1.Isim);
                komut.Parameters.AddWithValue("@UrunMiktari", Convert.ToInt32(numericUpDown1.Text));
                komut.Parameters.AddWithValue("@KullaniciBakiye", Convert.ToInt32(txt_Para.Text));
                komut.ExecuteNonQuery();
                MessageBox.Show("Urun basariyla alindi");
                baglanti.Close();
                //MessageBox.Show("Urun basariyla alindi");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Islemde hata olustu\n" + hata.Message);

            }

        }
    }
}
