namespace DocumentsNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TablePartStrings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GoodName = c.String(),
                        Quantity = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                        TablePartId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TableParts", t => t.TablePartId)
                .Index(t => t.TablePartId);
            
            DropColumn("dbo.TableParts", "TablePartString");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TableParts", "TablePartString", c => c.String());
            DropForeignKey("dbo.TablePartStrings", "TablePartId", "dbo.TableParts");
            DropIndex("dbo.TablePartStrings", new[] { "TablePartId" });
            DropTable("dbo.TablePartStrings");
        }
    }
}
