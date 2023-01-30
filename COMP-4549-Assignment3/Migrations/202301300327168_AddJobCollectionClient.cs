namespace COMP_4549_Assignment3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJobCollectionClient : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ClientID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Clients", t => t.ClientID, cascadeDelete: true)
                .Index(t => t.ClientID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DOE = c.DateTime(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.Clients", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "Address", c => c.String());
            DropForeignKey("dbo.Jobs", "ClientID", "dbo.Clients");
            DropIndex("dbo.Jobs", new[] { "ClientID" });
            DropTable("dbo.Services");
            DropTable("dbo.Employees");
            DropTable("dbo.Jobs");
        }
    }
}
