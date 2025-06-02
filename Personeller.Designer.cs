namespace OtelYonetimSistemi
{
    partial class Personeller
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
            pnlUstPer = new Panel();
            btnGeriDon = new Button();
            lblPersoneller = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtPersonelAd = new TextBox();
            txtPersonelSoyad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnKaydet = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            dgvPersonel = new DataGridView();
            label3 = new Label();
            txtPersonelArama = new TextBox();
            pnlUstPer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).BeginInit();
            SuspendLayout();
            // 
            // pnlUstPer
            // 
            pnlUstPer.BackColor = Color.SteelBlue;
            pnlUstPer.Controls.Add(btnGeriDon);
            pnlUstPer.Controls.Add(lblPersoneller);
            pnlUstPer.Dock = DockStyle.Top;
            pnlUstPer.Location = new Point(0, 0);
            pnlUstPer.Name = "pnlUstPer";
            pnlUstPer.Size = new Size(899, 70);
            pnlUstPer.TabIndex = 2;
            // 
            // btnGeriDon
            // 
            btnGeriDon.Location = new Point(719, 38);
            btnGeriDon.Name = "btnGeriDon";
            btnGeriDon.Size = new Size(137, 29);
            btnGeriDon.TabIndex = 4;
            btnGeriDon.Text = "Geri Dön";
            btnGeriDon.UseVisualStyleBackColor = true;
            btnGeriDon.Click += btnGeriDon_Click;
            // 
            // lblPersoneller
            // 
            lblPersoneller.AutoSize = true;
            lblPersoneller.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPersoneller.ForeColor = Color.White;
            lblPersoneller.Location = new Point(50, 20);
            lblPersoneller.Name = "lblPersoneller";
            lblPersoneller.Size = new Size(186, 31);
            lblPersoneller.TabIndex = 1;
            lblPersoneller.Text = "Personel Sayfası";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtPersonelAd, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPersonelSoyad, 1, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(61, 146);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(267, 128);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // txtPersonelAd
            // 
            txtPersonelAd.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPersonelAd.Location = new Point(118, 18);
            txtPersonelAd.Name = "txtPersonelAd";
            txtPersonelAd.Size = new Size(146, 27);
            txtPersonelAd.TabIndex = 0;
            // 
            // txtPersonelSoyad
            // 
            txtPersonelSoyad.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPersonelSoyad.Location = new Point(118, 82);
            txtPersonelSoyad.Name = "txtPersonelSoyad";
            txtPersonelSoyad.Size = new Size(146, 27);
            txtPersonelSoyad.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 2;
            label1.Text = "Personel Ad";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 86);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Personel Soyad";
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.PowderBlue;
            btnKaydet.FlatAppearance.BorderSize = 0;
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.ForeColor = Color.Black;
            btnKaydet.Location = new Point(64, 341);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(264, 29);
            btnKaydet.TabIndex = 9;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.PowderBlue;
            btnGuncelle.FlatAppearance.BorderSize = 0;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(64, 386);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(264, 29);
            btnGuncelle.TabIndex = 10;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.PowderBlue;
            btnSil.FlatAppearance.BorderSize = 0;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Location = new Point(64, 434);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(264, 29);
            btnSil.TabIndex = 12;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // dgvPersonel
            // 
            dgvPersonel.BackgroundColor = Color.White;
            dgvPersonel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonel.Location = new Point(377, 202);
            dgvPersonel.Name = "dgvPersonel";
            dgvPersonel.RowHeadersWidth = 51;
            dgvPersonel.Size = new Size(479, 261);
            dgvPersonel.TabIndex = 13;
            dgvPersonel.CellClick += dgvPersonel_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(377, 149);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 14;
            label3.Text = "Personel Arama";
            // 
            // txtPersonelArama
            // 
            txtPersonelArama.BackColor = SystemColors.Control;
            txtPersonelArama.Location = new Point(524, 146);
            txtPersonelArama.Name = "txtPersonelArama";
            txtPersonelArama.Size = new Size(137, 27);
            txtPersonelArama.TabIndex = 15;
            txtPersonelArama.TextChanged += txtPersonelArama_TextChanged;
            // 
            // Personeller
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtPersonelArama);
            Controls.Add(label3);
            Controls.Add(dgvPersonel);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnKaydet);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlUstPer);
            Name = "Personeller";
            Size = new Size(899, 541);
            Load += Personeller_Load;
            pnlUstPer.ResumeLayout(false);
            pnlUstPer.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlUstPer;
        private Label lblPersoneller;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtPersonelAd;
        private TextBox txtPersonelSoyad;
        private Label label1;
        private Label label2;
        private Button btnKaydet;
        private Button btnGuncelle;
        private Button btnSil;
        private DataGridView dgvPersonel;
        private Button btnGeriDon;
        private Label label3;
        private TextBox txtPersonelArama;
    }
}
