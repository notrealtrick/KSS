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
    }
}
