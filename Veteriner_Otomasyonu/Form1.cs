using System.Data;
using System.Data.SqlClient;

namespace Veteriner_Otomasyonu
{
    public partial class FrmKayit : Form
    {
        LogManager log = new LogManager();

        void Listele() // Bu metot, sahip adı-soyadı ile hayvan bilgilerini birleştirerek DataGridView'e listeleme işlemi yapacak
        {
            try
            {
                // SQL Sorgusu: Sahip ID'si ile birlikte sahip adı-soyadı ve hayvan bilgilerini alıyoruz
                // sütunlara alias vererek DataGridView'de isimlerle erişmeyi garanti ediyoruz
                string sorgu = "SELECT H.hayvanID AS hayvanID, S.sahipID AS sahipID, " +
                               "(S.ad + ' ' + S.soyad) AS Sahip, S.telefon, S.e_posta, " +
                               "H.hayvanAd, H.tur, H.cins, H.cinsiyet, H.dogum_Tarihi " +
                               "FROM Hayvanlar H INNER JOIN Sahip S ON H.sahipID = S.sahipID";

                SqlDataAdapter da = new SqlDataAdapter(sorgu, bag.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvKayit.DataSource = dt;

                // Artık sütun isimlerini elle değiştirmeye gerek yok çünkü sorguda alias kullandık.
                // Eğer isterseniz hayvanID veya sahipID sütunlarını görünmez yapabilirsiniz:
                // dgvKayit.Columns["sahipID"].Visible = false;
                // dgvKayit.Columns["hayvanID"].Visible = false;

                bag.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message);
            }
        }

        void HayvanKutulariniTemizle()
        {
            // Hayvan bilgilerini içeren textBox'ları temizleyelim
            txtHayvanAd.Clear();
            txtTur.Clear();
            txtCins.Clear();
            cbCinsiyet.SelectedIndex = -1; // ComboBox'ı boşa çek
            dtpDogum.Value = DateTime.Now; // Eğer tarih için DateTimePicker kullanıyorsan:
        }

        void SahipKutulariniTemizle()
        {
            // Sahip bilgilerini içeren textBox'ları temizleyelim
            txtAd.Clear();
            txtSoyad.Clear();
            txtNo.Clear();
            txtPosta.Clear();
        }

        Baglanti bag = new Baglanti();

        DataTable dt = new DataTable();
        //SqlConnection baglant = new SqlConnection("Data Source=.;Initial Catalog=VETERİNER_OTOMASYONU;Integrated Security=True");
        public FrmKayit()
        {
            InitializeComponent();
        }

        private void btnKayitGeri_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            this.Hide();

            frmMenu.Show();
        }

        private void btnSahipKayitGuncelle_Click(object sender, EventArgs e)
        {// Sahip ve hayvan bilgilerini aynı anda eklemek için iki ayrı SQL komutu kullanarak işlemi gerçekleştirelim
            // Aynı kişiye birden fazla kayıt eklememek için önce mevcut sahibi kontrol et
            using (SqlConnection con = bag.baglanti())
            {
                if (con.State == ConnectionState.Closed) con.Open();
                using (SqlTransaction tran = con.BeginTransaction())
                {
                    try
                    {
                        // Öncelikle telefon veya e_posta ile mevcut sahip sorgulanabilir.
                        // Uygulamanıza göre kontrole ad+soyad da eklenebilir.
                        string kontrol = "SELECT TOP 1 sahipID FROM Sahip WHERE telefon = @telefon OR e_posta = @e_posta";
                        int yeniSahipID;
                        using (SqlCommand cmdKontrol = new SqlCommand(kontrol, con, tran))
                        {
                            cmdKontrol.Parameters.AddWithValue("@telefon", txtNo.Text.Trim());
                            cmdKontrol.Parameters.AddWithValue("@e_posta", txtPosta.Text.Trim());
                            object exist = cmdKontrol.ExecuteScalar();
                            if (exist != null && exist != DBNull.Value)
                            {
                                // Mevcut sahibi kullan
                                yeniSahipID = Convert.ToInt32(exist);
                            }
                            else
                            {
                                // Yeni sahip ekle
                                string ekle = "INSERT INTO Sahip (ad, soyad, telefon, e_posta) VALUES (@ad, @soyad, @telefon,@e_posta); SELECT SCOPE_IDENTITY();";
                                using (SqlCommand cmdSahip = new SqlCommand(ekle, con, tran))
                                {
                                    cmdSahip.Parameters.AddWithValue("@ad", txtAd.Text.Trim());
                                    cmdSahip.Parameters.AddWithValue("@soyad", txtSoyad.Text.Trim());
                                    cmdSahip.Parameters.AddWithValue("@telefon", txtNo.Text.Trim());
                                    cmdSahip.Parameters.AddWithValue("@e_posta", txtPosta.Text.Trim());
                                    yeniSahipID = Convert.ToInt32(cmdSahip.ExecuteScalar());
                                }
                            }
                        }

                        // Hayvan kaydını ekle
                        string hayvanEkle = "INSERT INTO Hayvanlar (sahipID, hayvanAd, tur, cins, cinsiyet, dogum_Tarihi) VALUES (@sahipID, @hayvanAd, @tur, @cins, @cinsiyet, @dogum_Tarihi)";
                        using (SqlCommand cmdHayvan = new SqlCommand(hayvanEkle, con, tran))
                        {
                            cmdHayvan.Parameters.AddWithValue("@sahipID", yeniSahipID);
                            cmdHayvan.Parameters.AddWithValue("@hayvanAd", txtHayvanAd.Text.Trim());
                            cmdHayvan.Parameters.AddWithValue("@tur", txtTur.Text.Trim());
                            cmdHayvan.Parameters.AddWithValue("@cins", txtCins.Text.Trim());
                            cmdHayvan.Parameters.AddWithValue("@cinsiyet", cbCinsiyet.Text);
                            cmdHayvan.Parameters.AddWithValue("@dogum_Tarihi", dtpDogum.Value);
                            cmdHayvan.ExecuteNonQuery();
                        }

                        tran.Commit();
                        MessageBox.Show("Kayıt Başarılı", "Kayıt", MessageBoxButtons.OK);
                        log.LogYaz("Admin", $"SahipID: {yeniSahipID}, HayvanAd: {txtHayvanAd.Text}", "Yeni sahip ve hayvan kaydı eklendi");
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Kayıt sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.LogYaz("Admin", $"Hata: {ex.Message}", "Kayıt eklenirken hata oluştu");
                    }
                }
            }
            
            HayvanKutulariniTemizle();
            SahipKutulariniTemizle();
            textBox1.Clear();
        }

        private void dgvKayit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Hücre tıklandığında, tıklanan satırın bilgilerini textBox'lara doldur
            if (e.RowIndex >= 0)
            {
                // Öncelikle DataBoundItem üzerinden DataRowView kullanarak doğrudan kaynak veriye erişmeyi deneyelim.
                // Bu, DataGridView'deki kolon isimleri/aliaslar arasındaki uyumsuzluklardan kaynaklanan sorunları önler.
                DataGridViewRow satir = dgvKayit.Rows[e.RowIndex];
                var drv = satir.DataBoundItem as DataRowView;
                if (drv != null)
                {
                    // SahipID
                    if (drv.Row.Table.Columns.Contains("sahipID"))
                    {
                        var valSahip = drv["sahipID"];
                        textBox1.Text = (valSahip == null || valSahip == DBNull.Value) ? string.Empty : valSahip.ToString();
                    }
                    else
                    {
                        textBox1.Text = string.Empty;
                    }

                    // HayvanID
                    if (drv.Row.Table.Columns.Contains("hayvanID"))
                    {
                        var valHayvan = drv["hayvanID"];
                        if (valHayvan == null || valHayvan == DBNull.Value)
                        {
                            lblHayvanID.Text = string.Empty;
                        }
                        else
                        {
                            var s = valHayvan.ToString();
                            if (int.TryParse(s, out int hid)) lblHayvanID.Text = hid.ToString();
                            else lblHayvanID.Text = s;
                        }
                    }
                    else
                    {
                        lblHayvanID.Text = string.Empty;
                    }
                }
                else
                {
                    // Eğer DataBoundItem yoksa (ör. manuel kolonlar kullanılıyorsa), hücre üzerinden güvenli erişim yap
                    if (dgvKayit.Columns.Contains("sahipID"))
                    {
                        var valSahip = satir.Cells["sahipID"].Value;
                        textBox1.Text = (valSahip == null || valSahip == DBNull.Value) ? string.Empty : valSahip.ToString();
                    }
                    else textBox1.Text = string.Empty;

                    if (dgvKayit.Columns.Contains("hayvanID"))
                    {
                        var valHayvan = satir.Cells["hayvanID"].Value;
                        if (valHayvan == null || valHayvan == DBNull.Value) lblHayvanID.Text = string.Empty;
                        else
                        {
                            var s = valHayvan.ToString();
                            if (int.TryParse(s, out int hid)) lblHayvanID.Text = hid.ToString();
                            else lblHayvanID.Text = s;
                        }
                    }
                    else lblHayvanID.Text = string.Empty;
                }
            }
        }

        private void btnSahipKayitSil_Click(object sender, EventArgs e)
        {// Silme işlemi yaparken, textBox1'deki sahipID'yi kullanarak ilgili kaydı silmeye çalışalım

            // Öncelikle, textBox1'in boş olup olmadığını kontrol edelim
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz kaydı tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult onay = MessageBox.Show("Bu kayıdı silmek istediğinizden emin misiniz", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                using (SqlConnection con = bag.baglanti())
                {
                    try// Silme işlemi için SQL komutunu hazırlayalım ve parametre ekleyelim
                    {
                        string sil = "DELETE FROM Sahip WHERE sahipID = @sahipID";// SahipID'ye göre silme işlemi yapacağız
                        SqlCommand cmd = new SqlCommand(sil, con);
                        cmd.Parameters.AddWithValue("@sahipID", textBox1.Text);
                        cmd.ExecuteNonQuery();// İşlem başarılıysa, kullanıcıya bilgi verelim ve bağlantıyı kapatalım
                        MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)// Silme işlemi sırasında bir hata oluşursa, kullanıcıya hata mesajını gösterelim
                    {
                        MessageBox.Show("Kayıt silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        log.LogYaz("Admin", $"Hata: {ex.Message}", "Kayıt silinirken hata oluştu");
                    }
                }
            }
        }

        private void btnHayvanKayitEkle_Click(object sender, EventArgs e)
        {
            try// Hayvan eklerken, textBox1'deki sahipID'yi kullanarak hayvan kaydını eklemeye çalışalım
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("Lütfen hayvan eklemek istediğiniz sahibin kaydını tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                SqlCommand command = new SqlCommand("INSERT INTO Hayvanlar (sahipID, hayvanAd, tur, cins, cinsiyet, dogum_Tarihi)" +
                    " VALUES (@sahipID, @hayvanAd, @tur, @cins, @cinsiyet, @dogum_Tarihi)", bag.baglanti());
                command.Parameters.AddWithValue("@sahipID", Convert.ToInt32(textBox1.Text));
                command.Parameters.AddWithValue("@hayvanAd", txtHayvanAd.Text);
                command.Parameters.AddWithValue("@tur", txtTur.Text);
                command.Parameters.AddWithValue("@cins", txtCins.Text);
                command.Parameters.AddWithValue("@cinsiyet", cbCinsiyet.Text);
                command.Parameters.AddWithValue("@dogum_Tarihi", dtpDogum.Value);

                command.ExecuteNonQuery();
                bag.baglanti().Close();
                MessageBox.Show("Hayvan kaydı başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                log.LogYaz("Admin", $"SahipID: {textBox1.Text}, HayvanAd: {txtHayvanAd.Text}", "Yeni hayvan kaydı eklendi");
                Listele();
                HayvanKutulariniTemizle();
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hayvan eklenirken hata oluştu: " + ex.Message);
                log.LogYaz("Admin", $"Hata: {ex.Message}", "Hayvan kaydı eklenirken hata oluştu");
            }
        }

        private void btnHayvanKayitSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lblHayvanID.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz hayvan kaydını tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult onay = MessageBox.Show("Bu hayvan kaydını silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {

                using (SqlConnection con = bag.baglanti())
                {
                    try
                    {
                        if (con.State == ConnectionState.Closed) con.Open();
                        string sil = "DELETE FROM Hayvanlar WHERE hayvanID = @hayvanID";
                        SqlCommand cmd = new SqlCommand(sil, con);
                        cmd.Parameters.AddWithValue("@hayvanID", Convert.ToInt32(lblHayvanID.Text));
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Kayıt başalı bir şekilde silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        log.LogYaz("Admin", $"HayvanID: {lblHayvanID.Text}", "Hayvan kaydı silindi");
                        Listele();
                        textBox1.Clear();
                        lblHayvanID.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hayvan silinirken hata oluştu: " + ex.Message);
                        log.LogYaz("Admin", $"Hata: {ex.Message}", "Hayvan kaydı silinirken hata oluştu");
                        return;
                        
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string soru = "SELECT S.sahipID, S.ad, S.soyad, S.telefon, S.e_posta, H.hayvanID, H.hayvanAd, H.tur, H.cins, H.cinsiyet, H.dogum_Tarihi " +
                       "FROM Sahip S LEFT JOIN Hayvanlar H ON S.sahipID = H.sahipID " +
                       "WHERE S.ad LIKE @ad OR S.soyad LIKE @soyad";
                SqlDataAdapter da = new SqlDataAdapter(soru, bag.baglanti());
                da.SelectCommand.Parameters.AddWithValue("@ad", "%" + textBox1.Text + "%");
                da.SelectCommand.Parameters.AddWithValue("@soyad", "%" + textBox1.Text + "%");
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dgvKayit.DataSource = dataTable;
                bag.baglanti().Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıtlar getirilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmKayit_Load(object sender, EventArgs e)
        {

        }
    }
}