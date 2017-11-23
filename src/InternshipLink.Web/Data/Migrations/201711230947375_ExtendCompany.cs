namespace InternshipLink.Web.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtendCompany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Email", c => c.String(maxLength: 100));
            AddColumn("dbo.Companies", "Description", c => c.String(maxLength: 200));
            AddColumn("dbo.Companies", "ContactNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Companies", "Address", c => c.String());
            AddColumn("dbo.Companies", "City", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "City");
            DropColumn("dbo.Companies", "Address");
            DropColumn("dbo.Companies", "ContactNumber");
            DropColumn("dbo.Companies", "Description");
            DropColumn("dbo.Companies", "Email");
        }
    }
}
