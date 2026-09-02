// 파이어베이스를 사용하게 위한 using 3가지
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

using System;
using System.Data;
using System.Windows.Forms;

namespace _025_FirebaseCRUD
{
    public partial class Form1 : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "b80MShxmPDgGoY0q6jM4E8NAbYMbVGqFzDRun1mv",
            BasePath = "https://pbook1-a1ddd-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);

            try
            {
                await client.SetAsync("test", "OK"); // 테스트로 OK를 써줌
                FirebaseResponse res = await client.GetAsync("Counter"); //Counter 값을 가져온다

                if (res == null)
                {
                    MessageBox.Show("Firebase 서버와 통신 할 수 없습니다.");
                    return;
                }
                if (res.Body == "null")
                {
                    await client.SetAsync("Counter", 0);
                }

                MessageBox.Show("Firebase 연결 및 Counter 세팅");
            }
            catch (Exception ex)
            {
                MessageBox.Show("초기화 과정 중 오류 발생!\n" + ex.Message);
            }

            // DateGridView 설정하기
            dt.Columns.Add("Id");
            dt.Columns.Add("학번");
            dt.Columns.Add("이름");
            dt.Columns.Add("전화번호");

            dataGridView1.DataSource = dt;

            export();
        }

        // 파이어베이스에 있는 데이터를 dataGridView에 표시하는 메소드
        private async void export()
        {
            dt.Rows.Clear();
            FirebaseResponse res = await client.GetAsync("Counter");

            if (res == null || res.Body == "null")
            {
                return;
            }

            int cnt = res.ResultAs<int>();

            for (int i=1; i<=cnt; i++)
            {
                FirebaseResponse r = await client.GetAsync("Phonebook/" + i);
                if (r != null && r.Body != "null")
                {
                    Data d = r.ResultAs<Data>();
                    dt.Rows.Add(d.Id, d.SId, d.Name, d.Phone);
                }
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {

        }

        private async void btnInsert_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetAsync("Counter");

            if (res == null || res.Body == "null")
            {
                MessageBox.Show("Counter를 읽어오지 못합니다.");
                return;
            }

            int cnt = res.ResultAs<int>();
            cnt++;

            var d = new Data
            {
                Id = cnt.ToString(),
                SId = txtSId.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text
            };

            await client.SetAsync("Counter", cnt);

            SetResponse s = await client.SetAsync("Phonebook/" + d.Id, d);

            // 사실 없어도 됨. 그냥 데이터가 잘 넣어졌는지 확인하는 것
            Data r = s.ResultAs<Data>();
            MessageBox.Show(r.Id + "번 데이터 삽입");

            export();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                return;
            }

            FirebaseResponse res = await client.GetAsync("Phonebook/" + txtId.Text);

            Data d = res.ResultAs<Data>();

            if (d != null)
            {
                txtId.Text = d.Id;
                txtSId.Text = d.SId;
                txtName.Text = d.Name;
                txtPhone.Text = d.Phone;
            }
            else
                MessageBox.Show("찾는 값이 없습니다!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtSId.Text = "";
            txtName.Text = string.Empty;
            txtPhone.Text = string.Empty;

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
                return;

            var d = new Data
            {
                Id = txtId.Text,
                SId = txtSId.Text,
                Name = txtName.Text,
                Phone = txtPhone.Text,
            };

            FirebaseResponse res = await client.UpdateAsync("Phonebook/" + txtId.Text, d);

            export();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
