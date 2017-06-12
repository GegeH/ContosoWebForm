﻿using Contoso.Models;
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
    public partial class DepartmentEdit : System.Web.UI.Page
    {
        private DepartmentService deptService = new DepartmentService();
        int id;

        protected void Page_Load(object sender, EventArgs e)
        {
            string deptId = Request.QueryString["departmentId"];
            id = Convert.ToInt32(deptId);
            if (!Page.IsPostBack)
            {
                var department = deptService.GetDepartmentByID(Convert.ToInt32(deptId));
                txtDeptName.Text = department.Name;
                txtDeptBudget.Text = department.Budget.ToString();
                txtDeptStartDate.Text = department.StartDate.ToString("mm/dd/yyyy");
                //dropDownInstructor.DataSource = ;
                //dropDownInstructor.DataTextField = "";
                //dropDownInstructor.DataValueField = "";
                //dropDownInstructor.SelectedValue = "";
                //txtInstrutorId.Text = department.InstructorId.ToString();
                //ddlInstructor.select.Text = department.InstructorId.ToString();

                txtRowVer.Text = department.RowVersion.ToString();

                txtCreatedDate.Text = department.CreatedDate.ToString();
                txtCreatedBy.Text = department.CreatedBy.ToString();
                txtUpdatedDate.Text = department.UpdatedDate.ToString();
                txtUpdatedBy.Text = department.UpdatedBy.ToString();

                // labelRowVersion.Text = department.RowVersion.ToString();
                // labelCreatedDate.Text = department.CreatedDate.ToString();
                // labelCreatedBy.Text = department.CreatedBy.ToString();
                // labelUpdatedDate.Text = department.UpdatedDate.ToString();
                // labelUpdatedBy.Text = department.UpdatedBy.ToString();

                //string cs = ConfigurationManager.ConnectionStrings["ContosoDbContext"].ConnectionString;
                //SqlConnection connection = new SqlConnection(cs);
                //SqlCommand command = new SqlCommand("Select p.Id, p.FirstName + ' ' + p.LastName As 'FullName' From People p INNER JOIN Instructors i on p.Id = i.Id", connection);
                //connection.Open();
                //SqlDataAdapter sqlAdapter = new SqlDataAdapter(command);
                //DataSet ds = new DataSet();
                //sqlAdapter.Fill(ds);
                //ddlInstructor.DataSource = ds;
                //ddlInstructor.DataTextField = "FullName";
                //ddlInstructor.DataValueField = "Id";
                //ddlInstructor.DataBind();
                //connection.Dispose();
            }
        }

        protected void btnSaveDept_Click(object sender, EventArgs e)
        {
            string deptId = Request.QueryString["departmentId"];
            var departmentId = deptService.GetDepartmentByID(Convert.ToInt32(deptId));
            var department = new Department()
            {
                Id = id,
                Name = txtDeptName.Text,
                Budget = Convert.ToInt32(txtDeptBudget.Text),
                StartDate = Convert.ToDateTime(txtDeptStartDate.Text),
                //InstructorId = Convert.ToInt32(txtInstrutorId.Text),
                //InstructorId = Convert.ToInt32(txtInstrutorId.Text),
                RowVersion = 2,
                UpdatedDate = DateTime.Now,
                UpdatedBy = 1,
            };
            deptService.UpdateDepartment(department);
        }
    }
}