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
    public partial class UyeOl : Form
    {
        public UyeOl()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KAYIT EKLENDİ");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void UyeOl_Load(object sender, EventArgs e)
        {

        }

        private void txtbox_ad_MouseEnter(object sender, EventArgs e)
        {
            if (txtbox_ad.Text == "Ad")
                txtbox_ad.Text = "";

        }

        private void txtbox_ad_MouseLeave(object sender, EventArgs e)
        {
            if (txtbox_ad.Text == "")
                txtbox_ad.Text = "Ad";
        }

        private void txtbox_soyad_MouseEnter(object sender, EventArgs e)
        {
            if (txtbox_soyad.Text == "Soyad")
                txtbox_soyad.Text = "";
        }

        private void txtbox_soyad_MouseLeave(object sender, EventArgs e)
        {
            if (txtbox_soyad.Text == "")
                txtbox_soyad.Text = "Soyad";
        }

        private void txtbox_eposta_MouseEnter(object sender, EventArgs e)
        {
            if (txtbox_eposta.Text == "E-posta")
                txtbox_eposta.Text = "";
        }

        private void txtbox_eposta_MouseLeave(object sender, EventArgs e)
        {
            if (txtbox_eposta.Text == "")
                txtbox_eposta.Text = "E-posta";
        }

        private void txtbox_sifre_MouseEnter(object sender, EventArgs e)
        {
            if (txtbox_sifre.Text == "Şifre")
                txtbox_sifre.Text = "";
        }

        private void txtbox_sifre_MouseLeave(object sender, EventArgs e)
        {
            if (txtbox_sifre.Text == "")
                txtbox_sifre.Text = "Şifre";

        }

        private void txtbox_dgko_MouseEnter(object sender, EventArgs e)
        {
            if (txtbox_dgko.Text == "Doğum Tarihi")
                txtbox_dgko.Text = "";
        }

        private void txtbox_dgko_MouseLeave(object sender, EventArgs e)
        {
            if (txtbox_dgko.Text == "")
                txtbox_dgko.Text = "Doğum Tarihi";
        }
    }
}
