namespace Veteriner_Otomasyonu
{
    partial class FrmSatis
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
            label1 = new Label();
            label2 = new Label();
            dgvIslem = new DataGridView();
            label3 = new Label();
            dtpIslemTarih = new DateTimePicker();
            textBox1 = new TextBox();
            btnSatısGeri = new Button();
            panel1 = new Panel();
            txtYillikKazanc = new TextBox();
            txtAylikKazanc = new TextBox();
            txtGunlukKazanc = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label7 = new Label();
            nudIslemUcret = new NumericUpDown();
            btnSatisEkle = new Button();
            btnSil = new Button();
            label8 = new Label();
            txtUrunId = new TextBox();
            label9 = new Label();
            txtUrunAd = new TextBox();
            btnUrunSat = new Button();
            label10 = new Label();
            nudAlincakUrunMiktar = new NumericUpDown();
            label11 = new Label();
            txtUrunUcret = new TextBox();
            dgvUrun = new DataGridView();
            textBox2 = new TextBox();
            txtIslemAd = new TextBox();
            dtpNow = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvIslem).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIslemUcret).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudAlincakUrunMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrun).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GhostWhite;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(364, 9);
            label1.Name = "label1";
            label1.Size = new Size(322, 38);
            label1.TabIndex = 0;
            label1.Text = "SATIŞ / İŞLEM GEÇMİŞİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 164);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "İşlem Adı:";
            // 
            // dgvIslem
            // 
            dgvIslem.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvIslem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIslem.Location = new Point(-2, 277);
            dgvIslem.Name = "dgvIslem";
            dgvIslem.RowHeadersWidth = 51;
            dgvIslem.Size = new Size(531, 164);
            dgvIslem.TabIndex = 3;
            dgvIslem.CellClick += dgvIslem_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 209);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 4;
            label3.Text = "İşlem tarihi:";
            // 
            // dtpIslemTarih
            // 
            dtpIslemTarih.CustomFormat = "dd.MM.yyyy.HH.mm";
            dtpIslemTarih.Format = DateTimePickerFormat.Custom;
            dtpIslemTarih.Location = new Point(105, 204);
            dtpIslemTarih.Name = "dtpIslemTarih";
            dtpIslemTarih.Size = new Size(239, 27);
            dtpIslemTarih.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-2, 237);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(525, 34);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnSatısGeri
            // 
            btnSatısGeri.Location = new Point(12, 12);
            btnSatısGeri.Name = "btnSatısGeri";
            btnSatısGeri.Size = new Size(94, 29);
            btnSatısGeri.TabIndex = 7;
            btnSatısGeri.Text = "Geri Dön";
            btnSatısGeri.UseVisualStyleBackColor = true;
            btnSatısGeri.Click += btnSatısGeri_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtYillikKazanc);
            panel1.Controls.Add(txtAylikKazanc);
            panel1.Controls.Add(txtGunlukKazanc);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(709, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 168);
            panel1.TabIndex = 8;
            // 
            // txtYillikKazanc
            // 
            txtYillikKazanc.Location = new Point(163, 120);
            txtYillikKazanc.Name = "txtYillikKazanc";
            txtYillikKazanc.ReadOnly = true;
            txtYillikKazanc.Size = new Size(125, 27);
            txtYillikKazanc.TabIndex = 5;
            // 
            // txtAylikKazanc
            // 
            txtAylikKazanc.Location = new Point(163, 76);
            txtAylikKazanc.Name = "txtAylikKazanc";
            txtAylikKazanc.ReadOnly = true;
            txtAylikKazanc.Size = new Size(125, 27);
            txtAylikKazanc.TabIndex = 4;
            // 
            // txtGunlukKazanc
            // 
            txtGunlukKazanc.Location = new Point(163, 27);
            txtGunlukKazanc.Name = "txtGunlukKazanc";
            txtGunlukKazanc.ReadOnly = true;
            txtGunlukKazanc.Size = new Size(125, 27);
            txtGunlukKazanc.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 123);
            label6.Name = "label6";
            label6.Size = new Size(94, 20);
            label6.TabIndex = 2;
            label6.Text = "Yıllık Kazanç:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(49, 74);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 1;
            label5.Text = "Aylık Kazanç:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 27);
            label4.Name = "label4";
            label4.Size = new Size(108, 20);
            label4.TabIndex = 0;
            label4.Text = "Günlük Kazanç:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 121);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 9;
            label7.Text = "Ücret:";
            // 
            // nudIslemUcret
            // 
            nudIslemUcret.DecimalPlaces = 2;
            nudIslemUcret.Location = new Point(105, 119);
            nudIslemUcret.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            nudIslemUcret.Name = "nudIslemUcret";
            nudIslemUcret.Size = new Size(150, 27);
            nudIslemUcret.TabIndex = 10;
            nudIslemUcret.ThousandsSeparator = true;
            // 
            // btnSatisEkle
            // 
            btnSatisEkle.BackColor = Color.FromArgb(192, 255, 192);
            btnSatisEkle.Location = new Point(605, 136);
            btnSatisEkle.Name = "btnSatisEkle";
            btnSatisEkle.Size = new Size(98, 31);
            btnSatisEkle.TabIndex = 11;
            btnSatisEkle.Text = "İşlem Satış";
            btnSatisEkle.UseVisualStyleBackColor = false;
            btnSatisEkle.Click += btnSatisEkle_Click_1;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.FromArgb(255, 192, 192);
            btnSil.Location = new Point(605, 173);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(98, 31);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 77);
            label8.Name = "label8";
            label8.Size = new Size(62, 20);
            label8.TabIndex = 13;
            label8.Text = "Ürün ID:";
            // 
            // txtUrunId
            // 
            txtUrunId.Location = new Point(105, 74);
            txtUrunId.Name = "txtUrunId";
            txtUrunId.ReadOnly = true;
            txtUrunId.Size = new Size(125, 27);
            txtUrunId.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(299, 77);
            label9.Name = "label9";
            label9.Size = new Size(70, 20);
            label9.TabIndex = 15;
            label9.Text = "Ürün Adı:";
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(375, 74);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.ReadOnly = true;
            txtUrunAd.Size = new Size(125, 27);
            txtUrunAd.TabIndex = 16;
            // 
            // btnUrunSat
            // 
            btnUrunSat.BackColor = Color.FromArgb(192, 255, 192);
            btnUrunSat.Location = new Point(605, 98);
            btnUrunSat.Name = "btnUrunSat";
            btnUrunSat.Size = new Size(98, 32);
            btnUrunSat.TabIndex = 17;
            btnUrunSat.Text = "Ürün Satış";
            btnUrunSat.UseVisualStyleBackColor = false;
            btnUrunSat.Click += btnUrunSat_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(299, 121);
            label10.Name = "label10";
            label10.Size = new Size(153, 20);
            label10.TabIndex = 18;
            label10.Text = "Alınacak Ürün Miktarı:";
            // 
            // nudAlincakUrunMiktar
            // 
            nudAlincakUrunMiktar.Location = new Point(458, 119);
            nudAlincakUrunMiktar.Name = "nudAlincakUrunMiktar";
            nudAlincakUrunMiktar.Size = new Size(93, 27);
            nudAlincakUrunMiktar.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(299, 164);
            label11.Name = "label11";
            label11.Size = new Size(82, 20);
            label11.TabIndex = 20;
            label11.Text = "Ürün Ücret:";
            // 
            // txtUrunUcret
            // 
            txtUrunUcret.Location = new Point(387, 161);
            txtUrunUcret.Name = "txtUrunUcret";
            txtUrunUcret.ReadOnly = true;
            txtUrunUcret.Size = new Size(125, 27);
            txtUrunUcret.TabIndex = 21;
            // 
            // dgvUrun
            // 
            dgvUrun.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvUrun.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrun.Location = new Point(535, 277);
            dgvUrun.Name = "dgvUrun";
            dgvUrun.RowHeadersWidth = 51;
            dgvUrun.Size = new Size(526, 164);
            dgvUrun.TabIndex = 22;
            dgvUrun.CellClick += dgvUrun_CellClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(542, 237);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(519, 34);
            textBox2.TabIndex = 24;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // txtIslemAd
            // 
            txtIslemAd.Location = new Point(105, 161);
            txtIslemAd.Name = "txtIslemAd";
            txtIslemAd.Size = new Size(150, 27);
            txtIslemAd.TabIndex = 25;
            // 
            // dtpNow
            // 
            dtpNow.CustomFormat = "dd.MM.yyyy.HH.mm";
            dtpNow.Format = DateTimePickerFormat.Custom;
            dtpNow.Location = new Point(799, 9);
            dtpNow.Name = "dtpNow";
            dtpNow.Size = new Size(250, 27);
            dtpNow.TabIndex = 26;
            // 
            // FrmSatis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1061, 444);
            Controls.Add(dtpNow);
            Controls.Add(txtIslemAd);
            Controls.Add(dgvUrun);
            Controls.Add(dgvIslem);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtUrunUcret);
            Controls.Add(label11);
            Controls.Add(nudAlincakUrunMiktar);
            Controls.Add(label10);
            Controls.Add(btnUrunSat);
            Controls.Add(txtUrunAd);
            Controls.Add(label9);
            Controls.Add(txtUrunId);
            Controls.Add(label8);
            Controls.Add(btnSil);
            Controls.Add(btnSatisEkle);
            Controls.Add(nudIslemUcret);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(btnSatısGeri);
            Controls.Add(dtpIslemTarih);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmSatis";
            Text = "Satış İşlem";
            Load += FrmSatıs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvIslem).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudIslemUcret).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudAlincakUrunMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrun).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvIslem;
        private Label label3;
        private DateTimePicker dtpIslemTarih;
        private TextBox textBox1;
        private Button btnSatısGeri;
        private Panel panel1;
        private TextBox txtYillikKazanc;
        private TextBox txtAylikKazanc;
        private TextBox txtGunlukKazanc;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private NumericUpDown nudIslemUcret;
        private Button btnSatisEkle;
        private Button btnSil;
        private Label label8;
        private TextBox txtUrunId;
        private Label label9;
        private TextBox txtUrunAd;
        private Button btnUrunSat;
        private Label label10;
        private NumericUpDown nudAlincakUrunMiktar;
        private Label label11;
        private TextBox txtUrunUcret;
        private DataGridView dgvUrun;
        private TextBox textBox2;
        private TextBox txtIslemAd;
        private DateTimePicker dtpNow;
    }
}