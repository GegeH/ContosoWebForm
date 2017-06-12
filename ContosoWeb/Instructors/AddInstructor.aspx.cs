using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ContosoUtility;
using Contoso.Models;
using ContosoService;

namespace ContosoWeb.Instructors
{
    public partial class AddInstructor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ddlState.DataSource = Utility.GetAllStates();
                ddlState.DataTextField = "StateName";
                ddlState.DataValueField = "Value";
                ddlState.DataBind();
            }
        }

        protected void btnSaveInstructor_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelInstructor_Click(object sender, EventArgs e)
        {

        }
    }
}