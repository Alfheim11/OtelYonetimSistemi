namespace OtelYonetimSistemi
{
    partial class Form1
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
            pnlUst = new Panel();
            pnlOYS = new Label();
            btnRezervasyon = new Button();
            btnOdalar = new Button();
            btnMisafirler = new Button();
            btnCikis = new Button();
            pnlAnaSayfa = new Panel();
            btnPersonel = new Button();
            pnlUst.SuspendLayout();
            pnlAnaSayfa.SuspendLayout();
            SuspendLayout();
            // 
            // pnlUst
            // 
            pnlUst.BackColor = Color.SteelBlue;
            pnlUst.Controls.Add(pnlOYS);
            pnlUst.Dock = DockStyle.Top;
            pnlUst.Location = new Point(0, 0);
            pnlUst.Name = "pnlUst";
            pnlUst.Size = new Size(899, 74);
            pnlUst.TabIndex = 0;
            // 
            // pnlOYS
            // 
            pnlOYS.AutoSize = true;
            pnlOYS.BackColor = Color.SteelBlue;
            pnlOYS.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            pnlOYS.ForeColor = Color.White;
            pnlOYS.Location = new Point(50, 20);
            pnlOYS.Name = "pnlOYS";
            pnlOYS.Size = new Size(239, 31);
            pnlOYS.TabIndex = 1;
            pnlOYS.Text = "Otel Yönetim Sistemi";
            // 
            // btnRezervasyon
            // 
            btnRezervasyon.BackColor = Color.PowderBlue;
            btnRezervasyon.Cursor = Cursors.Hand;
            btnRezervasyon.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRezervasyon.Location = new Point(156, 175);
            btnRezervasyon.Name = "btnRezervasyon";
            btnRezervasyon.Size = new Size(150, 100);
            btnRezervasyon.TabIndex = 1;
            btnRezervasyon.Text = "Rezervasyon";
            btnRezervasyon.UseVisualStyleBackColor = false;
            btnRezervasyon.Click += btnRezervasyon_Click;
            // 
            // btnOdalar
            // 
            btnOdalar.BackColor = Color.PowderBlue;
            btnOdalar.Cursor = Cursors.Hand;
            btnOdalar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnOdalar.Location = new Point(357, 175);
            btnOdalar.Name = "btnOdalar";
            btnOdalar.Size = new Size(150, 100);
            btnOdalar.TabIndex = 2;
            btnOdalar.Text = "Odalar";
            btnOdalar.UseVisualStyleBackColor = false;
            btnOdalar.Click += btnOdalar_Click;
            // 
            // btnMisafirler
            // 
            btnMisafirler.BackColor = Color.PowderBlue;
            btnMisafirler.Cursor = Cursors.Hand;
            btnMisafirler.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMisafirler.Location = new Point(579, 175);
            btnMisafirler.Name = "btnMisafirler";
            btnMisafirler.Size = new Size(150, 100);
            btnMisafirler.TabIndex = 3;
            btnMisafirler.Text = "Müşteriler";
            btnMisafirler.UseVisualStyleBackColor = false;
            btnMisafirler.Click += btnMisafirler_Click;
            // 
            // btnCikis
            // 
            btnCikis.BackColor = Color.PowderBlue;
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnCikis.Location = new Point(472, 343);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(150, 100);
            btnCikis.TabIndex = 5;
            btnCikis.Text = "Çıkış";
            btnCikis.UseVisualStyleBackColor = false;
            btnCikis.Click += btnCikis_Click;
            // 
            // pnlAnaSayfa
            // 
            pnlAnaSayfa.BackColor = Color.White;
            pnlAnaSayfa.Controls.Add(btnPersonel);
            pnlAnaSayfa.Controls.Add(pnlUst);
            pnlAnaSayfa.Controls.Add(btnCikis);
            pnlAnaSayfa.Controls.Add(btnOdalar);
            pnlAnaSayfa.Controls.Add(btnRezervasyon);
            pnlAnaSayfa.Controls.Add(btnMisafirler);
            pnlAnaSayfa.Dock = DockStyle.Fill;
            pnlAnaSayfa.Location = new Point(0, 0);
            pnlAnaSayfa.Name = "pnlAnaSayfa";
            pnlAnaSayfa.Size = new Size(899, 553);
            pnlAnaSayfa.TabIndex = 6;
            // 
            // btnPersonel
            // 
            btnPersonel.BackColor = Color.PowderBlue;
            btnPersonel.Cursor = Cursors.Hand;
            btnPersonel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnPersonel.Location = new Point(250, 343);
            btnPersonel.Name = "btnPersonel";
            btnPersonel.Size = new Size(150, 100);
            btnPersonel.TabIndex = 6;
            btnPersonel.Text = "Personeller";
            btnPersonel.UseVisualStyleBackColor = false;
            btnPersonel.Click += btnPersonel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 553);
            Controls.Add(pnlAnaSayfa);
            Name = "Form1";
            Text = "Ana Menü";
            pnlUst.ResumeLayout(false);
            pnlUst.PerformLayout();
            pnlAnaSayfa.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlUst;
        private Label pnlOYS;
        private Button btnRezervasyon;
        private Button btnOdalar;
        private Button btnMisafirler;
        private Button btnCikis;
        private Panel pnlAnaSayfa;
        private Button btnPersonel;
    }
}
