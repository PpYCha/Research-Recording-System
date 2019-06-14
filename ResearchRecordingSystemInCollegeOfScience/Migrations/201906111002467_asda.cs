namespace ResearchRecordingSystemInCollegeOfScience.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResearchBooks", "AbstractEcopy", c => c.String());
            AddColumn("dbo.ResearchBooks", "ApprovalSheetEcopy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ResearchBooks", "ApprovalSheetEcopy");
            DropColumn("dbo.ResearchBooks", "AbstractEcopy");
        }
    }
}
