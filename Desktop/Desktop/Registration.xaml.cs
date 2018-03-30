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
using MySql.Data.MySqlClient;
using System.Data;
using System.Security.Policy;
using System.Text.RegularExpressions;
using MySql.Data;

namespace Desktop
{
    /// <summary>
    /// Логика взаимодействия для Eror.xaml
    /// </summary>
    public partial class Registration : Window
    {
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlDataReader reader;

        public Registration()
        {
            InitializeComponent();
        }

        public bool Login(string username, string password,string key)
        {
            bool isTrue = false;
            MySqlCommand cmd = new MySqlCommand();
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString =
                "server = 127.0.0.1; user id = root; password = 1234; database = admindata; SslMode = none;";
            cmd.Connection = conn;
            conn.Open();
            string sql = "insert into admindata.adminuser(adminlogin, adminpass, adminkey)"+ "values('" + usernameTextBox.Text+"','"+passwordTextBox.Password.ToString()+
                         "','"+"concat(adminuser.adminlogin,'',adminuser.id))'";
            cmd.CommandText = sql;
            //string sql1 = "insert into admindata.adminkey(key)" + " values('" + keyTextBox.Text.ToString() + "')";
            //cmd.CommandText = sql1;
            MySql.Data.MySqlClient.MySqlCommand myCommand = new MySqlCommand(sql,conn);
            //MySql.Data.MySqlClient.MySqlCommand myCommand1 = new MySqlCommand(sql1, conn);


            //MySqlParameter AdminloginParametar = new MySqlParameter("@adminlogin", SqlDbType.VarChar);
            //MySqlParameter AdminpassParametar = new MySqlParameter("@adminpass", SqlDbType.VarChar);

            //cmd.Parameters.Add(AdminloginParametar);
            //cmd.Parameters.Add(AdminpassParametar);

            //AdminpassParametar.Value = username;
            //AdminpassParametar.Value = password;


            //cmd.CommandType = CommandType.Text;
            //cmd.ExecuteNonQuery();

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

            reader.Close();
            conn.Close();
        }

        //public bool KeyGen(string key)
        //{
        //    bool isTrue = false;
        //    MySqlCommand cmd = new MySqlCommand();
        //    MySqlConnection conn = new MySqlConnection();
        //    conn.ConnectionString =
        //        "server = 127.0.0.1; user id = root; password = 1234; database = admindata; SslMode = none;";
        //    cmd.Connection = conn;
        //    conn.Open();
        //    string sql = "insert into admindata.adminkey(key)"+" values('" + keyTextBox.Text + "')";
        //    cmd.CommandText = sql;


        //    //    MySqlParameter KeyParametar = new MySqlParameter("@key", SqlDbType.VarChar);

        //    //    cmd.Parameters.Add(KeyParametar);

        //    //    KeyParametar.Value = key;

        //    //    conn.Open();

        //    //    cmd.CommandType = CommandType.Text;
        //    //    cmd.ExecuteNonQuery();

        //    MySqlDataReader reader = cmd.ExecuteReader();
        //    if (reader.HasRows)
        //    {
        //        isTrue = true;
        //        return isTrue;
        //    }
        //    else
        //    {
        //        isTrue = false;
        //        return isTrue;
        //    }
        //    reader.Close();
        //    conn.Close();
        //}

        public void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //const string str = "abcdefghijklmnopqrstuvwxyz0123456789";
            //var builder = new StringBuilder();

            //Random rnd = new Random();

            //for (var i = 0; i < 10; i++)
            //{
            //    var c = str[rnd.Next(0, str.Length)];
            //    builder.Append(c);
            //}

            //keyTextBox.Text = builder.ToString();
            //keyTextBox.TextAlignment = TextAlignment.Left;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            //Regex keyRegex = new Regex(@"\+[0-9],[a-z],[A-Z]\*");
            if (Login(usernameTextBox.Text.Trim(), passwordTextBox.Password.ToString().Trim(),keyTextBox.Text.ToString().Trim()))
            {
                MessageBoxResult res = MessageBox.Show("User registreted" + "\n Your activation key:" +
                                                       "'select adminkey from adminuser'");

            }
            else
            {
                MessageBox.Show("Unnable to register, plese check input data");
                usernameTextBox.Text = "";
                passwordTextBox.Password = "";
                keyTextBox.Clear();
                usernameTextBox.Focus();
            }

        }

    }

}
