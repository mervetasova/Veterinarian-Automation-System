namespace Veteriner_Otomasyonu
{
    partial class FrmRandevu
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
            dgvRandevu = new DataGridView();
            textBox1 = new TextBox();
            dtpRandevu = new DateTimePicker();
            btnRandevuGuncelle = new Button();
            btnRandevuSil = new Button();
            btnRandevuEkle = new Button();
            txtSecHasta = new TextBox();
            label5 = new Label();
            cmbRapor = new ComboBox();
            label4 = new Label();
            btnRandevuGeri = new Button();
            monthCalendar1 = new MonthCalendar();
            groupBox1 = new GroupBox();
            lblUrunID = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRandevu).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GhostWhite;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(258, 10);
            label1.Name = "label1";
            label1.Size = new Size(295, 38);
            label1.TabIndex = 0;
            label1.Text = "RANDEVU YÖNETİMİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 23);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 1;
            label2.Text = "Randevu Saati:";
            // 
            // dgvRandevu
            // 
            dgvRandevu.BackgroundColor = SystemColors.GradientInactiveCaption;
            dgvRandevu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRandevu.Dock = DockStyle.Bottom;
            dgvRandevu.Location = new Point(0, 321);
            dgvRandevu.Name = "dgvRandevu";
            dgvRandevu.RowHeadersWidth = 51;
            dgvRandevu.Size = new Size(803, 131);
            dgvRandevu.TabIndex = 2;
            dgvRandevu.CellClick += dataGridView1_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 286);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(800, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dtpRandevu
            // 
            dtpRandevu.CustomFormat = "dd.MM.yyyy.HH.mm";
            dtpRandevu.Format = DateTimePickerFormat.Custom;
            dtpRandevu.Location = new Point(118, 23);
            dtpRandevu.Name = "dtpRandevu";
            dtpRandevu.Size = new Size(250, 27);
            dtpRandevu.TabIndex = 5;
            // 
            // btnRandevuGuncelle
            // 
            btnRandevuGuncelle.BackColor = Color.FromArgb(192, 255, 255);
            btnRandevuGuncelle.ForeColor = SystemColors.ControlText;
            btnRandevuGuncelle.Location = new Point(339, 128);
            btnRandevuGuncelle.Name = "btnRandevuGuncelle";
            btnRandevuGuncelle.Size = new Size(107, 44);
            btnRandevuGuncelle.TabIndex = 16;
            btnRandevuGuncelle.Text = "Güncelle";
            btnRandevuGuncelle.UseVisualStyleBackColor = false;
            btnRandevuGuncelle.Click += btnRandevuGuncelle_Click;
            // 
            // btnRandevuSil
            // 
            btnRandevuSil.BackColor = Color.FromArgb(255, 192, 192);
            btnRandevuSil.ForeColor = SystemColors.ControlText;
            btnRandevuSil.Location = new Point(199, 128);
            btnRandevuSil.Name = "btnRandevuSil";
            btnRandevuSil.Size = new Size(107, 44);
            btnRandevuSil.TabIndex = 15;
            btnRandevuSil.Text = "Sil";
            btnRandevuSil.UseVisualStyleBackColor = false;
            btnRandevuSil.Click += btnRandevuSil_Click;
            // 
            // btnRandevuEkle
            // 
            btnRandevuEkle.BackColor = Color.FromArgb(192, 255, 192);
            btnRandevuEkle.ForeColor = SystemColors.ControlText;
            btnRandevuEkle.Location = new Point(59, 128);
            btnRandevuEkle.Name = "btnRandevuEkle";
            btnRandevuEkle.Size = new Size(107, 44);
            btnRandevuEkle.TabIndex = 14;
            btnRandevuEkle.Text = "Ekle";
            btnRandevuEkle.UseVisualStyleBackColor = false;
            btnRandevuEkle.Click += btnRandevuEkle_Click;
            // 
            // txtSecHasta
            // 
            txtSecHasta.Location = new Point(370, 80);
            txtSecHasta.Name = "txtSecHasta";
            txtSecHasta.ReadOnly = true;
            txtSecHasta.Size = new Size(125, 27);
            txtSecHasta.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 83);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 12;
            label5.Text = "Seçili Hasta:";
            // 
            // cmbRapor
            // 
            cmbRapor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRapor.FormattingEnabled = true;
            cmbRapor.Items.AddRange(new object[] { "Aşı", "Ameliyat", "İlaç enjekte", "Muayne", "Parazit işlem" });
            cmbRapor.Location = new Point(118, 80);
            cmbRapor.Name = "cmbRapor";
            cmbRapor.Size = new Size(151, 28);
            cmbRapor.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 83);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 7;
            label4.Text = "İşlem Adı:";
            // 
            // btnRandevuGeri
            // 
            btnRandevuGeri.Location = new Point(12, 10);
            btnRandevuGeri.Name = "btnRandevuGeri";
            btnRandevuGeri.Size = new Size(94, 29);
            btnRandevuGeri.TabIndex = 8;
            btnRandevuGeri.Text = "Geri Dön";
            btnRandevuGeri.UseVisualStyleBackColor = true;
            btnRandevuGeri.Click += btnRandevuGeri_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(12, 67);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.GhostWhite;
            groupBox1.Controls.Add(lblUrunID);
            groupBox1.Controls.Add(btnRandevuGuncelle);
            groupBox1.Controls.Add(btnRandevuSil);
            groupBox1.Controls.Add(btnRandevuEkle);
            groupBox1.Controls.Add(txtSecHasta);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbRapor);
            groupBox1.Controls.Add(dtpRandevu);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(284, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 207);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // lblUrunID
            // 
            lblUrunID.AutoSize = true;
            lblUrunID.Location = new Point(488, 184);
            lblUrunID.Name = "lblUrunID";
            lblUrunID.Size = new Size(17, 20);
            lblUrunID.TabIndex = 17;
            lblUrunID.Text = "0";
            // 
            // FrmRandevu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(803, 452);
            Controls.Add(groupBox1);
            Controls.Add(monthCalendar1);
            Controls.Add(btnRandevuGeri);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dgvRandevu);
            ForeColor = SystemColors.ControlText;
            Name = "FrmRandevu";
            Text = "Randevu Takip";
            Load += Form5_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRandevu).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dgvRandevu;
        private TextBox textBox1;
        private DateTimePicker dtpRandevu;
        private Label label4;
        private ComboBox cmbRapor;
        private Label label5;
        private Button btnRandevuEkle;
        private TextBox txtSecHasta;
        private Button btnRandevuGuncelle;
        private Button btnRandevuSil;
        private Button btnRandevuGeri;
        private MonthCalendar monthCalendar1;
        private GroupBox groupBox1;
        private Label lblUrunID;
    }
}