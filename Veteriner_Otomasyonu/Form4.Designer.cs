namespace Veteriner_Otomasyonu
{
    partial class FrmKullaniciGiris
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
            txtKullaniciAd = new TextBox();
            txtKullaniciSifre = new TextBox();
            groupBox1 = new GroupBox();
            btnGiris = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 74);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 142);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // txtKullaniciAd
            // 
            txtKullaniciAd.Location = new Point(152, 71);
            txtKullaniciAd.Name = "txtKullaniciAd";
            txtKullaniciAd.Size = new Size(125, 27);
            txtKullaniciAd.TabIndex = 2;
            // 
            // txtKullaniciSifre
            // 
            txtKullaniciSifre.Location = new Point(152, 139);
            txtKullaniciSifre.Name = "txtKullaniciSifre";
            txtKullaniciSifre.Size = new Size(125, 27);
            txtKullaniciSifre.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.GhostWhite;
            groupBox1.Controls.Add(btnGiris);
            groupBox1.Controls.Add(txtKullaniciSifre);
            groupBox1.Controls.Add(txtKullaniciAd);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(212, 96);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 286);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Girişi";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnGiris
            // 
            btnGiris.BackColor = Color.Lavender;
            btnGiris.Font = new Font("Bahnschrift Condensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGiris.Location = new Point(127, 211);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(125, 47);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "GİRİŞ";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.GhostWhite;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(278, 9);
            label3.Name = "label3";
            label3.Size = new Size(250, 38);
            label3.TabIndex = 5;
            label3.Text = "KULLANICI GİRİŞİ";
            // 
            // FrmKullaniciGiris
            // 
            AcceptButton = btnGiris;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "FrmKullaniciGiris";
            Text = "Kulanıcı Giriş";
            FormClosed += FrmKullaniciGiris_FormClosed;
            Load += FrmKullaniciGiris_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAd;
        private TextBox txtKullaniciSifre;
        private GroupBox groupBox1;
        private Button btnGiris;
        private Label label3;
    }
}