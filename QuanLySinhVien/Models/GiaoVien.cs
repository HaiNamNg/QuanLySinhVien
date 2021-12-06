using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class GiaoVien
    {

        [Key]
        public string MaGV { get; set; }


        [Required]
        public string TenGV { get; set; }

        [Required]
        public string PhongBan { get; set; }

        public string HocPhanPhuTrach { get; set; }
    }
}