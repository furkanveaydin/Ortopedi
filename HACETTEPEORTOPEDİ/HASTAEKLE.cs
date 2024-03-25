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
    public partial class HASTAEKLE : Form
    {

        SqlConnection baglanti;
        SqlDataAdapter da;
        public HASTAEKLE()
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
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }

        static string constring =("Data Source=DESKTOP-BH7H7NQ\\SQLEXPRESS;Initial Catalog=HacettepeOrtopedi;Integrated Security=True");
        SqlConnection baglan = new SqlConnection(constring);
        private void HASTAEKLE_Load(object sender, EventArgs e)
        {


        }
        

        private void btnHastaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglan.State==ConnectionState.Closed)
                {
                    baglan.Open();
                    string kayit= "insert into HastaBilgileri(TC_KimliK_NO, AD, SOYAD, DogumTarih, CepTelefonu) values(@TC_Kimlik_NO,@AD,@SOYAD,@DogumTarih,@CepTelefonu)";
                    SqlCommand komut = new SqlCommand(kayit, baglan);
                    komut.Parameters.AddWithValue("@AD", textBoxAd.Text);
                    komut.Parameters.AddWithValue("@SOYAD", textBoxSoyad.Text);
                    komut.Parameters.AddWithValue("@DogumTarih", textBoxDt.Text);
                    komut.Parameters.AddWithValue("@TC_Kimlik_NO", textBoxTc.Text);
                    komut.Parameters.AddWithValue("@CepTelefonu", textBoxCepT.Text);
                    komut.ExecuteNonQuery();

                    HastaGetir();
                    MessageBox.Show("Kayıt Başarıyla Eklendi");
                    baglan.Close();
                }
              
            }
            catch (Exception hata)
            {
               
                MessageBox.Show("Yanlış Bir Değer Girdiniz, Kontrol Ediniz" + hata.Message);
                
            }
        }
    }
}
