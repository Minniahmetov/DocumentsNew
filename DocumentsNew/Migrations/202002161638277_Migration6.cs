namespace DocumentsNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration6 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TablePartStrings", "Good_Id", "dbo.Goods");
            DropIndex("dbo.TablePartStrings", new[] { "Good_Id" });
            AddColumn("dbo.TablePartStrings", "GoodId", c => c.Int(nullable: false));
            DropColumn("dbo.TablePartStrings", "Good_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TablePartStrings", "Good_Id", c => c.Int());
            DropColumn("dbo.TablePartStrings", "GoodId");
            CreateIndex("dbo.TablePartStrings", "Good_Id");
            AddForeignKey("dbo.TablePartStrings", "Good_Id", "dbo.Goods", "Id");
        }
    }
}
