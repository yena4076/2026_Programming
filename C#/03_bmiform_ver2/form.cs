using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _004_BMI
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
            string bmi2 = "";

            h /= 100;
            double bmi = w / (h * h);
            if (bmi < 20) { bmi2 = "저체중"; pictureBox1.BackColor = Color.Blue; }
            else if (bmi >=20 && bmi<25) { bmi2 = "정상체중"; pictureBox1.BackColor = Color.Green; }
            else if (bmi >= 25 && bmi < 30) { bmi2 = "경도비만"; pictureBox1.BackColor = Color.Yellow; }
            else if (bmi >= 30 && bmi < 40) { bmi2 = "비만"; pictureBox1.BackColor = Color.Orange; }
            else if (bmi >= 40) { bmi2 = "고도비만"; pictureBox1.BackColor = Color.Red; }

            // .ToString()은 문자열로 바꾸어 준다
            lblBMI.Text = "BMI = " + bmi.ToString("F1");
            lblBMI2.Text = "판정 : " + bmi2;
        }
    }
}
