using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
namespace Forms
{
    public partial class Form1 : System.Web.UI.Page
    {
        String sqlConName = "datasource = localhost; port=3306;username=root;password=root";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MySqlConnection myConn = connectToDb();
            MySqlCommand cmd = new MySqlCommand("insert into form.form1(p_name,email,contact,school,batch,hostelite,hostel) Values('"+this.TextBox1.Text+"','"+this.TextBox2.Text+"','"+this.TextBox3.Text+"','"+this.TextBox4.Text+"','"+this.TextBox5.Text+"','"+this.TextBox6.Text+"','"+this.TextBox7.Text+"');", myConn);
            MySqlDataReader myReader;
            //INSERT INTO `form`.`form1` ( `p_name`, `email`, `contact`, `school`, `batch`, `hostelite`, `hostel`) VALUES ('2', 'anoosha', 'akeen', '745734', 'SEECS', '2k15', 'Yes', 'Ayesha');

            try
            {
                myReader = cmd.ExecuteReader();
                Response.Redirect("~/Login.aspx");
            }
            catch(Exception ex)
            {

            }
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
    }
}