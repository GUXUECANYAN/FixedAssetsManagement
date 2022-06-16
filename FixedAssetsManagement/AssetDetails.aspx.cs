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
    public partial class AssetDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
    }
}