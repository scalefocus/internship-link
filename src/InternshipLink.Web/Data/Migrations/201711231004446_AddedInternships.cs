namespace InternshipLink.Web.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedInternships : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Internships",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        StartDate = c.Int(nullable: false),
                        EndDate = c.Int(nullable: false),
                        StudentID = c.Long(nullable: false),
                        CompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Companies", t => t.CompanyID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Internships", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Internships", "CompanyID", "dbo.Companies");
            DropIndex("dbo.Internships", new[] { "CompanyID" });
            DropIndex("dbo.Internships", new[] { "StudentID" });
            DropTable("dbo.Internships");
        }
    }
}
