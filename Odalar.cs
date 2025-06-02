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
    public partial class Odalar : UserControl
    {
        private string connectionString = "Data Source=TURKER\\SQLEXPRESS;Initial Catalog = OtelYP; Integrated Security = True; Encrypt=False;Trust Server Certificate=True";
        private int selectedOdaID = 0;
        public Odalar()
        {
            InitializeComponent();
        }

        private void Odalar_Load(object sender, EventArgs e)
        {
            LoadOdalar();
            DuzenleDurumComboBox();
            TemizleGirdiler();
        }
        private void DuzenleDurumComboBox()
        {
            cmbDurum.Items.Clear();
            cmbDurum.Items.Add("Boş");
            cmbDurum.Items.Add("Dolu");
            cmbDurum.SelectedIndex = -1;
        }
        private void LoadOdalar(string aramaMetni = null)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT OdaID, OdaNo, GecelikFiyat, Durum FROM Odalar";

                    if (!string.IsNullOrEmpty(aramaMetni))
                    {
                        query += " WHERE OdaNo LIKE @AramaMetni";
                    }
                    query += " ORDER BY OdaNo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(aramaMetni))
                        {
                            cmd.Parameters.AddWithValue("@AramaMetni", "%" + aramaMetni + "%");
                        }

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvOdalar.DataSource = dt;

                        if (dgvOdalar.Columns["OdaID"] != null) dgvOdalar.Columns["OdaID"].HeaderText = "ID";
                        if (dgvOdalar.Columns["OdaNo"] != null) dgvOdalar.Columns["OdaNo"].HeaderText = "Oda No";
                        if (dgvOdalar.Columns["GecelikFiyat"] != null) dgvOdalar.Columns["GecelikFiyat"].HeaderText = "Fiyat";
                        if (dgvOdalar.Columns["Durum"] != null) dgvOdalar.Columns["Durum"].HeaderText = "Durum";


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Odalar yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TemizleGirdiler()
        {
            txtOdaNo.Clear();
            txtFiyat.Clear();
            cmbDurum.SelectedIndex = -1;
            txtAramaOda.Clear();
            selectedOdaID = 0;
            dgvOdalar.ClearSelection();
            btnKaydet.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOdaNo.Text) ||
                string.IsNullOrWhiteSpace(txtFiyat.Text) ||
                cmbDurum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Fiyat geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM dbo.Odalar WHERE OdaNo = @OdaNo";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@OdaNo", txtOdaNo.Text.Trim());
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Bu oda numarası zaten kayıtlı. Lütfen farklı bir oda numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }


                    string query = "INSERT INTO dbo.Odalar (OdaNo, GecelikFiyat, Durum) VALUES (@OdaNo, @GecelikFiyat, @Durum)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OdaNo", txtOdaNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@GecelikFiyat", fiyat);
                        cmd.Parameters.AddWithValue("@Durum", cmbDurum.SelectedItem.ToString());

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Oda başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                LoadOdalar();
                TemizleGirdiler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda kaydedilirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (selectedOdaID == 0)
            {
                MessageBox.Show("Lütfen güncellemek için bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtOdaNo.Text) ||
                string.IsNullOrWhiteSpace(txtFiyat.Text) ||
                cmbDurum.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtFiyat.Text, out decimal fiyat))
            {
                MessageBox.Show("Fiyat geçerli bir sayı olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string checkQuery = "SELECT COUNT(*) FROM dbo.Odalar WHERE OdaNo = @OdaNo AND OdaID != @OdaID";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@OdaNo", txtOdaNo.Text.Trim());
                        checkCmd.Parameters.AddWithValue("@OdaID", selectedOdaID);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Bu oda numarası başka bir oda için zaten kayıtlı. Lütfen farklı bir oda numarası girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    string query = "UPDATE dbo.Odalar SET OdaNo = @OdaNo, GecelikFiyat = @GecelikFiyat, Durum = @Durum WHERE OdaID = @OdaID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@OdaNo", txtOdaNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@GecelikFiyat", fiyat);
                        cmd.Parameters.AddWithValue("@Durum", cmbDurum.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@OdaID", selectedOdaID);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Oda başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Oda güncellenemedi. Kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                LoadOdalar();
                TemizleGirdiler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oda güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (selectedOdaID == 0)
            {
                MessageBox.Show("Lütfen silmek için bir oda seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Bu odayı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string query = "DELETE FROM Odalar WHERE OdaID = @OdaID";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@OdaID", selectedOdaID);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Oda başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Oda silinemedi. Kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    LoadOdalar();
                    TemizleGirdiler();
                }
                catch (SqlException sqlEx) 
                {
                    if (sqlEx.Number == 547)
                    {
                        MessageBox.Show("Bu oda bir veya daha fazla rezervasyonla ilişkili olduğu için silinemez. Önce ilgili rezervasyonları silin veya değiştirin.", "Silme Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Oda silinirken bir veritabanı hatası oluştu: " + sqlEx.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oda silinirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            TemizleGirdiler();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Form1 parentForm = this.ParentForm as Form1;
            if (parentForm != null)
            {
                parentForm.GoToHomePage();
            }
        }

        private void dgvOdalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvOdalar.Rows.Count - 1)
            {
                DataGridViewRow row = dgvOdalar.Rows[e.RowIndex];
                if (row.Cells["OdaID"].Value != null && row.Cells["OdaID"].Value != DBNull.Value)
                {
                    selectedOdaID = Convert.ToInt32(row.Cells["OdaID"].Value);
                    txtOdaNo.Text = row.Cells["OdaNo"].Value?.ToString();
                    txtFiyat.Text = row.Cells["GecelikFiyat"].Value?.ToString();
                    cmbDurum.SelectedItem = row.Cells["Durum"].Value?.ToString();

                    btnKaydet.Enabled = false; 
                    btnGuncelle.Enabled = true; 
                    btnSil.Enabled = true;   
                }
            }
        }

        private void txtAramaOda_TextChanged(object sender, EventArgs e)
        {
            LoadOdalar(txtAramaOda.Text.Trim());
        }
    }
}
