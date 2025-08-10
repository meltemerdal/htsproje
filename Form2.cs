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


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        frmSqlBaglanti bgl = new frmSqlBaglanti();

        private void btnKayit_Click(object sender, EventArgs e)
        {
            frmKayit fr = new frmKayit();
            fr.Show();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKulAdi.Text != "" && txtSifre.Text != "")
            {
                SqlCommand giris = new SqlCommand("girisYap", bgl.baglan());
                giris.CommandType = CommandType.StoredProcedure;
                giris.Parameters.AddWithValue("KulAdi", txtKulAdi.Text);
                giris.Parameters.AddWithValue("sifre", txtSifre.Text);
                SqlDataReader dr = giris.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Giriş İşlemi Başarılı", "Giriş İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAnaSayfa fr = new frmAnaSayfa();
                    this.Hide();
                    fr.Show();
                    
                }
                else
                {
                    MessageBox.Show("Giriş İşlemi Başarısız", "Giriş İşlemi Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
