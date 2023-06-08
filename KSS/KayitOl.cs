using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSS
{
    public partial class KayitOl : Form
    {
        private string _connectionString = "Server=localhost;Port=5432;User Id=user;Password=pass;Database=kss;";

        public KayitOl()
        {
        }

        public KayitOl(string connectionString)
        {
            InitializeComponent();
            Contract.Requires(!string.IsNullOrEmpty(connectionString), "Veritabanı bağlantı dizesi null ya da boş olamaz.");
           
            _connectionString = connectionString;
        }
        public void Kaydet(string kullaniciAdi, string tcKimlikNo, string sifre, string isim, string soyisim, DateTime dogumTarihi)
        {

            Contract.Requires(!string.IsNullOrEmpty(kullaniciAdi), "Kullanıcı adı null ya da boş olamaz.");
            Contract.Requires(!string.IsNullOrEmpty(tcKimlikNo), "TC kimlik numarası null ya da boş olamaz.");
            Contract.Requires(!string.IsNullOrEmpty(sifre), "Şifre null ya da boş olamaz.");
            Contract.Requires(!string.IsNullOrEmpty(isim), "İsim null ya da boş olamaz.");
            Contract.Requires(!string.IsNullOrEmpty(soyisim), "Soyisim null ya da boş olamaz.");
            Contract.Requires(dogumTarihi != DateTime.MinValue, "Doğum tarihi geçersiz.");
        using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Kullanicilar WHERE TCKimlikNo =@TCKimlikNo";
        using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TCKimlikNo", tcKimlikNo);
                    int count = (int)command.ExecuteScalar();
                    if (count == 0)
                    {
                        query = "INSERT INTO Kullanicilar (KullaniciAdi, TCKimlikNo,Sifre, Isim, Soyisim, DogumTarihi) VALUES(@KullaniciAdi, @TCKimlikNo, @Sifre, @Isim,@Soyisim, @DogumTarihi)";
                    using (SqlCommand insertCommand = new SqlCommand(query, connection))
                        {
                            insertCommand.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                            insertCommand.Parameters.AddWithValue("@TCKimlikNo", tcKimlikNo);
                            insertCommand.Parameters.AddWithValue("@Sifre", sifre);
                            insertCommand.Parameters.AddWithValue("@Isim", isim);
                            insertCommand.Parameters.AddWithValue("@Soyisim", soyisim);
                            insertCommand.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                            insertCommand.ExecuteNonQuery();

                        }
                    }
                    else
                    {
                        throw new Exception("Bu TC kimlik numarasına sahip bir kullanıcı zaten kayıtlı.");
                    }
                }
            }
        }


        private void KayitOl_Load(object sender, EventArgs e)
        {
            this.Opacity = 96;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = true;
        }

        private void KayitOl_MouseMove(object sender, MouseEventArgs e)
        {
            label2.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KAYIT EKLENDİ");
        }

        private void txtbox_ad_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
