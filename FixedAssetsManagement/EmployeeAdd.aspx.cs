using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FixedAssetsManagement.Models;


namespace FixedAssetsManagement
{
    public partial class EmployeeAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            Employee Employee = new Employee
            {
                EmployeeName = EmployeeNameTxt.Text,
                Password = EmployeePasswordTxt.Text,
                Telephone = EmployeeTelephoneTxt.Text,
                Email=EmployeeEmailTxt.Text,
                IsManager=IsManagerCheckBox.Checked
            };
            var _db = new AssetContext();
            _db.Employees.Add(Employee);
            _db.SaveChanges();
            Response.Redirect("EmployeeManagement.aspx");
        }
    }
}