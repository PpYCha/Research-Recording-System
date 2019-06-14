namespace ResearchRecordingSystemInCollegeOfScience.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateNoOfBook : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Borrows", "NoOfBookBorrowed", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Borrows", "NoOfBookBorrowed");
        }
    }
}
