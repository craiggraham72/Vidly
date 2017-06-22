namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE MembershipTypes ADD MembershipTypeName nvarchar(255) NULL");
        }
        
        public override void Down()
        {
        }
    }
}
