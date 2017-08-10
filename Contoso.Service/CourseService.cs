using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class CourseService
    {
        public List<Courses> GetAllCourse()
        {
            CourseRepository repository = new CourseRepository();
            var Course = repository.GetAll();
            return Course;

        }

        public void SaveCourse(Courses c)
        {
            CourseRepository repository = new CourseRepository();
            repository.CreateNew(c);
        }

        public Courses GetCourseById(int id)
        {
            CourseRepository repository = new CourseRepository();
            return repository.GetById(id);

        }

        public void DeleteCourse(int id)
        {
            CourseRepository repository = new CourseRepository();
            repository.DeleteById(id);
        }

        public void UpdateCourse (Courses course)
        {
            CourseRepository repository = new CourseRepository();
            repository.Update(course);
        }
    }
}
