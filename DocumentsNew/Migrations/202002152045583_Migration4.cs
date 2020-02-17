namespace DocumentsNew.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GoodBalnces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GoodId = c.Int(nullable: false),
                        DocId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Flow = c.Int(nullable: false),
                        Cancellaton = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropColumn("dbo.Goods", "Balance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Goods", "Balance", c => c.Int(nullable: false));
            DropTable("dbo.GoodBalnces");
        }
    }
}
