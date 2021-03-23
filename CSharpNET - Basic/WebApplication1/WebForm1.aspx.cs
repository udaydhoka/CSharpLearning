using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Using the string indexer to store session data
            Session["Session1"] = "Session one Data";
            // Using the string indexer to store session data
            Session["Session2"] = "Session two Data";

            // Using the integral indexer to retrieve data 
            Response.Write("Session 1 Data = " + Session[0].ToString());
            Response.Write("<br/>");
            // Using the string indexer to retrieve data 
            Response.Write("Session 2 Data = " + Session["Session2"].ToString());

            //see metadata of HttpSessionState class to see how indexes are declared

            Response.Write("<br/>");
            Response.Write("<br/>");
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("Select * from one", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // Using integral indexer to retrieve Id column value
                    Response.Write("Id = " + rdr[0].ToString() + " ");
                    // Using string indexer to retrieve Id column value
                    Response.Write("Name = " + rdr["Name"].ToString());
                    Response.Write("<br/>");
                }
            }

            //see metadate of HttpSessionState class to see how indexes are declared

        }
    }
}