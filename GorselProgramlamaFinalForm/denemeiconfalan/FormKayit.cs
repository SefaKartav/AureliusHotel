using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace denemeiconfalan
{
    public partial class FormKayit : Form
    {
        string connectionString = "Server=localhost;Database=oteltrivela;Uid=root;Pwd=14032004";

        public FormKayit()
        {
            InitializeComponent();
        }

        private void ButtonKayitOl_Click_1(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO kullanicilar (kullanici_adi, tc, sifre, email) VALUES (@kullanici_adi, @tc, @sifre, @email)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@kullanici_adi", ArtikolKullaniciAdi.Text.Trim());
                    cmd.Parameters.AddWithValue("@tc", ArtikolTc.Text.Trim());
                    cmd.Parameters.AddWithValue("@sifre", ArtikolSifre.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", ArtikolEmail.Text.Trim());

                    int sonuc = cmd.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarılı! Giriş ekranına yönlendiriliyorsunuz.");

                        Form1 girisFormu = new Form1();
                        girisFormu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt yapılamadı, lütfen tekrar deneyin!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void ArtikolKullaniciAdi_Click(object sender, EventArgs e) { }
        private void ArtikolSifre_Click(object sender, EventArgs e) { }
        private void ArtikolTc_Click(object sender, EventArgs e) { }
        private void ArtikolEmail_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}
