namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipNames : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes set Name = 'Pay as you go' where id = 1");
            Sql("Update MembershipTypes set Name = '6 Months' where id = 2");
            Sql("Update MembershipTypes set Name = '1 Year' where id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
