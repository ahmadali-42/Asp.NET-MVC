namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertIntoTypes : DbMigration
    {
        public override void Up()
        {
            Sql("insert into MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) values(1,0,0,0)");
            Sql("insert into MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) values(2,30,20,6)");
            Sql("insert into MembershipTypes(Id, SignupFee, DurationInMonths, DiscountRate) values(3,90,30,12)");
        }
        
        public override void Down()
        {
        }
    }
}
