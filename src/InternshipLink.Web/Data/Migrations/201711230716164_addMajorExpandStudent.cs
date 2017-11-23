namespace InternshipLink.Web.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addMajorExpandStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Majors",
                c => new
                    {
                        MajorID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => t.MajorID);
            
            AddColumn("dbo.Students", "MiddleName", c => c.String(maxLength: 40));
            AddColumn("dbo.Students", "StartYear", c => c.Int());
            AddColumn("dbo.Students", "MajorID", c => c.Int(nullable: false));
            AddColumn("dbo.Students", "Group", c => c.Int());
            CreateIndex("dbo.Students", "MajorID");
            AddForeignKey("dbo.Students", "MajorID", "dbo.Majors", "MajorID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "MajorID", "dbo.Majors");
            DropIndex("dbo.Students", new[] { "MajorID" });
            DropColumn("dbo.Students", "Group");
            DropColumn("dbo.Students", "MajorID");
            DropColumn("dbo.Students", "StartYear");
            DropColumn("dbo.Students", "MiddleName");
            DropTable("dbo.Majors");
        }
    }
}
