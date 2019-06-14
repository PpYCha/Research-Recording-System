namespace ResearchRecordingSystemInCollegeOfScience.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class classification : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classifacations",
                c => new
                    {
                        ClassificationId = c.Int(nullable: false, identity: true),
                        ClassificationName = c.String(),
                        CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClassificationId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Classifacations", "CourseId", "dbo.Courses");
            DropIndex("dbo.Classifacations", new[] { "CourseId" });
            DropTable("dbo.Classifacations");
        }
    }
}
