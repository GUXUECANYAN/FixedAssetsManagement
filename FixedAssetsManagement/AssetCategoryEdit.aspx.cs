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
    public partial class AssetCategoryEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public IQueryable<AssetCategory> GetAssetCategory([QueryString("AssetCategoryID")] int? AssetCategoryID)
        {
            var _db = new AssetContext();
            IQueryable<AssetCategory> query = _db.AssetCategories;
            if (AssetCategoryID.HasValue && AssetCategoryID > 0)
            {
                query = query.Where(ac => ac.AssetCategoryID == AssetCategoryID);
            }
            else
            {
                query = null;
            }
            return query;
        }

        protected void SaveAssetCategoryBtn_Click(object sender, EventArgs e)
        {
            int AssetCategoryID= int.Parse(((TextBox)fvAssetCategory.FindControl("AssetCategoryIDTxt")).Text);
            string AssetCategoryName = ((TextBox)fvAssetCategory.FindControl("AssetCategoryNameTxt")).Text;
            string AssetCategoryDescription = ((TextBox)fvAssetCategory.FindControl("AssetCategoryDescriptionTxt")).Text;
            var _db = new AssetContext();
            var AssetCategory = _db.AssetCategories.FirstOrDefault(ac => ac.AssetCategoryID == AssetCategoryID);
            AssetCategory.AssetCategoryName = AssetCategoryName;
            AssetCategory.AssetCategoryDescription = AssetCategoryDescription;
            _db.SaveChanges();
            Response.Redirect("AssetCategoryManagement.aspx");
        }
    }
}