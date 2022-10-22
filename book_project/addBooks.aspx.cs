using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace book_project
{
    public partial class addBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String book_name = TextBox1.Text;
            String author = TextBox2.Text;
            String price = TextBox3.Text;
            String catagory = TextBox4.Text;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WAD_PROJECT\book_project\book_project\App_Data\books.mdf;Integrated Security=True";
            try
            {
                using (con)
                {
                    con.Open();
                    String query = "INSERT INTO [Books] (book_name,author,price,catagory) VALUES('" + book_name + "','" + author + "','" + price + "','" + catagory + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
         
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('done');", true);
                    con.Close();
                    Response.Redirect("AdminHome.aspx", false);
                }

            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.Message);
            }
        }
    }
}