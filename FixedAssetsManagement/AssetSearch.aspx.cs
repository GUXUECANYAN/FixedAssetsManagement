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
    public partial class AssetSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Employee"] == null)
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
                        Response.Redirect("AssetSearch.aspx?AssetID=" + Int32.Parse(SearchAssetValue));
                    }
                    else
                    {
                        MessageLabel.Text = "资产名称需为整数";
                        return;
                    }
                    break;
                case "AssetName":
                    Response.Redirect("AssetSearch.aspx?AssetName=" + SearchAssetValue);
                    break;
                case "AssetCategory":
                    Response.Redirect("AssetSearch.aspx?AssetCategory=" + SearchAssetValue);
                    break;
                case "AssetPurchaseDate":
                    Response.Redirect("AssetSearch.aspx?AssetPurchaseDate=" + SearchAssetValue);
                    break;
                case "AssetLocation":
                    Response.Redirect("AssetSearch.aspx?AssetLocation=" + SearchAssetValue);
                    break;
                case "AssetEmployee":
                    Response.Redirect("AssetSearch.aspx?AssetEmployeeName=" + SearchAssetValue);
                    break;
                default:
                    Response.Redirect("AssetSearch.aspx");
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
    }
}