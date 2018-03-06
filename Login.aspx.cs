﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
namespace Forms
{
    public partial class Login : System.Web.UI.Page
    {
        String sqlConName = "datasource = localhost; port=3306;username=root;password=root";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = connectToDb();
            MySqlCommand cmd = new MySqlCommand("Select id from form.Person where p_name='" + this.TextBox2.Text + "' and pass='" + this.TextBox1.Text + "';", myConn);
            MySqlDataReader myReader;
            //myConn.Open();
            myReader = cmd.ExecuteReader();
            int count = 0;
            string arr = "";
            while (myReader.Read())
            {
                count++;
                //arr = (string)myReader["designation"];
            }
            if (count == 1)
            {
                
                    Response.Redirect("~/Form1.aspx");
                
            }
            closeDbConnection(myConn);
        }
        private MySqlConnection connectToDb()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(sqlConName);
                con.Open();
                if (con.State == ConnectionState.Open)
                {

                }
                return con;
            }

            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void closeDbConnection(MySqlConnection con)
        {
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AdminLogin.aspx");
        }
    }
}