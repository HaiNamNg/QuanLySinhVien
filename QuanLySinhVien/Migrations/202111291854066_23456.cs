namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _23456 : DbMigration
    {
        public override void Up()
        {
            
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.SinhVien",
                c => new
                    {
                        HoVaTen = c.String(nullable: false, maxLength: 128),
                        MaSinhVien = c.String(nullable: false),
                        GioiTinh = c.String(nullable: false),
                        DiaChi = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Sdt = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.HoVaTen);
            
        }
    }
}
