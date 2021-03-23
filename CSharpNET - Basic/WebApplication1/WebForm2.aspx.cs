using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Company c = new Company();
            Response.Write("Name of the 1st employee is : " + c[1]);
            Response.Write("<br/>");
            Response.Write("Name of the 1st employee is : " + c[4]);
            Response.Write("<br/>");
            

            c[1] = "update to kumar";
            c[4] = "update to Johny";

            Response.Write("After updating the names");
            Response.Write("<br/>");
            Response.Write("Name of the 1st employee is : " + c[1]);
            Response.Write("<br/>");
            Response.Write("Name of the 1st employee is : " + c[4]);
            Response.Write("<br/>");

            //mod 66
            Response.Write("<br/>");
            Response.Write("List of Male Employees: " + c["Male"]);
            Response.Write("<br/>");
            Response.Write("List of Female Employees: " + c["Female"]);
            Response.Write("<br/>");

            c["Male"] = "Female";
            c["Female"] = "Male";

            Response.Write("After reversing the gender");
            Response.Write("<br/>");
            Response.Write("List of Male Employees: " + c["Male"]);
            Response.Write("<br/>");
            Response.Write("List of Female Employees: " + c["Female"]);
            Response.Write("<br/>");


        }
    }
}