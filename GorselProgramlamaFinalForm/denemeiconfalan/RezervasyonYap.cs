using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace denemeiconfalan
{
    public partial class RezervasyonYap : Form
    {
        public RezervasyonYap()
        {
            InitializeComponent();
        }

        private void RezervasyonYap_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxUcret_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxTelefonRezervasyon_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxTCNoRezervasyon_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxMailRezervasyon_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxSoyadRezervasyon_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxIsimRezervasyon_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerGirisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerCikisTarihi_ValueChanged(object sender, EventArgs e)
        {

        }





        private void radioButtonStandart_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonDeluxe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonExecutive_CheckedChanged(object sender, EventArgs e)
        {

        }



        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonPresidentiel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSuperior_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAnaSayfa anaSayfa = new FormAnaSayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Bağlantı cümlesini kendi bağlantına göre ayarla
            string connectionString = "server=localhost;database=oteltrivela;user=root;password=14032004;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Girilen verileri oku
                    string ad = TextBoxIsimRezervasyon.Text.Trim();
                    string soyad = TextBoxSoyadRezervasyon.Text.Trim();
                    string email = TextBoxMailRezervasyon.Text.Trim();
                    string tcno = TextBoxTCNoRezervasyon.Text.Trim();
                    string telefon = TextBoxTelefonRezervasyon.Text.Trim();
                    DateTime girisTarihi = dateTimePickerGirisTarihi.Value;
                    DateTime cikisTarihi = dateTimePickerCikisTarihi.Value;

                    // Gün sayısını hesapla
                    int gunSayisi = (cikisTarihi - girisTarihi).Days;
                    if (gunSayisi <= 0)
                    {
                        MessageBox.Show("Çıkış tarihi giriş tarihinden sonra olmalı!");
                        return;
                    }

                    // Oda tipini ve fiyatı seç
                    string odaTipi = "";
                    decimal gunlukFiyat = 0;

                    if (radioButtonStandart.Checked)
                    {
                        odaTipi = "Standart Oda";
                        gunlukFiyat = 125;
                    }
                    else if (radioButtonDeluxe.Checked)
                    {
                        odaTipi = "Deluxe Oda";
                        gunlukFiyat = 135;
                    }
                    else if (radioButtonExecutive.Checked)
                    {
                        odaTipi = "Executive Oda";
                        gunlukFiyat = 145;
                    }
                    else if (radioButtonSuperior.Checked)
                    {
                        odaTipi = "Superior Oda";
                        gunlukFiyat = 155;
                    }
                    else if (radioButtonPresidentiel.Checked)
                    {
                        odaTipi = "Presidentiel Oda";
                        gunlukFiyat = 165;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen bir oda tipi seçin!");
                        return;
                    }

                    // Toplam fiyatı hesapla
                    decimal toplamTutar = gunSayisi * gunlukFiyat;
                    TextBoxUcret.Text = toplamTutar.ToString("0.00");

                    // Giriş yapan kullanıcı adını al
                    string kullaniciAdi = FormAnaSayfa.KullaniciAdi;

                    // Veritabanına kayıt ekle
                    string sql = "INSERT INTO rezervasyonlar (ad, soyad, email, tcno, telefon, giris_tarihi, cikis_tarihi, oda_tipi, gun_sayisi, toplam_tutar, kullanici_adi) " +
                                 "VALUES (@ad, @soyad, @email, @tcno, @telefon, @giris_tarihi, @cikis_tarihi, @oda_tipi, @gun_sayisi, @toplam_tutar, @kullanici_adi)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ad", ad);
                    cmd.Parameters.AddWithValue("@soyad", soyad);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@tcno", tcno);
                    cmd.Parameters.AddWithValue("@telefon", telefon);
                    cmd.Parameters.AddWithValue("@giris_tarihi", girisTarihi);
                    cmd.Parameters.AddWithValue("@cikis_tarihi", cikisTarihi);
                    cmd.Parameters.AddWithValue("@oda_tipi", odaTipi);
                    cmd.Parameters.AddWithValue("@gun_sayisi", gunSayisi);
                    cmd.Parameters.AddWithValue("@toplam_tutar", toplamTutar);
                    cmd.Parameters.AddWithValue("@kullanici_adi", kullaniciAdi);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Rezervasyon başarıyla yapıldı!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
