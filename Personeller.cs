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
    public partial class Personeller : UserControl
    {
        private string connectionString = "Data Source=TURKER\\SQLEXPRESS;Initial Catalog = OtelYP; Integrated Security = True; Encrypt=False;Trust Server Certificate=True";
        private int selectedPersonelID = -1;
        public Personeller()
        {
            InitializeComponent();
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            LoadPersonel();
            TemizleGirdiler();
        }
        private void LoadPersonel(string aramaMetni = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT PersonelID, PersonelAd, PersonelSoyad FROM dbo.Personel";

                    if (!string.IsNullOrEmpty(aramaMetni))
                    {

                        query += " WHERE PersonelAd LIKE @AramaMetni OR PersonelSoyad LIKE @AramaMetni";
                    }
                    query += " ORDER BY PersonelAd, PersonelSoyad";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(aramaMetni))
                        {
                            cmd.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvPersonel.DataSource = dt;


                        if (dgvPersonel.Columns["PersonelID"] != null)
                        {
                            dgvPersonel.Columns["PersonelID"].Visible = false;
                        }
                        if (dgvPersonel.Columns["PersonelAd"] != null)
                        {
                            dgvPersonel.Columns["PersonelAd"].HeaderText = "Personel Adı";
                            dgvPersonel.Columns["PersonelAd"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                        if (dgvPersonel.Columns["PersonelSoyad"] != null)
                        {
                            dgvPersonel.Columns["PersonelSoyad"].HeaderText = "Personel Soyadı";
                            dgvPersonel.Columns["PersonelSoyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel listesi yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TemizleGirdiler()
        {
            txtPersonelAd.Clear();
            txtPersonelSoyad.Clear();
            txtPersonelArama.Clear();
            selectedPersonelID = 0;
            if (dgvPersonel.DataSource != null)
            {
                dgvPersonel.ClearSelection();
            }
            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPersonelAd.Text) ||
               string.IsNullOrWhiteSpace(txtPersonelSoyad.Text))
            {
                MessageBox.Show("Personel adı ve soyadı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                  

                    string query = "INSERT INTO dbo.Personel (PersonelAd, PersonelSoyad) VALUES (@PersonelAd, @PersonelSoyad)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonelAd", txtPersonelAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@PersonelSoyad", txtPersonelSoyad.Text.Trim());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Personel başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadPersonel();
                TemizleGirdiler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedPersonelID == 0)
            {
                MessageBox.Show("Lütfen güncellemek için bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPersonelAd.Text) ||
                string.IsNullOrWhiteSpace(txtPersonelSoyad.Text))
            {
                MessageBox.Show("Personel adı ve soyadı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE dbo.Personel SET PersonelAd = @PersonelAd, PersonelSoyad = @PersonelSoyad WHERE PersonelID = @PersonelID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@PersonelAd", txtPersonelAd.Text.Trim());
                        cmd.Parameters.AddWithValue("@PersonelSoyad", txtPersonelSoyad.Text.Trim());
                        cmd.Parameters.AddWithValue("@PersonelID", selectedPersonelID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Personel bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Personel güncellenemedi. Kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                LoadPersonel();
                TemizleGirdiler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Personel güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedPersonelID == 0)
            {
                MessageBox.Show("Lütfen silmek için bir personel seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bu personeli silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        
                        string query = "DELETE FROM dbo.Personel WHERE PersonelID = @PersonelID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@PersonelID", selectedPersonelID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Personel başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Personel silinemedi. Kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    LoadPersonel();
                    TemizleGirdiler();
                }
                catch (SqlException sqlEx) 
                {
                    if (sqlEx.Number == 547) 
                    {
                        MessageBox.Show("Bu personel bir veya daha fazla kayıtla (örn: rezervasyon) ilişkili olduğu için silinemez. Önce ilgili kayıtları silin veya değiştirin.", "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Personel silinirken bir veritabanı hatası oluştu: " + sqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Personel silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtPersonelArama_TextChanged(object sender, EventArgs e)
        {
            LoadPersonel(txtPersonelArama.Text.Trim());
        }

        private void dgvPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < dgvPersonel.Rows.Count && dgvPersonel.Rows[e.RowIndex].Cells["PersonelID"].Value != null)
            {
                DataGridViewRow row = dgvPersonel.Rows[e.RowIndex];

               
                if (row.Cells["PersonelID"].Value != DBNull.Value)
                {
                    selectedPersonelID = Convert.ToInt32(row.Cells["PersonelID"].Value);
                    txtPersonelAd.Text = row.Cells["PersonelAd"].Value?.ToString();
                    txtPersonelSoyad.Text = row.Cells["PersonelSoyad"].Value?.ToString();

                    btnKaydet.Enabled = false;
                    btnGuncelle.Enabled = true;
                    btnSil.Enabled = true;
                }
            }
        }
    }
}
