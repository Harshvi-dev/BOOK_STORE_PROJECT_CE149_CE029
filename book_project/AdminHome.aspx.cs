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
    public partial class AdminHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Response.Write("hey");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("addBooks.aspx", false);
        }

        /* protected void Button1_Click(object sender, EventArgs e)
         {
             SqlConnection con = new SqlConnection();
             con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WAD_PROJECT\book_project\book_project\App_Data\books.mdf;Integrated Security=True";
             try
             {
                 using (con)
                 {
                     String command = "SELECT * FROM [User]";
                     SqlCommand cmd = new SqlCommand(command, con);
                     con.Open();
                     SqlDataReader rdr = cmd.ExecuteReader();
                     GridView1.DataSource = rdr;
                     GridView1.DataBind();
                     rdr.Close();
                 }
             }
             catch (Exception ex)
             {
                 Response.Write("Errors: " + ex.Message);
             }

         }*/

        /*protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WAD_PROJECT\book_project\book_project\App_Data\books.mdf;Integrated Security=True";
            try
            {
                using (con)
                {
                    String command = "SELECT * FROM [Books]";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridView2.DataSource = rdr;
                    GridView2.DataBind();
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
        }*/

        /*protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WAD_PROJECT\book_project\book_project\App_Data\books.mdf;Integrated Security=True";
            try
            {
                using (con)
                {
                    String command = "SELECT * FROM [Order]";
                    SqlCommand cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridView3.DataSource = rdr;
                    GridView3.DataBind();
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write("Errors: " + ex.Message);
            }
        }*/

        /*protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WAD_PROJECT\book_project\book_project\App_Data\books.mdf;Integrated Security=True";
            try
            {
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("delete from  [User] where user_id= user_id ", con);
                    //con.Parameters.AddWithValue("@id",);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //   MessageBox.Show("Data stored successfully");
                }
            }
            catch (Exception ex)
            {
                Response.Write("errors:" + ex.Message);
            }

     */
    }

       
    }