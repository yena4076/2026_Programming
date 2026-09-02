using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _005_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtI.Text;
            string ps = txtP.Text;

            if (id == "abcd" && ps == "1234") { txtL.Text = "로그인 성공"; }
            else { txtL.Text = "로그인 실패"; }
        }
    }
}
