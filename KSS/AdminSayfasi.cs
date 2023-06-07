using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSS
{
    public partial class AdminSayfasi : Form
    {
        public AdminSayfasi()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

         // Veritabanı bağlantısı oluşturun
            string connString = "Server=postgresql;Port=5432;User Id=melih;Password=melih;Database=KSS;";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();

            // SQL sorgunuzu yazın ve sonuçları bir DataTable'a yükleyin
            string query = "SELECT * FROM uyeler";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // DataGridView bileşenine verileri yükleyin
            dataGridView1.DataSource = dt;

            // Bağlantıyı kapatın
            conn.Close();

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            // Seçilen satırı DataGridView'den alın
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Veritabanı bağlantısı oluşturun
            string connString = "Server=SERVER_NAME;Port=5432;User Id=user;Password=PASSWORD;Database=DATABASE_NAME;";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();

            // SQL sorgunuzu yazın ve sonuçları bir DataTable'a yükleyin
            string query = "DELETE FROM uyeler WHERE id = @id";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", selectedRow.Cells["id"].Value);
            cmd.ExecuteNonQuery();

            // DataGridView bileşeninden seçilen satırı kaldırın
            dataGridView1.Rows.Remove(selectedRow);

            // Bağlantıyı kapatın
            conn.Close();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }
    }
}
