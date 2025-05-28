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
    public partial class FormOgrenci : Form
    {
        private string ogrenciID;
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        public FormOgrenci(string ogrenciID)
        {
            InitializeComponent();
            this.ogrenciID = ogrenciID;
        }

        private void FormOgrenci_Load(object sender, EventArgs e)
        {
            string sorgu = $@"
    SELECT 
        o.ogr_ad, 
        o.ogr_soyad, 
        o.ogr_dtarihi, 
        o.ogr_cinsiyet, 
        o.ogr_durum, 
        o.ogr_kayit_tarihi, 
        o.ogr_tel_no, 
        b.bolum_ad
    FROM Ogrenciler o
    JOIN Bolumler b ON o.ogr_bolum_id = b.bolum_id
    WHERE o.ogr_id = {ogrenciID}";


            DataTable dt = vt.Select(sorgu);

            if (dt.Rows.Count > 0)
            {
                lblAd.Text = dt.Rows[0]["ogr_ad"].ToString();
                lblSoyad.Text = dt.Rows[0]["ogr_soyad"].ToString();
                lblDogumTarihi.Text = Convert.ToDateTime(dt.Rows[0]["ogr_dtarihi"]).ToShortDateString();
                lblCinsiyet.Text = dt.Rows[0]["ogr_cinsiyet"].ToString();
                lblDurum.Text = dt.Rows[0]["ogr_durum"].ToString();
                lblKayitTarihi.Text = Convert.ToDateTime(dt.Rows[0]["ogr_kayit_tarihi"]).ToShortDateString();
                lblTelefon.Text = dt.Rows[0]["ogr_tel_no"].ToString();
                lblBolum.Text = dt.Rows[0]["bolum_ad"].ToString();
            }
            else
            {
                MessageBox.Show("Öğrenci bilgileri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNotlar_Click(object sender, EventArgs e)
        {
            int ogrenciIDInt = Convert.ToInt32(ogrenciID);
            FormNotlar notlarForm = new FormNotlar(ogrenciIDInt);
            notlarForm.ShowDialog();
        }

        private void btnDersProgrami_Click(object sender, EventArgs e)
        {
            int ogrID = Convert.ToInt32(ogrenciID);
            FormDersProgrami dpForm = new FormDersProgrami(ogrID);
            dpForm.ShowDialog();
        }

        private void btnDevamsizlik_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.ogrenciID);
            FormDevamsizlik frm = new FormDevamsizlik(id);
            frm.ShowDialog();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 girisForm = new Form1();
            girisForm.Show();
        }
    }
}
