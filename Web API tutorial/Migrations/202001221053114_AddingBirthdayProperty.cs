namespace Web_API_tutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBirthdayProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
