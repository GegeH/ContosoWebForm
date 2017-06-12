using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ContosoRepository
{
    public class DepartmentRepository
    {
        string cs = ConfigurationManager.ConnectionStrings["ContosoDbContext"].ConnectionString;

        public List<Department> GetAllDepartments()
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("GetAllDepartment", connection);
            List<Department> depList = new List<Department>();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Department dept = new Department();
                    dept.Id = Convert.ToInt32(reader["Id"]);
                    dept.Name = Convert.ToString(reader["name"]);
                    dept.Budget = Convert.ToInt32(reader["Budget"]);
                    depList.Add(dept);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Dispose();
            }

            return depList;
        }

        public Department GetDepartmentByName(string name)
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("GetDepartmentByName", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", name);
            Department dept = new Department();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                dept.Name = Convert.ToString(reader["name"]);
                dept.Id = Convert.ToInt32(reader["Id"]);
                dept.Budget = Convert.ToInt32(reader["Budget"]);
                dept.StartDate = Convert.ToDateTime(reader["StartDate"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Dispose();
            }
            return dept;
        }

        public Department GetDepartmentById(int id)
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("GetDeparmentById", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            Department dept = new Department();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                dept.Id = Convert.ToInt32(reader["Id"]);
                dept.Name = Convert.ToString(reader["name"]);
                dept.Budget = Convert.ToInt32(reader["Budget"]);
                dept.StartDate = Convert.ToDateTime(reader["StartDate"]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Dispose();
            }
            return dept;
        }

        public void AddDepartment(Department dept)
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("InsertDepartment", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Name", dept.Name);
            command.Parameters.AddWithValue("@Budget", dept.Budget);
            command.Parameters.AddWithValue("@StartDate", dept.StartDate);
            command.Parameters.AddWithValue("@InstructorId", dept.InstructorId);
            command.Parameters.AddWithValue("@RowVersion", dept.RowVersion);
            //command.Parameters.AddWithValue("@CreatedDate", dept.CreatedDate);
            command.Parameters.AddWithValue("@CreatedDate", DBNull.Value);
            //command.Parameters.AddWithValue("@CreatedBy", dept.CreatedBy);
            command.Parameters.AddWithValue("@CreatedBy", DBNull.Value);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public void DeleteDepartmentById(int id)
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("DeleteDepartmentById", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Dispose();
            }
        }

        public void UpdateDepartment(Department dept)
        {
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("UpdateDepartment", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", dept.Id);
            command.Parameters.AddWithValue("@Name", dept.Name);
            command.Parameters.AddWithValue("@Budget", dept.Budget);
            command.Parameters.AddWithValue("@InstructorId", dept.InstructorId);
            command.Parameters.AddWithValue("@StartDate", dept.StartDate);
            command.Parameters.AddWithValue("@RowVersion", dept.RowVersion);
            //command.Parameters.AddWithValue("@UpdatedDate", dept.UpdatedDate);
            command.Parameters.AddWithValue("@UpdatedDate", DBNull.Value);
            //command.Parameters.AddWithValue("@UpdatedBy", dept.UpdatedBy);
            command.Parameters.AddWithValue("@UpdatedBy", DBNull.Value);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                connection.Dispose();
            }
        }

    }
}
