using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_bmiform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double h = double.Parse(txtH.Text);
            double w = double.Parse(txtW.Text);

            h /= 100;
            double bmi = w / (h * h);

             // .ToString()은 문자열로 바꾸어 준다
            lblBMI.Text = "BMI = " + bmi.ToString();

        }

        private void txtW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
