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
    public partial class FrmSatis : Form
    {
        LogManager log = new LogManager();

        private void KazancHesapla()
        {
            try
            {
                using (SqlConnection connection = bag.baglanti())
                {
                    if (connection.State == ConnectionState.Closed) connection.Open();

                    // Günlük, Aylık ve Yıllık kazançları tek seferde çeken sorgu
                    string sorgu = @" SELECT 
                    SUM(CASE WHEN CAST(islemTarihi AS DATE) = CAST(GETDATE() AS DATE) THEN satisFiyati ELSE 0 END) as Gunluk,
                    SUM(CASE WHEN MONTH(islemTarihi) = MONTH(GETDATE()) AND YEAR(islemTarihi) = YEAR(GETDATE()) THEN satisFiyati ELSE 0 END) as Aylik,
                    SUM(CASE WHEN YEAR(islemTarihi) = YEAR(GETDATE()) THEN satisFiyati ELSE 0 END) as Yillik
                FROM islem_Gecmisi";

                    using (SqlCommand cmd = new SqlCommand(sorgu, connection))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            // DBNull kontrolü yaparak kazançları formatlayarak göster
                            txtGunlukKazanc.Text = dr["Gunluk"] != DBNull.Value ? string.Format("{0:C2}", dr["Gunluk"]) : "0,00 ₺";
                            txtAylikKazanc.Text = dr["Aylik"] != DBNull.Value ? string.Format("{0:C2}", dr["Aylik"]) : "0,00 ₺";
                            txtYillikKazanc.Text = dr["Yillik"] != DBNull.Value ? string.Format("{0:C2}", dr["Yillik"]) : "0,00 ₺";
                        }
                        dr.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda boş bırakalım
                txtGunlukKazanc.Text = "0,00 ₺";
                log.LogYaz("Admin", "KazancHesapla", "Hata: " + ex.Message);
            }
        }

        Baglanti bag = new Baglanti();
        DataTable dt = new DataTable();

        public void UrunListele()
        {
            // Varolan DataTable'ı temizleyip yeniden doldur (tekrar eden kayıtları önlemek için)
            using (SqlDataAdapter da = new SqlDataAdapter("SELECT miktar, urunAD, urunUcret, skt, urunID" +
                " FROM stok_Takibi", bag.baglanti()))
            {
                dt.Clear();
                da.Fill(dt);
                dgvUrun.DataSource = dt;
            }
        }

        public void Listele()
        {
            try
            {
                // LEFT JOIN kullanarak eksik ilişkilere rağmen tüm randevu kayıtlarını göster
                string sorgu = @"SELECT 
            R.randevuID, 
            R.yapilacak_Islem,  
            R.randevu_Tarih, 
            H.hayvanAD 
            FROM randevu_Takvimi R 
            LEFT JOIN Hayvanlar H ON R.hayvanID = H.hayvanID 
            LEFT JOIN stok_Takibi T ON R.urunID = T.urunID";

                using (SqlConnection connection = bag.baglanti())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(sorgu, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvIslem.DataSource = dataTable;
                    dgvIslem.AutoGenerateColumns = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listele işlemi sırasında bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Temizle()
        {
            textBox1.Clear();
            dtpIslemTarih.Value = DateTime.Now;
            nudIslemUcret.Value = 0;
        }

        public FrmSatis()
        {
            InitializeComponent();
        }

        private void btnSatısGeri_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            this.Hide();

            frmMenu.Show();
        }

        private void FrmSatıs_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde tüm ürün/satış bilgilerini listele
            try
            {
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listele yüklenirken hata: " + ex.Message);
            }

            try
            {
                UrunListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("UrunListele yüklenirken hata: " + ex.Message);
            }
            KazancHesapla();
        }

        private void dgvIslem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvIslem.Rows.Count)
                {
                    DataGridViewRow row = dgvIslem.Rows[e.RowIndex];

                    if (row.Cells.Contains(row.Cells["yapilacak_Islem"]))
                    {
                        txtIslemAd.Text = row.Cells["yapilacak_Islem"].Value?.ToString() ?? string.Empty;
                    }
                    if (row.Cells.Contains(row.Cells["randevu_Tarih"]))
                    {
                        dtpIslemTarih.Value = Convert.ToDateTime(row.Cells["randevu_Tarih"].Value ?? DateTime.Now);
                    }

                }
                else
                {
                    MessageBox.Show("Geçersiz satır seçimi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satır seçimi sırasında hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvUrun_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.RowIndex < dgvUrun.Rows.Count)
                {
                    DataGridViewRow row = dgvUrun.Rows[e.RowIndex];

                    // Ürün grid'inden seçili satırı form alanlarına doldur
                    if (row.Cells.Contains(row.Cells["urunID"]))
                    {
                        txtUrunId.Text = row.Cells["urunID"].Value?.ToString() ?? string.Empty;
                    }

                    if (dgvUrun.Columns.Contains("urunAD"))
                    {
                        txtUrunAd.Text = row.Cells["urunAD"].Value?.ToString() ?? string.Empty;
                    }

                    if (dgvUrun.Columns.Contains("urunUcret"))
                    {
                        txtUrunUcret.Text = Convert.ToInt32(row.Cells["urunUcret"].Value ?? 0).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün seçiminde hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = textBox1.Text.Trim();
                if (string.IsNullOrEmpty(search))
                {
                    Listele();
                    return;
                }

                string soru = "SELECT R.randevuID, R.yapilacak_Islem, R.randevu_Tarih, H.hayvanAD " +
                   "FROM randevu_Takvimi R LEFT JOIN Hayvanlar H ON R.hayvanID = H.hayvanID  " +
                   "WHERE R.yapilacak_Islem LIKE @search OR H.hayvanAD LIKE @search";

                using (SqlConnection conn = bag.baglanti())
                using (SqlDataAdapter adapter = new SqlDataAdapter(soru, conn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgvIslem.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama sırasında bir hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string search = textBox2.Text.Trim();
                if (string.IsNullOrEmpty(search))
                {
                    UrunListele();
                    return;
                }

                string sorgu = "SELECT T.urunAD, T.urunID, T.urunUcret " +
                    "FROM stok_Takibi T " +
                    "WHERE T.urunAD LIKE @search";

                using (SqlConnection connection = bag.baglanti())
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(sorgu, connection))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvUrun.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün araması sırasında hata oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnUrunSat_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = bag.baglanti())
                {
                    string stokDusSorgu = "UPDATE stok_Takibi SET miktar = miktar - @alinan WHERE urunID = @urunID AND miktar > 0";

                    string ekleSorgu = "INSERT INTO islem_Gecmisi (urunID, satisFiyati, islemTarihi) VALUES (@urunID, @satisFiyati, @islemTarihi)";

                    using (SqlCommand cmdStok = new SqlCommand(stokDusSorgu, connection))
                    {
                        cmdStok.Parameters.AddWithValue("@urunID", txtUrunId.Text);
                        cmdStok.Parameters.AddWithValue("@alinan", (int)nudAlincakUrunMiktar.Value);
                        int rowsAffected = cmdStok.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            using (SqlCommand cmdEkle = new SqlCommand(ekleSorgu, connection))
                            {

                                cmdEkle.Parameters.AddWithValue("@urunID", txtUrunId.Text);
                                cmdEkle.Parameters.AddWithValue("@satisFiyati", Convert.ToDecimal(txtUrunUcret.Text)*nudAlincakUrunMiktar.Value);
                                cmdEkle.Parameters.AddWithValue("@islemTarihi", dtpNow.Value);
                                cmdEkle.ExecuteNonQuery();
                            }
                            MessageBox.Show("Ürün satıldı ve stoktan düşüldü.", "Başarılı");
                            log.LogYaz("Admin", "Ürün Satışı", $"Ürün Satıldı");
                            UrunListele();
                            KazancHesapla();
                        }
                        else
                        {
                            MessageBox.Show("Stokta yeterli ürün yok veya ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            log.LogYaz("Admin", "Ürün Satışı", $"Stokta yeterli ürün yok veya ürün bulunamadı. UrunID: {txtUrunId.Text}");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Satış işlemi sırasında bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.LogYaz("Admin", "Ürün Satışı", $"Satış işlemi sırasında bir hata oluştu. UrunID: {txtUrunId.Text}");
            }
        }

        private void btnSatisEkle_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIslemAd.Text) || string.IsNullOrWhiteSpace(txtIslemAd.Text))
            {
                MessageBox.Show("Lütfen bir işlem adı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (nudIslemUcret.Value <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir işlem ücreti girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpIslemTarih.Value > DateTime.Now)
            {
                MessageBox.Show("İşlem tarihi bugünden ileri olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection connection = bag.baglanti())
                {
                     string ekleSorgu = "INSERT INTO islem_Gecmisi (islemTarihi, islemAdi, islemFiyati ) VALUES (@islemTarihi, @islemAdi, @islemFiyati)";

                     using (SqlCommand cmdEkle = new SqlCommand(ekleSorgu, connection))
                     {
                          cmdEkle.Parameters.AddWithValue("@islemTarihi", dtpNow.Value);
                          cmdEkle.Parameters.AddWithValue("@islemAdi", txtIslemAd.Text);
                          cmdEkle.Parameters.AddWithValue("@islemFiyati", nudIslemUcret.Value);
                          cmdEkle.ExecuteNonQuery();
                     }


                     MessageBox.Show("Satış kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.LogYaz("Admin", "Satış Ekleme", $"Yeni satış eklendi: {txtIslemAd.Text} - {nudIslemUcret.Value:C2}");
                     Listele();
                     UrunListele();
                     Temizle();
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("İşlem sırasında hata: " + ex.Message);
                log.LogYaz("Admin", "Satış Ekleme", $"Hata: {ex.Message}");
            }
        }
    }
}
