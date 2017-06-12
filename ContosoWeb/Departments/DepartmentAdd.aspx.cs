using Contoso.Models;
using ContosoService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContosoWeb.Departments
{
    public partial class DepartmentAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["ContosoDbContext"].ConnectionString;
            SqlConnection connection = new SqlConnection(cs);
            SqlCommand command = new SqlCommand("Select p.Id, p.FirstName + ' ' + p.LastName As 'FullName' From People p INNER JOIN Instructors i on p.Id = i.Id", connection);

            connection.Open();
            SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            sqlAdapter.Fill(ds);
            ddlInstructor.DataSource = ds;
            ddlInstructor.DataTextField = "FullName";
            ddlInstructor.DataValueField = "Id";
            ddlInstructor.DataBind();
            connection.Dispose();
        }

        protected void btnSaveDept_Click(object sender, EventArgs e)
        {
            var department = new Department()
            {
                Name = txtDeptName.Text,
                Budget = Convert.ToInt32(txtDeptBudget.Text),
                StartDate = Convert.ToDateTime(txtDeptStartDate.Text),
                InstructorId = Convert.ToInt32(ddlInstructor.Text),
                RowVersion = 1,
                CreatedDate = null,
                CreatedBy = null,
            };
            new DepartmentService().SaveDepartment(department);
        }
    }
    
}