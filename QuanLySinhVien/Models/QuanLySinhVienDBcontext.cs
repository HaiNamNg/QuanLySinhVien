﻿using System;
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
    }
}
//DESKTOP-GIPHEE4\SQLEXPRESS