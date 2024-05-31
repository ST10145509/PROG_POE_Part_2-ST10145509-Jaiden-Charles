using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROG_POE_Part_2.Employees;


/* ST10145509
 * Jaiden Charles
 * BCA3
 * */
namespace PROG_POE_Part_2.Farmers
{
    public partial class ViewMyProducts : System.Web.UI.Page
    {
        /// <summary>
        /// refreshes the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        /// <summary>
        /// deletes row freom databases where the product name matcheswhen clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string productNameToDelete = txtProductNameToDelete.Text.Trim();
            // Clears previous error messages
            lblMessage.Text = "";

            if (!string.IsNullOrEmpty(productNameToDelete))
            {
                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductName = @ProductName", con);
                    cmd.Parameters.AddWithValue("@ProductName", productNameToDelete);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Product deleted successfully
                        BindGridView();
                    }
                    else
                    {
                        lblMessage.Text = "Error: Product with the specified name not found.";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }
            else
            {
                lblMessage.Text = "Error: Please enter a product name.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }
        /// <summary>
        /// Validates data and deletes row.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvMyProducts_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int productId = Convert.ToInt32(gvMyProducts.DataKeys[e.RowIndex].Value);

            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Products WHERE ProductID = @ProductID", con);
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.ExecuteNonQuery();
            }

            BindGridView();
        }
        /// <summary>
        /// binds data to grid view.
        /// </summary>
        private void BindGridView()
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT ProductName, Category, ProductionDate FROM Products WHERE FarmerID = (SELECT UserID FROM Users WHERE LoginID = (SELECT LoginID FROM Login WHERE Username = @Username))", con);
                cmd.Parameters.AddWithValue("@Username", Session["Username"].ToString());

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvMyProducts.DataSource = dt;
                gvMyProducts.DataBind();
            }
        }
        /// <summary>
        /// Redirects Farmer back to AddProduct page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReturnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Farmers/AddProduct.aspx");
        }
        /// <summary>
        /// logs user out and redirects back to the login page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Account/Login.aspx");
        }

    }
}
//-----------------------------------------------------------------------------------------------End of File--------------------------------------------------------------------------------------------//