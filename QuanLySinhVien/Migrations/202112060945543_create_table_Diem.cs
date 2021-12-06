namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_Diem : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Diems",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaSinhVien = c.String(nullable: false),
                        HocKi = c.String(nullable: false),
                        DiemA = c.Double(nullable: false),
                        DiemB = c.Double(nullable: false),
                        DiemC = c.Double(nullable: false),
                        DiemTB = c.Double(nullable: false),
                        MaHocPhan = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Diems");
        }
    }
}
