using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Enter.xaml
    /// </summary>
    public partial class Enter : Window
    {
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlDataReader reader;
        public Enter()
        {
            InitializeComponent();
        }

        public bool Login(string username, string password)
        {
            bool isTrue = false;
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server = 127.0.0.1; user id = root; password = 1234; database = webappdemo; SslMode = none;";
            cmd.Connection = conn;
            string sql = "SELECT * from webappdemo.userregistration where username = '" + usernameTextBox.Text + "' and password ='" + passwordTextBox.Password.ToString()+ "'";
            cmd.CommandText = sql;


            MySqlParameter UsernameParametar = new MySqlParameter("@username", SqlDbType.VarChar);
            MySqlParameter PassParametar = new MySqlParameter("@password", SqlDbType.VarChar);
            cmd.Parameters.Add(UsernameParametar);
            cmd.Parameters.Add(PassParametar);
            UsernameParametar.Value = username;
            PassParametar.Value = password;
            conn.Open();


            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                isTrue = true;
                return isTrue;
            }
            else
            {
                isTrue = false;
                return isTrue;
            }
        }

            public void login(object sender, RoutedEventArgs e)
            {
            if (Login(usernameTextBox.Text.Trim(), passwordTextBox.Password.ToString().Trim()))
                {
                    MessageBoxResult res = MessageBox.Show("Login successsful");
                    if (res == MessageBoxResult.OK)
                    {
                        StartWindow window = new StartWindow();
                        window.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                    usernameTextBox.Text = "";
                    passwordTextBox.Password = "";
                    usernameTextBox.Focus();
                }
            }

        

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            Registration window = new Registration();
            window.Show();
            this.Close();
        }
    }
}
