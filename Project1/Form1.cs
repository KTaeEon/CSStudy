namespace Project1
{
    public partial class form1 : Form
    {
        private int savedNum = 0;
        private int operate = 0;  // 1:Plus, 2:Minus, 3:Multi, 4 Div
        private bool newInput = true;
        List<int> list = new List<int>();
        private int count = 0;
        private bool newres = true;
        

        public form1()
        {
            InitializeComponent();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEq_Click(object sender, EventArgs e)
        {
            int finalnum = int.Parse(txtResult.Text);
            int result = 0;

            switch (operate)
            {
                case 1:
                    result = savedNum + finalnum;
                    break;

                case 2:
                    result = savedNum - finalnum;
                    break;

                case 3:
                    result = savedNum * finalnum;
                    break;

                case 4:
                    result = savedNum / finalnum;
                    break;
            }

            txtResult.Text = result.ToString();
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string strNum = btn.Tag.ToString();

            // Console.WriteLine("Tag : "+btn.Tag);
            if (newInput )
            {
                txtResult.Text = strNum;
                newInput = false;
            }
            else
            {
                txtResult.Text += strNum;
            }
        }

        private void btnOperater_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            list.Add(int.Parse(txtResult.Text));
            if (newres)
            {
                savedNum = list[list.Count - 1];
                newres = false;
            }
            else
            {
                switch (operate)
                {
                    case 1:
                        savedNum = savedNum + list[list.Count - 1];
                        break;
                    case 2:
                        savedNum = savedNum - list[list.Count - 1];
                        break;
                    case 3:
                        savedNum = savedNum * list[list.Count - 1];
                        break;
                    case 4:
                        savedNum = savedNum / list[list.Count - 1];
                        break;
                }
            }
            operate = int.Parse(btn.Tag.ToString());
            txtResult.Text = "0";
            newInput = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            newInput = true;
            newres = true;
        }
    }
}