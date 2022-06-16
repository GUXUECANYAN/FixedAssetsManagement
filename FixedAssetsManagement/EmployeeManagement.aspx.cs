using FixedAssetsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FixedAssetsManagement
{
    public partial class EmployeeManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Manager"] != null)
            {
                if (!IsPostBack)
                {
                    var _db = new AssetContext();
                    var result = _db.Employees.ToList();
                    EmployeeGridView.DataSource = result;
                    EmployeeGridView.DataBind();
                }
            }
            else
            {
                Response.Redirect("EmployeeLogin.aspx");
            }
        }

        protected void EmployeeGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EmployeeDe")
            {
                int EmployeeID = int.Parse(e.CommandArgument.ToString());
                var _db = new AssetContext();
                var result = _db.Employees.Where(em => em.EmployeeID == EmployeeID).FirstOrDefault();
                _db.Employees.Remove(result);
                _db.SaveChanges();
                Response.Redirect("EmployeeManagement.aspx");
            }
            if (e.CommandName == "EmployeeEd")
            {
                Response.Redirect("EmployeeEdit.aspx?EmployeeID=" + int.Parse(e.CommandArgument.ToString()));
            }
        }

        protected void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeAdd.aspx");
        }
    }
}