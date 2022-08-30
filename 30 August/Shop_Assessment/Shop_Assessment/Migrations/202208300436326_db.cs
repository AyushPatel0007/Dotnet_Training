namespace Shop_Assessment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ViewAlls",
                c => new
                    {
                        Cid = c.Int(nullable: false, identity: true),
                        Cname = c.String(),
                        Pid = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Cid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ViewAlls");
        }
    }
}
