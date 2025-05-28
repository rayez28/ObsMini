
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace OBSMini
{
    class VeritabaniIslemleri
    {
        SqlConnection baglanti = new SqlConnection("Data Source=EMRULLAH\\SQLEXPRESS01;Initial Catalog=OBSMini;Integrated Security=True;Encrypt=False");
        public DataTable datatbl = new DataTable();
        public SqlDataAdapter adtr = new SqlDataAdapter();
        public SqlCommand sqlkomut = new SqlCommand();


        public DataTable Select(string sorgu)
        {
            if (baglan() == true)
            {
                datatbl = new DataTable();
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                adtr.SelectCommand = sqlkomut;
                adtr.Fill(datatbl);
                baglantiKapat();
                return datatbl;
            }
            else
                return null;
        }

        public int Insert(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
                return 0;
        }
        public int Execute(string sorgu)
        {
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            if (baglanti.State != ConnectionState.Open)
                baglanti.Open();

            int etkilenen = komut.ExecuteNonQuery();
            baglanti.Close();
            return etkilenen;
        }

        public int UpdateDelete(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
                return 0;
        }

        public int SorguCalistir(string sorgu)
        {
            if (baglan() == true)
            {
                sqlkomut.Connection = baglanti;
                sqlkomut.CommandText = sorgu;
                int sayi = sqlkomut.ExecuteNonQuery();
                baglantiKapat();
                return sayi;
            }
            else
                return 0;

        }


        bool baglan()
        {
            try
            {
                baglanti.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        void baglantiKapat()
        {
            try
            {
                baglanti.Close();
            }
            catch
            {
 
            }
        }

    }
}