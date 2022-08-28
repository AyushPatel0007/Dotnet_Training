namespace CBA_P1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        Cname = c.String(),
                        Caddress = c.String(),
                        Products_Pid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cid)
                .ForeignKey("dbo.Products", t => t.Products_Pid, cascadeDelete: true)
                .Index(t => t.Products_Pid);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Pid = c.Int(nullable: false, identity: true),
                        Pname = c.String(),
                        Price = c.Int(nullable: false),
                        Purchase = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Pid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Products_Pid", "dbo.Products");
            DropIndex("dbo.Customers", new[] { "Products_Pid" });
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
        }
    }
}
