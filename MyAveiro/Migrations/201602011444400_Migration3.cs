namespace MyAveiro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ImagesRepositories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        URLImage = c.String(),
                        Utilities_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Utilities", t => t.Utilities_ID)
                .Index(t => t.Utilities_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImagesRepositories", "Utilities_ID", "dbo.Utilities");
            DropIndex("dbo.ImagesRepositories", new[] { "Utilities_ID" });
            DropTable("dbo.ImagesRepositories");
        }
    }
}
