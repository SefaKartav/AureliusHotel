using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemeiconfalan
{
    public partial class FormAnaSayfa : Form
    {
        public static string KullaniciAdi; // <<<<<< Bunu ekledik
        public static string KullaniciEmail;


        public FormAnaSayfa()
        {
            InitializeComponent();
        }


        private void ButtonRezervasyonYapYonlendir_Click_1(object sender, EventArgs e)
        {
            RezervasyonYap formRezervasyon = new RezervasyonYap();
            formRezervasyon.Show();
            this.Hide();
        }

        private void ButtonKullaniciBilgileri_Click_1(object sender, EventArgs e)
        {
            KullaniciBilgileri formKullaniciBilgileri = new KullaniciBilgileri();
            formKullaniciBilgileri.Show();
            this.Hide();
        }

        private void ButtonRezervasonIslemleriYonlendir_Click_1(object sender, EventArgs e)
        {
            RezervasonIslemleri formRezervasyonIslemleri = new RezervasonIslemleri();
            formRezervasyonIslemleri.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormAnaSayfa_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
