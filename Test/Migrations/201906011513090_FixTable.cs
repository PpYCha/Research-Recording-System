namespace ResearchRecordingSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorName", c => c.String());
            DropColumn("dbo.Authors", "AuthorFName");
            DropColumn("dbo.Authors", "AuthorLName");
            DropColumn("dbo.Authors", "AuthorMName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Authors", "AuthorMName", c => c.String());
            AddColumn("dbo.Authors", "AuthorLName", c => c.String());
            AddColumn("dbo.Authors", "AuthorFName", c => c.String());
            DropColumn("dbo.Authors", "AuthorName");
        }
    }
}
