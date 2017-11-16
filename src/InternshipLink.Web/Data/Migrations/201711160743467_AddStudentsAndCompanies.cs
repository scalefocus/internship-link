namespace InternshipLink.Web.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentsAndCompanies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 80),
                        NumberOfEmployees = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 40),
                        LastName = c.String(maxLength: 40),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
            DropTable("dbo.Companies");
        }
    }
}
