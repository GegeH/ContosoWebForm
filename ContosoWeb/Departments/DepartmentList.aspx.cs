using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoService;
using Contoso.Models;

namespace ContosoWeb.Departments
{
    public partial class DepartmentList : System.Web.UI.Page
    {
        private DepartmentService deptService = new DepartmentService();

        protected void Page_Load(object sender, EventArgs e)
        {
            var departments = deptService.GetAllDepartments();
            rptDepartmentList.DataSource = departments;
            rptDepartmentList.DataBind();
        }

        protected void rptDepartmentList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Details")
            {
                var departmentId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("DepartmentDetails.aspx?DepartmentId=" + departmentId.ToString());
            }
            if (e.CommandName == "Edit")
            {
                var departmentId = Convert.ToInt32(e.CommandArgument);
                Response.Redirect("DepartmentEdit.aspx?DepartmentId=" + departmentId.ToString());
            }
        }
    }
}