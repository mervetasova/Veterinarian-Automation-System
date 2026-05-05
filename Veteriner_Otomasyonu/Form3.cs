using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veteriner_Otomasyonu
{
    public partial class FrmStokTakip : Form
    {
        LogManager log = new LogManager();

        int newUrunID = 0;
        Baglanti bag = new Baglanti();
        DataTable dt = new DataTable();

        public void UrunListele()
        {
            // Varolan DataTable'ı temizleyip yeniden doldur (tekrar eden kayıtları önlemek için)
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM stok_Takibi", bag.baglanti());
            dt.Clear();
            da.Fill(dt);
            dgvStok.DataSource = dt;
        }

        public void KutularıTemizle()
        {
            txtUrunAd.Clear();
            cmbKategori.SelectedIndex = -1;
            nudMiktar.Value = 0;
            dtpSkt.Value = DateTime.Now;
        }

        public FrmStokTakip()
        {
            InitializeComponent();
        }

        private void btnTakipGeri_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            this.Hide();

            frmMenu.Show();
        }

        private void FrmStokTakip_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde listeyi getir
            try
            {
                UrunListele();
            }
            catch
            {
                MessageBox.Show("Veriler getirilirken bir hata oluştu. Lütfen bağlantınızı kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnTakipEkle_Click(object sender, EventArgs e)
        {
            try
            {
                // Yeni ürün ekleme: bağlantıyı using ile açıp kapat, parametreleri güvenli şekilde ekle
                string urunEkle = "INSERT INTO stok_Takibi (urunAD, kategori, miktar, skt, urunUcret) Values (@urunAD, @kategori, @miktar, @skt, @urunUcret); SELECT SCOPE_IDENTITY();";
                using (SqlConnection connection = bag.baglanti())
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    using (SqlCommand command = new SqlCommand(urunEkle, connection))
                    {
                        command.Parameters.AddWithValue("@urunAD", txtUrunAd.Text.Trim());
                        command.Parameters.AddWithValue("@kategori", cmbKategori.Text.Trim());
                        command.Parameters.AddWithValue("@miktar", Convert.ToInt32(nudMiktar.Value));
                        command.Parameters.AddWithValue("@skt", dtpSkt.Value);
                        command.Parameters.AddWithValue("@urunUcret", nudUrunUcret.Value);
                        var result = command.ExecuteScalar();
                        if (result != null && result != DBNull.Value && int.TryParse(result.ToString(), out int newUrunId))
                        {
                            newUrunID = newUrunId;
                            MessageBox.Show("Ürün başarıyla eklendi. Yeni ürün ID'si: " + newUrunID);
                            log.LogYaz("Admin", $"Yeni ürün eklendi: {txtUrunAd.Text} (ID: {newUrunID})", "Ürün Ekleme");
                        }
                        else
                        {
                            MessageBox.Show("Ürün eklenirken beklenmeyen bir sonuç döndü.");
                            log.LogYaz("Admin", $"Ürün eklenirken beklenmeyen bir sonuç döndü: {txtUrunAd.Text}", "Ürün Ekleme");
                        }
                    }
                }

                // Listeyi yenile ve kutuları temizle
                UrunListele();
                KutularıTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün eklenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.LogYaz("Admin", $"Ürün eklenirken hata oluştu: {txtUrunAd.Text} - Hata: {ex.Message}", "Ürün Ekleme");
            }
        }

        private void btnTakipGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Lütfen güncellenecek ürünü seçin.");
                return;
            }
            try
            {
                using (SqlConnection connection = bag.baglanti())
                {// Güncelleme işlemi: bağlantıyı using ile açıp kapat, parametreleri güvenli şekilde ekle
                    if (connection.State == ConnectionState.Closed) connection.Open();
                    string urunGuncelle = "UPDATE stok_Takibi SET urunAD = @urunAD, kategori = @kategori, miktar = @miktar, skt = @skt, urunUcret = @urunUcret WHERE urunID = @urunID";
                    using (SqlCommand command = new SqlCommand(urunGuncelle, connection))
                    {
                        // urunID'yi doğrula
                        if (!int.TryParse(textBox2.Text, out int urunID))
                        {
                            MessageBox.Show("Geçersiz ürün ID.");
                            return;
                        }

                        // Parametreleri formdaki araçlardan alıyoruz
                        command.Parameters.AddWithValue("@urunAD", txtUrunAd.Text);
                        command.Parameters.AddWithValue("@miktar", Convert.ToInt32(nudMiktar.Value));
                        command.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                        command.Parameters.AddWithValue("@skt", dtpSkt.Value);
                        command.Parameters.AddWithValue("@urunUcret", nudUrunUcret.Value);
                        command.Parameters.AddWithValue("@urunID", urunID);

                        int sonuc = command.ExecuteNonQuery();

                        if (sonuc > 0)// Güncelleme başarılıysa
                        {
                            MessageBox.Show("Ürün başarıyla güncellendi.");
                            log.LogYaz("Admin", $"Ürün güncellendi: {txtUrunAd.Text} (ID: {urunID})", "Ürün Güncelleme");
                            UrunListele(); // Tabloyu anında tazele
                            KutularıTemizle(); // Formu temizle
                        }
                        else
                        {
                            MessageBox.Show("Güncellenecek kayıt bulunamadı.");
                            log.LogYaz("Admin", $"Güncellenecek kayıt bulunamadı: {txtUrunAd.Text} (ID: {urunID})", "Ürün Güncelleme");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında hata oluştu: " + ex.Message);
                log.LogYaz("Admin", $"Güncelleme sırasında hata oluştu: {txtUrunAd.Text} - Hata: {ex.Message}", "Ürün Güncelleme");
            }

        }

        private void dgvStok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)//Satır indexi geçerli bir değere sahip mi kontrolü
            {
                DataGridViewRow satir = dgvStok.Rows[e.RowIndex];//Tıklanan satırı al
                // Seçilen satırdaki değerleri formlara doldur
                var valId = satir.Cells["urunID"].Value;
                // textBox2 hem arama hem ID için kullanıldığından, TextChanged olayının tetiklenmesini engelle
                // (aksi halde arama çalışıp DataGridView kaynağını değiştiriyor)
                textBox2.TextChanged -= textBox2_TextChanged;
                textBox2.Text = (valId == null || valId == DBNull.Value) ? string.Empty : valId.ToString();
                textBox2.TextChanged += textBox2_TextChanged;
                // Diğer hücre değerlerini de benzer şekilde alıp formlara doldur
                var valAd = satir.Cells["urunAD"].Value;
                txtUrunAd.Text = (valAd == null || valAd == DBNull.Value) ? string.Empty : valAd.ToString();
                // Kategori, miktar ve skt değerlerini de alıp formlara doldur
                var valKat = satir.Cells["kategori"].Value;
                cmbKategori.Text = (valKat == null || valKat == DBNull.Value) ? string.Empty : valKat.ToString();

                var valMiktar = satir.Cells["miktar"].Value;
                if (valMiktar != null && valMiktar != DBNull.Value && decimal.TryParse(valMiktar.ToString(), out decimal miktar))
                    nudMiktar.Value = miktar;
                else
                    nudMiktar.Value = 0;

                var valSkt = satir.Cells["skt"].Value;
                if (valSkt != null && valSkt != DBNull.Value && DateTime.TryParse(valSkt.ToString(), out DateTime skt))
                    dtpSkt.Value = skt;
                else
                    dtpSkt.Value = DateTime.Now;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT * FROM stok_Takibi WHERE urunAD LIKE @urunAD";
                SqlDataAdapter da = new SqlDataAdapter(sorgu, bag.baglanti());
                da.SelectCommand.Parameters.AddWithValue("@urunAD", "%" + textBox2.Text + "%");
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dgvStok.DataSource = dataTable;
                bag.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnTakipSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))// Silme işlemi için ürün ID'si gereklidir, bu yüzden kontrol ediyoruz
            {
                MessageBox.Show("Lütfen silinecek ürünü seçin.");
                return;
            }
            try // Silme işlemi: bağlantıyı using ile açıp kapat, parametreleri güvenli şekilde ekle
            {
                using (SqlConnection con = bag.baglanti())
                {
                    if (con.State == ConnectionState.Closed) con.Open();
                    string urunSil = "DELETE FROM stok_Takibi WHERE urunID = @urunID";
                    // urunID'ye göre silme işlemi yapacağız, bu yüzden parametre olarak ekliyoruz
                    using (SqlCommand cmd = new SqlCommand(urunSil, con))// urunID'yi doğrula
                    {
                        if (!int.TryParse(textBox2.Text, out int urunID))
                          // textBox2'deki değerin geçerli bir tamsayı olup olmadığını kontrol ediyoruz
                        {
                            MessageBox.Show("Geçersiz ürün ID.");
                            return;
                        }
                        cmd.Parameters.AddWithValue("@urunID", urunID);
                        // Silme işlemi için urunID'yi parametre olarak ekliyoruz
                        int sonuc = cmd.ExecuteNonQuery();
                        if (sonuc > 0)
                        {
                            MessageBox.Show("Ürün başarıyla silindi.");
                            log.LogYaz("Admin", $"Ürün silindi: {txtUrunAd.Text} (ID: {urunID})", "Ürün Silme");
                            UrunListele(); // Tabloyu anında tazele
                            KutularıTemizle(); // Formu temizle
                        }
                        else
                        {
                            MessageBox.Show("Silinecek kayıt bulunamadı.");
                            log.LogYaz("Admin", $"Silinecek kayıt bulunamadı: {txtUrunAd.Text} (ID: {urunID})", "Ürün Silme");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında hata oluştu: " + ex.Message);
                log.LogYaz("Admin", $"Silme işlemi sırasında hata oluştu: {txtUrunAd.Text} - Hata: {ex.Message}", "Ürün Silme");
            }
            
        }
    }
}
