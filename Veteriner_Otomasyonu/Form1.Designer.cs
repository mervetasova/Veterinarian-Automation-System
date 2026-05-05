namespace Veteriner_Otomasyonu
{
    partial class FrmKayit
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAd = new Label();
            lblSoyad = new Label();
            lblNo = new Label();
            lblPosta = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtNo = new TextBox();
            txtPosta = new TextBox();
            lbl_H_Ad = new Label();
            lblTur = new Label();
            lblCins = new Label();
            lblDogum_Tarih = new Label();
            txtHayvanAd = new TextBox();
            txtCins = new TextBox();
            txtTur = new TextBox();
            groupBox1 = new GroupBox();
            btnSahipKayitSil = new Button();
            btnSahipKayitGuncelle = new Button();
            groupBox2 = new GroupBox();
            dtpDogum = new DateTimePicker();
            cbCinsiyet = new ComboBox();
            lblCinsiyet = new Label();
            btnHayvanKayitSil = new Button();
            btnHayvanKayitEkle = new Button();
            label1 = new Label();
            btnKayitGeri = new Button();
            dgvKayit = new DataGridView();
            textBox1 = new TextBox();
            lblHayvanID = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKayit).BeginInit();
            SuspendLayout();
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(18, 27);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(33, 20);
            lblAd.TabIndex = 0;
            lblAd.Text = "AD:";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(18, 61);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(59, 20);
            lblSoyad.TabIndex = 1;
            lblSoyad.Text = "SOYAD:";
            // 
            // lblNo
            // 
            lblNo.AutoSize = true;
            lblNo.Location = new Point(18, 99);
            lblNo.Name = "lblNo";
            lblNo.Size = new Size(61, 20);
            lblNo.TabIndex = 2;
            lblNo.Text = "TEL NO:";
            // 
            // lblPosta
            // 
            lblPosta.AutoSize = true;
            lblPosta.Location = new Point(18, 137);
            lblPosta.Name = "lblPosta";
            lblPosta.Size = new Size(70, 20);
            lblPosta.TabIndex = 3;
            lblPosta.Text = "E-POSTA:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(94, 20);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 4;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(94, 58);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(125, 27);
            txtSoyad.TabIndex = 5;
            // 
            // txtNo
            // 
            txtNo.Location = new Point(94, 92);
            txtNo.Name = "txtNo";
            txtNo.Size = new Size(125, 27);
            txtNo.TabIndex = 6;
            // 
            // txtPosta
            // 
            txtPosta.Location = new Point(94, 130);
            txtPosta.Multiline = true;
            txtPosta.Name = "txtPosta";
            txtPosta.ScrollBars = ScrollBars.Both;
            txtPosta.Size = new Size(125, 27);
            txtPosta.TabIndex = 7;
            // 
            // lbl_H_Ad
            // 
            lbl_H_Ad.AutoSize = true;
            lbl_H_Ad.Location = new Point(24, 27);
            lbl_H_Ad.Name = "lbl_H_Ad";
            lbl_H_Ad.Size = new Size(98, 20);
            lbl_H_Ad.TabIndex = 8;
            lbl_H_Ad.Text = "HAYVAN ADI:";
            // 
            // lblTur
            // 
            lblTur.AutoSize = true;
            lblTur.Location = new Point(24, 61);
            lblTur.Name = "lblTur";
            lblTur.Size = new Size(39, 20);
            lblTur.TabIndex = 9;
            lblTur.Text = "TÜR:";
            // 
            // lblCins
            // 
            lblCins.AutoSize = true;
            lblCins.Location = new Point(24, 99);
            lblCins.Name = "lblCins";
            lblCins.Size = new Size(44, 20);
            lblCins.TabIndex = 10;
            lblCins.Text = "CİNS:";
            // 
            // lblDogum_Tarih
            // 
            lblDogum_Tarih.AutoSize = true;
            lblDogum_Tarih.Location = new Point(101, 177);
            lblDogum_Tarih.Name = "lblDogum_Tarih";
            lblDogum_Tarih.Size = new Size(116, 20);
            lblDogum_Tarih.TabIndex = 12;
            lblDogum_Tarih.Text = "DOĞUM TARİHİ:";
            // 
            // txtHayvanAd
            // 
            txtHayvanAd.Location = new Point(146, 20);
            txtHayvanAd.Name = "txtHayvanAd";
            txtHayvanAd.Size = new Size(125, 27);
            txtHayvanAd.TabIndex = 13;
            // 
            // txtCins
            // 
            txtCins.Location = new Point(146, 92);
            txtCins.Name = "txtCins";
            txtCins.Size = new Size(125, 27);
            txtCins.TabIndex = 15;
            // 
            // txtTur
            // 
            txtTur.Location = new Point(146, 58);
            txtTur.Name = "txtTur";
            txtTur.Size = new Size(125, 27);
            txtTur.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.GhostWhite;
            groupBox1.Controls.Add(txtPosta);
            groupBox1.Controls.Add(txtNo);
            groupBox1.Controls.Add(txtSoyad);
            groupBox1.Controls.Add(txtAd);
            groupBox1.Controls.Add(lblPosta);
            groupBox1.Controls.Add(lblNo);
            groupBox1.Controls.Add(lblSoyad);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Location = new Point(367, 84);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(327, 238);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sahip";
            // 
            // btnSahipKayitSil
            // 
            btnSahipKayitSil.BackColor = Color.FromArgb(255, 192, 192);
            btnSahipKayitSil.Location = new Point(739, 261);
            btnSahipKayitSil.Name = "btnSahipKayitSil";
            btnSahipKayitSil.Size = new Size(111, 33);
            btnSahipKayitSil.TabIndex = 20;
            btnSahipKayitSil.Text = "SİL";
            btnSahipKayitSil.UseVisualStyleBackColor = false;
            btnSahipKayitSil.Click += btnSahipKayitSil_Click;
            // 
            // btnSahipKayitGuncelle
            // 
            btnSahipKayitGuncelle.BackColor = Color.FromArgb(192, 255, 192);
            btnSahipKayitGuncelle.Location = new Point(739, 208);
            btnSahipKayitGuncelle.Name = "btnSahipKayitGuncelle";
            btnSahipKayitGuncelle.Size = new Size(111, 33);
            btnSahipKayitGuncelle.TabIndex = 8;
            btnSahipKayitGuncelle.Text = "HASTA EKLE";
            btnSahipKayitGuncelle.UseVisualStyleBackColor = false;
            btnSahipKayitGuncelle.Click += btnSahipKayitGuncelle_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.GhostWhite;
            groupBox2.Controls.Add(dtpDogum);
            groupBox2.Controls.Add(cbCinsiyet);
            groupBox2.Controls.Add(txtTur);
            groupBox2.Controls.Add(txtCins);
            groupBox2.Controls.Add(txtHayvanAd);
            groupBox2.Controls.Add(lblCinsiyet);
            groupBox2.Controls.Add(lblCins);
            groupBox2.Controls.Add(lblDogum_Tarih);
            groupBox2.Controls.Add(lblTur);
            groupBox2.Controls.Add(lbl_H_Ad);
            groupBox2.Location = new Point(19, 84);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(327, 238);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hayvan";
            // 
            // dtpDogum
            // 
            dtpDogum.Location = new Point(38, 200);
            dtpDogum.Name = "dtpDogum";
            dtpDogum.Size = new Size(253, 27);
            dtpDogum.TabIndex = 24;
            // 
            // cbCinsiyet
            // 
            cbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCinsiyet.FormattingEnabled = true;
            cbCinsiyet.Items.AddRange(new object[] { "Erkek", "Disi" });
            cbCinsiyet.Location = new Point(146, 134);
            cbCinsiyet.Name = "cbCinsiyet";
            cbCinsiyet.Size = new Size(151, 28);
            cbCinsiyet.TabIndex = 23;
            // 
            // lblCinsiyet
            // 
            lblCinsiyet.AutoSize = true;
            lblCinsiyet.Location = new Point(24, 137);
            lblCinsiyet.Name = "lblCinsiyet";
            lblCinsiyet.Size = new Size(72, 20);
            lblCinsiyet.TabIndex = 11;
            lblCinsiyet.Text = "CİNSİYET:";
            // 
            // btnHayvanKayitSil
            // 
            btnHayvanKayitSil.BackColor = Color.FromArgb(255, 192, 192);
            btnHayvanKayitSil.Location = new Point(739, 158);
            btnHayvanKayitSil.Name = "btnHayvanKayitSil";
            btnHayvanKayitSil.Size = new Size(111, 33);
            btnHayvanKayitSil.TabIndex = 22;
            btnHayvanKayitSil.Text = "SİL";
            btnHayvanKayitSil.UseVisualStyleBackColor = false;
            btnHayvanKayitSil.Click += btnHayvanKayitSil_Click;
            // 
            // btnHayvanKayitEkle
            // 
            btnHayvanKayitEkle.BackColor = Color.FromArgb(192, 255, 192);
            btnHayvanKayitEkle.Location = new Point(739, 105);
            btnHayvanKayitEkle.Name = "btnHayvanKayitEkle";
            btnHayvanKayitEkle.Size = new Size(111, 33);
            btnHayvanKayitEkle.TabIndex = 21;
            btnHayvanKayitEkle.Text = "HAYVAN EKLE";
            btnHayvanKayitEkle.UseVisualStyleBackColor = false;
            btnHayvanKayitEkle.Click += btnHayvanKayitEkle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GhostWhite;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(290, 9);
            label1.Name = "label1";
            label1.Size = new Size(303, 38);
            label1.TabIndex = 20;
            label1.Text = "HASTA KAYIT FORMU";
            // 
            // btnKayitGeri
            // 
            btnKayitGeri.BackColor = Color.GhostWhite;
            btnKayitGeri.Location = new Point(12, 19);
            btnKayitGeri.Name = "btnKayitGeri";
            btnKayitGeri.Size = new Size(94, 29);
            btnKayitGeri.TabIndex = 21;
            btnKayitGeri.Text = "Geri Dön";
            btnKayitGeri.UseVisualStyleBackColor = false;
            btnKayitGeri.Click += btnKayitGeri_Click;
            // 
            // dgvKayit
            // 
            dgvKayit.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvKayit.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKayit.Dock = DockStyle.Bottom;
            dgvKayit.Location = new Point(0, 431);
            dgvKayit.Name = "dgvKayit";
            dgvKayit.RowHeadersWidth = 51;
            dgvKayit.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKayit.Size = new Size(894, 182);
            dgvKayit.TabIndex = 22;
            dgvKayit.CellClick += dgvKayit_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 375);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(886, 27);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lblHayvanID
            // 
            lblHayvanID.AutoSize = true;
            lblHayvanID.Location = new Point(874, 352);
            lblHayvanID.Name = "lblHayvanID";
            lblHayvanID.Size = new Size(0, 20);
            lblHayvanID.TabIndex = 24;
            // 
            // FrmKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(894, 613);
            Controls.Add(lblHayvanID);
            Controls.Add(textBox1);
            Controls.Add(btnSahipKayitSil);
            Controls.Add(btnHayvanKayitSil);
            Controls.Add(btnHayvanKayitEkle);
            Controls.Add(dgvKayit);
            Controls.Add(btnSahipKayitGuncelle);
            Controls.Add(btnKayitGeri);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmKayit";
            Text = "KAYIT";
            Load += FrmKayit_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvKayit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAd;
        private Label lblSoyad;
        private Label lblNo;
        private Label lblPosta;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtNo;
        private TextBox txtPosta;
        private Label lbl_H_Ad;
        private Label lblTur;
        private Label lblCins;
        private Label lblDogum_Tarih;
        private TextBox txtHayvanAd;
        private TextBox txtCins;
        private TextBox txtTur;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnSahipKayitGuncelle;
        private Button btnSahipKayitSil;
        private Button btnHayvanKayitSil;
        private Button btnHayvanKayitEkle;
        private Label label1;
        private Button btnKayitGeri;
        private ComboBox cbCinsiyet;
        private Label lblCinsiyet;
        private DataGridView dgvKayit;
        private DateTimePicker dtpDogum;
        private TextBox textBox1;
        private Label lblHayvanID;
    }
}
