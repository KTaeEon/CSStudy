using MySql.Data.MySqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // �׸���� ������ ������ ���� ����Ʈ
            List<User> userList = new List<User>();
            // DB ����
            string server = "127.0.0.1";
            string port = "3306";
            string username = "root";
            string password = "1234";
            string database = "userdb";
            string table = "user3";

            // DB ���� Ŀ�ؼ� ����
            string strConn = $"server={server};port={port};username={username};password={password};database={database};";
            MySqlConnection conn = new MySqlConnection(strConn);

            try
            {
                // DB ����
                conn.Open();

                // SQL ����
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM `{table}`";
                MySqlDataReader reader = cmd.ExecuteReader();

                // ���ó��
                while (reader.Read())
                {
                    User user = new User();
                    user.Uid = reader[0].ToString();
                    user.Name = reader[1].ToString();
                    user.Hp = reader[2].ToString();
                    user.Age = int.Parse(reader[3].ToString());

                    userList.Add(user);
                }

            }
            catch (Exception except)
            {
                Console.WriteLine(except.Message);
            }
            finally
            {
                // DB����
                conn.Close();
            }

            // �����ͱ׸���� ������ ����
            dataGrid.DataSource = userList;
        }
    }
}