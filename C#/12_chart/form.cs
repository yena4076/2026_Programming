using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _013_chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.Titles.Add("성적");

            chart1.Series[0].Points.Add(123);
            chart1.Series[0].Points.Add(353);
            chart1.Series[0].Points.Add(270);
            chart1.Series[0].Points.Add(875);
            chart1.Series[0].Points.Add(550);

            for (int i = 0; i < 5; i++)
                chart1.Series[0].Points.Add((i+1) * 100);

        }
    }
}
