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
    public partial class EditCourse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                var courseid = Convert.ToInt32(Request.QueryString["ID"]);
                CourseService service = new CourseService();
                Contoso.Model.Courses c = service.GetCourseById(courseid);

                txtTitle.Text = c.Title;
                txtCredits.Text = c.Credits.ToString();
                TxtDeptId.Text = c.DepartmentId.ToString();

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                Contoso.Model.Courses cs = new Contoso.Model.Courses
                {
                    Id = Convert.ToInt32(Request.QueryString["id"]),
                    Title = txtTitle.Text,
                    Credits = Convert.ToInt32(txtCredits.Text),
                    DepartmentId = Convert.ToInt32(TxtDeptId.Text),
                };

                CourseService service = new CourseService();
                service.UpdateCourse(cs);
            }
        }
    }
}