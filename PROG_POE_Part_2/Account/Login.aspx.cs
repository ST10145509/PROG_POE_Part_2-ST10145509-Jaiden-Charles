using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/* ST10145509
 * Jaiden Charles
 * BCA3
 * */
namespace PROG_POE_Part_2.Account
{
    public partial class Login : System.Web.UI.Page
    {
        /// <summary>
        /// Compares text input to tables in database and logs the user in if the data matches. Roles included.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = "";

            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Roles.Role FROM Login INNER JOIN Users ON Login.LoginID = Users.LoginID INNER JOIN Roles ON Users.RoleID = Roles.RoleID WHERE Login.Username = @Username AND Login.Password = @Password", con);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    role = reader["Role"].ToString();
                    Session["Username"] = username;
                    Session["Role"] = role;
                    //validates farmer role
                    if (role == "Farmer")
                    {
                        Response.Redirect("~/Farmers/AddProduct.aspx");
                    }
                    //validates employee role
                    else if (role == "Employee")
                    {
                        Response.Redirect("~/Employees/Home.aspx");
                    }
                }
                else
                {
                    lblMessage.Text = "Invalid username or password.";
                }
            }
        }

        /// <summary>
        /// Returns to Title Page if clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("~/Default.aspx");
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An error occurred while redirecting: " + ex.Message;
            }
        }
    }
}
//-----------------------------------------------------------------------------------------------End of File--------------------------------------------------------------------------------------------//