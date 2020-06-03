namespace VidMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            Sql("Insert Into MembershipTypes (Id , Name, signUpFee ,DurationInMonth ,DiscountRate) Values(1 ,'Pay as you go' ,0,0,0) ");
            Sql("Insert Into MembershipTypes (Id , Name, signUpFee ,DurationInMonth ,DiscountRate) Values(2 ,'Monthly',9,1,10) ");
            Sql("Insert Into MembershipTypes (Id , Name, signUpFee ,DurationInMonth ,DiscountRate) Values(3 ,'Quaterly',15,3,15) ");
            Sql("Insert Into MembershipTypes (Id , Name ,signUpFee ,DurationInMonth ,DiscountRate) Values(4 ,'Yearly',100,12,20) ");

        }

        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
