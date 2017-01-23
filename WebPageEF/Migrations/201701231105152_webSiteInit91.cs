namespace WebPageEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class webSiteInit91 : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.WebSites", "WebPageId", c => c.Int(nullable: false));
            CreateIndex("dbo.WebSites", "WebPageId");
            AddForeignKey("dbo.WebSites", "WebPageId", "dbo.WebPages", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WebSites", "WebPageId", "dbo.WebPages");
            DropIndex("dbo.WebSites", new[] { "WebPageId" });
            DropColumn("dbo.WebSites", "WebPageId");
        }
    }
}
