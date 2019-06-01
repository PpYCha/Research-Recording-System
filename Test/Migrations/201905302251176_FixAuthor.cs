namespace ResearchRecordingSystem.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class FixAuthor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorFName", c => c.String());
            AddColumn("dbo.Authors", "AuthorLName", c => c.String());
            AddColumn("dbo.Authors", "AuthorMName", c => c.String());
            AddColumn("dbo.Authors", "Gender", c => c.String());
            DropColumn("dbo.Authors", "AuthorName");
        }

        public override void Down()
        {
            AddColumn("dbo.Authors", "AuthorName", c => c.String());
            DropColumn("dbo.Authors", "Gender");
            DropColumn("dbo.Authors", "AuthorMName");
            DropColumn("dbo.Authors", "AuthorLName");
            DropColumn("dbo.Authors", "AuthorFName");
        }
    }
}
