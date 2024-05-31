using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/* ST10145509
 * Jaiden Charles
 * BCA3
 * */
namespace PROG_POE_Part_2.Farmers
{
    public partial class AddProduct : System.Web.UI.Page
    {
        /// <summary>
        /// Adds product details to database when clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddProduct_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text.Trim();
            string category = txtCategory.Text.Trim();
            string productionDate = txtProductionDate.Text.Trim();

            // Clear previous error messages
            lblProductNameError.Text = "";
            lblCategoryError.Text = "";
            lblProductionDateError.Text = "";
            lblMessage.Text = "";

            bool isValid = true;

            // Validate inputs
            if (string.IsNullOrEmpty(productName))
            {
                lblProductNameError.Text = "Product name is required.";
                isValid = false;
            }
            if (string.IsNullOrEmpty(category))
            {
                lblCategoryError.Text = "Category is required.";
                isValid = false;
            }
            if (string.IsNullOrEmpty(productionDate))
            {
                lblProductionDateError.Text = "Production date is required.";
                isValid = false;
            }

            //Inserts into database tables if valid
            if (isValid)
            {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Products (ProductName, Category, ProductionDate, FarmerID) VALUES (@ProductName, @Category, @ProductionDate, (SELECT UserID FROM Users WHERE LoginID = (SELECT LoginID FROM Login WHERE Username = @Username)))", con);
                    cmd.Parameters.AddWithValue("@ProductName", productName);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@ProductionDate", productionDate);
                    cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        lblMessage.Text = "Product added successfully.";
                    }
                    else
                    {
                        lblMessage.Text = "Error adding product.";
                    }
                }
            }
        }

        /// <summary>
        /// Logs user out and clears session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Account/Login.aspx");
        }
    }
}
//-----------------------------------------------------------------------------------------------End of File--------------------------------------------------------------------------------------------//