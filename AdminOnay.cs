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
        SqlConnection baglantim;
        SqlCommand komut;
        SqlDataAdapter da;
        private void urunonaylistele()
        {
            baglantim = new SqlConnection("Data Source=DARKOLD\\DARKOLD;Initial Catalog=Urun;Integrated Security=True");
            baglantim.Open();

            da = new SqlDataAdapter("SELECT urunlerID[Talep ID] ,KullaniciAdi[Kullanıcı Adı],UrunIsmi[Ürün İsmi],urunFiyati[Ürün Fiyatı(Kg)],UrunMiktari[Ürün Miktarı] FROM Urunler", baglantim);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantim.Close();

        }
        private void paraonaylistele()
        {
            baglantim.Open();
            da = new SqlDataAdapter("SELECT talepID[Talep İD],KullaniciID[Kullanıcı ID],talepMiktari[Talep Miktarı] FROM talep", baglantim);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglantim.Close();
        }
        private void urunonayla()
        {

            try
            {
                baglantim.Open();
                string sorgu = "insert into satilanUrunler (urunAdi,urunMiktari,urunFiyati) VALUES (@urunadi,@urunmiktari,@urunfiyati) ";
                komut = new SqlCommand(sorgu, baglantim);
                komut.Parameters.AddWithValue("@urunadi", textBox4.Text);
                komut.Parameters.AddWithValue("@urunfiyati", textBox5.Text);
                komut.Parameters.AddWithValue("@urunmiktari", textBox6.Text);
                komut.ExecuteNonQuery();
                baglantim.Close();
                uruntaleptemizle();
                urunonaylistele();
                MessageBox.Show("Ürün Onaylandı!", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                MessageBox.Show(hatamsj.Message);
                baglantim.Close();
            }


        }

        private void paraonayla()
        {
            try
            {
                baglantim.Open();
                string sorgu = "update Kullanici SET guncelBakiye=@talepmiktari WHERE KullaniciID=kullaniciID";
                komut = new SqlCommand(sorgu, baglantim);
                komut.Parameters.AddWithValue("@talepmiktari", textBox9.Text);
                komut.Parameters.AddWithValue("@kullaniciID", textBox7.Text);
                komut.ExecuteNonQuery();
                baglantim.Close();
                parataleptemizle();
                paraonaylistele();
                MessageBox.Show("Para Talebi Onaylandı!", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                baglantim.Close();
            }

        }
        private void parataleptemizle()
        {
            baglantim.Open();
            string sorgu = "DELETE FROM talep WHERE talepID=@ıd";
            komut = new SqlCommand(sorgu, baglantim);
            komut.Parameters.AddWithValue("@ıd", Convert.ToInt32(textBox2.Text));
            komut.ExecuteNonQuery();
            baglantim.Close();
        }

        private void uruntaleptemizle()
        {
            baglantim.Open();
            string sorgu = "DELETE FROM Urunler WHERE urunlerID=@urunID";
            komut = new SqlCommand(sorgu, baglantim);
            komut.Parameters.AddWithValue("@urunID", Convert.ToInt32(textBox1.Text));
            komut.ExecuteNonQuery();
            baglantim.Close();
        }


        private void AdminOnay_Load(object sender, EventArgs e)
        {
            urunonaylistele();
            paraonaylistele();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunonayla();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uruntaleptemizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            paraonayla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parataleptemizle();
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            // textBox7.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            textBox9.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }
    }
}
