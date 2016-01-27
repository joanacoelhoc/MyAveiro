namespace MyAveiro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UtilityID = c.Int(nullable: false),
                        CompleteName = c.String(),
                        Acronym = c.String(),
                        PhoneNumber = c.String(),
                        AddressNumber = c.String(),
                        Email = c.String(),
                        URLSite = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UtilitiesTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UtilityName = c.String(),
                        Utilities_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Utilities", t => t.Utilities_ID)
                .Index(t => t.Utilities_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UtilitiesTypes", "Utilities_ID", "dbo.Utilities");
            DropIndex("dbo.UtilitiesTypes", new[] { "Utilities_ID" });
            DropTable("dbo.UtilitiesTypes");
            DropTable("dbo.Utilities");
        }
    }
}
