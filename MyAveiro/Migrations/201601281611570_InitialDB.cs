namespace MyAveiro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EventTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FoodTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FoodTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.FunTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FunTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.RestTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RestTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Utilities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Acronym = c.String(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        URLSite = c.String(),
                        EventTypes_ID = c.Int(),
                        FoodTypes_ID = c.Int(),
                        FunTypes_ID = c.Int(),
                        RestTypes_ID = c.Int(),
                        UtilitiesTypes_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.EventTypes", t => t.EventTypes_ID)
                .ForeignKey("dbo.FoodTypes", t => t.FoodTypes_ID)
                .ForeignKey("dbo.FunTypes", t => t.FunTypes_ID)
                .ForeignKey("dbo.RestTypes", t => t.RestTypes_ID)
                .ForeignKey("dbo.UtilitiesTypes", t => t.UtilitiesTypes_ID)
                .Index(t => t.EventTypes_ID)
                .Index(t => t.FoodTypes_ID)
                .Index(t => t.FunTypes_ID)
                .Index(t => t.RestTypes_ID)
                .Index(t => t.UtilitiesTypes_ID);
            
            CreateTable(
                "dbo.UtilitiesTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UtilityTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Utilities", "UtilitiesTypes_ID", "dbo.UtilitiesTypes");
            DropForeignKey("dbo.Utilities", "RestTypes_ID", "dbo.RestTypes");
            DropForeignKey("dbo.Utilities", "FunTypes_ID", "dbo.FunTypes");
            DropForeignKey("dbo.Utilities", "FoodTypes_ID", "dbo.FoodTypes");
            DropForeignKey("dbo.Utilities", "EventTypes_ID", "dbo.EventTypes");
            DropIndex("dbo.Utilities", new[] { "UtilitiesTypes_ID" });
            DropIndex("dbo.Utilities", new[] { "RestTypes_ID" });
            DropIndex("dbo.Utilities", new[] { "FunTypes_ID" });
            DropIndex("dbo.Utilities", new[] { "FoodTypes_ID" });
            DropIndex("dbo.Utilities", new[] { "EventTypes_ID" });
            DropTable("dbo.UtilitiesTypes");
            DropTable("dbo.Utilities");
            DropTable("dbo.RestTypes");
            DropTable("dbo.FunTypes");
            DropTable("dbo.FoodTypes");
            DropTable("dbo.EventTypes");
        }
    }
}
