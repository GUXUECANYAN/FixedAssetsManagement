using FixedAssetsManagement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FixedAssetsManagement
{
    public partial class AssetDetailManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var _db = new AssetContext();
                var AssetCategoryResult = _db.AssetCategories.ToList();
                DropDownList AssetCategoryDropDownList = (DropDownList)fvAssetDetails.FindControl("AssetCategoryDropDownList");
                AssetCategoryDropDownList.DataSource = AssetCategoryResult;
                AssetCategoryDropDownList.DataBind();
                AssetCategoryDropDownList.SelectedIndex = AssetCategoryDropDownList.Items.IndexOf(AssetCategoryDropDownList.Items.FindByText(AssetCategoryDropDownList.Attributes["AssetCategoryName"]));
                var EmployeeResult = _db.Employees.ToList();
                DropDownList EmployeeDropDownList = (DropDownList)fvAssetDetails.FindControl("EmployeeDropDownList");
                EmployeeDropDownList.DataSource = EmployeeResult;
                EmployeeDropDownList.DataBind();
                EmployeeDropDownList.SelectedIndex=EmployeeDropDownList.Items.IndexOf(EmployeeDropDownList.Items.FindByText(EmployeeDropDownList.Attributes["EmployeeName"]));
            }
        }
        public IQueryable<Asset> GetAsset([QueryString("AssetID")] int? AssetID)
        {
            var _db = new AssetContext();
            IQueryable<Asset> query = _db.Assets;
            if (AssetID.HasValue && AssetID > 0)
            {
                query = query.Where(a => a.AssetID == AssetID);
            }
            else
            {
                query = null;
            }
            return query;
        }

        protected void SaveAssetBtn_Click(object sender, EventArgs e)
        {
            int AssetID = int.Parse(((TextBox)fvAssetDetails.FindControl("AssetIDTxt")).Text);
            string AssetName = ((TextBox)fvAssetDetails.FindControl("AssetNameTxt")).Text;
            string PurchaseDate = ((TextBox)fvAssetDetails.FindControl("PurchaseDateTxt")).Text;
            string AssetLocation = ((TextBox)fvAssetDetails.FindControl("AssetLocationTxt")).Text;
            int AssetPrice = int.Parse(((TextBox)fvAssetDetails.FindControl("AssetPrice")).Text);
            string AssetSpecification = ((TextBox)fvAssetDetails.FindControl("AssetSpecification")).Text;
            int AssetCategory = int.Parse(((DropDownList)fvAssetDetails.FindControl("AssetCategoryDropDownList")).SelectedValue);
            int Employee = int.Parse(((DropDownList)fvAssetDetails.FindControl("EmployeeDropDownList")).SelectedValue);
            FileUpload AssetImageFileUpload = ((FileUpload)fvAssetDetails.FindControl("EditAssetImage"));
            string NewFilePath="";
            string NewFileName="";
            var _db = new AssetContext();
            var Asset = _db.Assets.FirstOrDefault(a => a.AssetID == AssetID);
            Asset.AssetName = AssetName;
            Asset.PurchaseDate = PurchaseDate;
            Asset.StorageLocation = AssetLocation;
            Asset.AssetPrice = AssetPrice;
            Asset.AssetSpecification = AssetSpecification;
            Asset.AssetCategoryID = AssetCategory;
            Asset.EmployeeID = Employee;
            if (AssetImageFileUpload.HasFile)
            {
                string ImageRootPath = Server.MapPath("./images/Assets/");
                string OldFilePath = ImageRootPath + AssetImageFileUpload.Attributes["AssetImage"];
                File.Delete(OldFilePath);
                NewFilePath = AssetImageFileUpload.FileName;
                NewFileName = NewFilePath.Substring(NewFilePath.LastIndexOf("\\") + 1);
                AssetImageFileUpload.SaveAs(ImageRootPath + NewFileName);
                Asset.AssetImage = NewFileName;
            }
            _db.SaveChanges();
            Response.Redirect("AssetManagement.aspx");
        }
    }
}