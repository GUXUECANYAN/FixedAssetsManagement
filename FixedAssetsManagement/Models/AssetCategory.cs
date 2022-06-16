using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FixedAssetsManagement.Models
{
    public class AssetCategory
    {
        [ScaffoldColumn(false)]
        public int AssetCategoryID { get; set; }

        [Required, StringLength(100), Display(Name = "类别名称")]
        public string AssetCategoryName { get; set; }

        [StringLength(300), Display(Name = "类别说明")]
        public string AssetCategoryDescription { get; set; }
    }
}