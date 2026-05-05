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
    public partial class FrmRandevu : Form
    {
        LogManager log = new LogManager();
        Baglanti bag = new Baglanti();

        public void Temizle()
        {
            dtpRandevu.Value = DateTime.Now;
            cmbRapor.SelectedIndex = -1;
            txtSecHasta.Clear();
        }

        public void RandevuListele()
        {
            try
            {
                using (SqlConnection connection = bag.baglanti())
                {
                    string soru = "SELECT R.randevuID, H.hayvanAd, H.hayvanID, R.randevu_Tarih, R.yapilacak_Islem " +
                        "FROM randevu_Takvimi R INNER JOIN Hayvanlar H ON R.hayvanID = H.hayvanID";
                    SqlDataAdapter sqlData = new SqlDataAdapter(soru, connection);
                    DataTable dataTable = new DataTable();
                    sqlData.Fill(dataTable);
                    dgvRandevu.DataSource = dataTable;
                    if (dgvRandevu.Columns.Contains("randevuID"))
                    {
                        dgvRandevu.Columns["randevuID"].HeaderText = "Randevu ID";
                        dgvRandevu.Columns["randevuID"].DisplayIndex = 0;
                        dgvRandevu.Columns["randevuID"].Visible = true;
                    }
                }
            }
            catch
            {

            }
        }

        public FrmRandevu()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnRandevuGeri_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            this.Hide();

            frmMenu.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                DataGridViewRow row = dgvRandevu.Rows[e.RowIndex];
                txtSecHasta.Text = row.Cells["hayvanID"].Value.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sorgu = "SELECT H.hayvanID, H.hayvanAd, R.randevu_Tarih, R.yapilacak_Islem " +
                     "FROM Hayvanlar H LEFT JOIN randevu_Takvimi R ON H.hayvanID = R.hayvanID" +
                     " WHERE H.hayvanAd LIKE @hayvanAd OR R.yapilacak_Islem LIKE @yapilacak_Islem";
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, bag.baglanti());
                adapter.SelectCommand.Parameters.AddWithValue("@hayvanAd", "%" + textBox1.Text + "%");
                adapter.SelectCommand.Parameters.AddWithValue("@yapilacak_Islem", "%" + textBox1.Text + "%");
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvRandevu.DataSource = dataTable;
                bag.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt getirilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecHasta.Text))
            {
                MessageBox.Show("Lütfen randevu eklemek istediğiniz hayvanı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbRapor.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen yapılacak işlemi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpRandevu.Value < DateTime.Now)
            {
                MessageBox.Show("Randevu tarihi bugünden önce olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                using (SqlConnection connection = bag.baglanti())
                {
                    string sorgu = "INSERT INTO randevu_Takvimi (hayvanID, urunID, randevu_Tarih, yapilacak_Islem) " +
                        "VALUES (@hayvanID, @urunID, @randevu_Tarih, @yapilacak_Islem)";//Randevu ekleme sorgusu
                    SqlCommand command = new SqlCommand(sorgu, connection);
                    command.Parameters.AddWithValue("@hayvanID", Convert.ToInt32(txtSecHasta.Text));
                    command.Parameters.AddWithValue("@randevu_Tarih", dtpRandevu.Value);
                    command.Parameters.AddWithValue("@yapilacak_Islem", cmbRapor.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@urunID", DBNull.Value);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.LogYaz("Admin", "Randevu Eklendi", $"Hayvan ID: {txtSecHasta.Text}, Randevu ekleme");
                    RandevuListele();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.LogYaz("Admin", "Ekleme Hatası", $"Randevu ekleme sırasında hata: {ex.Message}");
            }
        }

        private void btnRandevuGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecHasta.Text))//Randevu eklemek istediğiniz hayvanı seçiniz.
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz randevuyu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try//Randevu güncelleme işlemi
            {
                using (SqlConnection connection = bag.baglanti())//Veritabanı bağlantısı açılır
                {
                    string sorgu = "UPDATE randevu_Takvimi SET randevu_Tarih = @randevu_Tarih, yapilacak_Islem = @yapilacak_Islem " +
                        "WHERE hayvanID = @hayvanID";//Randevu güncelleme sorgusu
                    SqlCommand command = new SqlCommand(sorgu, connection);

                    if (!int.TryParse(txtSecHasta.Text, out int hayvanID))
                    {
                        MessageBox.Show("Geçersiz randevu ID.");
                        return;
                    }

                    command.Parameters.AddWithValue("@hayvanID", (txtSecHasta.Text));
                    command.Parameters.AddWithValue("@randevu_Tarih", dtpRandevu.Value);
                    command.Parameters.AddWithValue("@yapilacak_Islem", cmbRapor.SelectedItem.ToString());
                    command.ExecuteNonQuery();
                    MessageBox.Show("Randevu başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.LogYaz("Admin", "Randevu Güncellendi", $"Hayvan ID: {txtSecHasta.Text}");
                    RandevuListele();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.LogYaz("Admin", "Güncelleme Hatası", $"Randevu güncelleme sırasında hata: {ex.Message}");
            }
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSecHasta.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz randevuyu seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                using (SqlConnection connection = bag.baglanti())
                {
                    string sil = "DELETE FROM randevu_Takvimi WHERE hayvanID = @hayvanID";
                    SqlCommand command = new SqlCommand(sil, connection);
                    if (!int.TryParse(txtSecHasta.Text, out int hayvanID))
                    {
                        MessageBox.Show("Geçersiz randevu ID.");
                        return;
                    }
                    command.Parameters.AddWithValue("@hayvanID", hayvanID);
                    int sonuc = command.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Randevu başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        log.LogYaz("Admin", "Randevu Silindi", $"Hayvan ID: {txtSecHasta.Text}");
                    }
                    else
                    {
                        MessageBox.Show("Randevu bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        log.LogYaz("Admin", "Randevu Silme Hatası", $"Randevu silme sırasında hata: Randevu bulunamadı, Hayvan ID: {txtSecHasta.Text}");
                    }
                    RandevuListele();
                    Temizle();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                log.LogYaz("Admin", "Randevu Silme Hatası", $"Randevu silme sırasında hata: {ex.Message}, Hayvan ID: {txtSecHasta.Text}");
            }
        }
    }
}
