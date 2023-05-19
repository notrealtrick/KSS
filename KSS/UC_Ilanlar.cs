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
    public partial class UC_Ilanlar : UserControl
    {
        public UC_Ilanlar()
        {
            InitializeComponent();
        }

        public static int S_ilan_No { get; set; }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UC_Ilanlar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            S_ilan_No = Convert.ToInt32(button1.Tag);
        }
    }
}
