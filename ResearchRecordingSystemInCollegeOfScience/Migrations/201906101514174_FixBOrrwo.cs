namespace ResearchRecordingSystemInCollegeOfScience.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixBOrrwo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Borrows", "BFullName", c => c.String());
            AddColumn("dbo.Borrows", "DateWillRetrun", c => c.DateTime());
            DropColumn("dbo.Borrows", "BFullaName");
            DropColumn("dbo.Borrows", "BookReturnedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Borrows", "BookReturnedDate", c => c.DateTime());
            AddColumn("dbo.Borrows", "BFullaName", c => c.String());
            DropColumn("dbo.Borrows", "DateWillRetrun");
            DropColumn("dbo.Borrows", "BFullName");
        }
    }
}
