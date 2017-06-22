namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixMovieModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "NumberInStockMyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "NumberInStockMyProperty", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "NumberInStock");
        }
    }
}
