using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace ContosoWebApp.Departments
{
    public partial class DetailDept : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var deptid = Convert.ToInt32(Request.QueryString["ID"]);
                DeptService service = new DeptService();
                var dept = service.GetDeptById(deptid);
                lbName.Text = dept.Name;
                lbBudget.Text = dept.Budget;
                lbStartDate.Text = dept.StartDate.ToLongDateString();
                lbInstructorId.Text = dept.InstructorId.ToString();
                lbRowVersion.Text = dept.RowVersion;
                
            }
        }
    }
}