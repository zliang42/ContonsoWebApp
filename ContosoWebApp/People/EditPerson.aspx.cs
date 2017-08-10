using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Model;
using Contoso.Utility;
using Contoso.Service;

namespace ContosoWebApp.People
{
    public partial class EditPerson : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var personid = Convert.ToInt32(Request.QueryString["ID"]);
                PeopleService service = new PeopleService();
                Contoso.Model.People person= service.GetPersonById(personid);

                txtFirstName.Text = person.FirstName;
                txtLastName.Text = person.LastName;
                txtAge.Text = person.Age.ToString();
                txtEmail.Text = person.Email;
                TxtPhone.Text = person.Phone.ToString();
                txtAddress1.Text = person.AddressLine1;
                txtUnit.Text = person.UnitOrApartmentNumber.ToString();
                txtCity.Text = person.City;
                txtZipcode.Text = person.ZipCode.ToString();

                ddlStates.SelectedValue = person.State;
                ddlStates.DataSource = Utility.GetAllStates();
                ddlStates.DataTextField = "StateName";
                ddlStates.DataValueField = "Value";
                ddlStates.DataBind();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                Contoso.Model.People peo = new Contoso.Model.People
                {
                    Id = Convert.ToInt32(Request.QueryString["id"]),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    MiddleName = txtMiddleName.Text,
                    Age = Convert.ToInt32(txtAge.Text),
                    Email = txtEmail.Text,
                    Phone = Convert.ToInt32(TxtPhone.Text),
                    AddressLine1 = txtAddress1.Text,
                    AddressLine2 = txtAddress2.Text,
                    UnitOrApartmentNumber = Convert.ToInt32(txtUnit.Text),
                    City = txtCity.Text,
                    State = ddlStates.SelectedValue,
                    ZipCode = Convert.ToInt16(txtZipcode.Text)
                };
                PeopleService service = new PeopleService();
                service.UpdatePerson(peo);
            }
        }
    }
}