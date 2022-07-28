namespace Ch11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("기본메세지 박스");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("제목과 내용이 있는 메세지박스", "버튼2 클릭");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int count = 0;
        hi:
            DialogResult result = MessageBox.Show("두개의 버튼을 갖는 메시지박스",
                                                  "버튼3 클릭",
                                                  MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes && count < 3)
            {
                MessageBox.Show("YES 클릭!");
            }
            else if (result == DialogResult.No && count == 3) 
            {
                MessageBox.Show("나는 분명 기회를 줬다.");
                MessageBox.Show("너가 안들은거야.");
                MessageBox.Show("잘있어.");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("NO 클릭!");
                Thread.Sleep(1000);
                MessageBox.Show("왜 ?");
                Thread.Sleep(1000);
                MessageBox.Show("어째서 ?");
                Thread.Sleep(1000);
                MessageBox.Show("거절을 눌렀니 ?");
                Thread.Sleep(1000);
                MessageBox.Show("아니요가 맞아 ?");
                Thread.Sleep(1000);
                MessageBox.Show("왜 맞다 생각해 ?");
                Thread.Sleep(1000);
                MessageBox.Show("다시 선택해봐");
                count++;
                goto hi;



            }
        }

        private void btnUid_Click(object sender, EventArgs e)
        {
            string uid = txtUid.Text;
            lbUid.Text = "결과 : "+ uid;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            lbName.Text = "결과 : " + name;
        }

        private void btnHp_Click(object sender, EventArgs e)
        {
            string hp = txtHp.Text;
            lbHp.Text = "결과 : " + hp;
        }

        private void btnChkFruit_Click(object sender, EventArgs e)
        {
            CheckBox[] chkFruits = { chkFruit1, chkFruit2, chkFruit3, chkFruit4, chkFruit5 };
            List<string> fruits = new List<string>();

            foreach (CheckBox chk in chkFruits)
            {
                if (chk.Checked)
                {
                    fruits.Add(chk.Text);
                }
            }

            lbFruitResult.Text = "결과 : " + String.Join(", ", fruits);

        }

        private void btnChkColor_Click(object sender, EventArgs e)
        {
            CheckBox[] chkColors = { chkColor1, chkColor2, chkColor3, chkColor4, chkColor5 };
            List<string> colors = new List<string>();

            foreach (CheckBox chk in chkColors)
            {
                if (chk.Checked)
                {
                    colors.Add(chk.Text);
                }
            }

            lbColorResult.Text = "결과 : " + String.Join(", ", colors);
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
        }
    }
}