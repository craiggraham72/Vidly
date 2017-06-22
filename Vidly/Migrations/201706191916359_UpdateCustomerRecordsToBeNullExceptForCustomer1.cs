namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomerRecordsToBeNullExceptForCustomer1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = NULL WHERE Id IN(2, 3)");
        }
        
        public override void Down()
        {
        }
    }
}
