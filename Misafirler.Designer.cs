namespace OtelYonetimSistemi
{
    partial class Misafirler
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
            pnlUstMis = new Panel();
            btnGeriDon = new Button();
            lblMisafirler = new Label();
            dgvMusteriler = new DataGridView();
            txtMusteriArama = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            btnKaydet = new Button();
            btnTemizle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            txtMusteriAd = new TextBox();
            txtMusteriSoyad = new TextBox();
            cmbOda = new ComboBox();
            pnlUstMis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUstMis
            // 
            pnlUstMis.BackColor = Color.SteelBlue;
            pnlUstMis.Controls.Add(btnGeriDon);
            pnlUstMis.Controls.Add(lblMisafirler);
            pnlUstMis.Dock = DockStyle.Top;
            pnlUstMis.Location = new Point(0, 0);
            pnlUstMis.Name = "pnlUstMis";
            pnlUstMis.Size = new Size(899, 70);
            pnlUstMis.TabIndex = 1;
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new Point(737, 38);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(137, 29);
            btnGeriDon.TabIndex = 5;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // lblMisafirler
            // 
            lblMisafirler.AutoSize = true;
            lblMisafirler.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblMisafirler.ForeColor = Color.White;
            lblMisafirler.Location = new Point(50, 20);
            lblMisafirler.Name = "lblMisafirler";
            lblMisafirler.Size = new Size(125, 31);
            lblMisafirler.TabIndex = 1;
            lblMisafirler.Text = "Müşteriler";
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.BackgroundColor = Color.White;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Location = new Point(371, 157);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.RowHeadersWidth = 51;
            dgvMusteriler.Size = new Size(503, 308);
            dgvMusteriler.TabIndex = 14;
            dgvMusteriler.CellClick += dgvMusteriler_CellClick;
            // 
            // txtMusteriArama
            // 
            txtMusteriArama.BackColor = SystemColors.Control;
            txtMusteriArama.Location = new Point(514, 94);
            txtMusteriArama.Name = "txtMusteriArama";
            txtMusteriArama.Size = new Size(137, 27);
            txtMusteriArama.TabIndex = 17;
            txtMusteriArama.TextChanged += txtMusteriArama_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(371, 97);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 16;
            label3.Text = "Müşteri Arama";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(btnTemizle);
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(btnGuncelle);
            panel1.Location = new Point(50, 321);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 144);
            panel1.TabIndex = 18;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.PowderBlue;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.Black;
            btnKaydet.Location = new Point(0, 3);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(264, 29);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.BackColor = Color.PowderBlue;
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Location = new Point(0, 73);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(264, 29);
            btnTemizle.TabIndex = 10;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.PowderBlue;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Location = new Point(0, 108);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(264, 29);
            btnSil.TabIndex = 11;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.PowderBlue;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(0, 38);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(264, 29);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(txtMusteriAd, 1, 0);
            tableLayoutPanel1.Controls.Add(txtMusteriSoyad, 1, 1);
            tableLayoutPanel1.Controls.Add(cmbOda, 1, 2);
            tableLayoutPanel1.Location = new Point(50, 136);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(264, 144);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 14);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Müşteri Ad";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(3, 62);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 1;
            label2.Text = "Müşteri Soyad";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(3, 110);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 2;
            label4.Text = "Oda";
            // 
            // txtMusteriAd
            // 
            txtMusteriAd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMusteriAd.Location = new Point(112, 10);
            txtMusteriAd.Name = "txtMusteriAd";
            txtMusteriAd.Size = new Size(149, 27);
            txtMusteriAd.TabIndex = 3;
            // 
            // txtMusteriSoyad
            // 
            txtMusteriSoyad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMusteriSoyad.Location = new Point(112, 58);
            txtMusteriSoyad.Name = "txtMusteriSoyad";
            txtMusteriSoyad.Size = new Size(149, 27);
            txtMusteriSoyad.TabIndex = 4;
            // 
            // cmbOda
            // 
            cmbOda.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbOda.FormattingEnabled = true;
            cmbOda.Location = new Point(112, 106);
            cmbOda.Name = "cmbOda";
            cmbOda.Size = new Size(149, 28);
            cmbOda.TabIndex = 5;
            // 
            // Misafirler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(txtMusteriArama);
            Controls.Add(label3);
            Controls.Add(dgvMusteriler);
            Controls.Add(pnlUstMis);
            Name = "Misafirler";
            Size = new Size(899, 541);
            Load += Misafirler_Load;
            pnlUstMis.ResumeLayout(false);
            pnlUstMis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlUstMis;
        private Label lblMisafirler;
        private Button btnGeriDon;
        private DataGridView dgvMusteriler;
        private TextBox txtMusteriArama;
        private Label label3;
        private Panel panel1;
        private Button btnKaydet;
        private Button btnTemizle;
        private Button btnSil;
        private Button btnGuncelle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private TextBox txtMusteriAd;
        private TextBox txtMusteriSoyad;
        private ComboBox cmbOda;
    }
}
