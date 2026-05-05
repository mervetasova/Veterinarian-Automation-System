using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veteriner_Otomasyonu
{
    public partial class FrmKullaniciGiris : Form
    {
        LogManager log = new LogManager();

        public static string kullaniciAdi;
        public FrmKullaniciGiris()
        {
            InitializeComponent();
        }
        Baglanti bag = new Baglanti();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select*From Kullanicilar Where kullaniciAd=@p1 and kullaniciSifre=@p2", bag.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKullaniciSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            try
            {
                if (dr.Read()) // Eğer veritabanında bu bilgilerle eşleşen bir satır varsa
                {
                    kullaniciAdi = txtKullaniciAd.Text;
                    // Giriş başarılı! Ana Menü formuna geçiş yapıyoruz.
                    // Buradaki 'FormAnaMenu' kısmını kendi ana formunun adıyla değiştir.
                    FrmMenu frmMenu = new FrmMenu();
                    log.LogYaz(kullaniciAdi, "Başarılı giriş: " + kullaniciAdi, "Başarılı Giriş");
                    this.Hide();
                    frmMenu.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış, lütfen tekrar deneyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    log.LogYaz("Bilinmeyen", "Başarısız giriş denemesi: " + txtKullaniciAd.Text, "Başarısız Giriş");
                }
                bag.baglanti().Close();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlanırken hata oluştu. Lütfen bağlantı ayarlarınızı kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.LogYaz("Bilinmeyen", "Veritabanı bağlantı hatası: " + txtKullaniciAd.Text, "Hata");
            }
        }

        private void FrmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmKullaniciGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
