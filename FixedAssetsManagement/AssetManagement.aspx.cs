using FixedAssetsManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FixedAssetsManagement
{
    public partial class AssetManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Manager"] == null)
            {
                Response.Redirect("EmployeeLogin");
            }
        }

        protected void SearchAssetBtn_Click(object sender, EventArgs e)
        {
            string SelectedValue = AssetDropDownList.SelectedValue;
            string SearchAssetValue = SearchAssetTxt.Text;
            switch (SelectedValue)
            {
                case "AssetID":
                    if (Regex.IsMatch(SearchAssetValue, @"^\d+$"))
                    {
                        Response.Redirect("AssetManagement.aspx?AssetID=" + Int32.Parse(SearchAssetValue));
                    }
                    else
                    {
                        MessageLabel.Text = "资产名称需为整数";
                        return;
                    }
                    break;
                case "AssetName":
                    Response.Redirect("AssetManagement.aspx?AssetName=" + SearchAssetValue);
                    break;
                case "AssetCategory":
                    Response.Redirect("AssetManagement.aspx?AssetCategory=" + SearchAssetValue);
                    break;
                case "AssetPurchaseDate":
                    Response.Redirect("AssetManagement.aspx?AssetPurchaseDate=" + SearchAssetValue);
                    break;
                case "AssetLocation":
                    Response.Redirect("AssetManagement.aspx?AssetLocation=" + SearchAssetValue);
                    break;
                case "AssetEmployee":
                    Response.Redirect("AssetManagement.aspx?AssetEmployeeName=" + SearchAssetValue);
                    break;
                default:
                    Response.Redirect("AssetManagement.aspx");
                    break;
            }
        }

        public IQueryable<Asset> GetAssets([QueryString("AssetID")] int? AssetID, [QueryString("AssetName")] string AssetName, [QueryString("AssetPurchaseDate")] string AssetPurchaseDate, [QueryString("AssetLocation")] string AssetLocation, [QueryString("AssetEmployeeName")] string AssetEmployeeName, [QueryString("AssetCategory")] string AssetCategory)
        {
            var _db = new AssetContext();
            IQueryable<Asset> query = _db.Assets;
            if (AssetID.HasValue && AssetID > 0)
            {
                query = query.Where(p => p.AssetID == AssetID);
            }
            if (AssetName != null)
            {
                query = query.Where(p => p.AssetName.Contains(AssetName));
            }
            if (AssetPurchaseDate != null)
            {
                query = query.Where(p => p.PurchaseDate == AssetPurchaseDate);
            }
            if (AssetLocation != null)
            {
                query = query.Where(p => p.StorageLocation.Contains(AssetLocation));
            }
            if (AssetEmployeeName != null)
            {
                query = query.Where(p => p.Employee.EmployeeName.Contains(AssetEmployeeName));
            }
            if (AssetCategory != null)
            {
                query = query.Where(p => p.AssetCategory.AssetCategoryName.Contains(AssetCategory));
            }
            return query;
        }

        protected void DeleteAssetBtn_Click(object sender, EventArgs e)
        {
            Button DeleteButton = (Button)sender;
            int AssetID=int.Parse(DeleteButton.Attributes["AssetID"]);
            var _db = new AssetContext();
            var result = _db.Assets.Where(a => a.AssetID == AssetID).FirstOrDefault();
            _db.Assets.Remove(result);
            _db.SaveChanges();
            Response.Redirect("AssetManagement.aspx");
        }

        protected void AddAssetBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddAsset.aspx");
        }
    }
}