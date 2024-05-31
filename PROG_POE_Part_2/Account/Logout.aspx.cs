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
namespace PROG_POE_Part_2.Account
{
    public partial class Logout : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            // Clear user session
            Session.Clear();
            Session.Abandon();
            // Redirect to the login page
            Response.Redirect("~/Account/Login.aspx");
        }
    }
}
//-----------------------------------------------------------------------------------------------End of File--------------------------------------------------------------------------------------------//