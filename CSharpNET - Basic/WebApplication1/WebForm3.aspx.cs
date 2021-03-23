using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["CountriesData"] == null)
            {
                Country country1 = new Country() { Code = "AUS", Name = "AUSTRALIA", Capital = "Canberra" };

                Country country2 = new Country() { Code = "IND", Name = "INDIA ", Capital = "New Delhi" };

                Country country3 = new Country() { Code = "USA", Name = "UNITED STATES", Capital = "Washington D.C." };

                Country country4 = new Country() { Code = "GBR", Name = "UNITED KINGDOM", Capital = "London" };

                Country country5 = new Country() { Code = "CAN", Name = "CANADA", Capital = "Ottawa" };

                Dictionary<string, Country> dictCountries = new Dictionary<string, Country>();
                dictCountries.Add(country1.Code, country1);
                dictCountries.Add(country2.Code, country2);
                dictCountries.Add(country3.Code, country3);
                dictCountries.Add(country4.Code, country4);
                dictCountries.Add(country5.Code, country5);

                Session["CountriesData"] = dictCountries;
            }
            
        }

        protected void txtCountryCode_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, Country> dictCountries = (Dictionary<string, Country>)Session["CountriesData"];

            if (dictCountries.TryGetValue(txtCountryCode.Text.ToUpper(), out Country result))
            {
                txtCapital.Text = result.Capital;
                txtName.Text = result.Name;
                label1.Text = string.Empty;
            }
            else
            {
                label1.Text = "Invalid Country code";
                txtCapital.Text = string.Empty;
                txtName.Text = string.Empty;
            }
                

        }
    }
}