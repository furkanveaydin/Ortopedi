using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HACETTEPEORTOPEDİ
{
    public partial class ANASAYFA : Form
    {


        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public ANASAYFA()
        {
            InitializeComponent();
        }

        void HastaGetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-BH7H7NQ\\SQLEXPRESS;Initial Catalog=HacettepeOrtopedi;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("select*from HastaBilgileri", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void ANASAYFA_Load(object sender, EventArgs e)
        {

        }

        private void btnyenihastaekle_Click(object sender, EventArgs e)
        {
            HASTAEKLE HASTAEKLE = new HASTAEKLE();
            HASTAEKLE.Show();
        }

        private void btnTumu_Click(object sender, EventArgs e)
        {
            HastaGetir();
        }


    }
}


        

