namespace ResearchRecordingSystemInCollegeOfScience.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEcopy : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResearchBooks", "AbstractEcopyLoc", c => c.String());
            AddColumn("dbo.ResearchBooks", "ApprovalSheetLoc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ResearchBooks", "ApprovalSheetLoc");
            DropColumn("dbo.ResearchBooks", "AbstractEcopyLoc");
        }
    }
}
