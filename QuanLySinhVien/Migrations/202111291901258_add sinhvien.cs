namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addsinhvien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SinhhViens",
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
        
        public override void Down()
        {
            DropTable("dbo.SinhhViens");
        }
    }
}
