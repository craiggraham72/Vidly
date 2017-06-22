namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerTableAddBirthdateToCustomer1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = '1972-05-04' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
