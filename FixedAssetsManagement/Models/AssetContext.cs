using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FixedAssetsManagement.Models
{
    public class AssetContext:DbContext
    {
        public AssetContext() : base("AssetDatabase")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetCategory> AssetCategories { get; set; }
    }
}