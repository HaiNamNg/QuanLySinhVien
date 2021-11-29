using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class SinhhVien
    {
        [Key]
        [Required(ErrorMessage = "Ten sinh vien khong duoc de trong")]
        public string HoVaTen { get; set; }
        [Required]
        public string MaSinhVien { get; set; }
        [Required]
        public string GioiTinh { get; set; }
        [Required]
        public string DiaChi { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Sdt { get; set; }
    }
}