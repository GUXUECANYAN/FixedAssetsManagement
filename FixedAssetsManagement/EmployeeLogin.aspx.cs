using FixedAssetsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FixedAssetsManagement
{
    public partial class EmployeeLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            string Email = EmailTxt.Text;
            string Password = PasswordTxt.Text;
            var _db = new AssetContext();
            IQueryable<Employee> query = _db.Employees;
            IQueryable<Employee> NewQuery;
            if (Email!="" && Password!="")
            {
                NewQuery = query.Where(a => a.Email == Email && a.Password == Password);
                if (NewQuery.Count()!=0)
                {
                    if (NewQuery.First().IsManager)
                    {
                        Session["Manager"] = NewQuery;
                        Response.Redirect("AssetManagement.aspx");
                    }
                    else
                    {
                        Session["Employee"] = NewQuery;
                        Response.Redirect("AssetSearch.aspx");
                    }
                }
                else
                {
                    MessageLabel.Text = "此用户不存在";
                }
            }
            else
            {
                MessageLabel.Text = "邮箱或密码不能为空";
            }
        }
    }
}