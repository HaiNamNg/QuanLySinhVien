using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class Diem
    {
        [Key]
        public int ID { get; set; }

        

        [Required]
        public string HocKi { get; set; }

        public double DiemA { get; set; }

        public double DiemB { get; set; }

        public double DiemC { get; set; }

        public double DiemTB { get; set; }
        [Required]
        public string MaSinhVien { get; set; }

        public string MaHocPhan { get; set; }
        [ForeignKey("MaHocPhan")]
        public virtual HocPhan HocPhan { get; set; }
    }
       
}