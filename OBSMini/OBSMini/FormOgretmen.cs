using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBSMini
{
    public partial class FormOgretmen : Form
    {
        private string ogretmenID;
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        public FormOgretmen(string ogretmenID)
        {
            InitializeComponent();
            this.ogretmenID = ogretmenID;
        }

        private void FormOgretmen_Load(object sender, EventArgs e)
        {
            string sorgu = $@"
SELECT ogr_id, (ogr_ad + ' ' + ogr_soyad) AS ogrenci_ad_soyad
FROM Ogrenciler
WHERE ogr_bolum_id IN (SELECT bolum_id FROM Dersler WHERE ogrt_id = {ogretmenID})";

            DataTable dt = vt.Select(sorgu);

            cmbOgrenciler.DataSource = dt;
            cmbOgrenciler.DisplayMember = "ogrenci_ad_soyad";
            cmbOgrenciler.ValueMember = "ogr_id";

            string sorgu2 = $@"
SELECT o.ogrt_ad, o.ogrt_soyad, u.unvan_ad
FROM Ogretim_Gorevlisi o
LEFT JOIN Ogretim_Gorevlisi_Unvan u ON o.ogrt_id = u.ogrt_id
WHERE o.ogrt_id = {ogretmenID}";

            DataTable dtt = vt.Select(sorgu2);  // Burada sorgu2 olmalı

            if (dtt.Rows.Count > 0)
            {
                string ad = dtt.Rows[0]["ogrt_ad"].ToString();
                string soyad = dtt.Rows[0]["ogrt_soyad"].ToString();
                string unvan = dtt.Rows[0]["unvan_ad"].ToString();

                label1.Text = $"Hoş geldiniz, {unvan} {ad} {soyad}";
            }
            else
            {
                label1.Text = "Öğretim Görevlisi bilgisi bulunamadı!";
            }


        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form1 girisForm = new Form1();
            girisForm.Show();
        }

        private void btnOgrenciNotlari_Click(object sender, EventArgs e)
        {
            if (cmbOgrenciler.SelectedValue != null)
            {
                int ogrenciID = Convert.ToInt32(cmbOgrenciler.SelectedValue);
                int ogretmenID_int = Convert.ToInt32(this.ogretmenID);

                FormNotlarOgrt notlarForm = new FormNotlarOgrt(ogrenciID, ogretmenID_int);
                notlarForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbOgrenciler.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir öğrenci seçin.");
                return;
            }

            int secilenOgrID = Convert.ToInt32(cmbOgrenciler.SelectedValue);
            int ogretmenID_int = Convert.ToInt32(this.ogretmenID);


            FormDevamOgrt frmDevamsizlik = new FormDevamOgrt(secilenOgrID, ogretmenID_int);

            frmDevamsizlik.Show();
        }
    }
    
    
}
