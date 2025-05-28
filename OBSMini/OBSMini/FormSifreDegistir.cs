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
    public partial class FormSifreDegistir : Form
    {
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        public FormSifreDegistir()
        {
            InitializeComponent();
        }

        private void FormSifreDegistir_Load(object sender, EventArgs e)
        {

        }

        private void btnDegistir_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string eskiSifre = txtEskiSifre.Text.Trim();
            string yeniSifre = txtYeniSifre.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(eskiSifre) || string.IsNullOrEmpty(yeniSifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            string kontrolSorgusu = $@"
                SELECT * FROM Kullanici 
                WHERE kullanici_adi = '{kullaniciAdi}' AND sifre = '{eskiSifre}'";

            DataTable dt = vt.Select(kontrolSorgusu);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Kullanıcı adı veya eski şifre yanlış.");
                return;
            }

            string updateSorgu = $@"
                UPDATE Kullanici 
                SET sifre = '{yeniSifre}' 
                WHERE kullanici_adi = '{kullaniciAdi}'";

            int sonuc = vt.UpdateDelete(updateSorgu);

            if (sonuc > 0)
                MessageBox.Show("Şifre başarıyla değiştirildi.");
            else
                MessageBox.Show("Şifre güncellenemedi.");
        }

        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
