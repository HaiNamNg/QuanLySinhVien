using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Models
{
    public class QuanLySinhVienDBcontext : DbContext
    {
        public QuanLySinhVienDBcontext() : base("QuanLySinhVienDBcontext")
        { 
        }
        public DbSet<HocPhan> HocPhans { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Khoa> Khoas { get; set; }              
        public DbSet<Lop> Lops { get; set; }
        public DbSet<SinhhVien> SinhhViens { get; set; }
        public DbSet<Diem> Diems { get; set; }

        public System.Data.Entity.DbSet<QuanLySinhVien.Models.GiaoVien> GiaoViens { get; set; }
    }
}
//DESKTOP-GIPHEE4\SQLEXPRESS