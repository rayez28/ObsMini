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
    public partial class FormDevamOgrt : Form
    {
        private int ogrenciID;
        private int ogretmenID;
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        public FormDevamOgrt(int ogrenciID, int ogretmenID)
        {
            InitializeComponent();
            this.ogrenciID = ogrenciID;
            this.ogretmenID = ogretmenID;
        }

        private void FormDevamOgrt_Load(object sender, EventArgs e)
        {

            string sorguDersler = $"SELECT ders_id, ders_ad FROM Dersler WHERE ogrt_id = {ogretmenID}";
            DataTable dtDersler = vt.Select(sorguDersler);

            comboBoxDersler.DisplayMember = "ders_ad";
            comboBoxDersler.ValueMember = "ders_id";
            comboBoxDersler.DataSource = dtDersler;

            // İlk ders seçiliyse o dersin devamsızlıklarını listele
            if (comboBoxDersler.Items.Count > 0)
            {
                comboBoxDersler.SelectedIndex = 0;
                ListeleDevamsizliklar();
                comboBoxDurum.Items.AddRange(new string[] { "Geldi", "Gelmedi", "İzinli" });
                comboBoxDurum.SelectedIndex = 0;
            }
        }
        private void buttonEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxDersler.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir ders seçin.");
                return;
            }

            int secilenDersID = Convert.ToInt32(comboBoxDersler.SelectedValue);
            DateTime tarih = dateTimePickerTarih.Value;
            string durum = comboBoxDurum.SelectedItem.ToString();

            string sorguInsert = $@"
        INSERT INTO Devamsizlik (ogr_id, ders_id, tarih, durum)
        VALUES ({ogrenciID}, {secilenDersID}, '{tarih:yyyy-MM-dd}', '{durum}')";

            int sonuc = vt.Insert(sorguInsert);
            if (sonuc > 0)
            {
                MessageBox.Show("Devamsızlık başarıyla eklendi.");
                ListeleDevamsizliklar();
            }
            else
            {
                MessageBox.Show("Devamsızlık eklenirken hata oluştu.");
            }

        }
        private void ListeleDevamsizliklar()
        {
            if (comboBoxDersler.SelectedValue == null) return;

            int secilenDersID = Convert.ToInt32(comboBoxDersler.SelectedValue);

            string sorguDevamsizlik = $@"
        SELECT devamsizlik_id, tarih, durum
        FROM Devamsizlik
        WHERE ogr_id = {ogrenciID} AND ders_id = {secilenDersID}
        ORDER BY tarih DESC";

            DataTable dtDevamsizlik = vt.Select(sorguDevamsizlik);
            dataGridViewDevamsizlik.DataSource = dtDevamsizlik;
        }

        private void comboBoxDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListeleDevamsizliklar();
        }
    }
}
