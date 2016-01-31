namespace MyAveiro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Utilities", "URLImg", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Utilities", "URLImg");
        }
    }
}
