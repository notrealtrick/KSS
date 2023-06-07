using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            UyeleriGetir();
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

<<<<<<< HEAD
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AdminGuncelle A = new AdminGuncelle();
            A.Show();
            this.Hide();
=======
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
   
        }
        void UyeleriGetir()
        {
            listView1.Items.Clear();
            int i = 0;
            try
            {
                // Veritabanı bağlantısı oluşturun
                string connString = "Server=SERVER_NAME;Port=5432;User Id=user;Password=PASSWORD;Database=DATABASE_NAME;";
                NpgsqlConnection conn = new NpgsqlConnection(connString);
                conn.Open();

                // SQL sorgunuzu yazın ve sonuçları bir DataTable'a yükleyin
                string query = "SELECT * FROM uyeler";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                /* while (true)
                {
                    listView1.Items.Addrd["TC"].ToString());
                    listView1.Items[i].SubItems.Add(rd["Adı"].ToString());
                    listView1.Items[i].SubItems.Add(rd["Soyadı"].ToString());
                    listView1.Items[i].SubItems.Add(rd["Cinsiyeti"].ToString());
                    listView1.Items[i].SubItems.Add(rd["BabaAdı"].ToString());
                    listView1.Items[i].SubItems.Add(rd["AnneAdı"].ToString());
                    i++;
                }*/
            }
            catch (Exception)
            {

            }
>>>>>>> f1736005f0af58a7d572caec38ca34d87a6c93f3
        }
    }
}
