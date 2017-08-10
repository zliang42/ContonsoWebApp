using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace ContosoWebApp.Departments
{
    public partial class DeptList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DeptService d = new DeptService();
                repeaterDept.DataSource = d.GetAllDepartment();
                repeaterDept.DataBind();
            }
        }

        protected void repeaterDept_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var deptid = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                Response.Redirect("EditDept.aspx?id=" + deptid);
            }

            if (e.CommandName == "Delete")
            {
                DeptService service = new DeptService();
                service.DeleteDepartment(deptid);
                Response.Redirect("DeptList.aspx");
            }

            if (e.CommandName == "Details")
            {
                Response.Redirect("DetailDept.aspx?id=" + deptid);
            }
        }
    }
}