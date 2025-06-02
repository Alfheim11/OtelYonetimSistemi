namespace OtelYonetimSistemi
{
    partial class Odalar
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
            pnlUstOda = new Panel();
            btnGeriDon = new Button();
            lblOdalar = new Label();
            dgvOdalar = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtOdaNo = new TextBox();
            txtFiyat = new TextBox();
            cmbDurum = new ComboBox();
            btnKaydet = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnTemizle = new Button();
            panel1 = new Panel();
            label4 = new Label();
            txtAramaOda = new TextBox();
            pnlUstOda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOdalar).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUstOda
            // 
            pnlUstOda.BackColor = Color.SteelBlue;
            pnlUstOda.Controls.Add(btnGeriDon);
            pnlUstOda.Controls.Add(lblOdalar);
            pnlUstOda.Dock = DockStyle.Top;
            pnlUstOda.Location = new Point(0, 0);
            pnlUstOda.Name = "pnlUstOda";
            pnlUstOda.Size = new Size(899, 70);
            pnlUstOda.TabIndex = 1;
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new Point(738, 38);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(137, 29);
            btnGeriDon.TabIndex = 3;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // lblOdalar
            // 
            lblOdalar.AutoSize = true;
            lblOdalar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblOdalar.ForeColor = Color.White;
            lblOdalar.Location = new Point(50, 20);
            lblOdalar.Name = "lblOdalar";
            lblOdalar.Size = new Size(130, 31);
            lblOdalar.TabIndex = 1;
            lblOdalar.Text = "Oda Listesi";
            // 
            // dgvOdalar
            // 
            dgvOdalar.BackgroundColor = Color.White;
            dgvOdalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOdalar.GridColor = SystemColors.Control;
            dgvOdalar.Location = new Point(344, 153);
            dgvOdalar.Name = "dgvOdalar";
            dgvOdalar.RowHeadersWidth = 51;
            dgvOdalar.Size = new Size(531, 329);
            dgvOdalar.TabIndex = 2;
            dgvOdalar.CellClick += dgvOdalar_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(txtOdaNo, 1, 0);
            tableLayoutPanel1.Controls.Add(txtFiyat, 1, 1);
            tableLayoutPanel1.Controls.Add(cmbDurum, 1, 2);
            tableLayoutPanel1.Location = new Point(50, 153);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(261, 135);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Oda No";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 57);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Fiyat";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 102);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 1;
            label2.Text = "Durum";
            // 
            // txtOdaNo
            // 
            txtOdaNo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtOdaNo.Location = new Point(70, 9);
            txtOdaNo.Name = "txtOdaNo";
            txtOdaNo.Size = new Size(188, 27);
            txtOdaNo.TabIndex = 3;
            // 
            // txtFiyat
            // 
            txtFiyat.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFiyat.Location = new Point(70, 54);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(188, 27);
            txtFiyat.TabIndex = 4;
            // 
            // cmbDurum
            // 
            cmbDurum.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbDurum.FormattingEnabled = true;
            cmbDurum.Location = new Point(70, 98);
            cmbDurum.Name = "cmbDurum";
            cmbDurum.Size = new Size(188, 28);
            cmbDurum.TabIndex = 5;
            // 
            // btnKaydet
            // 
            btnKaydet.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnKaydet.BackColor = Color.PowderBlue;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.Black;
            btnKaydet.Location = new Point(0, 3);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(258, 29);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSil.BackColor = Color.PowderBlue;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Location = new Point(0, 108);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(258, 29);
            btnSil.TabIndex = 11;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnGuncelle.BackColor = Color.PowderBlue;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(0, 38);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(258, 29);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnTemizle.BackColor = Color.PowderBlue;
            btnTemizle.FlatAppearance.BorderSize = 0;
            btnTemizle.FlatStyle = FlatStyle.Flat;
            btnTemizle.Location = new Point(0, 73);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(258, 29);
            btnTemizle.TabIndex = 10;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = false;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnKaydet);
            panel1.Controls.Add(btnTemizle);
            panel1.Controls.Add(btnSil);
            panel1.Controls.Add(btnGuncelle);
            panel1.Location = new Point(53, 338);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 144);
            panel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(357, 115);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 13;
            label4.Text = "Oda Arama";
            // 
            // txtAramaOda
            // 
            txtAramaOda.BackColor = SystemColors.Control;
            txtAramaOda.Location = new Point(498, 112);
            txtAramaOda.Name = "txtAramaOda";
            txtAramaOda.Size = new Size(137, 27);
            txtAramaOda.TabIndex = 14;
            txtAramaOda.TextChanged += txtAramaOda_TextChanged;
            // 
            // Odalar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtAramaOda);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(dgvOdalar);
            Controls.Add(pnlUstOda);
            Name = "Odalar";
            Size = new Size(899, 541);
            Load += Odalar_Load;
            pnlUstOda.ResumeLayout(false);
            pnlUstOda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOdalar).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlUstOda;
        private Label lblOdalar;
        private DataGridView dgvOdalar;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button btnGeriDon;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnTemizle;
        private Panel panel1;
        private TextBox txtOdaNo;
        private TextBox txtFiyat;
        private ComboBox cmbDurum;
        private Label label4;
        private TextBox txtAramaOda;
    }
}
