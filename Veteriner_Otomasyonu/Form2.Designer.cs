namespace Veteriner_Otomasyonu
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            btnSecimKayit = new Button();
            btnSecimTakip = new Button();
            btnSecimRandevu = new Button();
            btnSecimGecmis = new Button();
            btnCikis = new Button();
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblKarsilama = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSecimKayit
            // 
            btnSecimKayit.BackColor = Color.LightGreen;
            btnSecimKayit.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnSecimKayit.Location = new Point(290, 85);
            btnSecimKayit.Name = "btnSecimKayit";
            btnSecimKayit.Size = new Size(200, 55);
            btnSecimKayit.TabIndex = 0;
            btnSecimKayit.Text = "HASTA KAYIT";
            btnSecimKayit.UseVisualStyleBackColor = false;
            btnSecimKayit.Click += btnSecimKayit_Click;
            // 
            // btnSecimTakip
            // 
            btnSecimTakip.BackColor = Color.GhostWhite;
            btnSecimTakip.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnSecimTakip.Location = new Point(290, 146);
            btnSecimTakip.Name = "btnSecimTakip";
            btnSecimTakip.Size = new Size(200, 55);
            btnSecimTakip.TabIndex = 1;
            btnSecimTakip.Text = "İLAÇ / STOK TAKİBİ";
            btnSecimTakip.UseVisualStyleBackColor = false;
            btnSecimTakip.Click += btnSecimTakip_Click;
            // 
            // btnSecimRandevu
            // 
            btnSecimRandevu.BackColor = Color.GhostWhite;
            btnSecimRandevu.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnSecimRandevu.Location = new Point(290, 207);
            btnSecimRandevu.Name = "btnSecimRandevu";
            btnSecimRandevu.Size = new Size(200, 55);
            btnSecimRandevu.TabIndex = 2;
            btnSecimRandevu.Text = "RANDEVULAR";
            btnSecimRandevu.UseVisualStyleBackColor = false;
            btnSecimRandevu.Click += btnSecimRandevu_Click;
            // 
            // btnSecimGecmis
            // 
            btnSecimGecmis.BackColor = Color.GhostWhite;
            btnSecimGecmis.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnSecimGecmis.Location = new Point(290, 268);
            btnSecimGecmis.Name = "btnSecimGecmis";
            btnSecimGecmis.Size = new Size(200, 55);
            btnSecimGecmis.TabIndex = 3;
            btnSecimGecmis.Text = "SATIŞ / İŞLEM GEÇMİŞİ";
            btnSecimGecmis.UseVisualStyleBackColor = false;
            btnSecimGecmis.Click += btnSecimGecmis_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.LightCoral;
            btnCikis.Font = new Font("Microsoft Sans Serif", 10.8F);
            btnCikis.Location = new Point(290, 329);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(200, 55);
            btnCikis.TabIndex = 4;
            btnCikis.Text = "ÇIKIŞ";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GhostWhite;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(305, 12);
            label1.Name = "label1";
            label1.Size = new Size(171, 38);
            label1.TabIndex = 5;
            label1.Text = "ANA MENÜ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(538, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.GhostWhite;
            label2.Font = new Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(165, 19);
            label2.TabIndex = 8;
            label2.Text = "SARMAL VETERİNERLİK";
            // 
            // lblKarsilama
            // 
            lblKarsilama.AutoSize = true;
            lblKarsilama.BackColor = Color.GhostWhite;
            lblKarsilama.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKarsilama.ForeColor = Color.DarkSlateGray;
            lblKarsilama.Location = new Point(23, 136);
            lblKarsilama.Name = "lblKarsilama";
            lblKarsilama.Size = new Size(67, 26);
            lblKarsilama.TabIndex = 9;
            lblKarsilama.Text = "label3";
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(lblKarsilama);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(btnCikis);
            Controls.Add(btnSecimGecmis);
            Controls.Add(btnSecimRandevu);
            Controls.Add(btnSecimTakip);
            Controls.Add(btnSecimKayit);
            Name = "FrmMenu";
            Text = "Ana Menü";
            FormClosed += FrmMenu_FormClosed;
            Load += FrmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSecimKayit;
        private Button btnSecimTakip;
        private Button btnSecimRandevu;
        private Button btnSecimGecmis;
        private Button btnCikis;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lblKarsilama;
    }
}