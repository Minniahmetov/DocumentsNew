namespace DocumentsNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TablePartStrings", "Good_Id", c => c.Int());
            CreateIndex("dbo.TablePartStrings", "Good_Id");
            AddForeignKey("dbo.TablePartStrings", "Good_Id", "dbo.Goods", "Id");
            DropColumn("dbo.TablePartStrings", "GoodName");
            DropColumn("dbo.TablePartStrings", "GoodId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TablePartStrings", "GoodId", c => c.Int(nullable: false));
            AddColumn("dbo.TablePartStrings", "GoodName", c => c.String());
            DropForeignKey("dbo.TablePartStrings", "Good_Id", "dbo.Goods");
            DropIndex("dbo.TablePartStrings", new[] { "Good_Id" });
            DropColumn("dbo.TablePartStrings", "Good_Id");
        }
    }
}
