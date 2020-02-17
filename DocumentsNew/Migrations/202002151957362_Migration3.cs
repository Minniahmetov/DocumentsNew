namespace DocumentsNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TablePartStrings", "GoodId", c => c.Int());
            CreateIndex("dbo.TablePartStrings", "GoodId");
            AddForeignKey("dbo.TablePartStrings", "GoodId", "dbo.Goods", "Id");
            DropColumn("dbo.TablePartStrings", "GoodName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TablePartStrings", "GoodName", c => c.String());
            DropForeignKey("dbo.TablePartStrings", "GoodId", "dbo.Goods");
            DropIndex("dbo.TablePartStrings", new[] { "GoodId" });
            AlterColumn("dbo.TablePartStrings", "GoodId", c => c.Int(nullable: false));
        }
    }
}
