using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;
using ContosoRepository;

namespace ContosoSample.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DepartmentRepository deptRepo = new DepartmentRepository();

            Console.WriteLine("********* Get All Departments *********");
            var department = deptRepo.GetAllDepartments();
            department.ForEach(x => Console.WriteLine("Id = {0}, Name: {1}, Budget: {2}", x.Id, x.Name, x.Budget));

            Console.WriteLine();
            Console.WriteLine("********* Get Department By Name *********");
            var deptByName = deptRepo.GetDepartmentByName("English");
            Console.WriteLine("{0} Department: ID = {1}, Budget = {2}, From {3}",
                                deptByName.Name, deptByName.Id, deptByName.Budget, deptByName.StartDate);

            Console.WriteLine();
            Console.WriteLine("********* Get Department By ID *********");
            var deptByID = deptRepo.GetDepartmentById(2);
            Console.WriteLine("Department with ID = {0} : Name: {1}, Budget = {2}, From {3}",
                               deptByID.Id, deptByID.Name, deptByID.Budget, deptByID.StartDate);

            //Console.WriteLine();
            //Console.WriteLine("********* Insert Department *********");
            //Department insertDept = new Department()
            //{
            //    Name = "Service",
            //    Budget = 15000,
            //    StartDate = new DateTime(2012, 05, 05),
            //    InstructorId = 1,
            //    RowVersion = 2,
            //    CreatedDate = new DateTime(2013, 05, 05),
            //    CreatedBy = 2,
            //    UpdatedDate = new DateTime(2014, 05, 05),
            //    UpdatedBy = 1
            //};
            //deptRepo.AddDepartment(insertDept);
            //department = deptRepo.GetAllDepartments();
            //department.ForEach(x => Console.WriteLine("Id = {0}, Name: {1}, Budget: {2}", x.Id, x.Name, x.Budget));

            //Console.WriteLine();
            //Console.WriteLine("********* Delete Department *********");
            //deptRepo.DeleteDepartmentById(7);
            //department = deptRepo.GetAllDepartments();
            //department.ForEach(x => Console.WriteLine("Id = {0}, Name: {1}, Budget: {2}", x.Id, x.Name, x.Budget));

            //Console.WriteLine();
            //Console.WriteLine("********* Update Department *********");
            //var updateDept = new Department()
            //{
            //    Id = 4,
            //    Name = "Service!!!",
            //    Budget = 15000,
            //    StartDate = new DateTime(2012, 05, 05),
            //    InstructorId = 1,
            //    RowVersion = 2,
            //    CreatedDate = new DateTime(2013, 05, 05),
            //    CreatedBy = 2,
            //    UpdatedDate = new DateTime(2014, 05, 05),
            //    UpdatedBy = 1
            //};
            //deptRepo.UpdateDepartment(updateDept);
            //department = deptRepo.GetAllDepartments();
            //department.ForEach(x => Console.WriteLine("Id = {0}, Name: {1}, Budget: {2}", x.Id, x.Name, x.Budget));

            Console.ReadKey();
        }
    }
}
