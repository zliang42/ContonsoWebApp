using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Utility;
using Contoso.Model;
using Contoso.Service;

namespace ContosoWebApp.People
{
    public partial class AddPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlStates.DataSource = Utility.GetAllStates();
                ddlStates.DataTextField = "StateName";
                ddlStates.DataValueField = "Value";
                ddlStates.DataBind();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) //user can disable the javascript control, this checks the server side control
            {

                Contoso.Model.People peo = new Contoso.Model.People
                {

                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    Email = txtEmail.Text,
                    Phone = Convert.ToInt32(TxtPhone.Text),
                    AddressLine1 = txtAddress1.Text,
                    AddressLine2 = txtAddress2.Text,
                    UnitOrApartmentNumber=Convert.ToInt32(txtUnit.Text),
                    City = txtCity.Text,
                    State = ddlStates.SelectedValue,
                    ZipCode = Convert.ToInt16(txtZipcode.Text)
                };
                PeopleService service = new PeopleService();
                service.SavePerson(peo);
            }

        }
    }
}