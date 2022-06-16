using FixedAssetsManagement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FixedAssetsManagement
{
    public partial class AddAsset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var _db = new AssetContext();
                var AssetCategoryResult = _db.AssetCategories.ToList();
                AssetCategoryDropDownList.DataSource = AssetCategoryResult;
                AssetCategoryDropDownList.DataBind();
                var EmployeeResult = _db.Employees.ToList();
                EmployeeDropDownList.DataSource = EmployeeResult;
                EmployeeDropDownList.DataBind();
            }
        }

        protected void AddAssetBtn_Click(object sender, EventArgs e)
        {
            if (AssetImage.HasFile)
            {
                string FilePath = AssetImage.PostedFile.FileName;
                string FileName = FilePath.Substring(FilePath.LastIndexOf("\\") + 1);
                string ImageRootPath = Server.MapPath("./images/Assets/");
                AssetImage.SaveAs(ImageRootPath + FileName);
                Asset asset = new Asset
                {
                    AssetName = AssetNameTxt.Text,
                    PurchaseDate = AssetPurchaseDateTxt.Text,
                    StorageLocation = AssetLocationTxt.Text,
                    AssetPrice = int.Parse(AssetPrice.Text),
                    AssetSpecification = AssetSpecification.Text,
                    AssetCategoryID = int.Parse(AssetCategoryDropDownList.SelectedValue),
                    EmployeeID = int.Parse(EmployeeDropDownList.SelectedValue),
                    AssetImage = FileName
                };
                var _db = new AssetContext();
                _db.Assets.Add(asset);
                _db.SaveChanges();
                Response.Redirect("AssetManagement.aspx");
            }
            
        }
    }
}