namespace Veteriner_Otomasyonu
{
    partial class FrmStokTakip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUrunAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbKategori = new ComboBox();
            nudMiktar = new NumericUpDown();
            dtpSkt = new DateTimePicker();
            label5 = new Label();
            groupBox1 = new GroupBox();
            nudUrunUcret = new NumericUpDown();
            label6 = new Label();
            btnTakipGuncelle = new Button();
            btnTakipSil = new Button();
            btnTakipEkle = new Button();
            textBox2 = new TextBox();
            dgvStok = new DataGridView();
            btnTakipGeri = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMiktar).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudUrunUcret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStok).BeginInit();
            SuspendLayout();
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(170, 35);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(125, 27);
            txtUrunAd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Kategori:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 3;
            label3.Text = "Miktar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 158);
            label4.Name = "label4";
            label4.Size = new Size(142, 20);
            label4.TabIndex = 4;
            label4.Text = "Son Kullanma Tarihi:";
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Items.AddRange(new object[] { "İlaç", "Mama", "Oyuncak", "Takı", "Aşı" });
            cmbKategori.Location = new Point(170, 76);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(151, 28);
            cmbKategori.TabIndex = 6;
            // 
            // nudMiktar
            // 
            nudMiktar.Location = new Point(170, 116);
            nudMiktar.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudMiktar.Name = "nudMiktar";
            nudMiktar.Size = new Size(150, 27);
            nudMiktar.TabIndex = 7;
            // 
            // dtpSkt
            // 
            dtpSkt.Location = new Point(170, 153);
            dtpSkt.Name = "dtpSkt";
            dtpSkt.Size = new Size(250, 27);
            dtpSkt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.GhostWhite;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(261, 9);
            label5.Name = "label5";
            label5.Size = new Size(294, 38);
            label5.TabIndex = 9;
            label5.Text = "İLAÇ VE STOK TAKİBİ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.GhostWhite;
            groupBox1.Controls.Add(nudUrunUcret);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnTakipGuncelle);
            groupBox1.Controls.Add(btnTakipSil);
            groupBox1.Controls.Add(btnTakipEkle);
            groupBox1.Controls.Add(dtpSkt);
            groupBox1.Controls.Add(nudMiktar);
            groupBox1.Controls.Add(cmbKategori);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUrunAd);
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 203);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ürün Bilgileri";
            // 
            // nudUrunUcret
            // 
            nudUrunUcret.Location = new Point(393, 35);
            nudUrunUcret.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudUrunUcret.Name = "nudUrunUcret";
            nudUrunUcret.Size = new Size(150, 27);
            nudUrunUcret.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(335, 38);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 12;
            label6.Text = "Ücret:";
            // 
            // btnTakipGuncelle
            // 
            btnTakipGuncelle.BackColor = Color.FromArgb(192, 255, 255);
            btnTakipGuncelle.Location = new Point(588, 86);
            btnTakipGuncelle.Name = "btnTakipGuncelle";
            btnTakipGuncelle.Size = new Size(93, 38);
            btnTakipGuncelle.TabIndex = 11;
            btnTakipGuncelle.Text = "Güncelle";
            btnTakipGuncelle.UseVisualStyleBackColor = false;
            btnTakipGuncelle.Click += btnTakipGuncelle_Click;
            // 
            // btnTakipSil
            // 
            btnTakipSil.BackColor = Color.FromArgb(255, 192, 192);
            btnTakipSil.Location = new Point(588, 142);
            btnTakipSil.Name = "btnTakipSil";
            btnTakipSil.Size = new Size(93, 38);
            btnTakipSil.TabIndex = 10;
            btnTakipSil.Text = "Sil";
            btnTakipSil.UseVisualStyleBackColor = false;
            btnTakipSil.Click += btnTakipSil_Click;
            // 
            // btnTakipEkle
            // 
            btnTakipEkle.BackColor = Color.FromArgb(192, 255, 192);
            btnTakipEkle.Location = new Point(588, 29);
            btnTakipEkle.Name = "btnTakipEkle";
            btnTakipEkle.Size = new Size(93, 38);
            btnTakipEkle.TabIndex = 9;
            btnTakipEkle.Text = "Ekle";
            btnTakipEkle.UseVisualStyleBackColor = false;
            btnTakipEkle.Click += btnTakipEkle_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(0, 293);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(801, 27);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // dgvStok
            // 
            dgvStok.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvStok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStok.Dock = DockStyle.Bottom;
            dgvStok.Location = new Point(0, 326);
            dgvStok.Name = "dgvStok";
            dgvStok.RowHeadersWidth = 51;
            dgvStok.Size = new Size(800, 137);
            dgvStok.TabIndex = 12;
            dgvStok.CellClick += dgvStok_CellClick;
            // 
            // btnTakipGeri
            // 
            btnTakipGeri.Location = new Point(12, 12);
            btnTakipGeri.Name = "btnTakipGeri";
            btnTakipGeri.Size = new Size(94, 29);
            btnTakipGeri.TabIndex = 13;
            btnTakipGeri.Text = "Geri Dön";
            btnTakipGeri.UseVisualStyleBackColor = true;
            btnTakipGeri.Click += btnTakipGeri_Click;
            // 
            // FrmStokTakip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 463);
            Controls.Add(btnTakipGeri);
            Controls.Add(dgvStok);
            Controls.Add(textBox2);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Name = "FrmStokTakip";
            Text = "İlaç / Stok Takibi";
            Load += FrmStokTakip_Load;
            ((System.ComponentModel.ISupportInitialize)nudMiktar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudUrunUcret).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUrunAd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbKategori;
        private NumericUpDown nudMiktar;
        private DateTimePicker dtpSkt;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnTakipGuncelle;
        private Button btnTakipSil;
        private Button btnTakipEkle;
        private TextBox textBox2;
        private DataGridView dgvStok;
        private Button btnTakipGeri;
        private NumericUpDown nudUrunUcret;
        private Label label6;
    }
}