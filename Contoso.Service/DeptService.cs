using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Data;
using Contoso.Model;

namespace Contoso.Service
{
    public class DeptService
    {
        public List<Department> GetAllDepartment()
        {
            DepartmentRepository repository = new DepartmentRepository();
            var Department = repository.GetAll();
            return Department;

        }

        public void SaveDepartment(Department d)
        {
            DepartmentRepository repository = new DepartmentRepository();
            repository.CreateNew(d);
        }

        public Department GetDeptById(int id)
        {
            DepartmentRepository repository = new DepartmentRepository();
            return repository.GetById(id);

        }

        public void DeleteDepartment(int id)
        {
            DepartmentRepository repository = new DepartmentRepository();
            repository.DeleteById(id);
        }

        public void UpdateDept (Department dept)
        {
            DepartmentRepository repository = new DepartmentRepository();
            repository.Update(dept);
        }
    }
}
