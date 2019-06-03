namespace ResearchRecordingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberOfCopies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ResearchBooks", "NumberOfCopies", c => c.String());
            DropColumn("dbo.ResearchBooks", "AbstractEcopyLoc");
            DropColumn("dbo.ResearchBooks", "ApprovalSheetLoc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ResearchBooks", "ApprovalSheetLoc", c => c.String());
            AddColumn("dbo.ResearchBooks", "AbstractEcopyLoc", c => c.String());
            DropColumn("dbo.ResearchBooks", "NumberOfCopies");
        }
    }
}
