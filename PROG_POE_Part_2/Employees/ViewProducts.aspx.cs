using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/* ST10145509
 * Jaiden Charles
 * BCA3
 * */
namespace PROG_POE_Part_2.Employees
{
    public partial class ViewProducts : System.Web.UI.Page
    {
        /// <summary>
        /// Retrieves all data from table that matches what fits into the desired criteria
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnViewProducts_Click(object sender, EventArgs e)
        {
            string farmerUsername = txtFarmerUsername.Text;
            string startDate = txtStartDate.Text;
            string endDate = txtEndDate.Text;
            string categoryType = txtCategoryType.Text;

            string query = "SELECT ProductName, Category, ProductionDate FROM Products WHERE FarmerID = (SELECT UserID FROM Users WHERE LoginID = (SELECT LoginID FROM Login WHERE Username = @Username))";
            if (!string.IsNullOrEmpty(startDate) && !string.IsNullOrEmpty(endDate))
            {
                query += " AND ProductionDate BETWEEN @StartDate AND @EndDate";
            }
            if (!string.IsNullOrEmpty(categoryType))
            {
                query += " AND Category = @CategoryType";
            }

            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Username", farmerUsername);
                if (!string.IsNullOrEmpty(startDate) && !string.IsNullOrEmpty(endDate))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                }
                if (!string.IsNullOrEmpty(categoryType))
                {
                    cmd.Parameters.AddWithValue("@CategoryType", categoryType);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                gvProducts.DataSource = dt;
                gvProducts.DataBind();
            }
        }
        /// <summary>
        /// Redirects user back to employee home page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void homeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Employees/Home.aspx");
        }
    }
}
//-----------------------------------------------------------------------------------------------End of File--------------------------------------------------------------------------------------------//