namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HocPhans",
                c => new
                    {
                        MaHocPhan = c.String(nullable: false, maxLength: 20),
                        TenHocPhan = c.String(nullable: false, maxLength: 20),
                        SoTinChi = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.MaHocPhan);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HocPhans");
        }
    }
}
