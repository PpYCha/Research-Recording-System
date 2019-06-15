namespace ResearchRecordingSystemInCollegeOfScience.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updaraada1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ResearchBooks", "ClassificationId", "dbo.Classifacations");
            DropIndex("dbo.ResearchBooks", new[] { "ClassificationId" });
            AddColumn("dbo.ResearchBooks", "Classification", c => c.String());
            DropColumn("dbo.ResearchBooks", "ClassificationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ResearchBooks", "ClassificationId", c => c.Int());
            DropColumn("dbo.ResearchBooks", "Classification");
            CreateIndex("dbo.ResearchBooks", "ClassificationId");
            AddForeignKey("dbo.ResearchBooks", "ClassificationId", "dbo.Classifacations", "ClassificationId");
        }
    }
}
