using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Model;
using Contoso.Service;

namespace ContosoWebApp.Departments
{
    public partial class EditDept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                var deptid = Convert.ToInt32(Request.QueryString["ID"]);
                DeptService service = new DeptService();
                Contoso.Model.Department dept = service.GetDeptById(deptid);

                txtName.Text = dept.Name;
                TxtBudget.Text = dept.Budget;
                TxtStartDate.Text = dept.StartDate.ToString();
                TxtInstructorId.Text = dept.InstructorId.ToString();
                TxtRowVersion.Text = dept.RowVersion;

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                Contoso.Model.Department dt = new Contoso.Model.Department
                {
                    Id = Convert.ToInt32(Request.QueryString["id"]),
                    Name = txtName.Text,
                    Budget = TxtBudget.Text,
                    StartDate = Convert.ToDateTime(TxtStartDate.Text),
                    InstructorId = Convert.ToInt32(TxtInstructorId.Text),
                    RowVersion = TxtRowVersion.Text,
                };

                DeptService service = new DeptService();
                service.UpdateDept(dt);
            }
        }
    }
}