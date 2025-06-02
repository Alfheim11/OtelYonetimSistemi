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
    public partial class Misafirler : UserControl
    {
        private string connectionString = "Data Source=TURKER\\SQLEXPRESS;Initial Catalog = OtelYP; Integrated Security = True; Encrypt=False;Trust Server Certificate=True";
        private int selectedMusteriID = -1;
        public Misafirler()
        {
            InitializeComponent();
        }

        private void Misafirler_Load(object sender, EventArgs e)
        {
            LoadMusteriler();
            DuzenlecmbOda();
            TemizleGirdiler();
        }
        private void DuzenlecmbOda()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT OdaID, OdaNo FROM dbo.Odalar ORDER BY OdaNo";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbOda.DataSource = dt;
                    cmbOda.DisplayMember = "OdaNo";
                    cmbOda.ValueMember = "OdaID";
                    cmbOda.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odalar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMusteriler(string aramaMetni = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MusteriID, MusteriAd, MusteriSoyad FROM dbo.Musteri";

                    if (!string.IsNullOrEmpty(aramaMetni))
                    {
                        query += " WHERE MusteriAd LIKE @AramaMetni OR MusteriSoyad LIKE @AramaMetni";
                    }
                    query += " ORDER BY MusteriAd, MusteriSoyad";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(aramaMetni))
                        {
                            cmd.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvMusteriler.DataSource = dt;

                        if (dgvMusteriler.Columns["MusteriID"] != null)
                        {
                            dgvMusteriler.Columns["MusteriID"].Visible = false;
                        }
                        if (dgvMusteriler.Columns["MusteriAd"] != null)
                        {
                            dgvMusteriler.Columns["MusteriAd"].HeaderText = "Müşteri Adı";
                            dgvMusteriler.Columns["MusteriAd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                        if (dgvMusteriler.Columns["MusteriSoyad"] != null)
                        {
                            dgvMusteriler.Columns["MusteriSoyad"].HeaderText = "Müşteri Soyadı";
                            dgvMusteriler.Columns["MusteriSoyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri listesi yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TemizleGirdiler()
        {
            txtMusteriAd.Clear();
            txtMusteriSoyad.Clear();
            cmbOda.SelectedIndex = -1;
            txtMusteriArama.Clear();
            selectedMusteriID = 0;
            if (dgvMusteriler.DataSource != null) dgvMusteriler.ClearSelection();

            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteriAd.Text) ||
                string.IsNullOrWhiteSpace(txtMusteriSoyad.Text))
            {
                MessageBox.Show("Müşteri adı ve soyadı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                   
                    string query = "INSERT INTO dbo.Musteri (MusteriAd, MusteriSoyad) VALUES (@MusteriAd, @MusteriSoyad); SELECT SCOPE_IDENTITY();";
                   

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MusteriAd", txtMusteriAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@MusteriSoyad", txtMusteriSoyad.Text.Trim());


                        cmd.ExecuteNonQuery(); 
                        MessageBox.Show("Müşteri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadMusteriler();
                TemizleGirdiler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedMusteriID == 0)
            {
                MessageBox.Show("Lütfen güncellemek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMusteriAd.Text) ||
                string.IsNullOrWhiteSpace(txtMusteriSoyad.Text))
            {
                MessageBox.Show("Müşteri adı ve soyadı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE dbo.Musteri SET MusteriAd = @MusteriAd, MusteriSoyad = @MusteriSoyad WHERE MusteriID = @MusteriID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MusteriAd", txtMusteriAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@MusteriSoyad", txtMusteriSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@MusteriID", selectedMusteriID);

                       

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Müşteri bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Müşteri güncellenemedi. Kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                LoadMusteriler();
                TemizleGirdiler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TemizleGirdiler();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedMusteriID == 0)
            {
                MessageBox.Show("Lütfen silmek için bir müşteri seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bu müşteriyi silmek istediğinizden emin misiniz? Bu işlem müşteriye ait rezervasyonları etkileyebilir (eğer varsa).", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
 
                        string query = "DELETE FROM dbo.Musteri WHERE MusteriID = @MusteriID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@MusteriID", selectedMusteriID);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Müşteri başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Müşteri silinemedi. Kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    LoadMusteriler();
                    TemizleGirdiler();
                }
                catch (SqlException sqlEx)
                {
                    if (sqlEx.Number == 547) 
                    {
                        MessageBox.Show("Bu müşteri bir veya daha fazla kayıtla (örn: rezervasyon) ilişkili olduğu için silinemez. Önce ilgili kayıtları silin veya değiştirin.", "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Müşteri silinirken bir veritabanı hatası oluştu: " + sqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Müşteri silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtMusteriArama_TextChanged(object sender, EventArgs e)
        {
            LoadMusteriler(txtMusteriArama.Text.Trim());
        }

        private void dgvMusteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvMusteriler.Rows.Count && dgvMusteriler.Rows[e.RowIndex].Cells["MusteriID"].Value != null)
            {
                DataGridViewRow row = dgvMusteriler.Rows[e.RowIndex];
                if (row.Cells["MusteriID"].Value != DBNull.Value)
                {
                    selectedMusteriID = Convert.ToInt32(row.Cells["MusteriID"].Value);
                    txtMusteriAd.Text = row.Cells["MusteriAd"].Value?.ToString();
                    txtMusteriSoyad.Text = row.Cells["MusteriSoyad"].Value?.ToString();
                    btnKaydet.Enabled = false;
                    btnGuncelle.Enabled = true;
                    btnSil.Enabled = true;
                    SetSelectedCustomerRoom(selectedMusteriID);
                }
            }
        }
        private void SetSelectedCustomerRoom(int musteriId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    
                    string query = @"SELECT TOP 1 R.OdaID 
                                     FROM dbo.Rezervasyon R 
                                     WHERE R.MusteriID = @MusteriID 
                                     ORDER BY R.GirisTarihi DESC, R.RezervasyonID DESC"; 
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MusteriID", musteriId);
                        object odaIdResult = cmd.ExecuteScalar();
                        if (odaIdResult != null && odaIdResult != DBNull.Value)
                        {
                            cmbOda.SelectedValue = Convert.ToInt32(odaIdResult);
                        }
                        else
                        {
                            cmbOda.SelectedIndex = -1; 
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
                cmbOda.SelectedIndex = -1;
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
