using System;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Desktop
{
    public partial class MainWindow : Window
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLoadDataGrid_Click(object sender, RoutedEventArgs e)
        {
            string connStr =
                "server = 127.0.0.1; user id = root; password = 1234; database = webdatabase; SslMode = none;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM webdatabase.userregistration", conn);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds, "LoadDataBinding");
            dataGridCustomers.DataContext = ds;
            conn.Close();
        }
    }
}
