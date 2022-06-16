using FixedAssetsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FixedAssetsManagement
{
    public partial class EmployeeEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Employee> GetEmployee([QueryString("EmployeeID")] int? EmployeeID)
        {
            var _db = new AssetContext();
            IQueryable<Employee> query = _db.Employees;
            if (EmployeeID.HasValue && EmployeeID > 0)
            {
                query = query.Where(e => e.EmployeeID == EmployeeID);
            }
            else
            {
                query = null;
            }
            return query;
        }

        protected void SaveEmployeeBtn_Click(object sender, EventArgs e)
        {
            int EmployeeID = int.Parse(((TextBox)fvEmployee.FindControl("EmployeeIDTxt")).Text);
            string EmployeeName = ((TextBox)fvEmployee.FindControl("EmployeeNameTxt")).Text;
            string EmployeePassword = ((TextBox)fvEmployee.FindControl("EmployeePasswordTxt")).Text;
            string EmployeeTelephone = ((TextBox)fvEmployee.FindControl("EmployeeTelephoneTxt")).Text;
            string EmployeeEmail = ((TextBox)fvEmployee.FindControl("EmployeeEmailTxt")).Text;
            bool IsManager = ((CheckBox)fvEmployee.FindControl("IsManagerCheckBox")).Checked;
            var _db = new AssetContext();
            var Employee = _db.Employees.FirstOrDefault(em => em.EmployeeID == EmployeeID);
            Employee.EmployeeName = EmployeeName;
            Employee.Password = EmployeePassword;
            Employee.Telephone = EmployeeTelephone;
            Employee.Email = EmployeeEmail;
            Employee.IsManager = IsManager;
            _db.SaveChanges();
            Response.Redirect("EmployeeManagement.aspx");
        }
    }
}