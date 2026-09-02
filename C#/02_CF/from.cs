using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _003_CF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double C = double.Parse(Cbox.Text);
            double F;
            F = C * (9.0 / 5) + 32;
            Fbox.Text = F.ToString("F1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double F = double.Parse(Fbox.Text);
            double C;
            C = (F - 32) * (5 / 9.0);
            Cbox.Text = C.ToString("F1");
        }
    }
}
