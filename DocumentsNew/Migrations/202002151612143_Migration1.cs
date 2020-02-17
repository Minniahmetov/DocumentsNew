namespace DocumentsNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.TablePartStrings", "GoodId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TablePartStrings", "GoodId");
        }
    }
}
