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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uyeol_Click(object sender, EventArgs e)
        {
            KayitOl frm1 = new KayitOl();
            frm1.Show();
            this.Hide();
        }

        private void giris_Click(object sender, EventArgs e)
        {
            KullaniciSayfasi frm1= new KullaniciSayfasi();
            frm1.Show();
            this.Hide();
        }
    }
}
