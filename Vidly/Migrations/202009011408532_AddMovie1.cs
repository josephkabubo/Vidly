namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovie1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberInStock", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "NumerInStock");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "NumerInStock", c => c.Byte(nullable: false));
            DropColumn("dbo.Movies", "NumberInStock");
        }
    }
}
