namespace Clouds.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addURLAsRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Airports", "URL", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Airports", "URL", c => c.String());
        }
    }
}
