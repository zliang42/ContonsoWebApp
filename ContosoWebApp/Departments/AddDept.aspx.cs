using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;
using Contoso.Model;

namespace ContosoWebApp.Departments
{
    public partial class AddDept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Contoso.Model.Department dept = new Contoso.Model.Department
            {
                Name = txtName.Text,
                Budget = TxtBudget.Text,
                StartDate = Convert.ToDateTime(TxtStartDate.Text),
                InstructorId = Convert.ToInt32(TxtInstructorId.Text),
                RowVersion = TxtRowVersion.Text
            };
            DeptService service = new DeptService();
            service.SaveDepartment(dept);
            
        }
    }
}