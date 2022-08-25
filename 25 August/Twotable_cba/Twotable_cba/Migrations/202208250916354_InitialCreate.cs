namespace Twotable_cba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Did = c.Int(nullable: false, identity: true),
                        Dname = c.String(),
                    })
                .PrimaryKey(t => t.Did);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Sid = c.Int(nullable: false, identity: true),
                        Sname = c.String(),
                        Semail = c.String(),
                        Spassword = c.String(),
                        Departments_Did = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Sid)
                .ForeignKey("dbo.Departments", t => t.Departments_Did, cascadeDelete: true)
                .Index(t => t.Departments_Did);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Departments_Did", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "Departments_Did" });
            DropTable("dbo.Students");
            DropTable("dbo.Departments");
        }
    }
}
