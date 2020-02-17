namespace DocumentsNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Docs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        DocType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TableParts",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        TablePartString = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Docs", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TableParts", "Id", "dbo.Docs");
            DropIndex("dbo.TableParts", new[] { "Id" });
            DropTable("dbo.TableParts");
            DropTable("dbo.Docs");
        }
    }
}
