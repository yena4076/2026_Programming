using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _016_susi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            txtMid.Text = "";
            txtFinal.Text = "";
            txtAsg.Text = "";
            txtResult.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mid = int.Parse(txtMid.Text);
            int final = int.Parse(txtFinal.Text);
            int asg = int.Parse(txtAsg.Text);

            int total = mid + final + asg;
            double avg = total / 3.0;
            string score;

            if (avg >= 90) score = "A";
            else if (avg >=80) score = "B";
            else if (avg >=70) score = "C";
            else if (avg >=60) score = "D";
            else score = "F";

            txtResult.Text = string.Format("학번: {0}\r\n이름: {1}\r\n총점: {2}\r\n평균: {3}\r\n학점: {4}",
                txtID.Text, txtName.Text, total, avg.ToString("0.00"), score);

            
        }
    }
}
