namespace COMP_4549_Assignment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "Name");
        }
    }
}
