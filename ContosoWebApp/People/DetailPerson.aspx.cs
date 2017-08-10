using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace ContosoWebApp.People
{
    public partial class DetailPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
	        {
            var personid = Convert.ToInt32(Request.QueryString["ID"]);
            PeopleService service = new PeopleService();
            var person = service.GetPersonById(personid);
            lbFristName.Text = person.FirstName;
            lbLastName.Text = person.LastName;
            lbAge.Text = person.Age.ToString();
            lbEmail.Text = person.Email;
            lbPhone.Text = person.Phone.ToString();
            lbAddress1.Text = person.AddressLine1;
            lbCity.Text = person.City;
            lbState.Text = person.State;
            lbZipcode.Text = person.ZipCode.ToString();

	        }
        }
    }
}