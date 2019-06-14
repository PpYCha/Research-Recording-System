namespace ResearchRecordingSystemInCollegeOfScience.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorId = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(),
                        AuthorContactNumber = c.String(),
                        ThesisTitleId = c.Int(),
                    })
                .PrimaryKey(t => t.AuthorId)
                .ForeignKey("dbo.ResearchBooks", t => t.ThesisTitleId)
                .Index(t => t.ThesisTitleId);
            
            CreateTable(
                "dbo.ResearchBooks",
                c => new
                    {
                        ThesisTitleId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        PublishedYear = c.String(),
                        Remarks = c.String(),
                        CourseNameRb = c.String(),
                    })
                .PrimaryKey(t => t.ThesisTitleId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        CourseName = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.UserAccounts",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Username = c.String(),
                        UserPassword = c.String(),
                        UserRole = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Authors", "ThesisTitleId", "dbo.ResearchBooks");
            DropIndex("dbo.Authors", new[] { "ThesisTitleId" });
            DropTable("dbo.UserAccounts");
            DropTable("dbo.Courses");
            DropTable("dbo.ResearchBooks");
            DropTable("dbo.Authors");
        }
    }
}
