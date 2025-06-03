using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace denemeiconfalan
{
    public partial class KullaniciBilgileri : Form
    {
        string connectionString = "Server=localhost;Database=oteltrivela;Uid=root;Pwd=14032004";

        public KullaniciBilgileri()
        {
            InitializeComponent();
        }

        private void KullaniciBilgileri_Load(object sender, EventArgs e)
        {
            // Kullanıcı bilgilerini form açılınca çekelim
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM kullanicilar WHERE kullanici_adi = @kullanici_adi";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kullanici_adi", FormAnaSayfa.KullaniciAdi);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        TextBoxIsimBilgi.Text = reader["kullanici_adi"].ToString();
                        TextBoxTCBilgi.Text = reader["tc"].ToString();
                        TextBoxEMailBilgi.Text = reader["email"].ToString();
                        TextBoxSifreBilgi.Text = reader["sifre"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void TextBoxIsimBilgi_Click(object sender, EventArgs e)
        {
        }

        private void TextBoxSifreBilgi_Click(object sender, EventArgs e)
        {
        }

        private void TextBoxEMailBilgi_Click(object sender, EventArgs e)
        {
        }

        private void TextBoxTCBilgi_Click(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Kullanıcı bilgilerini güncelle
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "UPDATE kullanicilar SET kullanici_adi=@kullanici_adi, tc=@tc, email=@email, sifre=@sifre WHERE kullanici_adi=@eski_kullanici_adi";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kullanici_adi", TextBoxIsimBilgi.Text.Trim());
                    cmd.Parameters.AddWithValue("@tc", TextBoxTCBilgi.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", TextBoxEMailBilgi.Text.Trim());
                    cmd.Parameters.AddWithValue("@sifre", TextBoxSifreBilgi.Text.Trim());
                    cmd.Parameters.AddWithValue("@eski_kullanici_adi", FormAnaSayfa.KullaniciAdi);

                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Bilgiler başarıyla güncellendi!");
                        FormAnaSayfa.KullaniciAdi = TextBoxIsimBilgi.Text.Trim(); // Kullanıcı adı değişirse güncelle
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme yapılamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }
    }
}
