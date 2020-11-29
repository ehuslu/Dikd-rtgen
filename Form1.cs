using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dikdortgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dikdortgen dd = new Dikdortgen();
            dd.Kisa = Convert.ToInt32(txtKisa.Text);
            dd.Uzun = Convert.ToInt32(txtUzun.Text);
            lblAlan.Text = "Alan :" + dd.Alan();
            lblCevre.Text = "Çevre" + dd.Cevre();
        }
    }
}
