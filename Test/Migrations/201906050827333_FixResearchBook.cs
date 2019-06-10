namespace ResearchRecordingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixResearchBook : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ResearchBooks", "NumberOfCopies", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ResearchBooks", "NumberOfCopies", c => c.String());
        }
    }
}
