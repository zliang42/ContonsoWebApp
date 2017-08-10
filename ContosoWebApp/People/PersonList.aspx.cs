using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace ContosoWebApp.People
{
    public partial class PersonList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PeopleService per = new PeopleService();
                repeaterPeople.DataSource = per.GetAllPeople();
                repeaterPeople.DataBind();
            }
        }

        protected void repeaterPeople_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var personid = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                Response.Redirect("EditPerson.aspx?id=" + personid);
            }

            if (e.CommandName == "Delete")
            {
                PeopleService service = new PeopleService();
                service.DeletePerson(personid);
                Response.Redirect("PersonList.aspx");
            }

            if (e.CommandName == "Details")
            {
                Response.Redirect("DetailPerson.aspx?id=" + personid);
            }
        }
    }
}