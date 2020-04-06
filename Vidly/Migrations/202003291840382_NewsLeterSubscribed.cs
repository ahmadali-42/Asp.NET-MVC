namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewsLeterSubscribed : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsNewsLetterSubscribed", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsNewsLetterSubscribed");
        }
    }
}
