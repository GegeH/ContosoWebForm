using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;
using ContosoRepository;
// using EFRepository;

namespace ContosoService
{
    public class DepartmentService
    {
        private DepartmentRepository deptRepo = new DepartmentRepository();
        public void SaveDepartment(Department dept)
        {
            deptRepo.AddDepartment(dept);
        }

        public List<Department> GetAllDepartments()
        {
            var department = deptRepo.GetAllDepartments();
            return department;
        }

        public Department GetDepartmentByID(int id)
        {
            var department = deptRepo.GetDepartmentById(id);
            return department;
        }
        public void UpdateDepartment(Department dept)
        {
            deptRepo.UpdateDepartment(dept);
        }
    }
}
