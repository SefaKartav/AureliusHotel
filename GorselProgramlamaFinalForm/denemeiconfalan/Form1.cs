using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace denemeiconfalan
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        // Bağlantı cümlesi
        string connectionString = "Server=localhost;Database=oteltrivela;Uid=root;Pwd=14032004";

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TextBoxKullaniciAdi_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxSifre_Click(object sender, EventArgs e)
        {

        }



        private void buttonKayitOlYonlendir_Click(object sender, EventArgs e)
        {
            FormKayit kayitFormu = new FormKayit(); // Yeni FormKayit formunu oluştur
            kayitFormu.Show();                      // FormKayit'ı göster
            this.Hide();                            // Form1'i gizle
        }

        private void ButtonGirisYap_Click_1(object sender, EventArgs e)
        {

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT * FROM kullanicilar WHERE kullanici_adi = @kullanici_adi AND sifre = @sifre";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@kullanici_adi", TextBoxKullaniciAdi.Text.Trim());
                    cmd.Parameters.AddWithValue("@sifre", TextBoxSifre.Text.Trim());

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        MessageBox.Show("Giriş başarılı!");

                        // ⭐ Kullanıcı bilgilerini kaydet
                        FormAnaSayfa.KullaniciAdi = reader["kullanici_adi"].ToString();
                        FormAnaSayfa.KullaniciEmail = reader["email"].ToString();

                        // Ana Sayfa formunu aç
                        FormAnaSayfa anaSayfa = new FormAnaSayfa();
                        anaSayfa.Show();
                        this.Hide(); // Giriş ekranını gizle
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
