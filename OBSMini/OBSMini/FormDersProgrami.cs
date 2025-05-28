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
    public partial class FormDersProgrami : Form
    {
        private int ogrenciID;
        VeritabaniIslemleri vt = new VeritabaniIslemleri();

        public FormDersProgrami(int ogrenciID)
        {
            InitializeComponent();
            this.ogrenciID = ogrenciID;
        }

        private void FormDersProgrami_Load(object sender, EventArgs e)
        {
            string sorgu = $@"
                SELECT dp.gun, dp.saat, d.ders_ad
                FROM Notlar n
                JOIN Dersler d ON n.ders_id = d.ders_id
                JOIN Ders_Programi dp ON d.ders_id = dp.ders_id
                WHERE n.ogr_id = {ogrenciID}";

            DataTable dt = vt.Select(sorgu);
            dataGridView1.DataSource = dt;
        }

        private void btnGeri_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
