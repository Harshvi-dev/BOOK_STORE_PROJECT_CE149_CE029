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
    public partial class home : System.Web.UI.Page
    {
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {

            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert(`welcome ${Session[name]}`);", true);
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.CompareTo("buy") == 0)
            {
                int index = Convert.ToInt32(e.CommandArgument);

                // Get the last name of the selected author from the appropriate
                // cell in the GridView control.
                GridViewRow selectedRow = GridView1.Rows[index];
                TableCell id = selectedRow.Cells[0];
                string books_id = id.Text;
                Response.Write(books_id);
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WAD_PROJECT\book_project\book_project\App_Data\books.mdf;Integrated Security=True";
                
                try
                {
                    using (con)
                    {
                        con.Open();
                        String query = "INSERT INTO [Order] (books_id) VALUES('" + books_id + "''" +  + "','" + price + "','" + catagory + "')";

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
}