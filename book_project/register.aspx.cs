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
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = TextBox2.Text;
            //Session[name] = name;
            String email = TextBox3.Text;
            String password = TextBox4.Text;
            String gender = RadioButtonList1.SelectedItem.Value;
            //Response.Write($"{name}");
            //Response.Write($"{email}");
            //Response.Write($"{password}");
            //Response.Write($"{gender}");

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WAD_PROJECT\book_project\book_project\App_Data\books.mdf;Integrated Security=True";
            try
            {
                using (con)
                {
                    con.Open();
                    String query = "INSERT INTO [User] (user_name,user_email,user_password,user_gender) VALUES('" + name + "','" + email + "','" + password + "','" + gender + "')";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    Response.Write("done");
                    //ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('done');", true);
                    con.Close();
                    Response.Redirect("home.aspx",false);
                }

            }
            catch(Exception ex)
            {
                Response.Write("error" + ex.Message);
            }
        }
    }
}