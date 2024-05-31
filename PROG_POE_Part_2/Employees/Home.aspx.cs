using System;
using System.Collections.Generic;
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
    public partial class Home : Page
    {
        /// <summary>
        /// Redirects to add farmer page when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnAddFarmer_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Employees/AddFarmer.aspx");
        }

        /// <summary>
        /// Redirects to ViewProducts page when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnViewProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Employees/ViewProducts.aspx");
        }

        /// <summary>
        /// Redirects back to Login page when clicked
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