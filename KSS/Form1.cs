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

        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 90;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = true;
        }

       

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        #region TXT
        private void grs_eposta_Enter(object sender, EventArgs e)
        {
            if (grs_eposta.Text == "eposta")
                grs_eposta.Text = "";

        }

        private void grs_eposta_Leave(object sender, EventArgs e)
        {
            if (grs_eposta.Text == "")
                grs_eposta.Text = "eposta";
        }

        private void grs_sifre_Enter(object sender, EventArgs e)
        {
            if (grs_sifre.Text == "sifre")
                grs_sifre.Text = "";

        }

        private void grs_sifre_Leave(object sender, EventArgs e)
        {
            if (grs_sifre.Text == "")
                grs_sifre.Text = "sifre";
        }

        
       
        bool move;
        int mouse_x;
        int mouse_y;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label3.Visible = false;
            if (move==true)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        #endregion

        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if(grs_eposta.Text =="admin" && grs_sifre.Text == "1234")
            {
                AdminSayfasi b = new AdminSayfasi();
                b.Show();
                this.Hide();
                
            }
            if (grs_eposta.Text == "kullanıcı" && grs_sifre.Text == "1111")
            {
                Ilanlar i = new Ilanlar();
                i.Show();
                this.Hide();
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            KayitOl a = new KayitOl();
            a.Show();
            this.Hide();
        }
    }
}
