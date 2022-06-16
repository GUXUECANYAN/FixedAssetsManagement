using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FixedAssetsManagement.Models;


namespace FixedAssetsManagement
{
    public partial class AssetCategoryAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AddAssetCategoryBtn_Click(object sender, EventArgs e)
        {
            AssetCategory AssetCategory = new AssetCategory
            {
                AssetCategoryName = AssetCategoryNameTxt.Text,
                AssetCategoryDescription = AssetCategoryDescriptionTxt.Text
            };
            var _db = new AssetContext();
            _db.AssetCategories.Add(AssetCategory);
            _db.SaveChanges();
            Response.Redirect("AssetCategoryManagement.aspx");
        }
    }
}