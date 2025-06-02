using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace OtelYonetimSistemi
{
    public partial class Rezervasyon : UserControl
    {
        private string connectionString = "Data Source=TURKER\\SQLEXPRESS;Initial Catalog = OtelYP; Integrated Security = True; Encrypt=False;Trust Server Certificate=True";
        private int selectedRezervasyonID = -1;
        public Rezervasyon()
        {
            InitializeComponent();

            this.Load += Rezervasyon_Load;


            dtpGirisTarihi.ValueChanged += new EventHandler(CalculateAndDisplayTotalAmount);
            dtpCikisTarihi.ValueChanged += new EventHandler(CalculateAndDisplayTotalAmount);
            cmbOda.SelectedIndexChanged += new EventHandler(CalculateAndDisplayTotalAmount);

           
            txtArama.TextChanged += new EventHandler(txtArama_TextChanged);
        }

        private void Rezervasyon_Load(object sender, EventArgs e)
        {
            LoadOdalar();
            LoadPersonel();
            LoadRezervasyonlar();
            ResetForm();
        }
        private void LoadRezervasyonlar()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    
                    string query = @"SELECT R.RezervasyonID, M.MusteriAd, M.MusteriSoyad,
                                            O.OdaNo, O.GecelikFiyat,
                                            P.PersonelAd, P.PersonelSoyad,
                                            R.GirisTarihi, R.CikisTarihi
                                     FROM Rezervasyon R
                                     INNER JOIN Musteri M ON R.MusteriID = M.MusteriID
                                     INNER JOIN Odalar O ON R.OdaID = O.OdaID
                                     LEFT JOIN Personel P ON R.PersonelID = P.PersonelID"; 

                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRezervasyonlar.DataSource = dt;

                    // DataGridView sütun başlıklarını düzenleme (isteğe bağlı)
                    dgvRezervasyonlar.Columns["RezervasyonID"].HeaderText = "Rez. No";
                    dgvRezervasyonlar.Columns["MusteriAd"].HeaderText = "Misafir Adı";
                    dgvRezervasyonlar.Columns["MusteriSoyad"].HeaderText = "Misafir Soyadı";
                    dgvRezervasyonlar.Columns["OdaNo"].HeaderText = "Oda No";
                    dgvRezervasyonlar.Columns["GecelikFiyat"].Visible = false; 
                    dgvRezervasyonlar.Columns["PersonelAd"].HeaderText = "Personel Adı";
                    dgvRezervasyonlar.Columns["PersonelSoyad"].HeaderText = "Personel Soyadı";
                    dgvRezervasyonlar.Columns["GirisTarihi"].HeaderText = "Giriş Tarihi";
                    dgvRezervasyonlar.Columns["CikisTarihi"].HeaderText = "Çıkış Tarihi";

                   
                    if (!dgvRezervasyonlar.Columns.Contains("ToplamTutar"))
                    {
                        DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                        col.Name = "ToplamTutar";
                        col.HeaderText = "Toplam Tutar";
                        col.ReadOnly = true; 
                        dgvRezervasyonlar.Columns.Add(col);
                    }

                    foreach (DataGridViewRow row in dgvRezervasyonlar.Rows)
                    {
                        if (row.Cells["GirisTarihi"].Value != DBNull.Value &&
                            row.Cells["CikisTarihi"].Value != DBNull.Value &&
                            row.Cells["GecelikFiyat"].Value != DBNull.Value)
                        {
                            DateTime giris = Convert.ToDateTime(row.Cells["GirisTarihi"].Value);
                            DateTime cikis = Convert.ToDateTime(row.Cells["CikisTarihi"].Value);
                            decimal gecelikFiyat = Convert.ToDecimal(row.Cells["GecelikFiyat"].Value);

                            TimeSpan kalisSuresi = cikis.Subtract(giris);
                            int gunSayisi = kalisSuresi.Days;
                            if (gunSayisi < 0) gunSayisi = 0; 
                            if (gunSayisi == 0 && giris.Date < cikis.Date) gunSayisi = 1; 

                            decimal toplamTutar = gecelikFiyat * gunSayisi;
                            row.Cells["ToplamTutar"].Value = toplamTutar.ToString("C2"); 
                        }
                        else
                        {
                            row.Cells["ToplamTutar"].Value = "N/A"; 
                        }
                    }

                    dgvRezervasyonlar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells); 

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rezervasyonlar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadOdalar()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT OdaID, OdaNo, GecelikFiyat, Durum FROM Odalar WHERE Durum = N'Boş' OR Durum = N'Müsait' "; 
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbOda.DataSource = dt;
                    cmbOda.DisplayMember = "OdaNo";
                    cmbOda.ValueMember = "OdaID";
                    cmbOda.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Odalar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadPersonel()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT PersonelID, PersonelAd + ' ' + PersonelSoyad AS AdSoyad FROM Personel";
                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbPersonel.DataSource = dt;
                    cmbPersonel.DisplayMember = "AdSoyad";
                    cmbPersonel.ValueMember = "PersonelID";
                    cmbPersonel.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personeller yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ResetForm()
        {
            txtMisafirAd.Text = string.Empty;
            txtMisafirSoyad.Text = string.Empty;
            cmbOda.SelectedIndex = -1;
            cmbPersonel.SelectedIndex = -1;
            dtpGirisTarihi.Value = DateTime.Now;
            dtpCikisTarihi.Value = DateTime.Now.AddDays(1); 
            lblToplamTutar.Text = "0,00 TL";
            selectedRezervasyonID = -1; 


            if (dgvRezervasyonlar.SelectedRows.Count > 0)
            {
                dgvRezervasyonlar.ClearSelection();
            }
        }
        private void CalculateAndDisplayTotalAmount(object sender, EventArgs e)
        {
            if (cmbOda.SelectedValue != null && dtpGirisTarihi.Value != null && dtpCikisTarihi.Value != null)
            {
                try
                {

                    DataRowView selectedOda = cmbOda.SelectedItem as DataRowView;
                    if (selectedOda != null)
                    {
                        decimal gecelikFiyat = Convert.ToDecimal(selectedOda["GecelikFiyat"]);
                        DateTime girisTarihi = dtpGirisTarihi.Value.Date;
                        DateTime cikisTarihi = dtpCikisTarihi.Value.Date;


                        TimeSpan kalisSuresi = cikisTarihi.Subtract(girisTarihi);
                        int gunSayisi = kalisSuresi.Days;

                        if (gunSayisi < 0)
                        {
                            lblToplamTutar.Text = "0,00 TL";
                            return; 
                        }
                        if (gunSayisi == 0 && girisTarihi == cikisTarihi) 
                        {
                            gunSayisi = 1;
                        }
                        else if (gunSayisi == 0 && girisTarihi < cikisTarihi) 
                        {
                            gunSayisi = 1; 
                        }

                        decimal toplamTutar = gecelikFiyat * gunSayisi;
                        lblToplamTutar.Text = toplamTutar.ToString("C2"); 
                    }
                    else
                    {
                        lblToplamTutar.Text = "0,00 TL"; 
                    }
                }
                catch (Exception ex)
                {
                    lblToplamTutar.Text = "Hata!";
                  
                }
            }
            else
            {
                lblToplamTutar.Text = "0,00 TL"; 
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtMisafirAd.Text) || string.IsNullOrWhiteSpace(txtMisafirSoyad.Text) ||
                cmbOda.SelectedValue == null || cmbPersonel.SelectedValue == null || dtpGirisTarihi.Value == null || dtpCikisTarihi.Value == null)
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurun: Misafir Ad, Soyad, Oda, Personel, Giriş/Çıkış Tarihi.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (dtpGirisTarihi.Value.Date > dtpCikisTarihi.Value.Date)
            {
                MessageBox.Show("Giriş tarihi, çıkış tarihinden sonra olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    int musteriID;
                    string checkMusteriQuery = "SELECT MusteriID FROM Musteri WHERE MusteriAd = @MusteriAd AND MusteriSoyad = @MusteriSoyad";
                    using (SqlCommand checkMusteriCmd = new SqlCommand(checkMusteriQuery, connection, transaction))
                    {
                        checkMusteriCmd.Parameters.AddWithValue("@MusteriAd", txtMisafirAd.Text.Trim());
                        checkMusteriCmd.Parameters.AddWithValue("@MusteriSoyad", txtMisafirSoyad.Text.Trim());
                        object result = checkMusteriCmd.ExecuteScalar();

                        if (result != null) 
                        {
                            musteriID = Convert.ToInt32(result);
                        }
                        else 
                        {
                            string insertMusteriQuery = "INSERT INTO Musteri (MusteriAd, MusteriSoyad) VALUES (@MusteriAd, @MusteriSoyad); SELECT SCOPE_IDENTITY();";
                            using (SqlCommand insertMusteriCmd = new SqlCommand(insertMusteriQuery, connection, transaction))
                            {
                                insertMusteriCmd.Parameters.AddWithValue("@MusteriAd", txtMisafirAd.Text.Trim());
                                insertMusteriCmd.Parameters.AddWithValue("@MusteriSoyad", txtMisafirSoyad.Text.Trim());
                                musteriID = Convert.ToInt32(insertMusteriCmd.ExecuteScalar()); 
                            }
                        }
                    }


                    string insertRezervasyonQuery = "INSERT INTO Rezervasyon (GirisTarihi, CikisTarihi, MusteriID, OdaID, PersonelID) VALUES (@GirisTarihi, @CikisTarihi, @MusteriID, @OdaID, @PersonelID)";
                    using (SqlCommand command = new SqlCommand(insertRezervasyonQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@GirisTarihi", dtpGirisTarihi.Value.Date);
                        command.Parameters.AddWithValue("@CikisTarihi", dtpCikisTarihi.Value.Date);
                        command.Parameters.AddWithValue("@MusteriID", musteriID);
                        command.Parameters.AddWithValue("@OdaID", Convert.ToInt32(cmbOda.SelectedValue));
                        command.Parameters.AddWithValue("@PersonelID", Convert.ToInt32(cmbPersonel.SelectedValue));

                        command.ExecuteNonQuery();
                    }


                    string updateOdaDurumQuery = "UPDATE Odalar SET Durum = N'Dolu' WHERE OdaID = @OdaID";
                    using (SqlCommand updateOdaCmd = new SqlCommand(updateOdaDurumQuery, connection, transaction))
                    {
                        updateOdaCmd.Parameters.AddWithValue("@OdaID", Convert.ToInt32(cmbOda.SelectedValue));
                        updateOdaCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Rezervasyon başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    LoadRezervasyonlar(); 
                    LoadOdalar();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Rezervasyon kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvRezervasyonlar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvRezervasyonlar.Rows[e.RowIndex];

                selectedRezervasyonID = Convert.ToInt32(row.Cells["RezervasyonID"].Value);

                txtMisafirAd.Text = row.Cells["MusteriAd"].Value.ToString();
                txtMisafirSoyad.Text = row.Cells["MusteriSoyad"].Value.ToString();


                cmbOda.SelectedValue = GetOdaIdByOdaNo(row.Cells["OdaNo"].Value.ToString());


                string personelAd = row.Cells["PersonelAd"].Value?.ToString() ?? ""; 
                string personelSoyad = row.Cells["PersonelSoyad"].Value?.ToString() ?? "";
                if (!string.IsNullOrEmpty(personelAd) || !string.IsNullOrEmpty(personelSoyad))
                {
                    cmbPersonel.SelectedValue = GetPersonelIdByAdSoyad(personelAd, personelSoyad);
                }
                else
                {
                    cmbPersonel.SelectedIndex = -1; 
                }

                dtpGirisTarihi.Value = Convert.ToDateTime(row.Cells["GirisTarihi"].Value);
                dtpCikisTarihi.Value = Convert.ToDateTime(row.Cells["CikisTarihi"].Value);

                CalculateAndDisplayTotalAmount(null, null); 
            }
        }

        private int? GetOdaIdByOdaNo(string odaNo)
        {
            if (cmbOda.DataSource != null)
            {
                DataTable dt = (DataTable)cmbOda.DataSource;
                DataRow[] rows = dt.Select($"OdaNo = '{odaNo}'");
                if (rows.Length > 0)
                {
                    return Convert.ToInt32(rows[0]["OdaID"]);
                }
            }
            return null;
        }


        private int? GetPersonelIdByAdSoyad(string personelAd, string personelSoyad)
        {
            if (cmbPersonel.DataSource != null)
            {
                DataTable dt = (DataTable)cmbPersonel.DataSource;

                foreach (DataRow row in dt.Rows)
                {
                    if (row["AdSoyad"].ToString() == (personelAd + " " + personelSoyad).Trim())
                    {
                        return Convert.ToInt32(row["PersonelID"]);
                    }
                }
            }
            return null;
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedRezervasyonID == -1)
            {
                MessageBox.Show("Lütfen güncellenecek bir rezervasyon seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMisafirAd.Text) || string.IsNullOrWhiteSpace(txtMisafirSoyad.Text) ||
                cmbOda.SelectedValue == null || cmbPersonel.SelectedValue == null || dtpGirisTarihi.Value == null || dtpCikisTarihi.Value == null)
            {
                MessageBox.Show("Lütfen tüm zorunlu alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpGirisTarihi.Value.Date > dtpCikisTarihi.Value.Date)
            {
                MessageBox.Show("Giriş tarihi, çıkış tarihinden sonra olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    int musteriID;
                    string checkMusteriQuery = "SELECT MusteriID FROM Musteri WHERE MusteriAd = @MusteriAd AND MusteriSoyad = @MusteriSoyad";
                    using (SqlCommand checkMusteriCmd = new SqlCommand(checkMusteriQuery, connection, transaction))
                    {
                        checkMusteriCmd.Parameters.AddWithValue("@MusteriAd", txtMisafirAd.Text.Trim());
                        checkMusteriCmd.Parameters.AddWithValue("@MusteriSoyad", txtMisafirSoyad.Text.Trim());
                        object result = checkMusteriCmd.ExecuteScalar();

                        if (result != null)
                        {
                            musteriID = Convert.ToInt32(result);
                        }
                        else 
                        {
                            string insertMusteriQuery = "INSERT INTO Musteri (MusteriAd, MusteriSoyad) VALUES (@MusteriAd, @MusteriSoyad); SELECT SCOPE_IDENTITY();";
                            using (SqlCommand insertMusteriCmd = new SqlCommand(insertMusteriQuery, connection, transaction))
                            {
                                insertMusteriCmd.Parameters.AddWithValue("@MusteriAd", txtMisafirAd.Text.Trim());
                                insertMusteriCmd.Parameters.AddWithValue("@MusteriSoyad", txtMisafirSoyad.Text.Trim());
                                musteriID = Convert.ToInt32(insertMusteriCmd.ExecuteScalar());
                            }
                        }
                    }


                    int oldOdaID = -1;
                    string getOldOdaIDQuery = "SELECT OdaID FROM Rezervasyon WHERE RezervasyonID = @RezervasyonID";
                    using (SqlCommand getOldOdaCmd = new SqlCommand(getOldOdaIDQuery, connection, transaction))
                    {
                        getOldOdaCmd.Parameters.AddWithValue("@RezervasyonID", selectedRezervasyonID);
                        object oldOdaResult = getOldOdaCmd.ExecuteScalar();
                        if (oldOdaResult != null)
                        {
                            oldOdaID = Convert.ToInt32(oldOdaResult);
                        }
                    }


                    string updateQuery = @"UPDATE Rezervasyon SET 
                                            GirisTarihi = @GirisTarihi, 
                                            CikisTarihi = @CikisTarihi, 
                                            MusteriID = @MusteriID, 
                                            OdaID = @OdaID, 
                                            PersonelID = @PersonelID 
                                        WHERE RezervasyonID = @RezervasyonID";
                    using (SqlCommand command = new SqlCommand(updateQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@GirisTarihi", dtpGirisTarihi.Value.Date);
                        command.Parameters.AddWithValue("@CikisTarihi", dtpCikisTarihi.Value.Date);
                        command.Parameters.AddWithValue("@MusteriID", musteriID);
                        command.Parameters.AddWithValue("@OdaID", Convert.ToInt32(cmbOda.SelectedValue));
                        command.Parameters.AddWithValue("@PersonelID", Convert.ToInt32(cmbPersonel.SelectedValue));
                        command.Parameters.AddWithValue("@RezervasyonID", selectedRezervasyonID);

                        command.ExecuteNonQuery();
                    }

                    if (oldOdaID != -1 && oldOdaID != Convert.ToInt32(cmbOda.SelectedValue))
                    {
                        string updateOldOdaQuery = "UPDATE Odalar SET Durum = N'Boş' WHERE OdaID = @OldOdaID";
                        using (SqlCommand updateOldOdaCmd = new SqlCommand(updateOldOdaQuery, connection, transaction))
                        {
                            updateOldOdaCmd.Parameters.AddWithValue("@OldOdaID", oldOdaID);
                            updateOldOdaCmd.ExecuteNonQuery();
                        }
                    }

                    string updateNewOdaQuery = "UPDATE Odalar SET Durum = N'Dolu' WHERE OdaID = @NewOdaID";
                    using (SqlCommand updateNewOdaCmd = new SqlCommand(updateNewOdaQuery, connection, transaction))
                    {
                        updateNewOdaCmd.Parameters.AddWithValue("@NewOdaID", Convert.ToInt32(cmbOda.SelectedValue));
                        updateNewOdaCmd.ExecuteNonQuery();
                    }


                    transaction.Commit();
                    MessageBox.Show("Rezervasyon başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    LoadRezervasyonlar();
                    LoadOdalar();
                    selectedRezervasyonID = -1;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Rezervasyon güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedRezervasyonID == -1)
            {
                MessageBox.Show("Lütfen silinecek bir rezervasyon seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show("Seçilen rezervasyonu silmek istediğinizden emin misiniz? Bu işlem geri alınamaz.", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No)
            {
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {

                    int odaIDToFree = -1;
                    string getOdaIdQuery = "SELECT OdaID FROM Rezervasyon WHERE RezervasyonID = @RezervasyonID";
                    using (SqlCommand getOdaCmd = new SqlCommand(getOdaIdQuery, connection, transaction))
                    {
                        getOdaCmd.Parameters.AddWithValue("@RezervasyonID", selectedRezervasyonID);
                        object result = getOdaCmd.ExecuteScalar();
                        if (result != null)
                        {
                            odaIDToFree = Convert.ToInt32(result);
                        }
                    }


                    string deleteQuery = "DELETE FROM Rezervasyon WHERE RezervasyonID = @RezervasyonID";
                    using (SqlCommand command = new SqlCommand(deleteQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@RezervasyonID", selectedRezervasyonID);
                        int affectedRows = command.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {

                            if (odaIDToFree != -1)
                            {
                                string updateOdaDurumQuery = "UPDATE Odalar SET Durum = N'Boş' WHERE OdaID = @OdaID";
                                using (SqlCommand updateOdaCmd = new SqlCommand(updateOdaDurumQuery, connection, transaction))
                                {
                                    updateOdaCmd.Parameters.AddWithValue("@OdaID", odaIDToFree);
                                    updateOdaCmd.ExecuteNonQuery();
                                }
                            }
                            transaction.Commit();
                            MessageBox.Show("Rezervasyon başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ResetForm();
                            LoadRezervasyonlar();
                            LoadOdalar();
                            selectedRezervasyonID = -1;
                        }
                        else
                        {
                            transaction.Rollback();
                            MessageBox.Show("Rezervasyon silinemedi veya bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Rezervasyon silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            string aramaMetni = txtArama.Text.Trim();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"SELECT R.RezervasyonID, M.MusteriAd, M.MusteriSoyad,
                                            O.OdaNo, O.GecelikFiyat,
                                            P.PersonelAd, P.PersonelSoyad,
                                            R.GirisTarihi, R.CikisTarihi
                                     FROM Rezervasyon R
                                     INNER JOIN Musteri M ON R.MusteriID = M.MusteriID
                                     INNER JOIN Odalar O ON R.OdaID = O.OdaID
                                     LEFT JOIN Personel P ON R.PersonelID = P.PersonelID
                                     WHERE M.MusteriAd LIKE @SearchTerm OR M.MusteriSoyad LIKE @SearchTerm 
                                        OR O.OdaNo LIKE @SearchTerm OR CONCAT(M.MusteriAd, ' ', M.MusteriSoyad) LIKE @SearchTerm"; // Hem tek tek hem de tam isimle arama

                    SqlDataAdapter da = new SqlDataAdapter(query, connection);
                    da.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + aramaMetni + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRezervasyonlar.DataSource = dt;
                    if (dgvRezervasyonlar.Columns.Contains("ToplamTutar"))
                    {
                        foreach (DataGridViewRow row in dgvRezervasyonlar.Rows)
                        {
                            if (row.Cells["GirisTarihi"].Value != DBNull.Value &&
                                row.Cells["CikisTarihi"].Value != DBNull.Value &&
                                row.Cells["GecelikFiyat"].Value != DBNull.Value)
                            {
                                DateTime giris = Convert.ToDateTime(row.Cells["GirisTarihi"].Value);
                                DateTime cikis = Convert.ToDateTime(row.Cells["CikisTarihi"].Value);
                                decimal gecelikFiyat = Convert.ToDecimal(row.Cells["GecelikFiyat"].Value);

                                TimeSpan kalisSuresi = cikis.Subtract(giris);
                                int gunSayisi = kalisSuresi.Days;
                                if (gunSayisi < 0) gunSayisi = 0;
                                if (gunSayisi == 0 && giris.Date < cikis.Date) gunSayisi = 1;

                                decimal toplamTutar = gecelikFiyat * gunSayisi;
                                row.Cells["ToplamTutar"].Value = toplamTutar.ToString("C2");
                            }
                            else
                            {
                                row.Cells["ToplamTutar"].Value = "N/A";
                            }
                        }
                    }
                    dgvRezervasyonlar.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rezervasyon aranırken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Form1 parentForm = this.ParentForm as Form1;
            if (parentForm != null)
            {
                parentForm.GoToHomePage();
            }
        }
    }
}
