namespace WebPageEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleteBodyEtc : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.HtmlElements", newName: "SubTitles");
            DropForeignKey("dbo.HtmlElements", "footer_Id", "dbo.HtmlElements");
            DropIndex("dbo.SubTitles", new[] { "footer_Id" });
            CreateTable(
                "dbo.Titles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
           // DropColumn("dbo.SubTitles", "Discriminator");
            //DropColumn("dbo.SubTitles", "footer_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SubTitles", "footer_Id", c => c.Int());
            AddColumn("dbo.SubTitles", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropTable("dbo.Titles");
            CreateIndex("dbo.SubTitles", "footer_Id");
            AddForeignKey("dbo.HtmlElements", "footer_Id", "dbo.HtmlElements", "Id");
            RenameTable(name: "dbo.SubTitles", newName: "HtmlElements");
        }
    }
}
