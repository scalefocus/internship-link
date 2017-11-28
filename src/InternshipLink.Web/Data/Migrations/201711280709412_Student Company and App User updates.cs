namespace InternshipLink.Web.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentCompanyandAppUserupdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "Phone", c => c.String());
            AddColumn("dbo.Students", "UserID", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "StudentID", c => c.Int(nullable: false));
            DropColumn("dbo.Companies", "ContactNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Companies", "ContactNumber", c => c.Int(nullable: false));
            DropColumn("dbo.AspNetUsers", "StudentID");
            DropColumn("dbo.Students", "UserID");
            DropColumn("dbo.Companies", "Phone");
        }
    }
}
