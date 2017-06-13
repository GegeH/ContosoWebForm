using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFRepository;

namespace EFservice
{
    public class DepartmentService
    {
        public List<Department> GetAllDepts()
        {
            List<Department> departments = new List<Department>(); 
            using (var db = new ContosoEntities())
            {
                var result = db.GetAllDepartment();
                departments = db.Departments.ToList();
                foreach (var item in result)
                {
                    departments.Add(new Department
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Budget = item.Budget,
                        StartDate = item.StartDate,
                        InstructorId = item.InstructorId,
                        RowVersion = item.RowVersion,
                        CreatedDate = item.CreatedDate,
                        CreatedBy = item.CreatedBy,
                    });
                }
                return departments;
            }

        }
    }
}



