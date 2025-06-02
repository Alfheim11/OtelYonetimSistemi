namespace OtelYonetimSistemi
{
    partial class Rezervasyon
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            pnlUstRez = new Panel();
            btnGeriDon = new Button();
            lblRezervasyon = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            dtpCikisTarihi = new DateTimePicker();
            cmbPersonel = new ComboBox();
            txtMisafirSoyad = new TextBox();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtMisafirAd = new TextBox();
            cmbOda = new ComboBox();
            dtpGirisTarihi = new DateTimePicker();
            lblToplamTutar = new Label();
            label2 = new Label();
            dgvRezervasyonlar = new DataGridView();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            panel1 = new Panel();
            label8 = new Label();
            txtArama = new TextBox();
            pnlUstRez.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUstRez
            // 
            pnlUstRez.BackColor = Color.SteelBlue;
            pnlUstRez.Controls.Add(btnGeriDon);
            pnlUstRez.Controls.Add(lblRezervasyon);
            pnlUstRez.Dock = DockStyle.Top;
            pnlUstRez.Location = new Point(0, 0);
            pnlUstRez.Name = "pnlUstRez";
            pnlUstRez.Size = new Size(899, 70);
            pnlUstRez.TabIndex = 1;
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new Point(751, 38);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(137, 29);
            btnGeriDon.TabIndex = 2;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // lblRezervasyon
            // 
            lblRezervasyon.AutoSize = true;
            lblRezervasyon.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblRezervasyon.ForeColor = Color.White;
            lblRezervasyon.Location = new Point(50, 20);
            lblRezervasyon.Name = "lblRezervasyon";
            lblRezervasyon.Size = new Size(175, 31);
            lblRezervasyon.TabIndex = 1;
            lblRezervasyon.Text = "Rezervasyonlar";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dtpCikisTarihi, 1, 5);
            tableLayoutPanel1.Controls.Add(cmbPersonel, 1, 3);
            tableLayoutPanel1.Controls.Add(txtMisafirSoyad, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 6);
            tableLayoutPanel1.Controls.Add(txtMisafirAd, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbOda, 1, 2);
            tableLayoutPanel1.Controls.Add(dtpGirisTarihi, 1, 4);
            tableLayoutPanel1.Controls.Add(lblToplamTutar, 1, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(18, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(314, 263);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(108, 183);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(203, 27);
            dtpCikisTarihi.TabIndex = 11;
            // 
            // cmbPersonel
            // 
            cmbPersonel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbPersonel.FormattingEnabled = true;
            cmbPersonel.Location = new Point(108, 111);
            cmbPersonel.Name = "cmbPersonel";
            cmbPersonel.Size = new Size(203, 28);
            cmbPersonel.TabIndex = 9;
            // 
            // txtMisafirSoyad
            // 
            txtMisafirSoyad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMisafirSoyad.Location = new Point(108, 39);
            txtMisafirSoyad.Name = "txtMisafirSoyad";
            txtMisafirSoyad.Size = new Size(203, 27);
            txtMisafirSoyad.TabIndex = 7;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(3, 188);
            label6.Name = "label6";
            label6.Size = new Size(99, 20);
            label6.TabIndex = 3;
            label6.Text = "Çıkış Tarihi";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 0;
            label1.Text = "Misafir Ad";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 80);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 2;
            label3.Text = "Oda";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 116);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 3;
            label4.Text = "Personel Ad";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(3, 152);
            label5.Name = "label5";
            label5.Size = new Size(99, 20);
            label5.TabIndex = 4;
            label5.Text = "Giris Tarihi";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(3, 229);
            label7.Name = "label7";
            label7.Size = new Size(99, 20);
            label7.TabIndex = 5;
            label7.Text = "Toplam Tutar";
            // 
            // txtMisafirAd
            // 
            txtMisafirAd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMisafirAd.Location = new Point(108, 3);
            txtMisafirAd.Name = "txtMisafirAd";
            txtMisafirAd.Size = new Size(203, 27);
            txtMisafirAd.TabIndex = 6;
            // 
            // cmbOda
            // 
            cmbOda.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbOda.FormattingEnabled = true;
            cmbOda.Location = new Point(108, 75);
            cmbOda.Name = "cmbOda";
            cmbOda.Size = new Size(203, 28);
            cmbOda.TabIndex = 8;
            // 
            // dtpGirisTarihi
            // 
            dtpGirisTarihi.Location = new Point(108, 147);
            dtpGirisTarihi.Name = "dtpGirisTarihi";
            dtpGirisTarihi.Size = new Size(203, 27);
            dtpGirisTarihi.TabIndex = 10;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Location = new Point(108, 229);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(203, 20);
            lblToplamTutar.TabIndex = 12;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 1;
            label2.Text = "Misafir Soyad";
            // 
            // dgvRezervasyonlar
            // 
            dgvRezervasyonlar.BackgroundColor = Color.White;
            dgvRezervasyonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRezervasyonlar.Location = new Point(348, 116);
            dgvRezervasyonlar.Name = "dgvRezervasyonlar";
            dgvRezervasyonlar.RowHeadersWidth = 51;
            dgvRezervasyonlar.Size = new Size(540, 403);
            dgvRezervasyonlar.TabIndex = 3;
            dgvRezervasyonlar.CellClick += dgvRezervasyonlar_CellClick;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.PowderBlue;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.Black;
            btnKaydet.Location = new Point(0, 14);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(311, 29);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.PowderBlue;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(0, 49);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(311, 29);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.PowderBlue;
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Location = new Point(0, 84);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(311, 29);
            btnTemizle.TabIndex = 6;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.PowderBlue;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Location = new Point(-3, 119);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(314, 29);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(btnGuncelle);
            panel1.Controls.Add(btnTemizle);
            panel1.Location = new Point(21, 367);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 153);
            panel1.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(348, 83);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 9;
            label8.Text = "İsim Arama";
            // 
            // txtArama
            // 
            txtArama.BackColor = SystemColors.Control;
            txtArama.Location = new Point(460, 80);
            txtArama.Name = "txtArama";
            txtArama.Size = new Size(125, 27);
            txtArama.TabIndex = 10;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // Rezervasyon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(txtArama);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(dgvRezervasyonlar);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlUstRez);
            Name = "Rezervasyon";
            Size = new Size(899, 541);
            Load += Rezervasyon_Load;
            pnlUstRez.ResumeLayout(false);
            pnlUstRez.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRezervasyonlar).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlUstRez;
        private Label lblRezervasyon;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridView dgvRezervasyonlar;
        private DateTimePicker dtpCikisTarihi;
        private ComboBox cmbPersonel;
        private TextBox txtMisafirSoyad;
        private TextBox txtMisafirAd;
        private ComboBox cmbOda;
        private DateTimePicker dtpGirisTarihi;
        private Label lblToplamTutar;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnTemizle;
        private Button btnSil;
        private Panel panel1;
        private Button btnGeriDon;
        private Label label8;
        private TextBox txtArama;
    }
}
