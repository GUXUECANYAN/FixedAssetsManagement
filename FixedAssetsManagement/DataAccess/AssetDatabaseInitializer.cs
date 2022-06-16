using FixedAssetsManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FixedAssetsManagement.DataAccess
{
    public class AssetDatabaseInitializer : DropCreateDatabaseIfModelChanges<AssetContext>
    {
        protected override void Seed(AssetContext context)
        {
            GetAssetCategories().ForEach(c => context.AssetCategories.Add(c));
            GetAssets().ForEach(a => context.Assets.Add(a));
            GetEmployees().ForEach(e => context.Employees.Add(e));
        }

        private static List<AssetCategory> GetAssetCategories()
        {
            var categories = new List<AssetCategory> {
            new AssetCategory
            {
                AssetCategoryID = 1,
                AssetCategoryName = "电脑类"
            },
            new AssetCategory
            {
                AssetCategoryID = 2,
                AssetCategoryName = "网络类"
            },
            new AssetCategory
            {
                AssetCategoryID = 3,
                AssetCategoryName = "空调类"
            },
            new AssetCategory
            {
                AssetCategoryID = 4,
                AssetCategoryName = "教学类"
            }
            };
            return categories;
        }

        private static List<Asset> GetAssets()
        {
            var assets = new List<Asset> {
                new Asset
                {
                    AssetID = 1,
                    AssetName = "格力空调1",
                    AssetSpecification = "外机尺寸:宽248mm,高502mm,深600mm;内机机身尺寸:宽292mm,高190mm,深720mm;电压/频率:220V/50Hz;外机净重:23kg;制冷剂:R22;内机净重:9kg",
                    AssetImage = "eed57e9fe0f19f13.jpg",
                    AssetPrice = 3000,
                    PurchaseDate="2019年5月21日",
                    StorageLocation = "第一教学楼301",
                    AssetCategoryID = 3,
                    EmployeeID = 1
                },
                new Asset
                {
                    AssetID = 2,
                    AssetName = "美的空调1",
                    AssetSpecification = "外机尺寸:宽248mm,高502mm,深600mm;内机机身尺寸:宽292mm,高190mm,深720mm;电压/频率:220V/50Hz;外机净重:23kg;制冷剂:R22;内机净重:9kg",
                    AssetImage = "91816a9e6da5385b.jpg",
                    AssetPrice = 2200,
                    PurchaseDate="2019年5月21日",
                    StorageLocation = "中巴软件楼104",
                    AssetCategoryID = 3,
                    EmployeeID = 2
                },
                new Asset
                {
                    AssetID = 3,
                    AssetName = "申花空调1",
                    AssetSpecification = "外机尺寸:宽248mm,高502mm,深600mm;内机机身尺寸:宽292mm,高190mm,深720mm;电压/频率:220V/50Hz;外机净重:23kg;制冷剂:R22;内机净重:9kg",
                    AssetImage = "830b9f637e76f815.jpg",
                    AssetPrice = 1300,
                    PurchaseDate="2019年3月15日",
                    StorageLocation = "第二教学楼510",
                    AssetCategoryID = 3,
                    EmployeeID = 1
                },
                new Asset
                {
                    AssetID = 4,
                    AssetName = "海尔空调1",
                    AssetSpecification = "内机机身尺寸:宽800mm,高300mm,深190mm;外机净重:27.5kg;电压/频率:220V/50Hz;外机尺寸:宽800mm；高545mm；深325mm;内机净重:9kg;制冷剂:R32",
                    AssetImage = "e35f1781602eb2b4.jpg",
                    AssetPrice = 1900,
                    PurchaseDate="2019年3月15日",
                    StorageLocation = "第二教学楼509",
                    AssetCategoryID = 3,
                    EmployeeID = 3
                },
                new Asset
                {
                    AssetID = 5,
                    AssetName = "松下投影仪1",
                    AssetSpecification = "整机功耗:300W;产品尺寸:长335mm,宽252mm,高96mm;产品净重:2.8kg;噪音(dB):38dB（普通模式）,35dB（节能模式）,30dB（低噪音模式）",
                    AssetImage = "530796561d142403.jpg",
                    AssetPrice = 2600,
                    PurchaseDate="2019年5月21日",
                    StorageLocation = "第一教学楼415",
                    AssetCategoryID = 4,
                    EmployeeID = 2
                },
                new Asset
                {
                    AssetID = 6,
                    AssetName = "先科投影仪1",
                    AssetSpecification = "遥控器控制方式:红外遥控;产品净重:2.4kg;噪音(dB):＜50dB;产品尺寸:长304mm,宽233mm,高107mm",
                    AssetImage = "cf6c0aa8318fb349.jpg",
                    AssetPrice = 1150,
                    PurchaseDate="2019年5月19日",
                    StorageLocation = "第一教学楼205",
                    AssetCategoryID = 4,
                    EmployeeID = 2
                },
                new Asset
                {
                    AssetID = 7,
                    AssetName = "互视达教学一体机1",
                    AssetSpecification = "云台控制:支持;带电池:不带电池;连接方式:无线;专用话机:不支持;是否支持串联:支持串联;主动降噪:支持主动降噪",
                    AssetImage = "81442baf2cbbe774.jpg",
                    AssetPrice = 5080,
                    PurchaseDate="2019年5月20日",
                    StorageLocation = "第三教学楼318",
                    AssetCategoryID = 4,
                    EmployeeID = 3
                },
                new Asset
                {
                    AssetID = 8,
                    AssetName = "凌昌教学一体机1",
                    AssetSpecification = "连接方式:USB;OPS电脑:I7/8G/256G;屏幕显示:彩色;手写触摸:支持手写触摸;接口:VGA,HDMI,AV,USB2.0,USB;是否支持视频会议:支持视频会议",
                    AssetImage = "4ea4e693940d822f.jpg",
                    AssetPrice = 29700,
                    PurchaseDate="2021年7月12日",
                    StorageLocation = "第三教学楼502",
                    AssetCategoryID = 4,
                    EmployeeID = 3
                },
                new Asset
                {
                    AssetID = 9,
                    AssetName = "富鑫通黑板1",
                    AssetSpecification = "商品毛重:10.0kg;板面颜色:绿色;是否带磁性:带磁;板面材质:金属烤漆;板面尺寸:120*240cm",
                    AssetImage = "1d128a7c1d53c100.jpg",
                    AssetPrice = 590,
                    PurchaseDate="2019年6月11日",
                    StorageLocation = "第一教学楼507",
                    AssetCategoryID = 4,
                    EmployeeID = 3
                },
                new Asset
                {
                    AssetID = 10,
                    AssetName = "联想电脑1",
                    AssetSpecification = "型号:M3900q;速度:DDR4;USB接口数:4个;CPU型号:AMD-A3050U;核心数:双核;转速:7200rpm;屏幕尺寸:19.5英寸",
                    AssetImage = "bd019ec1dd38cb07.jpg",
                    AssetPrice = 2100,
                    PurchaseDate="2020年8月4日",
                    StorageLocation = "中巴软件楼306",
                    AssetCategoryID = 1,
                    EmployeeID = 4
                },
                new Asset
                {
                    AssetID = 11,
                    AssetName = "联想电脑2",
                    AssetSpecification = "型号:M3900q;速度:DDR4;USB接口数:4个;CPU型号:AMD-A3050U;核心数:双核;转速:7200rpm;屏幕尺寸:19.5英寸",
                    AssetImage = "bd019ec1dd38cb07.jpg",
                    AssetPrice = 2100,
                    PurchaseDate="2020年8月4日",
                    StorageLocation = "中巴软件楼306",
                    AssetCategoryID = 1,
                    EmployeeID = 4
                },
                new Asset
                {
                    AssetID = 12,
                    AssetName = "联想电脑3",
                    AssetSpecification = "型号:M3900q;速度:DDR4;USB接口数:4个;CPU型号:AMD-A3050U;核心数:双核;转速:7200rpm;屏幕尺寸:19.5英寸",
                    AssetImage = "bd019ec1dd38cb07.jpg",
                    AssetPrice = 2100,
                    PurchaseDate="2020年8月4日",
                    StorageLocation = "中巴软件楼306",
                    AssetCategoryID = 1,
                    EmployeeID = 4
                },
                new Asset
                {
                    AssetID = 13,
                    AssetName = "联想电脑4",
                    AssetSpecification = "型号:510S;速度:DDR4;USB接口数:3个;CPU型号:i3-12100;核心数:四核;转速:7200rpm;屏幕尺寸:21.45英寸",
                    AssetImage = "7c5c21bec2157b81.jpg",
                    AssetPrice = 3200,
                    PurchaseDate="2020年8月4日",
                    StorageLocation = "中巴软件楼105",
                    AssetCategoryID = 1,
                    EmployeeID = 4
                },
                new Asset
                {
                    AssetID = 14,
                    AssetName = "戴尔服务器1",
                    AssetSpecification = "型号:R740;功率:750W;产品尺寸:长680mm,宽480mm,高88mm;产品净重（kg）:30;芯片组:集成显卡",
                    AssetImage = "7b0fcba7a00c0f70.jpg",
                    AssetPrice = 242888,
                    PurchaseDate="2020年12月30日",
                    StorageLocation = "中巴软件楼501",
                    AssetCategoryID = 2,
                    EmployeeID = 1
                },
                new Asset
                {
                    AssetID = 15,
                    AssetName = "优胜服务器1",
                    AssetSpecification = "型号:4028GR-TR;功率:700W;产品尺寸:长680mm,宽480mm,高88mm;产品净重（kg）:15;接口:SATA 串行",
                    AssetImage = "d5008d05d71cdf3c.jpg",
                    AssetPrice = 28888,
                    PurchaseDate="2020年12月30日",
                    StorageLocation = "中巴软件楼502",
                    AssetCategoryID = 1,
                    EmployeeID = 1
                },
                new Asset
                {
                    AssetID = 16,
                    AssetName = "超威服务器1",
                    AssetSpecification = "型号:超微 4029GP-TRT;功率:2000W;产品尺寸:长680mm,宽480mm,高88mm;产品净重（kg）:45;CPU缓存:13.75MB;CPU频率:2.2GHz",
                    AssetImage = "e3048e56a0e1e84b.jpg",
                    AssetPrice = 33500,
                    PurchaseDate="2020年11月11日",
                    StorageLocation = "第二教学楼502",
                    AssetCategoryID = 1,
                    EmployeeID = 2
                }
            };
            return assets;
        }

        private static List<Employee> GetEmployees()
        {
            var employees = new List<Employee> {
            new Employee
            {
                EmployeeID = 1,
                EmployeeName = "藤原千花",
                Password="123456",
                Telephone="15014456420",
                IsManager=false,
                Email="qianhua@163.com"
            },
            new Employee
            {
                EmployeeID = 2,
                EmployeeName = "甘雨",
                Password="123456",
                Telephone="15014456420",
                IsManager=false,
                Email="ganyu@163.com"
            },
            new Employee
            {
                EmployeeID = 3,
                EmployeeName = "高木",
                Password="123456",
                Telephone="15014456420",
                IsManager=false,
                Email="gaomu@163.com"
            },
            new Employee
            {
                EmployeeID = 4,
                EmployeeName = "西宫硝子",
                Password="123456",
                Telephone="15014456420",
                IsManager=false,
                Email="xiaozi@163.com"
            },
            new Employee
            {
                EmployeeID = 5,
                EmployeeName = "郑烨星",
                Password="123456",
                Telephone="15014456420",
                IsManager=true,
                Email="zyx@163.com"
            }
            };
            return employees;
        }
    }
}