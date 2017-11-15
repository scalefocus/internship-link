namespace InternshipLink.Web.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCompany : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Companies", "NumberOfEmployees", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Companies", "NumberOfEmployees");
        }
    }
}
