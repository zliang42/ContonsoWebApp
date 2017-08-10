using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Service;

namespace ContosoWebApp.Courses
{
    public partial class CourseList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CourseService c = new CourseService();
                repeaterCourse.DataSource = c.GetAllCourse();
                repeaterCourse.DataBind();
            }
        }

        protected void repeaterCourse_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            var courseid = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "Edit")
            {
                Response.Redirect("EditCourse.aspx?id=" + courseid);
            }

            if (e.CommandName == "Delete")
            {
                CourseService service = new CourseService();
                service.DeleteCourse(courseid);
                Response.Redirect("CourseList.aspx");
            }

            if (e.CommandName == "Details")
            {
                Response.Redirect("DetailCourse.aspx?id=" + courseid);
            }
        }
    }
}