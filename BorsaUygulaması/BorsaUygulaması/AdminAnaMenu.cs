﻿using System;
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
    public partial class AdminAnaMenu : Form
    {
        public AdminAnaMenu()
        {
            InitializeComponent();
        }
        
        private void Kullanici_Ekle_Click(object sender, EventArgs e)
        {
            KullaniciEkle kullaniciEklemeEkrani = new KullaniciEkle();
            
            kullaniciEklemeEkrani.ShowDialog();
           
        }

        private void Alim_Satim_Goster_Click(object sender, EventArgs e)
        {

        }

        private void Alici_Onay_Click(object sender, EventArgs e)
        {

        }

        private void AdminOnay_Click(object sender, EventArgs e)
        {
            AdminOnay adminOnaylama = new AdminOnay();
            adminOnaylama.ShowDialog();

        }
    }
}
