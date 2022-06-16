using FixedAssetsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FixedAssetsManagement
{
    public partial class AssetCategoryManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Manager"] != null) 
            {
                if (!IsPostBack)
                {
                    var _db = new AssetContext();
                    var result = _db.AssetCategories.ToList();
                    AssetCategoryGridView.DataSource = result;
                    AssetCategoryGridView.DataBind();
                }
            }
            else
            {
                Response.Redirect("EmployeeLogin.aspx");
            }
        }

        protected void AssetCategoryGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "AssetCategoryDe")
            {
                int AssetCategoryID = int.Parse(e.CommandArgument.ToString());
                var _db = new AssetContext();
                var result = _db.AssetCategories.Where(ac => ac.AssetCategoryID == AssetCategoryID).FirstOrDefault();
                _db.AssetCategories.Remove(result);
                _db.SaveChanges();
                Response.Redirect("AssetCategoryManagement.aspx");
            }
            if (e.CommandName == "AssetCategoryEd")
            {
                Response.Redirect("AssetCategoryEdit.aspx?AssetCategoryID=" + int.Parse(e.CommandArgument.ToString()));
            }
        }

        protected void AddAssetCategoryBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssetCategoryAdd.aspx");
        }
    }
}