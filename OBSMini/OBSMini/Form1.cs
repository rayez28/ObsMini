using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBSMini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text.Trim();

            if (kullaniciAdi == "" || sifre == "")
            {
                lblHata.Text = "Kullanıcı adı ve şifre giriniz.";
                return;
            }

            // SQL Injection'a karşı parametrik sorgu kullanacağız.
            string sorgu = $"SELECT * FROM Kullanici WHERE kullanici_adi = '{kullaniciAdi}' AND sifre = '{sifre}'";
            DataTable dt = vt.Select(sorgu);

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                string kullaniciID = dr["kullanici_id"].ToString();
                string ogrID = dr["ogr_id"].ToString();
                string ogrtID = dr["ogrt_id"].ToString();

                if (!string.IsNullOrEmpty(ogrID)) // Öğrenci girişi
                {
                    FormOgrenci ogrForm = new FormOgrenci(ogrID);
                    ogrForm.Show();
                    this.Hide();
                }
                else if (!string.IsNullOrEmpty(ogrtID)) // Öğretim görevlisi girişi
                {
                    FormOgretmen ogretmenForm = new FormOgretmen(ogrtID);
                    ogretmenForm.Show();
                    this.Hide();
                }
                else
                {
                    lblHata.Text = "Rol belirlenemedi. Veritabanı hatası.";
                }
            }
            else
            {
                lblHata.Text = "Kullanıcı adı veya şifre yanlış.";
            }
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            FormSifreDegistir sifreForm = new FormSifreDegistir();
            sifreForm.ShowDialog();
        }
    }
}
