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
namespace PROG_POE_Part_2.Employees
{
    public partial class AddFarmer : System.Web.UI.Page
    {
        /// <summary>
        /// Adds farmer details to database when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddFarmer_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Clears previous error messages
            lblNameError.Text = "";
            lblSurnameError.Text = "";
            lblUsernameError.Text = "";
            lblPasswordError.Text = "";
            lblMessage.Text = "";

            bool isValid = true;

            // Validate inputs
            if (string.IsNullOrEmpty(name))
            {
                lblNameError.Text = "Name is required.";
                isValid = false;
            }
            if (string.IsNullOrEmpty(surname))
            {
                lblSurnameError.Text = "Surname is required.";
                isValid = false;
            }
            if (string.IsNullOrEmpty(username))
            {
                lblUsernameError.Text = "Username is required.";
                isValid = false;
            }
            if (string.IsNullOrEmpty(password))
            {
                lblPasswordError.Text = "Password is required.";
                isValid = false;
            }

            //Inserts into database tables if valid
            if (isValid)
            {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Login (Username, Password) VALUES (@Username, @Password); INSERT INTO Users (Name, Surname, LoginID, RoleID) VALUES (@Name, @Surname, (SELECT LoginID FROM Login WHERE Username = @Username), (SELECT RoleID FROM Roles WHERE Role = 'Farmer'))", con);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Surname", surname);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        lblMessage.Text = "Farmer added successfully.";
                    }
                    else
                    {
                        lblMessage.Text = "Error adding farmer.";
                    }
                }
            }
        }

        /// <summary>
        /// Takes employee back to employee home page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Employees/Home.aspx");
        }
    }
}
//-----------------------------------------------------------------------------------------------End of File--------------------------------------------------------------------------------------------//