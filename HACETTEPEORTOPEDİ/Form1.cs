using System.Data.SqlTypes;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System.Data.SqlClient;

namespace HACETTEPEORTOPEDİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BH7H7NQ\\SQLEXPRESS;Initial Catalog=HacettepeOrtopedi;Integrated Security=True");


        private void btn1Giris_Click(object sender, EventArgs e)
        {
            if (textBox1kullaniciadi.Text == "" || textBox2sifre.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alanları Doldurunuz");

            }
            else
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("select*from KullaniciBilgileri where KullaniciAdi=@P1 And KullaniciSifre=@P2", baglanti);
                cmd.Parameters.AddWithValue("@P1", textBox1kullaniciadi.Text);
                cmd.Parameters.AddWithValue("@P2", textBox2sifre.Text);
                SqlDataReader oku = cmd.ExecuteReader();
                if (oku.Read())
                {
                    ANASAYFA ANA = new ANASAYFA();
                    ANA.Show();

                }
                else
                {
                    MessageBox.Show("Hatalı bilgi girişi yaptınız, tekrar deneyiniz", "KONTROL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                baglanti.Close();
            }

        }
    }
    }
