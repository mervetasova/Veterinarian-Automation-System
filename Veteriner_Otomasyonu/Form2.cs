using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Veteriner_Otomasyonu
{
    public partial class FrmMenu : Form
    {
        LogManager log = new LogManager();

        
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSecimKayit_Click(object sender, EventArgs e)
        {
            FrmKayit kayit_formu = new FrmKayit();

            this.Hide();

            kayit_formu.Show();
        }

        private void btnSecimTakip_Click(object sender, EventArgs e)
        {
            FrmStokTakip frmStok = new FrmStokTakip();

            this.Hide();

            frmStok.Show();
        }

        private void btnSecimRandevu_Click(object sender, EventArgs e)
        {
            FrmRandevu frmRandevu = new FrmRandevu();

            this.Hide();

            frmRandevu.Show();
        }

        private void btnSecimGecmis_Click(object sender, EventArgs e)
        {
            FrmSatis frmSatıs = new FrmSatis();

            this.Hide();

            frmSatıs.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            lblKarsilama.Text = "Hoşgeldiniz, " + FrmKullaniciGiris.kullaniciAdi + "!";
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult secenek = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "Çıkış Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secenek == DialogResult.Yes)
            {
                FrmKullaniciGiris frmKullaniciGiris = new FrmKullaniciGiris();
                log.LogYaz(FrmKullaniciGiris.kullaniciAdi, "Çıkış", "Kullanıcı çıkış yaptı.");
                this.Close();
                frmKullaniciGiris.Show();
            }
        }

        private void FrmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
