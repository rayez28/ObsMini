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
    public partial class FormDevamsizlik : Form
    {
        private int ogrenciID;
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        public FormDevamsizlik(int ogrenciID)
        {
            InitializeComponent();
            this.ogrenciID = ogrenciID;
        }

        private void FormDevamsizlik_Load(object sender, EventArgs e)
        {
            string sorgu = $@"
            SELECT 
                d.ders_ad,
                dev.tarih,
                dev.durum
            FROM Devamsizlik dev
            JOIN Dersler d ON dev.ders_id = d.ders_id
            WHERE dev.ogr_id = {ogrenciID}
            ORDER BY dev.tarih DESC";

            DataTable dt = vt.Select(sorgu);
            dataGridView1.DataSource = dt;
        }

        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
