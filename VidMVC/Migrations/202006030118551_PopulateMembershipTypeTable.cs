namespace VidMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into MembershipTypes (Id ,  signUpFee ,DurationInMonth ,DiscountRate) Values(1 ,0,0,0) "); 
            Sql("Insert Into MembershipTypes (Id ,  signUpFee ,DurationInMonth ,DiscountRate) Values(2 ,9,1,10) "); 
            Sql("Insert Into MembershipTypes (Id ,  signUpFee ,DurationInMonth ,DiscountRate) Values(3 ,15,3,15) "); 
            Sql("Insert Into MembershipTypes (Id , signUpFee ,DurationInMonth ,DiscountRate) Values(4 ,100,12,20) "); 
        }
        
        public override void Down()
        {

        }
    }
}
