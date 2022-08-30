namespace Shop_Assessment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class db1 : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.sp_InsertCategory",
                p => new
                    {
                        name = p.String(),
                    },
                body:
                    @"INSERT [dbo].[Categories]([Cname])
                      VALUES (@name)
                      
                      DECLARE @Cid int
                      SELECT @Cid = [Cid]
                      FROM [dbo].[Categories]
                      WHERE @@ROWCOUNT > 0 AND [Cid] = scope_identity()
                      
                      SELECT t0.[Cid] AS Id
                      FROM [dbo].[Categories] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Cid] = @Cid"
            );
            
            CreateStoredProcedure(
                "dbo.Category_Update",
                p => new
                    {
                        Cid = p.Int(),
                        Cname = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[Categories]
                      SET [Cname] = @Cname
                      WHERE ([Cid] = @Cid)"
            );
            
            CreateStoredProcedure(
                "dbo.Category_Delete",
                p => new
                    {
                        Cid = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Categories]
                      WHERE ([Cid] = @Cid)"
            );
            
            CreateStoredProcedure(
                "dbo.sp_InsertProduct",
                p => new
                    {
                        name = p.String(),
                        price = p.Int(),
                        cid = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Products]([Name], [Price], [Categories_Cid])
                      VALUES (@name, @price, @cid)
                      
                      DECLARE @Pid int
                      SELECT @Pid = [Pid]
                      FROM [dbo].[Products]
                      WHERE @@ROWCOUNT > 0 AND [Pid] = scope_identity()
                      
                      SELECT t0.[Pid] AS Id
                      FROM [dbo].[Products] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Pid] = @Pid"
            );
            
            CreateStoredProcedure(
                "dbo.sp_UpdateProduct",
                p => new
                    {
                        Pid = p.Int(),
                        name = p.String(),
                        price = p.Int(),
                        cid = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Products]
                      SET [Name] = @name, [Price] = @price, [Categories_Cid] = @cid
                      WHERE ([Pid] = @Pid)"
            );
            
            CreateStoredProcedure(
                "dbo.sp_DeleteProduct",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Products]
                      WHERE ([Pid] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.sp_DeleteProduct");
            DropStoredProcedure("dbo.sp_UpdateProduct");
            DropStoredProcedure("dbo.sp_InsertProduct");
            DropStoredProcedure("dbo.Category_Delete");
            DropStoredProcedure("dbo.Category_Update");
            DropStoredProcedure("dbo.sp_InsertCategory");
        }
    }
}
