namespace ResearchRecordingSystemInCollegeOfScience.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updaraada : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResearchBooks", "ClassificationId", c => c.Int());
            CreateIndex("dbo.ResearchBooks", "ClassificationId");
            AddForeignKey("dbo.ResearchBooks", "ClassificationId", "dbo.Classifacations", "ClassificationId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ResearchBooks", "ClassificationId", "dbo.Classifacations");
            DropIndex("dbo.ResearchBooks", new[] { "ClassificationId" });
            DropColumn("dbo.ResearchBooks", "ClassificationId");
        }
    }
}
