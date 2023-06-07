using Npgsql;
using System;
using System.Collections;
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
    public partial class Ilanlar : Form
    {
        public Ilanlar()
        {
            InitializeComponent();
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void Ilanlar_Load(object sender, EventArgs e)
        {
            

        }
        public void Baslangic()
        {
           
                UC_Ilanlar uc = new UC_Ilanlar();
                uc.button1.Click += T1_Click;
                uc.Dock = DockStyle.Top;
                panel1.Controls.Add(uc);
            
        }
        private void T1_Click(object sender,EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string connstring = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=mydb;";
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            string sql = "SELECT ilanbaslik FROM ilanlar";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                string ilanid = row.Cells["ilanid"].Value.ToString();
                string sahipid = row.Cells["sahipid"].Value.ToString();
                string ilanbaslik = row.Cells["ilanbaslik"].Value.ToString();
                string ilanaciklama = row.Cells["ilanaciklama"].Value.ToString();
                string ilanfiyat = row.Cells["ilanfiyat"].Value.ToString();
                string ilanturu = row.Cells["ilanturu"].Value.ToString();
                string ilantarihi = row.Cells["ilantarihi"].Value.ToString();
                string pasifaktif = row.Cells["pasifaktif"].Value.ToString();
                // diğer verileri de burada string olarak tutabilirsiniz
            }
        }


        private void label_ilanbaslik_Click(object sender, EventArgs e)
        {
            //label_ilanbaslik.Text = ilanbaslik;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string kelime = bunifuMaterialTextbox1.Text;

            string connstring = "Server=localhost;Port=5432;User Id=postgres;Password=1234;Database=mydb;";
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            string sql = "SELECT ilanbaslik FROM ilanlar WHERE ilanbaslik= %@arama% ";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@arama", kelime);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
