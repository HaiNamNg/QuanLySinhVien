namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_GiaoVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GiaoViens",
                c => new
                    {
                        MaGV = c.String(nullable: false, maxLength: 128),
                        TenGV = c.String(nullable: false),
                        PhongBan = c.String(nullable: false),
                        HocPhanPhuTrach = c.String(),
                    })
                .PrimaryKey(t => t.MaGV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GiaoViens");
        }
    }
}
