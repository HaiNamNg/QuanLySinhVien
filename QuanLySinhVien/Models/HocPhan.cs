using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class HocPhan
    {
        [Key]
        [Required, MaxLength(20)]
        public string MaHocPhan { get; set; }
        [Required, MaxLength(20)]
        public string TenHocPhan { get; set; }
        [Required, MaxLength(20)]
        public string SoTinChi { get; set; }
    }
}