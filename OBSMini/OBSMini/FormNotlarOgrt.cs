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
    public partial class FormNotlarOgrt : Form
    {
        int ogrenciID;
        int ogretmenID;
        int secilenOgrID;
        int dersID;
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        public FormNotlarOgrt(int ogrenciID, int ogretmenID)
        {
            InitializeComponent();
            this.ogrenciID = ogrenciID;
            this.ogretmenID = ogretmenID;
            this.secilenOgrID = ogrenciID;
            this.dersID = dersID;
        }

        private void FormNotlarOgrt_Load(object sender, EventArgs e)
        {
            string sorguNotlar = $@"
SELECT n.not_id, d.ders_ad, n.vize, n.final, n.ortalama
FROM Notlar n
JOIN Dersler d ON n.ders_id = d.ders_id
WHERE n.ogr_id = {ogrenciID} AND d.ogrt_id = {ogretmenID}";

            DataTable dtNotlar = vt.Select(sorguNotlar);
            dataGridView1.DataSource = dtNotlar;

            string sorguDersler = $@"
SELECT d.ders_id, d.ders_ad
FROM Dersler d
INNER JOIN Notlar n ON d.ders_id = n.ders_id
WHERE d.ogrt_id = {ogretmenID} AND n.ogr_id = {ogrenciID}";

            DataTable dtDersler = vt.Select(sorguDersler);

            comboBoxDersler.DisplayMember = "ders_ad";
            comboBoxDersler.ValueMember = "ders_id";
            comboBoxDersler.DataSource = dtDersler;
        }

        private void btnNotGuncelle_Click_Click(object sender, EventArgs e)
        {
            if (comboBoxDersler.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir ders seçin.");
                return;
            }

            int dersID = Convert.ToInt32(comboBoxDersler.SelectedValue);

            if (!int.TryParse(txtVize.Text, out int vize) || vize < 0 || vize > 100)
            {
                MessageBox.Show("Geçerli bir vize notu girin (0-100).");
                return;
            }

            if (!int.TryParse(txtFinal.Text, out int final) || final < 0 || final > 100)
            {
                MessageBox.Show("Geçerli bir final notu girin (0-100).");
                return;
            }

            double ortalama = vize * 0.4 + final * 0.6;

            // Not kontrolü (var mı diye)
            string kontrolSorgu = $"SELECT COUNT(*) FROM Notlar WHERE ogr_id = {secilenOgrID} AND ders_id = {dersID}";
            DataTable dtKontrol = vt.Select(kontrolSorgu);
            int mevcutKayit = Convert.ToInt32(dtKontrol.Rows[0][0]);

            if (mevcutKayit > 0)
            {
                DialogResult dr = MessageBox.Show("Not zaten mevcut, güncellemek ister misiniz?", "Not Güncelleme", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string updateSorgu = $@"
                UPDATE Notlar SET 
                    vize = {vize}, 
                    final = {final}, 
                    ortalama = {ortalama} 
                WHERE ogr_id = {secilenOgrID} AND ders_id = {dersID}";

                    int sonuc = vt.UpdateDelete(updateSorgu);
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Not başarıyla güncellendi.");
                        NotlariListele();
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme başarısız.");
                    }
                }
            }
            else
            {
                string insertSorgu = $@"
            INSERT INTO Notlar (ogr_id, ders_id, vize, final, ortalama)
            VALUES ({secilenOgrID}, {dersID}, {vize}, {final}, {ortalama})";

                int sonuc = vt.Insert(insertSorgu);
                if (sonuc > 0)
                {
                    MessageBox.Show("Not başarıyla eklendi.");
                    NotlariListele();
                    Temizle();
                }
                else
                {
                    MessageBox.Show("Not eklenirken hata oluştu.");
                }
            }
        }
        private void NotlariListele()
        {
            string sorgu = $@"
        SELECT n.not_id, d.ders_ad, n.vize, n.final
        FROM Notlar n
        JOIN Dersler d ON n.ders_id = d.ders_id
        WHERE n.ogr_id = {secilenOgrID} AND d.ogrt_id = {ogretmenID}";

            DataTable dt = vt.Select(sorgu);

            // Yeni ortalama sütunu ekle
            if (!dt.Columns.Contains("ortalama"))
                dt.Columns.Add("ortalama", typeof(double));

            // Her satır için ortalama hesapla
            foreach (DataRow row in dt.Rows)
            {
                int vize = Convert.ToInt32(row["vize"]);
                int final = Convert.ToInt32(row["final"]);
                double ortalama = vize * 0.4 + final * 0.6;
                row["ortalama"] = ortalama;
            }

            dataGridView1.DataSource = dt;
        }
        private void Temizle()
        {
            txtVize.Clear();
            txtFinal.Clear();
            comboBoxDersler.SelectedIndex = 0;
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            try
            {
                int ogrenciID = this.secilenOgrID;

                if (comboBoxDersler.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir ders seçin.");
                    return;
                }

                int dersID = Convert.ToInt32(comboBoxDersler.SelectedValue);

                int vize = Convert.ToInt32(txtVize.Text);
                int final = Convert.ToInt32(txtFinal.Text);
                double ortalama = (vize * 0.4) + (final * 0.6);

                string sorgu = $@"
            INSERT INTO Notlar (ogr_id, ders_id, vize, final, ortalama)
            VALUES ({ogrenciID}, {dersID}, {vize}, {final}, {ortalama})";

                int sonuc = vt.Execute(sorgu);

                if (sonuc > 0)
                {
                    MessageBox.Show("Not başarıyla eklendi!");
                    NotlariListele();  // Grid güncellenir
                    Temizle();        // Textboxlar temizlenir
                }
                else
                {
                    MessageBox.Show("Not eklenirken bir hata oluştu!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void comboBoxDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
