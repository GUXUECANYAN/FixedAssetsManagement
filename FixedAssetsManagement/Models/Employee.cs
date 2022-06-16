using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FixedAssetsManagement.Models
{
    public class Employee
    {
        [ScaffoldColumn(false)]
        public int EmployeeID { get; set; }

        [StringLength(100), Display(Name = "姓名")]
        public string EmployeeName { get; set; }

        [Required, StringLength(100), Display(Name = "密码")]
        public string Password { get; set; }

        [StringLength(100), Display(Name = "电话")]
        public string Telephone { get; set; }

        [Required, Display(Name = "是否为管理员")]
        public bool IsManager { get; set; }

        [Required, StringLength(100), Display(Name = "邮箱")]
        public string Email { get; set; }
    }
}