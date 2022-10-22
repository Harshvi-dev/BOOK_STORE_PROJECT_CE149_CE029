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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String name = TextBox1.Text;
            String password = TextBox2.Text;
            Session["UserName"] = name;
            if (name == "admin" && password == "admin123")
            {
                Response.Redirect("AdminHome.aspx", false);
            }
            else
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WAD_PROJECT\book_project\book_project\App_Data\books.mdf;Integrated Security=True";
                try
                {
                    using (con)
                    {
                        
                        SqlCommand cmd = new SqlCommand("select * from [user] where user_name=@user and user_password=@pass", con);
                        cmd.Parameters.AddWithValue("@user", TextBox1.Text);
                        cmd.Parameters.AddWithValue("@pass", TextBox2.Text);
                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        con.Open();
                        int i = cmd.ExecuteNonQuery();
                        con.Close();

                        if (dt.Rows.Count > 0)
                        {
                            Response.Redirect("home.aspx");
                        }
                        else
                        {
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('notdone');", true);


                        }

                    }
                }
                catch (Exception ex)
                {
                    Response.Write("error" + ex.Message);
                }
            }
        }
    }
}
