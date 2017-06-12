 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Contoso.Models;
using ContosoService;

namespace ContosoWeb.Departments
{
    public partial class DepartmentDetails : System.Web.UI.Page
    {
        private DepartmentService deptService = new DepartmentService();

        protected void Page_Load(object sender, EventArgs e)
        {
            string deptId = Request.QueryString["departmentId"];
            var department = deptService.GetDepartmentByID(Convert.ToInt32(deptId));
            labelID.Text = department.Id.ToString();
            labelName.Text = department.Name;
            labelBudget.Text = department.Budget.ToString();
            labelStartDate.Text = department.StartDate.ToString("mm/dd/yyyy");
            labelInstructorId.Text = department.InstructorId.ToString();
            labelRowVersion.Text = department.RowVersion.ToString();
            labelCreatedDate.Text = department.CreatedDate.ToString();
            labelCreatedBy.Text = department.CreatedBy.ToString();
            labelUpdatedDate.Text = department.UpdatedDate.ToString();
            labelUpdatedBy.Text = department.UpdatedBy.ToString();
        }
    }
}