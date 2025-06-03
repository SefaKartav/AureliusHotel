using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // Veritabanı bağlantısı için ekliyoruz

namespace denemeiconfalan
{
    public partial class RezervasonIslemleri : Form
    {
        // Veritabanı bağlantı bilgisi
        string connectionString = "Server=localhost;Database=oteltrivela;Uid=root;Pwd=14032004";

        public RezervasonIslemleri()
        {
            InitializeComponent();
        }

        private void RezervasonIslemleri_Load(object sender, EventArgs e)
        {
            // Form yüklenirken kullanıcının rezervasyonlarını listele
            KullaniciRezervasyonlariniGetir();
        }

        private void KullaniciRezervasyonlariniGetir()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Sadece giriş yapan kullanıcının email adresine göre filtreleme
                    string sql = "SELECT ad, soyad, email, tcno, telefon, giris_tarihi, cikis_tarihi, oda_tipi, gun_sayisi, toplam_tutar FROM rezervasyonlar WHERE email = @email";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@email", FormAnaSayfa.KullaniciEmail); // Email bilgisi FormAnaSayfa'dan alınacak

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }
    }
}
