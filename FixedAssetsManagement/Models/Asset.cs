using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FixedAssetsManagement.Models
{
    public class Asset
    {
        [ScaffoldColumn(false)]
        public int AssetID { get; set; }

        [Required, StringLength(100), Display(Name = "资产名")]
        public string AssetName { get; set; }

        [StringLength(300), Display(Name = "资产规格")]
        public string AssetSpecification { get; set; }

        public string AssetImage { get; set; }

        [Display(Name = "资产价格")]
        public double? AssetPrice { get; set; }

        [Required, StringLength(100), Display(Name = "购买日期")]
        public string PurchaseDate { get; set; }

        [Required, StringLength(300), Display(Name = "存放位置")]
        public string StorageLocation { get; set; }

        public int? AssetCategoryID { get; set; }

        public virtual AssetCategory AssetCategory { get; set; }

        public int? EmployeeID { get; set; }

        public virtual Employee Employee { get; set; }

    }
}