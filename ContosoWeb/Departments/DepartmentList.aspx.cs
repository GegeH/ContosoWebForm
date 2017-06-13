using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoService;
using Contoso.Models;
using EFRepository;
using EFservice;

namespace ContosoWeb.Departments
{
    public partial class DepartmentList : System.Web.UI.Page
    {
        private ContosoService.DepartmentService deptService = new ContosoService.DepartmentService();
        private EFservice.DepartmentService EFservice = new EFservice.DepartmentService();
        protected void Page_Load(object sender, EventArgs e)
        {
           //var departments = deptService.GetAllDepartments();
            var departments = EFservice.GetAllDepts();
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