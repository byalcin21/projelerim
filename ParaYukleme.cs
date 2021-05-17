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
    public partial class ParaYukleme : Form
    {
        public ParaYukleme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source= DARKOLD\\DARKOLD;Initial Catalog=Urun;Integrated Security=True");
        private void btn_bakEk_Click(object sender, EventArgs e)
        {
            tbx_ekBak.Clear();
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();

                string kayit = "insert into talep(talepMiktari) values (@talepMiktari)";
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                komut.Parameters.AddWithValue("@talepMiktari", tbx_ekBak.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show("Bakiye Talebi İletildi");
                baglanti.Close();
            }

            catch (Exception hata)
            {
                MessageBox.Show("Islemde hata olustu\n" + hata.Message);
            }
        }
    }
}
