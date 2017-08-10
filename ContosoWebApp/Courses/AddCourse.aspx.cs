using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Model;
using Contoso.Service;

namespace ContosoWebApp.Courses
{
    public partial class AddCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Contoso.Model.Courses course = new Contoso.Model.Courses
            {
                Title = txtTitle.Text,
                Credits = Convert.ToInt32(txtCredits.Text),
                DepartmentId = Convert.ToInt32(TxtDeptId.Text)

            };

            CourseService service = new CourseService();
            service.SaveCourse(course);
        }
    }
}