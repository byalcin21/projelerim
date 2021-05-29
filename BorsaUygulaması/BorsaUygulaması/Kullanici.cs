using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaUygulaması
{
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }

        private void Para_EKLE_Click(object sender, EventArgs e)
        {
            ParaYukleme frm5 = new ParaYukleme();
            this.Hide();
            frm5.ShowDialog();
            this.Close();

        }

        private void Urun_EKLE_Click(object sender, EventArgs e)
        {
            StokUrunEkle frm6 = new StokUrunEkle();
            this.Hide();
            frm6.ShowDialog();
            this.Close();
        }

        private void Ozet_Click(object sender, EventArgs e)
        {

        }

        private void Kullanici_Load(object sender, EventArgs e)
        {

        }
    }
}
