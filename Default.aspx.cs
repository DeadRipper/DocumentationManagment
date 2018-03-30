using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        MySql.Data.MySqlClient.MySqlConnection conn;
        MySql.Data.MySqlClient.MySqlCommand cmd;
        MySql.Data.MySqlClient.MySqlDataReader reader;
        String queryStr;
        String name;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitEventMethod(object sender, EventArgs e)
        {
            String connString = System.Configuration.ConfigurationManager.ConnectionStrings["WebAppConnString"].ToString();
            conn = new MySql.Data.MySqlClient.MySqlConnection(connString);
            conn.Open();
            queryStr = "";
            queryStr = "select * from webappdemo.userregistration where username='" + usernameTextBox.Text + "'and password='" + passwordTextBox.Text +"'";
            cmd = new MySql.Data.MySqlClient.MySqlCommand(queryStr, conn);

            reader = cmd.ExecuteReader();
            name = "";
            while(reader.HasRows&&reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("firstname")) + " " +
                    reader.GetString(reader.GetOrdinal("middlename")) + " " +
                    reader.GetString(reader.GetOrdinal("lastname")) + " ";
            }
            if(reader.HasRows)
            {
                Session["uname"] = name;
                Response.BufferOutput = true;
                Response.Redirect("LoggedIn.aspx", false);
            }
            else
            {
                passwordTextBox.Text = "invalid user";
            }

            reader.Close();
            conn.Close();
        }
    }
}