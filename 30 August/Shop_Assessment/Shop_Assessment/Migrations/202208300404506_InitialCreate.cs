namespace Shop_Assessment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        Cname = c.String(),
                    })
                .PrimaryKey(t => t.Cid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Categories_Cid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Pid)
                .ForeignKey("dbo.Categories", t => t.Categories_Cid, cascadeDelete: true)
                .Index(t => t.Categories_Cid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Categories_Cid", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Categories_Cid" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
