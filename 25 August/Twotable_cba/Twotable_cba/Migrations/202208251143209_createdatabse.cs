namespace Twotable_cba.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdatabse : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Sname", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Semail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Semail", c => c.String());
            AlterColumn("dbo.Students", "Sname", c => c.String());
        }
    }
}
