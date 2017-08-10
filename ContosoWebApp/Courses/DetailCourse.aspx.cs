using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace ContosoWebApp.Courses
{
    public partial class DetailCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var courseid = Convert.ToInt32(Request.QueryString["ID"]);
                CourseService service = new CourseService();
                var course = service.GetCourseById(courseid);
                lbTitle.Text = course.Title;
                lbCredits.Text = course.Credits.ToString();
                lbDeptId.Text = course.DepartmentId.ToString();
               

            }
        }
    }
}