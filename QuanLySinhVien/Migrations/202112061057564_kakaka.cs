namespace QuanLySinhVien.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kakaka : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Diems", "MaHocPhan", c => c.String(maxLength: 20));
            CreateIndex("dbo.Diems", "MaHocPhan");
            AddForeignKey("dbo.Diems", "MaHocPhan", "dbo.HocPhans", "MaHocPhan");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Diems", "MaHocPhan", "dbo.HocPhans");
            DropIndex("dbo.Diems", new[] { "MaHocPhan" });
            AlterColumn("dbo.Diems", "MaHocPhan", c => c.String());
        }
    }
}
