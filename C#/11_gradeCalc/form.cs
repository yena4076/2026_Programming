using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _012_gradeCalc
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double totalScore = 0; // 토탈점수(학점수*성적)
            int totalCredits = 0; // 토탈 학점수

            for (int i = 0; i < crds.Length; i++)
            {
                if (titles[i].Text != "")
                {
                    int crd = int.Parse(crds[i].Text);
                    totalCredits += crd;
                    totalScore += crd * GetGrade(grds[i].Text);
                }
                txtGrade.Text = (totalScore / totalCredits).ToString("0.00");
            }
        }
                

        // Form1이 로드될 떄 (프로그램이 시작될 때)
        private void Form1_Load(object sender, EventArgs e)
        {
            txt1.Text = "인체의 구조와 기능";
            txt2.Text = "설계및프로젝트심화";
            txt3.Text = "전기전자공학및실험";
            txt4.Text = "디지털기술입문";
            txt5.Text = "비주얼프로그래밍";
            txt6.Text = "기업가정신";
            txt7.Text = "생활속첨단과학";

            crds = new ComboBox[] { crd1, crd2, crd3, crd4, crd5, crd6, crd7 };
            grds = new ComboBox[] { grd1, grd2, grd3, grd4, grd5, grd6, grd7 };
            titles = new TextBox[] { txt1, txt2, txt3, txt4, txt5, txt6, txt7 };
            int[] arrCredit = { 1, 2, 3, 4, 5 };
            List<string> lstGrade = new List<string> { "A+", "A0", "B+", "B0", "C+", "C0", "D+", "D0", "F" };
            
            // 이중반복문으로 crd1,...crd7에 1,2,3,4,5를 Items로 등록
            foreach (var combo in crds)
            {
                foreach (var i in arrCredit)
                    combo.Items.Add(i);
                combo.SelectedIndex = 1;
            }
            // 성적 콤보박스에 A+부터 F까지를 등록
            foreach (var combo in grds)
            {
                foreach (var i in lstGrade)
                    combo.Items.Add(i);
            }
        }

        private double GetGrade(string text)
        {
            if (text == "A+") return 4.5;
            else if (text == "A0") return 4.0;
            else if (text == "B+") return 3.5;
            else if (text == "B0") return 3.0;
            else if (text == "C+") return 2.5;
            else if (text == "C0") return 2.0;
            else if (text == "D+") return 1.5;
            else if (text == "D0") return 1.0;
            else return 0;
        }
    }
}
